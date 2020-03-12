using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net;

namespace KR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Warehouse> wrhlist = new List<Warehouse>();
        List<Distributor> dislist = new List<Distributor>();
        List<object> list = new List<object>();

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Storage;Integrated Security=True";


            for (int i = 0; i < 9; i++)
            {
                list.Add(0);
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Заполняем список Складов
                SqlCommand command = new SqlCommand("SELECT * FROM Warehouses", connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        wrhlist.Add(new Warehouse((string)reader.GetValue(0), reader.GetValue(1), new List<Goods>()));
                    }
                }
                reader.Close();

                // Заполняем список поставщиков
                SqlCommand command2 = new SqlCommand("SELECT * FROM Distributors", connection);
                SqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.HasRows) // если есть данные
                {
                    while (reader2.Read()) // построчно считываем данные
                    {
                        dislist.Add(new Distributor((string)reader2.GetValue(0), (string)reader2.GetValue(1)));
                    }
                }
                reader2.Close();

                // Заполняем список товаров
                SqlCommand commandn = new SqlCommand("SELECT * FROM Goods", connection);
                SqlDataReader readern = commandn.ExecuteReader();

                if (readern.HasRows) // если есть данные
                {
                    while (readern.Read()) // построчно считываем данные
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            if (i == 7)
                                list[i] = dislist.Find(x => x.Id == (string)readern.GetValue(i));
                            else
                                list[i] = readern.GetValue(i);
                        }

                        for (int i = 0; i < wrhlist.Count; i++)
                        {
                            if (wrhlist[i].Id == (string)readern.GetValue(8))
                            {
                                Goods a = new Goods(list);
                                wrhlist[i].GoodsLst.Add(a);
                            }
                        }
                    }
                }
                readern.Close();

                
            }
            CtgCmbBox.Items.Add("*");
            MdlCmbBox.Items.Add("*");
            PrdCmbBox.Items.Add("*");
            WthCmbBox.Items.Add("*");


            for (int i = 0; i < wrhlist.Count; i++)
            {
                WrhCmbBox.Items.Add(wrhlist[i].Id);
            }

            WrhCmbBox.SelectedItem = WrhCmbBox.Items[0];
            object wrhsel = WrhCmbBox.SelectedItem;

            goodsBindingSource.DataSource = wrhlist.Find(x => x.Id == (string)wrhsel).GoodsLst;
        }

        public void Searching(string wrhsel, string ctgsel, string mdlsel, string prdsel, string wthsel)
        {
            List<Goods> list2 = new List<Goods>();
            List<Goods> list3 = new List<Goods>();

            list2 = wrhlist.Find(x => x.Id == (string)wrhsel).GoodsLst;
            int a;
            int.TryParse(wthsel, out a);

            list3 = list2.FindAll(x => (((ctgsel is "*") | (x.Categ == ctgsel)) &
                                        ((mdlsel is "*") | (x.Model == mdlsel)) &
                                        ((prdsel is "*") | (x.Producer == prdsel)) &
                                        ((wthsel is "*") | (x.Worth ==  a))));

            goodsBindingSource.DataSource = list3;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string wrhsel = (string)WrhCmbBox.Text;
            string ctgsel = (string)CtgCmbBox.Text;
            string mdlsel = (string)MdlCmbBox.Text;
            string prdsel = (string)PrdCmbBox.Text;
            string wthsel = (string)WthCmbBox.Text;

            Searching(wrhsel, ctgsel, mdlsel, prdsel, wthsel);
        }
    }
}

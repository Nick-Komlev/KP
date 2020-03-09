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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void DataRepr_Click(object sender, EventArgs e)
        {
            Form newfrm = new Form2();
            newfrm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Storage;Integrated Security=True";

            List<Warehouse> wrhlist = new List<Warehouse>();

            List<object> list = new List<object>();
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Warehouses", connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    
                    while (reader.Read()) // построчно считываем данные
                    {
                        wrhlist.Add(new Warehouse((string)reader.GetValue(0), reader.GetValue(1), new List<Goods>()));
                    }

                }

                reader.Close();

                SqlCommand command2 = new SqlCommand("SELECT * FROM Goods", connection);
                SqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.HasRows) // если есть данные
                {

                    while (reader2.Read()) // построчно считываем данные
                    {
                        list[0] = reader2.GetValue(0);
                        list[1] = reader2.GetValue(1);
                        list[2] = reader2.GetValue(2);
                        list[3] = reader2.GetValue(3);
                        list[4] = reader2.GetValue(4);
                        list[5] = reader2.GetValue(5);
                        list[6] = reader2.GetValue(6);
                        list[7] = reader2.GetValue(7);
                        list[8] = reader2.GetValue(8);

                        for (int i = 0; i < wrhlist.Count; i++)
                        {
                            if (wrhlist[i].Id == (string)reader2.GetValue(8))
                            {
                                Goods a = new Goods(list);
                                wrhlist[i].GoodsLst.Add(a);
                            }
                        }
                    }
                }
                goodsBindingSource.DataSource = wrhlist[0].GoodsLst;
            }

        }
    }

    class Warehouse
    {
        // Класс "склад". Содержит два поля:
        // Id - целочисленное значение, идентификационный номер склада.
        // GoodsLst - список содержащихся на складе товаров.

        public string Id { get; set; }
        public string Address { get; set; }
        public List<Goods> GoodsLst { get; set; }
        

        public Warehouse(string id, object addr, List<Goods> goods)
        {
            Id = id;
            if (addr is string)
                Address = (string)addr;
            GoodsLst = goods;
        }

        public override string ToString()
        {
            return string.Format("Склад номер: {0}", Id);
        }

    }

    class Distributor
    {
        // Класс "поставщик". Содержит два поля:
        // Id - целочисленное значение, идентификационный номер поставщика.
        // Name - строковое название компании поставщика.

        public int Id { get; set; }
        public string Name { get; set; }
        //==============================================================================================

        public Distributor(ArrayList list)
        {
            Id = Convert.ToInt32(list[0]);
            Name = (string)list[1];
        }
    }

    class Goods
    {
        // Класс "товар". Содержит восем полей:
        // Id - целочисленное значение, идентификационный номер товара.
        // Categ - строковое название категории.
        // Model - строковое название модели.
        // Producer - строковое название произодителя.
        // Worth - вещественное значение цены.
        // ArDate - дата поступления на склад.
        // InStock - булевское обозначение: "в наличии".
        // Distr - объекта класса поставщика.

        public string Id { get; set; }
        public string Categ { get; set; }
        public string Model { get; set; }
        public string Producer { get; set; }
        public int Worth { get; set; }
        public DateTime ArDate { get; set; }
        public bool InStock { get; set; }
        public string Distr { get; set; }
        public string WrhId { get; set; }
        //==============================================================================================

        public Goods(List<object> list)
        {
            Id = (string)(list[0]);
            Categ = (string)list[1];
            Model = (string)list[2];
            Producer = (string)list[3];
            Worth = Convert.ToInt32(list[4]);
            ArDate = DateTime.Parse(list[5].ToString());
            InStock = (bool)list[6];
            Distr = (string)list[7];
            WrhId = (string)(list[8]);
        }
        //==============================================================================================

        public override string ToString()
        {
            return string.Format("\nИдентификационный номер: {0}, \nкатегория товара: {1}, \nмодель: {2}," +
                " \nпроизводитель: {3}, \nцена: {4} р.", Id, Categ, Model, Producer, Worth);
        }
    }

    //class Microphone : Goods
    //{
    //    public string SysType { get; set; }
    //    public string Sence { get; set; }
    //    public int Resist { get; set; }
    //    //==============================================================================================

    //    public Microphone(ArrayList list) : base(list)
    //    {
    //        SysType = (string)list[8];
    //        Sence = (string)list[9];
    //        Resist = Convert.ToInt32(list[10]);

    //    }
    //    //==============================================================================================

    //    public override string ToString()
    //    {
    //        return string.Format("\nИдентификационный номер: {0}, \nкатегория товара: {1}, \nмодель: {2}," +
    //            " \nпроизводитель: {3}, \nцена: {4} р., \nтип системы: {5}," +
    //            " \nчувствительность (направленность): {6}, \nсопротивление: {7} Ом",
    //            Id, Categ, Model, Producer, Worth, SysType, Sence, Resist);
    //    }
    //}

    //class Speeckers : Goods
    //{
    //    public string SysType { get; set; }
    //    public int Power { get; set; }
    //    public int DynCount { get; set; }
    //    //==============================================================================================

    //    public Speeckers(ArrayList list) : base(list)
    //    {
    //        SysType = (string)list[8];
    //        Power = (int)list[9];
    //        DynCount = (int)list[10];
    //    }
    //    //==============================================================================================

    //    public override string ToString()
    //    {
    //        return string.Format("\nИдентификационный номер: {0}, \nкатегория товара: {1}, \nмодель: {2}," +
    //            " \nпроизводитель: {3}, \nцена: {4} р., \nтип системы: {5}, \nмощность: {6} дБ," +
    //            " \nколичество динамиков: {7}", Id, Categ, Model, Producer, Worth, SysType, Power, DynCount);
    //    }
    //}

    //class Players : Goods
    //{
    //    public string SysType { get; set; }
    //    public string Connect { get; set; }
    //    public double HarmDist { get; set; }
    //    //==============================================================================================

    //    public Players(ArrayList list) : base(list)
    //    {
    //        SysType = (string)list[8]; ;
    //        Connect = (string)list[9]; ;
    //        HarmDist = (double)list[10]; ;
    //    }
    //    //==============================================================================================

    //    public override string ToString()
    //    {
    //        return string.Format("\nИдентификационный номер: {0}, \nкатегория товара: {1}, \nмодель: {2}," +
    //            " \nпроизводитель: {3}, \nцена: {4} р., \nтип системы: {5}, \nспособы соединения: {6}," +
    //            " \nкоэффициент гармонического искажения: {7}%", Id, Categ, Model, Producer, Worth, SysType, Connect, HarmDist);
    //    }
    //}
}

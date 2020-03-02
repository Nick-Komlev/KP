using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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
    }

    class Warehouse
    {
        public int Id { get; set; }
        public List<Goods> Goods { get; set; }

        public Warehouse(int id, List<Goods> goods)
        {
            Id = id;
            Goods = goods;
        }

        public override string ToString()
        {
            return string.Format("Склад номер: {0}", Id);
        }

        public void Show_goods()
        {
            for (int i = 0; i < Goods.Count; i++)
            {

            }
        }
    }

    class Goods
    {
        public int Id { get; set; }
        public string Categ { get; set; }
        public string Model { get; set; }
        public string Producer { get; set; }
        public int Worth { get; set; }
        //==============================================================================================

        public Goods(ArrayList list)
        {
            Id = Convert.ToInt32(list[0]);
            Categ = (string)list[1];
            Model = (string)list[2];
            Producer = (string)list[3];
            Worth = Convert.ToInt32(list[4]);
        }
        //==============================================================================================

        public override string ToString()
        {
            return string.Format("\nИдентификационный номер: {0}, \nкатегория товара: {1}, \nмодель: {2}," +
                " \nпроизводитель: {3}, \nцена: {4} р.", Id, Categ, Model, Producer, Worth);
        }
    }

    class Microphone : Goods
    {
        public string SysType { get; set; }
        public string Sence { get; set; }
        public int Resist { get; set; }
        //==============================================================================================

        public Microphone(ArrayList list) : base(list)
        {
            SysType = (string)list[5];
            Sence = (string)list[6];
            Resist = Convert.ToInt32(list[7]);

        }
        //==============================================================================================

        public override string ToString()
        {
            return string.Format("\nИдентификационный номер: {0}, \nкатегория товара: {1}, \nмодель: {2}," +
                " \nпроизводитель: {3}, \nцена: {4} р., \nтип системы: {5}," +
                " \nчувствительность (направленность): {6}, \nсопротивление: {7} Ом",
                Id, Categ, Model, Producer, Worth, SysType, Sence, Resist);
        }
    }

    class Speeckers : Goods
    {
        public string SysType { get; set; }
        public int Power { get; set; }
        public int DynCount { get; set; }
        //==============================================================================================

        public Speeckers(ArrayList list) : base(list)
        {
            SysType = (string)list[5];
            Power = (int)list[6];
            DynCount = (int)list[7];
        }
        //==============================================================================================

        public override string ToString()
        {
            return string.Format("\nИдентификационный номер: {0}, \nкатегория товара: {1}, \nмодель: {2}," +
                " \nпроизводитель: {3}, \nцена: {4} р., \nтип системы: {5}, \nмощность: {6} дБ," +
                " \nколичество динамиков: {7}", Id, Categ, Model, Producer, Worth, SysType, Power, DynCount);
        }
    }

    class Players : Goods
    {
        public string SysType { get; set; }
        public string Connect { get; set; }
        public double HarmDist { get; set; }
        //==============================================================================================

        public Players(ArrayList list) : base(list)
        {
            SysType = (string)list[5]; ;
            Connect = (string)list[6]; ;
            HarmDist = (double)list[7]; ;
        }
        //==============================================================================================

        public override string ToString()
        {
            return string.Format("\nИдентификационный номер: {0}, \nкатегория товара: {1}, \nмодель: {2}," +
                " \nпроизводитель: {3}, \nцена: {4} р., \nтип системы: {5}, \nспособы соединения: {6}," +
                " \nкоэффициент гармонического искажения: {7}%", Id, Categ, Model, Producer, Worth, SysType, Connect, HarmDist);
        }
    }
}

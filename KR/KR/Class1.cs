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

        public string Id { get; set; }
        public string Name { get; set; }
        //==============================================================================================

        public Distributor(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
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
        public Distributor Distr { get; set; }
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
            Distr = (Distributor)list[7];
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

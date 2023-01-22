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
using System.IO;
using System.Reflection;

namespace KR
{
    public class Warehouse
    {
        //Класс "склад". Содержит три свойства:
        // Id - строковое значение, идентификационный номер склада.
        // Address - строковое значение адреса склада.
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
            return string.Format("{0}", Id.Substring(3));
        }

    }

    public class Distributor
    {
        // Класс "поставщик". Содержит два свойства:
        // Id - целочисленное значение, идентификационный номер поставщика.
        // Name - строковое название компании поставщика.

        public string Id { get; set; }
        public string Name { get; set; }

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

    public class Category
    {
        //Класс "категорий". Содержит два свойства:
        //Id - строковое значение, идентификационный номер категории товара.
        //Name - строковое название категории.

        public string Id { get; set; }
        public string Name { get; set; }

        public Category(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }

    public class Producer
    {
        //Класс "производителей". Содержит два свойства:
        // Id - строковое значение, идентификационный номер производителя.
        // Name - строковое название производителя.

        public string Id { get; set; }
        public string Name { get; set; }

        public Producer(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }

    public class Model
    {
        // Класс "моделей". Содержит четыре свойства:
        // Id - строковое значение, идентификационный номер модели.
        // Name - строковое название модели.
        // Ctg - экземпляр класса категории модели.
        // Prod - экземпляр класса производителя.

        public string Id { get; set; }
        public string Name { get; set; }
        public Category Categ { get; set; }
        public Producer Prod { get; set; }

        public Model(string id, string name, Category ctg, Producer prod)
        {
            Id = id;
            Name = name;
            Categ = ctg;
            Prod = prod;
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }

    public class Goods
    {
        //Класс "товар". Содержит восемь свойств:
        // Id - строковое значение, идентификационный номер товара.
        // Categ - экземпляр класса категории.
        // Model - экземпляр класса модели.
        // Producer - экземпляр класса произодителя.
        // Worth - вещественное значение цены.
        // ArDate - дата поступления на склад.
        // InStock - булевское обозначение: "в наличии".
        // Distr - экземпляр класса поставщика.

        public string Id { get; set; }
        public Category Categ { get; set; }
        public Model Mod { get; set; }
        public Producer Prod { get; set; }
        public double Worth { get; set; }
        public DateTime ArDate { get; set; }
        public bool InStock { get; set; }
        public Distributor Distr { get; set; }
        public Warehouse WrhId { get; set; }

        public Goods(string id, Category categ, Model mod, Producer prod, double worth, DateTime ardate, bool instock, Distributor distr, Warehouse wrhid)
        {
            Id = id;
            Categ = categ;
            Mod = mod;
            Prod = prod;
            Worth = worth;
            ArDate = ardate;
            InStock = instock;
            Distr = distr;
            WrhId = wrhid;
        }


        public override string ToString()
        {
            return string.Format("Идентификационный номер: {0}, \nкатегория товара: {1}, \nмодель: {2}," +
                " \nпроизводитель: {3}, \nцена: {4} р.\n", Id, Categ, Mod, Prod, Worth);
        }
    }

    public static class Singleton
    {
        //Статический класс предназначен для хранения всех данных,
        //над которыми проводятся операции (хранение, изменение, удаление, поиск)

        //Списки, содержащие все экземпляры всех классов
        public static List<Warehouse> wrhlist = new List<Warehouse>();
        public static List<Distributor> dislist = new List<Distributor>();
        public static List<Category> ctglist = new List<Category>();
        public static List<Producer> prolist = new List<Producer>();
        public static List<Model> modlist = new List<Model>();
        public static List<Goods> showlist = new List<Goods>();

        //Переменные, хранящие последнее значение идентификатора для каждого класса
        public static int wr_id = 0;
        public static int dis_id = 0;
        public static int ctg_id = 0;
        public static int pro_id = 0;
        public static int mod_id = 0;
        public static Dictionary<string, int> good_id = new Dictionary<string, int>();

        //Списки, содержащие элементы, которые ожидают, чтобы их добавили в БД, изменили и удалили из нее соответственно
        public static List<Goods> newgoodlist = new List<Goods>();
        public static List<Goods> chgoodlist = new List<Goods>();
        public static List<Goods> delgoodlist = new List<Goods>();

        public static List<Model> newmodlist = new List<Model>();
        public static List<Category> newctglist = new List<Category>();
        public static List<Producer> newprolist = new List<Producer>();
        public static List<Distributor> newdislist = new List<Distributor>();

        //Путь для подключения к серверу
        public static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Storage;Integrated Security=True";

        static Singleton()
        {
            // Заполняем списки данными из базы
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

                // Заполняем список категорий
                SqlCommand command3 = new SqlCommand("SELECT * FROM Categories", connection);
                SqlDataReader reader3 = command3.ExecuteReader();

                if (reader3.HasRows) // если есть данные
                {
                    while (reader3.Read()) // построчно считываем данные
                    {
                        ctglist.Add(new Category((string)reader3.GetValue(0), (string)reader3.GetValue(1)));
                    }
                }
                reader3.Close();

                // Заполняем список производителей
                SqlCommand command4 = new SqlCommand("SELECT * FROM Producers", connection);
                SqlDataReader reader4 = command4.ExecuteReader();

                if (reader4.HasRows) // если есть данные
                {
                    while (reader4.Read()) // построчно считываем данные
                    {
                        prolist.Add(new Producer((string)reader4.GetValue(0), (string)reader4.GetValue(1)));
                    }
                }
                reader4.Close();

                // Заполняем список моделей
                SqlCommand command5 = new SqlCommand("SELECT * FROM Models", connection);
                SqlDataReader reader5 = command5.ExecuteReader();

                if (reader5.HasRows) // если есть данные
                {
                    while (reader5.Read()) // построчно считываем данные
                    {
                        modlist.Add(new Model((string)reader5.GetValue(0), (string)reader5.GetValue(1),
                                                ctglist.Find(s => s.Id == (string)reader5.GetValue(2)),
                                                prolist.Find(s => s.Id == (string)reader5.GetValue(3))));
                    }
                }
                reader5.Close();

                // Заполняем список товаров
                SqlCommand commandn = new SqlCommand("SELECT * FROM Goods", connection);
                SqlDataReader readern = commandn.ExecuteReader();

                if (readern.HasRows) // если есть данные
                {
                    while (readern.Read()) // построчно считываем данные
                    {
                        wrhlist.Find(s => s.Id == (string)readern.GetValue(6)).GoodsLst.Add(new Goods((string)readern.GetValue(0),
                                                                                                       modlist.Find(s => s.Id == (string)readern.GetValue(1)).Categ,
                                                                                                       modlist.Find(s => s.Id == (string)readern.GetValue(1)),
                                                                                                       modlist.Find(s => s.Id == (string)readern.GetValue(1)).Prod,
                                                                                                       (double)readern.GetValue(2),
                                                                                                       (DateTime)readern.GetValue(3),
                                                                                                       (bool)readern.GetValue(4),
                                                                                                       dislist.Find(s => s.Id == (string)readern.GetValue(5)),
                                                                                                       wrhlist.Find(s => s.Id == (string)readern.GetValue(6))));
                    }
                }
                readern.Close();

                RefreshShowList();

                // Заполняем переменные с последними значениями идентификационных номеров
                for (int i = 0; i < wrhlist.Count; i++)
                {
                    if (Convert.ToInt32(wrhlist[i].Id.Substring(3)) > wr_id)
                        wr_id = Convert.ToInt32(wrhlist[i].Id.Substring(3));
                }
                for (int i = 0; i < dislist.Count; i++)
                {
                    if (Convert.ToInt32(dislist[i].Id.Substring(3)) > dis_id)
                        dis_id = Convert.ToInt32(dislist[i].Id.Substring(3));
                }
                for (int i = 0; i < ctglist.Count; i++)
                {
                    if (Convert.ToInt32(ctglist[i].Id.Substring(3)) > ctg_id)
                        ctg_id = Convert.ToInt32(ctglist[i].Id.Substring(3));
                }
                for (int i = 0; i < prolist.Count; i++)
                {
                    if (Convert.ToInt32(prolist[i].Id.Substring(3)) > pro_id)
                        pro_id = Convert.ToInt32(prolist[i].Id.Substring(3));
                }
                for (int i = 0; i < modlist.Count; i++)
                {
                    if (Convert.ToInt32(modlist[i].Id.Substring(3)) > mod_id)
                        mod_id = Convert.ToInt32(modlist[i].Id.Substring(3));
                }

                for (int i = 0; i < wrhlist.Count; i++)
                {
                    for (int j = 0; j < wrhlist[i].GoodsLst.Count; j++)
                    {
                        if (good_id.ContainsKey(wrhlist[i].GoodsLst[j].Id.Substring(0, 5)))
                        {
                            if (good_id[wrhlist[i].GoodsLst[j].Id.Substring(0, 5)] < Convert.ToInt32(wrhlist[i].GoodsLst[j].Id.Substring(5, 5)))
                                good_id[wrhlist[i].GoodsLst[j].Id.Substring(0, 5)] = Convert.ToInt32(wrhlist[i].GoodsLst[j].Id.Substring(5, 5));
                            else { };
                        }
                        else good_id.Add(wrhlist[i].GoodsLst[j].Id.Substring(0, 5), Convert.ToInt32(wrhlist[i].GoodsLst[j].Id.Substring(5, 5)));
                    }
                }
            }
        }

        public static void RefreshShowList()
        {
            //Функция обновления шоулиста, для вывода всех товаров со всех складов
            showlist.Clear();
            // Заполняем шоулист  (спсиок товаров для вывода)
            for (int i = 0; i < wrhlist.Count; i++)
            {
                for (int j = 0; j < wrhlist[i].GoodsLst.Count; j++)
                {
                    showlist.Add(wrhlist[i].GoodsLst[j]);
                }
            }
        }

        public static void TwoLevelSort(object lv1id, object lv2id, string sortmod1, string sortmod2, List<Goods> showlist)
        {
            //Метод двухуровневой сортировки
            //Получает на вход:
            //lv1id - объект, содержащий тэг первого столбца таблицы
            //lv2id - объект, содержащий тэг второго столбца таблицы
            //sortmod1 - число, (значение 1 или -1) обозначает порядок (по убыванию, по возрастанию) первого уровня
            //sortmod2 - число, (значение 1 или -1) обозначает порядок (по убыванию, по возрастанию) второго уровня
            //showlist - список товаров, который следует упорядочить

            PropertyInfo prop1 = typeof(Goods).GetProperties().FirstOrDefault(x => x.Name.Equals(lv1id));//Определяем свойство 1, равное тэгу 1 столбца таблицы
            PropertyInfo prop2 = typeof(Goods).GetProperties().FirstOrDefault(x => x.Name.Equals(lv2id));//Определяем свойство 2, равное тэгу 2 столбца таблицы

            double y;//понадобится для проверки TryParse

            bool check1 = double.TryParse(prop1.GetValue(showlist[0]).ToString(), out y) && prop1.Name != "WrhId"; //условие, для дальнейшей проверки 
            bool check2 = double.TryParse(prop2.GetValue(showlist[0]).ToString(), out y) && prop2.Name != "WrhId"; //(нечисловые значения в дальнейшем должны быть
                                                                                                                   // отсортированы по методы ToString())
            if (prop1 != null && prop2 != null)
                if (sortmod1 == "По убыванию")
                { //Собственно сортирвка с использованием методов расширения LINQ
                    if (sortmod2 == "По убыванию")
                        Singleton.showlist = showlist.OrderByDescending(a => check1 ? prop1.GetValue(a) : prop1.GetValue(a).ToString())
                                                     .ThenByDescending(s => check2 ? prop2.GetValue(s) : prop2.GetValue(s).ToString())
                                                     .ToList();
                    else
                        Singleton.showlist = showlist.OrderByDescending(a => check1 ? prop1.GetValue(a) : prop1.GetValue(a).ToString())
                                                     .ThenBy(s => check2 ? prop2.GetValue(s) : prop2.GetValue(s).ToString())
                                                     .ToList();
                }
                else
                {
                    if (sortmod2 == "По убыванию")
                        Singleton.showlist = showlist.OrderBy(a => check1 ? prop1.GetValue(a): prop1.GetValue(a).ToString())
                                                     .ThenByDescending(s => check2 ? prop2.GetValue(s) : prop2.GetValue(s).ToString())
                                                     .ToList();
                    else
                        Singleton.showlist = showlist.OrderBy(a => check1 ? prop1.GetValue(a) : prop1.GetValue(a).ToString())
                                                     .ThenBy(s => check2 ? prop2.GetValue(s) : prop2.GetValue(s).ToString())
                                                     .ToList();
                }
                showlist = Singleton.showlist;
        }

        public static List<Goods> OneLevelSort(object index, int sort, List<Goods> showlist)
        {
            //Метод одноуровневой сортировки
            //Получает на вход:
            //index - объект, содержащий тэг столбца таблицы
            //sort - число, (значение 1 или -1) обозначает порядок (по убыванию, по возрастанию)
            //showlist - список товаров, который следует упорядочить
            //Возвращает отсортированный список

            PropertyInfo prop1 = typeof(Goods).GetProperties().FirstOrDefault(x => x.Name.Equals(index)); //Определяем свойство, равное тэгу столбца таблицы

            double y; //понадобится для проверки TryParse

            bool check1 = double.TryParse(prop1.GetValue(showlist[0]).ToString(), out y) && prop1.Name != "WrhId"; //условие, для дальнейшей проверки 
                                                                                                                   //(нечисловые значения в дальнейшем должны быть
                                                                                                                   // отсортированы по методы ToString())
            //Собственно сортирвка с использованием методов расширения LINQ
            if (sort < 0)
                showlist = showlist.OrderBy(a => check1 ? prop1.GetValue(a) : prop1.GetValue(a).ToString()).ToList();
            else
                showlist = showlist.OrderByDescending(a => check1 ? prop1.GetValue(a) : prop1.GetValue(a).ToString()).ToList();

            return showlist;
        }

        public static void ChangeNew(string id, Category categ, Producer prod, Model mod, double worth, DateTime ardate, bool instock, Distributor distr)
        {
            //Функция для изменения нового товара (который еще не был добавлен в БД)
            //Принимает на вход идентификатор, категорию, производителя, модель, цену, дату поступления, наличие и поставщика
            var x = newgoodlist.Find(s => s.Id.ToString() == id);
            x.Categ = categ;
            x.Mod = mod;
            x.Prod = prod;
            x.Worth = worth;
            x.ArDate = ardate;
            x.InStock = instock;
            x.Distr = distr;
        }

        public static void ChangeGen(string id, Category categ, Producer prod, Model mod, double worth, DateTime ardate, bool instock, Distributor distr, Warehouse wrh)
        {
            //Функция для изменения существующего товара
            //Принимает на вход идентификатор, категорию, производителя, модель, цену, дату поступления, наличие, поставщика и номер склада
            var x = wrhlist.Find(s => s == wrh).GoodsLst.Find(u => u.Id == id);
            chgoodlist.Add(new Goods(x.Id, x.Categ, x.Mod, x.Prod, x.Worth, x.ArDate, x.InStock, x.Distr, x.WrhId));
            
            x.Categ = categ;
            x.Mod = mod;
            x.Prod = prod;
            x.Worth = worth;
            x.ArDate = ardate;
            x.InStock = instock;
            x.Distr = distr;
        }

        public static void DeleteNew(string id, string wrh)
        {
            //Функция для удаления нового товара
            //Принимает на вход идентификационный номер товара номер его склада
            wrhlist.Find(s => s.ToString() == wrh).GoodsLst.Remove(newgoodlist.Find(s => s.Id == id));
            newgoodlist.Remove(newgoodlist.Find(s => s.Id == id));
        }

        public static void DeleteGenNotChanged(string id, string wrh)
        {
            //Функция для удаления существующего товара, который НЕ был предварительно изменен
            //Принимает на вход идентификационный номер товара номер его склада
            var x = wrhlist.Find(s => s.ToString() == wrh).GoodsLst.Find(s => s.Id == id);
            delgoodlist.Add(new Goods(x.Id, x.Categ, x.Mod, x.Prod, x.Worth, x.ArDate, x.InStock, x.Distr, x.WrhId));
            wrhlist.Find(s => s.ToString() == wrh).GoodsLst.Remove(x);
        }

        public static void DeleteGenChanged(string id, string wrh)
        {
            //Функция для удаления существующего товара, который БЫЛ предварительно изменен
            //Принимает на вход идентификационный номер товара номер его склада
            var x = chgoodlist.Find(s => s.Id == id);
            delgoodlist.Add(new Goods(x.Id, x.Categ, x.Mod, x.Prod, x.Worth, x.ArDate, x.InStock, x.Distr, x.WrhId));
            chgoodlist.Remove(x);
            x = wrhlist.Find(s => s.ToString() == wrh).GoodsLst.Find(u => u.Id == id);
            wrhlist.Find(s => s.ToString() == wrh).GoodsLst.Remove(x);
        }

        public static void SaveChanges()
        {
            //Функция для сохранения всех проведенных изменений в БД
            if ((newgoodlist.Count > 0) | (chgoodlist.Count > 0) | (delgoodlist.Count > 0) |
                (newctglist.Count > 0) | (newdislist.Count > 0) | (newprolist.Count > 0) | (newmodlist.Count > 0))
            {
                DialogResult res = MessageBox.Show(
                "Внесенные измение невозможно будет отменить. Сохранить изменения?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

                if (res == DialogResult.Yes)
                {
                    string rep;
                    if (newctglist.Count > 0)
                    {
                        //Если были добавлены новые категории, они добавляются в БД
                        for (int i = 0; i < newctglist.Count; i++)
                        {
                            var x = newctglist[i];

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(String.Format("INSERT INTO Categories (ctg_id, ctg_name) VALUES ('{0}', '{1}')",
                                                                                  x.Id.ToString(), x.Name.ToString()), connection);
                                var a = command.ExecuteNonQuery();
                            }
                            rep = String.Format("{0} - Category added  - {1}", DateTime.Now, x.ToString());
                            Log(rep);
                        }
                    }
                    if (newdislist.Count > 0)
                    {
                        //Если были добавлены новые поставщики, они добавляются в БД
                        for (int i = 0; i < newdislist.Count; i++)
                        {
                            var x = newdislist[i];

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(String.Format("INSERT INTO Distributors (distr_id, distr_name) VALUES ('{0}', '{1}')",
                                                                                  x.Id.ToString(), x.Name.ToString()), connection);
                                var a = command.ExecuteNonQuery();
                            }
                            rep = String.Format("{0} - Distributor added  - {1}", DateTime.Now, x.ToString());
                            Log(rep);
                        }
                    }
                    if (newprolist.Count > 0)
                    {
                        //Если были добавлены новые производители, они добавляются в БД
                        for (int i = 0; i < newprolist.Count; i++)
                        {
                            var x = newprolist[i];

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(String.Format("INSERT INTO Producers (prod_id, prod_name) VALUES ('{0}', '{1}')",
                                                                                  x.Id.ToString(), x.Name.ToString()), connection);
                                var a = command.ExecuteNonQuery();
                            }
                            rep = String.Format("{0} - Producer added  - {1}", DateTime.Now, x.ToString());
                            Log(rep);
                        }
                    }
                    if (newmodlist.Count > 0)
                    {
                        //Если были добавлены новые модели, они добавляются в БД
                        for (int i = 0; i < newmodlist.Count; i++)
                        {
                            var x = newmodlist[i];

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(String.Format("INSERT INTO Models (mod_id, mod_name, ctg_id, prod_id) VALUES ('{0}', '{1}', '{2}', '{3}')",
                                                                                  x.Id.ToString(), x.Name.ToString(), x.Categ.Id.ToString(), x.Prod.Id.ToString()), connection);
                                var a = command.ExecuteNonQuery();
                            }
                            rep = String.Format("{0} - Model added  - {1}", DateTime.Now, x.ToString());
                            Log(rep);
                        }
                    }
                    if (newgoodlist.Count > 0)
                    {
                        //Если были добавлены новые товары, они добавляются в БД
                        for (int i = 0; i < newgoodlist.Count; i++)
                        {
                            var x = newgoodlist[i];

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(String.Format("INSERT INTO Goods (good_id, mod_id, worth, arrive_date, in_stock, distr_id, wrh_id) VALUES ('{0}', '{1}', {2}, '{3}', {4}, '{5}', '{6}')",
                                                                                  x.Id.ToString(), x.Mod.Id.ToString(), x.Worth.ToString(), x.ArDate.ToString("yyyy.MM.dd HH:mm:ss"), (Convert.ToInt32(x.InStock)).ToString(), x.Distr.Id.ToString(), x.WrhId.Id.ToString()), connection);
                                var a = command.ExecuteNonQuery();
                            }
                            rep = String.Format("{0} - Warehouse {1} - Good added  - {2}", DateTime.Now, x.WrhId.ToString(), x.ToString());
                            Log(rep);
                        }
                    }
                    if (chgoodlist.Count > 0)
                    {
                        //Если товары были изменены, изменения вносятся в БД
                        for (int i = 0; i < chgoodlist.Count; i++)
                        {
                            var x = wrhlist.Find(s => s == chgoodlist[i].WrhId).GoodsLst.Find(u => u.Id == chgoodlist[i].Id);

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(String.Format("UPDATE Goods SET mod_id='{1}', worth={2}, arrive_date='{3}', in_stock={4}, distr_id='{5}' WHERE good_id='{0}'",
                                                                                  x.Id.ToString(), x.Mod.Id.ToString(), x.Worth.ToString(), x.ArDate.ToString("yyyy.MM.dd HH:mm:ss"), (Convert.ToInt32(x.InStock)).ToString(), x.Distr.Id.ToString()), connection);
                                var a = command.ExecuteNonQuery();
                            }
                            rep = String.Format("{0} - Warehouse {1} - Good changed - {2}", DateTime.Now, x.WrhId.ToString(), x.ToString());
                            Log(rep);
                        }
                    }
                    if (delgoodlist.Count > 0)
                    {
                        //Если товары были удалены, эти товары удаляются из БД
                        for (int i = 0; i < delgoodlist.Count; i++)
                        {
                            var x = delgoodlist[i];

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(String.Format("DELETE FROM Goods WHERE good_id='{0}'",
                                                                                  x.Id.ToString()), connection);
                                var a = command.ExecuteNonQuery();
                            }
                            rep = String.Format("{0} - Warehouse {1} - Good deleted - {2}", DateTime.Now, x.WrhId.ToString(), x.ToString());
                            Log(rep);
                        }
                    }
                    MessageBox.Show(
                        String.Format("Добавлено записей: {0}\nИзменено записей: {1}\nУдалено записей: {2}",
                        newgoodlist.Count + newmodlist.Count + newctglist.Count + newdislist.Count + newprolist.Count, chgoodlist.Count, delgoodlist.Count),
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);

                    newgoodlist.Clear();
                    chgoodlist.Clear();
                    delgoodlist.Clear();
                    newctglist.Clear();
                    newdislist.Clear();
                    newprolist.Clear();
                    newmodlist.Clear();
                }
            }
            else
                MessageBox.Show(
                    "Изменений не внесено",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
        }

        public static void CancelChanges()
        {
            //Функция для отмены всех проведенных изменений
            DialogResult res = MessageBox.Show(
                "Несохраненные измениния будут потеряны. Отменить изменения?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (res == DialogResult.Yes)
            { 
                //Удаление всех новых товаров из списков
                for (int i = 0; i < wrhlist.Count; i++)
                {
                    for (int j = 0; j < wrhlist[i].GoodsLst.Count; j++)
                    {
                        if (newgoodlist.Find(s => wrhlist[i].GoodsLst[j].Id == s.Id) == wrhlist[i].GoodsLst[j])
                        {
                            wrhlist[i].GoodsLst.RemoveAt(j);
                            j -= 1;
                        }
                    }
                }
                //Возвращение измененных товаров к первоначальному виду
                for (int i = 0; i < chgoodlist.Count; i++)
                {
                    var x = wrhlist.Find(s => s.Id == chgoodlist[i].WrhId.Id).GoodsLst.Find(u => u.Id == chgoodlist[i].Id);
                    wrhlist.Find(s => s.Id == chgoodlist[i].WrhId.Id).GoodsLst.Remove(x);
                    x = chgoodlist[i];
                    wrhlist.Find(s => s.Id == chgoodlist[i].WrhId.Id).GoodsLst.Add(new Goods(x.Id, x.Categ, x.Mod, x.Prod, x.Worth, x.ArDate, x.InStock, x.Distr, x.WrhId));
                }
                //Возвращение в списки удаленных товаров
                for (int i = 0; i < delgoodlist.Count; i++)
                {
                    var x = delgoodlist[i];
                    wrhlist.Find(s => s.Id == delgoodlist[i].WrhId.Id).GoodsLst.Add(new Goods(x.Id, x.Categ, x.Mod, x.Prod, x.Worth, x.ArDate, x.InStock, x.Distr, x.WrhId));
                }
                //Удаление всех новых моделей из списков
                for (int i = 0; i < newmodlist.Count; i++)
                {
                    modlist.Remove(modlist.Find(s => s.Id == newmodlist[i].Id));
                }
                //Удаление всех новых категорий из списков
                for (int i = 0; i < newctglist.Count; i++)
                {
                    ctglist.Remove(ctglist.Find(s => s.Id == newctglist[i].Id));
                }
                //Удаление всех новых поставщиков из списков
                for (int i = 0; i < newdislist.Count; i++)
                {
                    dislist.Remove(dislist.Find(s => s.Id == newdislist[i].Id));
                }
                //Удаление всех новых производителей из списков
                for (int i = 0; i < newprolist.Count; i++)
                {
                    prolist.Remove(prolist.Find(s => s.Id == newprolist[i].Id));
                }
                
                newgoodlist.Clear();
                chgoodlist.Clear();
                delgoodlist.Clear();
                newctglist.Clear();
                newdislist.Clear();
                newprolist.Clear();
                newmodlist.Clear();
            }
        }

        public static void Exit()
        {
            //Функция закрытия приложения
            DialogResult res = MessageBox.Show(
                "Несохраненные изменения будут потеряны. Закрыть проект?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (res == DialogResult.Yes)
                Application.Exit();
        }

        public static void Log(string message)
        {
            File.AppendAllText("log.txt", message + "\n");
        }
    }
}

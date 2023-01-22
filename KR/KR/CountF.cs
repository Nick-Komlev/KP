using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using NPOI.XWPF.UserModel;


namespace KR
{
    public partial class CountF : Form
    {
        //Форма Подсчет
        //Можно перейти к формированию отчета, перейти назад на форму Учета
        bool nochanges = true;
        List<string> defaultlst = new List<string>(); //Список с обязательными пунктами составления отчета
        string wrh, ctg, id, mod, dis, pro, wthfr, wthto, datfr, datto;

        public CountF(string wrh_, string ctg_, string id_, string mod_, string dis_, string pro_, string wthfr_, string wthto_, string datfr_, string datto_)
        {
            //Передаем информацию с предыдущей формы о заданных фильтрах
            InitializeComponent();
            wrh = wrh_ == "*" ? "Все" : wrh_;
            ctg = ctg_ == "*" ? "Все" : ctg_;
            id = id_ == "*" ? "Все" : id_;
            mod = mod_ == "*" ? "Все" : mod_;
            dis = dis_ == "*" ? "Все" : dis_;
            pro = pro_ == "*" ? "Все" : pro_;
            wthfr = wthfr_ == "*" ? "0" : wthfr_;
            wthto = wthto_ == "*" ? "..." : wthto_;
            datfr = datfr_;
            datto = datto_;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Выводим начальную информацию
            if (InfCmbBox.Text == "Количество товара")
                InfLbl.Text += Singleton.showlist.Count.ToString();
            //Заполняем список обязательными пунктами
            for (int i = 0; i < ListBox.Items.Count; i++)
            {
                defaultlst.Add(ListBox.Items[i].ToString());
            }

        }

        private void InfCmbBox_TextChanged(object sender, EventArgs e)
        {
            //При выборе определенного пункта выводится соответствующая информация
            if (!InfCmbBox.Items.Contains(InfCmbBox.Text))
            {
                InfCmbBox.Text = "Количество товара";
                Msg1();
            }
            else
            {
                InfLbl.Text = "Вывод: ";
                InfLbl.Text += TextSwitch(InfCmbBox.Text);
            }
        }        

        public string TextSwitch(string inc)
        {
            //Функция формирования ответа по соответствующему пункту
            //принимает текстовое значение пункта
            string res = "";
            switch (inc)
            {
                case "Количество товара":
                    res += Singleton.showlist.Count.ToString();
                    break;
                case "Средняя цена":
                    res += Math.Round(Singleton.showlist.Average(s => s.Worth), 2);
                    break;
                case "Сумма цен":
                    res += Singleton.showlist.Sum(s => s.Worth);
                    break;
                case "Товара в наличии":
                    res += Singleton.showlist.Count(s => s.InStock == true);
                    break;
                case "Самый дорогостоящий товар":
                    res += Singleton.showlist.Find(s => s.Worth == Singleton.showlist.Max(u => u.Worth)).ToString();
                    break;
                case "Самый дешевый товар":
                    res += Singleton.showlist.Find(s => s.Worth == Singleton.showlist.Min(u => u.Worth)).ToString();
                    break;
                case "Список товаров":
                    res += "Будет предоставлен список...";
                    break;
            }
            return res;
        }

        private void AddInfBtn_Click(object sender, EventArgs e)
        {
            //По нажатию кнопки, пункт расчета отобразится в списке
            nochanges = false;
            if (!ListBox.Items.Contains(InfCmbBox.Text))
                ListBox.Items.Add(InfCmbBox.Text);
            else Msg2();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //Удаляет указанный пункт расчета
            try
            {
                if (!defaultlst.Contains(ListBox.SelectedItem.ToString()))
                    ListBox.Items.RemoveAt(ListBox.SelectedIndex);
                else Msg3();
            }
            catch
            {
                Msg3();
            }
        }

        private void BinBtn_Click(object sender, EventArgs e)
        {
            //Очищает список от необязательных пунктов
            int i = 0;
            while (i < ListBox.Items.Count)
            { 
                if (!defaultlst.Contains(ListBox.Items[i]))
                {
                    ListBox.Items.RemoveAt(i);
                    i -= 1;
                }
                i += 1;  
            }
        }

        private void FormRepBtn_Click(object sender, EventArgs e)
        {
            //Функция для формирования отчета
            string report = String.Format("Склад: {0}\n\n\nИдентификационные номер: {1}\nКатегория: {2}\nМодель: {3}\nПроизводитель: {4}\nПоставщик: {5}\n" +
                          "Время поступления: с {6} по {7}\nДиапазон цен: от {8} до {9}", wrh, ctg, id, mod, dis, pro, datfr, datto, wthfr, wthto);
            for (int i = 0; i < ListBox.Items.Count; i++)
            {
                if (!defaultlst.Contains(ListBox.Items[i].ToString()) & ListBox.Items[i].ToString() != "Список товаров")
                {
                    report += String.Format("\n{0}: {1}", ListBox.Items[i].ToString(), TextSwitch(ListBox.Items[i].ToString()));
                }
                else if (ListBox.Items[i].ToString() == "Список товаров")
                {
                    report += "\nСписок товаров:";
                    for (int j = 0; j < Singleton.showlist.Count; j++)
                    {
                        report += String.Format("\n{0}. {1}", j, Singleton.showlist[j].ToString());
                    }
                }
            }
            report += String.Format("\n\n\nОтчет от {0}", DateTime.Now);

            File.Delete("rep.txt");
            using (FileStream fs = new FileStream("rep.txt", FileMode.OpenOrCreate))
            {
                byte[] x = Encoding.Default.GetBytes(report);
                fs.Write(x, 0, x.Length);
            }
            System.Diagnostics.Process.Start("notepad.exe", "rep.txt");
        }

        public void Msg1()
        {
            MessageBox.Show(
                    "Некорректный ввод",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
        }

        public void Msg2()
        {
            MessageBox.Show(
                    "Данная операция уже имеется в списке",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
        }

        public void Msg3()
        {
            MessageBox.Show(
                    "Следует выбрать необязательный элемент отчета",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Закрываем форму
            DialogResult = DialogResult.OK;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Убеждаемся, хотим ли закрыть форму
            if (!nochanges)
            {
                DialogResult result = MessageBox.Show(
                    "Есть несохраненные данные. Закрыть?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                if (result != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
    }
}

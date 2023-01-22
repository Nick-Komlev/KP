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
using System.Windows.Input;

namespace KR
{
    public partial class AccountF : Form
    {
        //Форма Учета товара. Получает ссылку на домашнюю форму
        //Можно перейти на форму Подсчет, вернуться на домашнюю форму
        Form1 oldfrm;

        int transit = 0; //для определения окрываемой формы для перехода

        int sort = -1;
        int lastsortind = 0; //столбец для одноуровневой сортировки
        bool isonesort = true; //проверка на то, выделен ли столбец для одноуровневой сортировки
        int firstlevelind; //первый столбец для двухуровнеой сортировки
        bool istwofirst = false; //проверка на то, выделен ли первый столбец для двухуровневой сортировки
        int secondlevelind; //второй столбец для двухуровнеой сортировки
        bool istwosecond = false; //проверка на то, выделен ли второй столбец для двухуровневой сортировки

        public string level1sort = "По убыванию"; //параметр первого уровня сортировки
        public string level2sort = "По убыванию"; //параметр первого уровня сортировки

        public AccountF(Form1 oldfrm_)
        {
            InitializeComponent();
            //Получаем ссылку на предыдущую форму
            oldfrm = oldfrm_;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GGds.Columns[0].Tag = "Id";
            GGds.Columns[1].Tag = "Categ";
            GGds.Columns[2].Tag = "Mod";
            GGds.Columns[3].Tag = "Prod";
            GGds.Columns[4].Tag = "Worth";
            GGds.Columns[5].Tag = "ArDate";
            GGds.Columns[6].Tag = "InStock";
            GGds.Columns[7].Tag = "Distr";
            GGds.Columns[8].Tag = "WrhId";


            // Устанавливаем "начальные значения" в комбобоксах
            CtgCmbBox.Items.Add("*");
            MdlCmbBox.Items.Add("*");
            PrdCmbBox.Items.Add("*");
            DisCmbBox.Items.Add("*");
            WthFromCmbBox.Items.Add("*");
            WthToCmbBox.Items.Add("*");
            WrhCmbBox.Items.Add("*");

            GGds.EnableHeadersVisualStyles = false;
            GGds.Columns[0].HeaderText += "↓";
            GGds.Columns[0].HeaderCell.Style.BackColor = Color.Aqua;

            // Заполняем комбобоксы для поиска
            for (int i = 0; i < Singleton.wrhlist.Count; i++)
            {
                WrhCmbBox.Items.Add(Singleton.wrhlist[i].ToString());
            }
            for (int i = 0; i < Singleton.ctglist.Count; i++)
            {
                CtgCmbBox.Items.Add(Singleton.ctglist[i].ToString());
            }
            for (int i = 0; i < Singleton.modlist.Count; i++)
            {
                MdlCmbBox.Items.Add(Singleton.modlist[i].ToString());
            }
            for (int i = 0; i < Singleton.prolist.Count; i++)
            {
                PrdCmbBox.Items.Add(Singleton.prolist[i].ToString());
            }
            for (int i = 0; i < Singleton.dislist.Count; i++)
            {
                DisCmbBox.Items.Add(Singleton.dislist[i].ToString());
            }
            // Заполняем шоулист  (спсиок товаров для вывода)
            Singleton.RefreshShowList();

            goodsBindingSource.DataSource = Singleton.showlist;
        }

        private void GGds_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Выполняем "покрас" таблицы
            for (int i = 0; i < GGds.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    GGds.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(190, 224, 238);
                else
                    GGds.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(250, 246, 228);

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Заполняем переменные данными из элементов поиска
                if (IdTxtBox.Text.Length <= 0)
                    IdTxtBox.Text = "*";
                DateTime dtfsel = DatePickFrom.Value;
                DateTime dttsel = DatePickTo.Value;
                string idsel = IdTxtBox.Text;
                string wrhsel = WrhCmbBox.Text;
                string ctgsel = CtgCmbBox.Text;
                string mdlsel = MdlCmbBox.Text;
                string prdsel = PrdCmbBox.Text;
                string dissel = DisCmbBox.Text;
                double wthfsel;
                double wthtsel;

                if (WthFromCmbBox.Text is "*") wthfsel = 0;
                else wthfsel = Convert.ToDouble(WthFromCmbBox.Text);

                if (WthToCmbBox.Text is "*") wthtsel = 999999999;
                else wthtsel = Convert.ToDouble(WthToCmbBox.Text);

                //Передаем данные в функцию поиска
                Searching(idsel, wrhsel, ctgsel, mdlsel, prdsel, dissel, wthfsel, wthtsel, dtfsel, dttsel);
            }

            catch
            {
                //В случае некорректно введенных данных
                MessageBox.Show(
                    "Некорректный ввод",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void GGds_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (Control.ModifierKeys == Keys.Control)
            {
                // Многоуровневая сортировка по нажатии на имя столбца с зажатой клавишей Ctrl
                if (isonesort)
                {
                    //Если до этого была выбрана одноуровневая сорторовка
                    ChangeSelection(lastsortind, 1);
                    isonesort = false;

                    firstlevelind = e.ColumnIndex;
                    GGds.Columns[firstlevelind].HeaderCell.Style.BackColor = Color.Tomato;
                    GGds.Columns[firstlevelind].HeaderText += "(1)";
                    istwofirst = true;
                    goodsBindingSource.ResetBindings(false);
                }
                else if (!istwosecond & e.ColumnIndex != firstlevelind)
                {
                    //Если до этого был выбран только первый столбец для двухуровневой сортировки
                    secondlevelind = e.ColumnIndex;
                    GGds.Columns[secondlevelind].HeaderCell.Style.BackColor = Color.Tomato;
                    GGds.Columns[secondlevelind].HeaderText += "(2)";
                    istwosecond = true;
                    Singleton.TwoLevelSort(GGds.Columns[firstlevelind].Tag, GGds.Columns[secondlevelind].Tag, level1sort, level2sort, Singleton.showlist);
                    goodsBindingSource.DataSource = Singleton.showlist;
                }
                else
                {
                    //Если до этого был выбрана двухуровневая сортировка
                    ChangeSelection(firstlevelind, 3);
                    if (istwosecond)
                    {
                        ChangeSelection(secondlevelind, 3);
                        istwosecond = false;
                    }

                    firstlevelind = e.ColumnIndex;
                    GGds.Columns[firstlevelind].HeaderCell.Style.BackColor = Color.Tomato;
                    GGds.Columns[firstlevelind].HeaderText += "(1)";
                    istwofirst = true;
                    goodsBindingSource.ResetBindings(false);
                }
                
            }
            else
            {
                // Одноуровневая сортировка по нажатии на имя столбца
                if (isonesort)
                {
                    //Если до этого была выбрана одноуровневая сортировка
                    ChangeSelection(lastsortind, 1);
                    isonesort = false;
                }
                else
                {
                    //Если до этого была выбрана двухуровневая сортировка
                    ChangeSelection(firstlevelind, 3);
                    istwofirst = false;
                    if (istwosecond)
                    {
                        ChangeSelection(secondlevelind, 3);
                        istwosecond = false;
                    }
                        
                }
                sort *= -1;
                if (sort > 0)
                    GGds.Columns[e.ColumnIndex].HeaderText += "↑";
                else
                    GGds.Columns[e.ColumnIndex].HeaderText += "↓";
                //Собственно сортировка
                Singleton.showlist = Singleton.OneLevelSort(GGds.Columns[e.ColumnIndex].Tag, sort, Singleton.showlist);
                
                lastsortind = e.ColumnIndex;
                GGds.Columns[lastsortind].HeaderCell.Style.BackColor = Color.Aqua;
                goodsBindingSource.DataSource = Singleton.showlist;
                isonesort = true;
            }
        }

        private void ChangeSelection(int i, int z)
        {
            //Функция для очистки предыдущего выделения столбцов
            var x = GGds.Columns[i].HeaderText;
            GGds.Columns[i].HeaderText = x.Substring(0, x.Length - z);
            GGds.Columns[i].HeaderCell.Style.BackColor = DefaultBackColor;
        }

        public void Searching(string idsel, string wrhsel, string ctgsel, string mdlsel, string prdsel,
                                string dissel, double wthfsel, double wthtsel, DateTime dtfsel, DateTime dttsel)
        {
            //Функция поиска данных
            //принимает на вход информацию, взятую из элементов поиска:
            //идентификационный номер, номер склада, номер категории, номер модели, номер производителя,
            //номер поставщика, левая граница цены, правая граница цены,
            //левая граница времени прибытия, правая граница времени прибытия

            // Поиск данных по данным фильтров и заполнения шоулиста
            List<Goods> searchlist = new List<Goods>();
            Goods x;

            if (wrhsel == "*")
            {
                // Прогон всех складов и всех товаров
                for (int i = 0; i < Singleton.wrhlist.Count; i++)
                {
                    for (int j = 0; j < Singleton.wrhlist[i].GoodsLst.Count; j++)
                    {
                        x = Singleton.wrhlist[i].GoodsLst[j];

                        // Проверка всех полей на данные из поиска
                        if (((idsel is "*") | (idsel == x.Id)) &
                            ((ctgsel is "*") | (ctgsel == x.Categ.ToString())) &
                            ((mdlsel is "*") | (mdlsel == x.Mod.ToString())) &
                            ((prdsel is "*") | (prdsel == x.Prod.ToString())) &
                            ((dissel is "*") | (dissel == x.Distr.ToString())) &
                            ((x.Worth <= wthtsel) & (x.Worth >= wthfsel)) &
                            ((x.ArDate <= dttsel) & (x.ArDate >= dtfsel))
                            ) searchlist.Add(Singleton.wrhlist[i].GoodsLst[j]);
                    }
                }
            }
            else
            {
                // Прогон всех товаров определенного склада
                for (int j = 0; j < Singleton.wrhlist.Find(s => s.ToString() == wrhsel).GoodsLst.Count; j++)
                {
                    x = Singleton.wrhlist.Find(s => s.ToString() == wrhsel).GoodsLst[j];

                    // Проверка всех полей на данные из поиска
                    if (((idsel is "*") | (idsel == x.Id)) &
                        ((ctgsel is "*") | (ctgsel == x.Categ.ToString())) &
                        ((mdlsel is "*") | (mdlsel == x.Mod.ToString())) &
                        ((prdsel is "*") | (prdsel == x.Prod.ToString())) &
                        ((dissel is "*") | (dissel == x.Distr.ToString())) &
                        ((x.Worth <= wthtsel) & (x.Worth >= wthfsel)) &
                        ((x.ArDate <= dttsel) & (x.ArDate >= dtfsel))) searchlist.Add(x);
                }

            }
            Singleton.showlist = searchlist;

            goodsBindingSource.DataSource = Singleton.showlist;
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            //Переход на форму подсчета
            Form newfrm = new CountF(WrhCmbBox.Text, CtgCmbBox.Text, IdTxtBox.Text, MdlCmbBox.Text, DisCmbBox.Text, 
                                    PrdCmbBox.Text, WthFromCmbBox.Text, WthToCmbBox.Text, DatePickFrom.Value.ToString(),
                                    DatePickTo.Value.ToString());
            newfrm.ShowDialog();
        }

        private void SaveStrip_Click(object sender, EventArgs e)
        {
            //Сохраняем изменения
            Singleton.SaveChanges();
        }

        private void ExitStrip_Click(object sender, EventArgs e)
        {
            //Закрываем приложение
            Singleton.Exit();
        }

        private void CancelStrip_Click(object sender, EventArgs e)
        {
            //Отменяем изменения
            Singleton.CancelChanges();
            Singleton.RefreshShowList();
            SearchBtn.PerformClick();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Указываем маршрут к главной
            transit = 0;
            //Закрываем форму
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Указываем путь
            oldfrm.transit = transit;
            //Возвращаемся на форму назад
            oldfrm.Show();
        }

        private void ОбАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал студент 2-го курса группы ПИ18-3 Комлев Н.П.",
                "Версия 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "info.txt");
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            //Переход к форме настройки двухуровневой сортировки
            Form newfrm = new SortF(this, null);
            newfrm.ShowDialog();
        }

        private void ГлавнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Указываем маршрут к главной
            transit = 0;
            //Закрываем форму
            this.Close();
        }

        private void УправлениеСкладыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Указываем маршрут к складам
            transit = 2;
            //Закрываем форму
            this.Close();
        }
    }
}

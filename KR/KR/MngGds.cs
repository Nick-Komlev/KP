using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    public partial class MngGds : Form
    {
        //Форма Управление данными: Товары
        //Можно перейти к форме добавления объектов, форме изменения товара, возвратиться на форму Управление данными: Склады
        readonly MngWrh oldfrm;

        List<Goods> showsearchlist = new List<Goods>();
        string wrh;
        int sort1 = -1;
        int sort2 = -1;

        int transit = 3;

        int lastsortind1 = 0; //столбец для одноуровневой сортировки первой таблицы
        bool isonesort1 = true; //проверка на то, выделен ли столбец для одноуровневой сортировки первой таблицы
        int firstlevelind1; //первый столбец для двухуровнеой сортировки первой таблицы
        bool istwofirst1 = false; //проверка на то, выделен ли первый столбец для двухуровневой сортировки первой таблицы
        int secondlevelind1; //второй столбец для двухуровнеой сортировки первой таблицы
        bool istwosecond1 = false; //проверка на то, выделен ли второй столбец для двухуровневой сортировки первой таблицы

        public string level1sort = "По убыванию"; //параметр первого уровня сортировки
        public string level2sort = "По убыванию"; //параметр первого уровня сортировки

        int lastsortind2 = 0; //столбец для одноуровневой сортировки второй таблицы


        public MngGds(MngWrh oldfrm_, string wrh_)
        {
            InitializeComponent();
            //Получаем ссылку на предыдущую форму
            oldfrm = oldfrm_;
            //Получаем информацию о том, с каким складом работаем
            wrh = wrh_;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //Заполняем таблицу
            RefreshShowList();
            goodsBindingSource.DataSource = Singleton.showlist;
            //Заполняем комбобокс для поиска
            ModCmbBx.Items.Add("*");
            for (int i = 0; i < Singleton.modlist.Count; i++)
            {
                ModCmbBx.Items.Add(Singleton.modlist[i].ToString());
            }
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView1.Columns[0].HeaderText += "↓";
            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.Aqua;
            dataGridView2.Columns[0].HeaderText += "↓";
            dataGridView2.Columns[0].HeaderCell.Style.BackColor = Color.Aqua;

            dataGridView1.Columns[0].Tag = "Id";
            dataGridView1.Columns[1].Tag = "Categ";
            dataGridView1.Columns[2].Tag = "Mod";
            dataGridView1.Columns[3].Tag = "Prod";
            dataGridView1.Columns[4].Tag = "Worth";
            dataGridView1.Columns[5].Tag = "ArDate";
            dataGridView1.Columns[6].Tag = "InStock";
            dataGridView1.Columns[7].Tag = "Distr";
            dataGridView1.Columns[8].Tag = "WrhId";

            dataGridView2.Columns[0].Tag = "Id";
            dataGridView2.Columns[1].Tag = "Categ";
            dataGridView2.Columns[2].Tag = "Mod";
            dataGridView2.Columns[3].Tag = "Prod";
            dataGridView2.Columns[4].Tag = "Worth";
            dataGridView2.Columns[5].Tag = "ArDate";
            dataGridView2.Columns[6].Tag = "InStock";
            dataGridView2.Columns[7].Tag = "Distr";
            dataGridView2.Columns[8].Tag = "WrhId";
        }

        public void RefreshShowList()
        {
            //Функция для отображения всех товаров из данного склада
            var x = Singleton.wrhlist.Find(s => s.ToString() == wrh);
            Singleton.showlist.Clear();
            for (int i = 0; i < x.GoodsLst.Count; i++)
            {
                Singleton.showlist.Add(x.GoodsLst[i]);
            }
        }

        private void AddGoodBtn_Click(object sender, EventArgs e)
        {
            //Действия по нажатию на "Добавить", переход на новую форму
            Form newfrm = new ChAdd(this, wrh);
            newfrm.ShowDialog();
            RefreshShowList();
            goodsBindingSource.ResetBindings(false);
            

            ModCmbBx.Items.Clear();
            ModCmbBx.Items.Add("*");
            ModCmbBx.Text = "*";
            for (int i = 0; i < Singleton.modlist.Count; i++)
            {
                ModCmbBx.Items.Add(Singleton.modlist[i].ToString());
            }

            if (showsearchlist.Count > 0)
                SearchBtn.PerformClick();
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
            RefreshShowList();
            goodsBindingSource.ResetBindings(false);
            if (showsearchlist.Count > 0)
                SearchBtn.PerformClick();
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Выполняем "покрас" таблицы
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(190, 224, 238);
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(250, 246, 228);

            }
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                // Многоуровневая сортировка по нажатию на имя столбца с зажатой клавишей Ctrl
                if (isonesort1)
                {
                    //Если до этого была выбрана одноуровневая сорторовка
                    ChangeSelection1(lastsortind1, 1);
                    isonesort1 = false;

                    firstlevelind1 = e.ColumnIndex;
                    dataGridView1.Columns[firstlevelind1].HeaderCell.Style.BackColor = Color.Tomato;
                    dataGridView1.Columns[firstlevelind1].HeaderText += "(1)";
                    istwofirst1 = true;
                    goodsBindingSource.ResetBindings(false);
                }
                else if (!istwosecond1 & e.ColumnIndex != firstlevelind1)
                {
                    //Если до этого был выбран только первый столбец для двухуровневой сортировки
                    secondlevelind1 = e.ColumnIndex;
                    dataGridView1.Columns[secondlevelind1].HeaderCell.Style.BackColor = Color.Tomato;
                    dataGridView1.Columns[secondlevelind1].HeaderText += "(2)";
                    istwosecond1 = true;
                    Singleton.TwoLevelSort(dataGridView1.Columns[firstlevelind1].Tag, dataGridView1.Columns[secondlevelind1].Tag, level1sort, level2sort, Singleton.showlist);
                    goodsBindingSource.DataSource = Singleton.showlist;
                }
                else
                {
                    //Если до этого был выбрана двухуровневая сортировка
                    ChangeSelection1(firstlevelind1, 3);
                    if (istwosecond1)
                    {
                        ChangeSelection1(secondlevelind1, 3);
                        istwosecond1 = false;
                    }

                    firstlevelind1 = e.ColumnIndex;
                    dataGridView1.Columns[firstlevelind1].HeaderCell.Style.BackColor = Color.Tomato;
                    dataGridView1.Columns[firstlevelind1].HeaderText += "(1)";
                    istwofirst1 = true;
                    goodsBindingSource.ResetBindings(false);
                }

            }
            else
            {
                // Одноуровневая сортировка по нажатию на имя столбца
                if (isonesort1)
                {
                    //Если до этого была выбрана одноуровневая сортировка
                    ChangeSelection1(lastsortind1, 1);
                    isonesort1 = false;
                }
                else
                {
                    //Если до этого была выбрана двухуровневая сортировка
                    ChangeSelection1(firstlevelind1, 3);
                    istwofirst1 = false;
                    if (istwosecond1)
                    {
                        ChangeSelection1(secondlevelind1, 3);
                        istwosecond1 = false;
                    }

                }
                sort1 *= -1;
                if (sort1 > 0)
                    dataGridView1.Columns[e.ColumnIndex].HeaderText += "↑";
                else
                    dataGridView1.Columns[e.ColumnIndex].HeaderText += "↓";
                //Собственно сортировка
                Singleton.showlist = Singleton.OneLevelSort(dataGridView1.Columns[e.ColumnIndex].Tag, sort1, Singleton.showlist);

                lastsortind1 = e.ColumnIndex;
                dataGridView1.Columns[lastsortind1].HeaderCell.Style.BackColor = Color.Aqua;
                goodsBindingSource.DataSource = Singleton.showlist;
                isonesort1 = true;
            }
        }

        private void DeleteGoodBtn_Click(object sender, EventArgs e)
        {
            //Действия при нажатии на "Удалить", удаляем выбранный в таблице объект
            string row;
            if (dataGridView1.CurrentCell.Selected == true)
                row = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            else
                row = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (Singleton.newgoodlist.Find(s => s.Id == row) != null)
            {
                //Если удаляем новый товар
                Singleton.DeleteNew(row, wrh);
            }
            else
            {
                //Если удаляем существующий товар
                if (Singleton.chgoodlist.Find(s => s.Id == row) != null)
                    //Если удаляем измененный товар
                    Singleton.DeleteGenChanged(row, wrh);
                else
                    //Если удаляем НЕизмененный товар
                    Singleton.DeleteGenNotChanged(row, wrh);
            }
            RefreshShowList();
            goodsBindingSource.ResetBindings(false);
            if (showsearchlist.Count > 0)
                SearchBtn.PerformClick();
        }

        private void ChangeGoodBtn_Click(object sender, EventArgs e)
        {
            //Действия при нажатии на "Изменить", перходим на следущую форму
            string row = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Form newfrm = new GdChan(this, wrh, row);
            newfrm.ShowDialog();
            RefreshShowList();
            goodsBindingSource.ResetBindings(false);
            if (showsearchlist.Count > 0)
                SearchBtn.PerformClick();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Сообщаем о переходе на склады
            transit = 3;
            //Закрываем форму
            this.Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Передаем координаты перехода
            oldfrm.transit = transit;
            //Переходим на форму назад
            oldfrm.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //Производим поиск по указанным фильтрам
            showsearchlist = new List<Goods>();
            if (IdCmbBx.Text == "")
                IdCmbBx.Text = "*";

            if (IdCmbBx.Text != "*")
            {
                if (ModCmbBx.Text != "*")
                    showsearchlist.Add(Singleton.showlist.Find(s => s.Id.ToString() == IdCmbBx.Text & s.Mod.ToString() == ModCmbBx.Text));
                else
                    showsearchlist.Add(Singleton.showlist.Find(s => s.Id.ToString() == IdCmbBx.Text));
            }
            else if (ModCmbBx.Text != "*")
                showsearchlist.AddRange(Singleton.showlist.FindAll(s => s.Mod.ToString() == ModCmbBx.Text));
            else
                showsearchlist.AddRange(Singleton.showlist.FindAll(s => true));

            goodsBindingSource1.DataSource = showsearchlist;
        }

        private void DataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Снимаем выделение с первой таблицы
            if (showsearchlist.Count > 0)
            {
                dataGridView1.ClearSelection();
            }
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Снимаем выделение со второй таблицы
            dataGridView2.ClearSelection();
        }

        private void DataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Выполняем "покрас" таблицы
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(190, 224, 238);
                else
                    dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(250, 246, 228);

            }
        }

        private void DataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (showsearchlist.Count > 1)
            {
                    // Одноуровневая сортировка по нажатию на имя столбца
                        //Если до этого была выбрана одноуровневая сортировка
                    ChangeSelection2(lastsortind2, 1);
                        //Если до этого была выбрана двухуровневая сортировка

                    sort2 *= -1;
                    if (sort2 > 0)
                        dataGridView2.Columns[e.ColumnIndex].HeaderText += "↑";
                    else
                        dataGridView2.Columns[e.ColumnIndex].HeaderText += "↓";
                    //Собственно сортировка
                    showsearchlist = Singleton.OneLevelSort(dataGridView2.Columns[e.ColumnIndex].Tag, sort2, showsearchlist);
                    lastsortind2 = e.ColumnIndex;
                    dataGridView2.Columns[lastsortind2].HeaderCell.Style.BackColor = Color.Aqua;
                    goodsBindingSource1.DataSource = showsearchlist;

            }
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

        private void ChangeSelection1(int i, int z)
        {
            var x = dataGridView1.Columns[i].HeaderText;
            dataGridView1.Columns[i].HeaderText = x.Substring(0, x.Length - z);
            dataGridView1.Columns[i].HeaderCell.Style.BackColor = DefaultBackColor;
        }

        private void ChangeSelection2(int i, int z)
        {
            var x = dataGridView2.Columns[i].HeaderText;
            dataGridView2.Columns[i].HeaderText = x.Substring(0, x.Length - z);
            dataGridView2.Columns[i].HeaderCell.Style.BackColor = DefaultBackColor;
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            Form newfrm = new SortF(null, this);
            newfrm.ShowDialog();
        }

        private void УправлениеСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Сообщаем о переходе на склады
            transit = 3;
            //Закрываем форму
            this.Close();
        }

        private void УчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Сообщаем о переходе в учет
            transit = 1;
            //Закрываем форму
            this.Close();
        }

        private void ГлавнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Сообщаем о переходе на главную
            transit = 0;
            //Закрываем форму
            this.Close();
        }
    }
}

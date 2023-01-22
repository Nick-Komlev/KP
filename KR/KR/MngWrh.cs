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
    public partial class MngWrh : Form
    {
        //Форма Управление данными: Склад. Выбирается склад для работы.
        //Можно перейти на форму Управления данными: Товары, вернуться на домашнюю форму.
        public Form1 oldfrm;
        public int transit = 3; //для определения окрываемой формы для перехода

        public MngWrh(Form1 oldfrm_)
        {
            InitializeComponent();
            //Получаем ссылку на предыдущую форму
            oldfrm = oldfrm_;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            transit = 3;
            //Заоплняем комбобоксы названиями складов
            for (int i = 0; i < Singleton.wrhlist.Count; i++)
            {
                WrhCmbBox.Items.Add(Singleton.wrhlist[i].ToString());
            }

            WrhCmbBox.Text = WrhCmbBox.Items[0].ToString();
        }

        public new void Show()
        {
            //Дополнение функции при появлении
            base.Show();
            //Проверка маршрута при отображении формы
            switch (transit)
            {
                //Переход на главную
                case 0:
                    ExitBtn.PerformClick();
                    break;
                //Переход в учет
                case 1:
                    учетToolStripMenuItem.PerformClick();
                    break;
                //Остаться
                default:
                    break;
            }
        }

        private void WrhSelBtn_Click(object sender, EventArgs e)
        {
            //Переход к форме управления данными: Товары
            Form newfrm = new MngGds(this, WrhCmbBox.Text.ToString());
            newfrm.Show();
            this.Hide();
        }

        private void WrhAddBtn_Click(object sender, EventArgs e)
        {
            //Попытка добавления новых складов заблокирована
            MessageBox.Show(
                    "Не хватает прав, обратитесь к администратору",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
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
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Передаем координаты перхода
            oldfrm.transit = transit;
            //Возвращаемся на форму назад
            oldfrm.Show();
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Сообщаем о переходе на главную
            transit = 0;
            //Закрываем форму
            this.Close();
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

        private void WrhCmbBox_TextChanged(object sender, EventArgs e)
        {
            //Защита от пользовательского ввода
            if (!WrhCmbBox.Items.Contains(WrhCmbBox.Text))
                WrhCmbBox.Text = WrhCmbBox.Items[0].ToString();
        }
    } 
}

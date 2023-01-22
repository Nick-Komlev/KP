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
        public int transit = 0;
        //Домашняя форма, имеет возможность перехода на форму Учета товаров и на форму Управления данными: Склад
        public Form1()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            //Дополнение функции при появлении
            base.Show();
            //Проверка маршрута при отображении формы
            switch (transit)
            {
                //Переход в учет
                case 1:
                    DataRepr.PerformClick();
                    break;
                //Переход в склады
                case 2:
                    DataMng.PerformClick();
                    break;
                //Остаться
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Инициализируем класс Singleton
            Singleton.RefreshShowList();
        }
        
        private void DataRepr_Click(object sender, EventArgs e)
        {
            //Переход на форму учета
            Form newfrm = new AccountF(this);
            newfrm.Show();
            this.Hide();
        }

        private void DataMng_Click(object sender, EventArgs e)
        {
            //Переход на форму управления данными: склад
            Form newfrm = new MngWrh(this);
            newfrm.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Закрываем приложение
            Singleton.Exit();
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

        private void ОбАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал студент 2-го курса группы ПИ18-3 Комлев Н.П.",
                "Версия 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "info.txt");
        }

    }

    
}

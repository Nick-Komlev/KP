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
    public partial class ModAdd : Form
    {
        //Форма добавления модели
        //Можно возвратиться на форму Управления данными: Товары
        public ModAdd()
        {
            InitializeComponent();
        }

        public void CheckFill()
        {
            //Функция проверки заполненности всех полей
            if (textBox1.Text.Length > 0 & CtgCmbBx.Text.Length > 0 & ProCmbBx.Text.Length > 0)
                YesBtn.Enabled = true;
            else
                YesBtn.Enabled = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //Закрываем форму
            DialogResult = DialogResult.OK;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            CheckFill();
        }

        private void CtgCmbBx_TextChanged(object sender, EventArgs e)
        {
            if (!CtgCmbBx.Items.Contains(CtgCmbBx.Text)) //Защита от пользовательского ввода
                CtgCmbBx.Text = CtgCmbBx.Items[0].ToString();
            CheckFill();
        }

        private void ProCmbBx_TextChanged(object sender, EventArgs e)
        {
            if (!ProCmbBx.Items.Contains(ProCmbBx.Text) & ProCmbBx.Items.Count > 0)//Защита от пользовательского ввода
                ProCmbBx.Text = ProCmbBx.Items[0].ToString();
            CheckFill();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            //Заполняем комбобоксы данными
            for (int i = 0; i < Singleton.ctglist.Count; i++)
            {
                CtgCmbBx.Items.Add(Singleton.ctglist[i].ToString());
            }
            for (int i = 0; i < Singleton.prolist.Count; i++)
            {
                ProCmbBx.Items.Add(Singleton.prolist[i].ToString());
            }
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            //Функция добавления изменения
            DialogResult res = MessageBox.Show(
                "Уверены, что хотите внести изменения?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                string keyy;
                keyy = "mod" + (Singleton.mod_id + 1).ToString().PadLeft(3, '0');
                Singleton.mod_id += 1;
                Singleton.newmodlist.Add(new Model(keyy, textBox1.Text, Singleton.ctglist.Find(s => s.ToString() == CtgCmbBx.Text), Singleton.prolist.Find(s => s.ToString() == ProCmbBx.Text)));
                Singleton.modlist.Add(new Model(keyy, textBox1.Text, Singleton.ctglist.Find(s => s.ToString() == CtgCmbBx.Text), Singleton.prolist.Find(s => s.ToString() == ProCmbBx.Text)));
                DialogResult = DialogResult.OK;
            }
        }
    }
}

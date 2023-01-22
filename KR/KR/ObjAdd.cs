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
    public partial class ObjAdd : Form
    {
        //Форма добавления объекта(катег, произв, поставщ)
        //Можно возвратиться на форму Управления данными: Товары
        MngGds oldfrm;
        string addobj;

        public ObjAdd(MngGds oldfrm_, string addobj_)
        {
            InitializeComponent();
            //Получаем ссылку на предыдущую форму
            oldfrm = oldfrm_;
            //Получаем информацию о том, какой объект добавляем
            addobj = addobj_;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //Заполняем лэйбл названием объекта
            label1.Text += addobj;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Проверка на пустоту текстбокса
            if (textBox1.Text.Length <= 0)
                YesBtn.Enabled = false;
            else YesBtn.Enabled = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            //Добавление нового объекта
            DialogResult res = MessageBox.Show(
                "Уверены, что хотите внести изменения?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                string keyy;
                if (addobj == "Категория")
                {
                    keyy = "ctg" + (Singleton.ctg_id + 1).ToString();
                    Singleton.ctg_id += 1;
                    Singleton.newctglist.Add(new Category(keyy, textBox1.Text));
                    Singleton.ctglist.Add(new Category(keyy, textBox1.Text));
                }
                else if (addobj == "Производитель")
                {
                    keyy = "pro" + (Singleton.pro_id + 1).ToString().PadLeft(3, '0');
                    Singleton.pro_id += 1;
                    Singleton.newprolist.Add(new Producer(keyy, textBox1.Text));
                    Singleton.prolist.Add(new Producer(keyy, textBox1.Text));
                }
                else if (addobj == "Поставщик")
                {
                    keyy = "dis" + (Singleton.dis_id + 1).ToString().PadLeft(2, '0');
                    Singleton.dis_id += 1;
                    Singleton.newdislist.Add(new Distributor(keyy, textBox1.Text));
                    Singleton.dislist.Add(new Distributor(keyy, textBox1.Text));
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}

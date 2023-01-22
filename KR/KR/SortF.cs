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
    public partial class SortF : Form
    {
        //Если форма вызывается из второй формы
        AccountF oldfrm2;
        //Если форма вызывается из первой формы
        MngGds oldfrm5;
        public SortF(AccountF oldfrm2_, MngGds oldfrm5_)
        {
            InitializeComponent();
            oldfrm2 = oldfrm2_;
            oldfrm5 = oldfrm5_;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            if (oldfrm5 is null)
            {
                ParLevel1.Items.Add("По убыванию");
                ParLevel1.Items.Add("По возрастанию");
                ParLevel1.Text = oldfrm2.level1sort;
                ParLevel2.Items.Add("По убыванию");
                ParLevel2.Items.Add("По возрастанию");
                ParLevel2.Text = oldfrm2.level2sort;
            }
            else
            {
                ParLevel1.Items.Add("По убыванию");
                ParLevel1.Items.Add("По возрастанию");
                ParLevel1.Text = oldfrm5.level1sort;
                ParLevel2.Items.Add("По убыванию");
                ParLevel2.Items.Add("По возрастанию");
                ParLevel2.Text = oldfrm5.level2sort;
            }
            
        }

        private void ParLevel1_TextChanged(object sender, EventArgs e)
        {
            //Проверка для ограничения пользовательского ввода
            if (!ParLevel1.Items.Contains(ParLevel1.Text))
                ParLevel1.Text = ParLevel1.Items[0].ToString();
        }

        private void ParLevel2_TextChanged(object sender, EventArgs e)
        {
            //Проверка для ограничения пользовательского ввода
            if (!ParLevel2.Items.Contains(ParLevel2.Text))
                ParLevel2.Text = ParLevel2.Items[0].ToString();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (oldfrm5 is null)
            {
                oldfrm2.level1sort = ParLevel1.Text;
                oldfrm2.level2sort = ParLevel2.Text;
            }
            else
            {
                oldfrm5.level1sort = ParLevel1.Text;
                oldfrm5.level2sort = ParLevel2.Text;
            }
        }
    }
}

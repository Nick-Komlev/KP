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
    public partial class ChAdd : Form
    {
        //Форма добавления объектов
        //Можно перейти на формы добавления товаров, и других объектов (категория, модель, производитель, поставщик) и вернуться на форму Управления данными: Товары
        MngGds oldfrm;
        string wrh;

        public ChAdd(MngGds oldfrm_, string wrh_)
        {
            InitializeComponent();
            //Получаем ссылку на предыдущую форму
            oldfrm = oldfrm_;
            //Получаем информацию о том, с каким складом работаем
            wrh = wrh_;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void AddGdBtn_Click(object sender, EventArgs e)
        {
            //Действия по нажатию на "Добавить", переход на новую форму
            Form newfrm = new GdAdd(oldfrm, wrh);
            newfrm.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            Form newfrm = new ModAdd();
            newfrm.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void CtgBtn_Click(object sender, EventArgs e)
        {
            Form newfrm = new ObjAdd(oldfrm, "Категория");
            newfrm.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void ProBtn_Click(object sender, EventArgs e)
        {
            Form newfrm = new ObjAdd(oldfrm, "Производитель");
            newfrm.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void DisBtn_Click(object sender, EventArgs e)
        {
            Form newfrm = new ObjAdd(oldfrm, "Поставщик");
            newfrm.ShowDialog();
            DialogResult = DialogResult.OK;
        }
    }
}

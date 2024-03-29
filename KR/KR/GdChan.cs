﻿using System;
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
    public partial class GdChan : Form
    {
        //Форма изменения товара
        //Можно возвратиться на форму Управления данными: Товары
        MngGds oldfrm;
        string wrh;
        string row;

        public GdChan(MngGds oldfrm_, string wrh_, string row_)
        {
            InitializeComponent();
            //Получаем ссылку на предыдущую форму
            oldfrm = oldfrm_;
            //Получаем информацию о том, с каким складом и каким объектом работаем
            wrh = wrh_;
            row = row_;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //Заполняем все элементы исходными данными выбранного объекта
            label1.Text += wrh;
            var x = Singleton.wrhlist.Find(s => s.ToString() == wrh).GoodsLst.Find(u => u.Id == row);
            for (int i = 0; i < Singleton.ctglist.Count; i++)
            {
                CtgCmbBx.Items.Add(Singleton.ctglist[i].ToString());
            }

            CtgCmbBx.Text = x.Categ.ToString();
            ProCmbBx.Text = x.Prod.ToString();
            ModCmbBx.Text = x.Mod.ToString();
            WthTxt.Text = x.Worth.ToString();
            DatePick.Value = x.ArDate;
            StcCheck.Checked = x.InStock;
            DisCmbBx.Text = x.Distr.ToString();

            for (int i = 0; i < Singleton.dislist.Count; i++)
            {
                DisCmbBx.Items.Add(Singleton.dislist[i].ToString());
            }
        }

        private void CtgCmbBx_TextChanged(object sender, EventArgs e)
        {
            //При выборе значения категории, вызываем функцию появления следующего комбобокса
            if (!CtgCmbBx.Items.Contains(CtgCmbBx.Text)) //Защита от пользовательского ввода
                CtgCmbBx.Text = CtgCmbBx.Items[0].ToString();
            if (CtgCmbBx.Text.Length > 0)
                Pro_Show(CtgCmbBx.Text);
        }

        public void Pro_Show(string ctg_)
        {
            //Функция появления комбобокса производителей
            //Принимает значение номера катогории
            label4.Visible = true;
            ProCmbBx.Visible = true;
            ProCmbBx.Items.Clear();
            ProCmbBx.Text = "";
            //Заполняем комбобокс производителями
            for (int i = 0; i < Singleton.prolist.Count; i++)
            {
                ProCmbBx.Items.Add(Singleton.prolist[i].ToString());
            }
        }

        private void ProCmbBx_TextChanged(object sender, EventArgs e)
        {
            //При выборе значения производителя вызываем функцию появления слующего комбобокса
            //В случае, если значение пустое, прячем следующий комбобокс
            if (!ProCmbBx.Items.Contains(ProCmbBx.Text) & ProCmbBx.Items.Count > 0)
                ProCmbBx.Text = ProCmbBx.Items[0].ToString();
            if (ProCmbBx.Text.Length > 0)
                Mod_Show(ProCmbBx.Text, CtgCmbBx.Text);
            else Mod_Hide();
        }

        public void Mod_Show(string pro_, string ctg_)
        {
            //Функция появления комобобокса моделей
            //Принимает значения номер производителя и номера категории
            OtherHide();
            label3.Visible = true;
            ModCmbBx.Visible = true;
            ModCmbBx.Items.Clear();
            ModCmbBx.Text = "";
            //Заполняем комбобокс в соответствие с выбранными категориями и производителем
            for (int i = 0; i < Singleton.modlist.Count; i++)
            {
                if ((Singleton.modlist[i].Prod.ToString() == pro_) & (Singleton.modlist[i].Categ.ToString() == ctg_))
                    ModCmbBx.Items.Add(Singleton.modlist[i].ToString());
            }
        }

        public void Mod_Hide()
        {
            //Функция скрытия комобобокса моделей
            label3.Visible = false;
            ModCmbBx.Visible = false;
            ModCmbBx.Items.Clear();
            ModCmbBx.Text = "";
            OtherHide();
        }

        private void ModCmbBx_TextChanged(object sender, EventArgs e)
        {
            //При выборе значения модели, показываем все остальные элементы
            if (!ModCmbBx.Items.Contains(ModCmbBx.Text) & ModCmbBx.Items.Count > 0)
                ModCmbBx.Text = ModCmbBx.Items[0].ToString();
            if (ModCmbBx.Text.Length > 0)
            {
                OtherShow();
            }
        }

        private void DisCmbBx_TextChanged(object sender, EventArgs e)
        {
            //Проверка заполненности комбобокса поставщиков
            if (!DisCmbBx.Items.Contains(DisCmbBx.Text) & DisCmbBx.Items.Count > 0)
                DisCmbBx.Text = DisCmbBx.Items[0].ToString();
            ConfirmCheck();
        }

        private void WthTxt_TextChanged(object sender, EventArgs e)
        {
            //Проверка заполненности поля цены
            ConfirmCheck();
        }

        public void ConfirmCheck()
        {
            //Если все заполнено, разрешить кнопку подтверждения
            if ((WthTxt.Text.Length > 0) & (DisCmbBx.Text.Length > 0))
                YesBtn.Enabled = true;
            else
                YesBtn.Enabled = false;
        }

        public void OtherHide()
        {
            //Функция скрывания остальных элементов
            WthTxt.Visible = false;
            label5.Visible = false;
            WthTxt.Text = "";
            DatePick.Visible = false;
            label6.Visible = false;
            StcCheck.Visible = false;
            label7.Visible = false;
            DisCmbBx.Visible = false;
            DisCmbBx.Text = "";
            label8.Visible = false;
        }

        public void OtherShow()
        {
            //Функция появления всех элементов
            WthTxt.Visible = true;
            label5.Visible = true;
            DatePick.Visible = true;
            label6.Visible = true;
            StcCheck.Visible = true;
            label7.Visible = true;
            DisCmbBx.Visible = true;
            label8.Visible = true;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            //Проверка на уверенность о внесении изменений
            DialogResult res = MessageBox.Show(
                "Уверены, что хотите внести изменения?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                try
                {
                    if (Singleton.newgoodlist.Contains(Singleton.wrhlist.Find(s => s.ToString() == wrh).GoodsLst.Find(u => u.Id == row)))
                    {
                        //Если меняем новый товар
                        Singleton.ChangeNew(row,
                                            Singleton.ctglist.Find(s => s.ToString() == CtgCmbBx.Text),
                                            Singleton.prolist.Find(s => s.ToString() == ProCmbBx.Text),
                                            Singleton.modlist.Find(s => s.ToString() == ModCmbBx.Text),
                                            Convert.ToDouble(WthTxt.Text),
                                            DatePick.Value,
                                            StcCheck.Checked,
                                            Singleton.dislist.Find(s => s.ToString() == DisCmbBx.Text));
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        //Если меняем существующий товар
                        Singleton.ChangeGen(row,
                                            Singleton.ctglist.Find(s => s.ToString() == CtgCmbBx.Text),
                                            Singleton.prolist.Find(s => s.ToString() == ProCmbBx.Text),
                                            Singleton.modlist.Find(s => s.ToString() == ModCmbBx.Text),
                                            Convert.ToDouble(WthTxt.Text),
                                            DatePick.Value,
                                            StcCheck.Checked,
                                            Singleton.dislist.Find(s => s.ToString() == DisCmbBx.Text),
                                            Singleton.wrhlist.Find(s => s.ToString() == wrh));
                        DialogResult = DialogResult.OK;
                    }
                        
                }
                catch
                {
                    //Если ошибка из-за некорректно введенных данных
                    MessageBox.Show(
                        "Некорректный ввод",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //Закрываем форму
            DialogResult = DialogResult.OK;
        }
    }
}

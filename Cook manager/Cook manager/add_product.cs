using System;
using System.Windows.Forms;

namespace Cook_manager
{
    public partial class add_product : Form
    {
        public add_product()
        {
            InitializeComponent();
        }

        private void TB_price_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void add_product_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing_form(sender, e);
        }

        private void closing_form(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
                e.Cancel = false;

            try
            {
                if (TB_name_product.Text.Trim() == "")
                {
                    TB_name_product.Focus();
                    throw new Exception("отсутствует имя продукта");
                }

                if (TB_price_product.Text.Trim() == "")
                {
                    TB_price_product.Focus();
                    throw new Exception("отсутствует стоимость продукта");
                }

                if (TB_kolvo.Text.Trim() == "")
                {
                    TB_kolvo.Focus();
                    throw new Exception("не указано кол-во/вес продукта");
                }
            }
            catch (Exception E)
            {
                if (DialogResult == DialogResult.OK)
                {
                    MessageBox.Show(E.Message, "предупреждение");
                    e.Cancel = true;
                }
            }
        }

        private void TB_kolvo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}

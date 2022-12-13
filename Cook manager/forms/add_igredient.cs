using System;
using System.Windows.Forms;

namespace Cook_manager
{
    public partial class add_igredient : Form
    {

        //public double[] price;
        //public double[] kolvo;
        public string[,] product_category;
        public add_igredient()
        {
            InitializeComponent();
        }


        private void CB_ingredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_price();
        }
        //public void update_value_price(int value)
        //{
        //    price = new double[value];
        //    kolvo = new double[value];
        //}
        public void update_value_category(int value)
        {
            product_category = new string[value, 3];
        }

        private void CB_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CB_ingredient.Items.Clear();

                if (CB_category.SelectedItem.ToString() != "все")
                {
                    for (int i = 0; i < product_category.GetLength(1); i++)
                        if (CB_category.SelectedItem.ToString() == product_category[3, i])
                            CB_ingredient.Items.Add(product_category[0, i]);
                }
                else
                    for (int i = 0; i < product_category.GetLength(1); i++)
                        CB_ingredient.Items.Add(product_category[0, i]);
            }
            catch { }
        }

        private void update_price()
        {
            if (CB_ingredient.SelectedIndex != -1 && TB_value.Text.Trim().ToString() != "")
            {
                for (int i = 0; i < product_category.GetLength(1); i++)
                    if (CB_ingredient.SelectedItem.ToString() == product_category[0, i])
                    {
                        TB_sebestoimost.Text = Convert.ToString(Math.Round((Convert.ToDouble(product_category[1, i]) / Convert.ToDouble(product_category[2, i])) * Convert.ToDouble(TB_value.Text), 2));
                        break;
                    }
            }
        }

        private void TB_value_TextChanged(object sender, EventArgs e)
        {
            update_price();
        }

        private void TB_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void add_igredient_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (CB_ingredient.SelectedIndex == -1)
                {
                    CB_ingredient.Focus();
                    throw new Exception("не выбран продукт");
                }

                if (TB_value.Text.Trim() == "")
                {
                    TB_value.Focus();
                    throw new Exception("отсутствует кол-во или вес продукта");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cook_manager
{
    public partial class recalculation : Form
    {
        public recalculation()
        {
            InitializeComponent();
        }

        public double[] sebestoimost;

        public void update_value_price(int value)
        {
            sebestoimost = new double[value];
            //kolvo = new double[value];
        }

        private void update_price()
        {
            if (CB_bludo.SelectedIndex != -1)
                TB_sebestoimost.Text = Convert.ToString(sebestoimost[CB_bludo.SelectedIndex]);
        }
        private void CB_bludo_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_price();
        }

        private void recalculation_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (CB_bludo.SelectedIndex == -1)
                {
                    CB_bludo.Focus();
                    throw new Exception("не выбрано блюдо");
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

    }
}

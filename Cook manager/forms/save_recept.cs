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
    public partial class save_recept : Form
    {
        public save_recept()
        {
            InitializeComponent();
        }
        private void save_recept_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (TB_name.Text.Trim() == "")
                {
                    TB_name.Focus();
                    throw new Exception("отсутствует название блюда");
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

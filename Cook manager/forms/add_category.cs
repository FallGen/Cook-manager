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
    public partial class add_category : Form
    {
        public add_category()
        {
            InitializeComponent();
        }

        private void add_category_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (TB_name_category.Text.Trim() == "")
                {
                    TB_name_category.Focus();
                    throw new Exception("отсутствует название категории");
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

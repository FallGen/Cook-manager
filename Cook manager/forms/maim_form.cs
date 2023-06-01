using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace Cook_manager
{
    public partial class maim_form : Form
    {
        public maim_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_product();
            load_bludo();
            load_setting();
            load_category();
        }

        int row_index_product = -1;
        int row_index_ingredient = -1;
        int row_index_bludo = -1;
        int row_index_category = -1;
        string[,] spisok_productov;

        //settings
        #region
        public void save_setting()
        {
            string settings = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\settings";

            try
            {
                using (BinaryWriter file = new BinaryWriter(File.Open(settings, FileMode.Create)))
                {
                    file.Write(CB_thema.SelectedIndex);
                }
            }
            catch { }
        }

        public void load_setting()
        {
            string settings = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\settings";
            try
            {
                using (BinaryReader file = new BinaryReader(File.Open(settings, FileMode.Open)))
                {
                    CB_thema.SelectedIndex = file.ReadInt32();
                }
            }
            catch
            {
                using (BinaryReader file = new BinaryReader(File.Create(settings)))
                {
                }

                CB_thema.SelectedIndex = 0;
            }

            update_settings();
        }

        private void update_settings()
        {
            if (CB_thema.SelectedIndex == 0)
            {
                pictureBox1.Image = Properties.Resources.повар_512х512;
                button1.Image = Properties.Resources.шапка_48х48;
            }
            else
                if (CB_thema.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.визитка;
                button1.Image = Properties.Resources.торт_64х64;
            }

        }

        private void CB_thema_SelectedIndexChanged(object sender, EventArgs e)
        {
            save_setting();
            update_settings();
        }

        #endregion

        private void update_param_button(int index_param)
        {
            button20.BackColor = Color.Gainsboro;
            button22.BackColor = Color.Gainsboro;

            panel2.Visible = false;
            panel3.Visible = false;

            switch (index_param)
            {
                case 1:
                    button20.BackColor = Color.White;
                    panel2.Visible = true;
                    break;
                case 2:
                    button22.BackColor = Color.White;
                    panel3.Visible = true;
                    break;
            }
        }

        public void update_main_button(int index_panel) //update color and interfaceВ
        {
            btn_work_recept(false);
            btn_work_bludo(false);
            btn_work_product(false);

            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button13.BackColor = Color.Gainsboro;

            pictureBox1.Visible = false;
            PANEL_recept.Visible = false;
            PANEL_create.Visible = false;
            PANEL_product.Visible = false;
            PANEL_calculate.Visible = false;
            PANEL_param.Visible = false;

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView6.ClearSelection();
            dataGridView4.ClearSelection();

            dataGridView2.RowCount = 0;
            pictureBox2.Image = null;

            row_index_product = -1;
            row_index_ingredient = -1;
            row_index_bludo = -1;

            switch (index_panel)
            {
                case 1:
                    button1.BackColor = Color.White;
                    pictureBox1.Visible = true;
                    break;
                case 2:
                    button2.BackColor = Color.White;
                    PANEL_recept.Visible = true;
                    break;
                case 3:
                    button3.BackColor = Color.White;
                    PANEL_create.Visible = true;
                    break;
                case 4:
                    button4.BackColor = Color.White;
                    PANEL_product.Visible = true;
                    break;
                case 5:
                    button13.BackColor = Color.White;
                    PANEL_calculate.Visible = true;
                    break;
                case 6:
                    button5.BackColor = Color.White;
                    PANEL_param.Visible = true;
                    update_param_button(1);
                    break;
            }
        }

        private void btn_work_recept(bool flag)
        {
            button15.Enabled = flag;

            if (flag)
            {
                button15.BackColor = Color.Gainsboro;
            }
            else
            {
                button15.BackColor = Color.DarkGray;
            }

            if (dataGridView6.RowCount > 0)
            {
                button9.Enabled = true;
                button9.BackColor = Color.Gainsboro;

                button8.Enabled = true;
                button8.BackColor = Color.Gainsboro;
            }
            else
            {
                button9.Enabled = false;
                button9.BackColor = Color.DarkGray;

                button8.Enabled = false;
                button8.BackColor = Color.DarkGray;
            }
        }
        private void btn_work_bludo(bool flag)
        {
            button7.Enabled = flag;
            button17.Enabled = flag;
            button16.Enabled = flag;
            button25.Enabled = flag;

            if (flag)
            {
                button17.BackColor = Color.Gainsboro;
                button7.BackColor = Color.Gainsboro;
                button16.BackColor = Color.Gainsboro;
                button25.BackColor = Color.Gainsboro;
            }
            else
            {
                button17.BackColor = Color.DarkGray;
                button7.BackColor = Color.DarkGray;
                button16.BackColor = Color.DarkGray;
                button25.BackColor = Color.DarkGray;
            }
        }
        private void btn_work_product(bool flag)
        {
            button11.Enabled = flag;
            button12.Enabled = flag;

            if (flag)
            {
                button11.BackColor = Color.Gainsboro;
                button12.BackColor = Color.Gainsboro;
            }
            else
            {
                button11.BackColor = Color.DarkGray;
                button12.BackColor = Color.DarkGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_main_button(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_main_button(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_main_button(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            update_main_button(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update_main_button(6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            update_main_button(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //save and load product
        #region
        public void load_product()
        {
            string product = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\product\product";

            try
            {
                using (BinaryReader file = new BinaryReader(File.Open(product, FileMode.Open)))
                {
                    try
                    {
                        dataGridView4.RowCount = file.ReadInt32();
                        spisok_productov = new string[dataGridView4.ColumnCount, dataGridView4.RowCount];

                        for (int i = 0; i < dataGridView4.RowCount; i++)
                            for (int j = 0; j < dataGridView4.ColumnCount; j++)
                                dataGridView4[j, i].Value = spisok_productov[j, i] = file.ReadString();
                    }
                    catch (Exception E) { /*MessageBox.Show(E.Message, "ошибка");*/ }
                }
            }
            catch
            {
                //создание папки
                string path = $@"C:\Users\{Environment.UserName}\AppData\Roaming\";
                string subpath = @"Cook manager\product";

                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                    dirInfo.Create();
                dirInfo.CreateSubdirectory(subpath);

                //создание файла
                using (BinaryReader file = new BinaryReader(File.Create(product)))
                {
                }

                load_product();
            }
        }

        public void save_product()
        {
            string product = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\product\product";

            try
            {
                using (BinaryWriter file = new BinaryWriter(File.Open(product, FileMode.Create)))
                {
                    file.Write(dataGridView4.RowCount);

                    for (int i = 0; i < dataGridView4.RowCount; i++)
                        for (int j = 0; j < dataGridView4.ColumnCount; j++)
                            file.Write(Convert.ToString(dataGridView4[j, i].Value));
                }
            }
            catch { }
        }


        #endregion

        //добавление продукта
        private void button10_Click(object sender, EventArgs e)
        {
            add_product();
        }

        private void add_product()
        {
            add_product form = new add_product();

            form.CB_category.Items.Add("все");
            for (int i = 0; i < LB_category.Items.Count; i++)
                form.CB_category.Items.Add(LB_category.Items[i].ToString());
            form.CB_category.SelectedIndex = 0;
            TB_find_product.Clear();

            if (form.ShowDialog() == DialogResult.OK)
            {
                dataGridView4.RowCount++;

                //сдвиг всех строк вниз на 1
                if (dataGridView4.RowCount > 1)
                    for (int j = dataGridView4.RowCount - 1; j >= 1; j--)
                        for (int c = 0; c < dataGridView4.ColumnCount; c++)
                            dataGridView4[c, j].Value = dataGridView4[c, j - 1].Value;

                dataGridView4[0, 0].Value = form.TB_name_product.Text;
                dataGridView4[1, 0].Value = Convert.ToString(form.TB_price_product.Text);
                dataGridView4[2, 0].Value = form.TB_kolvo.Text;
                dataGridView4[3, 0].Value = form.CB_category.Text;

                row_index_product = -1;

                save_product();
                load_product();
            }

            if (form.DialogResult == DialogResult.Abort)
            {
                update_main_button(6);
                add_category();
            }

            btn_work_product(false);

        }

        //удаление продукта
        private void button12_Click(object sender, EventArgs e)
        {
            if ((row_index_product != -1) && (MessageBox.Show("удалить безвозвратно продукт \"" + dataGridView4[0, row_index_product].Value + "\"?", "предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                dataGridView4.Rows.RemoveAt(dataGridView4.CurrentRow.Index);
                dataGridView4.ClearSelection();
                row_index_product = -1;

                btn_work_product(false);
                save_product();
            }
        }

        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dataGridView4.Rows[e.RowIndex].Selected = true;
                row_index_product = e.RowIndex;

                if (CB_category.SelectedItem.ToString() != "все" || TB_find_product.Text.Trim() != "")
                    btn_work_product(false);
                else
                    btn_work_product(true);
            }
            catch { }
        }

        //изменение продукта
        private void button11_Click(object sender, EventArgs e)
        {
            change_product();
        }

        public void change_product()
        {
            add_product form = new add_product();

            for (int i = 0; i < LB_category.Items.Count; i++)
                form.CB_category.Items.Add(LB_category.Items[i].ToString());
            form.CB_category.SelectedIndex = 0;
            TB_find_product.Clear();

            form.TB_name_product.Text = dataGridView4[0, row_index_product].Value.ToString();
            form.TB_price_product.Text = dataGridView4[1, row_index_product].Value.ToString();
            form.TB_kolvo.Text = dataGridView4[2, row_index_product].Value.ToString();
            form.CB_category.SelectedItem = dataGridView4[3, row_index_product].Value.ToString();

            if (form.ShowDialog() == DialogResult.OK)
            {
                dataGridView4[0, row_index_product].Value = form.TB_name_product.Text;
                dataGridView4[1, row_index_product].Value = form.TB_price_product.Text;
                dataGridView4[2, row_index_product].Value = form.TB_kolvo.Text;
                dataGridView4[3, row_index_product].Value = form.CB_category.Text;

                row_index_product = -1;

                //btn_work_product(false);
                save_product();
                load_product();
            }

            if (form.DialogResult == DialogResult.Abort)
            {
                update_main_button(6);
                add_category();
            }

            dataGridView4.ClearSelection();
            btn_work_product(false);
        }

        //добавление ингредиента
        private void button14_Click(object sender, EventArgs e)
        {
            add_igredient form = new add_igredient();

            //form.update_value_price(dataGridView4.RowCount);

            form.product_category = spisok_productov;

            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                form.CB_ingredient.Items.Add(dataGridView4[0, i].Value);
                //form.CB_ingredient.Items.Add(dataGridView4[0, i].Value + " | вес/кол-во: " + dataGridView4[2, i].Value);
                //form.price[i] = Convert.ToDouble(dataGridView4[1, i].Value);
                //form.kolvo[i] = Convert.ToDouble(dataGridView4[2, i].Value);
            }

            for (int i = 0; i <= LB_category.Items.Count; i++)
                form.CB_category.Items.Add(CB_category.Items[i]);

            form.CB_category.SelectedIndex = 0;

            if (form.ShowDialog() == DialogResult.OK)
            {
                dataGridView6.RowCount++;

                //сдвиг всех строк вниз на 1
                if (dataGridView6.RowCount > 1)
                    for (int j = dataGridView6.RowCount - 1; j >= 1; j--)
                        for (int c = 0; c < dataGridView6.ColumnCount; c++)
                            dataGridView6[c, j].Value = dataGridView6[c, j - 1].Value;

                dataGridView6[0, 0].Value = form.CB_ingredient.Text;
                dataGridView6[1, 0].Value = form.TB_value.Text;
                dataGridView6[2, 0].Value = form.TB_sebestoimost.Text;

                row_index_ingredient = -1;

                update_sebestoimost();
                update_ves();
            }

            if (form.DialogResult == DialogResult.Abort)
            {
                update_main_button(4);
                add_product();
            }

            dataGridView6.ClearSelection();
            btn_work_recept(false);
        }
        private void update_sebestoimost()
        {
            double sebestoimost = 0;

            for (int i = 0; i < dataGridView6.RowCount; i++)
                sebestoimost += Convert.ToDouble(dataGridView6[2, i].Value);

            dataGridView6.ClearSelection();
            TB_sebestoimost.Text = Convert.ToString(Math.Round(sebestoimost));
        }

        private void update_ves()
        {
            double ves = 0;

            for (int i = 0; i < dataGridView6.RowCount; i++)
                ves += Convert.ToDouble(dataGridView6[1, i].Value);

            dataGridView6.ClearSelection();
            TB_ves.Text = Convert.ToString(Math.Round(ves));
        }

        //выделение игредиента
        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dataGridView6.Rows[e.RowIndex].Selected = true;
                row_index_ingredient = e.RowIndex;

                btn_work_recept(true);
            }
            catch { }
        }

        //удаление ингредиента
        private void button15_Click(object sender, EventArgs e)
        {
            if ((row_index_ingredient != -1) && (MessageBox.Show("удалить ингредиент \"" + dataGridView6[0, row_index_ingredient].Value + "\"?", "предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                dataGridView6.Rows.RemoveAt(dataGridView6.CurrentRow.Index);
                dataGridView6.ClearSelection();
                row_index_ingredient = -1;

                btn_work_recept(false);
                update_sebestoimost();
                update_ves();
            }
        }

        //удаление всех ингредиентов
        private void button8_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("удалить все ингредиенты?", "предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                for (int i = dataGridView6.RowCount - 1; i >= 0; i--)
                    dataGridView6.Rows.RemoveAt(i);

                dataGridView6.ClearSelection();
                row_index_ingredient = -1;

                btn_work_recept(false);
                update_sebestoimost();
                update_ves();
            }
        }

        private bool checked_name_bludo(string name_bludo)
        {
            string bludo = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\bludo";

            try
            {
                using (BinaryReader file = new BinaryReader(File.Open(bludo, FileMode.Open)))
                {
                    int counter = file.ReadInt32();
                    string[,] temp_array = new string[counter, dataGridView1.ColumnCount];

                    for (int i = 0; i < counter; i++)
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            temp_array[i, j] = file.ReadString();
                            if (name_bludo == temp_array[i, j])
                                return false;
                        }
                }
            }
            catch
            {
                using (BinaryReader file = new BinaryReader(File.Create(bludo)))
                {
                }
            }
            return true;
        }

        //сохранение рецепта
        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView6.RowCount != 0)
            {
                save_recept form = new save_recept();

                form.TB_sebestoimost.Text = TB_sebestoimost.Text;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // метод проверки названия 
                    if (checked_name_bludo(form.TB_name.Text))
                    {
                        dataGridView1.RowCount++;

                        //сдвиг всех строк вниз на 1
                        if (dataGridView1.RowCount > 1)
                            for (int j = dataGridView1.RowCount - 1; j >= 1; j--)
                                for (int c = 0; c < dataGridView1.ColumnCount; c++)
                                    dataGridView1[c, j].Value = dataGridView1[c, j - 1].Value;

                        dataGridView1[0, 0].Value = form.TB_name.Text;
                        dataGridView1[1, 0].Value = form.TB_sebestoimost.Text;

                        save_bludo();
                        save_recept(form.TB_name.Text);
                        save_tech_map(form.TB_name.Text, form.TB_tech_map.Text);

                        update_main_button(2);
                        MessageBox.Show("блюдо и рецепт успешно сохранены", "успех");
                    }
                    else
                        MessageBox.Show("название блюда уже существует", "предупреждение");
                }
            }
        }

        public void save_recept(string name_recept)
        {
            string recept = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\recepts\{name_recept}";

            try
            {
                using (BinaryWriter file = new BinaryWriter(File.Open(recept, FileMode.Create)))
                {
                    file.Write(dataGridView6.RowCount);

                    for (int i = 0; i < dataGridView6.RowCount; i++)
                        for (int j = 0; j < dataGridView6.ColumnCount - 1; j++)
                            file.Write(Convert.ToString(dataGridView6[j, i].Value));
                }
            }
            catch
            {
                //создание папки
                string path = $@"C:\Users\{Environment.UserName}\AppData\Roaming\";
                string subpath = @"Cook manager\recepts";

                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                    dirInfo.Create();

                dirInfo.CreateSubdirectory(subpath);

                //создание файла
                using (BinaryReader file = new BinaryReader(File.Create(recept)))
                {
                }

                save_recept(name_recept);
            }
        }

        private void save_tech_map(string name_recept, string tech_map)
        {
            string recept = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\tech_map\{"tech_map " + name_recept}";

            try
            {
                using (BinaryWriter file = new BinaryWriter(File.Open(recept, FileMode.Create)))
                {
                    file.Write(tech_map);
                }
            }
            catch
            {
                //создание папки
                string path = $@"C:\Users\{Environment.UserName}\AppData\Roaming\";
                string subpath = @"Cook manager\tech_map";

                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                    dirInfo.Create();

                dirInfo.CreateSubdirectory(subpath);

                //создание файла
                using (BinaryReader file = new BinaryReader(File.Create(recept)))
                {
                }

                save_tech_map(name_recept, tech_map);
            }
        }
        public string load_tech_map(string name_recept)
        {
            string recept = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\tech_map\{"tech_map " + name_recept}";

            string map = string.Empty;

            try
            {
                using (BinaryReader file = new BinaryReader(File.Open(recept, FileMode.Open)))
                {
                    map = file.ReadString(); ;
                }
            }
            catch (Exception E) { /*MessageBox.Show(E.Message, "ошибка"); */}


            return map;
        }
        public void load_recept(string name_recept, string goal)
        {
            string recept = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\recepts\{name_recept}";
            try
            {

                using (BinaryReader file = new BinaryReader(File.Open(recept, FileMode.Open)))
                {
                    if (goal == "update_recept")
                    {
                        dataGridView2.RowCount = file.ReadInt32();

                        for (int i = 0; i < dataGridView2.RowCount; i++)
                            for (int j = 0; j < dataGridView2.ColumnCount; j++)
                                dataGridView2[j, i].Value = file.ReadString();
                    }
                    else
                        if (goal == "recalculation")
                    {
                        dataGridView6.RowCount = file.ReadInt32();

                        for (int i = 0; i < dataGridView6.RowCount; i++)
                            for (int j = 0; j < dataGridView6.ColumnCount - 1; j++)
                                dataGridView6[j, i].Value = file.ReadString();
                    }
                }
            }
            catch (Exception E) { /*MessageBox.Show(E.Message, "ошибка"); */}
        }

        public void save_bludo()
        {
            string bludo = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\bludo";

            try
            {
                using (BinaryWriter file = new BinaryWriter(File.Open(bludo, FileMode.Create)))
                {
                    file.Write(dataGridView1.RowCount);

                    for (int i = 0; i < dataGridView1.RowCount; i++)
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            file.Write(Convert.ToString(dataGridView1[j, i].Value));
                }
            }
            catch { }
        }

        public void load_bludo()
        {
            string bludo = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\bludo";
            try
            {
                using (BinaryReader file = new BinaryReader(File.Open(bludo, FileMode.Open)))
                {
                    dataGridView1.RowCount = file.ReadInt32();

                    for (int i = 0; i < dataGridView1.RowCount; i++)
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            dataGridView1[j, i].Value = file.ReadString();
                }
            }
            catch
            {
                using (BinaryReader file = new BinaryReader(File.Create(bludo)))
                {
                }
            }
        }

        private void load_photo_bludo(string name_bludo_photo)
        {
            try
            {
                string bludo = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\photo\photo {name_bludo_photo}";

                pictureBox2.ImageLocation = bludo;
            }
            catch { }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                row_index_bludo = e.RowIndex;

                btn_work_bludo(true);

                load_recept(dataGridView1[0, e.RowIndex].Value.ToString(), "update_recept");
                load_photo_bludo(dataGridView1[0, e.RowIndex].Value.ToString());

                dataGridView2.ClearSelection();
            }
            catch { }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        //удаление блюда
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if ((row_index_bludo != -1) && (MessageBox.Show("удалить безвозвратно блюдо \"" + dataGridView1[0, row_index_bludo].Value + "\"?", "предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    File.Delete($@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\recepts\{dataGridView1[0, row_index_bludo].Value}");
                    File.Delete($@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\tech_map\{"tech_map " + dataGridView1[0, row_index_bludo].Value}");
                    File.Delete($@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\photo\{"photo " + dataGridView1[0, row_index_bludo].Value}");

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    dataGridView1.ClearSelection();

                    btn_work_bludo(false);

                    dataGridView2.RowCount = 0;
                    row_index_bludo = -1;
                    pictureBox2.Image = null;

                    save_bludo();
                }
            }
            catch { }
        }

        //изменение блюда
        private void button16_Click(object sender, EventArgs e)
        {
            change_bludo();
        }

        private void change_bludo()
        {
            dataGridView6.RowCount = 0;

            double sebestoimost = Convert.ToDouble(dataGridView1[1, row_index_bludo].Value); //себестоимость

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView6.RowCount++;

                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    dataGridView6[j, i].Value = dataGridView2[j, i].Value;

                dataGridView6[2, i].Value = Convert.ToString(Math.Round(sebestoimost / dataGridView2.RowCount));
            }

            update_sebestoimost();
            update_ves();
            update_main_button(3);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tech_map form = new tech_map();
            form.TB_tech_map.Text = load_tech_map(dataGridView1[0, row_index_bludo].Value.ToString());
            form.label1.Text = dataGridView1[0, row_index_bludo].Value.ToString();

            if (form.ShowDialog() == DialogResult.OK)
            {
                save_tech_map(dataGridView1[0, row_index_bludo].Value.ToString(), form.TB_tech_map.Text);
            }
        }

        //арифметика кондитера
        #region
        private void update_selected_form_recept(int selected)
        {
            label7.Text = "коэффициент: ";

            PB_form_recept_circle.BackColor = Color.White;
            PB_form_recept_square.BackColor = Color.White;
            PB_form_recept_rectangle.BackColor = Color.White;

            TB_recept_circle.Visible = false;
            TB_recept_square.Visible = false;
            TB_recept_rectangleA.Visible = false;
            TB_recept_rectangleB.Visible = false;
            button21.Visible = false;

            TB_recept_circle.Clear();
            TB_recept_square.Clear();
            TB_recept_rectangleA.Clear();
            TB_recept_rectangleB.Clear();

            switch (selected)
            {
                case 1:
                    PB_form_recept_circle.BackColor = Color.Pink;
                    TB_recept_circle.Visible = true;
                    break;
                case 2:
                    PB_form_recept_square.BackColor = Color.Pink;
                    TB_recept_square.Visible = true;

                    break;
                case 3:
                    PB_form_recept_rectangle.BackColor = Color.Pink;
                    TB_recept_rectangleA.Visible = true;
                    TB_recept_rectangleB.Visible = true;
                    break;
            }
        }
        private void PB_form_recept_circle_Click(object sender, EventArgs e)
        {
            update_selected_form_recept(1);
        }

        private void PB_form_recept_square_Click(object sender, EventArgs e)
        {
            update_selected_form_recept(2);
        }

        private void PB_form_recept_rectangle_Click(object sender, EventArgs e)
        {
            update_selected_form_recept(3);
        }
        private void update_selected_my_form(int selected)
        {
            label7.Text = "коэффициент: ";

            PB_my_form_circle.BackColor = Color.White;
            PB_my_form_square.BackColor = Color.White;
            PB_my_form_rectangle.BackColor = Color.White;

            TB_my_circle.Visible = false;
            TB_my_square.Visible = false;
            TB_my_rectangleA.Visible = false;
            TB_my_rectangleB.Visible = false;

            TB_my_circle.Clear();
            TB_my_square.Clear();
            TB_my_rectangleA.Clear();
            TB_my_rectangleB.Clear();

            switch (selected)
            {
                case 1:
                    PB_my_form_circle.BackColor = Color.Pink;
                    TB_my_circle.Visible = true;
                    break;
                case 2:
                    PB_my_form_square.BackColor = Color.Pink;
                    TB_my_square.Visible = true;

                    break;
                case 3:
                    PB_my_form_rectangle.BackColor = Color.Pink;
                    TB_my_rectangleA.Visible = true;
                    TB_my_rectangleB.Visible = true;
                    break;
            }
        }

        private void PB_my_form_circle_Click(object sender, EventArgs e)
        {
            update_selected_my_form(1);
        }

        private void PB_my_form_square_Click(object sender, EventArgs e)
        {
            update_selected_my_form(2);
        }

        private void PB_my_form_rectangle_Click(object sender, EventArgs e)
        {
            update_selected_my_form(3);
        }

        private void result_koefficienta()
        {
            double koefficient;

            try
            {
                // 1 из круглой в круглую
                if (TB_recept_circle.Text.Trim() != "" && TB_my_circle.Text.Trim() != "")
                {
                    koefficient = Math.Round(Math.Pow(Convert.ToDouble(TB_my_circle.Text), 2) / Math.Pow(Convert.ToDouble(TB_recept_circle.Text), 2), 2);
                    label7.Text = "коэффициент: " + koefficient.ToString();

                    button21.Visible = true;
                }
                // 2 из квадратный в квадратную
                if (TB_recept_square.Text.Trim() != "" && TB_my_square.Text.Trim() != "")
                {
                    koefficient = Math.Round(Math.Pow(Convert.ToDouble(TB_my_square.Text), 2) / Math.Pow(Convert.ToDouble(TB_recept_square.Text), 2), 2);
                    label7.Text = "коэффициент: " + koefficient.ToString();

                    button21.Visible = true;
                }
                // 3 из прямоугольной в прямоугольную
                if (TB_recept_rectangleA.Text.Trim() != "" && TB_recept_rectangleB.Text.Trim() != "" &&
                    TB_my_rectangleA.Text.Trim() != "" && TB_my_rectangleB.Text.Trim() != "")

                {
                    double s_rec = Convert.ToDouble(TB_recept_rectangleA.Text) * Convert.ToDouble(TB_recept_rectangleB.Text);
                    double s_my = Convert.ToDouble(TB_my_rectangleA.Text) * Convert.ToDouble(TB_my_rectangleB.Text);
                    koefficient = Math.Round(s_my / s_rec, 2);
                    label7.Text = "коэффициент: " + koefficient.ToString();

                    button21.Visible = true;
                }
                // 4 из круглой в квадратную
                if (TB_my_square.Text.Trim() != "" && TB_recept_circle.Text.Trim() != "")
                {
                    double s = Math.Pow(Convert.ToDouble(TB_my_square.Text), 2);
                    double r = Convert.ToDouble(TB_recept_circle.Text) / 2.0;
                    double q = Math.PI * Math.Pow(r, 2);
                    koefficient = Math.Round(s / q, 2);
                    label7.Text = "коэффициент: " + koefficient.ToString();

                    button21.Visible = true;
                }
                // 5 из прямоугольной в круглую
                if (TB_recept_rectangleA.Text.Trim() != "" && TB_recept_rectangleB.Text.Trim() != "" && TB_my_circle.Text.Trim() != "")
                {
                    double s = Convert.ToDouble(TB_recept_rectangleA.Text) * Convert.ToDouble(TB_recept_rectangleB.Text);
                    double r = Convert.ToDouble(TB_my_circle.Text) / 2.0;
                    double q = Math.PI * Math.Pow(r, 2);
                    koefficient = Math.Round(q / s, 2);
                    label7.Text = "коэффициент: " + koefficient.ToString();

                    button21.Visible = true;
                }
                // 6 из круглой в прямоугольную
                if (TB_recept_circle.Text.Trim() != "" && TB_my_rectangleA.Text.Trim() != "" && TB_my_rectangleB.Text.Trim() != "")
                {
                    double s = Convert.ToDouble(TB_my_rectangleA.Text) * Convert.ToDouble(TB_my_rectangleB.Text);
                    double r = Convert.ToDouble(TB_recept_circle.Text) / 2.0;
                    double q = Math.PI * Math.Pow(r, 2);
                    koefficient = Math.Round(s / q, 2);
                    label7.Text = "коэффициент: " + koefficient.ToString();

                    button21.Visible = true;
                }
                // 7 из квадрата в круглую
                if (TB_recept_square.Text.Trim() != "" && TB_my_circle.Text.Trim() != "")
                {
                    double s = Math.Pow(Convert.ToDouble(TB_recept_square.Text), 2);
                    double r = Convert.ToDouble(TB_my_circle.Text) / 2.0;
                    double q = Math.PI * Math.Pow(r, 2);
                    koefficient = Math.Round(q / s, 2);
                    label7.Text = "коэффициент: " + koefficient.ToString();

                    button21.Visible = true;
                }
                // 8 из прямоугольный в квадратную
                if (TB_recept_rectangleA.Text.Trim() != "" && TB_recept_rectangleB.Text.Trim() != "" && TB_my_square.Text.Trim() != "")
                {
                    double s_rec = Convert.ToDouble(TB_recept_rectangleA.Text) * Convert.ToDouble(TB_recept_rectangleB.Text);
                    double s_my = Math.Pow(Convert.ToDouble(TB_my_square.Text), 2);
                    koefficient = Math.Round(s_my / s_rec, 2);
                    label7.Text = "коэффициент: " + koefficient.ToString();

                    button21.Visible = true;
                }
                // 9 из квадратной в прямоугольную
                if (TB_recept_square.Text.Trim() != "" && TB_my_rectangleA.Text.Trim() != "" && TB_my_rectangleB.Text.Trim() != "")
                {
                    double s_rec = Convert.ToDouble(TB_my_rectangleA.Text) * Convert.ToDouble(TB_my_rectangleB.Text);
                    double s_my = Math.Pow(Convert.ToDouble(TB_recept_square.Text), 2);
                    koefficient = Math.Round(s_rec / s_my, 2);
                    label7.Text = "коэффициент: " + koefficient.ToString();

                    button21.Visible = true;
                }
            }
            catch { }
        }

        //запрет ввода букв
        #region

        private void TB_events(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
        private void TB_recept_circle_KeyPress(object sender, KeyPressEventArgs e)
        {
            TB_events(sender, e);
        }

        private void TB_recept_square_KeyPress(object sender, KeyPressEventArgs e)
        {
            TB_events(sender, e);
        }

        private void TB_recept_rectangleA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TB_events(sender, e);
        }

        private void TB_recept_rectangleB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TB_events(sender, e);
        }

        private void TB_my_circle_KeyPress(object sender, KeyPressEventArgs e)
        {
            TB_events(sender, e);
        }

        private void TB_my_square_KeyPress(object sender, KeyPressEventArgs e)
        {
            TB_events(sender, e);
        }

        private void TB_my_rectangleA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TB_events(sender, e);
        }

        private void TB_my_rectangleB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TB_events(sender, e);
        }

        #endregion


        //эвент textchange
        #region
        private void TB_recept_circle_TextChanged(object sender, EventArgs e)
        {
            result_koefficienta();
        }

        private void TB_recept_square_TextChanged(object sender, EventArgs e)
        {
            result_koefficienta();
        }

        private void TB_recept_rectangleA_TextChanged(object sender, EventArgs e)
        {
            result_koefficienta();
        }

        private void TB_recept_rectangleB_TextChanged(object sender, EventArgs e)
        {
            result_koefficienta();
        }

        private void TB_my_circle_TextChanged(object sender, EventArgs e)
        {
            result_koefficienta();
        }

        private void TB_my_square_TextChanged(object sender, EventArgs e)
        {
            result_koefficienta();
        }

        private void TB_my_rectangleA_TextChanged(object sender, EventArgs e)
        {
            result_koefficienta();
        }

        private void TB_my_rectangleB_TextChanged(object sender, EventArgs e)
        {
            result_koefficienta();
        }

        #endregion

        #endregion

        //перерасчет
        private void button21_Click(object sender, EventArgs e)
        {
            recalculation form = new recalculation();

            form.update_value_price(dataGridView1.RowCount);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                form.CB_bludo.Items.Add(dataGridView1[0, i].Value);
                form.sebestoimost[i] = Convert.ToDouble(dataGridView1[1, i].Value);
            }

            double kf = Convert.ToDouble(label7.Text.Replace("коэффициент: ", ""));
            form.TB_kf.Text = kf.ToString();

            if (form.ShowDialog() == DialogResult.OK)
            {
                load_recept(form.CB_bludo.SelectedItem.ToString(), "recalculation");

                for (int i = 0; i < dataGridView6.RowCount; i++)
                    dataGridView6[2, i].Value = Convert.ToString(Convert.ToDouble(form.TB_sebestoimost.Text) / dataGridView6.RowCount);

                for (int i = 0; i < dataGridView6.RowCount; i++)
                    for (int j = 1; j < dataGridView6.ColumnCount; j++)
                        dataGridView6[j, i].Value = Math.Round(Convert.ToDouble(dataGridView6[j, i].Value) * kf, 2);

                update_sebestoimost();
                update_ves();
                update_main_button(3);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://fallgen.github.io/index.html");
        }


        #region
        //добавление категории
        private void button19_Click(object sender, EventArgs e)
        {
            add_category();
        }
        //удалить категорию
        private void button23_Click(object sender, EventArgs e)
        {
            delete_category();
        }
        private void add_category()
        {
            add_category form = new add_category();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LB_category.Items.Add(form.TB_name_category.Text);
                save_category();
                update_category();
            }
        }
        private void delete_category()
        {
            if (row_index_category != -1)
            {
                LB_category.Items.RemoveAt(row_index_category);

                button23.Enabled = false;
                button23.BackColor = Color.DarkGray;
                row_index_category = -1;

                save_category();
                update_category();
            }
        }
        private void LB_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            button23.Enabled = true;
            button23.BackColor = Color.Gainsboro;
            row_index_category = LB_category.SelectedIndex;
        }

        public void save_category()
        {
            string category = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\category";

            try
            {
                using (BinaryWriter file = new BinaryWriter(File.Open(category, FileMode.Create)))
                {
                    file.Write(LB_category.Items.Count);

                    for (int i = 0; i < LB_category.Items.Count; i++)
                        file.Write(LB_category.Items[i].ToString());
                }
            }
            catch { }
        }

        public void load_category()
        {
            string category = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\category";
            try
            {
                using (BinaryReader file = new BinaryReader(File.Open(category, FileMode.Open)))
                {
                    int counter = file.ReadInt32();

                    for (int i = 0; i < counter; i++)
                        LB_category.Items.Add(file.ReadString());

                    update_category();
                }
            }
            catch
            {
                using (BinaryReader file = new BinaryReader(File.Create(category)))
                {
                }

                update_category();
                //save_category();
            }
        }

        private void update_category()
        {
            CB_category.Items.Clear();
            CB_category.Items.Add("все");

            for (int i = 0; i < LB_category.Items.Count; i++)
                CB_category.Items.Add(LB_category.Items[i].ToString());

            CB_category.SelectedIndex = 0;
        }


        #endregion
        private void button20_Click(object sender, EventArgs e)
        {
            update_param_button(1);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            update_param_button(2);
        }


        //фильтрация по категориям и поиск
        #region
        private void find_product()
        {
            try
            {
                //row_index_product = -1;
                btn_work_product(false);

                string text = TB_find_product.Text.ToLower();
                int c;

                if (CB_category.SelectedItem.ToString() != "все" && TB_find_product.Text.Trim() != "")
                {
                    c = 0;
                    dataGridView4.RowCount = 0;

                    for (int i = 0; i < spisok_productov.GetLength(1); i++)
                        if (spisok_productov[3, i].ToLower().StartsWith(CB_category.SelectedItem.ToString()) && spisok_productov[0, i].ToLower().StartsWith(text))
                        {
                            dataGridView4.RowCount++;

                            for (int j = 0; j < spisok_productov.GetLength(0); j++)
                                dataGridView4[j, c].Value = Convert.ToString(spisok_productov[j, i]);
                            c++;
                        }
                }
                else
                     if (CB_category.SelectedItem.ToString() != "все")
                {
                    c = 0;
                    dataGridView4.RowCount = 0;

                    for (int i = 0; i < spisok_productov.GetLength(1); i++)
                        if (spisok_productov[3, i].ToLower().StartsWith(CB_category.SelectedItem.ToString()))
                        {
                            dataGridView4.RowCount++;

                            for (int j = 0; j < spisok_productov.GetLength(0); j++)
                                dataGridView4[j, c].Value = Convert.ToString(spisok_productov[j, i]);
                            c++;
                        }
                }
                else
                    if (TB_find_product.Text.Trim() != "")
                {
                    c = 0;
                    dataGridView4.RowCount = 0;

                    for (int i = 0; i < spisok_productov.GetLength(1); i++)
                        if (spisok_productov[0, i].ToLower().StartsWith(text))
                        {
                            dataGridView4.RowCount++;

                            for (int j = 0; j < spisok_productov.GetLength(0); j++)
                                dataGridView4[j, c].Value = Convert.ToString(spisok_productov[j, i]);
                            c++;
                        }
                }

                if (TB_find_product.Text.Trim() == "" & CB_category.SelectedItem.ToString() == "все")
                    load_product();

                dataGridView4.ClearSelection();
            }
            catch
            {
            }
        }
        private void CB_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            find_product();
        }

        //поиск по тексту dgv4
        private void TB_find_product_TextChanged(object sender, EventArgs e)
        {
            find_product();
        }

        #endregion

        private void button24_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("удалить безвозвратно все данные приложения? \nпотребуется перезапуск приложения", "предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                string papka = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager";

                Directory.Delete(papka, true);

                Application.Restart();
            }
        }

        //добавление фото к блюду
        private void button25_Click(object sender, EventArgs e)
        {
            add_photo_bludo();
        }

        private void add_photo_bludo()
        {
            string photo_bludo = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Cook manager\photo\photo {dataGridView1[0, row_index_bludo].Value}";

            try
            {
                //создание папки
                string path = $@"C:\Users\{Environment.UserName}\AppData\Roaming\";
                string subpath = @"Cook manager\photo";

                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                    dirInfo.Create();

                dirInfo.CreateSubdirectory(subpath);

                OpenFileDialog fileDialog = new OpenFileDialog();

                if (fileDialog.ShowDialog() == true)
                {
                    //pictureBox2.ImageLocation = fileDialog.FileName;
                    FileInfo fileInf = new FileInfo(fileDialog.FileName);
                    if (fileInf.Exists)
                        fileInf.CopyTo(photo_bludo, true);
                }

                load_photo_bludo(dataGridView1[0, row_index_bludo].Value.ToString());
            }
            catch { }
        }
    }
}

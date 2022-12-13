namespace Cook_manager
{
    partial class add_igredient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.CB_ingredient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_sebestoimost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CB_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(52, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "отмена";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(173, 258);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 30);
            this.button9.TabIndex = 4;
            this.button9.Text = "ок";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // CB_ingredient
            // 
            this.CB_ingredient.BackColor = System.Drawing.Color.White;
            this.CB_ingredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ingredient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_ingredient.FormattingEnabled = true;
            this.CB_ingredient.Location = new System.Drawing.Point(17, 94);
            this.CB_ingredient.Name = "CB_ingredient";
            this.CB_ingredient.Size = new System.Drawing.Size(272, 29);
            this.CB_ingredient.TabIndex = 1;
            this.CB_ingredient.SelectedIndexChanged += new System.EventHandler(this.CB_ingredient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "себестоимость (р)";
            // 
            // TB_sebestoimost
            // 
            this.TB_sebestoimost.BackColor = System.Drawing.Color.Gainsboro;
            this.TB_sebestoimost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_sebestoimost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_sebestoimost.Location = new System.Drawing.Point(17, 199);
            this.TB_sebestoimost.Name = "TB_sebestoimost";
            this.TB_sebestoimost.ReadOnly = true;
            this.TB_sebestoimost.Size = new System.Drawing.Size(272, 22);
            this.TB_sebestoimost.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "название игредиента";
            // 
            // TB_value
            // 
            this.TB_value.BackColor = System.Drawing.Color.White;
            this.TB_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_value.Location = new System.Drawing.Point(17, 150);
            this.TB_value.Name = "TB_value";
            this.TB_value.Size = new System.Drawing.Size(272, 22);
            this.TB_value.TabIndex = 3;
            this.TB_value.TextChanged += new System.EventHandler(this.TB_value_TextChanged);
            this.TB_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_value_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "кол-во (шт, г)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(234, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "+ продукт";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CB_category
            // 
            this.CB_category.BackColor = System.Drawing.Color.White;
            this.CB_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_category.FormattingEnabled = true;
            this.CB_category.Location = new System.Drawing.Point(17, 38);
            this.CB_category.Name = "CB_category";
            this.CB_category.Size = new System.Drawing.Size(272, 29);
            this.CB_category.TabIndex = 10;
            this.CB_category.SelectedIndexChanged += new System.EventHandler(this.CB_category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "категория (фильтр)";
            // 
            // add_igredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.CB_category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.CB_ingredient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_sebestoimost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_value);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_igredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_igredient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.add_igredient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.ComboBox CB_ingredient;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TB_sebestoimost;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TB_value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.ComboBox CB_category;
        private System.Windows.Forms.Label label4;
    }
}
namespace Cook_manager
{
    partial class add_product
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
            this.TB_name_product = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_price_product = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TB_kolvo = new System.Windows.Forms.TextBox();
            this.CB_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TB_name_product
            // 
            this.TB_name_product.BackColor = System.Drawing.Color.White;
            this.TB_name_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_name_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_name_product.Location = new System.Drawing.Point(17, 35);
            this.TB_name_product.Name = "TB_name_product";
            this.TB_name_product.Size = new System.Drawing.Size(271, 22);
            this.TB_name_product.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "название продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "стоимость продукта (р)";
            // 
            // TB_price_product
            // 
            this.TB_price_product.BackColor = System.Drawing.Color.White;
            this.TB_price_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_price_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_price_product.Location = new System.Drawing.Point(17, 138);
            this.TB_price_product.Name = "TB_price_product";
            this.TB_price_product.Size = new System.Drawing.Size(271, 22);
            this.TB_price_product.TabIndex = 3;
            this.TB_price_product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_price_product_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "кол-во (шт, г)";
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
            this.button9.TabIndex = 6;
            this.button9.Text = "ок";
            this.button9.UseVisualStyleBackColor = false;
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
            this.button1.TabIndex = 7;
            this.button1.Text = "отмена";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TB_kolvo
            // 
            this.TB_kolvo.BackColor = System.Drawing.Color.White;
            this.TB_kolvo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_kolvo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_kolvo.Location = new System.Drawing.Point(17, 187);
            this.TB_kolvo.Name = "TB_kolvo";
            this.TB_kolvo.Size = new System.Drawing.Size(271, 22);
            this.TB_kolvo.TabIndex = 5;
            this.TB_kolvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_kolvo_KeyPress);
            // 
            // CB_category
            // 
            this.CB_category.BackColor = System.Drawing.Color.White;
            this.CB_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_category.FormattingEnabled = true;
            this.CB_category.Location = new System.Drawing.Point(17, 82);
            this.CB_category.Name = "CB_category";
            this.CB_category.Size = new System.Drawing.Size(271, 29);
            this.CB_category.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "добавить в категорию";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(220, 66);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "+ категория";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_category);
            this.Controls.Add(this.TB_kolvo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_price_product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_name_product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.add_product_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TB_name_product;
        public System.Windows.Forms.TextBox TB_price_product;
        public System.Windows.Forms.TextBox TB_kolvo;
        public System.Windows.Forms.ComboBox CB_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
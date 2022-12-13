namespace Cook_manager
{
    partial class recalculation
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
            this.CB_bludo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_kf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_sebestoimost = new System.Windows.Forms.TextBox();
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
            this.button1.TabIndex = 13;
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
            this.button9.TabIndex = 12;
            this.button9.Text = "ок";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // CB_bludo
            // 
            this.CB_bludo.BackColor = System.Drawing.Color.White;
            this.CB_bludo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_bludo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_bludo.FormattingEnabled = true;
            this.CB_bludo.Location = new System.Drawing.Point(16, 33);
            this.CB_bludo.Name = "CB_bludo";
            this.CB_bludo.Size = new System.Drawing.Size(272, 29);
            this.CB_bludo.TabIndex = 9;
            this.CB_bludo.SelectedIndexChanged += new System.EventHandler(this.CB_bludo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "коэффициент для расчёта";
            // 
            // TB_kf
            // 
            this.TB_kf.BackColor = System.Drawing.Color.Gainsboro;
            this.TB_kf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_kf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_kf.Location = new System.Drawing.Point(16, 138);
            this.TB_kf.Name = "TB_kf";
            this.TB_kf.ReadOnly = true;
            this.TB_kf.Size = new System.Drawing.Size(272, 22);
            this.TB_kf.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "блюдо";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "себестоимость блюда";
            // 
            // TB_sebestoimost
            // 
            this.TB_sebestoimost.BackColor = System.Drawing.Color.Gainsboro;
            this.TB_sebestoimost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_sebestoimost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_sebestoimost.Location = new System.Drawing.Point(16, 89);
            this.TB_sebestoimost.Name = "TB_sebestoimost";
            this.TB_sebestoimost.ReadOnly = true;
            this.TB_sebestoimost.Size = new System.Drawing.Size(272, 22);
            this.TB_sebestoimost.TabIndex = 17;
            // 
            // recalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_sebestoimost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.CB_bludo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_kf);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "recalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recalculation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.recalculation_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.ComboBox CB_bludo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TB_kf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TB_sebestoimost;
    }
}
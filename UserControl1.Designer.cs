namespace hotel1
{
    partial class UserControl1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.btn_1 = new System.Windows.Forms.Button();
            this.cmb_1 = new System.Windows.Forms.ComboBox();
            this.cmb_2 = new System.Windows.Forms.ComboBox();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.chk_1 = new System.Windows.Forms.CheckBox();
            this.nud_1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(358, 319);
            this.btn_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(178, 54);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Prenota";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // cmb_1
            // 
            this.cmb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_1.FormattingEnabled = true;
            this.cmb_1.Items.AddRange(new object[] {
            "Bassa",
            "Media",
            "Alta"});
            this.cmb_1.Location = new System.Drawing.Point(358, 90);
            this.cmb_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_1.Name = "cmb_1";
            this.cmb_1.Size = new System.Drawing.Size(178, 28);
            this.cmb_1.TabIndex = 1;
            this.cmb_1.Text = "Selezione la Stagione";
            // 
            // cmb_2
            // 
            this.cmb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_2.FormattingEnabled = true;
            this.cmb_2.Items.AddRange(new object[] {
            "Base",
            "Media",
            "Alta"});
            this.cmb_2.Location = new System.Drawing.Point(358, 164);
            this.cmb_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_2.Name = "cmb_2";
            this.cmb_2.Size = new System.Drawing.Size(178, 28);
            this.cmb_2.TabIndex = 2;
            this.cmb_2.Text = "Seleziona la Stanza";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Baskerville Old Face", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbl_4.Location = new System.Drawing.Point(79, 9);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(401, 49);
            this.lbl_4.TabIndex = 3;
            this.lbl_4.Text = "ATLANTIS HOTEL";
           
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel1.Properties.Resources.atlantis_the_palm_servicios_156e61e7;
            this.pictureBox1.Location = new System.Drawing.Point(0, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(355, 62);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(84, 24);
            this.lbl_n1.TabIndex = 5;
            this.lbl_n1.Text = "Stagione";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(355, 136);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(109, 24);
            this.lbl_2.TabIndex = 6;
            this.lbl_2.Text = "Tipo Stanza";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(355, 215);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(154, 24);
            this.lbl_3.TabIndex = 7;
            this.lbl_3.Text = "Giorni di Alloggio";
            // 
            // chk_1
            // 
            this.chk_1.AutoSize = true;
            this.chk_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_1.Location = new System.Drawing.Point(358, 283);
            this.chk_1.Name = "chk_1";
            this.chk_1.Size = new System.Drawing.Size(188, 29);
            this.chk_1.TabIndex = 8;
            this.chk_1.Text = "Parcheggio 5$/g\r\n";
            this.chk_1.UseVisualStyleBackColor = true;
            
            // 
            // nud_1
            // 
            this.nud_1.Location = new System.Drawing.Point(358, 242);
            this.nud_1.Name = "nud_1";
            this.nud_1.Size = new System.Drawing.Size(182, 21);
            this.nud_1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 369);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(299, 140);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_1);
            this.Controls.Add(this.chk_1);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.cmb_2);
            this.Controls.Add(this.cmb_1);
            this.Controls.Add(this.btn_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(576, 554);
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.ComboBox cmb_1;
        private System.Windows.Forms.ComboBox cmb_2;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.CheckBox chk_1;
        private System.Windows.Forms.NumericUpDown nud_1;
        private System.Windows.Forms.Label label1;
    }
}

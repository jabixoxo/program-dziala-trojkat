
namespace uwusenpai
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtWynC = new System.Windows.Forms.TextBox();
            this.nUPDNa = new System.Windows.Forms.NumericUpDown();
            this.nUPDNb = new System.Windows.Forms.NumericUpDown();
            this.cmbFunkcja = new System.Windows.Forms.ComboBox();
            this.cmbkat = new System.Windows.Forms.ComboBox();
            this.txtWynFunkcje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPDNa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPDNb)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtWynC
            // 
            this.txtWynC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWynC.Location = new System.Drawing.Point(99, 145);
            this.txtWynC.MaxLength = 6;
            this.txtWynC.Name = "txtWynC";
            this.txtWynC.ReadOnly = true;
            this.txtWynC.Size = new System.Drawing.Size(72, 20);
            this.txtWynC.TabIndex = 2;
            this.txtWynC.TextChanged += new System.EventHandler(this.txtWynC_TextChanged);
            // 
            // nUPDNa
            // 
            this.nUPDNa.Location = new System.Drawing.Point(314, 157);
            this.nUPDNa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUPDNa.Name = "nUPDNa";
            this.nUPDNa.Size = new System.Drawing.Size(72, 20);
            this.nUPDNa.TabIndex = 3;
            this.nUPDNa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUPDNa.ValueChanged += new System.EventHandler(this.nUPDNa_ValueChanged);
            // 
            // nUPDNb
            // 
            this.nUPDNb.Location = new System.Drawing.Point(178, 248);
            this.nUPDNb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUPDNb.Name = "nUPDNb";
            this.nUPDNb.Size = new System.Drawing.Size(72, 20);
            this.nUPDNb.TabIndex = 4;
            this.nUPDNb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUPDNb.ValueChanged += new System.EventHandler(this.nUPDNb_ValueChanged);
            // 
            // cmbFunkcja
            // 
            this.cmbFunkcja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunkcja.DropDownWidth = 121;
            this.cmbFunkcja.FormattingEnabled = true;
            this.cmbFunkcja.Items.AddRange(new object[] {
            "sin",
            "cos",
            "tg",
            "ctg"});
            this.cmbFunkcja.Location = new System.Drawing.Point(30, 311);
            this.cmbFunkcja.Name = "cmbFunkcja";
            this.cmbFunkcja.Size = new System.Drawing.Size(86, 21);
            this.cmbFunkcja.TabIndex = 5;
            this.cmbFunkcja.SelectedIndexChanged += new System.EventHandler(this.cmbFunkcja_SelectedIndexChanged);
            // 
            // cmbkat
            // 
            this.cmbkat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkat.FormattingEnabled = true;
            this.cmbkat.Items.AddRange(new object[] {
            "alfa",
            "beta"});
            this.cmbkat.Location = new System.Drawing.Point(142, 311);
            this.cmbkat.Name = "cmbkat";
            this.cmbkat.Size = new System.Drawing.Size(86, 21);
            this.cmbkat.TabIndex = 6;
            this.cmbkat.SelectedIndexChanged += new System.EventHandler(this.cmbkat_SelectedIndexChanged);
            // 
            // txtWynFunkcje
            // 
            this.txtWynFunkcje.Location = new System.Drawing.Point(286, 312);
            this.txtWynFunkcje.Name = "txtWynFunkcje";
            this.txtWynFunkcje.ReadOnly = true;
            this.txtWynFunkcje.Size = new System.Drawing.Size(100, 20);
            this.txtWynFunkcje.TabIndex = 7;
            this.txtWynFunkcje.TextChanged += new System.EventHandler(this.txtWynFunkcje_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "TROJKAT PROSTOKATNY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(134, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "funkcje trygonometryczne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(246, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "_ _";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 312);
            this.label9.TabIndex = 16;
            this.label9.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 312);
            this.label10.TabIndex = 17;
            this.label10.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "_ _ _ _ _";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "_ _";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "_ _";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(388, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "_";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(117, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "_ _";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "_ _ _ _ _";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 344);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWynFunkcje);
            this.Controls.Add(this.cmbkat);
            this.Controls.Add(this.cmbFunkcja);
            this.Controls.Add(this.nUPDNb);
            this.Controls.Add(this.nUPDNa);
            this.Controls.Add(this.txtWynC);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "trygonometria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPDNa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPDNb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtWynC;
        private System.Windows.Forms.NumericUpDown nUPDNa;
        private System.Windows.Forms.NumericUpDown nUPDNb;
        private System.Windows.Forms.ComboBox cmbFunkcja;
        private System.Windows.Forms.ComboBox cmbkat;
        private System.Windows.Forms.TextBox txtWynFunkcje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}


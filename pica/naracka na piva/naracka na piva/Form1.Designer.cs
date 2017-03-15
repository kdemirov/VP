namespace naracka_na_piva
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMiddle = new System.Windows.Forms.RadioButton();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.tbSmall = new System.Windows.Forms.TextBox();
            this.tbMiddle = new System.Windows.Forms.TextBox();
            this.tbBig = new System.Windows.Forms.TextBox();
            this.tbKecap = new System.Windows.Forms.TextBox();
            this.tbCheese = new System.Windows.Forms.TextBox();
            this.tbFef = new System.Windows.Forms.TextBox();
            this.tbQuaBeer = new System.Windows.Forms.TextBox();
            this.tbQuaCola = new System.Windows.Forms.TextBox();
            this.tbQuaJuice = new System.Windows.Forms.TextBox();
            this.tbPriceBeer = new System.Windows.Forms.TextBox();
            this.tbPriceCola = new System.Windows.Forms.TextBox();
            this.tbPriceJuice = new System.Windows.Forms.TextBox();
            this.tbBeer = new System.Windows.Forms.TextBox();
            this.tbCola = new System.Windows.Forms.TextBox();
            this.tbJuice = new System.Windows.Forms.TextBox();
            this.tbZaVrakanje = new System.Windows.Forms.TextBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.tbNaplateno = new System.Windows.Forms.TextBox();
            this.cbFef = new System.Windows.Forms.CheckBox();
            this.cbCheese = new System.Windows.Forms.CheckBox();
            this.cbKecap = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDesserts = new System.Windows.Forms.ListBox();
            this.tbPriceDessert = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBig);
            this.groupBox1.Controls.Add(this.tbMiddle);
            this.groupBox1.Controls.Add(this.tbSmall);
            this.groupBox1.Controls.Add(this.rbBig);
            this.groupBox1.Controls.Add(this.rbMiddle);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbKecap);
            this.groupBox2.Controls.Add(this.cbCheese);
            this.groupBox2.Controls.Add(this.cbFef);
            this.groupBox2.Controls.Add(this.tbKecap);
            this.groupBox2.Controls.Add(this.tbFef);
            this.groupBox2.Controls.Add(this.tbCheese);
            this.groupBox2.Location = new System.Drawing.Point(406, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатоци";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbBeer);
            this.groupBox3.Controls.Add(this.tbCola);
            this.groupBox3.Controls.Add(this.tbJuice);
            this.groupBox3.Controls.Add(this.tbPriceBeer);
            this.groupBox3.Controls.Add(this.tbPriceCola);
            this.groupBox3.Controls.Add(this.tbPriceJuice);
            this.groupBox3.Controls.Add(this.tbQuaBeer);
            this.groupBox3.Controls.Add(this.tbQuaCola);
            this.groupBox3.Controls.Add(this.tbQuaJuice);
            this.groupBox3.Location = new System.Drawing.Point(28, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 167);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пијалок";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnOrder);
            this.groupBox4.Controls.Add(this.tbPriceDessert);
            this.groupBox4.Controls.Add(this.lbDesserts);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(28, 444);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 167);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Десерпи";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tbZaVrakanje);
            this.groupBox5.Controls.Add(this.tbSum);
            this.groupBox5.Controls.Add(this.tbNaplateno);
            this.groupBox5.Location = new System.Drawing.Point(406, 444);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(280, 167);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Наплата";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(16, 32);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(14, 13);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMiddle
            // 
            this.rbMiddle.AutoSize = true;
            this.rbMiddle.Location = new System.Drawing.Point(16, 83);
            this.rbMiddle.Name = "rbMiddle";
            this.rbMiddle.Size = new System.Drawing.Size(14, 13);
            this.rbMiddle.TabIndex = 1;
            this.rbMiddle.UseVisualStyleBackColor = true;
            this.rbMiddle.CheckedChanged += new System.EventHandler(this.rbMiddle_CheckedChanged);
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(16, 133);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(14, 13);
            this.rbBig.TabIndex = 2;
            this.rbBig.UseVisualStyleBackColor = true;
            this.rbBig.CheckedChanged += new System.EventHandler(this.rbBig_CheckedChanged);
            // 
            // tbSmall
            // 
            this.tbSmall.Location = new System.Drawing.Point(160, 32);
            this.tbSmall.Name = "tbSmall";
            this.tbSmall.Size = new System.Drawing.Size(100, 20);
            this.tbSmall.TabIndex = 3;
            this.tbSmall.TextChanged += new System.EventHandler(this.tbSmall_TextChanged);
            // 
            // tbMiddle
            // 
            this.tbMiddle.Location = new System.Drawing.Point(160, 80);
            this.tbMiddle.Name = "tbMiddle";
            this.tbMiddle.Size = new System.Drawing.Size(100, 20);
            this.tbMiddle.TabIndex = 4;
            this.tbMiddle.TextChanged += new System.EventHandler(this.tbMiddle_TextChanged);
            // 
            // tbBig
            // 
            this.tbBig.Location = new System.Drawing.Point(160, 130);
            this.tbBig.Name = "tbBig";
            this.tbBig.Size = new System.Drawing.Size(100, 20);
            this.tbBig.TabIndex = 5;
            this.tbBig.TextChanged += new System.EventHandler(this.tbBig_TextChanged);
            // 
            // tbKecap
            // 
            this.tbKecap.Location = new System.Drawing.Point(157, 127);
            this.tbKecap.Name = "tbKecap";
            this.tbKecap.Size = new System.Drawing.Size(100, 20);
            this.tbKecap.TabIndex = 8;
            this.tbKecap.Text = "20";
            this.tbKecap.TextChanged += new System.EventHandler(this.tbKecap_TextChanged);
            // 
            // tbCheese
            // 
            this.tbCheese.Location = new System.Drawing.Point(157, 77);
            this.tbCheese.Name = "tbCheese";
            this.tbCheese.Size = new System.Drawing.Size(100, 20);
            this.tbCheese.TabIndex = 7;
            this.tbCheese.Text = "30";
            this.tbCheese.TextChanged += new System.EventHandler(this.tbCheese_TextChanged);
            // 
            // tbFef
            // 
            this.tbFef.Location = new System.Drawing.Point(157, 29);
            this.tbFef.Name = "tbFef";
            this.tbFef.Size = new System.Drawing.Size(100, 20);
            this.tbFef.TabIndex = 6;
            this.tbFef.Text = "40";
            this.tbFef.TextChanged += new System.EventHandler(this.tbFef_TextChanged);
            // 
            // tbQuaBeer
            // 
            this.tbQuaBeer.Location = new System.Drawing.Point(160, 133);
            this.tbQuaBeer.Name = "tbQuaBeer";
            this.tbQuaBeer.Size = new System.Drawing.Size(100, 20);
            this.tbQuaBeer.TabIndex = 11;
            this.tbQuaBeer.Text = "0";
            this.tbQuaBeer.TextChanged += new System.EventHandler(this.tbQuaBeer_TextChanged);
            // 
            // tbQuaCola
            // 
            this.tbQuaCola.Location = new System.Drawing.Point(160, 35);
            this.tbQuaCola.Name = "tbQuaCola";
            this.tbQuaCola.Size = new System.Drawing.Size(100, 20);
            this.tbQuaCola.TabIndex = 9;
            this.tbQuaCola.Text = "0";
            this.tbQuaCola.TextChanged += new System.EventHandler(this.tbQuaCola_TextChanged);
            // 
            // tbQuaJuice
            // 
            this.tbQuaJuice.Location = new System.Drawing.Point(160, 83);
            this.tbQuaJuice.Name = "tbQuaJuice";
            this.tbQuaJuice.Size = new System.Drawing.Size(100, 20);
            this.tbQuaJuice.TabIndex = 10;
            this.tbQuaJuice.Text = "0";
            this.tbQuaJuice.TextChanged += new System.EventHandler(this.tbQuaJuice_TextChanged);
            // 
            // tbPriceBeer
            // 
            this.tbPriceBeer.Location = new System.Drawing.Point(378, 133);
            this.tbPriceBeer.Name = "tbPriceBeer";
            this.tbPriceBeer.Size = new System.Drawing.Size(100, 20);
            this.tbPriceBeer.TabIndex = 14;
            this.tbPriceBeer.Text = "80";
            this.tbPriceBeer.TextChanged += new System.EventHandler(this.tbPriceBeer_TextChanged);
            // 
            // tbPriceCola
            // 
            this.tbPriceCola.Location = new System.Drawing.Point(378, 35);
            this.tbPriceCola.Name = "tbPriceCola";
            this.tbPriceCola.Size = new System.Drawing.Size(100, 20);
            this.tbPriceCola.TabIndex = 12;
            this.tbPriceCola.Text = "60";
            this.tbPriceCola.TextChanged += new System.EventHandler(this.tbPriceCola_TextChanged);
            // 
            // tbPriceJuice
            // 
            this.tbPriceJuice.Location = new System.Drawing.Point(378, 83);
            this.tbPriceJuice.Name = "tbPriceJuice";
            this.tbPriceJuice.Size = new System.Drawing.Size(100, 20);
            this.tbPriceJuice.TabIndex = 13;
            this.tbPriceJuice.Text = "70";
            this.tbPriceJuice.TextChanged += new System.EventHandler(this.tbPriceJuice_TextChanged);
            // 
            // tbBeer
            // 
            this.tbBeer.Enabled = false;
            this.tbBeer.Location = new System.Drawing.Point(535, 133);
            this.tbBeer.Name = "tbBeer";
            this.tbBeer.Size = new System.Drawing.Size(100, 20);
            this.tbBeer.TabIndex = 17;
            // 
            // tbCola
            // 
            this.tbCola.Enabled = false;
            this.tbCola.Location = new System.Drawing.Point(535, 35);
            this.tbCola.Name = "tbCola";
            this.tbCola.Size = new System.Drawing.Size(100, 20);
            this.tbCola.TabIndex = 15;
            // 
            // tbJuice
            // 
            this.tbJuice.Enabled = false;
            this.tbJuice.Location = new System.Drawing.Point(535, 83);
            this.tbJuice.Name = "tbJuice";
            this.tbJuice.Size = new System.Drawing.Size(100, 20);
            this.tbJuice.TabIndex = 16;
            // 
            // tbZaVrakanje
            // 
            this.tbZaVrakanje.Location = new System.Drawing.Point(157, 133);
            this.tbZaVrakanje.Name = "tbZaVrakanje";
            this.tbZaVrakanje.Size = new System.Drawing.Size(100, 20);
            this.tbZaVrakanje.TabIndex = 20;
            // 
            // tbSum
            // 
            this.tbSum.Enabled = false;
            this.tbSum.Location = new System.Drawing.Point(157, 35);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(100, 20);
            this.tbSum.TabIndex = 18;
            // 
            // tbNaplateno
            // 
            this.tbNaplateno.Location = new System.Drawing.Point(157, 83);
            this.tbNaplateno.Name = "tbNaplateno";
            this.tbNaplateno.Size = new System.Drawing.Size(100, 20);
            this.tbNaplateno.TabIndex = 19;
            this.tbNaplateno.TextChanged += new System.EventHandler(this.tbNaplateno_TextChanged);
            // 
            // cbFef
            // 
            this.cbFef.AutoSize = true;
            this.cbFef.Location = new System.Drawing.Point(7, 34);
            this.cbFef.Name = "cbFef";
            this.cbFef.Size = new System.Drawing.Size(81, 17);
            this.cbFef.TabIndex = 9;
            this.cbFef.Text = "Феферони";
            this.cbFef.UseVisualStyleBackColor = true;
            this.cbFef.CheckedChanged += new System.EventHandler(this.cbFef_CheckedChanged);
            // 
            // cbCheese
            // 
            this.cbCheese.AutoSize = true;
            this.cbCheese.Location = new System.Drawing.Point(7, 80);
            this.cbCheese.Name = "cbCheese";
            this.cbCheese.Size = new System.Drawing.Size(106, 17);
            this.cbCheese.TabIndex = 10;
            this.cbCheese.Text = "Екстра Сирење";
            this.cbCheese.UseVisualStyleBackColor = true;
            this.cbCheese.CheckedChanged += new System.EventHandler(this.cbCheese_CheckedChanged);
            // 
            // cbKecap
            // 
            this.cbKecap.AutoSize = true;
            this.cbKecap.Location = new System.Drawing.Point(7, 127);
            this.cbKecap.Name = "cbKecap";
            this.cbKecap.Size = new System.Drawing.Size(56, 17);
            this.cbKecap.TabIndex = 11;
            this.cbKecap.Text = "Кечап";
            this.cbKecap.UseVisualStyleBackColor = true;
            this.cbKecap.CheckedChanged += new System.EventHandler(this.cbKecap_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Кока Кола/Фанта/Спрајт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Сок од јаболко/Портокал";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Пиво";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Вкупно за наплата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Наплатено";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "За враќање";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Цена на десерт";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Количина";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Цена";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(569, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Вкупно";
            // 
            // lbDesserts
            // 
            this.lbDesserts.FormattingEnabled = true;
            this.lbDesserts.Location = new System.Drawing.Point(16, 42);
            this.lbDesserts.Name = "lbDesserts";
            this.lbDesserts.Size = new System.Drawing.Size(120, 121);
            this.lbDesserts.TabIndex = 24;
            this.lbDesserts.SelectedIndexChanged += new System.EventHandler(this.lbDesserts_SelectedIndexChanged);
            // 
            // tbPriceDessert
            // 
            this.tbPriceDessert.Location = new System.Drawing.Point(160, 70);
            this.tbPriceDessert.Name = "tbPriceDessert";
            this.tbPriceDessert.Size = new System.Drawing.Size(100, 20);
            this.tbPriceDessert.TabIndex = 27;
            this.tbPriceDessert.TextChanged += new System.EventHandler(this.tbPriceDessert_TextChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(160, 96);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 23);
            this.btnOrder.TabIndex = 28;
            this.btnOrder.Text = "Нарачај";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 623);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBig;
        private System.Windows.Forms.TextBox tbMiddle;
        private System.Windows.Forms.TextBox tbSmall;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.RadioButton rbMiddle;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbKecap;
        private System.Windows.Forms.CheckBox cbCheese;
        private System.Windows.Forms.CheckBox cbFef;
        private System.Windows.Forms.TextBox tbKecap;
        private System.Windows.Forms.TextBox tbFef;
        private System.Windows.Forms.TextBox tbCheese;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBeer;
        private System.Windows.Forms.TextBox tbCola;
        private System.Windows.Forms.TextBox tbJuice;
        private System.Windows.Forms.TextBox tbPriceBeer;
        private System.Windows.Forms.TextBox tbPriceCola;
        private System.Windows.Forms.TextBox tbPriceJuice;
        private System.Windows.Forms.TextBox tbQuaBeer;
        private System.Windows.Forms.TextBox tbQuaCola;
        private System.Windows.Forms.TextBox tbQuaJuice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbZaVrakanje;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.TextBox tbNaplateno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox tbPriceDessert;
        private System.Windows.Forms.ListBox lbDesserts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}


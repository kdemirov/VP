namespace WindowsFormsApplication1
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
            this.lbCountries = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbShortName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCapital = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCounty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.laPoints = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.rbA3 = new System.Windows.Forms.RadioButton();
            this.rbA2 = new System.Windows.Forms.RadioButton();
            this.rbA1 = new System.Windows.Forms.RadioButton();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCountries
            // 
            this.lbCountries.FormattingEnabled = true;
            this.lbCountries.Location = new System.Drawing.Point(13, 38);
            this.lbCountries.Name = "lbCountries";
            this.lbCountries.Size = new System.Drawing.Size(244, 485);
            this.lbCountries.TabIndex = 0;
            this.lbCountries.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Drzavi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.tbShortName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCapital);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCounty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(282, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 232);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vnesi Drzava";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Dodadi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(10, 203);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Izbrisi";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbShortName
            // 
            this.tbShortName.Location = new System.Drawing.Point(10, 164);
            this.tbShortName.Name = "tbShortName";
            this.tbShortName.Size = new System.Drawing.Size(311, 20);
            this.tbShortName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kratenka";
            // 
            // tbCapital
            // 
            this.tbCapital.Location = new System.Drawing.Point(9, 108);
            this.tbCapital.Name = "tbCapital";
            this.tbCapital.Size = new System.Drawing.Size(311, 20);
            this.tbCapital.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Glaven Grad";
            // 
            // tbCounty
            // 
            this.tbCounty.Location = new System.Drawing.Point(10, 48);
            this.tbCounty.Name = "tbCounty";
            this.tbCounty.Size = new System.Drawing.Size(311, 20);
            this.tbCounty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.laPoints);
            this.groupBox2.Controls.Add(this.btnGuess);
            this.groupBox2.Controls.Add(this.rbA3);
            this.groupBox2.Controls.Add(this.rbA2);
            this.groupBox2.Controls.Add(this.rbA1);
            this.groupBox2.Controls.Add(this.btnQuestion);
            this.groupBox2.Location = new System.Drawing.Point(282, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 254);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // laPoints
            // 
            this.laPoints.AutoSize = true;
            this.laPoints.Location = new System.Drawing.Point(270, 233);
            this.laPoints.Name = "laPoints";
            this.laPoints.Size = new System.Drawing.Size(24, 13);
            this.laPoints.TabIndex = 5;
            this.laPoints.Text = "0/0";
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(10, 156);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(301, 23);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Pogodi";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // rbA3
            // 
            this.rbA3.AutoSize = true;
            this.rbA3.Location = new System.Drawing.Point(10, 121);
            this.rbA3.Name = "rbA3";
            this.rbA3.Size = new System.Drawing.Size(14, 13);
            this.rbA3.TabIndex = 3;
            this.rbA3.TabStop = true;
            this.rbA3.UseVisualStyleBackColor = true;
            // 
            // rbA2
            // 
            this.rbA2.AutoSize = true;
            this.rbA2.Location = new System.Drawing.Point(10, 98);
            this.rbA2.Name = "rbA2";
            this.rbA2.Size = new System.Drawing.Size(14, 13);
            this.rbA2.TabIndex = 2;
            this.rbA2.TabStop = true;
            this.rbA2.UseVisualStyleBackColor = true;
            // 
            // rbA1
            // 
            this.rbA1.AutoSize = true;
            this.rbA1.Location = new System.Drawing.Point(10, 75);
            this.rbA1.Name = "rbA1";
            this.rbA1.Size = new System.Drawing.Size(14, 13);
            this.rbA1.TabIndex = 1;
            this.rbA1.TabStop = true;
            this.rbA1.UseVisualStyleBackColor = true;
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(10, 20);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(301, 23);
            this.btnQuestion.TabIndex = 0;
            this.btnQuestion.Text = "?";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbCountries);
            this.Name = "Form1";
            this.Text = "Lista na drzavi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCountries;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbShortName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCounty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label laPoints;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.RadioButton rbA3;
        private System.Windows.Forms.RadioButton rbA2;
        private System.Windows.Forms.RadioButton rbA1;
        private System.Windows.Forms.Button btnQuestion;
    }
}


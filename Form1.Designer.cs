namespace WindowsFormsApp1
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
            this.Ucitaj_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_test = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Vrijednost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NajveciZad = new System.Windows.Forms.Button();
            this.SpremiZad = new System.Windows.Forms.Button();
            this.UcitajZad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GradZad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrstanZad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrzavaZad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.Ucitaj_button);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_test);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(496, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Ucitaj_button
            // 
            this.Ucitaj_button.BackColor = System.Drawing.SystemColors.Control;
            this.Ucitaj_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Ucitaj_button.Location = new System.Drawing.Point(32, 217);
            this.Ucitaj_button.Name = "Ucitaj_button";
            this.Ucitaj_button.Size = new System.Drawing.Size(75, 23);
            this.Ucitaj_button.TabIndex = 5;
            this.Ucitaj_button.Text = "Ucitaj";
            this.Ucitaj_button.UseVisualStyleBackColor = false;
            this.Ucitaj_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(211, 260);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(75, 23);
            this.button_test.TabIndex = 1;
            this.button_test.Text = "TEST!";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vrijednost,
            this.Opis});
            this.dataGridView1.Location = new System.Drawing.Point(22, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 165);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Vrijednost
            // 
            this.Vrijednost.HeaderText = "Vrijednost";
            this.Vrijednost.Name = "Vrijednost";
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.Controls.Add(this.NajveciZad);
            this.groupBox2.Controls.Add(this.SpremiZad);
            this.groupBox2.Controls.Add(this.UcitajZad);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(496, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 298);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "zadatak";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // NajveciZad
            // 
            this.NajveciZad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NajveciZad.Location = new System.Drawing.Point(185, 201);
            this.NajveciZad.Name = "NajveciZad";
            this.NajveciZad.Size = new System.Drawing.Size(99, 39);
            this.NajveciZad.TabIndex = 10;
            this.NajveciZad.Text = "Najveci grad";
            this.NajveciZad.UseVisualStyleBackColor = false;
            // 
            // SpremiZad
            // 
            this.SpremiZad.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SpremiZad.Location = new System.Drawing.Point(6, 201);
            this.SpremiZad.Name = "SpremiZad";
            this.SpremiZad.Size = new System.Drawing.Size(101, 39);
            this.SpremiZad.TabIndex = 9;
            this.SpremiZad.Text = "Spremi u XML";
            this.SpremiZad.UseVisualStyleBackColor = false;
            this.SpremiZad.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // UcitajZad
            // 
            this.UcitajZad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.UcitajZad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UcitajZad.Location = new System.Drawing.Point(209, 173);
            this.UcitajZad.Name = "UcitajZad";
            this.UcitajZad.Size = new System.Drawing.Size(75, 23);
            this.UcitajZad.TabIndex = 8;
            this.UcitajZad.Text = "Ucitaj";
            this.UcitajZad.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradZad,
            this.BrstanZad,
            this.DrzavaZad});
            this.dataGridView2.Location = new System.Drawing.Point(6, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(278, 150);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // GradZad
            // 
            this.GradZad.HeaderText = "Grad";
            this.GradZad.Name = "GradZad";
            this.GradZad.Width = 75;
            // 
            // BrstanZad
            // 
            this.BrstanZad.HeaderText = "Broj stanovnika";
            this.BrstanZad.Name = "BrstanZad";
            this.BrstanZad.Width = 80;
            // 
            // DrzavaZad
            // 
            this.DrzavaZad.HeaderText = "Drzava";
            this.DrzavaZad.Name = "DrzavaZad";
            this.DrzavaZad.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(793, 617);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijednost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Ucitaj_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UcitajZad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradZad;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrstanZad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaZad;
        private System.Windows.Forms.Button NajveciZad;
        private System.Windows.Forms.Button SpremiZad;
    }
}


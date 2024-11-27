namespace sortiranjeVozila
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxGodProizvodnje = new System.Windows.Forms.TextBox();
            this.textBoxKilometraza = new System.Windows.Forms.TextBox();
            this.textBoxIspis = new System.Windows.Forms.TextBox();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.buttonSortiraj = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSmjerSortiranja = new System.Windows.Forms.ComboBox();
            this.btnSpremiXML = new System.Windows.Forms.Button();
            this.btnUcitajXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina Proizvodnje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kilometraza:";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(15, 36);
            this.textBoxMarka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(223, 26);
            this.textBoxMarka.TabIndex = 5;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(12, 104);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(226, 26);
            this.textBoxModel.TabIndex = 6;
            // 
            // textBoxGodProizvodnje
            // 
            this.textBoxGodProizvodnje.Location = new System.Drawing.Point(13, 170);
            this.textBoxGodProizvodnje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGodProizvodnje.Name = "textBoxGodProizvodnje";
            this.textBoxGodProizvodnje.Size = new System.Drawing.Size(225, 26);
            this.textBoxGodProizvodnje.TabIndex = 7;
            // 
            // textBoxKilometraza
            // 
            this.textBoxKilometraza.Location = new System.Drawing.Point(12, 239);
            this.textBoxKilometraza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKilometraza.Name = "textBoxKilometraza";
            this.textBoxKilometraza.Size = new System.Drawing.Size(226, 26);
            this.textBoxKilometraza.TabIndex = 8;
            // 
            // textBoxIspis
            // 
            this.textBoxIspis.Location = new System.Drawing.Point(271, 79);
            this.textBoxIspis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIspis.Multiline = true;
            this.textBoxIspis.Name = "textBoxIspis";
            this.textBoxIspis.Size = new System.Drawing.Size(579, 377);
            this.textBoxIspis.TabIndex = 9;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(12, 290);
            this.btnDodajVozilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(226, 41);
            this.btnDodajVozilo.TabIndex = 10;
            this.btnDodajVozilo.Text = "Dodaj Vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // buttonSortiraj
            // 
            this.buttonSortiraj.Location = new System.Drawing.Point(12, 417);
            this.buttonSortiraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSortiraj.Name = "buttonSortiraj";
            this.buttonSortiraj.Size = new System.Drawing.Size(226, 39);
            this.buttonSortiraj.TabIndex = 11;
            this.buttonSortiraj.Text = "Sortiraj";
            this.buttonSortiraj.UseVisualStyleBackColor = true;
            this.buttonSortiraj.Click += new System.EventHandler(this.buttonSortiraj_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Marka",
            "Model",
            "Godina Proizvodnje",
            "Kilometraza"});
            this.comboBox1.Location = new System.Drawing.Point(12, 359);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Sortiranje";
            // 
            // comboBoxSmjerSortiranja
            // 
            this.comboBoxSmjerSortiranja.FormattingEnabled = true;
            this.comboBoxSmjerSortiranja.Items.AddRange(new object[] {
            "Silazno",
            "Uzlazno"});
            this.comboBoxSmjerSortiranja.Location = new System.Drawing.Point(271, 36);
            this.comboBoxSmjerSortiranja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSmjerSortiranja.Name = "comboBoxSmjerSortiranja";
            this.comboBoxSmjerSortiranja.Size = new System.Drawing.Size(226, 28);
            this.comboBoxSmjerSortiranja.TabIndex = 13;
            this.comboBoxSmjerSortiranja.Text = "Uzlazno/Silazno";
            // 
            // btnSpremiXML
            // 
            this.btnSpremiXML.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSpremiXML.Location = new System.Drawing.Point(522, 36);
            this.btnSpremiXML.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSpremiXML.Name = "btnSpremiXML";
            this.btnSpremiXML.Size = new System.Drawing.Size(152, 35);
            this.btnSpremiXML.TabIndex = 14;
            this.btnSpremiXML.Text = "Spremi u XML";
            this.btnSpremiXML.UseVisualStyleBackColor = false;
            this.btnSpremiXML.Click += new System.EventHandler(this.btnSpremiXML_Click);
            // 
            // btnUcitajXML
            // 
            this.btnUcitajXML.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUcitajXML.Location = new System.Drawing.Point(698, 36);
            this.btnUcitajXML.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUcitajXML.Name = "btnUcitajXML";
            this.btnUcitajXML.Size = new System.Drawing.Size(152, 35);
            this.btnUcitajXML.TabIndex = 15;
            this.btnUcitajXML.Text = "Učitaj XML";
            this.btnUcitajXML.UseVisualStyleBackColor = false;
            this.btnUcitajXML.Click += new System.EventHandler(this.btnUcitajXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 495);
            this.Controls.Add(this.btnUcitajXML);
            this.Controls.Add(this.btnSpremiXML);
            this.Controls.Add(this.comboBoxSmjerSortiranja);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSortiraj);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.textBoxIspis);
            this.Controls.Add(this.textBoxKilometraza);
            this.Controls.Add(this.textBoxGodProizvodnje);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxGodProizvodnje;
        private System.Windows.Forms.TextBox textBoxKilometraza;
        private System.Windows.Forms.TextBox textBoxIspis;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button buttonSortiraj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxSmjerSortiranja;
        private System.Windows.Forms.Button btnSpremiXML;
        private System.Windows.Forms.Button btnUcitajXML;
    }
}


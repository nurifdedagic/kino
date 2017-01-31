namespace Kino
{
    partial class Administracija
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
            this.components = new System.ComponentModel.Container();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.Korisnici = new System.Windows.Forms.TabPage();
            this.buttonIzlazAdmin = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonDodajKorisnika = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.labelSifra = new System.Windows.Forms.Label();
            this.textBoxKorisničkoIme = new System.Windows.Forms.TextBox();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.buttonPrikažiDodavanjeKorisnika = new System.Windows.Forms.Button();
            this.buttonIzbrisiKorisnika = new System.Windows.Forms.Button();
            this.listBoxKorisnici = new System.Windows.Forms.ListBox();
            this.Projekcije1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlAdmin.SuspendLayout();
            this.Korisnici.SuspendLayout();
            this.Projekcije1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.Korisnici);
            this.tabControlAdmin.Controls.Add(this.Projekcije1);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.Padding = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(488, 410);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // Korisnici
            // 
            this.Korisnici.BackgroundImage = global::Kino.Properties.Resources.background;
            this.Korisnici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Korisnici.Controls.Add(this.buttonIzlazAdmin);
            this.Korisnici.Controls.Add(this.buttonOdustani);
            this.Korisnici.Controls.Add(this.buttonDodajKorisnika);
            this.Korisnici.Controls.Add(this.checkBoxAdmin);
            this.Korisnici.Controls.Add(this.textBoxSifra);
            this.Korisnici.Controls.Add(this.labelSifra);
            this.Korisnici.Controls.Add(this.textBoxKorisničkoIme);
            this.Korisnici.Controls.Add(this.labelKorisnickoIme);
            this.Korisnici.Controls.Add(this.buttonPrikažiDodavanjeKorisnika);
            this.Korisnici.Controls.Add(this.buttonIzbrisiKorisnika);
            this.Korisnici.Controls.Add(this.listBoxKorisnici);
            this.Korisnici.Location = new System.Drawing.Point(4, 25);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Padding = new System.Windows.Forms.Padding(3);
            this.Korisnici.Size = new System.Drawing.Size(480, 381);
            this.Korisnici.TabIndex = 0;
            this.Korisnici.Text = "Korisnici";
            this.Korisnici.UseVisualStyleBackColor = true;
            // 
            // buttonIzlazAdmin
            // 
            this.buttonIzlazAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzlazAdmin.Location = new System.Drawing.Point(403, 19);
            this.buttonIzlazAdmin.Name = "buttonIzlazAdmin";
            this.buttonIzlazAdmin.Size = new System.Drawing.Size(69, 27);
            this.buttonIzlazAdmin.TabIndex = 10;
            this.buttonIzlazAdmin.Text = "Nazad";
            this.buttonIzlazAdmin.UseVisualStyleBackColor = true;
            this.buttonIzlazAdmin.Click += new System.EventHandler(this.buttonIzlazAdmin_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdustani.Location = new System.Drawing.Point(327, 227);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(100, 32);
            this.buttonOdustani.TabIndex = 9;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Visible = false;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonDodajKorisnika
            // 
            this.buttonDodajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajKorisnika.Location = new System.Drawing.Point(231, 227);
            this.buttonDodajKorisnika.Name = "buttonDodajKorisnika";
            this.buttonDodajKorisnika.Size = new System.Drawing.Size(90, 32);
            this.buttonDodajKorisnika.TabIndex = 8;
            this.buttonDodajKorisnika.Text = "Dodaj";
            this.buttonDodajKorisnika.UseVisualStyleBackColor = true;
            this.buttonDodajKorisnika.Visible = false;
            this.buttonDodajKorisnika.Click += new System.EventHandler(this.buttonDodajKorisnika_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Checked = true;
            this.checkBoxAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxAdmin.Location = new System.Drawing.Point(231, 195);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(110, 21);
            this.checkBoxAdmin.TabIndex = 7;
            this.checkBoxAdmin.Text = "Administrator";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            this.checkBoxAdmin.Visible = false;
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSifra.Location = new System.Drawing.Point(231, 150);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(196, 26);
            this.textBoxSifra.TabIndex = 6;
            this.textBoxSifra.Visible = false;
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSifra.Location = new System.Drawing.Point(227, 125);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(42, 20);
            this.labelSifra.TabIndex = 5;
            this.labelSifra.Text = "Šifra";
            this.labelSifra.Visible = false;
            // 
            // textBoxKorisničkoIme
            // 
            this.textBoxKorisničkoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKorisničkoIme.Location = new System.Drawing.Point(231, 82);
            this.textBoxKorisničkoIme.Name = "textBoxKorisničkoIme";
            this.textBoxKorisničkoIme.Size = new System.Drawing.Size(196, 26);
            this.textBoxKorisničkoIme.TabIndex = 4;
            this.textBoxKorisničkoIme.Visible = false;
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKorisnickoIme.Location = new System.Drawing.Point(227, 57);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(110, 20);
            this.labelKorisnickoIme.TabIndex = 3;
            this.labelKorisnickoIme.Text = "Korisničko ime";
            this.labelKorisnickoIme.Visible = false;
            // 
            // buttonPrikažiDodavanjeKorisnika
            // 
            this.buttonPrikažiDodavanjeKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrikažiDodavanjeKorisnika.Location = new System.Drawing.Point(42, 309);
            this.buttonPrikažiDodavanjeKorisnika.Name = "buttonPrikažiDodavanjeKorisnika";
            this.buttonPrikažiDodavanjeKorisnika.Size = new System.Drawing.Size(139, 31);
            this.buttonPrikažiDodavanjeKorisnika.TabIndex = 2;
            this.buttonPrikažiDodavanjeKorisnika.Text = "Dodaj korisnika";
            this.buttonPrikažiDodavanjeKorisnika.UseVisualStyleBackColor = true;
            this.buttonPrikažiDodavanjeKorisnika.Click += new System.EventHandler(this.buttonPrikažiDodavanjeKorisnika_Click);
            // 
            // buttonIzbrisiKorisnika
            // 
            this.buttonIzbrisiKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzbrisiKorisnika.Location = new System.Drawing.Point(42, 271);
            this.buttonIzbrisiKorisnika.Name = "buttonIzbrisiKorisnika";
            this.buttonIzbrisiKorisnika.Size = new System.Drawing.Size(139, 32);
            this.buttonIzbrisiKorisnika.TabIndex = 1;
            this.buttonIzbrisiKorisnika.Text = "Izbriši korisnika";
            this.buttonIzbrisiKorisnika.UseVisualStyleBackColor = true;
            this.buttonIzbrisiKorisnika.Click += new System.EventHandler(this.buttonIzbrisiKorisnika_Click);
            // 
            // listBoxKorisnici
            // 
            this.listBoxKorisnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxKorisnici.FormattingEnabled = true;
            this.listBoxKorisnici.ItemHeight = 20;
            this.listBoxKorisnici.Location = new System.Drawing.Point(42, 35);
            this.listBoxKorisnici.Margin = new System.Windows.Forms.Padding(15);
            this.listBoxKorisnici.Name = "listBoxKorisnici";
            this.listBoxKorisnici.ScrollAlwaysVisible = true;
            this.listBoxKorisnici.Size = new System.Drawing.Size(139, 224);
            this.listBoxKorisnici.Sorted = true;
            this.listBoxKorisnici.TabIndex = 0;
            // 
            // Projekcije1
            // 
            this.Projekcije1.Controls.Add(this.button1);
            this.Projekcije1.Controls.Add(this.comboBox1);
            this.Projekcije1.Controls.Add(this.label1);
            this.Projekcije1.Controls.Add(this.dataGridView1);
            this.Projekcije1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Projekcije1.Location = new System.Drawing.Point(4, 25);
            this.Projekcije1.Name = "Projekcije1";
            this.Projekcije1.Padding = new System.Windows.Forms.Padding(3);
            this.Projekcije1.Size = new System.Drawing.Size(480, 381);
            this.Projekcije1.TabIndex = 1;
            this.Projekcije1.Text = "Projekcije";
            this.Projekcije1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(403, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ant-man",
            "Batman v Superman",
            "Civil wars",
            "Finding Nemo",
            "Mechanic",
            "Rise guardians",
            "Star Wars: The force awakens",
            "Tarzan",
            "The jungle book",
            "The revenant"});
            this.comboBox1.Location = new System.Drawing.Point(60, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 32);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataSource = typeof(Kino.Login);
            // 
            // Administracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 410);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "Administracija";
            this.Text = "Administracija";
            this.tabControlAdmin.ResumeLayout(false);
            this.Korisnici.ResumeLayout(false);
            this.Korisnici.PerformLayout();
            this.Projekcije1.ResumeLayout(false);
            this.Projekcije1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage Korisnici;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonDodajKorisnika;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.TextBox textBoxKorisničkoIme;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Button buttonPrikažiDodavanjeKorisnika;
        private System.Windows.Forms.Button buttonIzbrisiKorisnika;
        private System.Windows.Forms.ListBox listBoxKorisnici;
        private System.Windows.Forms.TabPage Projekcije1;
        private System.Windows.Forms.Button buttonIzlazAdmin;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}
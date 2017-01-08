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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.Projekcije = new System.Windows.Forms.TabPage();
            this.Korisnici = new System.Windows.Forms.TabPage();
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
            this.buttonIzlazAdmin = new System.Windows.Forms.Button();
            this.tabControlAdmin.SuspendLayout();
            this.Korisnici.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.Korisnici);
            this.tabControlAdmin.Controls.Add(this.Projekcije);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.Padding = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(488, 410);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // Projekcije
            // 
            this.Projekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Projekcije.Location = new System.Drawing.Point(4, 26);
            this.Projekcije.Name = "Projekcije";
            this.Projekcije.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Projekcije.Size = new System.Drawing.Size(480, 380);
            this.Projekcije.TabIndex = 1;
            this.Projekcije.Text = "Projekcije";
            this.Projekcije.UseVisualStyleBackColor = true;
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
            this.Korisnici.Location = new System.Drawing.Point(4, 26);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Korisnici.Size = new System.Drawing.Size(480, 380);
            this.Korisnici.TabIndex = 0;
            this.Korisnici.Text = "Korisnici";
            this.Korisnici.UseVisualStyleBackColor = true;
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
            this.checkBoxAdmin.Size = new System.Drawing.Size(114, 22);
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
            this.textBoxSifra.Size = new System.Drawing.Size(196, 27);
            this.textBoxSifra.TabIndex = 6;
            this.textBoxSifra.Visible = false;
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSifra.Location = new System.Drawing.Point(227, 125);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(47, 22);
            this.labelSifra.TabIndex = 5;
            this.labelSifra.Text = "Šifra";
            this.labelSifra.Visible = false;
            // 
            // textBoxKorisničkoIme
            // 
            this.textBoxKorisničkoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKorisničkoIme.Location = new System.Drawing.Point(231, 82);
            this.textBoxKorisničkoIme.Name = "textBoxKorisničkoIme";
            this.textBoxKorisničkoIme.Size = new System.Drawing.Size(196, 27);
            this.textBoxKorisničkoIme.TabIndex = 4;
            this.textBoxKorisničkoIme.Visible = false;
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKorisnickoIme.Location = new System.Drawing.Point(227, 57);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(126, 22);
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
            this.listBoxKorisnici.Items.AddRange(new object[] {
            "Korisnik 1",
            "Korisnik 2",
            "Korisnik 3",
            "Korisnik 4"});
            this.listBoxKorisnici.Location = new System.Drawing.Point(42, 35);
            this.listBoxKorisnici.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.listBoxKorisnici.Name = "listBoxKorisnici";
            this.listBoxKorisnici.ScrollAlwaysVisible = true;
            this.listBoxKorisnici.Size = new System.Drawing.Size(139, 224);
            this.listBoxKorisnici.Sorted = true;
            this.listBoxKorisnici.TabIndex = 0;
            // 
            // buttonIzlazAdmin
            // 
            this.buttonIzlazAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzlazAdmin.Location = new System.Drawing.Point(411, 0);
            this.buttonIzlazAdmin.Name = "buttonIzlazAdmin";
            this.buttonIzlazAdmin.Size = new System.Drawing.Size(69, 27);
            this.buttonIzlazAdmin.TabIndex = 10;
            this.buttonIzlazAdmin.Text = "Izlaz";
            this.buttonIzlazAdmin.UseVisualStyleBackColor = true;
            this.buttonIzlazAdmin.Click += new System.EventHandler(this.buttonIzlazAdmin_Click);
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
        private System.Windows.Forms.TabPage Projekcije;
        private System.Windows.Forms.Button buttonIzlazAdmin;
    }
}
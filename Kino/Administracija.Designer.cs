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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.Korisnici.Controls.Add(this.button3);
            this.Korisnici.Controls.Add(this.button1);
            this.Korisnici.Controls.Add(this.checkBoxAdmin);
            this.Korisnici.Controls.Add(this.textBox2);
            this.Korisnici.Controls.Add(this.label1);
            this.Korisnici.Controls.Add(this.textBox1);
            this.Korisnici.Controls.Add(this.labelKorisnickoIme);
            this.Korisnici.Controls.Add(this.button2);
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(327, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "Odustani";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(231, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(231, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 27);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(227, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Šifra";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(231, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 27);
            this.textBox1.TabIndex = 4;
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
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(42, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dodaj korisnika";
            this.button2.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonIzbrisiKorisnika;
        private System.Windows.Forms.ListBox listBoxKorisnici;
        private System.Windows.Forms.TabPage Projekcije;
        private System.Windows.Forms.Button buttonIzlazAdmin;
    }
}
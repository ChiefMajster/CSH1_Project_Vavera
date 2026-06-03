namespace SkiArealManager
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtNazev = new System.Windows.Forms.TextBox();
            this.cmbVyber = new System.Windows.Forms.ComboBox();
            this.txtPocet = new System.Windows.Forms.TextBox();
            this.lblZadejteNazev = new System.Windows.Forms.Label();
            this.lblZvolte = new System.Windows.Forms.Label();
            this.lblZadejtePocet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPridat = new System.Windows.Forms.Button();
            this.btnOdebrat = new System.Windows.Forms.Button();
            this.btnEditovat = new System.Windows.Forms.Button();
            this.lblPocet = new System.Windows.Forms.Label();
            this.lblInfoSjezdovkyIdNazev = new System.Windows.Forms.Label();
            this.lblInfoSjezdovkyObtiznost = new System.Windows.Forms.Label();
            this.lblInfoSjezdovkyDelka = new System.Windows.Forms.Label();
            this.btnZpet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(272, 56);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(276, 277);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.polozkaDoubleClick);
            // 
            // txtNazev
            // 
            this.txtNazev.Location = new System.Drawing.Point(394, 339);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Size = new System.Drawing.Size(121, 20);
            this.txtNazev.TabIndex = 1;
            // 
            // cmbVyber
            // 
            this.cmbVyber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVyber.FormattingEnabled = true;
            this.cmbVyber.Location = new System.Drawing.Point(394, 368);
            this.cmbVyber.Name = "cmbVyber";
            this.cmbVyber.Size = new System.Drawing.Size(121, 21);
            this.cmbVyber.TabIndex = 2;
            // 
            // txtPocet
            // 
            this.txtPocet.Location = new System.Drawing.Point(394, 395);
            this.txtPocet.Name = "txtPocet";
            this.txtPocet.Size = new System.Drawing.Size(121, 20);
            this.txtPocet.TabIndex = 3;
            // 
            // lblZadejteNazev
            // 
            this.lblZadejteNazev.AutoSize = true;
            this.lblZadejteNazev.Location = new System.Drawing.Point(299, 342);
            this.lblZadejteNazev.Name = "lblZadejteNazev";
            this.lblZadejteNazev.Size = new System.Drawing.Size(78, 13);
            this.lblZadejteNazev.TabIndex = 4;
            this.lblZadejteNazev.Text = "Zadejte název:";
            // 
            // lblZvolte
            // 
            this.lblZvolte.AutoSize = true;
            this.lblZvolte.Location = new System.Drawing.Point(299, 371);
            this.lblZvolte.Name = "lblZvolte";
            this.lblZvolte.Size = new System.Drawing.Size(87, 13);
            this.lblZvolte.TabIndex = 5;
            this.lblZvolte.Text = "Zvolte obtížnost:";
            // 
            // lblZadejtePocet
            // 
            this.lblZadejtePocet.AutoSize = true;
            this.lblZadejtePocet.Location = new System.Drawing.Point(299, 398);
            this.lblZadejtePocet.Name = "lblZadejtePocet";
            this.lblZadejtePocet.Size = new System.Drawing.Size(75, 13);
            this.lblZadejtePocet.TabIndex = 6;
            this.lblZadejtePocet.Text = "Zadejte délku:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(258, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Evidence sjezdovek ve skiareálu";
            // 
            // btnPridat
            // 
            this.btnPridat.Location = new System.Drawing.Point(212, 434);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(129, 23);
            this.btnPridat.TabIndex = 9;
            this.btnPridat.Text = "Přidat Sjezdovku";
            this.btnPridat.UseVisualStyleBackColor = true;
            this.btnPridat.Click += new System.EventHandler(this.btnPridat_Click);
            // 
            // btnOdebrat
            // 
            this.btnOdebrat.Location = new System.Drawing.Point(347, 434);
            this.btnOdebrat.Name = "btnOdebrat";
            this.btnOdebrat.Size = new System.Drawing.Size(120, 23);
            this.btnOdebrat.TabIndex = 10;
            this.btnOdebrat.Text = "Odebrat Sjezdovku";
            this.btnOdebrat.UseVisualStyleBackColor = true;
            this.btnOdebrat.Click += new System.EventHandler(this.btnOdebrat_Click);
            // 
            // btnEditovat
            // 
            this.btnEditovat.Location = new System.Drawing.Point(473, 434);
            this.btnEditovat.Name = "btnEditovat";
            this.btnEditovat.Size = new System.Drawing.Size(129, 23);
            this.btnEditovat.TabIndex = 11;
            this.btnEditovat.Text = "Editovat Sjezdovku";
            this.btnEditovat.UseVisualStyleBackColor = true;
            this.btnEditovat.Click += new System.EventHandler(this.btnEditovat_Click);
            // 
            // lblPocet
            // 
            this.lblPocet.AutoSize = true;
            this.lblPocet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPocet.Location = new System.Drawing.Point(521, 402);
            this.lblPocet.Name = "lblPocet";
            this.lblPocet.Size = new System.Drawing.Size(33, 13);
            this.lblPocet.TabIndex = 12;
            this.lblPocet.Text = "metrů";
            // 
            // lblInfoSjezdovkyIdNazev
            // 
            this.lblInfoSjezdovkyIdNazev.AutoSize = true;
            this.lblInfoSjezdovkyIdNazev.Location = new System.Drawing.Point(617, 132);
            this.lblInfoSjezdovkyIdNazev.Name = "lblInfoSjezdovkyIdNazev";
            this.lblInfoSjezdovkyIdNazev.Size = new System.Drawing.Size(0, 13);
            this.lblInfoSjezdovkyIdNazev.TabIndex = 14;
            this.lblInfoSjezdovkyIdNazev.Visible = false;
            // 
            // lblInfoSjezdovkyObtiznost
            // 
            this.lblInfoSjezdovkyObtiznost.AutoSize = true;
            this.lblInfoSjezdovkyObtiznost.Location = new System.Drawing.Point(617, 155);
            this.lblInfoSjezdovkyObtiznost.Name = "lblInfoSjezdovkyObtiznost";
            this.lblInfoSjezdovkyObtiznost.Size = new System.Drawing.Size(0, 13);
            this.lblInfoSjezdovkyObtiznost.TabIndex = 15;
            this.lblInfoSjezdovkyObtiznost.Visible = false;
            // 
            // lblInfoSjezdovkyDelka
            // 
            this.lblInfoSjezdovkyDelka.AutoSize = true;
            this.lblInfoSjezdovkyDelka.Location = new System.Drawing.Point(617, 178);
            this.lblInfoSjezdovkyDelka.Name = "lblInfoSjezdovkyDelka";
            this.lblInfoSjezdovkyDelka.Size = new System.Drawing.Size(0, 13);
            this.lblInfoSjezdovkyDelka.TabIndex = 16;
            this.lblInfoSjezdovkyDelka.Visible = false;
            // 
            // btnZpet
            // 
            this.btnZpet.Location = new System.Drawing.Point(191, 56);
            this.btnZpet.Name = "btnZpet";
            this.btnZpet.Size = new System.Drawing.Size(75, 23);
            this.btnZpet.TabIndex = 17;
            this.btnZpet.Text = "zpět";
            this.btnZpet.UseVisualStyleBackColor = true;
            this.btnZpet.Visible = false;
            this.btnZpet.Click += new System.EventHandler(this.btnZpet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnZpet);
            this.Controls.Add(this.lblInfoSjezdovkyDelka);
            this.Controls.Add(this.lblInfoSjezdovkyObtiznost);
            this.Controls.Add(this.lblInfoSjezdovkyIdNazev);
            this.Controls.Add(this.lblPocet);
            this.Controls.Add(this.btnEditovat);
            this.Controls.Add(this.btnOdebrat);
            this.Controls.Add(this.btnPridat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblZadejtePocet);
            this.Controls.Add(this.lblZvolte);
            this.Controls.Add(this.lblZadejteNazev);
            this.Controls.Add(this.txtPocet);
            this.Controls.Add(this.cmbVyber);
            this.Controls.Add(this.txtNazev);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtNazev;
        private System.Windows.Forms.ComboBox cmbVyber;
        private System.Windows.Forms.TextBox txtPocet;
        private System.Windows.Forms.Label lblZadejteNazev;
        private System.Windows.Forms.Label lblZvolte;
        private System.Windows.Forms.Label lblZadejtePocet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.Button btnOdebrat;
        private System.Windows.Forms.Button btnEditovat;
        private System.Windows.Forms.Label lblPocet;
        private System.Windows.Forms.Label lblInfoSjezdovkyIdNazev;
        private System.Windows.Forms.Label lblInfoSjezdovkyObtiznost;
        private System.Windows.Forms.Label lblInfoSjezdovkyDelka;
        private System.Windows.Forms.Button btnZpet;
    }
}


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
            this.listBoxSjezdovky = new System.Windows.Forms.ListBox();
            this.txtNazevSjezdovky = new System.Windows.Forms.TextBox();
            this.cmbObtiznost = new System.Windows.Forms.ComboBox();
            this.txtDelkaSjezdovky = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPridatSjezdovku = new System.Windows.Forms.Button();
            this.btnOdebratSjezdovku = new System.Windows.Forms.Button();
            this.btnEditovatSjezdovku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSjezdovky
            // 
            this.listBoxSjezdovky.FormattingEnabled = true;
            this.listBoxSjezdovky.Location = new System.Drawing.Point(272, 56);
            this.listBoxSjezdovky.Name = "listBoxSjezdovky";
            this.listBoxSjezdovky.Size = new System.Drawing.Size(276, 277);
            this.listBoxSjezdovky.TabIndex = 0;
            this.listBoxSjezdovky.SelectedIndexChanged += new System.EventHandler(this.listBoxSjezdovky_SelectedIndexChanged);
            // 
            // txtNazevSjezdovky
            // 
            this.txtNazevSjezdovky.Location = new System.Drawing.Point(394, 339);
            this.txtNazevSjezdovky.Name = "txtNazevSjezdovky";
            this.txtNazevSjezdovky.Size = new System.Drawing.Size(121, 20);
            this.txtNazevSjezdovky.TabIndex = 1;
            // 
            // cmbObtiznost
            // 
            this.cmbObtiznost.FormattingEnabled = true;
            this.cmbObtiznost.Location = new System.Drawing.Point(394, 368);
            this.cmbObtiznost.Name = "cmbObtiznost";
            this.cmbObtiznost.Size = new System.Drawing.Size(121, 21);
            this.cmbObtiznost.TabIndex = 2;
            // 
            // txtDelkaSjezdovky
            // 
            this.txtDelkaSjezdovky.Location = new System.Drawing.Point(394, 395);
            this.txtDelkaSjezdovky.Name = "txtDelkaSjezdovky";
            this.txtDelkaSjezdovky.Size = new System.Drawing.Size(121, 20);
            this.txtDelkaSjezdovky.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zadejte název:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zvolte obtížnost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zadejte délku:";
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
            // btnPridatSjezdovku
            // 
            this.btnPridatSjezdovku.Location = new System.Drawing.Point(212, 434);
            this.btnPridatSjezdovku.Name = "btnPridatSjezdovku";
            this.btnPridatSjezdovku.Size = new System.Drawing.Size(129, 23);
            this.btnPridatSjezdovku.TabIndex = 9;
            this.btnPridatSjezdovku.Text = "Přidat Sjezdovku";
            this.btnPridatSjezdovku.UseVisualStyleBackColor = true;
            this.btnPridatSjezdovku.Click += new System.EventHandler(this.btnPridatSjezdovku_Click);
            // 
            // btnOdebratSjezdovku
            // 
            this.btnOdebratSjezdovku.Location = new System.Drawing.Point(347, 434);
            this.btnOdebratSjezdovku.Name = "btnOdebratSjezdovku";
            this.btnOdebratSjezdovku.Size = new System.Drawing.Size(120, 23);
            this.btnOdebratSjezdovku.TabIndex = 10;
            this.btnOdebratSjezdovku.Text = "Odebrat Sjezdovku";
            this.btnOdebratSjezdovku.UseVisualStyleBackColor = true;
            this.btnOdebratSjezdovku.Click += new System.EventHandler(this.btnOdebratSjezdovku_Click);
            // 
            // btnEditovatSjezdovku
            // 
            this.btnEditovatSjezdovku.Location = new System.Drawing.Point(473, 434);
            this.btnEditovatSjezdovku.Name = "btnEditovatSjezdovku";
            this.btnEditovatSjezdovku.Size = new System.Drawing.Size(129, 23);
            this.btnEditovatSjezdovku.TabIndex = 11;
            this.btnEditovatSjezdovku.Text = "Editovat Sjezdovku";
            this.btnEditovatSjezdovku.UseVisualStyleBackColor = true;
            this.btnEditovatSjezdovku.Click += new System.EventHandler(this.btnEditovatSjezdovku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnEditovatSjezdovku);
            this.Controls.Add(this.btnOdebratSjezdovku);
            this.Controls.Add(this.btnPridatSjezdovku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelkaSjezdovky);
            this.Controls.Add(this.cmbObtiznost);
            this.Controls.Add(this.txtNazevSjezdovky);
            this.Controls.Add(this.listBoxSjezdovky);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSjezdovky;
        private System.Windows.Forms.TextBox txtNazevSjezdovky;
        private System.Windows.Forms.ComboBox cmbObtiznost;
        private System.Windows.Forms.TextBox txtDelkaSjezdovky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPridatSjezdovku;
        private System.Windows.Forms.Button btnOdebratSjezdovku;
        private System.Windows.Forms.Button btnEditovatSjezdovku;
    }
}


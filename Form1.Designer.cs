
namespace koledar
{
    partial class Koledar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Koledar));
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextDate = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHiden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTorek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSreda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnČetrtek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPetek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSobota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNedeljaa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.buttonSkok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMesec = new System.Windows.Forms.Label();
            this.labelLeto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxYear
            // 
            this.textBoxYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxYear.Location = new System.Drawing.Point(299, 44);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 26);
            this.textBoxYear.TabIndex = 0;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "Marec",
            "April",
            "Maj",
            "Junij",
            "Julij",
            "Avgust",
            "September",
            "Oktober",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(98, 42);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMonth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mesec";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(239, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Leto";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(611, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vpiši datum:";
            // 
            // TextDate
            // 
            this.TextDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TextDate.Location = new System.Drawing.Point(750, 44);
            this.TextDate.Name = "TextDate";
            this.TextDate.Size = new System.Drawing.Size(121, 26);
            this.TextDate.TabIndex = 5;
            this.TextDate.Text = "1.12.2021";
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHiden,
            this.columnTorek,
            this.columnSreda,
            this.columnČetrtek,
            this.columnPetek,
            this.columnSobota,
            this.columnNedeljaa});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1056, 646);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHiden
            // 
            this.columnHiden.Text = "Ponedeljek";
            this.columnHiden.Width = 150;
            // 
            // columnTorek
            // 
            this.columnTorek.Text = "Torek";
            this.columnTorek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTorek.Width = 150;
            // 
            // columnSreda
            // 
            this.columnSreda.Text = "Sreda";
            this.columnSreda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSreda.Width = 150;
            // 
            // columnČetrtek
            // 
            this.columnČetrtek.Text = "Četrtek";
            this.columnČetrtek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnČetrtek.Width = 150;
            // 
            // columnPetek
            // 
            this.columnPetek.Text = "Petek";
            this.columnPetek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPetek.Width = 150;
            // 
            // columnSobota
            // 
            this.columnSobota.Text = "Sobota";
            this.columnSobota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSobota.Width = 150;
            // 
            // columnNedeljaa
            // 
            this.columnNedeljaa.Text = "Nedelja";
            this.columnNedeljaa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNedeljaa.Width = 150;
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPrikazi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonPrikazi.Location = new System.Drawing.Point(423, 41);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(125, 33);
            this.buttonPrikazi.TabIndex = 7;
            this.buttonPrikazi.Text = "PRIKAŽI";
            this.buttonPrikazi.UseVisualStyleBackColor = false;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // buttonSkok
            // 
            this.buttonSkok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSkok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSkok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonSkok.Location = new System.Drawing.Point(891, 40);
            this.buttonSkok.Name = "buttonSkok";
            this.buttonSkok.Size = new System.Drawing.Size(168, 35);
            this.buttonSkok.TabIndex = 8;
            this.buttonSkok.Text = "SKOK NA DATUM";
            this.buttonSkok.UseVisualStyleBackColor = false;
            this.buttonSkok.Click += new System.EventHandler(this.buttonSkok_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(260, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "MESEC:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(576, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "LETO:";
            // 
            // labelMesec
            // 
            this.labelMesec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMesec.AutoSize = true;
            this.labelMesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.labelMesec.Location = new System.Drawing.Point(403, 115);
            this.labelMesec.Name = "labelMesec";
            this.labelMesec.Size = new System.Drawing.Size(0, 36);
            this.labelMesec.TabIndex = 11;
            // 
            // labelLeto
            // 
            this.labelLeto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLeto.AutoSize = true;
            this.labelLeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.labelLeto.Location = new System.Drawing.Point(695, 115);
            this.labelLeto.Name = "labelLeto";
            this.labelLeto.Size = new System.Drawing.Size(0, 36);
            this.labelLeto.TabIndex = 12;
            // 
            // Koledar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 842);
            this.Controls.Add(this.labelLeto);
            this.Controls.Add(this.labelMesec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSkok);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TextDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.textBoxYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Koledar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koledar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextDate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHiden;
        private System.Windows.Forms.ColumnHeader columnTorek;
        private System.Windows.Forms.ColumnHeader columnSreda;
        private System.Windows.Forms.ColumnHeader columnČetrtek;
        private System.Windows.Forms.ColumnHeader columnPetek;
        private System.Windows.Forms.ColumnHeader columnSobota;
        private System.Windows.Forms.ColumnHeader columnNedeljaa;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Button buttonSkok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMesec;
        private System.Windows.Forms.Label labelLeto;
    }
}


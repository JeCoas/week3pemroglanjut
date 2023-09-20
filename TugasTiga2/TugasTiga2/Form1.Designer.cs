namespace TugasTiga2
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
            this.Nama = new System.Windows.Forms.Label();
            this.Pendidikan = new System.Windows.Forms.Label();
            this.Pekerjaan = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(31, 42);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(38, 13);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama ";
            // 
            // Pendidikan
            // 
            this.Pendidikan.AutoSize = true;
            this.Pendidikan.Location = new System.Drawing.Point(31, 83);
            this.Pendidikan.Name = "Pendidikan";
            this.Pendidikan.Size = new System.Drawing.Size(60, 13);
            this.Pendidikan.TabIndex = 1;
            this.Pendidikan.Text = "Pendidikan";
            this.Pendidikan.Click += new System.EventHandler(this.label2_Click);
            // 
            // Pekerjaan
            // 
            this.Pekerjaan.AutoSize = true;
            this.Pekerjaan.Location = new System.Drawing.Point(31, 115);
            this.Pekerjaan.Name = "Pekerjaan";
            this.Pekerjaan.Size = new System.Drawing.Size(55, 13);
            this.Pekerjaan.TabIndex = 2;
            this.Pekerjaan.Text = "Pekerjaan";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(136, 39);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(314, 20);
            this.txtNama.TabIndex = 3;
            // 
            // txtPesan1
            // 
            this.txtPesan1.Enabled = false;
            this.txtPesan1.Location = new System.Drawing.Point(34, 291);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.Size = new System.Drawing.Size(416, 20);
            this.txtPesan1.TabIndex = 4;
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.lstPekerjaan.Location = new System.Drawing.Point(136, 115);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(314, 160);
            this.lstPekerjaan.TabIndex = 5;
            // 
            // txtPesan2
            // 
            this.txtPesan2.Enabled = false;
            this.txtPesan2.Location = new System.Drawing.Point(34, 317);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.Size = new System.Drawing.Size(416, 20);
            this.txtPesan2.TabIndex = 6;
            // 
            // txtPesan3
            // 
            this.txtPesan3.Enabled = false;
            this.txtPesan3.Location = new System.Drawing.Point(34, 343);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.Size = new System.Drawing.Size(416, 20);
            this.txtPesan3.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(34, 369);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(416, 32);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "Pasca Sarjana"});
            this.cmbPendidikan.Location = new System.Drawing.Point(136, 77);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(314, 21);
            this.cmbPendidikan.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 409);
            this.Controls.Add(this.cmbPendidikan);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPesan3);
            this.Controls.Add(this.txtPesan2);
            this.Controls.Add(this.lstPekerjaan);
            this.Controls.Add(this.txtPesan1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.Pekerjaan);
            this.Controls.Add(this.Pendidikan);
            this.Controls.Add(this.Nama);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tugas 3.2 (Desain menggunakan komponen layout) ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label Pendidikan;
        private System.Windows.Forms.Label Pekerjaan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.TextBox txtPesan3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbPendidikan;
    }
}


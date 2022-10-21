namespace Tooded_DB
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
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.Toode_lbl = new System.Windows.Forms.Label();
            this.kogus = new System.Windows.Forms.Label();
            this.hind = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Kat_cbox = new System.Windows.Forms.ComboBox();
            this.Toode_pbox = new System.Windows.Forms.PictureBox();
            this.Otsi_btn = new System.Windows.Forms.Button();
            this.lisa_btn = new System.Windows.Forms.Button();
            this.uuenda_btn = new System.Windows.Forms.Button();
            this.kustuta_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lisa_Kat_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Toode_txt
            // 
            this.Toode_txt.Location = new System.Drawing.Point(124, 22);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(145, 20);
            this.Toode_txt.TabIndex = 0;
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(124, 62);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(145, 20);
            this.Kogus_txt.TabIndex = 1;
            // 
            // Hind_txt
            // 
            this.Hind_txt.Location = new System.Drawing.Point(124, 103);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(145, 20);
            this.Hind_txt.TabIndex = 2;
            // 
            // Toode_lbl
            // 
            this.Toode_lbl.AutoSize = true;
            this.Toode_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Toode_lbl.Location = new System.Drawing.Point(4, 22);
            this.Toode_lbl.Name = "Toode_lbl";
            this.Toode_lbl.Size = new System.Drawing.Size(114, 20);
            this.Toode_lbl.TabIndex = 3;
            this.Toode_lbl.Text = "Toode nimetus";
            // 
            // kogus
            // 
            this.kogus.AutoSize = true;
            this.kogus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.kogus.Location = new System.Drawing.Point(64, 62);
            this.kogus.Name = "kogus";
            this.kogus.Size = new System.Drawing.Size(54, 20);
            this.kogus.TabIndex = 4;
            this.kogus.Text = "Kogus";
            // 
            // hind
            // 
            this.hind.AutoSize = true;
            this.hind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.hind.Location = new System.Drawing.Point(71, 103);
            this.hind.Name = "hind";
            this.hind.Size = new System.Drawing.Size(42, 20);
            this.hind.TabIndex = 5;
            this.hind.Text = "Hind";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategooria";
            // 
            // Kat_cbox
            // 
            this.Kat_cbox.FormattingEnabled = true;
            this.Kat_cbox.Location = new System.Drawing.Point(124, 148);
            this.Kat_cbox.Name = "Kat_cbox";
            this.Kat_cbox.Size = new System.Drawing.Size(145, 21);
            this.Kat_cbox.TabIndex = 7;
            // 
            // Toode_pbox
            // 
            this.Toode_pbox.Location = new System.Drawing.Point(124, 193);
            this.Toode_pbox.Name = "Toode_pbox";
            this.Toode_pbox.Size = new System.Drawing.Size(145, 136);
            this.Toode_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Toode_pbox.TabIndex = 8;
            this.Toode_pbox.TabStop = false;
            // 
            // Otsi_btn
            // 
            this.Otsi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Otsi_btn.Location = new System.Drawing.Point(36, 191);
            this.Otsi_btn.Name = "Otsi_btn";
            this.Otsi_btn.Size = new System.Drawing.Size(74, 30);
            this.Otsi_btn.TabIndex = 9;
            this.Otsi_btn.Text = "Otsi pilt";
            this.Otsi_btn.UseVisualStyleBackColor = true;
            // 
            // lisa_btn
            // 
            this.lisa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lisa_btn.Location = new System.Drawing.Point(36, 227);
            this.lisa_btn.Name = "lisa_btn";
            this.lisa_btn.Size = new System.Drawing.Size(74, 30);
            this.lisa_btn.TabIndex = 10;
            this.lisa_btn.Text = "Lisa";
            this.lisa_btn.UseVisualStyleBackColor = true;
            this.lisa_btn.Click += new System.EventHandler(this.lisa_btn_Click);
            // 
            // uuenda_btn
            // 
            this.uuenda_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.uuenda_btn.Location = new System.Drawing.Point(36, 263);
            this.uuenda_btn.Name = "uuenda_btn";
            this.uuenda_btn.Size = new System.Drawing.Size(74, 30);
            this.uuenda_btn.TabIndex = 11;
            this.uuenda_btn.Text = "Uuenda";
            this.uuenda_btn.UseVisualStyleBackColor = true;
            // 
            // kustuta_btn
            // 
            this.kustuta_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.kustuta_btn.Location = new System.Drawing.Point(36, 299);
            this.kustuta_btn.Name = "kustuta_btn";
            this.kustuta_btn.Size = new System.Drawing.Size(74, 30);
            this.kustuta_btn.TabIndex = 12;
            this.kustuta_btn.Text = "Kustuta";
            this.kustuta_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 147);
            this.dataGridView1.TabIndex = 13;
            // 
            // Lisa_Kat_btn
            // 
            this.Lisa_Kat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Lisa_Kat_btn.Location = new System.Drawing.Point(124, 335);
            this.Lisa_Kat_btn.Name = "Lisa_Kat_btn";
            this.Lisa_Kat_btn.Size = new System.Drawing.Size(145, 30);
            this.Lisa_Kat_btn.TabIndex = 14;
            this.Lisa_Kat_btn.Text = "Lisa kategooriat";
            this.Lisa_Kat_btn.UseVisualStyleBackColor = true;
            this.Lisa_Kat_btn.Click += new System.EventHandler(this.Lisa_Kat_btn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lisa_Kat_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kustuta_btn);
            this.Controls.Add(this.uuenda_btn);
            this.Controls.Add(this.lisa_btn);
            this.Controls.Add(this.Otsi_btn);
            this.Controls.Add(this.Toode_pbox);
            this.Controls.Add(this.Kat_cbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hind);
            this.Controls.Add(this.kogus);
            this.Controls.Add(this.Toode_lbl);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Toode_txt);
            this.Name = "Form1";
            this.Text = "Tooded";
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.Label Toode_lbl;
        private System.Windows.Forms.Label kogus;
        private System.Windows.Forms.Label hind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Kat_cbox;
        private System.Windows.Forms.PictureBox Toode_pbox;
        private System.Windows.Forms.Button Otsi_btn;
        private System.Windows.Forms.Button lisa_btn;
        private System.Windows.Forms.Button uuenda_btn;
        private System.Windows.Forms.Button kustuta_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Lisa_Kat_btn;
    }
}


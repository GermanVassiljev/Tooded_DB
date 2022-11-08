namespace Tooded_DB
{
    partial class Kassa
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
            this.Lopp = new System.Windows.Forms.Button();
            this.Pilt_kassa = new System.Windows.Forms.PictureBox();
            this.Tooded_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.summ_lbl = new System.Windows.Forms.Label();
            this.Tooded_listbox = new System.Windows.Forms.ListBox();
            this.vaata_pdf = new System.Windows.Forms.Button();
            this.sulge = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pilt_kassa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lopp
            // 
            this.Lopp.BackColor = System.Drawing.Color.SeaShell;
            this.Lopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Lopp.Location = new System.Drawing.Point(656, 408);
            this.Lopp.Name = "Lopp";
            this.Lopp.Size = new System.Drawing.Size(132, 30);
            this.Lopp.TabIndex = 0;
            this.Lopp.Text = "Printida kviitung";
            this.Lopp.UseVisualStyleBackColor = false;
            this.Lopp.Click += new System.EventHandler(this.Lopp_Click);
            // 
            // Pilt_kassa
            // 
            this.Pilt_kassa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pilt_kassa.Location = new System.Drawing.Point(80, 211);
            this.Pilt_kassa.Name = "Pilt_kassa";
            this.Pilt_kassa.Size = new System.Drawing.Size(209, 180);
            this.Pilt_kassa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pilt_kassa.TabIndex = 2;
            this.Pilt_kassa.TabStop = false;
            // 
            // Tooded_lbl
            // 
            this.Tooded_lbl.AllowDrop = true;
            this.Tooded_lbl.AutoSize = true;
            this.Tooded_lbl.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Tooded_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Tooded_lbl.Location = new System.Drawing.Point(560, 95);
            this.Tooded_lbl.Name = "Tooded_lbl";
            this.Tooded_lbl.Size = new System.Drawing.Size(69, 20);
            this.Tooded_lbl.TabIndex = 6;
            this.Tooded_lbl.Text = "Tooded";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 80);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 118);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(355, 80);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // summ_lbl
            // 
            this.summ_lbl.AllowDrop = true;
            this.summ_lbl.AutoSize = true;
            this.summ_lbl.BackColor = System.Drawing.Color.AntiqueWhite;
            this.summ_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.summ_lbl.Location = new System.Drawing.Point(105, 95);
            this.summ_lbl.Name = "summ_lbl";
            this.summ_lbl.Size = new System.Drawing.Size(164, 20);
            this.summ_lbl.TabIndex = 10;
            this.summ_lbl.Text = "Kõik valikud tooded";
            // 
            // Tooded_listbox
            // 
            this.Tooded_listbox.BackColor = System.Drawing.SystemColors.Info;
            this.Tooded_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Tooded_listbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Tooded_listbox.FormattingEnabled = true;
            this.Tooded_listbox.ItemHeight = 16;
            this.Tooded_listbox.Location = new System.Drawing.Point(373, 211);
            this.Tooded_listbox.Name = "Tooded_listbox";
            this.Tooded_listbox.Size = new System.Drawing.Size(415, 180);
            this.Tooded_listbox.TabIndex = 11;
            // 
            // vaata_pdf
            // 
            this.vaata_pdf.BackColor = System.Drawing.Color.SeaShell;
            this.vaata_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.vaata_pdf.Location = new System.Drawing.Point(582, 408);
            this.vaata_pdf.Name = "vaata_pdf";
            this.vaata_pdf.Size = new System.Drawing.Size(68, 30);
            this.vaata_pdf.TabIndex = 13;
            this.vaata_pdf.Text = "Vaata";
            this.vaata_pdf.UseVisualStyleBackColor = false;
            this.vaata_pdf.Click += new System.EventHandler(this.vaata_pdf_Click);
            // 
            // sulge
            // 
            this.sulge.BackColor = System.Drawing.Color.Red;
            this.sulge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.sulge.Location = new System.Drawing.Point(756, 12);
            this.sulge.Name = "sulge";
            this.sulge.Size = new System.Drawing.Size(32, 30);
            this.sulge.TabIndex = 14;
            this.sulge.Text = "X";
            this.sulge.UseVisualStyleBackColor = false;
            this.sulge.Click += new System.EventHandler(this.sulge_Click);
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.SystemColors.HotTrack;
            this.head.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.head.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.head.Location = new System.Drawing.Point(-1, -2);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(802, 65);
            this.head.TabIndex = 15;
            this.head.Text = "Kassa";
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sulge);
            this.Controls.Add(this.head);
            this.Controls.Add(this.vaata_pdf);
            this.Controls.Add(this.Tooded_listbox);
            this.Controls.Add(this.summ_lbl);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Tooded_lbl);
            this.Controls.Add(this.Pilt_kassa);
            this.Controls.Add(this.Lopp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kassa";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Pilt_kassa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lopp;
        private System.Windows.Forms.PictureBox Pilt_kassa;
        private System.Windows.Forms.Label Tooded_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label summ_lbl;
        private System.Windows.Forms.ListBox Tooded_listbox;
        private System.Windows.Forms.Button vaata_pdf;
        private System.Windows.Forms.Button sulge;
        private System.Windows.Forms.RichTextBox head;
    }
}
namespace Tooded_DB
{
    partial class Register
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
            this.login_text = new System.Windows.Forms.TextBox();
            this.valmis = new System.Windows.Forms.Button();
            this.sulge = new System.Windows.Forms.Button();
            this.Login_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parool_text = new System.Windows.Forms.TextBox();
            this.parool_text2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Kassir = new System.Windows.Forms.RadioButton();
            this.manager = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_text
            // 
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.login_text.Location = new System.Drawing.Point(117, 75);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(227, 29);
            this.login_text.TabIndex = 21;
            // 
            // valmis
            // 
            this.valmis.BackColor = System.Drawing.Color.SeaShell;
            this.valmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.valmis.Location = new System.Drawing.Point(12, 274);
            this.valmis.Name = "valmis";
            this.valmis.Size = new System.Drawing.Size(112, 30);
            this.valmis.TabIndex = 22;
            this.valmis.Text = "Registreeri";
            this.valmis.UseVisualStyleBackColor = false;
            this.valmis.Click += new System.EventHandler(this.valmis_Click);
            // 
            // sulge
            // 
            this.sulge.BackColor = System.Drawing.Color.Red;
            this.sulge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.sulge.Location = new System.Drawing.Point(186, 3);
            this.sulge.Name = "sulge";
            this.sulge.Size = new System.Drawing.Size(34, 33);
            this.sulge.TabIndex = 23;
            this.sulge.Text = "X";
            this.sulge.UseVisualStyleBackColor = false;
            this.sulge.Click += new System.EventHandler(this.sulge_Click);
            // 
            // Login_lbl
            // 
            this.Login_lbl.AutoSize = true;
            this.Login_lbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Login_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Login_lbl.ForeColor = System.Drawing.SystemColors.Menu;
            this.Login_lbl.Location = new System.Drawing.Point(6, 75);
            this.Login_lbl.Name = "Login_lbl";
            this.Login_lbl.Size = new System.Drawing.Size(104, 27);
            this.Login_lbl.TabIndex = 24;
            this.Login_lbl.Text = "Uus login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(6, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Uus parool";
            // 
            // parool_text
            // 
            this.parool_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.parool_text.Location = new System.Drawing.Point(130, 147);
            this.parool_text.Name = "parool_text";
            this.parool_text.PasswordChar = '*';
            this.parool_text.Size = new System.Drawing.Size(214, 29);
            this.parool_text.TabIndex = 26;
            // 
            // parool_text2
            // 
            this.parool_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.parool_text2.Location = new System.Drawing.Point(130, 182);
            this.parool_text2.Name = "parool_text2";
            this.parool_text2.PasswordChar = '*';
            this.parool_text2.Size = new System.Drawing.Size(214, 29);
            this.parool_text2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(18, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kontrolli";
            // 
            // Kassir
            // 
            this.Kassir.AutoSize = true;
            this.Kassir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kassir.Location = new System.Drawing.Point(130, 274);
            this.Kassir.Name = "Kassir";
            this.Kassir.Size = new System.Drawing.Size(139, 28);
            this.Kassir.TabIndex = 29;
            this.Kassir.TabStop = true;
            this.Kassir.Text = "Kassapidaja";
            this.Kassir.UseVisualStyleBackColor = true;
            // 
            // manager
            // 
            this.manager.AutoSize = true;
            this.manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.manager.Location = new System.Drawing.Point(275, 274);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(110, 28);
            this.manager.TabIndex = 30;
            this.manager.TabStop = true;
            this.manager.Text = "Manager";
            this.manager.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.sulge);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(481, 69);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Registreerimine";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(481, 316);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.manager);
            this.Controls.Add(this.Kassir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parool_text2);
            this.Controls.Add(this.parool_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_lbl);
            this.Controls.Add(this.valmis);
            this.Controls.Add(this.login_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.Button valmis;
        private System.Windows.Forms.Button sulge;
        private System.Windows.Forms.Label Login_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parool_text;
        private System.Windows.Forms.TextBox parool_text2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Kassir;
        private System.Windows.Forms.RadioButton manager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
    }
}

namespace WF_lab1
{
    partial class LOG_IN_WINDOW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOG_IN_WINDOW));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLOGIN = new System.Windows.Forms.Label();
            this.tbPASSWORD = new System.Windows.Forms.TextBox();
            this.enterPASSWORDlabel = new System.Windows.Forms.Label();
            this.tbPHONE = new System.Windows.Forms.TextBox();
            this.enterPHONElabel = new System.Windows.Forms.Label();
            this.buttonLOG_IN = new System.Windows.Forms.Button();
            this.attention_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(232)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelLOGIN);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 124);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(806, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(595, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 101);
            this.panel2.TabIndex = 1;
            // 
            // labelLOGIN
            // 
            this.labelLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLOGIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLOGIN.Location = new System.Drawing.Point(4, 6);
            this.labelLOGIN.Name = "labelLOGIN";
            this.labelLOGIN.Size = new System.Drawing.Size(832, 115);
            this.labelLOGIN.TabIndex = 0;
            this.labelLOGIN.Text = "    LOG   IN";
            this.labelLOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPASSWORD
            // 
            this.tbPASSWORD.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPASSWORD.Location = new System.Drawing.Point(398, 280);
            this.tbPASSWORD.Name = "tbPASSWORD";
            this.tbPASSWORD.PasswordChar = '*';
            this.tbPASSWORD.Size = new System.Drawing.Size(385, 56);
            this.tbPASSWORD.TabIndex = 9;
            this.tbPASSWORD.UseSystemPasswordChar = true;
            // 
            // enterPASSWORDlabel
            // 
            this.enterPASSWORDlabel.AutoSize = true;
            this.enterPASSWORDlabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterPASSWORDlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterPASSWORDlabel.Location = new System.Drawing.Point(17, 278);
            this.enterPASSWORDlabel.Name = "enterPASSWORDlabel";
            this.enterPASSWORDlabel.Size = new System.Drawing.Size(377, 49);
            this.enterPASSWORDlabel.TabIndex = 8;
            this.enterPASSWORDlabel.Text = "Enter your password: ";
            // 
            // tbPHONE
            // 
            this.tbPHONE.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPHONE.Location = new System.Drawing.Point(348, 168);
            this.tbPHONE.MaxLength = 13;
            this.tbPHONE.Multiline = true;
            this.tbPHONE.Name = "tbPHONE";
            this.tbPHONE.Size = new System.Drawing.Size(435, 48);
            this.tbPHONE.TabIndex = 11;
            this.tbPHONE.Text = "+380";
            this.tbPHONE.TextChanged += new System.EventHandler(this.tbPHONE_TextChanged);
            this.tbPHONE.Leave += new System.EventHandler(this.tbPHONE_Leave);
            // 
            // enterPHONElabel
            // 
            this.enterPHONElabel.AutoSize = true;
            this.enterPHONElabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterPHONElabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterPHONElabel.Location = new System.Drawing.Point(17, 165);
            this.enterPHONElabel.Name = "enterPHONElabel";
            this.enterPHONElabel.Size = new System.Drawing.Size(325, 49);
            this.enterPHONElabel.TabIndex = 10;
            this.enterPHONElabel.Text = "Enter your phone: ";
            // 
            // buttonLOG_IN
            // 
            this.buttonLOG_IN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonLOG_IN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLOG_IN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLOG_IN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLOG_IN.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLOG_IN.Location = new System.Drawing.Point(348, 367);
            this.buttonLOG_IN.Name = "buttonLOG_IN";
            this.buttonLOG_IN.Size = new System.Drawing.Size(123, 42);
            this.buttonLOG_IN.TabIndex = 13;
            this.buttonLOG_IN.Text = "LOG IN";
            this.buttonLOG_IN.UseVisualStyleBackColor = false;
            this.buttonLOG_IN.Click += new System.EventHandler(this.buttonLOG_IN_Click);
            // 
            // attention_label
            // 
            this.attention_label.AutoSize = true;
            this.attention_label.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attention_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.attention_label.Location = new System.Drawing.Point(75, 444);
            this.attention_label.Name = "attention_label";
            this.attention_label.Size = new System.Drawing.Size(0, 41);
            this.attention_label.TabIndex = 14;
            // 
            // LOG_IN_WINDOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(844, 524);
            this.Controls.Add(this.attention_label);
            this.Controls.Add(this.buttonLOG_IN);
            this.Controls.Add(this.tbPHONE);
            this.Controls.Add(this.enterPHONElabel);
            this.Controls.Add(this.tbPASSWORD);
            this.Controls.Add(this.enterPASSWORDlabel);
            this.Controls.Add(this.panel1);
            this.Name = "LOG_IN_WINDOW";
            this.Text = "LOG_IN_WINDOW";
            this.Load += new System.EventHandler(this.LOG_IN_WINDOW_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLOGIN;
        private System.Windows.Forms.TextBox tbPASSWORD;
        private System.Windows.Forms.Label enterPASSWORDlabel;
        private System.Windows.Forms.TextBox tbPHONE;
        private System.Windows.Forms.Label enterPHONElabel;
        private System.Windows.Forms.Button buttonLOG_IN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label attention_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
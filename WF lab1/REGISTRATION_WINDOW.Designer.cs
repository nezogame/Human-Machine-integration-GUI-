
namespace WF_lab1
{
    partial class REGISTRATION
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRATION));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registration_label = new System.Windows.Forms.Label();
            this.enterFIOlabel = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbPHONE = new System.Windows.Forms.TextBox();
            this.enterPHONElabel = new System.Windows.Forms.Label();
            this.enterPASSWORDlabel = new System.Windows.Forms.Label();
            this.tbPASSWORD = new System.Windows.Forms.TextBox();
            this.chooseCITYlabel = new System.Windows.Forms.Label();
            this.cbCITY = new System.Windows.Forms.ComboBox();
            this.labelALREADY_REG = new System.Windows.Forms.Label();
            this.buttonLOG_IN = new System.Windows.Forms.Button();
            this.buttonREGISTER = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(232)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 153);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(642, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 144);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.registration_label);
            this.panel2.Location = new System.Drawing.Point(1, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 49);
            this.panel2.TabIndex = 1;
            // 
            // registration_label
            // 
            this.registration_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registration_label.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registration_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registration_label.Location = new System.Drawing.Point(0, 0);
            this.registration_label.Name = "registration_label";
            this.registration_label.Size = new System.Drawing.Size(842, 49);
            this.registration_label.TabIndex = 0;
            this.registration_label.Text = "REGISTRATION";
            this.registration_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterFIOlabel
            // 
            this.enterFIOlabel.AutoSize = true;
            this.enterFIOlabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterFIOlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterFIOlabel.Location = new System.Drawing.Point(21, 210);
            this.enterFIOlabel.Name = "enterFIOlabel";
            this.enterFIOlabel.Size = new System.Drawing.Size(280, 49);
            this.enterFIOlabel.TabIndex = 2;
            this.enterFIOlabel.Text = "Enter your FIO: ";
            // 
            // tbFIO
            // 
            this.tbFIO.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFIO.Location = new System.Drawing.Point(310, 211);
            this.tbFIO.Multiline = true;
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(477, 48);
            this.tbFIO.TabIndex = 3;
            this.tbFIO.Leave += new System.EventHandler(this.tbFIO_Leave);
            // 
            // tbPHONE
            // 
            this.tbPHONE.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPHONE.Location = new System.Drawing.Point(367, 276);
            this.tbPHONE.MaxLength = 13;
            this.tbPHONE.Multiline = true;
            this.tbPHONE.Name = "tbPHONE";
            this.tbPHONE.Size = new System.Drawing.Size(420, 48);
            this.tbPHONE.TabIndex = 5;
            this.tbPHONE.Text = "+380";
            this.tbPHONE.Leave += new System.EventHandler(this.tbPHONE_Leave);
            // 
            // enterPHONElabel
            // 
            this.enterPHONElabel.AutoSize = true;
            this.enterPHONElabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterPHONElabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterPHONElabel.Location = new System.Drawing.Point(21, 273);
            this.enterPHONElabel.Name = "enterPHONElabel";
            this.enterPHONElabel.Size = new System.Drawing.Size(325, 49);
            this.enterPHONElabel.TabIndex = 4;
            this.enterPHONElabel.Text = "Enter your phone: ";
            // 
            // enterPASSWORDlabel
            // 
            this.enterPASSWORDlabel.AutoSize = true;
            this.enterPASSWORDlabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterPASSWORDlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterPASSWORDlabel.Location = new System.Drawing.Point(19, 340);
            this.enterPASSWORDlabel.Name = "enterPASSWORDlabel";
            this.enterPASSWORDlabel.Size = new System.Drawing.Size(377, 49);
            this.enterPASSWORDlabel.TabIndex = 6;
            this.enterPASSWORDlabel.Text = "Enter your password: ";
            // 
            // tbPASSWORD
            // 
            this.tbPASSWORD.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPASSWORD.Location = new System.Drawing.Point(402, 341);
            this.tbPASSWORD.Name = "tbPASSWORD";
            this.tbPASSWORD.PasswordChar = '*';
            this.tbPASSWORD.Size = new System.Drawing.Size(385, 48);
            this.tbPASSWORD.TabIndex = 7;
            this.tbPASSWORD.UseSystemPasswordChar = true;
            // 
            // chooseCITYlabel
            // 
            this.chooseCITYlabel.AutoSize = true;
            this.chooseCITYlabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseCITYlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chooseCITYlabel.Location = new System.Drawing.Point(21, 405);
            this.chooseCITYlabel.Name = "chooseCITYlabel";
            this.chooseCITYlabel.Size = new System.Drawing.Size(306, 49);
            this.chooseCITYlabel.TabIndex = 8;
            this.chooseCITYlabel.Text = "Choose your city:";
            // 
            // cbCITY
            // 
            this.cbCITY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCITY.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCITY.FormattingEnabled = true;
            this.cbCITY.Items.AddRange(new object[] {
            "Dnipro",
            "Kyiv",
            "Odessa",
            "Kharkiv",
            "Lviv",
            "Poltava",
            "Uzhgorod"});
            this.cbCITY.Location = new System.Drawing.Point(367, 407);
            this.cbCITY.Name = "cbCITY";
            this.cbCITY.Size = new System.Drawing.Size(420, 45);
            this.cbCITY.TabIndex = 9;
            this.cbCITY.SelectedIndexChanged += new System.EventHandler(this.cbCITY_SelectedIndexChanged);
            // 
            // labelALREADY_REG
            // 
            this.labelALREADY_REG.AutoSize = true;
            this.labelALREADY_REG.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelALREADY_REG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelALREADY_REG.Location = new System.Drawing.Point(30, 474);
            this.labelALREADY_REG.Name = "labelALREADY_REG";
            this.labelALREADY_REG.Size = new System.Drawing.Size(307, 33);
            this.labelALREADY_REG.TabIndex = 10;
            this.labelALREADY_REG.Text = "Already registered? Log in!";
            // 
            // buttonLOG_IN
            // 
            this.buttonLOG_IN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLOG_IN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLOG_IN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLOG_IN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLOG_IN.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLOG_IN.Location = new System.Drawing.Point(367, 470);
            this.buttonLOG_IN.Name = "buttonLOG_IN";
            this.buttonLOG_IN.Size = new System.Drawing.Size(123, 42);
            this.buttonLOG_IN.TabIndex = 11;
            this.buttonLOG_IN.Text = "LOG IN";
            this.buttonLOG_IN.UseVisualStyleBackColor = false;
            this.buttonLOG_IN.Click += new System.EventHandler(this.buttonLOG_IN_Click);
            // 
            // buttonREGISTER
            // 
            this.buttonREGISTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonREGISTER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonREGISTER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonREGISTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonREGISTER.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonREGISTER.Location = new System.Drawing.Point(522, 470);
            this.buttonREGISTER.Name = "buttonREGISTER";
            this.buttonREGISTER.Size = new System.Drawing.Size(265, 42);
            this.buttonREGISTER.TabIndex = 12;
            this.buttonREGISTER.Text = "REGISTER";
            this.buttonREGISTER.UseVisualStyleBackColor = false;
            this.buttonREGISTER.Click += new System.EventHandler(this.buttonREGISTER_Click);
            // 
            // REGISTRATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(844, 524);
            this.Controls.Add(this.buttonREGISTER);
            this.Controls.Add(this.buttonLOG_IN);
            this.Controls.Add(this.labelALREADY_REG);
            this.Controls.Add(this.cbCITY);
            this.Controls.Add(this.chooseCITYlabel);
            this.Controls.Add(this.tbPASSWORD);
            this.Controls.Add(this.enterPASSWORDlabel);
            this.Controls.Add(this.tbPHONE);
            this.Controls.Add(this.enterPHONElabel);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.enterFIOlabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "REGISTRATION";
            this.Text = "UA_POST";
            this.Load += new System.EventHandler(this.REGISTRATION_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label registration_label;
        private System.Windows.Forms.Label enterFIOlabel;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.TextBox tbPHONE;
        private System.Windows.Forms.Label enterPHONElabel;
        private System.Windows.Forms.Label enterPASSWORDlabel;
        private System.Windows.Forms.TextBox tbPASSWORD;
        private System.Windows.Forms.Label chooseCITYlabel;
        private System.Windows.Forms.ComboBox cbCITY;
        private System.Windows.Forms.Label labelALREADY_REG;
        private System.Windows.Forms.Button buttonLOG_IN;
        private System.Windows.Forms.Button buttonREGISTER;
    }
}


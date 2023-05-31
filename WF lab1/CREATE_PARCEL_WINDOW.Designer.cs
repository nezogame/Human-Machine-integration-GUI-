
namespace WF_lab1
{
    partial class CREATE_PARCEL_WINDOW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CREATE_PARCEL_WINDOW));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedLB_place_sending = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_place_send = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_adress_send = new System.Windows.Forms.TextBox();
            this.label_adress_send = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_place_receive = new System.Windows.Forms.Label();
            this.checkedLB_place_receiving = new System.Windows.Forms.CheckedListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_adress_receive = new System.Windows.Forms.TextBox();
            this.label_adress_receive = new System.Windows.Forms.Label();
            this.label_info_sender = new System.Windows.Forms.Label();
            this.label_info_receiver = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_info_receive = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(232)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 109);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(758, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(219, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create parcel";
            // 
            // checkedLB_place_sending
            // 
            this.checkedLB_place_sending.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedLB_place_sending.FormattingEnabled = true;
            this.checkedLB_place_sending.Location = new System.Drawing.Point(44, 34);
            this.checkedLB_place_sending.MultiColumn = true;
            this.checkedLB_place_sending.Name = "checkedLB_place_sending";
            this.checkedLB_place_sending.Size = new System.Drawing.Size(469, 25);
            this.checkedLB_place_sending.TabIndex = 1;
            this.checkedLB_place_sending.SelectedIndexChanged += new System.EventHandler(this.checkedLB_place_sending_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.label_place_send);
            this.panel2.Controls.Add(this.checkedLB_place_sending);
            this.panel2.Location = new System.Drawing.Point(129, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 69);
            this.panel2.TabIndex = 2;
            // 
            // label_place_send
            // 
            this.label_place_send.AutoSize = true;
            this.label_place_send.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_place_send.Location = new System.Drawing.Point(41, 9);
            this.label_place_send.Name = "label_place_send";
            this.label_place_send.Size = new System.Drawing.Size(112, 21);
            this.label_place_send.TabIndex = 4;
            this.label_place_send.Text = "Place of send:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.label_info);
            this.panel3.Location = new System.Drawing.Point(130, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 73);
            this.panel3.TabIndex = 3;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(40, 16);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(0, 20);
            this.label_info.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.Controls.Add(this.tb_adress_send);
            this.panel4.Controls.Add(this.label_adress_send);
            this.panel4.Location = new System.Drawing.Point(130, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(540, 69);
            this.panel4.TabIndex = 3;
            // 
            // tb_adress_send
            // 
            this.tb_adress_send.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_adress_send.Location = new System.Drawing.Point(43, 33);
            this.tb_adress_send.Name = "tb_adress_send";
            this.tb_adress_send.Size = new System.Drawing.Size(334, 26);
            this.tb_adress_send.TabIndex = 12;
            // 
            // label_adress_send
            // 
            this.label_adress_send.AutoSize = true;
            this.label_adress_send.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_adress_send.Location = new System.Drawing.Point(40, 9);
            this.label_adress_send.Name = "label_adress_send";
            this.label_adress_send.Size = new System.Drawing.Size(121, 21);
            this.label_adress_send.TabIndex = 5;
            this.label_adress_send.Text = "Adress of send:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.label_place_receive);
            this.panel5.Controls.Add(this.checkedLB_place_receiving);
            this.panel5.Location = new System.Drawing.Point(129, 401);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 69);
            this.panel5.TabIndex = 3;
            // 
            // label_place_receive
            // 
            this.label_place_receive.AutoSize = true;
            this.label_place_receive.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_place_receive.Location = new System.Drawing.Point(32, 10);
            this.label_place_receive.Name = "label_place_receive";
            this.label_place_receive.Size = new System.Drawing.Size(131, 21);
            this.label_place_receive.TabIndex = 3;
            this.label_place_receive.Text = "Place of receive:";
            // 
            // checkedLB_place_receiving
            // 
            this.checkedLB_place_receiving.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedLB_place_receiving.FormattingEnabled = true;
            this.checkedLB_place_receiving.Location = new System.Drawing.Point(36, 35);
            this.checkedLB_place_receiving.MultiColumn = true;
            this.checkedLB_place_receiving.Name = "checkedLB_place_receiving";
            this.checkedLB_place_receiving.Size = new System.Drawing.Size(469, 25);
            this.checkedLB_place_receiving.TabIndex = 2;
            this.checkedLB_place_receiving.SelectedIndexChanged += new System.EventHandler(this.checkedLB_place_receiving_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Honeydew;
            this.panel6.Controls.Add(this.tb_adress_receive);
            this.panel6.Controls.Add(this.label_adress_receive);
            this.panel6.Location = new System.Drawing.Point(129, 476);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(540, 69);
            this.panel6.TabIndex = 3;
            // 
            // tb_adress_receive
            // 
            this.tb_adress_receive.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_adress_receive.Location = new System.Drawing.Point(38, 34);
            this.tb_adress_receive.Name = "tb_adress_receive";
            this.tb_adress_receive.Size = new System.Drawing.Size(334, 26);
            this.tb_adress_receive.TabIndex = 11;
            // 
            // label_adress_receive
            // 
            this.label_adress_receive.AutoSize = true;
            this.label_adress_receive.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_adress_receive.Location = new System.Drawing.Point(36, 10);
            this.label_adress_receive.Name = "label_adress_receive";
            this.label_adress_receive.Size = new System.Drawing.Size(140, 21);
            this.label_adress_receive.TabIndex = 6;
            this.label_adress_receive.Text = "Adress of receive:";
            // 
            // label_info_sender
            // 
            this.label_info_sender.AutoSize = true;
            this.label_info_sender.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_info_sender.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_info_sender.Location = new System.Drawing.Point(130, 115);
            this.label_info_sender.Name = "label_info_sender";
            this.label_info_sender.Size = new System.Drawing.Size(135, 21);
            this.label_info_sender.TabIndex = 4;
            this.label_info_sender.Text = "Info about sender:";
            // 
            // label_info_receiver
            // 
            this.label_info_receiver.AutoSize = true;
            this.label_info_receiver.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_info_receiver.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_info_receiver.Location = new System.Drawing.Point(130, 374);
            this.label_info_receiver.Name = "label_info_receiver";
            this.label_info_receiver.Size = new System.Drawing.Size(143, 21);
            this.label_info_receiver.TabIndex = 5;
            this.label_info_receiver.Text = "Info about receiver:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Honeydew;
            this.panel7.Controls.Add(this.tb_phone);
            this.panel7.Controls.Add(this.tb_name);
            this.panel7.Controls.Add(this.label_phone);
            this.panel7.Controls.Add(this.label_name);
            this.panel7.Controls.Add(this.label_info_receive);
            this.panel7.Location = new System.Drawing.Point(129, 551);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(540, 97);
            this.panel7.TabIndex = 6;
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_phone.Location = new System.Drawing.Point(92, 62);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(280, 26);
            this.tb_phone.TabIndex = 11;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name.Location = new System.Drawing.Point(92, 32);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(280, 26);
            this.tb_name.TabIndex = 10;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_phone.Location = new System.Drawing.Point(38, 69);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(52, 18);
            this.label_phone.TabIndex = 9;
            this.label_phone.Text = "Phone:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(38, 37);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(48, 18);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Name:";
            // 
            // label_info_receive
            // 
            this.label_info_receive.AutoSize = true;
            this.label_info_receive.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_info_receive.Location = new System.Drawing.Point(36, 12);
            this.label_info_receive.Name = "label_info_receive";
            this.label_info_receive.Size = new System.Drawing.Size(153, 21);
            this.label_info_receive.TabIndex = 7;
            this.label_info_receive.Text = "Info about receiver:";
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.Honeydew;
            this.button_create.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_create.ForeColor = System.Drawing.Color.LimeGreen;
            this.button_create.Location = new System.Drawing.Point(690, 609);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(98, 39);
            this.button_create.TabIndex = 7;
            this.button_create.Text = "submit";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // CREATE_PARCEL_WINDOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label_info_receiver);
            this.Controls.Add(this.label_info_sender);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CREATE_PARCEL_WINDOW";
            this.Text = "CREATE_PARCEL_WINDOW";
            this.Load += new System.EventHandler(this.CREATE_PARCEL_WINDOW_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedLB_place_sending;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.CheckedListBox checkedLB_place_receiving;
        private System.Windows.Forms.Label label_place_receive;
        private System.Windows.Forms.Label label_info_sender;
        private System.Windows.Forms.Label label_info_receiver;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_place_send;
        private System.Windows.Forms.Label label_adress_send;
        private System.Windows.Forms.Label label_adress_receive;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_info_receive;
        private System.Windows.Forms.TextBox tb_adress_send;
        private System.Windows.Forms.TextBox tb_adress_receive;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
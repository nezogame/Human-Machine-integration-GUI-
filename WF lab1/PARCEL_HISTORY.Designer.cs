
namespace WF_lab1
{
    partial class PARCEL_HISTORY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PARCEL_HISTORY));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_box_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.parcels_history_label = new System.Windows.Forms.Label();
            this.listbox_receive = new System.Windows.Forms.ListBox();
            this.listbox_send = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_send = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_receive = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.label_info_text = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(232)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.picture_box_logo);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.parcels_history_label);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 131);
            this.panel1.TabIndex = 4;
            // 
            // picture_box_logo
            // 
            this.picture_box_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_box_logo.BackgroundImage")));
            this.picture_box_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_box_logo.Image")));
            this.picture_box_logo.Location = new System.Drawing.Point(619, 13);
            this.picture_box_logo.Name = "picture_box_logo";
            this.picture_box_logo.Size = new System.Drawing.Size(106, 103);
            this.picture_box_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_logo.TabIndex = 17;
            this.picture_box_logo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(759, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // parcels_history_label
            // 
            this.parcels_history_label.AutoSize = true;
            this.parcels_history_label.Font = new System.Drawing.Font("Corbel", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parcels_history_label.Location = new System.Drawing.Point(74, 32);
            this.parcels_history_label.Name = "parcels_history_label";
            this.parcels_history_label.Size = new System.Drawing.Size(506, 72);
            this.parcels_history_label.TabIndex = 0;
            this.parcels_history_label.Text = "PARCELS HISTORY";
            // 
            // listbox_receive
            // 
            this.listbox_receive.FormattingEnabled = true;
            this.listbox_receive.ItemHeight = 20;
            this.listbox_receive.Location = new System.Drawing.Point(77, 176);
            this.listbox_receive.Name = "listbox_receive";
            this.listbox_receive.Size = new System.Drawing.Size(138, 264);
            this.listbox_receive.TabIndex = 5;
            this.listbox_receive.DoubleClick += new System.EventHandler(this.listbox_receive_DoubleClick);
            // 
            // listbox_send
            // 
            this.listbox_send.FormattingEnabled = true;
            this.listbox_send.ItemHeight = 20;
            this.listbox_send.Location = new System.Drawing.Point(573, 176);
            this.listbox_send.Name = "listbox_send";
            this.listbox_send.Size = new System.Drawing.Size(138, 264);
            this.listbox_send.TabIndex = 6;
            this.listbox_send.DoubleClick += new System.EventHandler(this.listbox_send_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.Controls.Add(this.label_send);
            this.panel3.Location = new System.Drawing.Point(573, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 34);
            this.panel3.TabIndex = 7;
            // 
            // label_send
            // 
            this.label_send.AutoSize = true;
            this.label_send.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_send.Location = new System.Drawing.Point(11, 5);
            this.label_send.Name = "label_send";
            this.label_send.Size = new System.Drawing.Size(116, 24);
            this.label_send.TabIndex = 9;
            this.label_send.Text = "Send history";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.label_receive);
            this.panel2.Location = new System.Drawing.Point(77, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 34);
            this.panel2.TabIndex = 8;
            // 
            // label_receive
            // 
            this.label_receive.AutoSize = true;
            this.label_receive.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_receive.Location = new System.Drawing.Point(0, 5);
            this.label_receive.Name = "label_receive";
            this.label_receive.Size = new System.Drawing.Size(138, 24);
            this.label_receive.TabIndex = 0;
            this.label_receive.Text = "Receive history";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_info.Location = new System.Drawing.Point(304, 133);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(171, 33);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "PARCEL INFO";
            // 
            // label_info_text
            // 
            this.label_info_text.AutoSize = true;
            this.label_info_text.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_info_text.Location = new System.Drawing.Point(310, 172);
            this.label_info_text.Name = "label_info_text";
            this.label_info_text.Size = new System.Drawing.Size(0, 18);
            this.label_info_text.TabIndex = 9;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_status.Location = new System.Drawing.Point(309, 391);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 29);
            this.label_status.TabIndex = 10;
            // 
            // PARCEL_HISTORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_info_text);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listbox_send);
            this.Controls.Add(this.listbox_receive);
            this.Controls.Add(this.panel1);
            this.Name = "PARCEL_HISTORY";
            this.Text = "PARCEL_HISTORY";
            this.Load += new System.EventHandler(this.PARCEL_HISTORY_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_box_logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label parcels_history_label;
        private System.Windows.Forms.ListBox listbox_receive;
        private System.Windows.Forms.ListBox listbox_send;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_send;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_receive;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_info_text;
        private System.Windows.Forms.Label label_status;
    }
}
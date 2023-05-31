
namespace WF_lab1
{
    partial class MY_PARCELS_WINDOW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MY_PARCELS_WINDOW));
            this.parcels_listbox = new System.Windows.Forms.ListBox();
            this.parcel_info_label = new System.Windows.Forms.Label();
            this.pay_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.my_parcels_label = new System.Windows.Forms.Label();
            this.toogleSwitcher = new WF_lab1.CustomControls.ToogleSwitcher();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.sort_listbox = new System.Windows.Forms.ListBox();
            this.button_take_out = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // parcels_listbox
            // 
            this.parcels_listbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parcels_listbox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parcels_listbox.ForeColor = System.Drawing.Color.Black;
            this.parcels_listbox.FormattingEnabled = true;
            this.parcels_listbox.ItemHeight = 24;
            this.parcels_listbox.Location = new System.Drawing.Point(110, 220);
            this.parcels_listbox.Name = "parcels_listbox";
            this.parcels_listbox.Size = new System.Drawing.Size(218, 220);
            this.parcels_listbox.TabIndex = 0;
            this.parcels_listbox.DoubleClick += new System.EventHandler(this.parcels_listbox_DoubleClick);
            // 
            // parcel_info_label
            // 
            this.parcel_info_label.AutoSize = true;
            this.parcel_info_label.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parcel_info_label.Location = new System.Drawing.Point(464, 197);
            this.parcel_info_label.Name = "parcel_info_label";
            this.parcel_info_label.Size = new System.Drawing.Size(0, 21);
            this.parcel_info_label.TabIndex = 1;
            // 
            // pay_button
            // 
            this.pay_button.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pay_button.Location = new System.Drawing.Point(112, 449);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(216, 36);
            this.pay_button.TabIndex = 2;
            this.pay_button.Text = "pay";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(232)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.my_parcels_label);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 131);
            this.panel1.TabIndex = 3;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(546, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // my_parcels_label
            // 
            this.my_parcels_label.AutoSize = true;
            this.my_parcels_label.Font = new System.Drawing.Font("Corbel", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.my_parcels_label.Location = new System.Drawing.Point(102, 32);
            this.my_parcels_label.Name = "my_parcels_label";
            this.my_parcels_label.Size = new System.Drawing.Size(358, 72);
            this.my_parcels_label.TabIndex = 0;
            this.my_parcels_label.Text = "MY PARCELS";
            // 
            // toogleSwitcher
            // 
            this.toogleSwitcher.AutoSize = true;
            this.toogleSwitcher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toogleSwitcher.Location = new System.Drawing.Point(369, 10);
            this.toogleSwitcher.MinimumSize = new System.Drawing.Size(60, 25);
            this.toogleSwitcher.Name = "toogleSwitcher";
            this.toogleSwitcher.OffBackColor = System.Drawing.Color.Khaki;
            this.toogleSwitcher.OffToggleColor = System.Drawing.Color.LightSeaGreen;
            this.toogleSwitcher.OnBackColor = System.Drawing.Color.Khaki;
            this.toogleSwitcher.OnToggleColor = System.Drawing.Color.LightSeaGreen;
            this.toogleSwitcher.Size = new System.Drawing.Size(60, 25);
            this.toogleSwitcher.TabIndex = 7;
            this.toogleSwitcher.UseVisualStyleBackColor = true;
            this.toogleSwitcher.CheckedChanged += new System.EventHandler(this.toogleSwitcher_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(112, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 42);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARCELS TO RECEIVE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(465, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 42);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "PARCELS TO SEND";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.toogleSwitcher);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(-1, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(805, 48);
            this.panel4.TabIndex = 8;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_status.Location = new System.Drawing.Point(464, 446);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 23);
            this.label_status.TabIndex = 0;
            // 
            // sort_listbox
            // 
            this.sort_listbox.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sort_listbox.FormattingEnabled = true;
            this.sort_listbox.ItemHeight = 22;
            this.sort_listbox.Items.AddRange(new object[] {
            "(No sort)",
            "By price of delivery",
            "Only paid",
            "By the date of arrival"});
            this.sort_listbox.Location = new System.Drawing.Point(110, 186);
            this.sort_listbox.Name = "sort_listbox";
            this.sort_listbox.Size = new System.Drawing.Size(216, 26);
            this.sort_listbox.TabIndex = 9;
            this.sort_listbox.SelectedIndexChanged += new System.EventHandler(this.sort_listbox_SelectedIndexChanged);
            // 
            // button_take_out
            // 
            this.button_take_out.Location = new System.Drawing.Point(22, 186);
            this.button_take_out.Name = "button_take_out";
            this.button_take_out.Size = new System.Drawing.Size(28, 29);
            this.button_take_out.TabIndex = 1;
            this.button_take_out.Text = "=";
            this.button_take_out.UseVisualStyleBackColor = true;
            this.button_take_out.Click += new System.EventHandler(this.button_take_out_Click);
            // 
            // MY_PARCELS_WINDOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.button_take_out);
            this.Controls.Add(this.sort_listbox);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.parcel_info_label);
            this.Controls.Add(this.parcels_listbox);
            this.Name = "MY_PARCELS_WINDOW";
            this.Text = "MY_PARCELS_WINDOW";
            this.Load += new System.EventHandler(this.MY_PARCELS_WINDOW_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.ListBox parcels_listbox;
        private System.Windows.Forms.Label parcel_info_label;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label my_parcels_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.ToogleSwitcher toogleSwitcher;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ListBox sort_listbox;
        private System.Windows.Forms.Button button_take_out;
    }
}
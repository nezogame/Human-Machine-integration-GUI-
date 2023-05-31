
namespace WF_lab1
{
    partial class PAY_WINDOW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PAY_WINDOW));
            this.enter_card_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.block4_tb = new System.Windows.Forms.TextBox();
            this.block3_tb = new System.Windows.Forms.TextBox();
            this.block2_tb = new System.Windows.Forms.TextBox();
            this.block1_tb = new System.Windows.Forms.TextBox();
            this.month_tb = new System.Windows.Forms.TextBox();
            this.year_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pay_button = new System.Windows.Forms.Button();
            this.roll_listbox = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toogle_switcher = new WF_lab1.CustomControls.ToogleSwitcher();
            this.label_discount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // enter_card_label
            // 
            this.enter_card_label.AutoSize = true;
            this.enter_card_label.Font = new System.Drawing.Font("Corbel", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enter_card_label.Location = new System.Drawing.Point(116, 9);
            this.enter_card_label.Name = "enter_card_label";
            this.enter_card_label.Size = new System.Drawing.Size(587, 42);
            this.enter_card_label.TabIndex = 0;
            this.enter_card_label.Text = "Enter you card number (in HEX format):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WF_lab1.Properties.Resources.CARD_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(69, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // block4_tb
            // 
            this.block4_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.block4_tb.Location = new System.Drawing.Point(508, 227);
            this.block4_tb.MaxLength = 4;
            this.block4_tb.Name = "block4_tb";
            this.block4_tb.Size = new System.Drawing.Size(86, 34);
            this.block4_tb.TabIndex = 3;
            this.block4_tb.Leave += new System.EventHandler(this.block4_tb_Leave);
            // 
            // block3_tb
            // 
            this.block3_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.block3_tb.Location = new System.Drawing.Point(399, 227);
            this.block3_tb.MaxLength = 4;
            this.block3_tb.Name = "block3_tb";
            this.block3_tb.Size = new System.Drawing.Size(86, 34);
            this.block3_tb.TabIndex = 4;
            this.block3_tb.Leave += new System.EventHandler(this.block3_tb_Leave);
            // 
            // block2_tb
            // 
            this.block2_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.block2_tb.Location = new System.Drawing.Point(291, 227);
            this.block2_tb.MaxLength = 4;
            this.block2_tb.Name = "block2_tb";
            this.block2_tb.Size = new System.Drawing.Size(86, 34);
            this.block2_tb.TabIndex = 5;
            this.block2_tb.Leave += new System.EventHandler(this.block2_tb_Leave);
            // 
            // block1_tb
            // 
            this.block1_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.block1_tb.Location = new System.Drawing.Point(185, 226);
            this.block1_tb.MaxLength = 4;
            this.block1_tb.Name = "block1_tb";
            this.block1_tb.Size = new System.Drawing.Size(86, 34);
            this.block1_tb.TabIndex = 6;
            this.block1_tb.Leave += new System.EventHandler(this.block1_tb_Leave);
            // 
            // month_tb
            // 
            this.month_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.month_tb.Location = new System.Drawing.Point(354, 285);
            this.month_tb.MaxLength = 2;
            this.month_tb.Name = "month_tb";
            this.month_tb.Size = new System.Drawing.Size(33, 27);
            this.month_tb.TabIndex = 7;
            this.month_tb.Leave += new System.EventHandler(this.month_tb_Leave);
            // 
            // year_tb
            // 
            this.year_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.year_tb.Location = new System.Drawing.Point(407, 285);
            this.year_tb.MaxLength = 2;
            this.year_tb.Name = "year_tb";
            this.year_tb.Size = new System.Drawing.Size(33, 27);
            this.year_tb.TabIndex = 8;
            this.year_tb.Leave += new System.EventHandler(this.year_tb_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(368, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 9;
            // 
            // pay_button
            // 
            this.pay_button.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pay_button.Location = new System.Drawing.Point(508, 389);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(121, 32);
            this.pay_button.TabIndex = 10;
            this.pay_button.Text = "pay";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // roll_listbox
            // 
            this.roll_listbox.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roll_listbox.FormattingEnabled = true;
            this.roll_listbox.ItemHeight = 21;
            this.roll_listbox.Location = new System.Drawing.Point(161, 390);
            this.roll_listbox.Name = "roll_listbox";
            this.roll_listbox.Size = new System.Drawing.Size(262, 25);
            this.roll_listbox.TabIndex = 11;
            this.roll_listbox.SelectedIndexChanged += new System.EventHandler(this.roll_listbox_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(759, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // toogle_switcher
            // 
            this.toogle_switcher.AutoSize = true;
            this.toogle_switcher.Location = new System.Drawing.Point(159, 420);
            this.toogle_switcher.MinimumSize = new System.Drawing.Size(45, 22);
            this.toogle_switcher.Name = "toogle_switcher";
            this.toogle_switcher.OffBackColor = System.Drawing.Color.Gray;
            this.toogle_switcher.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toogle_switcher.OnBackColor = System.Drawing.Color.MediumSpringGreen;
            this.toogle_switcher.OnToggleColor = System.Drawing.Color.White;
            this.toogle_switcher.Size = new System.Drawing.Size(45, 22);
            this.toogle_switcher.TabIndex = 18;
            this.toogle_switcher.UseVisualStyleBackColor = true;
            this.toogle_switcher.CheckedChanged += new System.EventHandler(this.toogle_switcher_CheckedChanged);
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_discount.Location = new System.Drawing.Point(209, 419);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(211, 23);
            this.label_discount.TabIndex = 19;
            this.label_discount.Text = "use discount to pay parcel";
            // 
            // PAY_WINDOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.toogle_switcher);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.roll_listbox);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.year_tb);
            this.Controls.Add(this.month_tb);
            this.Controls.Add(this.block1_tb);
            this.Controls.Add(this.block2_tb);
            this.Controls.Add(this.block3_tb);
            this.Controls.Add(this.block4_tb);
            this.Controls.Add(this.enter_card_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PAY_WINDOW";
            this.Text = "PAY_WINDOW";
            this.Load += new System.EventHandler(this.PAY_WINDOW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enter_card_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox block4_tb;
        private System.Windows.Forms.TextBox block3_tb;
        private System.Windows.Forms.TextBox block2_tb;
        private System.Windows.Forms.TextBox block1_tb;
        private System.Windows.Forms.TextBox month_tb;
        private System.Windows.Forms.TextBox year_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.ListBox roll_listbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.ToogleSwitcher toogle_switcher;
        private System.Windows.Forms.Label label_discount;
    }
}
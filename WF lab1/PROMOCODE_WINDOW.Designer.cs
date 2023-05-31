
namespace WF_lab1
{
    partial class PROMOCODE_WINDOW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PROMOCODE_WINDOW));
            this.enter_promocode = new System.Windows.Forms.Label();
            this.promocode_textbox = new System.Windows.Forms.TextBox();
            this.tick_button = new System.Windows.Forms.Button();
            this.answer_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enter_promocode
            // 
            this.enter_promocode.AutoSize = true;
            this.enter_promocode.Font = new System.Drawing.Font("Corbel", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enter_promocode.Location = new System.Drawing.Point(79, 37);
            this.enter_promocode.Name = "enter_promocode";
            this.enter_promocode.Size = new System.Drawing.Size(710, 60);
            this.enter_promocode.TabIndex = 0;
            this.enter_promocode.Text = "Enter your promocode to get sale:";
            // 
            // promocode_textbox
            // 
            this.promocode_textbox.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promocode_textbox.Location = new System.Drawing.Point(79, 107);
            this.promocode_textbox.Name = "promocode_textbox";
            this.promocode_textbox.Size = new System.Drawing.Size(564, 50);
            this.promocode_textbox.TabIndex = 1;
            this.promocode_textbox.TextChanged += new System.EventHandler(this.promocode_textbox_TextChanged);
            // 
            // tick_button
            // 
            this.tick_button.BackColor = System.Drawing.Color.Lime;
            this.tick_button.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tick_button.Location = new System.Drawing.Point(663, 107);
            this.tick_button.Name = "tick_button";
            this.tick_button.Size = new System.Drawing.Size(110, 54);
            this.tick_button.TabIndex = 2;
            this.tick_button.Text = "enter";
            this.tick_button.UseVisualStyleBackColor = false;
            this.tick_button.Click += new System.EventHandler(this.tick_button_Click);
            // 
            // answer_label
            // 
            this.answer_label.Font = new System.Drawing.Font("Corbel", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer_label.Location = new System.Drawing.Point(87, 187);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(686, 60);
            this.answer_label.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(806, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PROMOCODE_WINDOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(847, 498);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answer_label);
            this.Controls.Add(this.tick_button);
            this.Controls.Add(this.promocode_textbox);
            this.Controls.Add(this.enter_promocode);
            this.Name = "PROMOCODE_WINDOW";
            this.Text = "PROMOCODE_WINDOW";
            this.Load += new System.EventHandler(this.PROMOCODE_WINDOW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label enter_promocode;
        private System.Windows.Forms.TextBox promocode_textbox;
        private System.Windows.Forms.Button tick_button;
        private System.Windows.Forms.Label answer_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
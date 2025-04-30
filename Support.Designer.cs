namespace WinFormsApp1
{
    partial class Form2
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
            panel1 = new Panel();
            button2 = new Button();
            inquiryTxt = new TextBox();
            cancel = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            IdBox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 233, 228);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(IdBox);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(inquiryTxt);
            panel1.Controls.Add(cancel);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 458);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 34, 59);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(464, 336);
            button2.Name = "button2";
            button2.Size = new Size(314, 61);
            button2.TabIndex = 13;
            button2.Text = "Send Inquiry";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // inquiryTxt
            // 
            inquiryTxt.Location = new Point(12, 295);
            inquiryTxt.Multiline = true;
            inquiryTxt.Name = "inquiryTxt";
            inquiryTxt.Size = new Size(432, 143);
            inquiryTxt.TabIndex = 12;
            // 
            // cancel
            // 
            cancel.BackColor = Color.FromArgb(34, 34, 59);
            cancel.ForeColor = SystemColors.ControlLightLight;
            cancel.Location = new Point(265, 202);
            cancel.Name = "cancel";
            cancel.Size = new Size(300, 29);
            cancel.TabIndex = 10;
            cancel.Text = "Cancel Booking";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 130);
            label7.Name = "label7";
            label7.Size = new Size(314, 37);
            label7.TabIndex = 9;
            label7.Text = "Bookings Management";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 77);
            label6.Name = "label6";
            label6.Size = new Size(191, 30);
            label6.TabIndex = 5;
            label6.Text = "How can we help?";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label5.Location = new Point(12, 116);
            label5.Name = "label5";
            label5.Size = new Size(766, 2);
            label5.TabIndex = 4;
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 262);
            label3.Name = "label3";
            label3.Size = new Size(181, 30);
            label3.TabIndex = 2;
            label3.Text = "Another Inquiry?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(176, 54);
            label1.TabIndex = 0;
            label1.Text = "Support";
            // 
            // IdBox
            // 
            IdBox.Cursor = Cursors.SizeNESW;
            IdBox.Location = new Point(103, 202);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(100, 23);
            IdBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 205);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 15;
            label2.Text = "Booking ID";
            label2.Click += label2_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label7;
        private Button cancel;
        private TextBox inquiryTxt;
        private Button button2;
        private Label label2;
        private TextBox IdBox;
    }
}
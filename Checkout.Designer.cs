namespace Vechile_Renting_System
{
    partial class Checkout
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
            label1 = new Label();
            panel1 = new Panel();
            dropOffValue = new Label();
            label9 = new Label();
            pickUpValue = new Label();
            label7 = new Label();
            returnDateValue = new Label();
            label6 = new Label();
            label2 = new Label();
            totalValueLbl = new Label();
            totalLbl = new Label();
            taxValuelbl = new Label();
            taxlbl = new Label();
            StartDateValue = new Label();
            lblDays = new Label();
            priceValuelbl = new Label();
            lbPriCePerday = new Label();
            label3 = new Label();
            groupPaymentMetod = new GroupBox();
            CardDetailspanel = new Panel();
            CCVtxtbox = new TextBox();
            CCVlbl = new Label();
            ExpDateTxtbox = new TextBox();
            ExpDatelbl = new Label();
            cardNumTxtBox = new TextBox();
            CardNumlbl = new Label();
            Creditbtn = new RadioButton();
            CasHbtn = new RadioButton();
            label4 = new Label();
            btnPay = new Button();
            backBtn = new Button();
            invalidLabel = new Label();
            panel1.SuspendLayout();
            groupPaymentMetod.SuspendLayout();
            CardDetailspanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(74, 78, 105);
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 0, 0);
            label1.Size = new Size(776, 39);
            label1.TabIndex = 0;
            label1.Text = "Payment";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 233, 228);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dropOffValue);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pickUpValue);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(returnDateValue);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(totalValueLbl);
            panel1.Controls.Add(totalLbl);
            panel1.Controls.Add(taxValuelbl);
            panel1.Controls.Add(taxlbl);
            panel1.Controls.Add(StartDateValue);
            panel1.Controls.Add(lblDays);
            panel1.Controls.Add(priceValuelbl);
            panel1.Controls.Add(lbPriCePerday);
            panel1.Location = new Point(490, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 228);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // dropOffValue
            // 
            dropOffValue.AutoSize = true;
            dropOffValue.Location = new Point(169, 33);
            dropOffValue.Name = "dropOffValue";
            dropOffValue.Size = new Size(16, 15);
            dropOffValue.TabIndex = 15;
            dropOffValue.Text = "6 ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 33);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 14;
            label9.Text = "Drop off:";
            // 
            // pickUpValue
            // 
            pickUpValue.AutoSize = true;
            pickUpValue.Location = new Point(169, 9);
            pickUpValue.Name = "pickUpValue";
            pickUpValue.Size = new Size(16, 15);
            pickUpValue.TabIndex = 13;
            pickUpValue.Text = "6 ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 9);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 12;
            label7.Text = "Pick up:";
            // 
            // returnDateValue
            // 
            returnDateValue.AutoSize = true;
            returnDateValue.Location = new Point(169, 84);
            returnDateValue.Name = "returnDateValue";
            returnDateValue.Size = new Size(16, 15);
            returnDateValue.TabIndex = 11;
            returnDateValue.Text = "6 ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 84);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 10;
            label6.Text = "Return date:";
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Location = new Point(9, 173);
            label2.Name = "label2";
            label2.Size = new Size(282, 1);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // totalValueLbl
            // 
            totalValueLbl.AutoSize = true;
            totalValueLbl.Location = new Point(167, 187);
            totalValueLbl.Name = "totalValueLbl";
            totalValueLbl.Size = new Size(49, 15);
            totalValueLbl.TabIndex = 8;
            totalValueLbl.Text = "620 EGP";
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Location = new Point(16, 187);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(36, 15);
            totalLbl.TabIndex = 7;
            totalLbl.Text = "Total:";
            // 
            // taxValuelbl
            // 
            taxValuelbl.AutoSize = true;
            taxValuelbl.Location = new Point(169, 140);
            taxValuelbl.Name = "taxValuelbl";
            taxValuelbl.Size = new Size(43, 15);
            taxValuelbl.TabIndex = 6;
            taxValuelbl.Text = "20 EGP";
            // 
            // taxlbl
            // 
            taxlbl.AutoSize = true;
            taxlbl.Location = new Point(18, 140);
            taxlbl.Name = "taxlbl";
            taxlbl.Size = new Size(27, 15);
            taxlbl.TabIndex = 5;
            taxlbl.Text = "Tax:";
            // 
            // StartDateValue
            // 
            StartDateValue.AutoSize = true;
            StartDateValue.Location = new Point(169, 59);
            StartDateValue.Name = "StartDateValue";
            StartDateValue.Size = new Size(16, 15);
            StartDateValue.TabIndex = 4;
            StartDateValue.Text = "6 ";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(18, 59);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(60, 15);
            lblDays.TabIndex = 3;
            lblDays.Text = "Start date:";
            lblDays.Click += lblDays_Click;
            // 
            // priceValuelbl
            // 
            priceValuelbl.AutoSize = true;
            priceValuelbl.Location = new Point(169, 113);
            priceValuelbl.Name = "priceValuelbl";
            priceValuelbl.Size = new Size(49, 15);
            priceValuelbl.TabIndex = 2;
            priceValuelbl.Text = "100 EGP";
            priceValuelbl.Click += label4_Click;
            // 
            // lbPriCePerday
            // 
            lbPriCePerday.AutoSize = true;
            lbPriCePerday.Location = new Point(18, 113);
            lbPriCePerday.Name = "lbPriCePerday";
            lbPriCePerday.Size = new Size(78, 15);
            lbPriCePerday.TabIndex = 1;
            lbPriCePerday.Text = "Price per day:";
            lbPriCePerday.UseMnemonic = false;
            lbPriCePerday.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(490, 88);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 10;
            label3.Text = "Booking summary:";
            label3.Click += label3_Click_1;
            // 
            // groupPaymentMetod
            // 
            groupPaymentMetod.BackColor = Color.FromArgb(242, 233, 228);
            groupPaymentMetod.Controls.Add(CardDetailspanel);
            groupPaymentMetod.Controls.Add(Creditbtn);
            groupPaymentMetod.Controls.Add(CasHbtn);
            groupPaymentMetod.Location = new Point(12, 125);
            groupPaymentMetod.Name = "groupPaymentMetod";
            groupPaymentMetod.Size = new Size(250, 203);
            groupPaymentMetod.TabIndex = 11;
            groupPaymentMetod.TabStop = false;
            // 
            // CardDetailspanel
            // 
            CardDetailspanel.Controls.Add(CCVtxtbox);
            CardDetailspanel.Controls.Add(CCVlbl);
            CardDetailspanel.Controls.Add(ExpDateTxtbox);
            CardDetailspanel.Controls.Add(ExpDatelbl);
            CardDetailspanel.Controls.Add(cardNumTxtBox);
            CardDetailspanel.Controls.Add(CardNumlbl);
            CardDetailspanel.Location = new Point(6, 85);
            CardDetailspanel.Name = "CardDetailspanel";
            CardDetailspanel.Size = new Size(220, 100);
            CardDetailspanel.TabIndex = 2;
            CardDetailspanel.Visible = false;
            // 
            // CCVtxtbox
            // 
            CCVtxtbox.Location = new Point(110, 72);
            CCVtxtbox.Name = "CCVtxtbox";
            CCVtxtbox.Size = new Size(100, 23);
            CCVtxtbox.TabIndex = 5;
            // 
            // CCVlbl
            // 
            CCVlbl.AutoSize = true;
            CCVlbl.Location = new Point(10, 75);
            CCVlbl.Name = "CCVlbl";
            CCVlbl.Size = new Size(30, 15);
            CCVlbl.TabIndex = 4;
            CCVlbl.Text = "CCV";
            // 
            // ExpDateTxtbox
            // 
            ExpDateTxtbox.Location = new Point(110, 39);
            ExpDateTxtbox.Name = "ExpDateTxtbox";
            ExpDateTxtbox.Size = new Size(100, 23);
            ExpDateTxtbox.TabIndex = 3;
            // 
            // ExpDatelbl
            // 
            ExpDatelbl.AutoSize = true;
            ExpDatelbl.Location = new Point(10, 42);
            ExpDatelbl.Name = "ExpDatelbl";
            ExpDatelbl.Size = new Size(68, 15);
            ExpDatelbl.TabIndex = 2;
            ExpDatelbl.Text = "Expiry Date:";
            // 
            // cardNumTxtBox
            // 
            cardNumTxtBox.Location = new Point(110, 10);
            cardNumTxtBox.Name = "cardNumTxtBox";
            cardNumTxtBox.Size = new Size(100, 23);
            cardNumTxtBox.TabIndex = 1;
            // 
            // CardNumlbl
            // 
            CardNumlbl.AutoSize = true;
            CardNumlbl.Location = new Point(10, 13);
            CardNumlbl.Name = "CardNumlbl";
            CardNumlbl.Size = new Size(82, 15);
            CardNumlbl.TabIndex = 0;
            CardNumlbl.Text = "Card Number:";
            // 
            // Creditbtn
            // 
            Creditbtn.AutoSize = true;
            Creditbtn.Location = new Point(20, 60);
            Creditbtn.Name = "Creditbtn";
            Creditbtn.Size = new Size(85, 19);
            Creditbtn.TabIndex = 1;
            Creditbtn.TabStop = true;
            Creditbtn.Text = "Credit Card";
            Creditbtn.UseVisualStyleBackColor = true;
            Creditbtn.CheckedChanged += Creditbtn_CheckedChanged;
            // 
            // CasHbtn
            // 
            CasHbtn.AutoSize = true;
            CasHbtn.Location = new Point(20, 30);
            CasHbtn.Name = "CasHbtn";
            CasHbtn.Size = new Size(51, 19);
            CasHbtn.TabIndex = 0;
            CasHbtn.TabStop = true;
            CasHbtn.Text = "Cash";
            CasHbtn.UseVisualStyleBackColor = true;
            CasHbtn.CheckedChanged += CasHbtn_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 88);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 12;
            label4.Text = "Payment Method:";
            label4.Click += label4_Click_1;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(154, 140, 152);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(494, 359);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(298, 40);
            btnPay.TabIndex = 13;
            btnPay.Text = "Pay now";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(34, 34, 59);
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = Color.White;
            backBtn.Location = new Point(494, 405);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(298, 40);
            backBtn.TabIndex = 14;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            // 
            // invalidLabel
            // 
            invalidLabel.AutoSize = true;
            invalidLabel.ForeColor = Color.Red;
            invalidLabel.Location = new Point(12, 336);
            invalidLabel.Name = "invalidLabel";
            invalidLabel.Size = new Size(38, 15);
            invalidLabel.TabIndex = 15;
            invalidLabel.Text = "label5";
            invalidLabel.Visible = false;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(invalidLabel);
            Controls.Add(backBtn);
            Controls.Add(btnPay);
            Controls.Add(label4);
            Controls.Add(groupPaymentMetod);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupPaymentMetod.ResumeLayout(false);
            groupPaymentMetod.PerformLayout();
            CardDetailspanel.ResumeLayout(false);
            CardDetailspanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label StartDateValue;
        private Label lblDays;
        private Label priceValuelbl;
        private Label lbPriCePerday;
        private Label label2;
        private Label totalValueLbl;
        private Label totalLbl;
        private Label taxValuelbl;
        private Label taxlbl;
        private Label label3;
        private GroupBox groupPaymentMetod;
        private RadioButton Creditbtn;
        private RadioButton CasHbtn;
        private Panel CardDetailspanel;
        private TextBox ExpDateTxtbox;
        private Label ExpDatelbl;
        private TextBox cardNumTxtBox;
        private Label CardNumlbl;
        private TextBox CCVtxtbox;
        private Label CCVlbl;
        private Label label4;
        private Button btnPay;
        private Button backBtn;
        private Label returnDateValue;
        private Label label6;
        private Label invalidLabel;
        private Label dropOffValue;
        private Label label9;
        private Label pickUpValue;
        private Label label7;
    }
}
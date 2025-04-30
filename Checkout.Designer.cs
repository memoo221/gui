

using System.Drawing;
using System.Windows.Forms;

namespace DisplayCars
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropOffValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pickUpValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.returnDateValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalValueLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.taxValuelbl = new System.Windows.Forms.Label();
            this.taxlbl = new System.Windows.Forms.Label();
            this.StartDateValue = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.priceValuelbl = new System.Windows.Forms.Label();
            this.lbPriCePerday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupPaymentMetod = new System.Windows.Forms.GroupBox();
            this.CardDetailspanel = new System.Windows.Forms.Panel();
            this.CCVtxtbox = new System.Windows.Forms.TextBox();
            this.CCVlbl = new System.Windows.Forms.Label();
            this.ExpDateTxtbox = new System.Windows.Forms.TextBox();
            this.ExpDatelbl = new System.Windows.Forms.Label();
            this.cardNumTxtBox = new System.Windows.Forms.TextBox();
            this.CardNumlbl = new System.Windows.Forms.Label();
            this.Creditbtn = new System.Windows.Forms.RadioButton();
            this.CasHbtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.invalidLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupPaymentMetod.SuspendLayout();
            this.CardDetailspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(665, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dropOffValue);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pickUpValue);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.returnDateValue);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.totalValueLbl);
            this.panel1.Controls.Add(this.totalLbl);
            this.panel1.Controls.Add(this.taxValuelbl);
            this.panel1.Controls.Add(this.taxlbl);
            this.panel1.Controls.Add(this.StartDateValue);
            this.panel1.Controls.Add(this.lblDays);
            this.panel1.Controls.Add(this.priceValuelbl);
            this.panel1.Controls.Add(this.lbPriCePerday);
            this.panel1.Location = new System.Drawing.Point(420, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 198);
            this.panel1.TabIndex = 1;
            // 
            // dropOffValue
            // 
            this.dropOffValue.AutoSize = true;
            this.dropOffValue.Location = new System.Drawing.Point(145, 29);
            this.dropOffValue.Name = "dropOffValue";
            this.dropOffValue.Size = new System.Drawing.Size(16, 13);
            this.dropOffValue.TabIndex = 15;
            this.dropOffValue.Text = "6 ";
            this.dropOffValue.Click += new System.EventHandler(this.dropOffValue_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Drop off:";
            // 
            // pickUpValue
            // 
            this.pickUpValue.AutoSize = true;
            this.pickUpValue.Location = new System.Drawing.Point(145, 8);
            this.pickUpValue.Name = "pickUpValue";
            this.pickUpValue.Size = new System.Drawing.Size(16, 13);
            this.pickUpValue.TabIndex = 13;
            this.pickUpValue.Text = "6 ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pick up:";
            // 
            // returnDateValue
            // 
            this.returnDateValue.AutoSize = true;
            this.returnDateValue.Location = new System.Drawing.Point(145, 73);
            this.returnDateValue.Name = "returnDateValue";
            this.returnDateValue.Size = new System.Drawing.Size(16, 13);
            this.returnDateValue.TabIndex = 11;
            this.returnDateValue.Text = "6 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Return date:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 1);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // totalValueLbl
            // 
            this.totalValueLbl.AutoSize = true;
            this.totalValueLbl.Location = new System.Drawing.Point(143, 162);
            this.totalValueLbl.Name = "totalValueLbl";
            this.totalValueLbl.Size = new System.Drawing.Size(50, 13);
            this.totalValueLbl.TabIndex = 8;
            this.totalValueLbl.Text = "620 EGP";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(14, 162);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(34, 13);
            this.totalLbl.TabIndex = 7;
            this.totalLbl.Text = "Total:";
            // 
            // taxValuelbl
            // 
            this.taxValuelbl.AutoSize = true;
            this.taxValuelbl.Location = new System.Drawing.Point(145, 121);
            this.taxValuelbl.Name = "taxValuelbl";
            this.taxValuelbl.Size = new System.Drawing.Size(44, 13);
            this.taxValuelbl.TabIndex = 6;
            this.taxValuelbl.Text = "20 EGP";
            // 
            // taxlbl
            // 
            this.taxlbl.AutoSize = true;
            this.taxlbl.Location = new System.Drawing.Point(15, 121);
            this.taxlbl.Name = "taxlbl";
            this.taxlbl.Size = new System.Drawing.Size(28, 13);
            this.taxlbl.TabIndex = 5;
            this.taxlbl.Text = "Tax:";
            // 
            // StartDateValue
            // 
            this.StartDateValue.AutoSize = true;
            this.StartDateValue.Location = new System.Drawing.Point(145, 51);
            this.StartDateValue.Name = "StartDateValue";
            this.StartDateValue.Size = new System.Drawing.Size(16, 13);
            this.StartDateValue.TabIndex = 4;
            this.StartDateValue.Text = "6 ";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(15, 51);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(56, 13);
            this.lblDays.TabIndex = 3;
            this.lblDays.Text = "Start date:";
            // 
            // priceValuelbl
            // 
            this.priceValuelbl.AutoSize = true;
            this.priceValuelbl.Location = new System.Drawing.Point(145, 98);
            this.priceValuelbl.Name = "priceValuelbl";
            this.priceValuelbl.Size = new System.Drawing.Size(50, 13);
            this.priceValuelbl.TabIndex = 2;
            this.priceValuelbl.Text = "100 EGP";
            // 
            // lbPriCePerday
            // 
            this.lbPriCePerday.AutoSize = true;
            this.lbPriCePerday.Location = new System.Drawing.Point(15, 98);
            this.lbPriCePerday.Name = "lbPriCePerday";
            this.lbPriCePerday.Size = new System.Drawing.Size(72, 13);
            this.lbPriCePerday.TabIndex = 1;
            this.lbPriCePerday.Text = "Price per day:";
            this.lbPriCePerday.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Booking summary:";
            // 
            // groupPaymentMetod
            // 
            this.groupPaymentMetod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.groupPaymentMetod.Controls.Add(this.CardDetailspanel);
            this.groupPaymentMetod.Controls.Add(this.Creditbtn);
            this.groupPaymentMetod.Controls.Add(this.CasHbtn);
            this.groupPaymentMetod.Location = new System.Drawing.Point(10, 108);
            this.groupPaymentMetod.Name = "groupPaymentMetod";
            this.groupPaymentMetod.Size = new System.Drawing.Size(214, 176);
            this.groupPaymentMetod.TabIndex = 11;
            this.groupPaymentMetod.TabStop = false;
            // 
            // CardDetailspanel
            // 
            this.CardDetailspanel.Controls.Add(this.CCVtxtbox);
            this.CardDetailspanel.Controls.Add(this.CCVlbl);
            this.CardDetailspanel.Controls.Add(this.ExpDateTxtbox);
            this.CardDetailspanel.Controls.Add(this.ExpDatelbl);
            this.CardDetailspanel.Controls.Add(this.cardNumTxtBox);
            this.CardDetailspanel.Controls.Add(this.CardNumlbl);
            this.CardDetailspanel.Location = new System.Drawing.Point(5, 74);
            this.CardDetailspanel.Name = "CardDetailspanel";
            this.CardDetailspanel.Size = new System.Drawing.Size(189, 87);
            this.CardDetailspanel.TabIndex = 2;
            this.CardDetailspanel.Visible = false;
            this.CardDetailspanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CardDetailspanel_Paint);
            // 
            // CCVtxtbox
            // 
            this.CCVtxtbox.Location = new System.Drawing.Point(94, 62);
            this.CCVtxtbox.Name = "CCVtxtbox";
            this.CCVtxtbox.Size = new System.Drawing.Size(86, 20);
            this.CCVtxtbox.TabIndex = 5;
            // 
            // CCVlbl
            // 
            this.CCVlbl.AutoSize = true;
            this.CCVlbl.Location = new System.Drawing.Point(9, 65);
            this.CCVlbl.Name = "CCVlbl";
            this.CCVlbl.Size = new System.Drawing.Size(28, 13);
            this.CCVlbl.TabIndex = 4;
            this.CCVlbl.Text = "CCV";
            // 
            // ExpDateTxtbox
            // 
            this.ExpDateTxtbox.Location = new System.Drawing.Point(94, 34);
            this.ExpDateTxtbox.Name = "ExpDateTxtbox";
            this.ExpDateTxtbox.Size = new System.Drawing.Size(86, 20);
            this.ExpDateTxtbox.TabIndex = 3;
            // 
            // ExpDatelbl
            // 
            this.ExpDatelbl.AutoSize = true;
            this.ExpDatelbl.Location = new System.Drawing.Point(9, 36);
            this.ExpDatelbl.Name = "ExpDatelbl";
            this.ExpDatelbl.Size = new System.Drawing.Size(64, 13);
            this.ExpDatelbl.TabIndex = 2;
            this.ExpDatelbl.Text = "Expiry Date:";
            // 
            // cardNumTxtBox
            // 
            this.cardNumTxtBox.Location = new System.Drawing.Point(94, 9);
            this.cardNumTxtBox.Name = "cardNumTxtBox";
            this.cardNumTxtBox.Size = new System.Drawing.Size(86, 20);
            this.cardNumTxtBox.TabIndex = 1;
            // 
            // CardNumlbl
            // 
            this.CardNumlbl.AutoSize = true;
            this.CardNumlbl.Location = new System.Drawing.Point(9, 11);
            this.CardNumlbl.Name = "CardNumlbl";
            this.CardNumlbl.Size = new System.Drawing.Size(72, 13);
            this.CardNumlbl.TabIndex = 0;
            this.CardNumlbl.Text = "Card Number:";
            // 
            // Creditbtn
            // 
            this.Creditbtn.AutoSize = true;
            this.Creditbtn.Location = new System.Drawing.Point(17, 52);
            this.Creditbtn.Name = "Creditbtn";
            this.Creditbtn.Size = new System.Drawing.Size(77, 17);
            this.Creditbtn.TabIndex = 1;
            this.Creditbtn.TabStop = true;
            this.Creditbtn.Text = "Credit Card";
            this.Creditbtn.UseVisualStyleBackColor = true;
            this.Creditbtn.CheckedChanged += new System.EventHandler(this.Creditbtn_CheckedChanged_1);
            // 
            // CasHbtn
            // 
            this.CasHbtn.AutoSize = true;
            this.CasHbtn.Location = new System.Drawing.Point(17, 26);
            this.CasHbtn.Name = "CasHbtn";
            this.CasHbtn.Size = new System.Drawing.Size(49, 17);
            this.CasHbtn.TabIndex = 0;
            this.CasHbtn.TabStop = true;
            this.CasHbtn.Text = "Cash";
            this.CasHbtn.UseVisualStyleBackColor = true;
            this.CasHbtn.CheckedChanged += new System.EventHandler(this.CasHbtn_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Payment Method:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(423, 311);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(255, 35);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Pay now";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(423, 351);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(255, 35);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // invalidLabel
            // 
            this.invalidLabel.AutoSize = true;
            this.invalidLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidLabel.Location = new System.Drawing.Point(10, 291);
            this.invalidLabel.Name = "invalidLabel";
            this.invalidLabel.Size = new System.Drawing.Size(35, 13);
            this.invalidLabel.TabIndex = 15;
            this.invalidLabel.Text = "label5";
            this.invalidLabel.Visible = false;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.invalidLabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupPaymentMetod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupPaymentMetod.ResumeLayout(false);
            this.groupPaymentMetod.PerformLayout();
            this.CardDetailspanel.ResumeLayout(false);
            this.CardDetailspanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
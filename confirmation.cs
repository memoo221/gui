using System.Windows.Forms;
using System;

namespace WindowsFormsApp5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelPickup;
        private Label labelReturn;
        private PictureBox pictureBoxCar;
        private Label labelCarName;
        private Label labelSpecs;
        private GroupBox groupBoxExtras;
        private CheckBox checkBoxBabySeat;
        private CheckBox checkBoxUnlimitedKM;
        private CheckBox checkBoxProtection;
        private Label labelPriceUnlimitedKM;
        private Label labelPriceProtection;
        private Label labelAdditionalNote;
        private TextBox textBoxNote;
        private Button buttonConfirm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelPickup = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.labelCarName = new System.Windows.Forms.Label();
            this.labelSpecs = new System.Windows.Forms.Label();
            this.groupBoxExtras = new System.Windows.Forms.GroupBox();
            this.checkBoxBabySeat = new System.Windows.Forms.CheckBox();
            this.checkBoxUnlimitedKM = new System.Windows.Forms.CheckBox();
            this.checkBoxProtection = new System.Windows.Forms.CheckBox();
            this.labelPriceUnlimitedKM = new System.Windows.Forms.Label();
            this.labelPriceProtection = new System.Windows.Forms.Label();
            this.labelAdditionalNote = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.groupBoxExtras.SuspendLayout();
            this.SuspendLayout();

            // Pickup label
            this.labelPickup.AutoSize = true;
            this.labelPickup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelPickup.Location = new System.Drawing.Point(20, 20);
            this.labelPickup.Text = "Pick up: King Khalid Airport Terminal 3-4 - Riyadh\nWed, 30 Apr, 12:00 AM";

            // Return label
            this.labelReturn.AutoSize = true;
            this.labelReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelReturn.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelReturn.Location = new System.Drawing.Point(20, 60);
            this.labelReturn.Text = "Return: King Khalid Airport Terminal 3-4 - Riyadh\nSat, 17 May, 12:30 AM";

            // Car picture
            this.pictureBoxCar.Location = new System.Drawing.Point(20, 110);
            this.pictureBoxCar.Size = new System.Drawing.Size(250, 140);
            this.pictureBoxCar.SizeMode = PictureBoxSizeMode.StretchImage;
            //this.pictureBoxCar.Image = Image.FromFile("car.png"); // Make sure "car.png" exists

            // Car name label
            this.labelCarName.AutoSize = true;
            this.labelCarName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelCarName.Location = new System.Drawing.Point(290, 110);
            this.labelCarName.Text = "Chery Arrizo 6 2023 or Similar";

            // Specs label
            this.labelSpecs.AutoSize = true;
            this.labelSpecs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSpecs.Location = new System.Drawing.Point(290, 150);
            this.labelSpecs.Text = "Seats: 5 | Bags: 2 | Gear: Auto | Doors: 4 | AC";

            // Extras group
            this.groupBoxExtras.Text = "Extras";
            this.groupBoxExtras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxExtras.Location = new System.Drawing.Point(20, 270);
            this.groupBoxExtras.Size = new System.Drawing.Size(740, 130);

            // Baby Seat
            this.checkBoxBabySeat.Text = "Baby Seat (Free)";
            this.checkBoxBabySeat.Location = new System.Drawing.Point(20, 30);

            // Unlimited KM
            this.checkBoxUnlimitedKM.Text = "Unlimited KM";
            this.checkBoxUnlimitedKM.Location = new System.Drawing.Point(20, 60);
            this.labelPriceUnlimitedKM.Text = "1000.00 EGP";
            this.labelPriceUnlimitedKM.Location = new System.Drawing.Point(150, 62);

            // Protection
            this.checkBoxProtection.Text = "Protection";
            this.checkBoxProtection.Location = new System.Drawing.Point(20, 90);
            this.labelPriceProtection.Text = "1000.00 EGP";
            this.labelPriceProtection.Location = new System.Drawing.Point(150, 92);

            // Add controls to groupbox
            this.groupBoxExtras.Controls.Add(this.checkBoxBabySeat);
            this.groupBoxExtras.Controls.Add(this.checkBoxUnlimitedKM);
            this.groupBoxExtras.Controls.Add(this.labelPriceUnlimitedKM);
            this.groupBoxExtras.Controls.Add(this.checkBoxProtection);
            this.groupBoxExtras.Controls.Add(this.labelPriceProtection);

            // Additional Note Label
            this.labelAdditionalNote.AutoSize = true;
            this.labelAdditionalNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAdditionalNote.Location = new System.Drawing.Point(20, 420);
            this.labelAdditionalNote.Text = "Additional Note";

            // Additional Note TextBox
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxNote.Location = new System.Drawing.Point(20, 450);
            this.textBoxNote.Size = new System.Drawing.Size(500, 100);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Font = new System.Drawing.Font("Segoe UI", 10F);
            // PlaceholderText only available in .NET 6+, you can comment it if using older .NET
            //this.textBoxNote.PlaceholderText = "Write Your Comment Here...";
            // Additional Note TextBox
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxNote.Location = new System.Drawing.Point(20, 450);
            this.textBoxNote.Size = new System.Drawing.Size(500, 100);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxNote.Text = "Write Your Comment Here...";
            this.textBoxNote.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNote.Enter += new System.EventHandler(this.textBoxNote_Enter);
            this.textBoxNote.Leave += new System.EventHandler(this.textBoxNote_Leave);


            // Confirm Button
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonConfirm.BackColor = System.Drawing.Color.Purple;
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.FlatStyle = FlatStyle.Flat;
            this.buttonConfirm.Location = new System.Drawing.Point(540, 500);
            this.buttonConfirm.Size = new System.Drawing.Size(120, 40);
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);

            // Form settings
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.labelPickup);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.labelCarName);
            this.Controls.Add(this.labelSpecs);
            this.Controls.Add(this.groupBoxExtras);
            this.Controls.Add(this.labelAdditionalNote);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.buttonConfirm);
            this.Text = "Car Rental Booking";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.groupBoxExtras.ResumeLayout(false);
            this.groupBoxExtras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void textBoxNote_Leave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBoxNote_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your note has been submitted:\n" + textBoxNote.Text, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

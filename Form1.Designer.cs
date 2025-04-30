namespace DisplayCars
{
    partial class DisplayCar
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.flowLayoutCars = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCategory.Location = new System.Drawing.Point(47, 63);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(96, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "By Categories";
            this.lblCategory.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Arial", 10F);
            this.lblSort.Location = new System.Drawing.Point(233, 63);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(52, 16);
            this.lblSort.TabIndex = 1;
            this.lblSort.Text = "Sort by";
            this.lblSort.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.IntegralHeight = false;
            this.cmbCategories.Location = new System.Drawing.Point(50, 79);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(151, 24);
            this.cmbCategories.TabIndex = 2;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbSort
            // 
            this.cmbSort.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(236, 79);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(151, 24);
            this.cmbSort.TabIndex = 3;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // flowLayoutCars
            // 
            this.flowLayoutCars.AutoScroll = true;
            this.flowLayoutCars.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutCars.Location = new System.Drawing.Point(50, 164);
            this.flowLayoutCars.Name = "flowLayoutCars";
            this.flowLayoutCars.Size = new System.Drawing.Size(960, 600);
            this.flowLayoutCars.TabIndex = 5;
            this.flowLayoutCars.WrapContents = false;
            this.flowLayoutCars.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // DisplayCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 761);
            this.Controls.Add(this.flowLayoutCars);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblCategory);
            this.Name = "DisplayCar";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "CarRentalDisplay";
            this.Load += new System.EventHandler(this.DisplayCar_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCars;
    }
}


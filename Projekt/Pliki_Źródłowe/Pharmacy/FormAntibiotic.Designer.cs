namespace Pharmacy
{
    partial class FormAntibiotic
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
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.listBoxAntibiotic = new System.Windows.Forms.ListBox();
            this.nomilalLabel = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addAntibioticButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.prescriptionCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Suplement",
            "Antybiotyk"});
            this.typeComboBox.Location = new System.Drawing.Point(170, 214);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(303, 50);
            this.typeComboBox.TabIndex = 27;
            // 
            // listBoxAntibiotic
            // 
            this.listBoxAntibiotic.FormattingEnabled = true;
            this.listBoxAntibiotic.Location = new System.Drawing.Point(513, 264);
            this.listBoxAntibiotic.Name = "listBoxAntibiotic";
            this.listBoxAntibiotic.Size = new System.Drawing.Size(412, 342);
            this.listBoxAntibiotic.TabIndex = 26;
            // 
            // nomilalLabel
            // 
            this.nomilalLabel.AutoSize = true;
            this.nomilalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.nomilalLabel.Location = new System.Drawing.Point(426, 119);
            this.nomilalLabel.Name = "nomilalLabel";
            this.nomilalLabel.Size = new System.Drawing.Size(47, 44);
            this.nomilalLabel.TabIndex = 25;
            this.nomilalLabel.Text = "zł";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNumericUpDown.Location = new System.Drawing.Point(170, 117);
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(247, 50);
            this.priceNumericUpDown.TabIndex = 24;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addAntibioticButton
            // 
            this.addAntibioticButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.addAntibioticButton.Location = new System.Drawing.Point(19, 466);
            this.addAntibioticButton.Name = "addAntibioticButton";
            this.addAntibioticButton.Size = new System.Drawing.Size(454, 146);
            this.addAntibioticButton.TabIndex = 23;
            this.addAntibioticButton.Text = "Dodaj antybiotyk";
            this.addAntibioticButton.UseVisualStyleBackColor = true;
            this.addAntibioticButton.Click += new System.EventHandler(this.addAntibioticButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.descriptionTextBox.Location = new System.Drawing.Point(593, 28);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.descriptionTextBox.Size = new System.Drawing.Size(332, 200);
            this.descriptionTextBox.TabIndex = 21;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.nameTextBox.Location = new System.Drawing.Point(170, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(303, 50);
            this.nameTextBox.TabIndex = 20;
            // 
            // prescriptionLabel
            // 
            this.prescriptionLabel.AutoSize = true;
            this.prescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.prescriptionLabel.Location = new System.Drawing.Point(22, 308);
            this.prescriptionLabel.Name = "prescriptionLabel";
            this.prescriptionLabel.Size = new System.Drawing.Size(266, 29);
            this.prescriptionLabel.TabIndex = 19;
            this.prescriptionLabel.Text = "Czy lek jest na recepte?";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.typeLabel.Location = new System.Drawing.Point(19, 217);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(103, 44);
            this.typeLabel.TabIndex = 18;
            this.typeLabel.Text = "Typ: ";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.descriptionLabel.Location = new System.Drawing.Point(479, 34);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(119, 44);
            this.descriptionLabel.TabIndex = 17;
            this.descriptionLabel.Text = "Opis: ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.priceLabel.Location = new System.Drawing.Point(19, 119);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(130, 44);
            this.priceLabel.TabIndex = 16;
            this.priceLabel.Text = "Cena: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.nameLabel.Location = new System.Drawing.Point(19, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(145, 44);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Nazwa:";
            // 
            // prescriptionCheckBox
            // 
            this.prescriptionCheckBox.AutoSize = true;
            this.prescriptionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.prescriptionCheckBox.Location = new System.Drawing.Point(294, 312);
            this.prescriptionCheckBox.Name = "prescriptionCheckBox";
            this.prescriptionCheckBox.Size = new System.Drawing.Size(15, 14);
            this.prescriptionCheckBox.TabIndex = 28212;
            this.prescriptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormAntibiotic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.prescriptionCheckBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.listBoxAntibiotic);
            this.Controls.Add(this.nomilalLabel);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.addAntibioticButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.prescriptionLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "FormAntibiotic";
            this.Text = "FormAntibiotic";
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ListBox listBoxAntibiotic;
        private System.Windows.Forms.Label nomilalLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Button addAntibioticButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label prescriptionLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckBox prescriptionCheckBox;
    }
}
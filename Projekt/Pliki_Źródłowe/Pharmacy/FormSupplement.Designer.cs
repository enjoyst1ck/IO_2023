namespace Pharmacy
{
    partial class FormSupplement
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.activeSubstanceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.activeSubstanceTextBox = new System.Windows.Forms.TextBox();
            this.addSupplementButton = new System.Windows.Forms.Button();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nomilalLabel = new System.Windows.Forms.Label();
            this.listBoxSupplement = new System.Windows.Forms.ListBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.nameLabel.Location = new System.Drawing.Point(12, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(145, 44);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nazwa:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.priceLabel.Location = new System.Drawing.Point(12, 136);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(130, 44);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Cena: ";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.descriptionLabel.Location = new System.Drawing.Point(472, 51);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(119, 44);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Opis: ";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.typeLabel.Location = new System.Drawing.Point(12, 234);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(103, 44);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Typ: ";
            // 
            // activeSubstanceLabel
            // 
            this.activeSubstanceLabel.AutoSize = true;
            this.activeSubstanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.activeSubstanceLabel.Location = new System.Drawing.Point(12, 313);
            this.activeSubstanceLabel.Name = "activeSubstanceLabel";
            this.activeSubstanceLabel.Size = new System.Drawing.Size(302, 44);
            this.activeSubstanceLabel.TabIndex = 4;
            this.activeSubstanceLabel.Text = "Składnik czynny:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.nameTextBox.Location = new System.Drawing.Point(163, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(303, 50);
            this.nameTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.descriptionTextBox.Location = new System.Drawing.Point(586, 45);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.descriptionTextBox.Size = new System.Drawing.Size(332, 200);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // activeSubstanceTextBox
            // 
            this.activeSubstanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.activeSubstanceTextBox.Location = new System.Drawing.Point(20, 380);
            this.activeSubstanceTextBox.Name = "activeSubstanceTextBox";
            this.activeSubstanceTextBox.Size = new System.Drawing.Size(446, 50);
            this.activeSubstanceTextBox.TabIndex = 9;
            // 
            // addSupplementButton
            // 
            this.addSupplementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.addSupplementButton.Location = new System.Drawing.Point(12, 483);
            this.addSupplementButton.Name = "addSupplementButton";
            this.addSupplementButton.Size = new System.Drawing.Size(454, 146);
            this.addSupplementButton.TabIndex = 10;
            this.addSupplementButton.Text = "Dodaj suplement";
            this.addSupplementButton.UseVisualStyleBackColor = true;
            this.addSupplementButton.Click += new System.EventHandler(this.addSupplementButton_Click);
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
            this.priceNumericUpDown.Location = new System.Drawing.Point(163, 134);
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(247, 50);
            this.priceNumericUpDown.TabIndex = 11;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nomilalLabel
            // 
            this.nomilalLabel.AutoSize = true;
            this.nomilalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.nomilalLabel.Location = new System.Drawing.Point(419, 136);
            this.nomilalLabel.Name = "nomilalLabel";
            this.nomilalLabel.Size = new System.Drawing.Size(47, 44);
            this.nomilalLabel.TabIndex = 12;
            this.nomilalLabel.Text = "zł";
            // 
            // listBoxSupplement
            // 
            this.listBoxSupplement.FormattingEnabled = true;
            this.listBoxSupplement.Location = new System.Drawing.Point(506, 281);
            this.listBoxSupplement.Name = "listBoxSupplement";
            this.listBoxSupplement.Size = new System.Drawing.Size(412, 342);
            this.listBoxSupplement.TabIndex = 13;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Suplement",
            "Antybiotyk"});
            this.typeComboBox.Location = new System.Drawing.Point(163, 231);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(303, 50);
            this.typeComboBox.TabIndex = 14;
            // 
            // FormSupplement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.listBoxSupplement);
            this.Controls.Add(this.nomilalLabel);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.addSupplementButton);
            this.Controls.Add(this.activeSubstanceTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.activeSubstanceLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "FormSupplement";
            this.Text = "FormSupplement";
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label activeSubstanceLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox activeSubstanceTextBox;
        private System.Windows.Forms.Button addSupplementButton;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label nomilalLabel;
        private System.Windows.Forms.ListBox listBoxSupplement;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}
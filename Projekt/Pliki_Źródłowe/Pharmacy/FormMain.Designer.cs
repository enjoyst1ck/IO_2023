namespace Pharmacy
{
    partial class FormMain
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
            this.buttonBrowseList = new System.Windows.Forms.Button();
            this.buttonAddSupplement = new System.Windows.Forms.Button();
            this.buttonAddAntibiotic = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBrowseList
            // 
            this.buttonBrowseList.Location = new System.Drawing.Point(153, 363);
            this.buttonBrowseList.Name = "buttonBrowseList";
            this.buttonBrowseList.Size = new System.Drawing.Size(596, 166);
            this.buttonBrowseList.TabIndex = 7;
            this.buttonBrowseList.Text = "Przeglądaj obiekty";
            this.buttonBrowseList.UseVisualStyleBackColor = true;
            this.buttonBrowseList.Click += new System.EventHandler(this.buttonBrowseList_Click);
            // 
            // buttonAddSupplement
            // 
            this.buttonAddSupplement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddSupplement.Location = new System.Drawing.Point(153, 156);
            this.buttonAddSupplement.Name = "buttonAddSupplement";
            this.buttonAddSupplement.Size = new System.Drawing.Size(295, 166);
            this.buttonAddSupplement.TabIndex = 6;
            this.buttonAddSupplement.Text = "Dodaj Suplement";
            this.buttonAddSupplement.UseVisualStyleBackColor = true;
            this.buttonAddSupplement.Click += new System.EventHandler(this.buttonAddSupplement_Click);
            // 
            // buttonAddAntibiotic
            // 
            this.buttonAddAntibiotic.Location = new System.Drawing.Point(454, 156);
            this.buttonAddAntibiotic.Name = "buttonAddAntibiotic";
            this.buttonAddAntibiotic.Size = new System.Drawing.Size(295, 166);
            this.buttonAddAntibiotic.TabIndex = 5;
            this.buttonAddAntibiotic.Text = "Dodaj Antybiotyk";
            this.buttonAddAntibiotic.UseVisualStyleBackColor = true;
            this.buttonAddAntibiotic.Click += new System.EventHandler(this.buttonAddAntibiotic_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMain.Location = new System.Drawing.Point(400, 61);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(150, 36);
            this.labelMain.TabIndex = 9;
            this.labelMain.Text = "Pharmacy";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.buttonBrowseList);
            this.Controls.Add(this.buttonAddSupplement);
            this.Controls.Add(this.buttonAddAntibiotic);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowseList;
        private System.Windows.Forms.Button buttonAddSupplement;
        private System.Windows.Forms.Button buttonAddAntibiotic;
        private System.Windows.Forms.Label labelMain;
    }
}
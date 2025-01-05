namespace BankQueueApp
{
    partial class KioskForm
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
            this.comboBoxServiceType = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblQueueNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxServiceType
            // 
            this.comboBoxServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServiceType.FormattingEnabled = true;
            this.comboBoxServiceType.Location = new System.Drawing.Point(130, 50);
            this.comboBoxServiceType.Name = "comboBoxServiceType";
            this.comboBoxServiceType.Size = new System.Drawing.Size(220, 33);
            this.comboBoxServiceType.TabIndex = 0;
            this.comboBoxServiceType.Text = "Select Service Type";
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(171, 119);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 35);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Get Number";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblQueueNumber
            // 
            this.lblQueueNumber.AutoSize = true;
            this.lblQueueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNumber.Location = new System.Drawing.Point(57, 205);
            this.lblQueueNumber.Name = "lblQueueNumber";
            this.lblQueueNumber.Size = new System.Drawing.Size(138, 25);
            this.lblQueueNumber.TabIndex = 2;
            this.lblQueueNumber.Text = "Your Number: ";
            // 
            // KioskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 345);
            this.Controls.Add(this.lblQueueNumber);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.comboBoxServiceType);
            this.Name = "KioskForm";
            this.Text = "KioskForm";
            this.Load += new System.EventHandler(this.KioskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxServiceType;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblQueueNumber;
    }
}
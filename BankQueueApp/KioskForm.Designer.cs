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
            this.comboBoxServiceType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxServiceType.Font = new System.Drawing.Font("Fredoka SemiBold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServiceType.ForeColor = System.Drawing.Color.Coral;
            this.comboBoxServiceType.FormattingEnabled = true;
            this.comboBoxServiceType.Location = new System.Drawing.Point(114, 48);
            this.comboBoxServiceType.Name = "comboBoxServiceType";
            this.comboBoxServiceType.Size = new System.Drawing.Size(248, 37);
            this.comboBoxServiceType.TabIndex = 0;
            this.comboBoxServiceType.Text = "Select Service Type";
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerate.FlatAppearance.BorderSize = 15;
            this.btnGenerate.Font = new System.Drawing.Font("Fredoka", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnGenerate.Location = new System.Drawing.Point(161, 123);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(142, 45);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Get Number";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblQueueNumber
            // 
            this.lblQueueNumber.AutoSize = true;
            this.lblQueueNumber.Font = new System.Drawing.Font("Fredoka", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNumber.ForeColor = System.Drawing.Color.Coral;
            this.lblQueueNumber.Location = new System.Drawing.Point(48, 215);
            this.lblQueueNumber.Name = "lblQueueNumber";
            this.lblQueueNumber.Size = new System.Drawing.Size(184, 34);
            this.lblQueueNumber.TabIndex = 2;
            this.lblQueueNumber.Text = "Your Number: ";
            // 
            // KioskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
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
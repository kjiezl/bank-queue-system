namespace BankQueueApp
{
    partial class Menu
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnKiosk = new System.Windows.Forms.Button();
            this.btnTeller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.AutoSize = true;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(143, 86);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(86, 35);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnKiosk
            // 
            this.btnKiosk.AutoSize = true;
            this.btnKiosk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiosk.Location = new System.Drawing.Point(145, 149);
            this.btnKiosk.Name = "btnKiosk";
            this.btnKiosk.Size = new System.Drawing.Size(75, 35);
            this.btnKiosk.TabIndex = 1;
            this.btnKiosk.Text = "Kiosk";
            this.btnKiosk.UseVisualStyleBackColor = true;
            this.btnKiosk.Click += new System.EventHandler(this.btnKiosk_Click);
            // 
            // btnTeller
            // 
            this.btnTeller.AutoSize = true;
            this.btnTeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeller.Location = new System.Drawing.Point(143, 216);
            this.btnTeller.Name = "btnTeller";
            this.btnTeller.Size = new System.Drawing.Size(75, 35);
            this.btnTeller.TabIndex = 2;
            this.btnTeller.Text = "Teller";
            this.btnTeller.UseVisualStyleBackColor = true;
            this.btnTeller.Click += new System.EventHandler(this.btnTeller_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 344);
            this.Controls.Add(this.btnTeller);
            this.Controls.Add(this.btnKiosk);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnKiosk;
        private System.Windows.Forms.Button btnTeller;
    }
}


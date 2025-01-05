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
            this.btnDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisplay.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplay.FlatAppearance.BorderSize = 15;
            this.btnDisplay.Font = new System.Drawing.Font("Fredoka", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDisplay.Location = new System.Drawing.Point(118, 46);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Padding = new System.Windows.Forms.Padding(10);
            this.btnDisplay.Size = new System.Drawing.Size(145, 79);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnKiosk
            // 
            this.btnKiosk.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnKiosk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiosk.FlatAppearance.BorderSize = 15;
            this.btnKiosk.Font = new System.Drawing.Font("Fredoka", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiosk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKiosk.Location = new System.Drawing.Point(118, 133);
            this.btnKiosk.Name = "btnKiosk";
            this.btnKiosk.Size = new System.Drawing.Size(145, 77);
            this.btnKiosk.TabIndex = 1;
            this.btnKiosk.Text = "Kiosk";
            this.btnKiosk.UseVisualStyleBackColor = false;
            this.btnKiosk.Click += new System.EventHandler(this.btnKiosk_Click);
            // 
            // btnTeller
            // 
            this.btnTeller.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnTeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeller.Font = new System.Drawing.Font("Fredoka", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeller.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTeller.Location = new System.Drawing.Point(118, 230);
            this.btnTeller.Name = "btnTeller";
            this.btnTeller.Size = new System.Drawing.Size(145, 77);
            this.btnTeller.TabIndex = 2;
            this.btnTeller.Text = "Teller";
            this.btnTeller.UseVisualStyleBackColor = false;
            this.btnTeller.Click += new System.EventHandler(this.btnTeller_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(387, 351);
            this.Controls.Add(this.btnTeller);
            this.Controls.Add(this.btnKiosk);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnKiosk;
        private System.Windows.Forms.Button btnTeller;
    }
}


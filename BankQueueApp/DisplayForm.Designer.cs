namespace BankQueueApp
{
    partial class DisplayForm
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
            this.lblAssignedTeller = new System.Windows.Forms.Label();
            this.listBoxQueue = new System.Windows.Forms.ListBox();
            this.lblCustomersInQueue = new System.Windows.Forms.Label();
            this.lblCurrentQueue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAssignedTeller
            // 
            this.lblAssignedTeller.AutoSize = true;
            this.lblAssignedTeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedTeller.Location = new System.Drawing.Point(330, 72);
            this.lblAssignedTeller.Name = "lblAssignedTeller";
            this.lblAssignedTeller.Size = new System.Drawing.Size(0, 25);
            this.lblAssignedTeller.TabIndex = 1;
            // 
            // listBoxQueue
            // 
            this.listBoxQueue.BackColor = System.Drawing.Color.LightBlue;
            this.listBoxQueue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBoxQueue.Font = new System.Drawing.Font("Fredoka", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQueue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listBoxQueue.FormattingEnabled = true;
            this.listBoxQueue.ItemHeight = 25;
            this.listBoxQueue.Location = new System.Drawing.Point(70, 175);
            this.listBoxQueue.Margin = new System.Windows.Forms.Padding(7);
            this.listBoxQueue.Name = "listBoxQueue";
            this.listBoxQueue.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxQueue.Size = new System.Drawing.Size(426, 179);
            this.listBoxQueue.TabIndex = 5;
            // 
            // lblCustomersInQueue
            // 
            this.lblCustomersInQueue.AutoSize = true;
            this.lblCustomersInQueue.Font = new System.Drawing.Font("Fredoka SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersInQueue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCustomersInQueue.Location = new System.Drawing.Point(27, 134);
            this.lblCustomersInQueue.Name = "lblCustomersInQueue";
            this.lblCustomersInQueue.Size = new System.Drawing.Size(122, 34);
            this.lblCustomersInQueue.TabIndex = 3;
            this.lblCustomersInQueue.Text = "Waiting: ";
            // 
            // lblCurrentQueue
            // 
            this.lblCurrentQueue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCurrentQueue.AutoSize = true;
            this.lblCurrentQueue.Font = new System.Drawing.Font("Fredoka", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQueue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCurrentQueue.Location = new System.Drawing.Point(126, 65);
            this.lblCurrentQueue.Name = "lblCurrentQueue";
            this.lblCurrentQueue.Size = new System.Drawing.Size(308, 34);
            this.lblCurrentQueue.TabIndex = 6;
            this.lblCurrentQueue.Text = "Currently Serving: None";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(567, 399);
            this.Controls.Add(this.lblCurrentQueue);
            this.Controls.Add(this.lblCustomersInQueue);
            this.Controls.Add(this.listBoxQueue);
            this.Controls.Add(this.lblAssignedTeller);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAssignedTeller;
        private System.Windows.Forms.ListBox listBoxQueue;
        private System.Windows.Forms.Label lblCustomersInQueue;
        private System.Windows.Forms.Label lblCurrentQueue;
    }
}
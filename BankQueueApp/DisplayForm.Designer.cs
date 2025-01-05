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
            this.lblCurrentQueue = new System.Windows.Forms.Label();
            this.lblAssignedTeller = new System.Windows.Forms.Label();
            this.listBoxQueue = new System.Windows.Forms.ListBox();
            this.lblCustomersInQueue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentQueue
            // 
            this.lblCurrentQueue.AutoSize = true;
            this.lblCurrentQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQueue.Location = new System.Drawing.Point(65, 72);
            this.lblCurrentQueue.Name = "lblCurrentQueue";
            this.lblCurrentQueue.Size = new System.Drawing.Size(174, 25);
            this.lblCurrentQueue.TabIndex = 0;
            this.lblCurrentQueue.Text = "Currently Serving: ";
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
            this.listBoxQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQueue.FormattingEnabled = true;
            this.listBoxQueue.ItemHeight = 25;
            this.listBoxQueue.Location = new System.Drawing.Point(70, 169);
            this.listBoxQueue.Name = "listBoxQueue";
            this.listBoxQueue.Size = new System.Drawing.Size(387, 179);
            this.listBoxQueue.TabIndex = 2;
            // 
            // lblCustomersInQueue
            // 
            this.lblCustomersInQueue.AutoSize = true;
            this.lblCustomersInQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersInQueue.Location = new System.Drawing.Point(65, 132);
            this.lblCustomersInQueue.Name = "lblCustomersInQueue";
            this.lblCustomersInQueue.Size = new System.Drawing.Size(89, 25);
            this.lblCustomersInQueue.TabIndex = 3;
            this.lblCustomersInQueue.Text = "Waiting: ";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 399);
            this.Controls.Add(this.lblCustomersInQueue);
            this.Controls.Add(this.listBoxQueue);
            this.Controls.Add(this.lblAssignedTeller);
            this.Controls.Add(this.lblCurrentQueue);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentQueue;
        private System.Windows.Forms.Label lblAssignedTeller;
        private System.Windows.Forms.ListBox listBoxQueue;
        private System.Windows.Forms.Label lblCustomersInQueue;
    }
}
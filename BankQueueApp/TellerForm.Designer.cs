namespace BankQueueApp
{
    partial class TellerForm
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
            this.btnCallNext = new System.Windows.Forms.Button();
            this.btnMarkAsServed = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.listBoxWaitingQueue = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCurrentQueue
            // 
            this.lblCurrentQueue.AutoSize = true;
            this.lblCurrentQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQueue.Location = new System.Drawing.Point(106, 84);
            this.lblCurrentQueue.Name = "lblCurrentQueue";
            this.lblCurrentQueue.Size = new System.Drawing.Size(174, 25);
            this.lblCurrentQueue.TabIndex = 0;
            this.lblCurrentQueue.Text = "Currently Serving: ";
            // 
            // btnCallNext
            // 
            this.btnCallNext.AutoSize = true;
            this.btnCallNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallNext.Location = new System.Drawing.Point(257, 168);
            this.btnCallNext.Name = "btnCallNext";
            this.btnCallNext.Size = new System.Drawing.Size(101, 35);
            this.btnCallNext.TabIndex = 1;
            this.btnCallNext.Text = "Call Next";
            this.btnCallNext.UseVisualStyleBackColor = true;
            this.btnCallNext.Click += new System.EventHandler(this.btnCallNext_Click);
            // 
            // btnMarkAsServed
            // 
            this.btnMarkAsServed.AutoSize = true;
            this.btnMarkAsServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAsServed.Location = new System.Drawing.Point(58, 168);
            this.btnMarkAsServed.Name = "btnMarkAsServed";
            this.btnMarkAsServed.Size = new System.Drawing.Size(160, 35);
            this.btnMarkAsServed.TabIndex = 2;
            this.btnMarkAsServed.Text = "Mark as Served";
            this.btnMarkAsServed.UseVisualStyleBackColor = true;
            this.btnMarkAsServed.Click += new System.EventHandler(this.btnMarkAsServed_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.AutoSize = true;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(396, 168);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(87, 35);
            this.btnSkip.TabIndex = 3;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // listBoxWaitingQueue
            // 
            this.listBoxWaitingQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWaitingQueue.FormattingEnabled = true;
            this.listBoxWaitingQueue.ItemHeight = 25;
            this.listBoxWaitingQueue.Location = new System.Drawing.Point(75, 238);
            this.listBoxWaitingQueue.Name = "listBoxWaitingQueue";
            this.listBoxWaitingQueue.Size = new System.Drawing.Size(408, 154);
            this.listBoxWaitingQueue.TabIndex = 4;
            // 
            // TellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 439);
            this.Controls.Add(this.listBoxWaitingQueue);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnMarkAsServed);
            this.Controls.Add(this.btnCallNext);
            this.Controls.Add(this.lblCurrentQueue);
            this.Name = "TellerForm";
            this.Text = "TellerForm";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.TellerForm_Load);
        }

        #endregion

        private System.Windows.Forms.Label lblCurrentQueue;
        private System.Windows.Forms.Button btnCallNext;
        private System.Windows.Forms.Button btnMarkAsServed;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.ListBox listBoxWaitingQueue;
    }
}
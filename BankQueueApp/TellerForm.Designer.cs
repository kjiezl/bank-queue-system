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
            this.lblCurrentQueue.Font = new System.Drawing.Font("Fredoka", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQueue.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblCurrentQueue.Location = new System.Drawing.Point(89, 60);
            this.lblCurrentQueue.Name = "lblCurrentQueue";
            this.lblCurrentQueue.Size = new System.Drawing.Size(273, 34);
            this.lblCurrentQueue.TabIndex = 0;
            this.lblCurrentQueue.Text = "No currently serving.";
            // 
            // btnCallNext
            // 
            this.btnCallNext.AutoSize = true;
            this.btnCallNext.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCallNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCallNext.FlatAppearance.BorderSize = 15;
            this.btnCallNext.Font = new System.Drawing.Font("Fredoka SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCallNext.Location = new System.Drawing.Point(257, 355);
            this.btnCallNext.Name = "btnCallNext";
            this.btnCallNext.Size = new System.Drawing.Size(105, 35);
            this.btnCallNext.TabIndex = 1;
            this.btnCallNext.Text = "Call Next";
            this.btnCallNext.UseVisualStyleBackColor = false;
            this.btnCallNext.Click += new System.EventHandler(this.btnCallNext_Click);
            // 
            // btnMarkAsServed
            // 
            this.btnMarkAsServed.AutoSize = true;
            this.btnMarkAsServed.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMarkAsServed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkAsServed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMarkAsServed.FlatAppearance.BorderSize = 15;
            this.btnMarkAsServed.Font = new System.Drawing.Font("Fredoka SemiBold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAsServed.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnMarkAsServed.Location = new System.Drawing.Point(52, 352);
            this.btnMarkAsServed.Name = "btnMarkAsServed";
            this.btnMarkAsServed.Size = new System.Drawing.Size(172, 38);
            this.btnMarkAsServed.TabIndex = 2;
            this.btnMarkAsServed.Text = "Mark as Served";
            this.btnMarkAsServed.UseVisualStyleBackColor = false;
            this.btnMarkAsServed.Click += new System.EventHandler(this.btnMarkAsServed_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.AutoSize = true;
            this.btnSkip.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.FlatAppearance.BorderSize = 15;
            this.btnSkip.Font = new System.Drawing.Font("Fredoka SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSkip.Location = new System.Drawing.Point(406, 355);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(87, 35);
            this.btnSkip.TabIndex = 3;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // listBoxWaitingQueue
            // 
            this.listBoxWaitingQueue.BackColor = System.Drawing.Color.Thistle;
            this.listBoxWaitingQueue.Font = new System.Drawing.Font("Fredoka", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWaitingQueue.ForeColor = System.Drawing.Color.DarkOrchid;
            this.listBoxWaitingQueue.FormattingEnabled = true;
            this.listBoxWaitingQueue.ItemHeight = 25;
            this.listBoxWaitingQueue.Location = new System.Drawing.Point(52, 141);
            this.listBoxWaitingQueue.Name = "listBoxWaitingQueue";
            this.listBoxWaitingQueue.Size = new System.Drawing.Size(441, 179);
            this.listBoxWaitingQueue.TabIndex = 4;
            // 
            // TellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(560, 439);
            this.Controls.Add(this.listBoxWaitingQueue);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnMarkAsServed);
            this.Controls.Add(this.btnCallNext);
            this.Controls.Add(this.lblCurrentQueue);
            this.Name = "TellerForm";
            this.Text = "TellerForm";
            this.Load += new System.EventHandler(this.TellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentQueue;
        private System.Windows.Forms.Button btnCallNext;
        private System.Windows.Forms.Button btnMarkAsServed;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.ListBox listBoxWaitingQueue;
    }
}
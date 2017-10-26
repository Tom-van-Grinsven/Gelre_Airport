namespace Gelre_airport
{
    partial class MainForm
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
            this.btnGetCheckInCounters = new System.Windows.Forms.Button();
            this.lbCheckInCounters = new System.Windows.Forms.ListBox();
            this.btnSelectCheckInCounter = new System.Windows.Forms.Button();
            this.pnlWindow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnGetCheckInCounters
            // 
            this.btnGetCheckInCounters.Location = new System.Drawing.Point(12, 12);
            this.btnGetCheckInCounters.Name = "btnGetCheckInCounters";
            this.btnGetCheckInCounters.Size = new System.Drawing.Size(240, 23);
            this.btnGetCheckInCounters.TabIndex = 0;
            this.btnGetCheckInCounters.Text = "Toon incheckbalies";
            this.btnGetCheckInCounters.UseVisualStyleBackColor = true;
            this.btnGetCheckInCounters.Click += new System.EventHandler(this.btnGetCheckInCounters_Click);
            // 
            // lbCheckInCounters
            // 
            this.lbCheckInCounters.FormattingEnabled = true;
            this.lbCheckInCounters.Location = new System.Drawing.Point(12, 42);
            this.lbCheckInCounters.Name = "lbCheckInCounters";
            this.lbCheckInCounters.Size = new System.Drawing.Size(240, 290);
            this.lbCheckInCounters.TabIndex = 1;
            // 
            // btnSelectCheckInCounter
            // 
            this.btnSelectCheckInCounter.Location = new System.Drawing.Point(12, 338);
            this.btnSelectCheckInCounter.Name = "btnSelectCheckInCounter";
            this.btnSelectCheckInCounter.Size = new System.Drawing.Size(240, 55);
            this.btnSelectCheckInCounter.TabIndex = 3;
            this.btnSelectCheckInCounter.Text = "Selecteer balie";
            this.btnSelectCheckInCounter.UseVisualStyleBackColor = true;
            this.btnSelectCheckInCounter.Click += new System.EventHandler(this.btnSelectCheckInCounter_Click);
            // 
            // pnlWindow
            // 
            this.pnlWindow.Location = new System.Drawing.Point(259, 12);
            this.pnlWindow.Name = "pnlWindow";
            this.pnlWindow.Size = new System.Drawing.Size(871, 381);
            this.pnlWindow.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 405);
            this.Controls.Add(this.pnlWindow);
            this.Controls.Add(this.btnSelectCheckInCounter);
            this.Controls.Add(this.lbCheckInCounters);
            this.Controls.Add(this.btnGetCheckInCounters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetCheckInCounters;
        private System.Windows.Forms.ListBox lbCheckInCounters;
        private System.Windows.Forms.Button btnSelectCheckInCounter;
        private System.Windows.Forms.Panel pnlWindow;
    }
}


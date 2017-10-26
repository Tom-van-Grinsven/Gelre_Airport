namespace Gelre_airport
{
    partial class CheckInForm
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
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.LblFlightNumber = new System.Windows.Forms.Label();
            this.LblDestination = new System.Windows.Forms.Label();
            this.LblAirline = new System.Windows.Forms.Label();
            this.LblDepartureDate = new System.Windows.Forms.Label();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtAirline = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(12, 29);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(216, 20);
            this.txtPassengerName.TabIndex = 0;
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Location = new System.Drawing.Point(13, 13);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(79, 13);
            this.lblPassengerName.TabIndex = 1;
            this.lblPassengerName.Text = "Passagiernaam";
            // 
            // LblFlightNumber
            // 
            this.LblFlightNumber.AutoSize = true;
            this.LblFlightNumber.Location = new System.Drawing.Point(13, 64);
            this.LblFlightNumber.Name = "LblFlightNumber";
            this.LblFlightNumber.Size = new System.Drawing.Size(74, 13);
            this.LblFlightNumber.TabIndex = 2;
            this.LblFlightNumber.Text = "Vluchtnummer";
            // 
            // LblDestination
            // 
            this.LblDestination.AutoSize = true;
            this.LblDestination.Location = new System.Drawing.Point(13, 113);
            this.LblDestination.Name = "LblDestination";
            this.LblDestination.Size = new System.Drawing.Size(64, 13);
            this.LblDestination.TabIndex = 3;
            this.LblDestination.Text = "Bestemming";
            // 
            // LblAirline
            // 
            this.LblAirline.AutoSize = true;
            this.LblAirline.Location = new System.Drawing.Point(13, 166);
            this.LblAirline.Name = "LblAirline";
            this.LblAirline.Size = new System.Drawing.Size(70, 13);
            this.LblAirline.TabIndex = 4;
            this.LblAirline.Text = "Maatschappij";
            // 
            // LblDepartureDate
            // 
            this.LblDepartureDate.AutoSize = true;
            this.LblDepartureDate.Location = new System.Drawing.Point(12, 218);
            this.LblDepartureDate.Name = "LblDepartureDate";
            this.LblDepartureDate.Size = new System.Drawing.Size(70, 13);
            this.LblDepartureDate.TabIndex = 5;
            this.LblDepartureDate.Text = "Vertrekdatum";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(12, 80);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(216, 20);
            this.txtFlightNumber.TabIndex = 6;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(12, 129);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(216, 20);
            this.txtDestination.TabIndex = 7;
            // 
            // txtAirline
            // 
            this.txtAirline.Location = new System.Drawing.Point(12, 182);
            this.txtAirline.Name = "txtAirline";
            this.txtAirline.Size = new System.Drawing.Size(216, 20);
            this.txtAirline.TabIndex = 8;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(11, 234);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(216, 20);
            this.txtDepartureDate.TabIndex = 9;
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 385);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtAirline);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.LblDepartureDate);
            this.Controls.Add(this.LblAirline);
            this.Controls.Add(this.LblDestination);
            this.Controls.Add(this.LblFlightNumber);
            this.Controls.Add(this.lblPassengerName);
            this.Controls.Add(this.txtPassengerName);
            this.Name = "CheckInForm";
            this.Text = "CheckInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.Label LblFlightNumber;
        private System.Windows.Forms.Label LblDestination;
        private System.Windows.Forms.Label LblAirline;
        private System.Windows.Forms.Label LblDepartureDate;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtAirline;
        private System.Windows.Forms.TextBox txtDepartureDate;
    }
}
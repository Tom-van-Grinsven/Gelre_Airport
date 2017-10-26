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
            this.btnFindPassenger = new System.Windows.Forms.Button();
            this.lbPassengers = new System.Windows.Forms.ListBox();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPassengerDetails = new System.Windows.Forms.ListBox();
            this.lbPassengerBaggage = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
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
            // btnFindPassenger
            // 
            this.btnFindPassenger.Location = new System.Drawing.Point(11, 312);
            this.btnFindPassenger.Name = "btnFindPassenger";
            this.btnFindPassenger.Size = new System.Drawing.Size(216, 61);
            this.btnFindPassenger.TabIndex = 10;
            this.btnFindPassenger.Text = "Vind passagier";
            this.btnFindPassenger.UseVisualStyleBackColor = true;
            this.btnFindPassenger.Click += new System.EventHandler(this.btnFindPassenger_Click);
            // 
            // lbPassengers
            // 
            this.lbPassengers.FormattingEnabled = true;
            this.lbPassengers.Location = new System.Drawing.Point(235, 29);
            this.lbPassengers.Name = "lbPassengers";
            this.lbPassengers.Size = new System.Drawing.Size(227, 342);
            this.lbPassengers.TabIndex = 11;
            this.lbPassengers.SelectedValueChanged += new System.EventHandler(this.lbPassengers_SelectedValueChanged);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Location = new System.Drawing.Point(10, 234);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(216, 20);
            this.dtpDeparture.TabIndex = 14;
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(77, 260);
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(149, 20);
            this.nudHour.TabIndex = 15;
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(77, 286);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(149, 20);
            this.nudMinute.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Uur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Minuut";
            // 
            // lbPassengerDetails
            // 
            this.lbPassengerDetails.FormattingEnabled = true;
            this.lbPassengerDetails.Location = new System.Drawing.Point(468, 29);
            this.lbPassengerDetails.Name = "lbPassengerDetails";
            this.lbPassengerDetails.Size = new System.Drawing.Size(227, 160);
            this.lbPassengerDetails.TabIndex = 19;
            // 
            // lbPassengerBaggage
            // 
            this.lbPassengerBaggage.FormattingEnabled = true;
            this.lbPassengerBaggage.Location = new System.Drawing.Point(468, 198);
            this.lbPassengerBaggage.Name = "lbPassengerBaggage";
            this.lbPassengerBaggage.Size = new System.Drawing.Size(227, 173);
            this.lbPassengerBaggage.TabIndex = 20;
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 386);
            this.Controls.Add(this.lbPassengerBaggage);
            this.Controls.Add(this.lbPassengerDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.lbPassengers);
            this.Controls.Add(this.btnFindPassenger);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
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
        private System.Windows.Forms.Button btnFindPassenger;
        private System.Windows.Forms.ListBox lbPassengers;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbPassengerDetails;
        private System.Windows.Forms.ListBox lbPassengerBaggage;
    }
}
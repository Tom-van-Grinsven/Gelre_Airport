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
            this.lbFlightDetails = new System.Windows.Forms.ListBox();
            this.lbPassengerBaggage = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteLuggage = new System.Windows.Forms.Button();
            this.txtBaggageFlightNumber = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddLuggage = new System.Windows.Forms.Button();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
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
            this.lbPassengers.Size = new System.Drawing.Size(366, 342);
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
            // lbFlightDetails
            // 
            this.lbFlightDetails.FormattingEnabled = true;
            this.lbFlightDetails.Location = new System.Drawing.Point(607, 29);
            this.lbFlightDetails.Name = "lbFlightDetails";
            this.lbFlightDetails.Size = new System.Drawing.Size(596, 173);
            this.lbFlightDetails.TabIndex = 19;
            // 
            // lbPassengerBaggage
            // 
            this.lbPassengerBaggage.FormattingEnabled = true;
            this.lbPassengerBaggage.Location = new System.Drawing.Point(607, 224);
            this.lbPassengerBaggage.Name = "lbPassengerBaggage";
            this.lbPassengerBaggage.Size = new System.Drawing.Size(227, 108);
            this.lbPassengerBaggage.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Stukken baggage";
            // 
            // btnDeleteLuggage
            // 
            this.btnDeleteLuggage.Location = new System.Drawing.Point(610, 348);
            this.btnDeleteLuggage.Name = "btnDeleteLuggage";
            this.btnDeleteLuggage.Size = new System.Drawing.Size(224, 23);
            this.btnDeleteLuggage.TabIndex = 22;
            this.btnDeleteLuggage.Text = "Verwijder stuk";
            this.btnDeleteLuggage.UseVisualStyleBackColor = true;
            this.btnDeleteLuggage.Click += new System.EventHandler(this.btnDeleteLuggage_Click);
            // 
            // txtBaggageFlightNumber
            // 
            this.txtBaggageFlightNumber.Location = new System.Drawing.Point(840, 250);
            this.txtBaggageFlightNumber.Name = "txtBaggageFlightNumber";
            this.txtBaggageFlightNumber.Size = new System.Drawing.Size(117, 20);
            this.txtBaggageFlightNumber.TabIndex = 23;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(840, 312);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(117, 20);
            this.txtWeight.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(841, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Vluchtnummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(841, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Gewicht";
            // 
            // btnAddLuggage
            // 
            this.btnAddLuggage.Location = new System.Drawing.Point(844, 348);
            this.btnAddLuggage.Name = "btnAddLuggage";
            this.btnAddLuggage.Size = new System.Drawing.Size(113, 23);
            this.btnAddLuggage.TabIndex = 27;
            this.btnAddLuggage.Text = "Voeg stuk toe";
            this.btnAddLuggage.UseVisualStyleBackColor = true;
            this.btnAddLuggage.Click += new System.EventHandler(this.btnAddLuggage_Click);
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Location = new System.Drawing.Point(1082, 249);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(121, 20);
            this.txtSeatNumber.TabIndex = 28;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(1082, 348);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(121, 23);
            this.btnCheckIn.TabIndex = 29;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(1082, 224);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 13);
            this.label.TabIndex = 30;
            this.label.Text = "Stoelnummer toewijzen:";
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 388);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.btnAddLuggage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtBaggageFlightNumber);
            this.Controls.Add(this.btnDeleteLuggage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPassengerBaggage);
            this.Controls.Add(this.lbFlightDetails);
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
        private System.Windows.Forms.ListBox lbFlightDetails;
        private System.Windows.Forms.ListBox lbPassengerBaggage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteLuggage;
        private System.Windows.Forms.TextBox txtBaggageFlightNumber;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddLuggage;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label label;
    }
}
namespace AirportApp.Forms
{
    partial class FlightForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            NumericUpDownFlightNumber = new NumericUpDown();
            ComboBox = new ComboBox();
            TimePicker = new DateTimePicker();
            NumericUpDownNumberPassengers = new NumericUpDown();
            NumericUpDownCrewNumber = new NumericUpDown();
            NumericUpDownCrewFee = new NumericUpDown();
            NumericUpDownPercentage = new NumericUpDown();
            NumericUpDownPassengerFee = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownFlightNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownNumberPassengers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCrewNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCrewFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPercentage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPassengerFee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 39);
            label1.Name = "label1";
            label1.Size = new Size(69, 50);
            label1.TabIndex = 0;
            label1.Text = "Номер\r\nрейса";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 102);
            label2.Name = "label2";
            label2.Size = new Size(87, 50);
            label2.TabIndex = 1;
            label2.Text = "Тип\r\nсамолета";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 165);
            label3.Name = "label3";
            label3.Size = new Size(92, 50);
            label3.TabIndex = 2;
            label3.Text = "Время\r\nприбытия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 237);
            label4.Name = "label4";
            label4.Size = new Size(111, 50);
            label4.TabIndex = 3;
            label4.Text = "Количество\r\nпассажиров";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 307);
            label5.Name = "label5";
            label5.Size = new Size(99, 50);
            label5.TabIndex = 4;
            label5.Text = "Сбор на\r\nпассажира";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 370);
            label6.Name = "label6";
            label6.Size = new Size(107, 50);
            label6.TabIndex = 5;
            label6.Text = "Количество\r\nэкипажа";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 435);
            label7.Name = "label7";
            label7.Size = new Size(79, 50);
            label7.TabIndex = 6;
            label7.Text = "Сбор на\r\nэкипаж";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 498);
            label8.Name = "label8";
            label8.Size = new Size(89, 50);
            label8.TabIndex = 7;
            label8.Text = "Процент\r\nнадбавки";
            // 
            // NumericUpDownFlightNumber
            // 
            NumericUpDownFlightNumber.Location = new Point(166, 39);
            NumericUpDownFlightNumber.Name = "NumericUpDownFlightNumber";
            NumericUpDownFlightNumber.Size = new Size(180, 31);
            NumericUpDownFlightNumber.TabIndex = 9;
            // 
            // ComboBox
            // 
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(166, 102);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(182, 33);
            ComboBox.TabIndex = 10;
            // 
            // TimePicker
            // 
            TimePicker.Format = DateTimePickerFormat.Time;
            TimePicker.Location = new Point(166, 184);
            TimePicker.Name = "TimePicker";
            TimePicker.Size = new Size(182, 31);
            TimePicker.TabIndex = 11;
            // 
            // NumericUpDownNumberPassengers
            // 
            NumericUpDownNumberPassengers.Location = new Point(166, 256);
            NumericUpDownNumberPassengers.Name = "NumericUpDownNumberPassengers";
            NumericUpDownNumberPassengers.Size = new Size(180, 31);
            NumericUpDownNumberPassengers.TabIndex = 12;
            // 
            // NumericUpDownCrewNumber
            // 
            NumericUpDownCrewNumber.Location = new Point(166, 384);
            NumericUpDownCrewNumber.Name = "NumericUpDownCrewNumber";
            NumericUpDownCrewNumber.Size = new Size(180, 31);
            NumericUpDownCrewNumber.TabIndex = 13;
            // 
            // NumericUpDownCrewFee
            // 
            NumericUpDownCrewFee.DecimalPlaces = 2;
            NumericUpDownCrewFee.Location = new Point(166, 442);
            NumericUpDownCrewFee.Name = "NumericUpDownCrewFee";
            NumericUpDownCrewFee.Size = new Size(180, 31);
            NumericUpDownCrewFee.TabIndex = 18;
            // 
            // NumericUpDownPercentage
            // 
            NumericUpDownPercentage.DecimalPlaces = 2;
            NumericUpDownPercentage.Location = new Point(166, 507);
            NumericUpDownPercentage.Name = "NumericUpDownPercentage";
            NumericUpDownPercentage.Size = new Size(180, 31);
            NumericUpDownPercentage.TabIndex = 19;
            // 
            // NumericUpDownPassengerFee
            // 
            NumericUpDownPassengerFee.DecimalPlaces = 2;
            NumericUpDownPassengerFee.Location = new Point(166, 317);
            NumericUpDownPassengerFee.Name = "NumericUpDownPassengerFee";
            NumericUpDownPassengerFee.Size = new Size(180, 31);
            NumericUpDownPassengerFee.TabIndex = 20;
            // 
            // FlightForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 576);
            Controls.Add(NumericUpDownPassengerFee);
            Controls.Add(NumericUpDownPercentage);
            Controls.Add(NumericUpDownCrewFee);
            Controls.Add(NumericUpDownCrewNumber);
            Controls.Add(NumericUpDownNumberPassengers);
            Controls.Add(TimePicker);
            Controls.Add(ComboBox);
            Controls.Add(NumericUpDownFlightNumber);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FlightForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Параметры рейса";
            Load += FlightForm_Load;
            ((System.ComponentModel.ISupportInitialize)NumericUpDownFlightNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownNumberPassengers).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCrewNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCrewFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPercentage).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPassengerFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown NumericUpDownFlightNumber;
        private ComboBox ComboBox;
        private DateTimePicker TimePicker;
        private NumericUpDown NumericUpDownNumberPassengers;
        private NumericUpDown NumericUpDownCrewNumber;
        private NumericUpDown NumericUpDownCrewFee;
        private NumericUpDown NumericUpDownPercentage;
        private NumericUpDown NumericUpDownPassengerFee;
    }
}
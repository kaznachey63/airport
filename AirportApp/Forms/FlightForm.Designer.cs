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
            components = new System.ComponentModel.Container();
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
            NumericUpDownNumberPassenger = new NumericUpDown();
            NumericUpDownCrewNumber = new NumericUpDown();
            NumericUpDownCrewFee = new NumericUpDown();
            NumericUpDownPercentage = new NumericUpDown();
            NumericUpDownPassengerFee = new NumericUpDown();
            SaveButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)NumericUpDownFlightNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownNumberPassenger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCrewNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCrewFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPercentage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPassengerFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(69, 50);
            label1.TabIndex = 0;
            label1.Text = "Номер\r\nрейса";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 102);
            label2.Name = "label2";
            label2.Size = new Size(87, 50);
            label2.TabIndex = 1;
            label2.Text = "Тип\r\nсамолета";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 165);
            label3.Name = "label3";
            label3.Size = new Size(92, 50);
            label3.TabIndex = 2;
            label3.Text = "Время\r\nприбытия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 237);
            label4.Name = "label4";
            label4.Size = new Size(111, 50);
            label4.TabIndex = 3;
            label4.Text = "Количество\r\nпассажиров";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 307);
            label5.Name = "label5";
            label5.Size = new Size(99, 50);
            label5.TabIndex = 4;
            label5.Text = "Сбор на\r\nпассажира";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 370);
            label6.Name = "label6";
            label6.Size = new Size(107, 50);
            label6.TabIndex = 5;
            label6.Text = "Количество\r\nэкипажа";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 435);
            label7.Name = "label7";
            label7.Size = new Size(79, 50);
            label7.TabIndex = 6;
            label7.Text = "Сбор на\r\nэкипаж";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 498);
            label8.Name = "label8";
            label8.Size = new Size(89, 50);
            label8.TabIndex = 7;
            label8.Text = "Процент\r\nнадбавки";
            // 
            // NumericUpDownFlightNumber
            // 
            NumericUpDownFlightNumber.Location = new Point(181, 39);
            NumericUpDownFlightNumber.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            NumericUpDownFlightNumber.Name = "NumericUpDownFlightNumber";
            NumericUpDownFlightNumber.Size = new Size(180, 31);
            NumericUpDownFlightNumber.TabIndex = 9;
            NumericUpDownFlightNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ComboBox
            // 
            ComboBox.DisplayMember = "-1";
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(181, 102);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(182, 33);
            ComboBox.TabIndex = 10;
            ComboBox.ValueMember = "-1";
            // 
            // TimePicker
            // 
            TimePicker.Format = DateTimePickerFormat.Time;
            TimePicker.Location = new Point(181, 184);
            TimePicker.Name = "TimePicker";
            TimePicker.Size = new Size(182, 31);
            TimePicker.TabIndex = 11;
            // 
            // NumericUpDownNumberPassenger
            // 
            NumericUpDownNumberPassenger.Location = new Point(181, 256);
            NumericUpDownNumberPassenger.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            NumericUpDownNumberPassenger.Name = "NumericUpDownNumberPassenger";
            NumericUpDownNumberPassenger.Size = new Size(180, 31);
            NumericUpDownNumberPassenger.TabIndex = 12;
            NumericUpDownNumberPassenger.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumericUpDownCrewNumber
            // 
            NumericUpDownCrewNumber.Location = new Point(181, 384);
            NumericUpDownCrewNumber.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            NumericUpDownCrewNumber.Name = "NumericUpDownCrewNumber";
            NumericUpDownCrewNumber.Size = new Size(180, 31);
            NumericUpDownCrewNumber.TabIndex = 13;
            NumericUpDownCrewNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumericUpDownCrewFee
            // 
            NumericUpDownCrewFee.DecimalPlaces = 2;
            NumericUpDownCrewFee.Location = new Point(181, 442);
            NumericUpDownCrewFee.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            NumericUpDownCrewFee.Name = "NumericUpDownCrewFee";
            NumericUpDownCrewFee.Size = new Size(180, 31);
            NumericUpDownCrewFee.TabIndex = 18;
            NumericUpDownCrewFee.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumericUpDownPercentage
            // 
            NumericUpDownPercentage.DecimalPlaces = 2;
            NumericUpDownPercentage.Location = new Point(181, 507);
            NumericUpDownPercentage.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            NumericUpDownPercentage.Name = "NumericUpDownPercentage";
            NumericUpDownPercentage.Size = new Size(180, 31);
            NumericUpDownPercentage.TabIndex = 19;
            NumericUpDownPercentage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumericUpDownPassengerFee
            // 
            NumericUpDownPassengerFee.DecimalPlaces = 2;
            NumericUpDownPassengerFee.Location = new Point(181, 317);
            NumericUpDownPassengerFee.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            NumericUpDownPassengerFee.Name = "NumericUpDownPassengerFee";
            NumericUpDownPassengerFee.Size = new Size(180, 31);
            NumericUpDownPassengerFee.TabIndex = 20;
            NumericUpDownPassengerFee.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(42, 565);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(321, 34);
            SaveButton.TabIndex = 21;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.BlinkRate = 1;
            errorProvider.ContainerControl = this;
            // 
            // FlightForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 624);
            Controls.Add(SaveButton);
            Controls.Add(NumericUpDownPassengerFee);
            Controls.Add(NumericUpDownPercentage);
            Controls.Add(NumericUpDownCrewFee);
            Controls.Add(NumericUpDownCrewNumber);
            Controls.Add(NumericUpDownNumberPassenger);
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
            MaximumSize = new Size(420, 680);
            MinimumSize = new Size(420, 680);
            Name = "FlightForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Параметры рейса";
            Load += FlightForm_Load;
            ((System.ComponentModel.ISupportInitialize)NumericUpDownFlightNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownNumberPassenger).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCrewNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCrewFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPercentage).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPassengerFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
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
        private NumericUpDown NumericUpDownNumberPassenger;
        private NumericUpDown NumericUpDownCrewNumber;
        private NumericUpDown NumericUpDownCrewFee;
        private NumericUpDown NumericUpDownPercentage;
        private NumericUpDown NumericUpDownPassengerFee;
        private Button SaveButton;
        private ErrorProvider errorProvider;
    }
}
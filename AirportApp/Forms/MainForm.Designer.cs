namespace AirportApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ToolStrip = new ToolStrip();
            AddButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            EditButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            DeleteButton = new ToolStripButton();
            StatusStrip = new StatusStrip();
            NumberOFFlights = new ToolStripStatusLabel();
            NumberOFPassengers = new ToolStripStatusLabel();
            CrewNumber = new ToolStripStatusLabel();
            TotalRevenue = new ToolStripStatusLabel();
            Table = new DataGridView();
            FlightNumberColumn = new DataGridViewTextBoxColumn();
            TypeOFAircraftColumn = new DataGridViewTextBoxColumn();
            ArrivalTimeColumn = new DataGridViewTextBoxColumn();
            NumberOFPassengersColumn = new DataGridViewTextBoxColumn();
            PassengerFeeColumn = new DataGridViewTextBoxColumn();
            CrewNumberColumn = new DataGridViewTextBoxColumn();
            CrewFeeColumn = new DataGridViewTextBoxColumn();
            ServicePercentageColumn = new DataGridViewTextBoxColumn();
            RevenueColumn = new DataGridViewTextBoxColumn();
            ToolStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Table).BeginInit();
            SuspendLayout();
            // 
            // ToolStrip
            // 
            ToolStrip.ImageScalingSize = new Size(24, 24);
            ToolStrip.Items.AddRange(new ToolStripItem[] { AddButton, toolStripSeparator1, EditButton, toolStripSeparator2, DeleteButton });
            ToolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            ToolStrip.Location = new Point(0, 0);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(800, 33);
            ToolStrip.TabIndex = 1;
            ToolStrip.Text = "toolStrip";
            // 
            // AddButton
            // 
            AddButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.ImageTransparentColor = Color.Magenta;
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(34, 28);
            AddButton.Text = "addButton";
            AddButton.ToolTipText = "Добавить";
            AddButton.Click += AddButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // EditButton
            // 
            EditButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            EditButton.Image = (Image)resources.GetObject("EditButton.Image");
            EditButton.ImageTransparentColor = Color.Magenta;
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(34, 28);
            EditButton.Text = "editButton";
            EditButton.ToolTipText = "Изменить";
            EditButton.Click += EditButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 33);
            // 
            // DeleteButton
            // 
            DeleteButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.ImageTransparentColor = Color.Magenta;
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(34, 28);
            DeleteButton.Text = "deleteButton";
            DeleteButton.ToolTipText = "Удалить";
            DeleteButton.Click += DeleteButton_Click;
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(24, 24);
            StatusStrip.Items.AddRange(new ToolStripItem[] { NumberOFFlights, NumberOFPassengers, CrewNumber, TotalRevenue });
            StatusStrip.Location = new Point(0, 418);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(800, 32);
            StatusStrip.TabIndex = 2;
            StatusStrip.Text = "statusStrip1";
            // 
            // NumberOFFlights
            // 
            NumberOFFlights.Name = "NumberOFFlights";
            NumberOFFlights.Size = new Size(176, 25);
            NumberOFFlights.Text = "Количество записей";
            // 
            // NumberOFPassengers
            // 
            NumberOFPassengers.Name = "NumberOFPassengers";
            NumberOFPassengers.Size = new Size(211, 25);
            NumberOFPassengers.Text = "Количество пассажиров";
            // 
            // CrewNumber
            // 
            CrewNumber.Name = "CrewNumber";
            CrewNumber.Size = new Size(180, 25);
            CrewNumber.Text = "Количество экипажа";
            // 
            // TotalRevenue
            // 
            TotalRevenue.Name = "TotalRevenue";
            TotalRevenue.Size = new Size(184, 25);
            TotalRevenue.Text = "Количество выручки";
            // 
            // Table
            // 
            Table.AllowUserToAddRows = false;
            Table.AllowUserToDeleteRows = false;
            Table.AllowUserToResizeColumns = false;
            Table.AllowUserToResizeRows = false;
            Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table.Columns.AddRange(new DataGridViewColumn[] { FlightNumberColumn, TypeOFAircraftColumn, ArrivalTimeColumn, NumberOFPassengersColumn, PassengerFeeColumn, CrewNumberColumn, CrewFeeColumn, ServicePercentageColumn, RevenueColumn });
            Table.Cursor = Cursors.Hand;
            Table.Dock = DockStyle.Fill;
            Table.Location = new Point(0, 33);
            Table.Name = "Table";
            Table.ReadOnly = true;
            Table.RowHeadersVisible = false;
            Table.RowHeadersWidth = 62;
            Table.ShowEditingIcon = false;
            Table.Size = new Size(800, 385);
            Table.TabIndex = 3;
            // 
            // FlightNumberColumn
            // 
            FlightNumberColumn.HeaderText = "Номер рейса";
            FlightNumberColumn.MinimumWidth = 8;
            FlightNumberColumn.Name = "FlightNumberColumn";
            FlightNumberColumn.ReadOnly = true;
            // 
            // TypeOFAircraftColumn
            // 
            TypeOFAircraftColumn.HeaderText = "Тип самолета";
            TypeOFAircraftColumn.MinimumWidth = 8;
            TypeOFAircraftColumn.Name = "TypeOFAircraftColumn";
            TypeOFAircraftColumn.ReadOnly = true;
            // 
            // ArrivalTimeColumn
            // 
            ArrivalTimeColumn.HeaderText = "Время прибытия";
            ArrivalTimeColumn.MinimumWidth = 8;
            ArrivalTimeColumn.Name = "ArrivalTimeColumn";
            ArrivalTimeColumn.ReadOnly = true;
            // 
            // NumberOFPassengersColumn
            // 
            NumberOFPassengersColumn.HeaderText = "Количество пассажиров";
            NumberOFPassengersColumn.MinimumWidth = 8;
            NumberOFPassengersColumn.Name = "NumberOFPassengersColumn";
            NumberOFPassengersColumn.ReadOnly = true;
            // 
            // PassengerFeeColumn
            // 
            PassengerFeeColumn.HeaderText = "Сбор на пассажира";
            PassengerFeeColumn.MinimumWidth = 8;
            PassengerFeeColumn.Name = "PassengerFeeColumn";
            PassengerFeeColumn.ReadOnly = true;
            // 
            // CrewNumberColumn
            // 
            CrewNumberColumn.HeaderText = "Количество экипажа";
            CrewNumberColumn.MinimumWidth = 8;
            CrewNumberColumn.Name = "CrewNumberColumn";
            CrewNumberColumn.ReadOnly = true;
            // 
            // CrewFeeColumn
            // 
            CrewFeeColumn.HeaderText = "Сбор на экипаж";
            CrewFeeColumn.MinimumWidth = 8;
            CrewFeeColumn.Name = "CrewFeeColumn";
            CrewFeeColumn.ReadOnly = true;
            // 
            // ServicePercentageColumn
            // 
            ServicePercentageColumn.HeaderText = "Процент надбавки";
            ServicePercentageColumn.MinimumWidth = 8;
            ServicePercentageColumn.Name = "ServicePercentageColumn";
            ServicePercentageColumn.ReadOnly = true;
            // 
            // RevenueColumn
            // 
            RevenueColumn.HeaderText = "Вырчука";
            RevenueColumn.MinimumWidth = 8;
            RevenueColumn.Name = "RevenueColumn";
            RevenueColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Table);
            Controls.Add(StatusStrip);
            Controls.Add(ToolStrip);
            Name = "MainForm";
            Text = "Аэропорт";
            Load += MainForm_Load;
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip ToolStrip;
        private ToolStripButton AddButton;
        private ToolStripButton EditButton;
        private ToolStripButton DeleteButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel NumberOFFlights;
        private ToolStripStatusLabel NumberOFPassengers;
        private ToolStripStatusLabel CrewNumber;
        private ToolStripStatusLabel TotalRevenue;
        private DataGridView Table;
        private DataGridViewTextBoxColumn FlightNumberColumn;
        private DataGridViewTextBoxColumn TypeOFAircraftColumn;
        private DataGridViewTextBoxColumn ArrivalTimeColumn;
        private DataGridViewTextBoxColumn NumberOFPassengersColumn;
        private DataGridViewTextBoxColumn PassengerFeeColumn;
        private DataGridViewTextBoxColumn CrewNumberColumn;
        private DataGridViewTextBoxColumn CrewFeeColumn;
        private DataGridViewTextBoxColumn ServicePercentageColumn;
        private DataGridViewTextBoxColumn RevenueColumn;
    }
}
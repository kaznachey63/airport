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
            DataGrid = new DataGridView();
            ToolStrip = new ToolStrip();
            AddButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            EditButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            DeleteButton = new ToolStripButton();
            StatusStrip = new StatusStrip();
            AmountRecords = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ToolStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToResizeColumns = false;
            DataGrid.AllowUserToResizeRows = false;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Cursor = Cursors.Hand;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.Location = new Point(0, 0);
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowHeadersWidth = 62;
            DataGrid.ShowEditingIcon = false;
            DataGrid.Size = new Size(800, 450);
            DataGrid.TabIndex = 0;
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
            StatusStrip.Items.AddRange(new ToolStripItem[] { AmountRecords });
            StatusStrip.Location = new Point(0, 418);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(800, 32);
            StatusStrip.TabIndex = 2;
            StatusStrip.Text = "statusStrip1";
            // 
            // AmountRecords
            // 
            AmountRecords.Name = "AmountRecords";
            AmountRecords.Size = new Size(180, 25);
            AmountRecords.Text = "Количество записей:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StatusStrip);
            Controls.Add(ToolStrip);
            Controls.Add(DataGrid);
            Name = "MainForm";
            Text = "Аэропорт";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGrid;
        private ToolStrip ToolStrip;
        private ToolStripButton AddButton;
        private ToolStripButton EditButton;
        private ToolStripButton DeleteButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel AmountRecords;
    }
}
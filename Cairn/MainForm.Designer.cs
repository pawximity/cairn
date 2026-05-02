namespace cairn
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            browseButton = new Button();
            filePathTextbox = new TextBox();
            menuStrip1 = new MenuStrip();
            dataGridView = new DataGridView();
            formatLabel = new Label();
            entryPointLabel = new Label();
            entryPointValueLabel = new Label();
            formatValueLabel = new Label();
            machineLabel = new Label();
            machineValueLabel = new Label();
            memoryFootprintLabel = new Label();
            memoryFootprintValueLabel = new Label();
            fileSizeLabel = new Label();
            fileSizeValueLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 377);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(559, 29);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 1;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += BrowseButton_Click;
            // 
            // filePathTextbox
            // 
            filePathTextbox.Location = new Point(162, 29);
            filePathTextbox.Name = "filePathTextbox";
            filePathTextbox.Size = new Size(391, 23);
            filePathTextbox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(33, 155);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(726, 283);
            dataGridView.TabIndex = 4;
            // 
            // formatLabel
            // 
            formatLabel.AutoSize = true;
            formatLabel.Location = new Point(39, 73);
            formatLabel.Name = "formatLabel";
            formatLabel.Size = new Size(48, 15);
            formatLabel.TabIndex = 5;
            formatLabel.Text = "Format:";
            // 
            // entryPointLabel
            // 
            entryPointLabel.AutoSize = true;
            entryPointLabel.Location = new Point(39, 103);
            entryPointLabel.Name = "entryPointLabel";
            entryPointLabel.Size = new Size(113, 15);
            entryPointLabel.TabIndex = 6;
            entryPointLabel.Text = "Entry Point Address:";
            // 
            // entryPointValueLabel
            // 
            entryPointValueLabel.AutoSize = true;
            entryPointValueLabel.Location = new Point(149, 103);
            entryPointValueLabel.Name = "entryPointValueLabel";
            entryPointValueLabel.Size = new Size(12, 15);
            entryPointValueLabel.TabIndex = 7;
            entryPointValueLabel.Text = "-";
            // 
            // formatValueLabel
            // 
            formatValueLabel.AutoSize = true;
            formatValueLabel.Location = new Point(83, 73);
            formatValueLabel.Name = "formatValueLabel";
            formatValueLabel.Size = new Size(12, 15);
            formatValueLabel.TabIndex = 8;
            formatValueLabel.Text = "-";
            // 
            // machineLabel
            // 
            machineLabel.AutoSize = true;
            machineLabel.Location = new Point(39, 88);
            machineLabel.Name = "machineLabel";
            machineLabel.Size = new Size(56, 15);
            machineLabel.TabIndex = 9;
            machineLabel.Text = "Machine:";
            // 
            // machineValueLabel
            // 
            machineValueLabel.AutoSize = true;
            machineValueLabel.Location = new Point(93, 88);
            machineValueLabel.Name = "machineValueLabel";
            machineValueLabel.Size = new Size(12, 15);
            machineValueLabel.TabIndex = 10;
            machineValueLabel.Text = "-";
            // 
            // memoryFootprintLabel
            // 
            memoryFootprintLabel.AutoSize = true;
            memoryFootprintLabel.Location = new Point(39, 118);
            memoryFootprintLabel.Name = "memoryFootprintLabel";
            memoryFootprintLabel.Size = new Size(110, 15);
            memoryFootprintLabel.TabIndex = 11;
            memoryFootprintLabel.Text = "Memory Footprint: ";
            // 
            // memoryFootprintValueLabel
            // 
            memoryFootprintValueLabel.AutoSize = true;
            memoryFootprintValueLabel.Location = new Point(149, 118);
            memoryFootprintValueLabel.Name = "memoryFootprintValueLabel";
            memoryFootprintValueLabel.Size = new Size(12, 15);
            memoryFootprintValueLabel.TabIndex = 12;
            memoryFootprintValueLabel.Text = "-";
            // 
            // fileSizeLabel
            // 
            fileSizeLabel.AutoSize = true;
            fileSizeLabel.Location = new Point(39, 133);
            fileSizeLabel.Name = "fileSizeLabel";
            fileSizeLabel.Size = new Size(51, 15);
            fileSizeLabel.TabIndex = 13;
            fileSizeLabel.Text = "File Size:";
            // 
            // fileSizeValueLabel
            // 
            fileSizeValueLabel.AutoSize = true;
            fileSizeValueLabel.Location = new Point(93, 133);
            fileSizeValueLabel.Name = "fileSizeValueLabel";
            fileSizeValueLabel.Size = new Size(12, 15);
            fileSizeValueLabel.TabIndex = 14;
            fileSizeValueLabel.Text = "-";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(fileSizeValueLabel);
            Controls.Add(fileSizeLabel);
            Controls.Add(memoryFootprintValueLabel);
            Controls.Add(memoryFootprintLabel);
            Controls.Add(machineValueLabel);
            Controls.Add(machineLabel);
            Controls.Add(formatValueLabel);
            Controls.Add(entryPointValueLabel);
            Controls.Add(entryPointLabel);
            Controls.Add(formatLabel);
            Controls.Add(dataGridView);
            Controls.Add(filePathTextbox);
            Controls.Add(browseButton);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "cairn";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button browseButton;
        private TextBox filePathTextbox;
        private MenuStrip menuStrip1;
        private DataGridView dataGridView;
        private Label formatLabel;
        private Label entryPointLabel;
        private Label entryPointValueLabel;
        private Label formatValueLabel;
        private Label machineLabel;
        private Label machineValueLabel;
        private Label memoryFootprintLabel;
        private Label memoryFootprintValueLabel;
        private Label fileSizeLabel;
        private Label fileSizeValueLabel;
    }
}

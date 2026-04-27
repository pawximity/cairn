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
            peDataGridView = new DataGridView();
            architectureLabel = new Label();
            entryPointLabel = new Label();
            entryPointValueLabel = new Label();
            architectureValueLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)peDataGridView).BeginInit();
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
            // peDataGridView
            // 
            peDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            peDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            peDataGridView.Location = new Point(33, 105);
            peDataGridView.Name = "peDataGridView";
            peDataGridView.Size = new Size(726, 333);
            peDataGridView.TabIndex = 4;
            // 
            // architectureLabel
            // 
            architectureLabel.AutoSize = true;
            architectureLabel.Location = new Point(39, 73);
            architectureLabel.Name = "architectureLabel";
            architectureLabel.Size = new Size(75, 15);
            architectureLabel.TabIndex = 5;
            architectureLabel.Text = "Architecture:";
            // 
            // entryPointLabel
            // 
            entryPointLabel.AutoSize = true;
            entryPointLabel.Location = new Point(162, 73);
            entryPointLabel.Name = "entryPointLabel";
            entryPointLabel.Size = new Size(113, 15);
            entryPointLabel.TabIndex = 6;
            entryPointLabel.Text = "Entry Point Address:";
            // 
            // entryPointValueLabel
            // 
            entryPointValueLabel.AutoSize = true;
            entryPointValueLabel.Location = new Point(272, 73);
            entryPointValueLabel.Name = "entryPointValueLabel";
            entryPointValueLabel.Size = new Size(12, 15);
            entryPointValueLabel.TabIndex = 7;
            entryPointValueLabel.Text = "-";
            // 
            // architectureValueLabel
            // 
            architectureValueLabel.AutoSize = true;
            architectureValueLabel.Location = new Point(111, 73);
            architectureValueLabel.Name = "architectureValueLabel";
            architectureValueLabel.Size = new Size(12, 15);
            architectureValueLabel.TabIndex = 8;
            architectureValueLabel.Text = "-";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(architectureValueLabel);
            Controls.Add(entryPointValueLabel);
            Controls.Add(entryPointLabel);
            Controls.Add(architectureLabel);
            Controls.Add(peDataGridView);
            Controls.Add(filePathTextbox);
            Controls.Add(browseButton);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "cairn";
            ((System.ComponentModel.ISupportInitialize)peDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button browseButton;
        private TextBox filePathTextbox;
        private MenuStrip menuStrip1;
        private DataGridView peDataGridView;
        private Label architectureLabel;
        private Label entryPointLabel;
        private Label entryPointValueLabel;
        private Label architectureValueLabel;
    }
}

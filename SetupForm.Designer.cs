namespace Triage {
    partial class SetupForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            SourceGroup = new System.Windows.Forms.GroupBox();
            SourceBrowseButton = new System.Windows.Forms.Button();
            SourceTextBox = new System.Windows.Forms.TextBox();
            DestinationGroup = new System.Windows.Forms.GroupBox();
            DestinationBrowseButton = new System.Windows.Forms.Button();
            DestinationTextBox = new System.Windows.Forms.TextBox();
            SourceFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            DestinationFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            StartFileCheckbox = new System.Windows.Forms.CheckBox();
            StartFileTextBox = new System.Windows.Forms.TextBox();
            StartFileBrowseButton = new System.Windows.Forms.Button();
            TriageButton = new System.Windows.Forms.Button();
            StartFileDialog = new System.Windows.Forms.OpenFileDialog();
            FilterCheckbox = new System.Windows.Forms.CheckBox();
            FilterTextBox = new System.Windows.Forms.TextBox();
            SourceGroup.SuspendLayout();
            DestinationGroup.SuspendLayout();
            SuspendLayout();
            // 
            // SourceGroup
            // 
            SourceGroup.Controls.Add(SourceBrowseButton);
            SourceGroup.Controls.Add(SourceTextBox);
            SourceGroup.Location = new System.Drawing.Point(12, 12);
            SourceGroup.Name = "SourceGroup";
            SourceGroup.Size = new System.Drawing.Size(310, 60);
            SourceGroup.TabIndex = 0;
            SourceGroup.TabStop = false;
            SourceGroup.Text = "Source";
            // 
            // SourceBrowseButton
            // 
            SourceBrowseButton.Location = new System.Drawing.Point(269, 22);
            SourceBrowseButton.Name = "SourceBrowseButton";
            SourceBrowseButton.Size = new System.Drawing.Size(35, 23);
            SourceBrowseButton.TabIndex = 1;
            SourceBrowseButton.Text = "...";
            SourceBrowseButton.UseVisualStyleBackColor = true;
            SourceBrowseButton.Click += SourceBrowseButton_Click;
            // 
            // SourceTextBox
            // 
            SourceTextBox.Location = new System.Drawing.Point(6, 22);
            SourceTextBox.Name = "SourceTextBox";
            SourceTextBox.Size = new System.Drawing.Size(257, 23);
            SourceTextBox.TabIndex = 0;
            SourceTextBox.TextChanged += SourceTextBox_TextChanged;
            // 
            // DestinationGroup
            // 
            DestinationGroup.Controls.Add(DestinationBrowseButton);
            DestinationGroup.Controls.Add(DestinationTextBox);
            DestinationGroup.Location = new System.Drawing.Point(12, 78);
            DestinationGroup.Name = "DestinationGroup";
            DestinationGroup.Size = new System.Drawing.Size(310, 60);
            DestinationGroup.TabIndex = 1;
            DestinationGroup.TabStop = false;
            DestinationGroup.Text = "Destination";
            // 
            // DestinationBrowseButton
            // 
            DestinationBrowseButton.Location = new System.Drawing.Point(269, 22);
            DestinationBrowseButton.Name = "DestinationBrowseButton";
            DestinationBrowseButton.Size = new System.Drawing.Size(35, 23);
            DestinationBrowseButton.TabIndex = 1;
            DestinationBrowseButton.Text = "...";
            DestinationBrowseButton.UseVisualStyleBackColor = true;
            DestinationBrowseButton.Click += DestinationBrowseButton_Click;
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.Location = new System.Drawing.Point(6, 22);
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.Size = new System.Drawing.Size(257, 23);
            DestinationTextBox.TabIndex = 0;
            // 
            // StartFileCheckbox
            // 
            StartFileCheckbox.AutoSize = true;
            StartFileCheckbox.Location = new System.Drawing.Point(12, 149);
            StartFileCheckbox.Name = "StartFileCheckbox";
            StartFileCheckbox.Size = new System.Drawing.Size(120, 19);
            StartFileCheckbox.TabIndex = 2;
            StartFileCheckbox.Text = "Start with this file:";
            StartFileCheckbox.UseVisualStyleBackColor = true;
            StartFileCheckbox.CheckedChanged += StartFileCheckbox_CheckedChanged;
            // 
            // StartFileTextBox
            // 
            StartFileTextBox.Enabled = false;
            StartFileTextBox.Location = new System.Drawing.Point(138, 145);
            StartFileTextBox.Name = "StartFileTextBox";
            StartFileTextBox.Size = new System.Drawing.Size(137, 23);
            StartFileTextBox.TabIndex = 3;
            // 
            // StartFileBrowseButton
            // 
            StartFileBrowseButton.Enabled = false;
            StartFileBrowseButton.Location = new System.Drawing.Point(281, 144);
            StartFileBrowseButton.Name = "StartFileBrowseButton";
            StartFileBrowseButton.Size = new System.Drawing.Size(35, 23);
            StartFileBrowseButton.TabIndex = 4;
            StartFileBrowseButton.Text = "...";
            StartFileBrowseButton.UseVisualStyleBackColor = true;
            StartFileBrowseButton.Click += StartFileBrowseButton_Click;
            // 
            // TriageButton
            // 
            TriageButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            TriageButton.Location = new System.Drawing.Point(12, 201);
            TriageButton.Name = "TriageButton";
            TriageButton.Size = new System.Drawing.Size(310, 43);
            TriageButton.TabIndex = 5;
            TriageButton.Text = "Triage";
            TriageButton.UseVisualStyleBackColor = true;
            TriageButton.Click += TriageButton_Click;
            // 
            // FilterCheckbox
            // 
            FilterCheckbox.AutoSize = true;
            FilterCheckbox.Location = new System.Drawing.Point(12, 174);
            FilterCheckbox.Name = "FilterCheckbox";
            FilterCheckbox.Size = new System.Drawing.Size(116, 19);
            FilterCheckbox.TabIndex = 6;
            FilterCheckbox.Text = "Use this file filter:";
            FilterCheckbox.UseVisualStyleBackColor = true;
            FilterCheckbox.CheckedChanged += FilterCheckbox_CheckedChanged;
            // 
            // FilterTextBox
            // 
            FilterTextBox.Enabled = false;
            FilterTextBox.Location = new System.Drawing.Point(138, 172);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.Size = new System.Drawing.Size(184, 23);
            FilterTextBox.TabIndex = 7;
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(334, 254);
            Controls.Add(FilterTextBox);
            Controls.Add(FilterCheckbox);
            Controls.Add(TriageButton);
            Controls.Add(StartFileBrowseButton);
            Controls.Add(StartFileTextBox);
            Controls.Add(StartFileCheckbox);
            Controls.Add(DestinationGroup);
            Controls.Add(SourceGroup);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SetupForm";
            Text = "Triage";
            SourceGroup.ResumeLayout(false);
            SourceGroup.PerformLayout();
            DestinationGroup.ResumeLayout(false);
            DestinationGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox SourceGroup;
        private System.Windows.Forms.Button SourceBrowseButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.GroupBox DestinationGroup;
        private System.Windows.Forms.Button DestinationBrowseButton;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.FolderBrowserDialog SourceFolderBrowser;
        private System.Windows.Forms.FolderBrowserDialog DestinationFolderBrowser;
        private System.Windows.Forms.CheckBox StartFileCheckbox;
        private System.Windows.Forms.TextBox StartFileTextBox;
        private System.Windows.Forms.Button StartFileBrowseButton;
        private System.Windows.Forms.Button TriageButton;
        private System.Windows.Forms.OpenFileDialog StartFileDialog;
        private System.Windows.Forms.CheckBox FilterCheckbox;
        private System.Windows.Forms.TextBox FilterTextBox;
    }
}
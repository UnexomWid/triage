namespace Triage
{
    partial class TriageForm
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
        private void InitializeComponent() {
            FilenameLabel = new System.Windows.Forms.Label();
            PreviousButton = new System.Windows.Forms.Button();
            NextButton = new System.Windows.Forms.Button();
            VerdictButton = new System.Windows.Forms.Button();
            WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WebView).BeginInit();
            SuspendLayout();
            // 
            // FilenameLabel
            // 
            FilenameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            FilenameLabel.AutoSize = true;
            FilenameLabel.Location = new System.Drawing.Point(264, 431);
            FilenameLabel.Name = "FilenameLabel";
            FilenameLabel.Size = new System.Drawing.Size(47, 15);
            FilenameLabel.TabIndex = 0;
            FilenameLabel.Text = "<path>";
            // 
            // PreviousButton
            // 
            PreviousButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            PreviousButton.Location = new System.Drawing.Point(12, 468);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new System.Drawing.Size(75, 23);
            PreviousButton.TabIndex = 2;
            PreviousButton.Text = "< Previous";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            NextButton.Location = new System.Drawing.Point(476, 468);
            NextButton.Name = "NextButton";
            NextButton.Size = new System.Drawing.Size(75, 23);
            NextButton.TabIndex = 3;
            NextButton.Text = "Next >";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // VerdictButton
            // 
            VerdictButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            VerdictButton.Location = new System.Drawing.Point(252, 468);
            VerdictButton.Name = "VerdictButton";
            VerdictButton.Size = new System.Drawing.Size(75, 23);
            VerdictButton.TabIndex = 4;
            VerdictButton.Text = "^ Accept ^";
            VerdictButton.UseVisualStyleBackColor = true;
            // 
            // WebView
            // 
            WebView.AllowExternalDrop = true;
            WebView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            WebView.CreationProperties = null;
            WebView.DefaultBackgroundColor = System.Drawing.Color.White;
            WebView.Location = new System.Drawing.Point(0, 0);
            WebView.Name = "WebView";
            WebView.Size = new System.Drawing.Size(563, 428);
            WebView.TabIndex = 5;
            WebView.ZoomFactor = 1D;
            // 
            // TriageForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(563, 503);
            Controls.Add(WebView);
            Controls.Add(VerdictButton);
            Controls.Add(NextButton);
            Controls.Add(PreviousButton);
            Controls.Add(FilenameLabel);
            Name = "TriageForm";
            Text = "Triage";
            FormClosed += TriageForm_FormClosed;
            SizeChanged += TriageForm_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)WebView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        new private System.Windows.Forms.Button VerdictButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
    }
}

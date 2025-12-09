using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Triage {
    public partial class TriageForm : Form {
        Action<string> onClose;

        IEnumerator<string> files;
        List<string> cache;

        int index;

        string dest;

        Color filenameDefaultColor;

        public TriageForm(Action<string> onClose, string src, string dest, string filter, string startFile) {
            InitializeComponent();
            filenameDefaultColor = FilenameLabel.ForeColor;

            this.onClose = onClose;
            this.dest = dest;

            files = Directory.EnumerateFiles(src, filter).GetEnumerator();

            cache = new List<string>();

            if (!files.MoveNext()) {
                throw new FileNotFoundException();
            }

            cache.Add(files.Current);

            index = 0;

            startFile = startFile.Trim().ToLower();

            if (startFile.Length > 0) {
                // Windows-specific: paths are case-insensitive
                while (Path.GetFileName(cache[index]).ToLower() != startFile) {
                    if (!files.MoveNext()) {
                        throw new FileLoadException();
                    }

                    cache.Add(files.Current);
                    ++index;
                }
            }

            Display();
        }

        void Display() {
            LoadFile(cache[index]);
            Text = $"Triage - {index + 1}";
        }

        void Next() {
            NextButton.Focus();

            if (index == cache.Count - 1) {
                if (!files.MoveNext()) {
                    return;
                }

                cache.Add(files.Current);
            }

            ++index;

            Display();
        }

        void Prev() {
            PreviousButton.Focus();

            if (index == 0) {
                return;
            }

            --index;

            Display();
        }

        void Accept() {
            VerdictButton.Focus();

            var target = GetTargetFile(cache[index]);

            if (File.Exists(target)) {
                return;
            }

            File.Copy(cache[index], target);

            UpdateControls();
            Next();
        }

        void Reject() {
            VerdictButton.Focus();

            var target = GetTargetFile(cache[index]);

            if (!File.Exists(target)) {
                return;
            }

            File.Delete(target);

            UpdateControls();
            Next();
        }

        void LoadFile(string path) {
            FilenameLabel.Text = Path.GetFileName(path);
            RepositionFilenameLabel();
            UpdateControls();

            WebView.Source = new Uri(path);
        }

        void UpdateControls() {
            if (File.Exists(GetTargetFile(cache[index]))) {
                FilenameLabel.ForeColor = Color.Green;
                VerdictButton.Text = "v Reject v";
            } else {
                FilenameLabel.ForeColor = filenameDefaultColor;
                VerdictButton.Text = "^ Accept ^";
            }

            FilenameLabel.Refresh();
            VerdictButton.Refresh();
        }

        string GetTargetFile(string path) {
            return Path.Join(dest, Path.GetFileName(path));
        }

        void RepositionFilenameLabel() {
            FilenameLabel.Left = (ClientSize.Width - FilenameLabel.Width) / 2;
            FilenameLabel.MaximumSize = new Size(ClientSize.Width, FilenameLabel.MaximumSize.Height);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            switch (keyData) {
                case Keys.Left: {
                    Prev();
                    return true;
                }
                case Keys.Right: {
                    Next();
                    return true;
                }
                case Keys.Up: {
                    Accept();
                    return true;
                }
                case Keys.Down: {
                    Reject();
                    return true;
                }
                case Keys.Escape: {
                    Close();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        void TriageForm_SizeChanged(object sender, System.EventArgs e) {
            RepositionFilenameLabel();
        }

        private void TriageForm_FormClosed(object sender, FormClosedEventArgs e) {
            files.Dispose();
            onClose(cache[index]);
        }

        private void PreviousButton_Click(object sender, System.EventArgs e) {
            Prev();
        }

        private void NextButton_Click(object sender, System.EventArgs e) {
            Next();
        }

        private void VerdictButton_Click(object sender, EventArgs e) {
            // Horrible, but no one will directly click on the button anyways
            if (VerdictButton.Text.Contains("Accept")) {
                Accept();
            } else {
                Reject();
            }
        }
    }
}

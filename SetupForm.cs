using System;
using System.IO;
using System.Windows.Forms;

namespace Triage {
    public partial class SetupForm : Form {
        public SetupForm() {
            InitializeComponent();
        }

        public void OnShowAgain() {
            TriageButton.Enabled = true;
            TriageButton.Text = "Triage";
            TriageButton.Refresh();
        }

        private void TriageButton_Click(object sender, EventArgs e) {
            var src = SourceTextBox.Text;
            var dest = DestinationTextBox.Text;

            var hasStartFile = StartFileCheckbox.Checked;
            var startFile = Path.GetFileName(StartFileTextBox.Text);

            var hasFilter = FilterCheckbox.Checked;
            var filter = FilterTextBox.Text;

            if (!Directory.Exists(src)) {
                Error("Source directory doesn't exist.");
                return;
            }

            if (!Directory.Exists(dest)) {
                Error("Destination directory doesn't exist.");
                return;
            }

            if (Path.GetFullPath(src) == Path.GetFullPath(dest)) {
                Error("Source and destination can't be the same.");
                return;
            }

            var startFileAbs = Path.Join(src, startFile);

            if (hasStartFile && !File.Exists(startFileAbs)) {
                Error($"Start file doesn't exist:\n\n{startFileAbs}");
            }

            TriageButton.Enabled = false;
            TriageButton.Text = "Parsing...";
            TriageButton.Refresh();

            Action<string> onClose = (lastFile) => {
                Show();
                OnShowAgain();

                StartFileCheckbox.Checked = true;
                StartFileTextBox.Text = Path.GetFileName(lastFile);

                StartFileCheckbox.Refresh();
            };

            try {
                var triage = new TriageForm(onClose, src, dest, hasFilter ? filter : "", hasStartFile ? startFile : "");
                triage.Show();
                Hide();
            } catch (ArgumentException) {
                Error("Invalid file filter.\n\nFilter supports wildcards (* and ?) but not regexes.");
                OnShowAgain();
            } catch (DirectoryNotFoundException) {
                Error("Source directory doesn't exist.");
                OnShowAgain();
            } catch (FileNotFoundException) {
                Error($"Source directory doesn't have any files{(hasFilter ? " that match the filter" : ".")}");
                OnShowAgain();
            } catch (FileLoadException) {
                Error("Start file doesn't exist.");
                OnShowAgain();
            }
        }

        void Error(string what) {
            MessageBox.Show(what, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void StartFileCheckbox_CheckedChanged(object sender, EventArgs e) {
            StartFileTextBox.Enabled = StartFileCheckbox.Checked;
            StartFileBrowseButton.Enabled = StartFileCheckbox.Checked;

            StartFileTextBox.Refresh();
            StartFileBrowseButton.Refresh();
        }

        private void SourceBrowseButton_Click(object sender, EventArgs e) {
            if (SourceFolderBrowser.ShowDialog() == DialogResult.OK) {
                SourceTextBox.Text = SourceFolderBrowser.SelectedPath;
            }
        }

        private void DestinationBrowseButton_Click(object sender, EventArgs e) {
            if (DestinationFolderBrowser.ShowDialog() == DialogResult.OK) {
                DestinationTextBox.Text = DestinationFolderBrowser.SelectedPath;
            }
        }

        private void StartFileBrowseButton_Click(object sender, EventArgs e) {
            if (StartFileDialog.ShowDialog() == DialogResult.OK) {
                SourceTextBox.Text = Path.GetFileName(StartFileDialog.FileName);
            }
        }

        private void FilterCheckbox_CheckedChanged(object sender, EventArgs e) {
            FilterTextBox.Enabled = FilterCheckbox.Checked;
            FilterTextBox.Refresh();
        }

        private void SourceTextBox_TextChanged(object sender, EventArgs e) {
            StartFileCheckbox.Checked = false;
            StartFileCheckbox.Refresh();
        }
    }
}

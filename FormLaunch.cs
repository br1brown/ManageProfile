using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Profili {
	public partial class FormLaunch : Form {

		public FormLaunch() {
			InitializeComponent();
		}

		private void btngo_Click(object sender, EventArgs e) {
			foreach (var pr in Back.GetItems(drpdProf.SelectedItem.ToString()))
				try {
					Process.Start(pr);
				} catch {
					try {
						Process process = new Process();
						ProcessStartInfo startInfo = new ProcessStartInfo();
						startInfo.FileName = "cmd.exe";
						startInfo.Arguments = "/C " + pr;
						process.StartInfo = startInfo;
						process.Start();
					} catch (Exception exx){
						MessageBox.Show(exx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			btnAddEdit.Text = "Add";
			if (drpdProf.SelectedIndex > 0)
				btnAddEdit.Text = "Edit";
			btngo.Enabled = btnAddEdit.Text == "Edit";
		}

		private void btnAddEdit_Click(object sender, EventArgs e) {
			string val = string.Empty;
			if (btnAddEdit.Text == "Edit")
				val = drpdProf.SelectedItem.ToString();
			new Editor(val).ShowDialog();

			Form1_Load(null, null);
		}

		private void Form1_Load(object sender, EventArgs e) {
			drpdProf.Items.Clear();
			drpdProf.Items.Add("-- NONE --");
			foreach (var fil in Back.GetProfiles) {
				drpdProf.Items.Add((fil));
			}
			drpdProf.SelectedIndex = 0;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape) {
				this.Close();
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profili {
	public partial class Form1 : Form {

		public const string CARTELLA = "prof";

		public static string[] GetItems(string file) {
			try {
				return File.ReadAllLines(CARTELLA + @"\" + file + ".txt").ToArray();
			} catch {
				return new List<string>().ToArray();
			}
		}
		public static void SetItem(string file, string[] item) {
			File.WriteAllLines(Form1.CARTELLA + @"\" + file + ".txt", item);
		}
		public static void Dels(string file) {
			File.Delete(Form1.CARTELLA + @"\" + file + ".txt");
		}

		public Form1() {
			InitializeComponent();
			if (!Directory.Exists(CARTELLA))
				Directory.CreateDirectory(CARTELLA);
		}

		private void btngo_Click(object sender, EventArgs e) {
			foreach (var pr in GetItems(drpdProf.SelectedItem.ToString()))
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
			foreach (var fil in Directory.GetFiles(CARTELLA)) {
				drpdProf.Items.Add(Path.GetFileNameWithoutExtension(fil));
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

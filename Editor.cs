using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profili {
	public partial class Editor : Form {
		public Editor(string name = "") {
			InitializeComponent();
			textName.Text = name;
			textName.ReadOnly = textName.Text != "";
			lDel.Visible = textName.ReadOnly;
			if (textName.Text != "") {
				listProg.Items.AddRange(Form1.GetItems(textName.Text));
			}
		}

		private void save_Click(object sender, EventArgs e) {
			Form1.SetItem(textName.Text, listProg.Items.OfType<string>().ToArray());
			Close();
		}

		private void listProg_SelectedIndexChanged(object sender, EventArgs e) {
			var menuVisible = (listProg.SelectedIndex != -1);

			if (menuVisible) {
				if (txtAdd.Text == "") {
					txtAdd.Text = listProg.SelectedItem.ToString();
					listProg.Items.RemoveAt(listProg.SelectedIndex);
				} else {
					SystemSounds.Exclamation.Play();
					txtAdd.Focus();
				}
				listProg.SelectedIndex = -1;
			}

			save.Enabled = textName.Text != string.Empty && listProg.Items.Count > 0;
		}

		private void btneditadd_Click(object sender, EventArgs e) {
			if (txtAdd.Text != "") {
				listProg.Items.Add(txtAdd.Text);
				txtAdd.Text = "";
			}
		}

		private void textName_TextChanged(object sender, EventArgs e) {
			save.Enabled = textName.Text != string.Empty && listProg.Items.Count > 0;
		}

		private void lDel_Click(object sender, EventArgs e) {
			if ((MessageBox.Show("Do you really want to delete the profile?", "DELETE THE PROFILE?",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
   MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)) {
				Form1.Dels(textName.Text);
				Close();
			}
		}


		void Form_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

		void Form_DragDrop(object sender, DragEventArgs e) {
			listProg.Items.AddRange((string[])e.Data.GetData(DataFormats.FileDrop));
		}
		private void Editor_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape) {
				if (txtAdd.Text != string.Empty)
					if ((MessageBox.Show("Close out without saving?", "CLOSE OUT WITHOUT SAVING?",
		   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
		   MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes))
						return;
				this.Close();
			}
		}

		private void opnefile_Click(object sender, EventArgs e) {
			if (txtAdd.Text == string.Empty)
				using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
					openFileDialog.InitialDirectory = "c:\\";
					openFileDialog.Filter = "All files (*.*)|*.*";
					openFileDialog.RestoreDirectory = true;

					if (openFileDialog.ShowDialog() == DialogResult.OK) {
						txtAdd.Text = (openFileDialog.FileName);
					}
				}
		}

		private void txtAdd_TextChanged(object sender, EventArgs e) {
			save.Enabled = textName.Text != string.Empty && listProg.Items.Count > 0;
		}
	}
}

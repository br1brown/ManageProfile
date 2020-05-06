namespace Profili {
	partial class Editor {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
			this.textName = new System.Windows.Forms.TextBox();
			this.listProg = new System.Windows.Forms.ListBox();
			this.save = new System.Windows.Forms.Button();
			this.btneditadd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtAdd = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.opnefile = new System.Windows.Forms.Label();
			this.lDel = new System.Windows.Forms.Label();
			this.lchoicceprg = new System.Windows.Forms.Label();
			this.lprogr = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textName
			// 
			this.textName.Dock = System.Windows.Forms.DockStyle.Top;
			this.textName.Location = new System.Drawing.Point(0, 0);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(538, 22);
			this.textName.TabIndex = 0;
			this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
			// 
			// listProg
			// 
			this.listProg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listProg.FormattingEnabled = true;
			this.listProg.ItemHeight = 16;
			this.listProg.Location = new System.Drawing.Point(3, 18);
			this.listProg.Name = "listProg";
			this.listProg.Size = new System.Drawing.Size(532, 336);
			this.listProg.TabIndex = 1;
			this.listProg.SelectedIndexChanged += new System.EventHandler(this.listProg_SelectedIndexChanged);
			// 
			// save
			// 
			this.save.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.save.Enabled = false;
			this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.save.Location = new System.Drawing.Point(0, 483);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(538, 38);
			this.save.TabIndex = 3;
			this.save.Text = "SAVE";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// btneditadd
			// 
			this.btneditadd.Dock = System.Windows.Forms.DockStyle.Right;
			this.btneditadd.Location = new System.Drawing.Point(476, 18);
			this.btneditadd.Name = "btneditadd";
			this.btneditadd.Size = new System.Drawing.Size(53, 52);
			this.btneditadd.TabIndex = 4;
			this.btneditadd.Text = "+";
			this.btneditadd.UseVisualStyleBackColor = true;
			this.btneditadd.Click += new System.EventHandler(this.btneditadd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.listProg);
			this.groupBox1.Location = new System.Drawing.Point(0, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(538, 357);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Program/File to Start";
			// 
			// txtAdd
			// 
			this.txtAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAdd.Location = new System.Drawing.Point(9, 21);
			this.txtAdd.Name = "txtAdd";
			this.txtAdd.Size = new System.Drawing.Size(461, 22);
			this.txtAdd.TabIndex = 7;
			this.txtAdd.TextChanged += new System.EventHandler(this.txtAdd_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.lprogr);
			this.groupBox2.Controls.Add(this.lchoicceprg);
			this.groupBox2.Controls.Add(this.opnefile);
			this.groupBox2.Controls.Add(this.txtAdd);
			this.groupBox2.Controls.Add(this.btneditadd);
			this.groupBox2.Location = new System.Drawing.Point(3, 404);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(532, 73);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add/Edit";
			// 
			// opnefile
			// 
			this.opnefile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.opnefile.AutoSize = true;
			this.opnefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.opnefile.Location = new System.Drawing.Point(371, 46);
			this.opnefile.Name = "opnefile";
			this.opnefile.Size = new System.Drawing.Size(99, 17);
			this.opnefile.TabIndex = 8;
			this.opnefile.Text = "CHOOSE FILE";
			this.opnefile.Click += new System.EventHandler(this.opnefile_Click);
			// 
			// lDel
			// 
			this.lDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lDel.AutoSize = true;
			this.lDel.ForeColor = System.Drawing.Color.Red;
			this.lDel.Location = new System.Drawing.Point(518, 3);
			this.lDel.Name = "lDel";
			this.lDel.Size = new System.Drawing.Size(17, 17);
			this.lDel.TabIndex = 7;
			this.lDel.Text = "X";
			this.lDel.Click += new System.EventHandler(this.lDel_Click);
			// 
			// lchoicceprg
			// 
			this.lchoicceprg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lchoicceprg.AutoSize = true;
			this.lchoicceprg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lchoicceprg.Location = new System.Drawing.Point(223, 46);
			this.lchoicceprg.Name = "lchoicceprg";
			this.lchoicceprg.Size = new System.Drawing.Size(142, 17);
			this.lchoicceprg.TabIndex = 9;
			this.lchoicceprg.Text = "CHOOSE PROGRAM";
			this.lchoicceprg.Click += new System.EventHandler(this.lchoicceprg_Click);
			// 
			// lprogr
			// 
			this.lprogr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lprogr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lprogr.FormattingEnabled = true;
			this.lprogr.Location = new System.Drawing.Point(9, 21);
			this.lprogr.Name = "lprogr";
			this.lprogr.Size = new System.Drawing.Size(461, 24);
			this.lprogr.TabIndex = 10;
			this.lprogr.Visible = false;
			this.lprogr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Editor
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 521);
			this.Controls.Add(this.lDel);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.save);
			this.Controls.Add(this.textName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(350, 500);
			this.Name = "Editor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editor";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_DragEnter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editor_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.ListBox listProg;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button btneditadd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtAdd;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lDel;
		private System.Windows.Forms.Label opnefile;
		private System.Windows.Forms.Label lchoicceprg;
		private System.Windows.Forms.ComboBox lprogr;
	}
}
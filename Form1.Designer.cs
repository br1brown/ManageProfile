namespace Profili {
	partial class Form1 {
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.drpdProf = new System.Windows.Forms.ComboBox();
			this.btngo = new System.Windows.Forms.Button();
			this.btnAddEdit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// drpdProf
			// 
			this.drpdProf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.drpdProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.drpdProf.FormattingEnabled = true;
			this.drpdProf.Location = new System.Drawing.Point(108, 20);
			this.drpdProf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.drpdProf.Name = "drpdProf";
			this.drpdProf.Size = new System.Drawing.Size(210, 33);
			this.drpdProf.TabIndex = 0;
			this.drpdProf.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// btngo
			// 
			this.btngo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btngo.Enabled = false;
			this.btngo.Location = new System.Drawing.Point(326, 8);
			this.btngo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btngo.Name = "btngo";
			this.btngo.Size = new System.Drawing.Size(102, 56);
			this.btngo.TabIndex = 1;
			this.btngo.Text = "Start";
			this.btngo.UseVisualStyleBackColor = true;
			this.btngo.Click += new System.EventHandler(this.btngo_Click);
			// 
			// btnAddEdit
			// 
			this.btnAddEdit.Location = new System.Drawing.Point(13, 13);
			this.btnAddEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAddEdit.Name = "btnAddEdit";
			this.btnAddEdit.Size = new System.Drawing.Size(87, 47);
			this.btnAddEdit.TabIndex = 3;
			this.btnAddEdit.Text = "Add";
			this.btnAddEdit.UseVisualStyleBackColor = true;
			this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(431, 67);
			this.Controls.Add(this.btnAddEdit);
			this.Controls.Add(this.btngo);
			this.Controls.Add(this.drpdProf);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage Profile";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox drpdProf;
		private System.Windows.Forms.Button btngo;
		private System.Windows.Forms.Button btnAddEdit;
	}
}


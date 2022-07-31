
namespace YGCLE
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
		if (disposing && (components != null))
		{
		components.Dispose();
		}
		base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox_notehi = new System.Windows.Forms.ListBox();
			this.listBox_type = new System.Windows.Forms.ListBox();
			this.button_file_new = new System.Windows.Forms.Button();
			this.button_file_load = new System.Windows.Forms.Button();
			this.button_file_save = new System.Windows.Forms.Button();
			this.label_file = new System.Windows.Forms.Label();
			this.label_length = new System.Windows.Forms.Label();
			this.label_lengthtext = new System.Windows.Forms.Label();
			this.label_bank = new System.Windows.Forms.Label();
			this.button_bank_new = new System.Windows.Forms.Button();
			this.button_bank_load = new System.Windows.Forms.Button();
			this.button_bank_save = new System.Windows.Forms.Button();
			this.button_bank_delete = new System.Windows.Forms.Button();
			this.listBox_bank = new System.Windows.Forms.ListBox();
			this.button_bank_get = new System.Windows.Forms.Button();
			this.button_bank_set = new System.Windows.Forms.Button();
			this.listBox_notelo = new System.Windows.Forms.ListBox();
			this.textBox_presetname = new System.Windows.Forms.TextBox();
			this.label_buffer = new System.Windows.Forms.Label();
			this.label_chords = new System.Windows.Forms.Label();
			this.button_pitch_down = new System.Windows.Forms.Button();
			this.label_pitch = new System.Windows.Forms.Label();
			this.button_pitch_up = new System.Windows.Forms.Button();
			this.comboBox_file_option = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// listBox_notehi
			// 
			this.listBox_notehi.FormattingEnabled = true;
			this.listBox_notehi.IntegralHeight = false;
			this.listBox_notehi.ItemHeight = 16;
			this.listBox_notehi.Items.AddRange(new object[] {
            "bbb",
            "bb",
            "b",
            "",
            "#",
            "##",
            "###"});
			this.listBox_notehi.Location = new System.Drawing.Point(440, 30);
			this.listBox_notehi.Name = "listBox_notehi";
			this.listBox_notehi.Size = new System.Drawing.Size(40, 120);
			this.listBox_notehi.TabIndex = 0;
			// 
			// listBox_type
			// 
			this.listBox_type.ColumnWidth = 84;
			this.listBox_type.FormattingEnabled = true;
			this.listBox_type.IntegralHeight = false;
			this.listBox_type.ItemHeight = 16;
			this.listBox_type.Items.AddRange(new object[] {
            "",
            "6",
            "M7",
            "M7(#11)",
            "add9",
            "M7(9)",
            "6(9)",
            "aug",
            "m",
            "m6",
            "m7",
            "m7(b5)",
            "madd9",
            "m7(9)",
            "m7(11)",
            "mM7",
            "mM7(9)",
            "dim",
            "dim7",
            "7",
            "7sus4",
            "7(b5)",
            "7(9)",
            "7(#11)",
            "7(13)",
            "7(b9)",
            "7(b13)",
            "7(#9)",
            "M7aug",
            "7aug",
            "1+8",
            "1+5",
            "sus4",
            "sus2",
            "Cancel"});
			this.listBox_type.Location = new System.Drawing.Point(490, 30);
			this.listBox_type.MultiColumn = true;
			this.listBox_type.Name = "listBox_type";
			this.listBox_type.Size = new System.Drawing.Size(260, 200);
			this.listBox_type.TabIndex = 0;
			// 
			// button_file_new
			// 
			this.button_file_new.Location = new System.Drawing.Point(310, 30);
			this.button_file_new.Name = "button_file_new";
			this.button_file_new.Size = new System.Drawing.Size(80, 25);
			this.button_file_new.TabIndex = 1;
			this.button_file_new.Text = "New";
			this.button_file_new.UseVisualStyleBackColor = true;
			this.button_file_new.Click += new System.EventHandler(this.button_file_new_Click);
			// 
			// button_file_load
			// 
			this.button_file_load.Location = new System.Drawing.Point(310, 57);
			this.button_file_load.Name = "button_file_load";
			this.button_file_load.Size = new System.Drawing.Size(80, 25);
			this.button_file_load.TabIndex = 1;
			this.button_file_load.Text = "Load";
			this.button_file_load.UseVisualStyleBackColor = true;
			this.button_file_load.Click += new System.EventHandler(this.button_file_load_Click);
			// 
			// button_file_save
			// 
			this.button_file_save.Location = new System.Drawing.Point(310, 84);
			this.button_file_save.Name = "button_file_save";
			this.button_file_save.Size = new System.Drawing.Size(80, 25);
			this.button_file_save.TabIndex = 1;
			this.button_file_save.Text = "Save";
			this.button_file_save.UseVisualStyleBackColor = true;
			this.button_file_save.Click += new System.EventHandler(this.button_file_save_Click);
			// 
			// label_file
			// 
			this.label_file.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_file.Location = new System.Drawing.Point(301, 0);
			this.label_file.Name = "label_file";
			this.label_file.Size = new System.Drawing.Size(469, 20);
			this.label_file.TabIndex = 2;
			this.label_file.Text = "File";
			this.label_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_length
			// 
			this.label_length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_length.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_length.Location = new System.Drawing.Point(310, 180);
			this.label_length.Name = "label_length";
			this.label_length.Size = new System.Drawing.Size(80, 20);
			this.label_length.TabIndex = 2;
			this.label_length.Text = "Length";
			this.label_length.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_lengthtext
			// 
			this.label_lengthtext.BackColor = System.Drawing.Color.White;
			this.label_lengthtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_lengthtext.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_lengthtext.Location = new System.Drawing.Point(310, 199);
			this.label_lengthtext.Name = "label_lengthtext";
			this.label_lengthtext.Size = new System.Drawing.Size(80, 20);
			this.label_lengthtext.TabIndex = 2;
			this.label_lengthtext.Text = "1";
			this.label_lengthtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_bank
			// 
			this.label_bank.BackColor = System.Drawing.SystemColors.Control;
			this.label_bank.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_bank.Location = new System.Drawing.Point(0, 0);
			this.label_bank.Name = "label_bank";
			this.label_bank.Size = new System.Drawing.Size(300, 20);
			this.label_bank.TabIndex = 2;
			this.label_bank.Text = "Bank";
			this.label_bank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_bank_new
			// 
			this.button_bank_new.Location = new System.Drawing.Point(10, 30);
			this.button_bank_new.Name = "button_bank_new";
			this.button_bank_new.Size = new System.Drawing.Size(80, 25);
			this.button_bank_new.TabIndex = 1;
			this.button_bank_new.Text = "New";
			this.button_bank_new.UseVisualStyleBackColor = true;
			this.button_bank_new.Click += new System.EventHandler(this.button_bank_new_Click);
			// 
			// button_bank_load
			// 
			this.button_bank_load.Location = new System.Drawing.Point(10, 56);
			this.button_bank_load.Name = "button_bank_load";
			this.button_bank_load.Size = new System.Drawing.Size(80, 25);
			this.button_bank_load.TabIndex = 1;
			this.button_bank_load.Text = "Load";
			this.button_bank_load.UseVisualStyleBackColor = true;
			this.button_bank_load.Click += new System.EventHandler(this.button_bank_load_Click);
			// 
			// button_bank_save
			// 
			this.button_bank_save.Location = new System.Drawing.Point(10, 82);
			this.button_bank_save.Name = "button_bank_save";
			this.button_bank_save.Size = new System.Drawing.Size(80, 25);
			this.button_bank_save.TabIndex = 1;
			this.button_bank_save.Text = "Save";
			this.button_bank_save.UseVisualStyleBackColor = true;
			this.button_bank_save.Click += new System.EventHandler(this.button_bank_save_Click);
			// 
			// button_bank_delete
			// 
			this.button_bank_delete.Location = new System.Drawing.Point(10, 180);
			this.button_bank_delete.Name = "button_bank_delete";
			this.button_bank_delete.Size = new System.Drawing.Size(80, 25);
			this.button_bank_delete.TabIndex = 1;
			this.button_bank_delete.Text = "Delete";
			this.button_bank_delete.UseVisualStyleBackColor = true;
			this.button_bank_delete.Click += new System.EventHandler(this.button_bank_delete_Click);
			// 
			// listBox_bank
			// 
			this.listBox_bank.FormattingEnabled = true;
			this.listBox_bank.IntegralHeight = false;
			this.listBox_bank.ItemHeight = 16;
			this.listBox_bank.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
			this.listBox_bank.Location = new System.Drawing.Point(100, 30);
			this.listBox_bank.Name = "listBox_bank";
			this.listBox_bank.Size = new System.Drawing.Size(190, 140);
			this.listBox_bank.TabIndex = 0;
			// 
			// button_bank_get
			// 
			this.button_bank_get.Location = new System.Drawing.Point(10, 117);
			this.button_bank_get.Name = "button_bank_get";
			this.button_bank_get.Size = new System.Drawing.Size(80, 25);
			this.button_bank_get.TabIndex = 1;
			this.button_bank_get.Text = "Get <<";
			this.button_bank_get.UseVisualStyleBackColor = true;
			this.button_bank_get.Click += new System.EventHandler(this.button_bank_get_Click);
			// 
			// button_bank_set
			// 
			this.button_bank_set.Location = new System.Drawing.Point(10, 143);
			this.button_bank_set.Name = "button_bank_set";
			this.button_bank_set.Size = new System.Drawing.Size(80, 25);
			this.button_bank_set.TabIndex = 1;
			this.button_bank_set.Text = "Set >>";
			this.button_bank_set.UseVisualStyleBackColor = true;
			this.button_bank_set.Click += new System.EventHandler(this.button_bank_set_Click);
			// 
			// listBox_notelo
			// 
			this.listBox_notelo.FormattingEnabled = true;
			this.listBox_notelo.IntegralHeight = false;
			this.listBox_notelo.ItemHeight = 16;
			this.listBox_notelo.Items.AddRange(new object[] {
            "",
            "C",
            "D",
            "E",
            "F",
            "G",
            "A",
            "B"});
			this.listBox_notelo.Location = new System.Drawing.Point(400, 30);
			this.listBox_notelo.Name = "listBox_notelo";
			this.listBox_notelo.Size = new System.Drawing.Size(30, 140);
			this.listBox_notelo.TabIndex = 0;
			// 
			// textBox_presetname
			// 
			this.textBox_presetname.Location = new System.Drawing.Point(100, 180);
			this.textBox_presetname.Name = "textBox_presetname";
			this.textBox_presetname.Size = new System.Drawing.Size(190, 23);
			this.textBox_presetname.TabIndex = 3;
			// 
			// label_buffer
			// 
			this.label_buffer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_buffer.Location = new System.Drawing.Point(771, 0);
			this.label_buffer.Name = "label_buffer";
			this.label_buffer.Size = new System.Drawing.Size(370, 20);
			this.label_buffer.TabIndex = 2;
			this.label_buffer.Text = "Buffer";
			this.label_buffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_chords
			// 
			this.label_chords.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_chords.Location = new System.Drawing.Point(0, 241);
			this.label_chords.Name = "label_chords";
			this.label_chords.Size = new System.Drawing.Size(1140, 19);
			this.label_chords.TabIndex = 2;
			this.label_chords.Text = "Chords";
			this.label_chords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_pitch_down
			// 
			this.button_pitch_down.Location = new System.Drawing.Point(310, 150);
			this.button_pitch_down.Name = "button_pitch_down";
			this.button_pitch_down.Size = new System.Drawing.Size(40, 23);
			this.button_pitch_down.TabIndex = 4;
			this.button_pitch_down.Text = "-";
			this.button_pitch_down.UseVisualStyleBackColor = true;
			this.button_pitch_down.Click += new System.EventHandler(this.button_file_pitchdown_Click);
			// 
			// label_pitch
			// 
			this.label_pitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_pitch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_pitch.Location = new System.Drawing.Point(310, 130);
			this.label_pitch.Name = "label_pitch";
			this.label_pitch.Size = new System.Drawing.Size(80, 20);
			this.label_pitch.TabIndex = 2;
			this.label_pitch.Text = "Pitch";
			this.label_pitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_pitch_up
			// 
			this.button_pitch_up.Location = new System.Drawing.Point(350, 150);
			this.button_pitch_up.Name = "button_pitch_up";
			this.button_pitch_up.Size = new System.Drawing.Size(40, 23);
			this.button_pitch_up.TabIndex = 4;
			this.button_pitch_up.Text = "+";
			this.button_pitch_up.UseVisualStyleBackColor = true;
			this.button_pitch_up.Click += new System.EventHandler(this.button_file_pitchup_Click);
			// 
			// comboBox_file_option
			// 
			this.comboBox_file_option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_file_option.FormattingEnabled = true;
			this.comboBox_file_option.Items.AddRange(new object[] {
            "b",
            "#"});
			this.comboBox_file_option.Location = new System.Drawing.Point(440, 160);
			this.comboBox_file_option.Name = "comboBox_file_option";
			this.comboBox_file_option.Size = new System.Drawing.Size(40, 24);
			this.comboBox_file_option.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1140, 520);
			this.Controls.Add(this.comboBox_file_option);
			this.Controls.Add(this.button_pitch_up);
			this.Controls.Add(this.button_pitch_down);
			this.Controls.Add(this.label_chords);
			this.Controls.Add(this.label_buffer);
			this.Controls.Add(this.label_file);
			this.Controls.Add(this.label_pitch);
			this.Controls.Add(this.label_length);
			this.Controls.Add(this.label_bank);
			this.Controls.Add(this.listBox_notehi);
			this.Controls.Add(this.listBox_notelo);
			this.Controls.Add(this.listBox_bank);
			this.Controls.Add(this.listBox_type);
			this.Controls.Add(this.button_bank_new);
			this.Controls.Add(this.button_file_new);
			this.Controls.Add(this.button_bank_get);
			this.Controls.Add(this.label_lengthtext);
			this.Controls.Add(this.button_file_load);
			this.Controls.Add(this.textBox_presetname);
			this.Controls.Add(this.button_file_save);
			this.Controls.Add(this.button_bank_set);
			this.Controls.Add(this.button_bank_save);
			this.Controls.Add(this.button_bank_load);
			this.Controls.Add(this.button_bank_delete);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "YamahaGenosChordLooperEditor";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox_notehi;
		private System.Windows.Forms.ListBox listBox_type;
		private System.Windows.Forms.Button button_file_new;
		private System.Windows.Forms.Button button_file_load;
		private System.Windows.Forms.Button button_file_save;
		private System.Windows.Forms.Label label_file;
		private System.Windows.Forms.Label label_length;
		private System.Windows.Forms.Label label_lengthtext;
		private System.Windows.Forms.Label label_bank;
		private System.Windows.Forms.Button button_bank_new;
		private System.Windows.Forms.Button button_bank_load;
		private System.Windows.Forms.Button button_bank_save;
		private System.Windows.Forms.Button button_bank_delete;
		private System.Windows.Forms.ListBox listBox_bank;
		private System.Windows.Forms.Button button_bank_get;
		private System.Windows.Forms.Button button_bank_set;
		private System.Windows.Forms.ListBox listBox_notelo;
		private System.Windows.Forms.TextBox textBox_presetname;
		private System.Windows.Forms.Label label_buffer;
		private System.Windows.Forms.Label label_chords;
		private System.Windows.Forms.Button button_pitch_down;
		private System.Windows.Forms.Label label_pitch;
		private System.Windows.Forms.Button button_pitch_up;
		private System.Windows.Forms.ComboBox comboBox_file_option;
	}
}


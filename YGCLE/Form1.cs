using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace YGCLE
{
	public partial class Form1 : Form
	{
		public Label[] BufferLabel;
		public Data[] BufferData;

		public Label[] ChordGridLabel;
		public Data[] ChordGridData;

		public int Length;

		public Color Selection1 = Color.FromArgb(127, 255, 127);
		public Color Selection2 = Color.FromArgb(95, 191, 95);

		public CLB TheCLB;
		public CLD TheCLD;

		public int[] TransposeArrayEs1 = new int[] { 1, 2, 2, 3, 3, 4, 5, 5, 6, 6, 7, 7 };
		public int[] TransposeArrayEs2 = new int[] { 3, 2, 3, 2, 3, 3, 2, 3, 2, 3, 2, 3 };

		public int[] TransposeArrayIs1 = new int[] { 1, 1, 2, 2, 3, 4, 4, 5, 5, 6, 6, 7 };
		public int[] TransposeArrayIs2 = new int[] { 3, 4, 3, 4, 3, 3, 4, 3, 4, 3, 4, 3 };

		public Form1()
		{
			InitializeComponent();

			this.label_bank.BackColor = Color.FromArgb(191, 127, 127);

			this.checkBox_bank_autoget.BackColor = Color.FromArgb(255, 127, 127);
			this.checkBox_bank_autoset.BackColor = Color.FromArgb(255, 127, 127);

			this.label_file.BackColor = Color.FromArgb(191, 191, 127);
			this.label_pitch.BackColor = Color.FromArgb(191, 191, 127);
			this.label_length.BackColor = Color.FromArgb(191, 191, 127);
			this.label_buffer.BackColor = Color.FromArgb(127, 191, 127);
			this.label_chords.BackColor = Color.FromArgb(127, 191, 191);

			this.listBox_bank.SelectedIndex = 0;
			this.Length = 1;

			this.comboBox_file_option.SelectedIndex = 1;

			InitChordBuffer(780, 30, 5, 6, 70, 30);
			InitChordGrid(10, 270, 16, 8, 70, 30);
		}

		public void InitChordBuffer(int PositionX, int PositionY, int CountX, int CountY, int SizeX, int SizeY)
		{
			this.BufferLabel = new Label[CountX * CountY];
			this.BufferData = new Data[CountX * CountY];

			for (int I = 0; I < this.BufferLabel.Length; I++)
			{
				int X = I % CountX;
				int Y = I / CountX;

				this.BufferLabel[I] = new Label();
				this.BufferLabel[I].BorderStyle = BorderStyle.FixedSingle;
				this.BufferLabel[I].Font = new Font(this.Font.Name, this.Font.Size - 2f);
				this.BufferLabel[I].Location = new Point(X * SizeX + PositionX, Y * SizeY + PositionY);
				this.BufferLabel[I].Size = new Size(SizeX + 1, SizeY + 1);
				this.BufferLabel[I].TextAlign = ContentAlignment.MiddleCenter;

				this.BufferLabel[I].MouseClick += delegate(object sender, MouseEventArgs e)
				{
					int Index = X + Y * CountX;

					if (e.Button == MouseButtons.Left)
					{
						if (BufferData[Index] == null) { return; }

						this.listBox_notelo.SelectedIndex = BufferData[Index].Value1;
						this.listBox_notehi.SelectedIndex = BufferData[Index].Value2;
						this.listBox_type.SelectedIndex = BufferData[Index].Value3;
					}
					else if (e.Button == MouseButtons.Right)
					{
						this.BufferData[Index] = null;
						this.BufferLabel[Index].Text = "";
					}
				};

				this.Controls.Add(this.BufferLabel[I]);
			}
		}
		public void InitChordGrid(int PositionX, int PositionY, int CountX, int CountY, int SizeX, int SizeY)
		{
			this.ChordGridLabel = new Label[CountX * CountY];
			this.ChordGridData = new Data[CountX * CountY];

			for (int I = 0; I < this.ChordGridLabel.Length; I++)
			{
				int X = I % CountX;
				int Y = I / CountX;

				this.ChordGridLabel[I] = new Label();
				this.ChordGridLabel[I].BorderStyle = BorderStyle.FixedSingle;
				this.ChordGridLabel[I].Font = new Font(this.Font.Name, this.Font.Size - 2f);
				this.ChordGridLabel[I].Location = new Point(X * SizeX + PositionX, Y * SizeY + PositionY);
				this.ChordGridLabel[I].Size = new Size(SizeX + 1, SizeY + 1);
				this.ChordGridLabel[I].TextAlign = ContentAlignment.MiddleCenter;

				if (I / 4 % 2 == 1) { this.ChordGridLabel[I].BackColor = Color.FromArgb(191, 191, 191); }
				if (I == 0) { this.ChordGridLabel[I].BackColor = this.Selection1; }

				this.ChordGridLabel[I].MouseClick += delegate(object sender, MouseEventArgs e)
				{
					int Index = X + Y * CountX;

					if (e.Button == MouseButtons.Left)
					{
						this.ChordGridData[Index] = new Data(this.listBox_notelo.SelectedIndex, this.listBox_notehi.SelectedIndex, this.listBox_type.SelectedIndex);
						if (this.listBox_type.SelectedIndex == 34) { this.ChordGridLabel[Index].Text = this.listBox_type.Text; }
						else { this.ChordGridLabel[Index].Text = this.listBox_notelo.Text + this.listBox_notehi.Text + this.listBox_type.Text; }

						bool Flag = false;
						for (int I2 = 0; I2 < this.BufferLabel.Length; I2++)
						{
							if (this.BufferLabel[I2].Text.Equals(this.ChordGridLabel[Index].Text))
							{
								Flag = true;
								break;
							}
						}

						if (!Flag)
						{
							for (int I2 = 0; I2 < this.BufferLabel.Length; I2++)
							{
								if (this.BufferLabel[I2].Text.Equals(""))
								{
									this.BufferData[I2] = this.ChordGridData[Index];
									this.BufferLabel[I2].Text = this.ChordGridLabel[Index].Text;
									break;
								}
							}
						}

						if (this.checkBox_bank_autoset.Checked) { button_bank_set_Click(this, EventArgs.Empty); }
					}
					else if (e.Button == MouseButtons.Right)
					{
						this.ChordGridData[Index] = null;
						this.ChordGridLabel[Index].Text = "";
						if (this.checkBox_bank_autoset.Checked) { button_bank_set_Click(this, EventArgs.Empty); }
					}
					else if (e.Button == MouseButtons.Middle)
					{
						this.Length = Index + 1;
						this.label_lengthtext.Text = this.Length.ToString();

						for (int I2 = 0; I2 < this.ChordGridLabel.Length; I2++)
						{
							this.ChordGridLabel[I2].BackColor = default;
							if (I2 <= Index) { this.ChordGridLabel[I2].BackColor = this.Selection1; }

							if (I2 / 4 % 2 == 1)
							{
								this.ChordGridLabel[I2].BackColor = Color.FromArgb(191, 191, 191);
								if (I2 <= Index) { this.ChordGridLabel[I2].BackColor = this.Selection2; }
							}
						}

						if (this.checkBox_bank_autoset.Checked) { button_bank_set_Click(this, EventArgs.Empty); }
					}
				};

				this.Controls.Add(this.ChordGridLabel[I]);
			}
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			button_bank_new_Click(this, EventArgs.Empty);
			button_file_new_Click(this, EventArgs.Empty);
		}
		public void Form1_Shown(object sender, EventArgs e)
		{
			this.textBox_presetname.Focus();
			for (int I = 0; I < this.Controls.Count; I++)
			{
				this.Controls[I].KeyDown += ExitOnEscape;
			}
		}
		public void Form1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 191, 191)), 0, 20, 300, 220);
			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 191)), 300, 20, 540, 220);
			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(191, 255, 191)), 770, 20, 370, 220);
			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(191, 255, 255)), 0, 240, 1140, 280);

			e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0)), 0, 20, this.ClientSize.Width - 1, 20);
			e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0)), 0, 240, this.ClientSize.Width - 1, 240);
			e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0)), 0, 260, this.ClientSize.Width - 1, 260);
			e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0)), 300, 0, 300, 240);
			e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0)), 770, 0, 770, 240);
		}

		public void ExitOnEscape(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) { this.Close(); }
		}

		public void button_bank_new_Click(object sender, EventArgs e)
		{
			this.TheCLB = new CLB();

			for (int I = 0; I < 8; I++)
			{
				this.listBox_bank.Items[I] = "";
			}

			this.listBox_bank.SelectedIndex = 0;
			this.textBox_presetname.Text = "";
		}
		public void button_bank_load_Click(object sender, EventArgs e)
		{
			OpenFileDialog NewOpenFileDialog = new OpenFileDialog();
			NewOpenFileDialog.Filter = "Chord Looper Bank (*.clb)|*.clb";

			DialogResult TheDialogResult = NewOpenFileDialog.ShowDialog();
			if (TheDialogResult != DialogResult.OK) { return; }

			this.TheCLB = new CLB();
			this.TheCLB.Load(NewOpenFileDialog.FileName);

			for (int I = 0; I < 8; I++)
			{
				this.listBox_bank.Items[I] = this.TheCLB.Filename[I];
			}
		}
		public void button_bank_save_Click(object sender, EventArgs e)
		{
			SaveFileDialog NewSaveFileDialog = new SaveFileDialog();
			NewSaveFileDialog.Filter = "Chord Looper Bank (*.clb)|*.clb";

			DialogResult TheDialogResult = NewSaveFileDialog.ShowDialog();
			if (TheDialogResult != DialogResult.OK) { return; }

			this.TheCLB.Save(NewSaveFileDialog.FileName);
		}
		public void button_bank_get_Click(object sender, EventArgs e)
		{
			int Index = this.listBox_bank.SelectedIndex;
			if (Index == -1) { return; }

			this.textBox_presetname.Text = this.TheCLB.Filename[Index];
			button_file_new_Click(this, EventArgs.Empty);

			if (this.textBox_presetname.Text.Equals("")) { return; }
			this.TheCLD = this.TheCLB.CldArray[Index];

			CldToGui();
		}
		public void button_bank_set_Click(object sender, EventArgs e)
		{
			int Index = this.listBox_bank.SelectedIndex;
			if (this.textBox_presetname.Text.Equals("")) { return; }

			GuiToCld();
			this.TheCLB.CldArray[Index] = this.TheCLD;

			this.TheCLB.Filename[Index] = this.textBox_presetname.Text;
			this.listBox_bank.Items[Index] = this.textBox_presetname.Text;
		}
		public void button_bank_delete_Click(object sender, EventArgs e)
		{
			this.listBox_bank.Items[this.listBox_bank.SelectedIndex] = "";
			this.TheCLB.CldArray[this.listBox_bank.SelectedIndex] = new CLD();
			this.TheCLB.Filename[this.listBox_bank.SelectedIndex] = "";
			this.textBox_presetname.Text = "";
		}

		public void button_file_new_Click(object sender, EventArgs e)
		{
			this.listBox_notelo.SelectedIndex = 1;
			this.listBox_notehi.SelectedIndex = 3;
			this.listBox_type.SelectedIndex = 0;

			for (int I = 0; I < this.BufferLabel.Length; I++)
			{
				this.BufferData[I] = null;
				this.BufferLabel[I].Text = "";
			}

			for (int I = 0; I < this.ChordGridLabel.Length; I++)
			{
				this.ChordGridData[I] = null;
				this.ChordGridLabel[I].Text = "";

				this.ChordGridLabel[I].BackColor = default;
				if (I / 4 % 2 == 1) { this.ChordGridLabel[I].BackColor = Color.FromArgb(191, 191, 191); }
				if (I == 0) { this.ChordGridLabel[I].BackColor = this.Selection1; }
			}

			this.Length = 1;
			this.label_lengthtext.Text = this.Length.ToString();

			this.TheCLD = new CLD();
			this.TheCLD.Create();
		}
		public void button_file_load_Click(object sender, EventArgs e)
		{
			OpenFileDialog NewOpenFileDialog = new OpenFileDialog();
			NewOpenFileDialog.Filter = "Chord Looper File (*.cld)|*.cld";

			DialogResult TheDialogResult = NewOpenFileDialog.ShowDialog();
			if (TheDialogResult != DialogResult.OK) { return; }

			button_file_new_Click(this, EventArgs.Empty);

			this.TheCLD = new CLD();
			this.TheCLD.Load(NewOpenFileDialog.FileName);

			CldToGui();
		}
		public void button_file_save_Click(object sender, EventArgs e)
		{
			SaveFileDialog NewSaveFileDialog = new SaveFileDialog();
			NewSaveFileDialog.Filter = "Chord Looper File (*.cld)|*.cld";

			DialogResult TheDialogResult = NewSaveFileDialog.ShowDialog();
			if (TheDialogResult != DialogResult.OK) { return; }

			GuiToCld();
			this.TheCLD.Save(NewSaveFileDialog.FileName);
		}
		public void button_file_pitchdown_Click(object sender, EventArgs e)
		{
			for (int I = 0; I < this.Length; I++)
			{
				if (this.ChordGridData[I] == null) { continue; }

				if (this.comboBox_file_option.SelectedIndex == 0)
				{
					int Index = GetPitch(this.ChordGridData[I].Value1, this.ChordGridData[I].Value2) - 1;
					if (Index < 0) { Index = 11; }
					if (Index > 11) { Index = 0; }
					SetPitch(I, this.TransposeArrayEs1[Index], this.TransposeArrayEs2[Index]);
				}
				else
				{
					int Index = GetPitch(this.ChordGridData[I].Value1, this.ChordGridData[I].Value2) - 1;
					if (Index < 0) { Index = 11; }
					if (Index > 11) { Index = 0; }
					SetPitch(I, this.TransposeArrayIs1[Index], this.TransposeArrayIs2[Index]);
				}
			}
			ChordGridToGui();

		}
		public void button_file_pitchup_Click(object sender, EventArgs e)
		{
			for (int I = 0; I < this.Length; I++)
			{
				if (this.ChordGridData[I] == null) { continue; }

				if (this.comboBox_file_option.SelectedIndex == 0)
				{
					int Index = GetPitch(this.ChordGridData[I].Value1, this.ChordGridData[I].Value2) + 1;
					if (Index < 0) { Index = 11; }
					if (Index > 11) { Index = 0; }
					SetPitch(I, this.TransposeArrayEs1[Index], this.TransposeArrayEs2[Index]);
				}
				else
				{
					int Index = GetPitch(this.ChordGridData[I].Value1, this.ChordGridData[I].Value2) + 1;
					if (Index < 0) { Index = 11; }
					if (Index > 11) { Index = 0; }
					SetPitch(I, this.TransposeArrayIs1[Index], this.TransposeArrayIs2[Index]);
				}
			}
			ChordGridToGui();
		}

		public void listBox_bank_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.checkBox_bank_autoget.Checked) { button_bank_get_Click(this, EventArgs.Empty); }
		}

		public int GetPitch(int Value1, int Value2)
		{
			int Result = 0;

			if (Value1 == 1) { Result = 0; }
			if (Value1 == 2) { Result = 2; }
			if (Value1 == 3) { Result = 4; }
			if (Value1 == 4) { Result = 5; }
			if (Value1 == 5) { Result = 7; }
			if (Value1 == 6) { Result = 9; }
			if (Value1 == 7) { Result = 11; }

			if (Value2 == 2) { Result = Result - 1; }
			if (Value2 == 4) { Result = Result + 1; }

			return Result;
		}
		public void SetPitch(int Index, int Value1, int Value2)
		{
			this.ChordGridData[Index].Value1 = Value1;
			this.ChordGridData[Index].Value2 = Value2;
		}

		public void ChordGridToGui()
		{
			for (int I = 0; I < this.Length; I++)
			{
				if (this.ChordGridData[I] != null)
				{
					if (this.ChordGridData[I].Value3 == 34) { this.ChordGridLabel[I].Text = this.listBox_type.Items[this.ChordGridData[I].Value3].ToString(); }
					{ this.ChordGridLabel[I].Text = this.listBox_notelo.Items[this.ChordGridData[I].Value1].ToString() + this.listBox_notehi.Items[this.ChordGridData[I].Value2].ToString() + this.listBox_type.Items[this.ChordGridData[I].Value3].ToString(); }
				}

				if (I / 4 % 2 == 1)
				{
					this.ChordGridLabel[I].BackColor = Color.FromArgb(191, 191, 191);
					if (I <= this.Length) { this.ChordGridLabel[I].BackColor = this.Selection2; }
				}
				else
				{
					this.ChordGridLabel[I].BackColor = default;
					if (I <= this.Length) { this.ChordGridLabel[I].BackColor = this.Selection1; }
				}

			}

			this.label_lengthtext.Text = this.Length.ToString();
		}
		public void CldToGui()
		{
			if (this.TheCLD.TheData.Length == 0)
			{
				this.Length = 1;
				return;
			}

			int Position = 0;
			for (int I = 0; I < this.TheCLD.TheData.Length; I++)
			{
				Position = Position + (int)(this.TheCLD.TheData[I].DeltaTime / 1920);
				byte Byte1 = (byte)(this.TheCLD.TheData[I].Value1 & 0xF);
				byte Byte2 = (byte)((this.TheCLD.TheData[I].Value1 & 0xF0) >> 4);
				byte Byte3 = this.TheCLD.TheData[I].Value2;

				this.ChordGridData[Position] = new Data(Byte1, Byte2, Byte3);

				if (Byte3 == 34) { this.ChordGridLabel[Position].Text = this.listBox_type.Items[Byte3].ToString(); }
				else { this.ChordGridLabel[Position].Text = "" + this.listBox_notelo.Items[Byte1] + this.listBox_notehi.Items[Byte2] + this.listBox_type.Items[Byte3]; }
			}

			Position = Position + (int)(this.TheCLD.LastDeltaTime / 1920);
			this.Length = Position;
			this.label_lengthtext.Text = this.Length.ToString();

			ChordGridToGui();
		}
		public void GuiToCld()
		{
			bool Flag = false;
			for (int I = 0; I < 128; I++)
			{
				if (this.ChordGridData[I] != null)
				{
					Flag = true;
					break;
				}
			}
			if (!Flag) { return; }

			this.TheCLD = new CLD();
			this.TheCLD.Create();

			List<CLD.Data> DataList = new List<CLD.Data>();
			int Position = 0;
			for (int I = 0; I < this.Length; I++)
			{
				if (this.ChordGridData[I] != null)
				{
					byte Byte1 = (byte)(this.ChordGridData[I].Value2 << 4);
					Byte1 = (byte)(Byte1 + this.ChordGridData[I].Value1);
					byte Byte2 = (byte)this.ChordGridData[I].Value3;

					DataList.Add(new CLD.Data((uint)((I - Position) * 1920), Byte1, Byte2));
					Position = I;
				}
			}

			this.TheCLD.LastDeltaTime = (uint)((this.Length - Position) * 1920);
			this.TheCLD.TheData = DataList.ToArray();

			this.TheCLD.Build();
		}

		public class Data
		{
			public int Value1;
			public int Value2;
			public int Value3;

			public Data(int Value1, int Value2, int Value3)
			{
				this.Value1 = Value1;
				this.Value2 = Value2;
				this.Value3 = Value3;
			}
		}
		public class CLB
		{
			public string[] Filename = new string[8];
			public CLD[] CldArray = new CLD[8];

			public CLB()
			{
				for (int I = 0; I < 8; I++)
				{
					this.Filename[I] = "";
					this.CldArray[I] = new CLD();
					this.CldArray[I].Create();
				}
			}

			public void Load(string Filename)
			{
				this.Filename = new string[8];
				this.CldArray = new CLD[8];

				byte[] Data = File.ReadAllBytes(Filename);

				MemoryStream MS = new MemoryStream(Data);
				BinaryReader BR = new BinaryReader(MS);

				for (int I = 0; I < 8; I++)
				{
					List<byte> Presetname = new List<byte>();

					while (true)
					{
						byte NextByte = BR.ReadByte();
						if (NextByte == 0x0D)
						{
							NextByte = BR.ReadByte();
							if (NextByte == 0x0A) { break; }
						}

						Presetname.Add(NextByte);
					}

					this.Filename[I] = Encoding.ASCII.GetString(Presetname.ToArray());

					this.CldArray[I] = new CLD();
					this.CldArray[I].Create();

					this.CldArray[I].Header.Read(BR);
					this.CldArray[I].Track.Read(BR);

					this.CldArray[I].Parse();
				}

				BR.Close();
				MS.Close();
			}
			public void Save(string Filename)
			{
				MemoryStream MS = new MemoryStream();
				BinaryWriter BW = new BinaryWriter(MS);

				for (int I1 = 0; I1 < 8; I1++)
				{
					for (int I2 = 0; I2 < this.Filename[I1].Length; I2++)
					{
						BW.Write(this.Filename[I1][I2]);
					}

					BW.Write((byte)0x0D);
					BW.Write((byte)0x0A);

					this.CldArray[I1].Build();
					this.CldArray[I1].Header.Write(BW);
					this.CldArray[I1].Track.Write(BW);
				}

				File.WriteAllBytes(Filename, MS.ToArray());

				BW.Close();
				MS.Close();
			}
		}
		public class CLD
		{
			public class HeaderClass
			{
				public string Signature;
				public uint Length;
				public ushort Format;
				public ushort Tracks;
				public ushort DeltaTime;

				public void Create()
				{
					this.Signature = "MThd";
					this.Length = 6;
					this.Format = 0;
					this.Tracks = 1;
					this.DeltaTime = 1920;
				}
				public void Read(BinaryReader BR)
				{
					this.Signature = Encoding.ASCII.GetString(BR.ReadBytes(4));
					this.Length = Util.SwapUInt32(BR.ReadUInt32());
					this.Format = Util.SwapUInt16(BR.ReadUInt16());
					this.Tracks = Util.SwapUInt16(BR.ReadUInt16());
					this.DeltaTime = Util.SwapUInt16(BR.ReadUInt16());
				}
				public void Write(BinaryWriter BW)
				{
					BW.Write(Encoding.ASCII.GetBytes(this.Signature));
					BW.Write(Util.SwapUInt32(this.Length));
					BW.Write(Util.SwapUInt16(this.Format));
					BW.Write(Util.SwapUInt16(this.Tracks));
					BW.Write(Util.SwapUInt16(this.DeltaTime));
				}
			}
			public class TrackClass
			{
				public string Signature;
				public uint Length;
				public byte[] Data;

				public void Create()
				{
					this.Signature = "MTrk";
					this.Length = 0;
					this.Data = new byte[0];
				}
				public void Read(BinaryReader BR)
				{
					this.Signature = Encoding.ASCII.GetString(BR.ReadBytes(4));
					this.Length = Util.SwapUInt32(BR.ReadUInt32());
					this.Data = BR.ReadBytes((int)this.Length);
				}
				public void Write(BinaryWriter BW)
				{
					BW.Write(Encoding.ASCII.GetBytes(this.Signature));
					BW.Write(Util.SwapUInt32(this.Length));
					BW.Write(this.Data);
				}
			}

			public HeaderClass Header;
			public TrackClass Track;

			public uint LastDeltaTime;
			public uint Duration;

			public Data[] TheData;

			public void Create()
			{
				this.Header = new HeaderClass();
				this.Header.Create();

				this.Track = new TrackClass();
				this.Track.Create();
			}

			public void Load(byte[] Data)
			{
				MemoryStream MS = new MemoryStream(Data);
				BinaryReader BR = new BinaryReader(MS);

				this.Header = new HeaderClass();
				this.Header.Read(BR);

				this.Track = new TrackClass();
				this.Track.Read(BR);

				BR.Close();
				MS.Close();

				Parse();
			}
			public void Load(string Filename)
			{
				Load(File.ReadAllBytes(Filename));
			}

			public byte[] Save()
			{
				Build();

				MemoryStream MS = new MemoryStream();
				BinaryWriter BW = new BinaryWriter(MS);

				this.Header.Write(BW);
				this.Track.Write(BW);

				byte[] Result = MS.ToArray();

				BW.Close();
				MS.Close();

				return Result;
			}
			public void Save(string Filename)
			{
				File.WriteAllBytes(Filename, Save());
			}

			public void Parse()
			{
				List<Data> DataList = new List<Data>();

				MemoryStream MS = new MemoryStream(this.Track.Data);
				BinaryReader BR = new BinaryReader(MS);

				for (int I = 0; I < this.Track.Length; I++)
				{
					uint DeltaTime = Util.DeltaTimeFromBytes(Util.ReadDeltaTime(BR));
					byte Event = BR.ReadByte();

					if (Event == 0xFF)
					{
						byte MetaEvent = BR.ReadByte();

						if (MetaEvent == 0x2F)
						{
							this.LastDeltaTime = DeltaTime;
							break;
						}
						if (MetaEvent == 0x7F)
						{
							uint SysExLength = Util.DeltaTimeFromBytes(Util.ReadDeltaTime(BR));
							byte[] SysExData = BR.ReadBytes((int)SysExLength);
							DataList.Add(new Data(DeltaTime, SysExData[3], SysExData[4]));
						}
					}
				}

				BR.Close();
				MS.Close();

				this.TheData = DataList.ToArray();
			}
			public void Build()
			{
				List<byte> TrackData = new List<byte>();

				if (this.TheData != null)
				{
					for (int I2 = 0; I2 < this.TheData.Length; I2++)
					{
						TrackData.AddRange(Util.DeltaTimeToBytes(this.TheData[I2].DeltaTime));
						TrackData.AddRange(new byte[] { 0xFF, 0x7F, 0x07, 0x43, 0x7B, 0x01, this.TheData[I2].Value1, this.TheData[I2].Value2, this.TheData[I2].Value1, this.TheData[I2].Value2 });
					}

					TrackData.AddRange(Util.DeltaTimeToBytes(this.LastDeltaTime));
					TrackData.AddRange(new byte[] { 0xFF, 0x2F, 0x00 });
				}

				this.Track.Data = TrackData.ToArray();
				this.Track.Length = (uint)this.Track.Data.Length;
			}

			public class Data
			{
				public uint DeltaTime;
				public byte Value1;
				public byte Value2;

				public Data(uint DeltaTime, byte Value1, byte Value2)
				{
					this.DeltaTime = DeltaTime;
					this.Value1 = Value1;
					this.Value2 = Value2;
				}
			}
			public class Util
			{
				public static ushort SwapUInt16(ushort Wert)
				{
					byte Byte1 = (byte)(Wert % 256);
					byte Byte2 = (byte)(Wert / 256 % 256);
					return (ushort)(Byte1 * 256 + Byte2);
				}
				public static uint SwapUInt32(uint Wert)
				{
					byte Byte1 = (byte)(Wert % 256);
					byte Byte2 = (byte)(Wert / 256 % 256);
					byte Byte3 = (byte)(Wert / 65536 % 256);
					byte Byte4 = (byte)(Wert / 16777216 % 256);
					return (uint)(Byte1 * 16777216 + Byte2 * 65536 + Byte3 * 256 + Byte4);
				}

				public static byte GetLowByte(byte Value)
				{
					return (byte)(Value & 0x0F);
				}
				public static byte GetHighByte(byte Value)
				{
					return (byte)(Value & 0xF0);
				}

				public static byte[] ReadDeltaTime(BinaryReader BR)
				{
					List<byte> NewList = new List<byte>();
					for (int I = 0; I < 4; I++)
					{
						byte NewByte = BR.ReadByte();
						NewList.Add(NewByte);
						if (NewByte <= 0x7F) { break; }
					}
					return NewList.ToArray();
				}
				public static uint DeltaTimeFromBytes(byte[] DeltaTimeBytes)
				{
					uint DeltaTime = 0;
					for (int I = 0; I < DeltaTimeBytes.Length; I++)
					{
						if (DeltaTimeBytes[I] <= 0x7F)
						{
							DeltaTime = DeltaTime + DeltaTimeBytes[I];
							break;
						}
						DeltaTime = (uint)(DeltaTime * 0x80 + (DeltaTimeBytes[I] - 0x80) * 0x80);
					}
					return DeltaTime;
				}
				public static byte[] DeltaTimeToBytes(uint DeltaTimeValue)
				{
					byte Byte1 = (byte)(DeltaTimeValue / 2097152 % 128);
					byte Byte2 = (byte)(DeltaTimeValue / 16384 % 128);
					byte Byte3 = (byte)(DeltaTimeValue / 128 % 128);
					byte Byte4 = (byte)(DeltaTimeValue % 128);

					if (Byte1 > 0) { return new byte[] { (byte)(Byte1 + 0x80), (byte)(Byte2 + 0x80), (byte)(Byte3 + 0x80), Byte4 }; }
					if (Byte2 > 0) { return new byte[] { (byte)(Byte2 + 0x80), (byte)(Byte3 + 0x80), Byte4 }; }
					if (Byte3 > 0) { return new byte[] { (byte)(Byte3 + 0x80), Byte4 }; }
					return new byte[] { Byte4 };
				}
			}
		}
	}
}

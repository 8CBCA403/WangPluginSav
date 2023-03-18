using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace XYORAS_Safari_Mirage_Tool;

public class MainForm : Form
{
	private int game;

	private string linkfile;

	private byte[] savebuffer_XY = new byte[415232];

	private byte[] savebuffer_ORAS = new byte[483328];

	private byte[] linkbuffer = new byte[2631];

	private int[] mirage_slots = new int[10];

	private int pss_slot;

	private Button loadsave;

	private TextBox savegamename;

	private TextBox currgame;

	private Label label35;

	private NumericUpDown ev_5;

	private NumericUpDown ev_4;

	private NumericUpDown ev_3;

	private NumericUpDown ev_2;

	private NumericUpDown ev_1;

	private NumericUpDown ev_0;

	private GroupBox groupBox7;

	private Button unlock_safari;

	private ComboBox comboBox2;

	private Label label2;

	private GroupBox orasbox;

	private GroupBox mdv_box;

	private Label u32;

	private Label label3;

	private Label u16;

	private NumericUpDown tid_hi;

	private Label label4;

	private NumericUpDown tid_lo;

	private NumericUpDown mdv3;

	private NumericUpDown mdv0;

	private NumericUpDown mdv2;

	private NumericUpDown mdv1;

	private Button mdv_advanced;

	private Button infobut;

	private Button oras_save;

	private Label spot8;

	private Label spot7;

	private Label spot6;

	private Label spot5;

	private Label spot4;

	private Label spot3;

	private Label spot2;

	private Label spot1;

	private Label spot0;

	private Label spot9;

	private Panel panel_info;

	private Label label5;

	private Label label6;

	private Button close_info;

	private Label label7;

	private GroupBox groupBox1;

	private RadioButton but8;

	private RadioButton but7;

	private RadioButton but6;

	private RadioButton but5;

	private RadioButton but4;

	private RadioButton but3;

	private RadioButton but2;

	private RadioButton but1;

	private RadioButton but0;

	private RadioButton but9;

	public MainForm()
	{
		InitializeComponent();
		base.Size = new Size(755, 270);
	}

	public static byte[] ccitt16(byte[] data)
	{
		int num = data.Length;
		ushort num2 = ushort.MaxValue;
		for (uint num3 = 0u; num3 < num; num3++)
		{
			num2 = (ushort)(num2 ^ (ushort)((uint)(data[num3] << 8) & 0xFFFFu));
			for (uint num4 = 0u; num4 < 8; num4++)
			{
				num2 = (((num2 & 0x8000) <= 0) ? ((ushort)(num2 << 1)) : ((ushort)(((ushort)((uint)(num2 << 1) & 0xFFFFu) ^ 0x1021u) & 0xFFFFu)));
			}
		}
		return BitConverter.GetBytes(num2);
	}

	public static void ReadWholeArray(Stream stream, byte[] data)
	{
		int num = 0;
		int num2 = data.Length;
		while (num2 > 0)
		{
			int num3 = stream.Read(data, num, num2);
			if (num3 <= 0)
			{
				throw new EndOfStreamException($"End of stream reached with {num2} bytes left to read");
			}
			num2 -= num3;
			num += num3;
		}
	}

	private void Read_data()
	{
		FileStream fileStream = new FileStream(savegamename.Text, FileMode.Open);
		if (fileStream.Length != 415232 && fileStream.Length != 483328)
		{
			savegamename.Text = "";
			MessageBox.Show("Invalid file length", "Error");
		}
		else if (fileStream.Length == 415232)
		{
			game = 1;
			currgame.Text = "X/Y";
			ReadWholeArray(fileStream, savebuffer_XY);
			fileStream.Close();
			unlock_safari.Enabled = true;
			orasbox.Enabled = false;
		}
		else if (fileStream.Length == 483328)
		{
			game = 2;
			currgame.Text = "OR/AS";
			ReadWholeArray(fileStream, savebuffer_ORAS);
			tid_lo.Value = savebuffer_ORAS[81920];
			tid_hi.Value = savebuffer_ORAS[81921];
			update_tid();
			mdv0.Value = savebuffer_ORAS[5632];
			mdv1.Value = savebuffer_ORAS[5633];
			mdv2.Value = savebuffer_ORAS[5634];
			mdv3.Value = savebuffer_ORAS[5635];
			update_mdv();
			pss_slot = 0;
			int num = 0;
			for (num = 0; num < 10; num++)
			{
				mirage_slots[num] = savebuffer_ORAS[198612 + num * 4];
			}
			update_mirages();
			savebuffer_ORAS.Skip(135167).Take(2631).ToArray()
				.CopyTo(linkbuffer, 0);
			fileStream.Close();
			unlock_safari.Enabled = false;
			orasbox.Enabled = true;
		}
	}

	private void Get_save_data()
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "VI gen save data|main|All Files (*.*)|*.*";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			savegamename.Text = openFileDialog.FileName;
			Read_data();
		}
	}

	private void Save_data()
	{
		if (savegamename.Text.Length < 1)
		{
			return;
		}
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "VI gen save data|main|All Files (*.*)|*.*";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
			if (game == 1)
			{
				fileStream.Write(savebuffer_XY, 0, savebuffer_XY.Length);
			}
			else if (game == 2)
			{
				fileStream.Write(savebuffer_ORAS, 0, savebuffer_ORAS.Length);
			}
			fileStream.Close();
			MessageBox.Show("File Saved.", "Save file");
		}
	}

	private void Dump_link_data()
	{
		if (savegamename.Text.Length < 1)
		{
			return;
		}
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "Pokémon Link Data|*.bin|All Files (*.*)|*.*";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
			if (game == 1)
			{
				fileStream.Write(savebuffer_XY, 131071, 2631);
			}
			else if (game == 2)
			{
				fileStream.Write(savebuffer_ORAS, 135167, 2631);
			}
			fileStream.Close();
			MessageBox.Show("Pokémon Link data dumped to:\r" + saveFileDialog.FileName + ".");
		}
	}

	private void Read_link_data()
	{
		FileStream fileStream = new FileStream(linkfile, FileMode.Open);
		if (fileStream.Length != 2631)
		{
			MessageBox.Show("Invalid file length", "Error");
			return;
		}
		ReadWholeArray(fileStream, linkbuffer);
		fileStream.Close();
		InjectNsave();
	}

	private void Get_link_data()
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Pokémon Link Data|*.bin|All Files (*.*)|*.*";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			linkfile = openFileDialog.FileName;
			Read_link_data();
		}
	}

	private void InjectNsave()
	{
		if (game == 1)
		{
			for (int i = 1; i < 101; i++)
			{
				if (savebuffer_XY[124927 + 21 * i] != 0)
				{
					savebuffer_XY[124927 + 21 * i] = 61;
				}
			}
			byte[] array = new byte[2100];
			Array.Copy(savebuffer_XY, 124928, array, 0, 2100);
			byte[] array2 = new byte[2];
			array2 = ccitt16(array);
			Array.Copy(array2, 0, savebuffer_XY, 415106, 2);
		}
		else if (game == 2)
		{
			Array.Copy(linkbuffer, 0, savebuffer_ORAS, 135167, 2631);
			savebuffer_ORAS[81920] = (byte)tid_lo.Value;
			savebuffer_ORAS[81921] = (byte)tid_hi.Value;
			byte[] array3 = new byte[368];
			Array.Copy(savebuffer_ORAS, 81920, array3, 0, 368);
			byte[] array4 = new byte[2];
			array4 = ccitt16(array3);
			Array.Copy(array4, 0, savebuffer_ORAS, 482978, 2);
			savebuffer_ORAS[5632] = (byte)mdv0.Value;
			savebuffer_ORAS[5633] = (byte)mdv1.Value;
			savebuffer_ORAS[5634] = (byte)mdv2.Value;
			savebuffer_ORAS[5635] = (byte)mdv3.Value;
			byte[] array5 = new byte[4];
			Array.Copy(savebuffer_ORAS, 5632, array5, 0, 4);
			array4 = ccitt16(array5);
			Array.Copy(array4, 0, savebuffer_ORAS, 482882, 2);
			int num = 0;
			for (num = 0; num < 10; num++)
			{
				savebuffer_ORAS[198612 + num * 4] = (byte)mirage_slots[num];
			}
			byte[] array6 = new byte[30896];
			Array.Copy(savebuffer_ORAS, 177664, array6, 0, 30896);
			array4 = ccitt16(array6);
			Array.Copy(array4, 0, savebuffer_ORAS, 483282, 2);
		}
		Save_data();
	}

	private void LoadsaveClick(object sender, EventArgs e)
	{
		Get_save_data();
	}

	private void Dump_butClick(object sender, EventArgs e)
	{
		if (savegamename.Text.Length >= 1)
		{
			Dump_link_data();
		}
	}

	private void SavegamenameTextChanged(object sender, EventArgs e)
	{
		if (savegamename.Text.Length > 0)
		{
			if (game == 1)
			{
				unlock_safari.Enabled = true;
			}
		}
		else
		{
			unlock_safari.Enabled = false;
		}
	}

	private void Inject_butClick(object sender, EventArgs e)
	{
		Get_link_data();
	}

	private void Mdv_advancedClick(object sender, EventArgs e)
	{
		GroupBox groupBox = mdv_box;
		groupBox.Visible = !groupBox.Visible;
		if (!mdv_box.Visible)
		{
			base.Size = new Size(755, 270);
		}
		else
		{
			base.Size = new Size(755, 394);
		}
	}

	private void GroupBox1Enter(object sender, EventArgs e)
	{
	}

	private void InfobutClick(object sender, EventArgs e)
	{
		panel_info.Visible = true;
		base.Size = new Size(755, 532);
	}

	private void Oras_saveClick(object sender, EventArgs e)
	{
		InjectNsave();
	}

	private void Unlock_safariClick(object sender, EventArgs e)
	{
		InjectNsave();
	}

	private void update_tid()
	{
		u16.Text = ((ushort)((ushort)tid_lo.Value | ((ushort)tid_hi.Value << 8))).ToString("00000") + "   (u16)\n0x" + ((ushort)((ushort)tid_lo.Value | ((ushort)tid_hi.Value << 8))).ToString("X4") + "  (hex) ";
	}

	private void Tid_hiValueChanged(object sender, EventArgs e)
	{
		update_tid();
	}

	private void Tid_loValueChanged(object sender, EventArgs e)
	{
		update_tid();
	}

	private void update_mdv()
	{
		u32.Text = ((uint)mdv0.Value | ((uint)mdv1.Value << 8) | ((uint)mdv2.Value << 16) | ((uint)mdv3.Value << 24)).ToString("0000000000") + "  (u32)\n0x" + ((uint)mdv0.Value | ((uint)mdv1.Value << 8) | ((uint)mdv2.Value << 16) | ((uint)mdv3.Value << 24)).ToString("X8") + "  (hex) ";
	}

	private void Mdv0ValueChanged(object sender, EventArgs e)
	{
		update_mdv();
	}

	private void Mdv1ValueChanged(object sender, EventArgs e)
	{
		update_mdv();
	}

	private void Mdv2ValueChanged(object sender, EventArgs e)
	{
		update_mdv();
	}

	private void Mdv3ValueChanged(object sender, EventArgs e)
	{
		update_mdv();
	}

	private void update_mirages()
	{
		spot0.Text = mirage_slots[0].ToString("00");
		spot1.Text = mirage_slots[1].ToString("00");
		spot2.Text = mirage_slots[2].ToString("00");
		spot3.Text = mirage_slots[3].ToString("00");
		spot4.Text = mirage_slots[4].ToString("00");
		spot5.Text = mirage_slots[5].ToString("00");
		spot6.Text = mirage_slots[6].ToString("00");
		spot7.Text = mirage_slots[7].ToString("00");
		spot8.Text = mirage_slots[8].ToString("00");
		spot9.Text = mirage_slots[9].ToString("00");
		comboBox2.SelectedIndex = mirage_slots[pss_slot];
	}

	private void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
	{
		mirage_slots[pss_slot] = comboBox2.SelectedIndex;
		update_mirages();
	}

	private void Close_infoClick(object sender, EventArgs e)
	{
		panel_info.Visible = false;
		if (!mdv_box.Visible)
		{
			base.Size = new Size(755, 270);
		}
		else
		{
			base.Size = new Size(755, 394);
		}
	}

	private void update_radio()
	{
		if (but0.Checked)
		{
			pss_slot = 0;
		}
		else if (but1.Checked)
		{
			pss_slot = 1;
		}
		else if (but2.Checked)
		{
			pss_slot = 2;
		}
		else if (but3.Checked)
		{
			pss_slot = 3;
		}
		else if (but4.Checked)
		{
			pss_slot = 4;
		}
		else if (but5.Checked)
		{
			pss_slot = 5;
		}
		else if (but6.Checked)
		{
			pss_slot = 6;
		}
		else if (but7.Checked)
		{
			pss_slot = 7;
		}
		else if (but8.Checked)
		{
			pss_slot = 8;
		}
		else if (but9.Checked)
		{
			pss_slot = 9;
		}
		else
		{
			pss_slot = 0;
		}
		comboBox2.SelectedIndex = mirage_slots[pss_slot];
	}

	private void But0CheckedChanged(object sender, EventArgs e)
	{
		update_radio();
	}

	private void But1CheckedChanged(object sender, EventArgs e)
	{
		update_radio();
	}

	private void But2CheckedChanged(object sender, EventArgs e)
	{
		update_radio();
	}

	private void But3CheckedChanged(object sender, EventArgs e)
	{
		update_radio();
	}

	private void But4CheckedChanged(object sender, EventArgs e)
	{
		update_radio();
	}

	private void But5CheckedChanged(object sender, EventArgs e)
	{
		update_radio();
	}

	private void But6CheckedChanged(object sender, EventArgs e)
	{
		update_radio();
	}

	private void But7CheckedChanged(object sender, EventArgs e)
	{
		update_radio();
	}

	private void But8CheckedChanged(object sender, EventArgs e)
	{
		update_radio();
	}

	private void But9CheckedChanged(object sender, EventArgs e)
	{
		update_radio();
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XYORAS_Safari_Mirage_Tool.MainForm));
		this.loadsave = new System.Windows.Forms.Button();
		this.savegamename = new System.Windows.Forms.TextBox();
		this.currgame = new System.Windows.Forms.TextBox();
		this.label35 = new System.Windows.Forms.Label();
		this.ev_5 = new System.Windows.Forms.NumericUpDown();
		this.ev_4 = new System.Windows.Forms.NumericUpDown();
		this.ev_3 = new System.Windows.Forms.NumericUpDown();
		this.ev_2 = new System.Windows.Forms.NumericUpDown();
		this.ev_1 = new System.Windows.Forms.NumericUpDown();
		this.ev_0 = new System.Windows.Forms.NumericUpDown();
		this.groupBox7 = new System.Windows.Forms.GroupBox();
		this.unlock_safari = new System.Windows.Forms.Button();
		this.comboBox2 = new System.Windows.Forms.ComboBox();
		this.label2 = new System.Windows.Forms.Label();
		this.orasbox = new System.Windows.Forms.GroupBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.spot9 = new System.Windows.Forms.Label();
		this.but9 = new System.Windows.Forms.RadioButton();
		this.oras_save = new System.Windows.Forms.Button();
		this.mdv_advanced = new System.Windows.Forms.Button();
		this.spot8 = new System.Windows.Forms.Label();
		this.but8 = new System.Windows.Forms.RadioButton();
		this.spot7 = new System.Windows.Forms.Label();
		this.but7 = new System.Windows.Forms.RadioButton();
		this.spot6 = new System.Windows.Forms.Label();
		this.but6 = new System.Windows.Forms.RadioButton();
		this.but5 = new System.Windows.Forms.RadioButton();
		this.spot5 = new System.Windows.Forms.Label();
		this.but4 = new System.Windows.Forms.RadioButton();
		this.spot4 = new System.Windows.Forms.Label();
		this.but3 = new System.Windows.Forms.RadioButton();
		this.spot3 = new System.Windows.Forms.Label();
		this.but2 = new System.Windows.Forms.RadioButton();
		this.spot2 = new System.Windows.Forms.Label();
		this.but1 = new System.Windows.Forms.RadioButton();
		this.spot1 = new System.Windows.Forms.Label();
		this.but0 = new System.Windows.Forms.RadioButton();
		this.spot0 = new System.Windows.Forms.Label();
		this.mdv_box = new System.Windows.Forms.GroupBox();
		this.infobut = new System.Windows.Forms.Button();
		this.u32 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.u16 = new System.Windows.Forms.Label();
		this.tid_hi = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.tid_lo = new System.Windows.Forms.NumericUpDown();
		this.mdv3 = new System.Windows.Forms.NumericUpDown();
		this.mdv0 = new System.Windows.Forms.NumericUpDown();
		this.mdv2 = new System.Windows.Forms.NumericUpDown();
		this.mdv1 = new System.Windows.Forms.NumericUpDown();
		this.panel_info = new System.Windows.Forms.Panel();
		this.close_info = new System.Windows.Forms.Button();
		this.label5 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.ev_5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev_4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev_3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev_2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev_1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev_0).BeginInit();
		this.groupBox7.SuspendLayout();
		this.orasbox.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.mdv_box.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tid_hi).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.tid_lo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.mdv3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.mdv0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.mdv2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.mdv1).BeginInit();
		this.panel_info.SuspendLayout();
		base.SuspendLayout();
		this.loadsave.Location = new System.Drawing.Point(20, 26);
		this.loadsave.Name = "loadsave";
		this.loadsave.Size = new System.Drawing.Size(162, 23);
		this.loadsave.TabIndex = 0;
		this.loadsave.Text = "Load XY/ORAS Savegame";
		this.loadsave.UseVisualStyleBackColor = true;
		this.loadsave.Click += new System.EventHandler(LoadsaveClick);
		this.savegamename.Location = new System.Drawing.Point(20, 55);
		this.savegamename.Name = "savegamename";
		this.savegamename.Size = new System.Drawing.Size(330, 20);
		this.savegamename.TabIndex = 1;
		this.currgame.Location = new System.Drawing.Point(188, 28);
		this.currgame.Name = "currgame";
		this.currgame.ReadOnly = true;
		this.currgame.Size = new System.Drawing.Size(73, 20);
		this.currgame.TabIndex = 5;
		this.currgame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label35.Location = new System.Drawing.Point(1135, 218);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(37, 23);
		this.label35.TabIndex = 102;
		this.label35.Text = "EVs";
		this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ev_5.Location = new System.Drawing.Point(1135, 351);
		this.ev_5.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev_5.Name = "ev_5";
		this.ev_5.Size = new System.Drawing.Size(37, 20);
		this.ev_5.TabIndex = 101;
		this.ev_4.Location = new System.Drawing.Point(1135, 329);
		this.ev_4.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev_4.Name = "ev_4";
		this.ev_4.Size = new System.Drawing.Size(37, 20);
		this.ev_4.TabIndex = 100;
		this.ev_3.Location = new System.Drawing.Point(1135, 307);
		this.ev_3.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev_3.Name = "ev_3";
		this.ev_3.Size = new System.Drawing.Size(37, 20);
		this.ev_3.TabIndex = 99;
		this.ev_2.Location = new System.Drawing.Point(1135, 285);
		this.ev_2.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev_2.Name = "ev_2";
		this.ev_2.Size = new System.Drawing.Size(37, 20);
		this.ev_2.TabIndex = 98;
		this.ev_1.Location = new System.Drawing.Point(1135, 263);
		this.ev_1.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev_1.Name = "ev_1";
		this.ev_1.Size = new System.Drawing.Size(37, 20);
		this.ev_1.TabIndex = 97;
		this.ev_0.Location = new System.Drawing.Point(1135, 241);
		this.ev_0.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev_0.Name = "ev_0";
		this.ev_0.Size = new System.Drawing.Size(37, 20);
		this.ev_0.TabIndex = 96;
		this.groupBox7.Controls.Add(this.currgame);
		this.groupBox7.Controls.Add(this.savegamename);
		this.groupBox7.Controls.Add(this.loadsave);
		this.groupBox7.Location = new System.Drawing.Point(18, 12);
		this.groupBox7.Name = "groupBox7";
		this.groupBox7.Size = new System.Drawing.Size(365, 89);
		this.groupBox7.TabIndex = 143;
		this.groupBox7.TabStop = false;
		this.groupBox7.Text = "Savegame";
		this.unlock_safari.Enabled = false;
		this.unlock_safari.Location = new System.Drawing.Point(403, 40);
		this.unlock_safari.Name = "unlock_safari";
		this.unlock_safari.Size = new System.Drawing.Size(103, 36);
		this.unlock_safari.TabIndex = 144;
		this.unlock_safari.Text = "Unlock all Friend Safari (XY only)";
		this.unlock_safari.UseVisualStyleBackColor = true;
		this.unlock_safari.Click += new System.EventHandler(Unlock_safariClick);
		this.comboBox2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comboBox2.FormattingEnabled = true;
		this.comboBox2.Items.AddRange(new object[34]
		{
			"00: NONE", "01: 467 - Crescent Isle           - Cresselia", "02: 184 - East of Mossdeep        - Tangela, Sunkern, Glameow, Minccino", "03: 185 - North of Route 124      - Tangela, Sunkern, Purugly, Vulpix", "04: 186 - West of Route 114       - Tangela, Sunkern, Purugly, Petilil", "05: 187 - North of Lilycove       - Tangela, Sunkern, Purugly, Cherrim", "06: 188 - South of Route 132      - Sunkern, Petilil, Audino", "07: 189 - West of Route 105       - Forretress, Happiny", "08: 190 - South of Route 109      - Audino, Sunkern", "09: 191 - North of Route 111      - Kricketune, Larvesta",
			"10: 192 - West of Rustboro        - Tynamo, Klink, Boldore, Graveler", "11: 193 - North of Fortree        - Klink, Tynamo, Excadrill, Onix", "12: 194 - South of Pacifidlog     - Tynamo, Cofagrigus, Slowpoke", "13: 195 - South of Route 107      - Unown", "14: 196 - North of Route 124      - Klink, Cofagrigus, Graveler, Boldore", "15: 197 - North of Route 132      - Ditto, Excadrill, Tynamo", "16: 198 - Southeast of Route 129  - Tynamo, Onix, Graveler, Boldore", "17: 199 - North of Fallarbor      - Slowpoke, Tynamo", "18: 200 - West of Route 104       - Venomoth, Xatu, Zebstrika, Darmanitan", "19: 201 - South of Route 134      - Venomoth, Xatu, Zebstrika, Maractus",
			"20: 202 - North of Route 124      - Venomoth, Xatu, Zebstrika, Persian", "21: 203 - West of Dewford Town    - Venomoth, Xatu, Zebstrika, Tangela", "22: 204 - South of Pacifidlog     - Audino, Xatu", "23: 205 - South of Route 132      - Munna, Ditto", "24: 206 - North of Route 113      - Darmanitan, Larvesta", "25: 207 - East of Shoal Cave      - Purugly, Porygon", "26: 208 - West of Route 104       - Forretress, Donphan, Kricketune, Stantler", "27: 460 - North of Lilycove       - Forretress, Donphan, Kricketune, Rufflet", "28: 461 - Northeast of Route 125  - Forretress, Donphan, Kricketune, Vullaby", "29: 462 - West of Route 131       - Donphan, Kricketune, Girafarig",
			"30: 463 - North of Mossdeep       - Magby, Darmanitan", "31: 464 - South of Route 129      - Zebstrika, Elekid", "32: 465 - Southeast of Route 129  - Porygon, Xatu, Munna", "33: 466 - East of Mossdeep        - Audino, Happiny, Tangela"
		});
		this.comboBox2.Location = new System.Drawing.Point(102, 72);
		this.comboBox2.Name = "comboBox2";
		this.comboBox2.Size = new System.Drawing.Size(566, 20);
		this.comboBox2.TabIndex = 147;
		this.comboBox2.SelectedIndexChanged += new System.EventHandler(ComboBox2SelectedIndexChanged);
		this.label2.Location = new System.Drawing.Point(12, 74);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(88, 19);
		this.label2.TabIndex = 148;
		this.label2.Text = "Mirage Spot:";
		this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.orasbox.Controls.Add(this.groupBox1);
		this.orasbox.Controls.Add(this.mdv_box);
		this.orasbox.Enabled = false;
		this.orasbox.Location = new System.Drawing.Point(18, 116);
		this.orasbox.Name = "orasbox";
		this.orasbox.Size = new System.Drawing.Size(710, 230);
		this.orasbox.TabIndex = 149;
		this.orasbox.TabStop = false;
		this.orasbox.Text = "OR/AS Mirage Spot";
		this.orasbox.Enter += new System.EventHandler(GroupBox1Enter);
		this.groupBox1.Controls.Add(this.spot9);
		this.groupBox1.Controls.Add(this.but9);
		this.groupBox1.Controls.Add(this.oras_save);
		this.groupBox1.Controls.Add(this.mdv_advanced);
		this.groupBox1.Controls.Add(this.spot8);
		this.groupBox1.Controls.Add(this.but8);
		this.groupBox1.Controls.Add(this.spot7);
		this.groupBox1.Controls.Add(this.but7);
		this.groupBox1.Controls.Add(this.spot6);
		this.groupBox1.Controls.Add(this.but6);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.but5);
		this.groupBox1.Controls.Add(this.spot5);
		this.groupBox1.Controls.Add(this.but4);
		this.groupBox1.Controls.Add(this.spot4);
		this.groupBox1.Controls.Add(this.but3);
		this.groupBox1.Controls.Add(this.spot3);
		this.groupBox1.Controls.Add(this.but2);
		this.groupBox1.Controls.Add(this.spot2);
		this.groupBox1.Controls.Add(this.but1);
		this.groupBox1.Controls.Add(this.spot1);
		this.groupBox1.Controls.Add(this.but0);
		this.groupBox1.Controls.Add(this.spot0);
		this.groupBox1.Controls.Add(this.comboBox2);
		this.groupBox1.Location = new System.Drawing.Point(8, 15);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(689, 100);
		this.groupBox1.TabIndex = 195;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "PSS Mirage Spot";
		this.groupBox1.Enter += new System.EventHandler(GroupBox1Enter);
		this.spot9.Location = new System.Drawing.Point(502, 49);
		this.spot9.Name = "spot9";
		this.spot9.Size = new System.Drawing.Size(22, 18);
		this.spot9.TabIndex = 173;
		this.spot9.Text = "01";
		this.but9.Location = new System.Drawing.Point(494, 24);
		this.but9.Name = "but9";
		this.but9.Size = new System.Drawing.Size(46, 17);
		this.but9.TabIndex = 194;
		this.but9.Text = "09";
		this.but9.UseVisualStyleBackColor = true;
		this.but9.CheckedChanged += new System.EventHandler(But9CheckedChanged);
		this.oras_save.Location = new System.Drawing.Point(6, 32);
		this.oras_save.Name = "oras_save";
		this.oras_save.Size = new System.Drawing.Size(75, 23);
		this.oras_save.TabIndex = 163;
		this.oras_save.Text = "Save";
		this.oras_save.UseVisualStyleBackColor = true;
		this.oras_save.Click += new System.EventHandler(Oras_saveClick);
		this.mdv_advanced.Location = new System.Drawing.Point(550, 24);
		this.mdv_advanced.Name = "mdv_advanced";
		this.mdv_advanced.Size = new System.Drawing.Size(118, 39);
		this.mdv_advanced.TabIndex = 149;
		this.mdv_advanced.Text = "Daily Mirage Spot (advanced)";
		this.mdv_advanced.UseVisualStyleBackColor = true;
		this.mdv_advanced.Click += new System.EventHandler(Mdv_advancedClick);
		this.spot8.Location = new System.Drawing.Point(452, 49);
		this.spot8.Name = "spot8";
		this.spot8.Size = new System.Drawing.Size(22, 18);
		this.spot8.TabIndex = 172;
		this.spot8.Text = "01";
		this.but8.Location = new System.Drawing.Point(447, 24);
		this.but8.Name = "but8";
		this.but8.Size = new System.Drawing.Size(46, 17);
		this.but8.TabIndex = 189;
		this.but8.Text = "08";
		this.but8.UseVisualStyleBackColor = true;
		this.but8.CheckedChanged += new System.EventHandler(But8CheckedChanged);
		this.spot7.Location = new System.Drawing.Point(414, 49);
		this.spot7.Name = "spot7";
		this.spot7.Size = new System.Drawing.Size(22, 18);
		this.spot7.TabIndex = 171;
		this.spot7.Text = "01";
		this.but7.Location = new System.Drawing.Point(409, 24);
		this.but7.Name = "but7";
		this.but7.Size = new System.Drawing.Size(46, 17);
		this.but7.TabIndex = 193;
		this.but7.Text = "07";
		this.but7.UseVisualStyleBackColor = true;
		this.but7.CheckedChanged += new System.EventHandler(But7CheckedChanged);
		this.spot6.Location = new System.Drawing.Point(373, 49);
		this.spot6.Name = "spot6";
		this.spot6.Size = new System.Drawing.Size(22, 18);
		this.spot6.TabIndex = 170;
		this.spot6.Text = "01";
		this.but6.Location = new System.Drawing.Point(367, 24);
		this.but6.Name = "but6";
		this.but6.Size = new System.Drawing.Size(46, 17);
		this.but6.TabIndex = 188;
		this.but6.Text = "06";
		this.but6.UseVisualStyleBackColor = true;
		this.but6.CheckedChanged += new System.EventHandler(But6CheckedChanged);
		this.but5.Location = new System.Drawing.Point(328, 24);
		this.but5.Name = "but5";
		this.but5.Size = new System.Drawing.Size(46, 17);
		this.but5.TabIndex = 192;
		this.but5.Text = "05";
		this.but5.UseVisualStyleBackColor = true;
		this.but5.CheckedChanged += new System.EventHandler(But5CheckedChanged);
		this.spot5.Location = new System.Drawing.Point(334, 49);
		this.spot5.Name = "spot5";
		this.spot5.Size = new System.Drawing.Size(22, 18);
		this.spot5.TabIndex = 169;
		this.spot5.Text = "01";
		this.but4.Location = new System.Drawing.Point(283, 24);
		this.but4.Name = "but4";
		this.but4.Size = new System.Drawing.Size(46, 17);
		this.but4.TabIndex = 187;
		this.but4.Text = "04";
		this.but4.UseVisualStyleBackColor = true;
		this.but4.CheckedChanged += new System.EventHandler(But4CheckedChanged);
		this.spot4.Location = new System.Drawing.Point(288, 49);
		this.spot4.Name = "spot4";
		this.spot4.Size = new System.Drawing.Size(22, 18);
		this.spot4.TabIndex = 168;
		this.spot4.Text = "01";
		this.but3.Location = new System.Drawing.Point(236, 24);
		this.but3.Name = "but3";
		this.but3.Size = new System.Drawing.Size(46, 17);
		this.but3.TabIndex = 191;
		this.but3.Text = "03";
		this.but3.UseVisualStyleBackColor = true;
		this.but3.CheckedChanged += new System.EventHandler(But3CheckedChanged);
		this.spot3.Location = new System.Drawing.Point(240, 49);
		this.spot3.Name = "spot3";
		this.spot3.Size = new System.Drawing.Size(22, 18);
		this.spot3.TabIndex = 167;
		this.spot3.Text = "01";
		this.but2.Location = new System.Drawing.Point(192, 24);
		this.but2.Name = "but2";
		this.but2.Size = new System.Drawing.Size(46, 17);
		this.but2.TabIndex = 186;
		this.but2.Text = "02";
		this.but2.UseVisualStyleBackColor = true;
		this.but2.CheckedChanged += new System.EventHandler(But2CheckedChanged);
		this.spot2.Location = new System.Drawing.Point(197, 49);
		this.spot2.Name = "spot2";
		this.spot2.Size = new System.Drawing.Size(22, 18);
		this.spot2.TabIndex = 166;
		this.spot2.Text = "01";
		this.but1.Location = new System.Drawing.Point(148, 24);
		this.but1.Name = "but1";
		this.but1.Size = new System.Drawing.Size(46, 17);
		this.but1.TabIndex = 190;
		this.but1.Text = "01";
		this.but1.UseVisualStyleBackColor = true;
		this.but1.CheckedChanged += new System.EventHandler(But1CheckedChanged);
		this.spot1.Location = new System.Drawing.Point(159, 49);
		this.spot1.Name = "spot1";
		this.spot1.Size = new System.Drawing.Size(22, 18);
		this.spot1.TabIndex = 165;
		this.spot1.Text = "01";
		this.but0.Checked = true;
		this.but0.Location = new System.Drawing.Point(103, 24);
		this.but0.Name = "but0";
		this.but0.Size = new System.Drawing.Size(46, 17);
		this.but0.TabIndex = 185;
		this.but0.TabStop = true;
		this.but0.Text = "00";
		this.but0.UseVisualStyleBackColor = true;
		this.but0.CheckedChanged += new System.EventHandler(But0CheckedChanged);
		this.spot0.Location = new System.Drawing.Point(108, 49);
		this.spot0.Name = "spot0";
		this.spot0.Size = new System.Drawing.Size(22, 18);
		this.spot0.TabIndex = 164;
		this.spot0.Text = "01";
		this.mdv_box.Controls.Add(this.infobut);
		this.mdv_box.Controls.Add(this.u32);
		this.mdv_box.Controls.Add(this.label3);
		this.mdv_box.Controls.Add(this.u16);
		this.mdv_box.Controls.Add(this.tid_hi);
		this.mdv_box.Controls.Add(this.label4);
		this.mdv_box.Controls.Add(this.tid_lo);
		this.mdv_box.Controls.Add(this.mdv3);
		this.mdv_box.Controls.Add(this.mdv0);
		this.mdv_box.Controls.Add(this.mdv2);
		this.mdv_box.Controls.Add(this.mdv1);
		this.mdv_box.Location = new System.Drawing.Point(64, 121);
		this.mdv_box.Name = "mdv_box";
		this.mdv_box.Size = new System.Drawing.Size(553, 94);
		this.mdv_box.TabIndex = 150;
		this.mdv_box.TabStop = false;
		this.mdv_box.Text = "Advanced (direct HEX view)";
		this.mdv_box.Visible = false;
		this.infobut.Location = new System.Drawing.Point(470, 65);
		this.infobut.Name = "infobut";
		this.infobut.Size = new System.Drawing.Size(75, 23);
		this.infobut.TabIndex = 162;
		this.infobut.Text = "Info";
		this.infobut.UseVisualStyleBackColor = true;
		this.infobut.Click += new System.EventHandler(InfobutClick);
		this.u32.Location = new System.Drawing.Point(266, 40);
		this.u32.Name = "u32";
		this.u32.Size = new System.Drawing.Size(198, 48);
		this.u32.TabIndex = 160;
		this.u32.Text = "MDV u32";
		this.label3.Location = new System.Drawing.Point(6, 16);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(45, 19);
		this.label3.TabIndex = 151;
		this.label3.Text = "TID:";
		this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.u16.Location = new System.Drawing.Point(57, 40);
		this.u16.Name = "u16";
		this.u16.Size = new System.Drawing.Size(119, 48);
		this.u16.TabIndex = 159;
		this.u16.Text = "TID u16";
		this.tid_hi.Hexadecimal = true;
		this.tid_hi.Location = new System.Drawing.Point(108, 14);
		this.tid_hi.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.tid_hi.Name = "tid_hi";
		this.tid_hi.Size = new System.Drawing.Size(45, 20);
		this.tid_hi.TabIndex = 152;
		this.tid_hi.ValueChanged += new System.EventHandler(Tid_hiValueChanged);
		this.label4.Location = new System.Drawing.Point(215, 17);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(45, 23);
		this.label4.TabIndex = 158;
		this.label4.Text = "MDV:";
		this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.tid_lo.Hexadecimal = true;
		this.tid_lo.Location = new System.Drawing.Point(57, 14);
		this.tid_lo.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.tid_lo.Name = "tid_lo";
		this.tid_lo.Size = new System.Drawing.Size(45, 20);
		this.tid_lo.TabIndex = 153;
		this.tid_lo.ValueChanged += new System.EventHandler(Tid_loValueChanged);
		this.mdv3.Hexadecimal = true;
		this.mdv3.Location = new System.Drawing.Point(419, 15);
		this.mdv3.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.mdv3.Name = "mdv3";
		this.mdv3.Size = new System.Drawing.Size(45, 20);
		this.mdv3.TabIndex = 157;
		this.mdv3.ValueChanged += new System.EventHandler(Mdv3ValueChanged);
		this.mdv0.Hexadecimal = true;
		this.mdv0.Location = new System.Drawing.Point(266, 15);
		this.mdv0.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.mdv0.Name = "mdv0";
		this.mdv0.Size = new System.Drawing.Size(45, 20);
		this.mdv0.TabIndex = 154;
		this.mdv0.ValueChanged += new System.EventHandler(Mdv0ValueChanged);
		this.mdv2.Hexadecimal = true;
		this.mdv2.Location = new System.Drawing.Point(368, 15);
		this.mdv2.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.mdv2.Name = "mdv2";
		this.mdv2.Size = new System.Drawing.Size(45, 20);
		this.mdv2.TabIndex = 156;
		this.mdv2.ValueChanged += new System.EventHandler(Mdv2ValueChanged);
		this.mdv1.Hexadecimal = true;
		this.mdv1.Location = new System.Drawing.Point(317, 15);
		this.mdv1.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.mdv1.Name = "mdv1";
		this.mdv1.Size = new System.Drawing.Size(45, 20);
		this.mdv1.TabIndex = 155;
		this.mdv1.ValueChanged += new System.EventHandler(Mdv1ValueChanged);
		this.panel_info.Controls.Add(this.close_info);
		this.panel_info.Controls.Add(this.label5);
		this.panel_info.Controls.Add(this.label7);
		this.panel_info.Controls.Add(this.label6);
		this.panel_info.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel_info.Location = new System.Drawing.Point(0, 0);
		this.panel_info.Name = "panel_info";
		this.panel_info.Size = new System.Drawing.Size(739, 494);
		this.panel_info.TabIndex = 0;
		this.panel_info.Visible = false;
		this.close_info.Location = new System.Drawing.Point(657, 460);
		this.close_info.Name = "close_info";
		this.close_info.Size = new System.Drawing.Size(60, 22);
		this.close_info.TabIndex = 2;
		this.close_info.Text = "Close";
		this.close_info.UseVisualStyleBackColor = true;
		this.close_info.Click += new System.EventHandler(Close_infoClick);
		this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.Location = new System.Drawing.Point(12, 87);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(679, 398);
		this.label5.TabIndex = 0;
		this.label5.Text = resources.GetString("label5.Text");
		this.label7.Location = new System.Drawing.Point(12, 40);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(705, 44);
		this.label7.TabIndex = 3;
		this.label7.Text = resources.GetString("label7.Text");
		this.label6.Location = new System.Drawing.Point(12, 9);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(705, 44);
		this.label6.TabIndex = 1;
		this.label6.Text = resources.GetString("label6.Text");
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(739, 494);
		base.Controls.Add(this.panel_info);
		base.Controls.Add(this.orasbox);
		base.Controls.Add(this.unlock_safari);
		base.Controls.Add(this.groupBox7);
		base.Controls.Add(this.label35);
		base.Controls.Add(this.ev_0);
		base.Controls.Add(this.ev_1);
		base.Controls.Add(this.ev_2);
		base.Controls.Add(this.ev_3);
		base.Controls.Add(this.ev_4);
		base.Controls.Add(this.ev_5);
		base.Name = "MainForm";
		this.Text = "XYORAS Safari Mirage Tool 0.1 by suloku";
		((System.ComponentModel.ISupportInitialize)this.ev_5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev_4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev_3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev_2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev_1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev_0).EndInit();
		this.groupBox7.ResumeLayout(false);
		this.groupBox7.PerformLayout();
		this.orasbox.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.mdv_box.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tid_hi).EndInit();
		((System.ComponentModel.ISupportInitialize)this.tid_lo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.mdv3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.mdv0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.mdv2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.mdv1).EndInit();
		this.panel_info.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}

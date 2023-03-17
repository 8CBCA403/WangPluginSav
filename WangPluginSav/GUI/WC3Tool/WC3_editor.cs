using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using PKHeX;

namespace WC3Tool;

public class WC3_editor : Form
{
	public string wc3filter = "Wonder Card file|*.wc3|All Files (*.*)|*.*";

	public string scriptfilter = "Script file|*.script|All Files (*.*)|*.*";

	public string xsescriptfilter = "XSE padded script file|*.gba";

	public byte[] wc3buffer;

	public byte[] wc3script_new;

	public static wc3 wc3file;

	public bool japanese;

	public static bool script_injected;

	private Graphics GFX;

	private ResourceManager resources = new ResourceManager("WC3Tool.WC3.Image.Cards", Assembly.GetExecutingAssembly());

	private ResourceManager resources2 = new ResourceManager("WC3Tool.WC3.Image.Icons", Assembly.GetExecutingAssembly());

	private Image bitmap2;

	private Image bitmap;

	private IContainer components;

	private Button load_wc3_but;

	private Button save_wc3_but;

	private TextBox wc3_path;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label8;

	private TextBox header1;

	private TextBox header2;

	private TextBox body1;

	private TextBox body2;

	private TextBox body3;

	private TextBox body4;

	private TextBox footer1;

	private TextBox footer2;

	private Button export_script_but;

	private Button import_script_but;

	private CheckBox custom_script;

	private ComboBox iconbox;

	private Label label9;

	private ComboBox colorbox;

	private Label label10;

	private NumericUpDown icon_num;

	private RadioButton distro_but_always;

	private GroupBox groupBox1;

	private RadioButton distro_but_one;

	private RadioButton distro_but_no;

	private Label regionlab;

	private Button giveEgg_but;

	private GroupBox groupBox2;

	private Label label13;

	private Label label12;

	private Label label11;

	private NumericUpDown map_npc;

	private NumericUpDown map_map;

	private NumericUpDown map_bank;

	private Label label14;

	private Button map_help;

	private Button xse_import;

	private Button xse_export;

	private Button xse_help;

	private Button giveEggExt_but;

	private CheckBox faketoogle;

	public WC3_editor()
	{
		InitializeComponent();
		faketoogle.Checked = true;
		regionlab.Text = "";
		GFX = CreateGraphics();
		colorbox.SelectedIndex = 0;
		icon_num.Value = 0m;
	}

	private void update_iconbox()
	{
		iconbox.Enabled = true;
		if (icon_num.Value >= 1m && icon_num.Value <= 251m)
		{
			iconbox.SelectedIndex = (ushort)icon_num.Value;
			return;
		}
		if (icon_num.Value >= 251m && icon_num.Value <= 440m)
		{
			iconbox.SelectedIndex = (ushort)icon_num.Value;
			return;
		}
		if (icon_num.Value == 65535m)
		{
			iconbox.SelectedIndex = 0;
			return;
		}
		iconbox.Enabled = false;
		iconbox.SelectedIndex = 440;
	}

	private string fill_line(string line, int index)
	{
		if (japanese)
		{
			if (index != 0)
			{
				if (index == 1)
				{
					while (line.Length < 13)
					{
						line += " ";
					}
				}
				else
				{
					while (line.Length < 20)
					{
						line += " ";
					}
				}
			}
			else
			{
				while (line.Length < 18)
				{
					line += " ";
				}
			}
		}
		else
		{
			while (line.Length < 40)
			{
				line += " ";
			}
		}
		return line;
	}

	private void update_wcdata()
	{
		switch (wc3file.distributable)
		{
		case 0:
			distro_but_no.Checked = true;
			break;
		case 1:
			distro_but_always.Checked = true;
			break;
		case 2:
			distro_but_one.Checked = true;
			break;
		default:
			distro_but_no.Checked = true;
			break;
		}
		icon_num.Value = wc3file.get_wc_icon();
		update_iconbox();
		colorbox.SelectedIndex = wc3file.get_wc_color();
		header1.Text = wc3file.get_wc_text_2(0);
		header2.Text = wc3file.get_wc_text_2(1);
		body1.Text = wc3file.get_wc_text_2(2);
		body2.Text = wc3file.get_wc_text_2(3);
		body3.Text = wc3file.get_wc_text_2(4);
		body4.Text = wc3file.get_wc_text_2(5);
		footer1.Text = wc3file.get_wc_text_2(6);
		footer2.Text = wc3file.get_wc_text_2(7);
		map_bank.Value = wc3file.MAP_BANK;
		map_map.Value = wc3file.MAP_MAP;
		map_npc.Value = wc3file.MAP_NPC;
	}

	private void set_wcdata()
	{
		wc3file.clear_wc_text();
		wc3file.insert_wc_text_2(header1.Text, 0);
		wc3file.insert_wc_text_2(header2.Text, 1);
		wc3file.insert_wc_text_2(body1.Text, 2);
		wc3file.insert_wc_text_2(body2.Text, 3);
		wc3file.insert_wc_text_2(body3.Text, 4);
		wc3file.insert_wc_text_2(body4.Text, 5);
		wc3file.insert_wc_text_2(footer1.Text, 6);
		wc3file.insert_wc_text_2(footer2.Text, 7);
		wc3file.ID = 51;
		wc3file.MAP_BANK = (byte)map_bank.Value;
		wc3file.MAP_MAP = (byte)map_map.Value;
		wc3file.MAP_NPC = (byte)map_npc.Value;
	}

	private void Load_WC3(string path)
	{
		int num = FileIO.load_file(ref wc3buffer, ref path, wc3filter);
		if (num == 1420 || num == 1252)
		{
			if (num == 1252)
			{
				japanese = true;
				regionlab.Text = "JAP";
				header1.MaxLength = 18;
				header2.MaxLength = 13;
				body1.MaxLength = 20;
				body2.MaxLength = 20;
				body3.MaxLength = 20;
				body4.MaxLength = 20;
				footer1.MaxLength = 20;
				footer2.MaxLength = 20;
			}
			else
			{
				japanese = false;
				regionlab.Text = "USA/EUR";
				header1.MaxLength = 40;
				header2.MaxLength = 40;
				body1.MaxLength = 40;
				body2.MaxLength = 40;
				body3.MaxLength = 40;
				body4.MaxLength = 40;
				footer1.MaxLength = 40;
				footer2.MaxLength = 40;
			}
			wc3_path.Text = path;
			wc3file = new wc3(wc3buffer);
			update_wcdata();
			save_wc3_but.Enabled = true;
			export_script_but.Enabled = true;
			import_script_but.Enabled = true;
			xse_export.Enabled = true;
			xse_import.Enabled = true;
			custom_script.Checked = false;
			drawCard();
		}
		else
		{
			MessageBox.Show("Invalid file size.");
		}
	}

	private void Load_wc3_butClick(object sender, EventArgs e)
	{
		Load_WC3(null);
	}

	private void Save_wc3_butClick(object sender, EventArgs e)
	{
		if (faketoogle.Checked)
		{
			wc3file.fakeWC();
		}
		wc3file.set_wc_icon((ushort)icon_num.Value);
		int num = 0;
		num = (distro_but_always.Checked ? 1 : (distro_but_one.Checked ? 2 : 0));
		wc3file.set_wc_color_distro(colorbox.SelectedIndex, num);
		set_wcdata();
		wc3file.fix_script_checksum();
		wc3file.fix_wc_checksum();
		if (wc3file.Edited)
		{
			FileIO.save_data(wc3file.Data, wc3filter);
		}
		else
		{
			MessageBox.Show("Save has not been edited");
		}
	}

	private void Export_script_butClick(object sender, EventArgs e)
	{
		FileIO.save_data(wc3file.get_script(), scriptfilter);
	}

	private void Import_script_butClick(object sender, EventArgs e)
	{
		string path = null;
		if (FileIO.load_file(ref wc3script_new, ref path, scriptfilter) <= 996)
		{
			wc3file.set_script(wc3script_new);
			custom_script.Checked = true;
			MessageBox.Show("Custom script imported.");
		}
		else
		{
			MessageBox.Show("Invalid file size.");
		}
	}

	private void IconboxSelectedIndexChanged(object sender, EventArgs e)
	{
		if (iconbox.SelectedIndex == 0)
		{
			icon_num.Value = 65535m;
		}
		else if (iconbox.SelectedIndex > 251)
		{
			icon_num.Value = iconbox.SelectedIndex;
		}
		else
		{
			icon_num.Value = iconbox.SelectedIndex;
		}
	}

	private void Icon_numValueChanged(object sender, EventArgs e)
	{
		update_iconbox();
		drawCard();
	}

	private void WC3_editorLoad(object sender, EventArgs e)
	{
	}

	private void GiveEgg_butClick(object sender, EventArgs e)
	{
		new WC3_editor_givegg().ShowDialog();
		if (script_injected)
		{
			script_injected = false;
			custom_script.Checked = true;
			MessageBox.Show("Give Egg script injected.");
		}
	}

	private void ColorboxSelectedIndexChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void drawCard()
	{
		bitmap = (Image)resources.GetObject("Card_" + colorbox.SelectedIndex);
		GFX.DrawImage(bitmap, 501, 141, 238, 158);
		if (icon_num.Value <= 251m || (icon_num.Value >= 277m && icon_num.Value <= 411m))
		{
			bitmap2 = (Image)resources2.GetObject(PKM.getG4Species((int)icon_num.Value).ToString());
			GFX.DrawImage(bitmap2, 700, 140, 40, 40);
		}
		else if (icon_num.Value >= 412m && icon_num.Value <= 439m)
		{
			bitmap2 = (Bitmap)resources2.GetObject(icon_num.Value.ToString());
			GFX.DrawImage(bitmap2, 700, 140, 40, 40);
		}
		else
		{
			bitmap2 = (Bitmap)resources2.GetObject("0");
			GFX.DrawImage(bitmap2, 700, 140, 40, 40);
		}
		GFX.DrawString(header1.Text, new Font("Calibri", 8f), Brushes.Black, 511f, 152f);
		GFX.DrawString(header2.Text, new Font("Calibri", 8f), Brushes.Black, 511f, 168f);
		GFX.DrawString(body1.Text, new Font("Calibri", 8f), Brushes.Black, 506f, 190f);
		GFX.DrawString(body2.Text, new Font("Calibri", 8f), Brushes.Black, 506f, 206f);
		GFX.DrawString(body3.Text, new Font("Calibri", 8f), Brushes.Black, 506f, 222f);
		GFX.DrawString(body4.Text, new Font("Calibri", 8f), Brushes.Black, 506f, 238f);
		GFX.DrawString(footer1.Text, new Font("Calibri", 8f), Brushes.Black, 506f, 262f);
		GFX.DrawString(footer2.Text, new Font("Calibri", 8f), Brushes.Black, 506f, 278f);
	}

	private void Header1TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Header2TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body1TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body2TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body3TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body4TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Footer1TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Footer2TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Map_helpClick(object sender, EventArgs e)
	{
		MessageBox.Show("These values are used to associate the script to a NPC character in the game.\n\nYou can use Advance Map to locate the values for all NPC in the game.\n\nIn Emerald, father at petalburg Gym is Bank 08, Map 01, NPC 01.\n\n For Wondercard Deliveryman set all to 255");
	}

	private void Xse_helpClick(object sender, EventArgs e)
	{
		MessageBox.Show("XSE Export: exports the script with padding corresponding to base address of the script and *.gba extension. You can directly load (and edit) the script in XSE, script offset will be shown when using the export button.\nXSE Import: imports a *.gba script generated by this tool after editing (or not) with XSE (importing anything else will not correctly work).\n\nThese options are just for convenience, the scripts are in no way gba roms, but it's the more convenient way to edit them in XSE.");
	}

	private void Xse_exportClick(object sender, EventArgs e)
	{
		FileIO.save_data(wc3file.get_script_XSE(), xsescriptfilter);
	}

	private void Xse_importClick(object sender, EventArgs e)
	{
		string path = null;
		if (FileIO.load_file(ref wc3script_new, ref path, xsescriptfilter) <= 1000)
		{
			wc3file.set_script_XSE(wc3script_new);
			custom_script.Checked = true;
			MessageBox.Show("Custom script imported.");
		}
		else
		{
			MessageBox.Show("Invalid file size.");
		}
	}

	private void GiveEggExt_butClick(object sender, EventArgs e)
	{
		new WC3_editor_giveggExt().ShowDialog();
		if (script_injected)
		{
			script_injected = false;
			custom_script.Checked = true;
			MessageBox.Show("Give Egg script injected.");
		}
	}

	private void WC3_editorDragEnter(object sender, DragEventArgs e)
	{
		e.Effect = DragDropEffects.All;
	}

	private void WC3_editorDragDrop(object sender, DragEventArgs e)
	{
		string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, autoConvert: false);
		Load_WC3(array[0]);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.load_wc3_but = new System.Windows.Forms.Button();
		this.save_wc3_but = new System.Windows.Forms.Button();
		this.wc3_path = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.header1 = new System.Windows.Forms.TextBox();
		this.header2 = new System.Windows.Forms.TextBox();
		this.body1 = new System.Windows.Forms.TextBox();
		this.body2 = new System.Windows.Forms.TextBox();
		this.body3 = new System.Windows.Forms.TextBox();
		this.body4 = new System.Windows.Forms.TextBox();
		this.footer1 = new System.Windows.Forms.TextBox();
		this.footer2 = new System.Windows.Forms.TextBox();
		this.export_script_but = new System.Windows.Forms.Button();
		this.import_script_but = new System.Windows.Forms.Button();
		this.custom_script = new System.Windows.Forms.CheckBox();
		this.iconbox = new System.Windows.Forms.ComboBox();
		this.label9 = new System.Windows.Forms.Label();
		this.colorbox = new System.Windows.Forms.ComboBox();
		this.label10 = new System.Windows.Forms.Label();
		this.icon_num = new System.Windows.Forms.NumericUpDown();
		this.distro_but_always = new System.Windows.Forms.RadioButton();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.distro_but_no = new System.Windows.Forms.RadioButton();
		this.distro_but_one = new System.Windows.Forms.RadioButton();
		this.regionlab = new System.Windows.Forms.Label();
		this.giveEgg_but = new System.Windows.Forms.Button();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.map_help = new System.Windows.Forms.Button();
		this.label14 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.map_npc = new System.Windows.Forms.NumericUpDown();
		this.map_map = new System.Windows.Forms.NumericUpDown();
		this.map_bank = new System.Windows.Forms.NumericUpDown();
		this.xse_import = new System.Windows.Forms.Button();
		this.xse_export = new System.Windows.Forms.Button();
		this.xse_help = new System.Windows.Forms.Button();
		this.giveEggExt_but = new System.Windows.Forms.Button();
		this.faketoogle = new System.Windows.Forms.CheckBox();
		((System.ComponentModel.ISupportInitialize)this.icon_num).BeginInit();
		this.groupBox1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.map_npc).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.map_map).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.map_bank).BeginInit();
		base.SuspendLayout();
		this.load_wc3_but.Location = new System.Drawing.Point(49, 11);
		this.load_wc3_but.Name = "load_wc3_but";
		this.load_wc3_but.Size = new System.Drawing.Size(75, 23);
		this.load_wc3_but.TabIndex = 0;
		this.load_wc3_but.Text = "Load WC3";
		this.load_wc3_but.UseVisualStyleBackColor = true;
		this.load_wc3_but.Click += new System.EventHandler(Load_wc3_butClick);
		this.save_wc3_but.Enabled = false;
		this.save_wc3_but.Location = new System.Drawing.Point(130, 11);
		this.save_wc3_but.Name = "save_wc3_but";
		this.save_wc3_but.Size = new System.Drawing.Size(75, 23);
		this.save_wc3_but.TabIndex = 1;
		this.save_wc3_but.Text = "Save WC3";
		this.save_wc3_but.UseVisualStyleBackColor = true;
		this.save_wc3_but.Click += new System.EventHandler(Save_wc3_butClick);
		this.wc3_path.Location = new System.Drawing.Point(221, 13);
		this.wc3_path.Name = "wc3_path";
		this.wc3_path.ReadOnly = true;
		this.wc3_path.Size = new System.Drawing.Size(522, 20);
		this.wc3_path.TabIndex = 2;
		this.label1.Location = new System.Drawing.Point(46, 117);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(100, 23);
		this.label1.TabIndex = 3;
		this.label1.Text = "Header 1";
		this.label2.Location = new System.Drawing.Point(46, 140);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 23);
		this.label2.TabIndex = 4;
		this.label2.Text = "Header 2";
		this.label3.Location = new System.Drawing.Point(46, 163);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(100, 23);
		this.label3.TabIndex = 5;
		this.label3.Text = "Body 1";
		this.label4.Location = new System.Drawing.Point(46, 186);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(100, 23);
		this.label4.TabIndex = 6;
		this.label4.Text = "Body 2";
		this.label5.Location = new System.Drawing.Point(46, 209);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(100, 23);
		this.label5.TabIndex = 7;
		this.label5.Text = "Body 3";
		this.label6.Location = new System.Drawing.Point(46, 232);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(100, 23);
		this.label6.TabIndex = 8;
		this.label6.Text = "Body 4";
		this.label7.Location = new System.Drawing.Point(46, 255);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(100, 23);
		this.label7.TabIndex = 9;
		this.label7.Text = "Footer 1";
		this.label8.Location = new System.Drawing.Point(46, 278);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(100, 23);
		this.label8.TabIndex = 10;
		this.label8.Text = "Footer 2";
		this.header1.Location = new System.Drawing.Point(114, 114);
		this.header1.MaxLength = 40;
		this.header1.Name = "header1";
		this.header1.Size = new System.Drawing.Size(379, 20);
		this.header1.TabIndex = 11;
		this.header1.TextChanged += new System.EventHandler(Header1TextChanged);
		this.header2.Location = new System.Drawing.Point(114, 137);
		this.header2.MaxLength = 40;
		this.header2.Name = "header2";
		this.header2.Size = new System.Drawing.Size(379, 20);
		this.header2.TabIndex = 12;
		this.header2.TextChanged += new System.EventHandler(Header2TextChanged);
		this.body1.Location = new System.Drawing.Point(114, 160);
		this.body1.MaxLength = 40;
		this.body1.Name = "body1";
		this.body1.Size = new System.Drawing.Size(379, 20);
		this.body1.TabIndex = 13;
		this.body1.TextChanged += new System.EventHandler(Body1TextChanged);
		this.body2.Location = new System.Drawing.Point(114, 183);
		this.body2.MaxLength = 40;
		this.body2.Name = "body2";
		this.body2.Size = new System.Drawing.Size(379, 20);
		this.body2.TabIndex = 14;
		this.body2.TextChanged += new System.EventHandler(Body2TextChanged);
		this.body3.Location = new System.Drawing.Point(114, 206);
		this.body3.MaxLength = 40;
		this.body3.Name = "body3";
		this.body3.Size = new System.Drawing.Size(379, 20);
		this.body3.TabIndex = 15;
		this.body3.TextChanged += new System.EventHandler(Body3TextChanged);
		this.body4.Location = new System.Drawing.Point(114, 229);
		this.body4.MaxLength = 40;
		this.body4.Name = "body4";
		this.body4.Size = new System.Drawing.Size(379, 20);
		this.body4.TabIndex = 16;
		this.body4.TextChanged += new System.EventHandler(Body4TextChanged);
		this.footer1.Location = new System.Drawing.Point(114, 252);
		this.footer1.MaxLength = 40;
		this.footer1.Name = "footer1";
		this.footer1.Size = new System.Drawing.Size(379, 20);
		this.footer1.TabIndex = 17;
		this.footer1.TextChanged += new System.EventHandler(Footer1TextChanged);
		this.footer2.Location = new System.Drawing.Point(114, 275);
		this.footer2.MaxLength = 40;
		this.footer2.Name = "footer2";
		this.footer2.Size = new System.Drawing.Size(379, 20);
		this.footer2.TabIndex = 18;
		this.footer2.TextChanged += new System.EventHandler(Footer2TextChanged);
		this.export_script_but.Enabled = false;
		this.export_script_but.Location = new System.Drawing.Point(49, 304);
		this.export_script_but.Name = "export_script_but";
		this.export_script_but.Size = new System.Drawing.Size(75, 23);
		this.export_script_but.TabIndex = 19;
		this.export_script_but.Text = "Export Script";
		this.export_script_but.UseVisualStyleBackColor = true;
		this.export_script_but.Click += new System.EventHandler(Export_script_butClick);
		this.import_script_but.Enabled = false;
		this.import_script_but.Location = new System.Drawing.Point(130, 304);
		this.import_script_but.Name = "import_script_but";
		this.import_script_but.Size = new System.Drawing.Size(75, 23);
		this.import_script_but.TabIndex = 20;
		this.import_script_but.Text = "Import Script";
		this.import_script_but.UseVisualStyleBackColor = true;
		this.import_script_but.Click += new System.EventHandler(Import_script_butClick);
		this.custom_script.AutoCheck = false;
		this.custom_script.Location = new System.Drawing.Point(215, 304);
		this.custom_script.Name = "custom_script";
		this.custom_script.Size = new System.Drawing.Size(137, 24);
		this.custom_script.TabIndex = 21;
		this.custom_script.Text = "Custom script loaded";
		this.custom_script.UseVisualStyleBackColor = true;
		this.iconbox.FormattingEnabled = true;
		this.iconbox.Items.AddRange(new object[441]
		{
			"????????", "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise",
			"Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata",
			"Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀",
			"Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff",
			"Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth",
			"Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine",
			"Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout",
			"Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke",
			"Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk",
			"Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler",
			"Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing",
			"Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking",
			"Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp",
			"Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar",
			"Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite",
			"Mewtwo", "Mew", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw",
			"Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat",
			"Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep",
			"Flaaffy", "Ampharos", "Bellossom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff",
			"Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking",
			"Misdreavus", "Unown A", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull",
			"Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross", "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo",
			"Swinub", "Piloswine", "Corsola", "Remoraid", "Octillery", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom",
			"Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler", "Smeargle", "Tyrogue", "Hitmontop", "Smoochum", "Elekid",
			"Magby", "Miltank", "Blissey", "Raikou", "Entei", "Suicune", "Larvitar", "Pupitar", "Tyranitar", "Lugia",
			"Ho-oh", "Celebi", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)",
			"? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)",
			"? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "Treecko", "Grovyle", "Sceptile",
			"Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone",
			"Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf",
			"Shiftry", "Nincada", "Ninjask", "Shedinja", "Taillow", "Swellow", "Shroomish", "Breloom", "Spinda", "Wingull",
			"Pelipper", "Surskit", "Masquerain", "Wailmer", "Wailord", "Skitty", "Delcatty", "Kecleon", "Baltoy", "Claydol",
			"Nosepass", "Torkoal", "Sableye", "Barboach", "Whiscash", "Luvdisc", "Corphish", "Crawdaunt", "Feebas", "Milotic",
			"Carvanha", "Sharpedo", "Trapinch", "Vibrava", "Flygon", "Makuhita", "Hariyama", "Electrike", "Manectric", "Numel",
			"Camerupt", "Spheal", "Sealeo", "Walrein", "Cacnea", "Cacturne", "Snorunt", "Glalie", "Lunatone", "Solrock",
			"Azurill", "Spoink", "Grumpig", "Plusle", "Minun", "Mawile", "Meditite", "Medicham", "Swablu", "Altaria",
			"Wynaut", "Duskull", "Dusclops", "Roselia", "Slakoth", "Vigoroth", "Slaking", "Gulpin", "Swalot", "Tropius",
			"Whismur", "Loudred", "Exploud", "Clamperl", "Huntail", "Gorebyss", "Absol", "Shuppet", "Banette", "Seviper",
			"Zangoose", "Relicanth", "Aron", "Lairon", "Aggron", "Castform", "Volbeat", "Illumise", "Lileep", "Cradily",
			"Anorith", "Armaldo", "Ralts", "Kirlia", "Gardevoir", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang",
			"Metagross", "Regirock", "Regice", "Registeel", "Kyogre", "Groudon", "Rayquaza", "Latias", "Latios", "Jirachi",
			"Deoxys", "Chimecho", "Pokémon Egg", "Unown B", "Unown C", "Unown D", "Unown E", "Unown F", "Unown G", "Unown H",
			"Unown I", "Unown J", "Unown K", "Unown L", "Unown M", "Unown N", "Unown O", "Unown P", "Unown Q", "Unown R",
			"Unown S", "Unown T", "Unown U", "Unown V", "Unown W", "Unown X", "Unown Y", "Unown Z", "Unown !", "Unown ?",
			"SET WITH INDEX  --->"
		});
		this.iconbox.Location = new System.Drawing.Point(115, 85);
		this.iconbox.Name = "iconbox";
		this.iconbox.Size = new System.Drawing.Size(243, 21);
		this.iconbox.TabIndex = 23;
		this.iconbox.SelectedIndexChanged += new System.EventHandler(IconboxSelectedIndexChanged);
		this.label9.Location = new System.Drawing.Point(46, 88);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(33, 14);
		this.label9.TabIndex = 24;
		this.label9.Text = "Icon";
		this.colorbox.FormattingEnabled = true;
		this.colorbox.Items.AddRange(new object[8] { "Dark Yellow with square patterns (0x00)", "Dark Blue/Green with square patterns (0x04)", "Red with line patterns (0x08)", "Green with line patterns (0x0c)", "Blue with line patterns (0x10)", "Yellow with line patterns (0x14)", "Yellow with pokeball patterns (0x18)", "Grey with pokeball patterns (0x1c)" });
		this.colorbox.Location = new System.Drawing.Point(115, 58);
		this.colorbox.Name = "colorbox";
		this.colorbox.Size = new System.Drawing.Size(243, 21);
		this.colorbox.TabIndex = 25;
		this.colorbox.SelectedIndexChanged += new System.EventHandler(ColorboxSelectedIndexChanged);
		this.label10.Location = new System.Drawing.Point(46, 60);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(63, 19);
		this.label10.TabIndex = 26;
		this.label10.Text = "Color";
		this.icon_num.Location = new System.Drawing.Point(373, 86);
		this.icon_num.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		this.icon_num.Name = "icon_num";
		this.icon_num.Size = new System.Drawing.Size(120, 20);
		this.icon_num.TabIndex = 27;
		this.icon_num.ValueChanged += new System.EventHandler(Icon_numValueChanged);
		this.distro_but_always.Location = new System.Drawing.Point(6, 19);
		this.distro_but_always.Name = "distro_but_always";
		this.distro_but_always.Size = new System.Drawing.Size(141, 24);
		this.distro_but_always.TabIndex = 28;
		this.distro_but_always.TabStop = true;
		this.distro_but_always.Text = "Always";
		this.distro_but_always.UseVisualStyleBackColor = true;
		this.groupBox1.Controls.Add(this.distro_but_no);
		this.groupBox1.Controls.Add(this.distro_but_one);
		this.groupBox1.Controls.Add(this.distro_but_always);
		this.groupBox1.Location = new System.Drawing.Point(499, 39);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(154, 95);
		this.groupBox1.TabIndex = 29;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Distributable";
		this.distro_but_no.Location = new System.Drawing.Point(6, 65);
		this.distro_but_no.Name = "distro_but_no";
		this.distro_but_no.Size = new System.Drawing.Size(141, 24);
		this.distro_but_no.TabIndex = 30;
		this.distro_but_no.TabStop = true;
		this.distro_but_no.Text = "No";
		this.distro_but_no.UseVisualStyleBackColor = true;
		this.distro_but_one.Location = new System.Drawing.Point(6, 42);
		this.distro_but_one.Name = "distro_but_one";
		this.distro_but_one.Size = new System.Drawing.Size(141, 24);
		this.distro_but_one.TabIndex = 29;
		this.distro_but_one.TabStop = true;
		this.distro_but_one.Text = "Receiver can't distribute";
		this.distro_but_one.UseVisualStyleBackColor = true;
		this.regionlab.Location = new System.Drawing.Point(373, 60);
		this.regionlab.Name = "regionlab";
		this.regionlab.Size = new System.Drawing.Size(100, 23);
		this.regionlab.TabIndex = 30;
		this.regionlab.Text = "USA/EUR";
		this.giveEgg_but.Location = new System.Drawing.Point(49, 371);
		this.giveEgg_but.Name = "giveEgg_but";
		this.giveEgg_but.Size = new System.Drawing.Size(135, 23);
		this.giveEgg_but.TabIndex = 31;
		this.giveEgg_but.Text = "Inject Give Egg Script";
		this.giveEgg_but.UseVisualStyleBackColor = true;
		this.giveEgg_but.Click += new System.EventHandler(GiveEgg_butClick);
		this.groupBox2.Controls.Add(this.map_help);
		this.groupBox2.Controls.Add(this.label14);
		this.groupBox2.Controls.Add(this.label13);
		this.groupBox2.Controls.Add(this.label12);
		this.groupBox2.Controls.Add(this.label11);
		this.groupBox2.Controls.Add(this.map_npc);
		this.groupBox2.Controls.Add(this.map_map);
		this.groupBox2.Controls.Add(this.map_bank);
		this.groupBox2.Location = new System.Drawing.Point(342, 304);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(203, 113);
		this.groupBox2.TabIndex = 32;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Script Association";
		this.map_help.Location = new System.Drawing.Point(174, 11);
		this.map_help.Name = "map_help";
		this.map_help.Size = new System.Drawing.Size(21, 22);
		this.map_help.TabIndex = 7;
		this.map_help.Text = "?";
		this.map_help.UseVisualStyleBackColor = true;
		this.map_help.Click += new System.EventHandler(Map_helpClick);
		this.label14.Location = new System.Drawing.Point(125, 31);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(72, 72);
		this.label14.TabIndex = 6;
		this.label14.Text = "All 255 for Pokémon Center deliveryman";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label13.Location = new System.Drawing.Point(17, 83);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(36, 23);
		this.label13.TabIndex = 5;
		this.label13.Text = "NPC:";
		this.label12.Location = new System.Drawing.Point(17, 57);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(36, 23);
		this.label12.TabIndex = 4;
		this.label12.Text = "Map:";
		this.label11.Location = new System.Drawing.Point(17, 31);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(36, 18);
		this.label11.TabIndex = 3;
		this.label11.Text = "Bank:";
		this.map_npc.Location = new System.Drawing.Point(59, 81);
		this.map_npc.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.map_npc.Name = "map_npc";
		this.map_npc.Size = new System.Drawing.Size(60, 20);
		this.map_npc.TabIndex = 2;
		this.map_map.Location = new System.Drawing.Point(59, 55);
		this.map_map.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.map_map.Name = "map_map";
		this.map_map.Size = new System.Drawing.Size(60, 20);
		this.map_map.TabIndex = 1;
		this.map_bank.Location = new System.Drawing.Point(59, 29);
		this.map_bank.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.map_bank.Name = "map_bank";
		this.map_bank.Size = new System.Drawing.Size(60, 20);
		this.map_bank.TabIndex = 0;
		this.xse_import.Enabled = false;
		this.xse_import.Location = new System.Drawing.Point(130, 333);
		this.xse_import.Name = "xse_import";
		this.xse_import.Size = new System.Drawing.Size(75, 23);
		this.xse_import.TabIndex = 34;
		this.xse_import.Text = "XSE Import";
		this.xse_import.UseVisualStyleBackColor = true;
		this.xse_import.Click += new System.EventHandler(Xse_importClick);
		this.xse_export.Enabled = false;
		this.xse_export.Location = new System.Drawing.Point(49, 333);
		this.xse_export.Name = "xse_export";
		this.xse_export.Size = new System.Drawing.Size(75, 23);
		this.xse_export.TabIndex = 33;
		this.xse_export.Text = "XSE Export";
		this.xse_export.UseVisualStyleBackColor = true;
		this.xse_export.Click += new System.EventHandler(Xse_exportClick);
		this.xse_help.Location = new System.Drawing.Point(211, 335);
		this.xse_help.Name = "xse_help";
		this.xse_help.Size = new System.Drawing.Size(21, 22);
		this.xse_help.TabIndex = 8;
		this.xse_help.Text = "?";
		this.xse_help.UseVisualStyleBackColor = true;
		this.xse_help.Click += new System.EventHandler(Xse_helpClick);
		this.giveEggExt_but.Location = new System.Drawing.Point(49, 400);
		this.giveEggExt_but.Name = "giveEggExt_but";
		this.giveEggExt_but.Size = new System.Drawing.Size(135, 35);
		this.giveEggExt_but.TabIndex = 35;
		this.giveEggExt_but.Text = "Inject Give Egg Script (Extended version)";
		this.giveEggExt_but.UseVisualStyleBackColor = true;
		this.giveEggExt_but.Click += new System.EventHandler(GiveEggExt_butClick);
		this.faketoogle.Location = new System.Drawing.Point(130, 38);
		this.faketoogle.Name = "faketoogle";
		this.faketoogle.Size = new System.Drawing.Size(126, 17);
		this.faketoogle.TabIndex = 36;
		this.faketoogle.Text = "Fake saved WC ID";
		this.faketoogle.UseVisualStyleBackColor = true;
		this.faketoogle.Visible = false;
		this.AllowDrop = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(749, 448);
		base.Controls.Add(this.faketoogle);
		base.Controls.Add(this.giveEggExt_but);
		base.Controls.Add(this.xse_help);
		base.Controls.Add(this.xse_import);
		base.Controls.Add(this.xse_export);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.giveEgg_but);
		base.Controls.Add(this.regionlab);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.icon_num);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.colorbox);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.iconbox);
		base.Controls.Add(this.custom_script);
		base.Controls.Add(this.import_script_but);
		base.Controls.Add(this.export_script_but);
		base.Controls.Add(this.footer2);
		base.Controls.Add(this.footer1);
		base.Controls.Add(this.body4);
		base.Controls.Add(this.body3);
		base.Controls.Add(this.body2);
		base.Controls.Add(this.body1);
		base.Controls.Add(this.header2);
		base.Controls.Add(this.header1);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.wc3_path);
		base.Controls.Add(this.save_wc3_but);
		base.Controls.Add(this.load_wc3_but);
		base.Name = "WC3_editor";
		this.Text = "WC3 Editor";
		base.Load += new System.EventHandler(WC3_editorLoad);
		base.DragDrop += new System.Windows.Forms.DragEventHandler(WC3_editorDragDrop);
		base.DragEnter += new System.Windows.Forms.DragEventHandler(WC3_editorDragEnter);
		((System.ComponentModel.ISupportInitialize)this.icon_num).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.map_npc).EndInit();
		((System.ComponentModel.ISupportInitialize)this.map_map).EndInit();
		((System.ComponentModel.ISupportInitialize)this.map_bank).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}

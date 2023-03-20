using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using PKHeX;

namespace WC3Tool;

partial class WC3_editor : Form
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

	
}

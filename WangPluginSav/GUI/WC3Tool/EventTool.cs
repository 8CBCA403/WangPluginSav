using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace WC3Tool;

partial class EventTool : Form
{
	private ResourceManager Tickets = new ResourceManager("WC3Tool.WC3.Tickets", Assembly.GetExecutingAssembly());

	public string savfilter = "RAW Save file|*.sav;*sa1;*sa2|All Files (*.*)|*.*";

	public string wc3filter = "Wonder Card file|*.wc3|All Files (*.*)|*.*";

	public string wcnfilter = "Wonder News file|*.wn3|All Files (*.*)|*.*";

	public string me3filter = "Mystery Event file|*.me3|All Files (*.*)|*.*";

	public string ectfilter = "e-card Trainer file|*.ect|All Files (*.*)|*.*";

	public string berryfilter = "e-card Berry file|*.ecb|All Files (*.*)|*.*";

	public byte[] savbuffer;

	public byte[] wc3new;

	public byte[] wcnnew;

	public byte[] me3file;

	public byte[] ectfile;

	public byte[] berryfile;

	public static SAV3 sav3file;
	

	public EventTool()
	{
		InitializeComponent();
		region_lab.Text = "";
	}

	private void Button1Click(object sender, EventArgs e)
	{
		new WC3_editor().ShowDialog();
	}

	private void Load_save(string path)
	{
		switch (FileIO.load_file(ref savbuffer, ref path, savfilter))
		{
		case 131072:
			sav3_path.Text = path;
			sav3file = new SAV3(savbuffer);
			region_but.Enabled = false;
			switch (sav3file.game)
			{
			default:
				if (sav3file.isjap)
				{
					region_lab.Text = "JAP";
				}
				else
				{
					region_lab.Text = "USA/EUR";
				}
				region_but.Enabled = true;
				language_box.SelectedIndex = sav3file.language - 1;
				game_box.SelectedIndex = sav3file.game;
				if (sav3file.isjap && sav3file.language != 1)
				{
					switch (MessageBox.Show("Region/language autodetection inconsistency.\n\nIs this a japanesse savegame?", "Region Input", MessageBoxButtons.YesNo))
					{
					case DialogResult.Yes:
						sav3file.isjap = true;
						region_lab.Text = "JAP";
						language_box.SelectedIndex = 0;
						break;
					case DialogResult.No:
						sav3file.isjap = false;
						region_lab.Text = "USA/EUR";
						break;
					}
				}
				sav3file.updateOffsets();
				break;
			}
			break;
		default:
			MessageBox.Show("Invalid file.");
			break;
		case -1:
			break;
		}
	}

	private void Load_save_butClick(object sender, EventArgs e)
	{
		Load_save(null);
	}

	private void Export_wc3butClick(object sender, EventArgs e)
	{
		if (!sav3file.has_WC)
		{
			MessageBox.Show("Save file does not contain WonderCard data.");
		}
		else
		{
			FileIO.save_data(sav3file.get_WC3(), wc3filter);
		}
	}

	private void Inject_wc3_butClick(object sender, EventArgs e)
	{
		if (sav3file.has_WC && MessageBox.Show("Savefile already has a WonderCard. Overwrite?", "WonderCard Injection", MessageBoxButtons.YesNo) == DialogResult.No)
		{
			return;
		}
		if (sav3file.has_mystery_gift)
		{
			string path = null;
			int num = FileIO.load_file(ref wc3new, ref path, wc3filter);
			if ((num == 1420 && !sav3file.isjap) || (num == 1252 && sav3file.isjap))
			{
				sav3file.set_WC3(wc3new);
				sav3file.update_section_chk(4);
				MessageBox.Show("WC3 injected.");
				FileIO.save_data(sav3file.Data, savfilter);
			}
			else if (num != -1)
			{
				MessageBox.Show("Invalid file size.");
			}
		}
		else
		{
			MessageBox.Show("Save file does not have Mystery Gift enabled.");
		}
	}

	private void Export_wcnClick(object sender, EventArgs e)
	{
		if (!sav3file.has_WCN)
		{
			MessageBox.Show("Save file does not contain Wonder News data.");
		}
		else
		{
			FileIO.save_data(sav3file.get_WCN(), wcnfilter);
		}
	}

	private void Inject_wcnClick(object sender, EventArgs e)
	{
		if (sav3file.has_mystery_gift)
		{
			string path = null;
			int num = FileIO.load_file(ref wcnnew, ref path, wcnfilter);
			if ((num == 448 && !sav3file.isjap) || (num == 228 && sav3file.isjap))
			{
				sav3file.set_WCN(wcnnew);
				sav3file.update_section_chk(4);
				MessageBox.Show("WC News injected.");
				FileIO.save_data(sav3file.Data, savfilter);
			}
			else if (num != -1)
			{
				MessageBox.Show("Invalid file size.");
			}
		}
		else
		{
			MessageBox.Show("Save file does not have Mystery Gift enabled.");
		}
	}

	private void Wcn_edit_butClick(object sender, EventArgs e)
	{
		new WCN_editor().ShowDialog();
	}

	private void Export_me3_butClick(object sender, EventArgs e)
	{
		int num = sav3file.has_ME3();
		switch (num)
		{
		case 0:
			MessageBox.Show("Save file does not contain Mystery Event Data.");
			break;
		case 2:
			MessageBox.Show("Save file does contain Mystery Event Data, but the script has already been erased from savedata.");
			break;
		}
		if (num != 0)
		{
			FileIO.save_data(sav3file.get_ME3(), me3filter);
		}
	}

	private void Inject_me3_butClick(object sender, EventArgs e)
	{
		if (sav3file.has_mystery_event || sav3file.game == 1)
		{
			if (sav3file.game == 1)
			{
				MessageBox.Show("Mystery Event was removed from non Japanesse Emerald.\n\tYou can still inject the data at your own risk.");
			}
			string path = null;
			int num = FileIO.load_file(ref me3file, ref path, me3filter);
			if (num == sav3file.me3_size)
			{
				ME3 mE = new ME3(me3file, num);
				if (sav3file.game != mE.isemerald)
				{
					MessageBox.Show("This ME3 file is not for this game!");
					return;
				}
				sav3file.set_ME3(me3file);
				sav3file.update_section_chk(4);
				MessageBox.Show("Mystery event injected.");
				FileIO.save_data(sav3file.Data, savfilter);
			}
			else if (num != -1)
			{
				MessageBox.Show("Invalid file size.");
			}
		}
		else
		{
			MessageBox.Show("Save file does not have Mystery Event enabled.");
		}
	}

	private void Me3_editor_butClick(object sender, EventArgs e)
	{
		new ME3_editor().ShowDialog();
	}

	private void Eon_em_butClick(object sender, EventArgs e)
	{
		MessageBox.Show("This will enable the Eon ticket event as distributed in Japan.\nKeep in mind this event was never available outside Japan.\nIf you want a legit EON ticket in Emerald, you have to Mix Records with a Ruby/Saphire game with distributable EON ticket.");
		sav3file.enable_eon_emerald();
		MessageBox.Show("Mystery event EON Ticket injected.\n\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
		FileIO.save_data(sav3file.Data, savfilter);
	}

	private void EnableMysteryGiftEventToolStripMenuItemClick(object sender, EventArgs e)
	{
		sav3file.enable_Mystery();
		FileIO.save_data(sav3file.Data, savfilter);
	}

	private void Region_butClick(object sender, EventArgs e)
	{
		game_box.Enabled = true;
		language_box.Enabled = true;
	}

	private void FixSectionChecksumsToolStripMenuItemClick(object sender, EventArgs e)
	{
		sav3file.fix_section_checksums();
		FileIO.save_data(sav3file.Data, savfilter);
	}

	private void Decor_butClick(object sender, EventArgs e)
	{
		new Decor_editor(sav3file).ShowDialog();
	}

	private void Ect_edit_butClick(object sender, EventArgs e)
	{
		new ECT_editor().ShowDialog();
	}

	private void Export_ect_butClick(object sender, EventArgs e)
	{
		FileIO.save_data(sav3file.get_ECT(), ectfilter);
	}

	private void Inject_ect_butClick(object sender, EventArgs e)
	{
		if (sav3file.game == 1)
		{
			MessageBox.Show("Mystery Event was removed from non Japanesse Emerald.\n\tYou can still inject the data at your own risk.");
		}
		string path = null;
		switch (FileIO.load_file(ref ectfile, ref path, ectfilter))
		{
		case 188:
			sav3file.set_ECT(ectfile);
			sav3file.update_section_chk(0);
			MessageBox.Show("e-card Trainer injected.");
			FileIO.save_data(sav3file.Data, savfilter);
			break;
		default:
			MessageBox.Show("Invalid file size.");
			break;
		case -1:
			break;
		}
	}

	private void EventToolDragEnter(object sender, DragEventArgs e)
	{
		e.Effect = DragDropEffects.All;
	}

	private void EventToolDragDrop(object sender, DragEventArgs e)
	{
		string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, autoConvert: false);
		Load_save(array[0]);
	}

	private void Game_boxSelectedIndexChanged(object sender, EventArgs e)
	{
		sav3file.game = game_box.SelectedIndex;
		sav3file.updateOffsets();
		switch (game_box.SelectedIndex)
		{
		case 0:
			jap_eon.Enabled = true;
			jap_aurora.Enabled = false;
			jap_mystic.Enabled = false;
			jap_old.Enabled = false;
			usa_eon_ecard.Enabled = true;
			usa_eon_italy.Enabled = true;
			usa_aurora.Enabled = false;
			usa_mystic.Enabled = false;
			eur_eon.Enabled = true;
			eur_aurora.Enabled = false;
			break;
		case 1:
			jap_eon.Enabled = true;
			jap_aurora.Enabled = false;
			jap_mystic.Enabled = true;
			jap_old.Enabled = true;
			usa_eon_ecard.Enabled = false;
			usa_eon_italy.Enabled = false;
			usa_aurora.Enabled = true;
			usa_mystic.Enabled = true;
			eur_eon.Enabled = false;
			eur_aurora.Enabled = true;
			break;
		case 2:
			jap_eon.Enabled = false;
			jap_aurora.Enabled = true;
			jap_mystic.Enabled = true;
			jap_old.Enabled = false;
			usa_eon_ecard.Enabled = false;
			usa_eon_italy.Enabled = false;
			usa_aurora.Enabled = true;
			usa_mystic.Enabled = true;
			eur_eon.Enabled = false;
			eur_aurora.Enabled = true;
			break;
		}
		jap_eon.Checked = false;
		jap_aurora.Checked = false;
		jap_mystic.Checked = false;
		jap_old.Checked = false;
		usa_eon_ecard.Checked = false;
		usa_eon_italy.Checked = false;
		usa_aurora.Checked = false;
		usa_mystic.Checked = false;
		eur_eon.Checked = false;
		eur_aurora.Checked = false;
	}

	private void Language_boxSelectedIndexChanged(object sender, EventArgs e)
	{
		sav3file.language = language_box.SelectedIndex + 1;
		if (sav3file.language == 1)
		{
			sav3file.isjap = true;
		}
		else
		{
			sav3file.isjap = false;
		}
		if (sav3file.isjap)
		{
			region_lab.Text = "JAP";
		}
		else
		{
			region_lab.Text = "USA/EUR";
		}
		sav3file.updateOffsets();
		switch (language_box.SelectedIndex)
		{
		case 0:
			JAP_group.Enabled = true;
			USA_group.Enabled = false;
			EUR_group.Enabled = false;
			break;
		case 1:
			JAP_group.Enabled = false;
			USA_group.Enabled = true;
			EUR_group.Enabled = false;
			break;
		case 2:
			JAP_group.Enabled = false;
			USA_group.Enabled = false;
			EUR_group.Enabled = true;
			break;
		case 3:
			JAP_group.Enabled = false;
			USA_group.Enabled = false;
			EUR_group.Enabled = true;
			break;
		case 4:
			JAP_group.Enabled = false;
			USA_group.Enabled = false;
			EUR_group.Enabled = true;
			break;
		case 5:
			JAP_group.Enabled = false;
			USA_group.Enabled = false;
			EUR_group.Enabled = false;
			break;
		case 6:
			JAP_group.Enabled = false;
			USA_group.Enabled = false;
			EUR_group.Enabled = true;
			break;
		}
		jap_eon.Checked = false;
		jap_aurora.Checked = false;
		jap_mystic.Checked = false;
		jap_old.Checked = false;
		usa_eon_ecard.Checked = false;
		usa_eon_italy.Checked = false;
		usa_aurora.Checked = false;
		usa_mystic.Checked = false;
		eur_eon.Checked = false;
		eur_aurora.Checked = false;
	}

	private void Inject_savClick(object sender, EventArgs e)
	{
		switch (language_box.SelectedIndex)
		{
		case 0:
			if (jap_eon.Checked)
			{
				if (sav3file.has_mystery_event)
				{
					if (game_box.SelectedIndex == 0)
					{
						sav3file.set_ME3((byte[])Tickets.GetObject("JAP_EON_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Eon Ticket Mystery Event injected.\n\nGo see your father at Petalburg Gym.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else if (game_box.SelectedIndex == 1)
					{
						sav3file.enable_eon_emerald();
						MessageBox.Show("Eon Ticket Mystery Event injected.\nGo see the man in blue at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
				}
				else
				{
					MessageBox.Show("Please enable Mystery Event in the savefile.");
				}
			}
			else if (jap_aurora.Checked)
			{
				if (game_box.SelectedIndex == 2)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("JAP_AURORA_FRLG_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in green at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
			}
			else if (jap_mystic.Checked)
			{
				if (game_box.SelectedIndex == 1)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("JAP_MYSTIC_E_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Mystic Ticket Wondercard injected.\nGo see the man in blue at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable Mystery Gift in the savefile.");
					}
				}
				else if (game_box.SelectedIndex == 2)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("JAP_MYSTIC_FRLG_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Mystic Ticket Wondercard injected.\nGo see the man in green at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable Mystery Gift in the savefile.");
					}
				}
			}
			else if (jap_old.Checked && game_box.SelectedIndex == 1)
			{
				if (sav3file.has_mystery_gift)
				{
					sav3file.set_WC3((byte[])Tickets.GetObject("JAP_OLDMAP_E_FILE"));
					sav3file.update_section_chk(4);
					MessageBox.Show("Old Map Wondercard injected.\nGo see the man in green at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
					FileIO.save_data(sav3file.Data, savfilter);
				}
				else
				{
					MessageBox.Show("Please enable Mystery Gift in the savefile.");
				}
			}
			break;
		case 1:
			if (usa_eon_ecard.Checked)
			{
				if (sav3file.has_mystery_event)
				{
					if (game_box.SelectedIndex == 0)
					{
						sav3file.set_ME3((byte[])Tickets.GetObject("USA_EON_ECARD_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Eon Ticket Mystery Event injected.\n\nGo see your father at Petalburg Gym.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
				}
				else
				{
					MessageBox.Show("Please enable Mystery Event in the savefile.");
				}
			}
			else if (usa_eon_italy.Checked)
			{
				if (sav3file.has_mystery_event)
				{
					if (game_box.SelectedIndex == 0)
					{
						sav3file.set_ME3((byte[])Tickets.GetObject("USA_EON_ITALY_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Eon Ticket Mystery Event injected.\n\nGo see your father at Petalburg Gym.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
				}
				else
				{
					MessageBox.Show("Please enable Mystery Event in the savefile.");
				}
			}
			else if (usa_aurora.Checked)
			{
				if (game_box.SelectedIndex == 1)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("USA_AURORA_E_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in blue at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
				else if (game_box.SelectedIndex == 2)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("USA_AURORA_FRLG_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in green at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
			}
			else
			{
				if (!usa_mystic.Checked)
				{
					break;
				}
				if (game_box.SelectedIndex == 1)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("USA_MYSTIC_E_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Mystic Ticket Wondercard injected.\nGo see the man in blue at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable Mystery Gift in the savefile.");
					}
				}
				else if (game_box.SelectedIndex == 2)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("USA_MYSTIC_FRLG_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Mystic Ticket Wondercard injected.\nGo see the man in green at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable Mystery Gift in the savefile.");
					}
				}
			}
			break;
		case 2:
			if (eur_eon.Checked)
			{
				if (sav3file.has_mystery_event)
				{
					if (game_box.SelectedIndex == 0)
					{
						sav3file.set_ME3((byte[])Tickets.GetObject("FR_EON_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Eon Ticket Mystery Event injected.\n\nGo see your father at Petalburg Gym.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
				}
				else
				{
					MessageBox.Show("Please enable Mystery Event in the savefile.");
				}
			}
			else
			{
				if (!eur_aurora.Checked)
				{
					break;
				}
				if (game_box.SelectedIndex == 1)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("FR_AURORA_E_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in blue at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
				else if (game_box.SelectedIndex == 2)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("FR_AURORA_FRLG_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in green at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
			}
			break;
		case 3:
			if (eur_eon.Checked)
			{
				if (sav3file.has_mystery_event)
				{
					if (game_box.SelectedIndex == 0)
					{
						sav3file.set_ME3((byte[])Tickets.GetObject("IT_EON_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Eon Ticket Mystery Event injected.\n\nGo see your father at Petalburg Gym.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
				}
				else
				{
					MessageBox.Show("Please enable Mystery Event in the savefile.");
				}
			}
			else
			{
				if (!eur_aurora.Checked)
				{
					break;
				}
				if (game_box.SelectedIndex == 1)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("IT_AURORA_E_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in blue at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
				else if (game_box.SelectedIndex == 2)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("IT_AURORA_FRLG_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in green at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
			}
			break;
		case 4:
			if (eur_eon.Checked)
			{
				if (sav3file.has_mystery_event)
				{
					if (game_box.SelectedIndex == 0)
					{
						sav3file.set_ME3((byte[])Tickets.GetObject("DE_EON_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Eon Ticket Mystery Event injected.\n\nGo see your father at Petalburg Gym.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
				}
				else
				{
					MessageBox.Show("Please enable Mystery Event in the savefile.");
				}
			}
			else
			{
				if (!eur_aurora.Checked)
				{
					break;
				}
				if (game_box.SelectedIndex == 1)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("DE_AURORA_E_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in blue at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
				else if (game_box.SelectedIndex == 2)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("DE_AURORA_FRLG_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in green at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
			}
			break;
		case 6:
			if (eur_eon.Checked)
			{
				if (sav3file.has_mystery_event)
				{
					if (game_box.SelectedIndex == 0)
					{
						sav3file.set_ME3((byte[])Tickets.GetObject("SP_EON_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Eon Ticket Mystery Event injected.\n\nGo see your father at Petalburg Gym.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
				}
				else
				{
					MessageBox.Show("Please enable Mystery Event in the savefile.");
				}
			}
			else
			{
				if (!eur_aurora.Checked)
				{
					break;
				}
				if (game_box.SelectedIndex == 1)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("SP_AURORA_E_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in blue at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
				else if (game_box.SelectedIndex == 2)
				{
					if (sav3file.has_mystery_gift)
					{
						sav3file.set_WC3((byte[])Tickets.GetObject("SP_AURORA_FRLG_FILE"));
						sav3file.update_section_chk(4);
						MessageBox.Show("Aurora Ticket Wondercard injected.\nGo see the man in green at pokemon's center 2nd floor.\nNote: if you saved in the 2nd floor of Pokémon Center, you'll have to exit and enter for the Blue man to appear.");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					else
					{
						MessageBox.Show("Please enable mystery gift in the savefile.");
					}
				}
			}
			break;
		case 5:
			break;
		}
	}

	
}

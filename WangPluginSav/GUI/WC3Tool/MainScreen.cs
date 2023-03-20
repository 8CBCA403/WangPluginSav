using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using WangPluginSav.Util.WC3;

namespace WC3Tool;

partial class MainScreen : Form
{
    public static string savfilter = "RAW Save file|*.sav;*sa1;*sa2|All Files (*.*)|*.*";

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

    public static SAV3 sav3file = SAV;


   
    private static SAV3 SAV { get; set; }
    public string version()
    {
        Version version = Assembly.GetExecutingAssembly().GetName().Version;
        DateTime dateTime = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);
        return $"BUILD {dateTime.Year}{dateTime.Month}{dateTime.Day}_{dateTime.Hour}{dateTime.Minute}{dateTime.Second}";
    }

    public MainScreen(SAV3 sav)
    {
        InitializeComponent();
        region_lab.Text = "";
        SAV = sav;
        sav3file = SAV;
        update_button_state();
        language_box.SelectedIndex = sav3file.language - 1;
        game_box.SelectedIndex = sav3file.game;
        if (sav3file.isjap && sav3file.language != 1)
        {
            switch (MessageBox.Show("Region/language autodetection inconsistency.\n\nIs this a japanese savegame?", "Region Input", MessageBoxButtons.YesNo))
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
    }

    private void Button1Click(object sender, EventArgs e)
    {
        new WC3_editor().ShowDialog();
    }

    private void update_button_state()
    {
        export_wc3but.Enabled = false;
        inject_wc3_but.Enabled = false;
        export_wcn.Enabled = false;
        inject_wcn.Enabled = false;
        export_me3_but.Enabled = false;
        inject_me3_but.Enabled = false;
        eon_em_but.Enabled = false;
        decor_but.Enabled = false;
        export_ect_but.Enabled = false;
        inject_ect_but.Enabled = false;
        export_eberry.Enabled = false;
        inject_eberry.Enabled = false;
        tvswarm_but.Enabled = false;
        region_but.Enabled = false;
        toolStripMenuItem1.Enabled = false;
        exportOldSaveToolStripMenuItem.Enabled = false;
        enableMysteryGiftMainScreenStripMenuItem.Enabled = false;
        fixSectionChecksumsToolStripMenuItem.Enabled = false;
        switch (sav3file.game)
        {
            case 0:
                export_me3_but.Enabled = true;
                inject_me3_but.Enabled = true;
                decor_but.Enabled = true;
                export_eberry.Enabled = true;
                inject_eberry.Enabled = true;
                tvswarm_but.Enabled = true;
                break;
            case 1:
                export_wc3but.Enabled = true;
                inject_wc3_but.Enabled = true;
                export_wcn.Enabled = true;
                inject_wcn.Enabled = true;
                export_me3_but.Enabled = true;
                inject_me3_but.Enabled = true;
                eon_em_but.Enabled = true;
                decor_but.Enabled = true;
                tvswarm_but.Enabled = true;
                break;
            case 2:
                export_wc3but.Enabled = true;
                inject_wc3_but.Enabled = true;
                export_wcn.Enabled = true;
                inject_wcn.Enabled = true;
                tvswarm_but.Enabled = false;
                break;
        }
        toolStripMenuItem1.Enabled = true;
        exportOldSaveToolStripMenuItem.Enabled = true;
        enableMysteryGiftMainScreenStripMenuItem.Enabled = true;
        fixSectionChecksumsToolStripMenuItem.Enabled = true;
        clearEggEventFlagToolStripMenuItem.Enabled = sav3file.has_EggEvent_Flag();
        export_ect_but.Enabled = true;
        inject_ect_but.Enabled = true;
        region_lab.Text = (sav3file.isjap ? "JAP" : "USA/EUR");
        region_but.Enabled = true;
    }

    private void Load_save(string path)
    {
        switch (FileIO.load_file(ref savbuffer, ref path, savfilter))
        {
            case 131072:
                sav3_path.Text = path;
                sav3file = new SAV3(savbuffer);
                update_button_state();
                language_box.SelectedIndex = sav3file.language - 1;
                game_box.SelectedIndex = sav3file.game;
                if (sav3file.isjap && sav3file.language != 1)
                {
                    switch (MessageBox.Show("Region/language autodetection inconsistency.\n\nIs this a japanese savegame?", "Region Input", MessageBoxButtons.YesNo))
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
                MessageBox.Show("Mystery Event was removed from non Japanese Emerald.\n\tYou can still inject the data at your own risk.");
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

    private void EnableMysteryGiftMainScreenStripMenuItemClick(object sender, EventArgs e)
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
            MessageBox.Show("Mystery Event was removed from non Japanese Emerald.\n\tYou can still inject the data at your own risk.");
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

    private void MainScreenDragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.All;
    }

    private void MainScreenDragDrop(object sender, DragEventArgs e)
    {
        string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, autoConvert: false);
        Load_save(array[0]);
    }

    private void Game_boxSelectedIndexChanged(object sender, EventArgs e)
    {
        sav3file.game = game_box.SelectedIndex;
        update_button_state();
        sav3file.updateOffsets();
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
        update_button_state();
        sav3file.updateOffsets();
    }

    private void ExportOldSaveToolStripMenuItemClick(object sender, EventArgs e)
    {
        FileIO.save_data(sav3file.getSortedSave(1), savfilter);
    }

    private void ToolStripMenuItem1Click(object sender, EventArgs e)
    {
        FileIO.save_data(sav3file.getSortedSave(0), savfilter);
    }

    private void ClearEggEventFlagToolStripMenuItemClick(object sender, EventArgs e)
    {
        sav3file.clear_EggEvent_Flag();
        MessageBox.Show("Egg Event flag cleared.");
        FileIO.save_data(sav3file.Data, savfilter);
        clearEggEventFlagToolStripMenuItem.Enabled = sav3file.has_EggEvent_Flag();
    }

    private void EnableEnigmaBerryFlagToolStripMenuItemClick(object sender, EventArgs e)
    {
    }

    private void Export_eberryClick(object sender, EventArgs e)
    {
        if (sav3file.has_berry())
        {
            FileIO.save_data(sav3file.get_ECB(), berryfilter);
        }
        else
        {
            MessageBox.Show("There's no berry in savefile.");
        }
    }

    private void Inject_eberryClick(object sender, EventArgs e)
    {
        if (sav3file.game == 0)
        {
            string path = null;
            switch (FileIO.load_file(ref berryfile, ref path, berryfilter))
            {
                case 1328:
                    sav3file.set_ECB(berryfile);
                    sav3file.set_Enigma_Flag();
                    sav3file.update_section_chk(4);
                    MessageBox.Show("Enigma Berry injected.");
                    FileIO.save_data(sav3file.Data, savfilter);
                    break;
                default:
                    MessageBox.Show("Invalid file size.");
                    break;
                case -1:
                    break;
            }
        }
    }

    private void Ecb_edit_butClick(object sender, EventArgs e)
    {
        new ECB_editor().ShowDialog();
    }

    private void AboutToolStripMenuItem1Click(object sender, EventArgs e)
    {
        MessageBox.Show("Mystery Gift Tool 0.1f by Sabresite (" + version() + ")\n\nMany thanks to suloku, ajxpkm, Real.96, BlackShark, lostaddict, Háčky, every contributor and many more involved in Mystery Event research!\n\nThe research thread at projectpokemon.org might be of your interest.\n\nIf you want to contribute any missing event, contact Sabresite, suloku or ajxpkm at projectpokemon's forums or sabresite@projectpokemon.org");
    }

    private void Tvswarm_butClick(object sender, EventArgs e)
    {
        new TV_editor(sav3file).ShowDialog();
    }

    private void Events_distro_butClick(object sender, EventArgs e)
    {
        new EventTool().ShowDialog();
    }

    
}

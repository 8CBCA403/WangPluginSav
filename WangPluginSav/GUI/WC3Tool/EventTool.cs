using System.Reflection;
using System.Resources;
using WangPluginSav.Util.WC3;

namespace WC3Tool;

partial class EventTool : Form
{
    private ResourceManager Tickets = new ResourceManager("WangPluginSav.Tickets", Assembly.GetExecutingAssembly());

    public string savfilter = "原存档文件|*.sav;*sa1;*sa2|所有文件(*.*)|*.*";
    public string wc3filter = "神秘卡片文件|*.wc3|所有文件(*.*)|*.*";
    public string wcnfilter = "神秘新闻文件|*.wn3|所有文件(*.*)|*.*";
    public string me3filter = "神秘事件文件|*.me3|所有文件(*.*)|*.*";
    public string ectfilter = "e卡训练家文件|*.ect|所有文件(*.*)|*.*";
    public string berryfilter = "e卡树果文件|*.ecb|所有文件(*.*)|*.*";

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
        int filesize = FileIO.load_file(ref savbuffer, ref path, savfilter);
        if (filesize == SAV3.SAVE_SIZE)
        {
            sav3_path.Text = path;
            sav3file = new SAV3(savbuffer);


            region_but.Enabled = false;

            switch (sav3file.game)
            {
                case 0:
                    //Gamelabel.Text = "Ruby/Sapphire";

                    break;
                case 1:
                    //Gamelabel.Text = "Emerald";

                    break;
                case 2:
                    //Gamelabel.Text = "Fire Red/Leaf Green";

                    break;
                default:
                    //Gamelabel.Text = "Can't autodetect save game";
                    break;
            }


            if (sav3file.isjap)
                region_lab.Text = "日版";
            else
                region_lab.Text = "美/欧版";

            region_but.Enabled = true;

            language_box.SelectedIndex = sav3file.language - 1;
            game_box.SelectedIndex = sav3file.game;

            if (sav3file.isjap && sav3file.language != 1)
            {
                DialogResult dialogResult = MessageBox.Show("Region/language autodetection inconsistency.\n\nIs this a japanesse savegame?", "Region Input", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sav3file.isjap = true;
                    region_lab.Text = "日版";
                    language_box.SelectedIndex = 0;
                }
                else if (dialogResult == DialogResult.No)
                {
                    sav3file.isjap = false;
                    region_lab.Text = "美/欧版";
                }
            }
            sav3file.updateOffsets();

        }
        else if (filesize == -1)
        {
            ;
        }
        else
        {
            MessageBox.Show("无效文件。");
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
            MessageBox.Show("存档未包含神秘卡片数据。");
        }
        else
        {
            FileIO.save_data(sav3file.get_WC3(), wc3filter);
        }
    }

    private void Inject_wc3_butClick(object sender, EventArgs e)
    {
        if (sav3file.has_WC)
        {
            DialogResult dialogResult = MessageBox.Show("存档已经有一张神秘卡片了，是否覆盖？", "神秘卡片配信中", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        if (sav3file.has_mystery_gift)
        {
            string path = null;
            int filesize = FileIO.load_file(ref wc3new, ref path, wc3filter);
            if (filesize == wc3.SIZE_WC3 && sav3file.isjap == false || filesize == wc3.SIZE_WC3_jap && sav3file.isjap)
            {
                sav3file.set_WC3(wc3new);
                //custom_script.Checked = true;
                //Add fix sav3 checksum func3
                sav3file.update_section_chk(4);
                MessageBox.Show("神秘卡片配信完成。");
                FileIO.save_data(sav3file.Data, savfilter);

            }
            else if (filesize == -1)
            {
                ;
            }
            else
            {
                MessageBox.Show("无效文件大小。");
            }
        }
        else
        {
            MessageBox.Show("存档未开启神秘礼物功能。");
        }
    }

    private void Export_wcnClick(object sender, EventArgs e)
    {
        if (!sav3file.has_WCN)
        {
            MessageBox.Show("存档未包含神秘新闻数据。");
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
            int filesize = FileIO.load_file(ref wcnnew, ref path, wcnfilter);
            if (filesize == SAV3.WCN_SIZE && sav3file.isjap == false || filesize == SAV3.WCN_SIZE_jap && sav3file.isjap)
            {
                sav3file.set_WCN(wcnnew);
                //custom_script.Checked = true;
                //Add fix sav3 checksum func3
                sav3file.update_section_chk(4);
                MessageBox.Show("神秘新闻配信完成。");
                FileIO.save_data(sav3file.Data, savfilter);

            }
            else if (filesize == -1)
            {
                ;
            }
            else
            {
                MessageBox.Show("无效文件大小。");
            }
        }
        else
        {
            MessageBox.Show("存档未开启神秘礼物功能。");
        }
    }

    private void Wcn_edit_butClick(object sender, EventArgs e)
    {
        new WCN_editor().ShowDialog();
    }

    private void Export_me3_butClick(object sender, EventArgs e)
    {
        int check = sav3file.has_ME3();
        if (check == 0)
            MessageBox.Show("存档未包含神秘事件数据。");
        else if (check == 2)
            MessageBox.Show("存档包含神秘事件数据，但脚本已从存档数据中被删除。");

        if (check != 0)
            FileIO.save_data(sav3file.get_ME3(), me3filter);
    }
    private void Inject_me3_butClick(object sender, EventArgs e)
    {
        if (sav3file.has_mystery_event || sav3file.game == 1)
        {
            if (sav3file.game == 1)
                MessageBox.Show("非日版绿宝石里已移除神秘事件。\n\t您仍可以自行承担风险继续配信数据。");
            string path = null;
            int filesize = FileIO.load_file(ref me3file, ref path, me3filter);
            if (filesize == sav3file.me3_size)
            {
                ME3 me3_struct = new ME3(me3file, filesize);
                if (sav3file.game != me3_struct.isemerald)
                {
                    MessageBox.Show("神秘事件文件不适用于此游戏！");
                }
                else
                {
                    sav3file.set_ME3(me3file);
                    //custom_script.Checked = true;
                    //Add fix sav3 checksum func3
                    sav3file.update_section_chk(4);
                    MessageBox.Show("神秘事件配信完成。");
                    FileIO.save_data(sav3file.Data, savfilter);
                }

            }
            else if (filesize == -1)
            {
                ;
            }
            else
            {
                MessageBox.Show("无效文件大小。");
            }
        }
        else
        {
            MessageBox.Show("存档未开启神秘事件功能。");
        }
    }

    private void Me3_editor_butClick(object sender, EventArgs e)
    {
        new ME3_editor().ShowDialog();
    }

    private void Eon_em_butClick(object sender, EventArgs e)
    {
        MessageBox.Show("无限船票将作为日版活动配信。\n请注意此活动从未在日本以外地区配信过。\n如您想在非日版绿宝石获得合法无限船票，请与配信了无限船票的红宝石/蓝宝石进行混合记录。");
        sav3file.enable_eon_emerald();
        MessageBox.Show("神秘事件无限船票注入完成。\n\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色配信员出现。");
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

    void Inject_ect_butClick(object sender, EventArgs e)
    {
        //if (sav3file.has_mystery_event == true || sav3file.game == 1)
        //{
        if (sav3file.game == 1)
            MessageBox.Show("非日版绿宝石里已移除神秘事件。\n\t您仍可以自行承担风险继续配信数据。");
        string path = null;
        int filesize = FileIO.load_file(ref ectfile, ref path, ectfilter);
        if (filesize == ECT.SIZE_ECT)
        {
            sav3file.set_ECT(ectfile);
            sav3file.update_section_chk(0);
            MessageBox.Show("e卡训练家配信完成。");
            FileIO.save_data(sav3file.Data, savfilter);

        }
        else if (filesize == -1)
        {
            ;
        }
        else
        {
            MessageBox.Show("无效文件大小。");
        }
        //}else
        //{
        //	MessageBox.Show("Save file does not have Mystery Event enabled.");
        //}
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
            region_lab.Text = "日版";
        else
            region_lab.Text = "美/欧版";
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

    void Inject_savClick(object sender, EventArgs e)
    {
        switch (language_box.SelectedIndex)
        {
            case 0://JAP
                if (jap_eon.Checked)
                {
                    if (sav3file.has_mystery_event)
                    {
                        if (game_box.SelectedIndex == 0) //RS
                        {
                            sav3file.set_ME3((byte[])Tickets.GetObject("JAP_EON_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘事件无限船票配信完成。\n\n请前往橙华道馆与父亲对话。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else if (game_box.SelectedIndex == 1) //E
                        {
                            sav3file.enable_eon_emerald();
                            MessageBox.Show("神秘礼物无限船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先开启本存档的神秘事件/神秘礼物功能。");
                    }
                }
                else if (jap_aurora.Checked)
                {
                    if (game_box.SelectedIndex == 2) //FRLG
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("JAP_AURORA_FRLG_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                }
                else if (jap_mystic.Checked)
                {
                    if (game_box.SelectedIndex == 1) //E
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("JAP_MYSTIC_E_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物神秘船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                    else if (game_box.SelectedIndex == 2) //FRLG
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("JAP_MYSTIC_FRLG_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物神秘船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                }
                else if (jap_old.Checked)
                {
                    if (game_box.SelectedIndex == 1) //E
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("JAP_OLDMAP_E_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物古航海图配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                }
                break;
            case 1://English
                if (usa_eon_ecard.Checked)
                {
                    if (sav3file.has_mystery_event)
                    {
                        if (game_box.SelectedIndex == 0) //RS
                        {
                            sav3file.set_ME3((byte[])Tickets.GetObject("USA_EON_ECARD_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘事件无限船票配信完成。\n\n请前往橙华道馆与父亲对话。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先开启本存档的神秘事件功能。");
                    }
                }
                else if (usa_eon_italy.Checked)
                {
                    if (sav3file.has_mystery_event)
                    {
                        if (game_box.SelectedIndex == 0) //RS
                        {
                            sav3file.set_ME3((byte[])Tickets.GetObject("USA_EON_ITALY_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘事件无限船票配信完成。\n\n请前往橙华道馆与父亲对话。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先开启本存档的神秘事件功能。");
                    }
                }
                else if (usa_aurora.Checked)
                {
                    if (game_box.SelectedIndex == 1) //E
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("USA_AURORA_E_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                    else if (game_box.SelectedIndex == 2) //FRLG
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("USA_AURORA_FRLG_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                }
                else if (usa_mystic.Checked)
                {
                    if (game_box.SelectedIndex == 1) //E
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("USA_MYSTIC_E_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物神秘船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                    else if (game_box.SelectedIndex == 2) //FRLG
                    {

                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("USA_MYSTIC_FRLG_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物神秘船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }
                    }

                }
                break;
            case 2://French
                if (eur_eon.Checked)
                {
                    if (sav3file.has_mystery_event)
                    {
                        if (game_box.SelectedIndex == 0) //RS
                        {
                            sav3file.set_ME3((byte[])Tickets.GetObject("FR_EON_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘事件无限船票配信完成。\n\n请前往橙华道馆与父亲对话。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先开启本存档的神秘事件功能。");
                    }
                }
                else if (eur_aurora.Checked)
                {
                    if (game_box.SelectedIndex == 1) //E
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("FR_AURORA_E_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                    else if (game_box.SelectedIndex == 2) //FRLG
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("FR_AURORA_FRLG_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                }
                break;
            case 3://Italian
                if (eur_eon.Checked)
                {
                    if (sav3file.has_mystery_event)
                    {
                        if (game_box.SelectedIndex == 0) //RS
                        {
                            sav3file.set_ME3((byte[])Tickets.GetObject("IT_EON_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘事件无限船票配信完成。\n\n请前往橙华道馆与父亲对话。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先开启本存档的神秘事件功能。");
                    }
                }
                else if (eur_aurora.Checked)
                {
                    if (game_box.SelectedIndex == 1) //E
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("IT_AURORA_E_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                    else if (game_box.SelectedIndex == 2) //FRLG
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("IT_AURORA_FRLG_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                }
                break;
            case 4://German
                if (eur_eon.Checked)
                {
                    if (sav3file.has_mystery_event)
                    {
                        if (game_box.SelectedIndex == 0) //RS
                        {
                            sav3file.set_ME3((byte[])Tickets.GetObject("DE_EON_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘事件无限船票配信完成。\n\n请前往橙华道馆与父亲对话。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先开启本存档的神秘事件功能。");
                    }
                }
                else if (eur_aurora.Checked)
                {
                    if (game_box.SelectedIndex == 1) //E
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("DE_AURORA_E_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                    else if (game_box.SelectedIndex == 2) //FRLG
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("DE_AURORA_FRLG_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                }
                break;
            case 5://Korean
                break;
            case 6://Spanish
                if (eur_eon.Checked)
                {
                    if (sav3file.has_mystery_event)
                    {
                        if (game_box.SelectedIndex == 0) //RS
                        {
                            sav3file.set_ME3((byte[])Tickets.GetObject("SP_EON_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘事件无限船票配信完成。\n\n请前往橙华道馆与父亲对话。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先开启本存档的神秘事件功能。");
                    }
                }
                else if (eur_aurora.Checked)
                {
                    if (game_box.SelectedIndex == 1) //E
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("SP_AURORA_E_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                    else if (game_box.SelectedIndex == 2) //FRLG
                    {
                        if (sav3file.has_mystery_gift)
                        {
                            sav3file.set_WC3((byte[])Tickets.GetObject("SP_AURORA_FRLG_FILE"));
                            sav3file.update_section_chk(4);
                            MessageBox.Show("神秘礼物极光船票配信完成。\n请前往宝可梦中心二楼蓝色邮递员处。\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
                            FileIO.save_data(sav3file.Data, savfilter);
                        }
                        else
                        {
                            MessageBox.Show("请先开启本存档的神秘礼物功能。");
                        }

                    }
                }
                break;
        }
    }


}

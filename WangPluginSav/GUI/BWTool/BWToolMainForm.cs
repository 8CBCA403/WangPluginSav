using WangPluginSav.Util.Pikaedit;
using Pikaedit;
namespace BW_tool
{
    public partial class BWToolMainForm : Form
    {
        private byte[] saveFile { get; set; }
        public BWToolMainForm(byte[] SAV)
        {
           
            InitializeComponent();
            saveFile = SAV;
            int filesize = saveFile.Length;
            if (filesize == SAV5.SIZERAW || filesize == SAV5.SIZERAW + 122)
            {
                //Convert DSV to SAV
                if (filesize == SAV5.SIZERAW + 122)
                    Array.Resize(ref savebuffer, SAV5.SIZERAW);
                save = new SAV5(saveFile);

                if (save.B2W2)
                {
                    versiontext.Text = "黑2/白2";
                    dumper_but.Enabled = true;
                    chk_but.Enabled = true;
                    chk_updt_but.Enabled = true;
                    save_but.Enabled = true;
                    grotto_but.Enabled = true;
                    trainer_records_but.Enabled = true;
                    medal_but.Enabled = true;
                    forest_but.Enabled = true;
                    key_but.Enabled = true;
                    join_but.Enabled = true;
                    trainer_but.Enabled = true;
                    memory_but.Enabled = true;
                    dlc_but.Enabled = true;
                    dr_but.Enabled = true;
                    prop_but.Enabled = true;
                }
                else if (save.BW)
                {
                    versiontext.Text = "黑/白";

                    dumper_but.Enabled = true;
                    chk_but.Enabled = true;
                    chk_updt_but.Enabled = true;
                    save_but.Enabled = true;
                    grotto_but.Enabled = false;
                    trainer_records_but.Enabled = false;
                    medal_but.Enabled = false;
                    forest_but.Enabled = true;
                    key_but.Enabled = false;
                    join_but.Enabled = false;
                    trainer_but.Enabled = true;
                    memory_but.Enabled = false;
                    dlc_but.Enabled = true;
                    dr_but.Enabled = false;
                    prop_but.Enabled = true;
                }
                else versiontext.Text = "无效文件";


            }
            else
            {
                MessageBox.Show("无效文件");
                savegamename.Text = "";
                dumper_but.Enabled = false;
                chk_but.Enabled = false;
                chk_updt_but.Enabled = false;
                save_but.Enabled = false;
                grotto_but.Enabled = false;
                trainer_records_but.Enabled = false;
                medal_but.Enabled = false;
                forest_but.Enabled = false;
                key_but.Enabled = false;
                join_but.Enabled = false;
                trainer_but.Enabled = false;
                memory_but.Enabled = false;
                dlc_but.Enabled = false;
                dr_but.Enabled = false;
            }
        }
        public string dsfilter = "NDS存档文件|*.sav;*.dsv|所有文件(*.*)|*.*";
        public byte[] ?savebuffer;
        public static SAV5? save;
        void Loadsave_butClick(object sender, EventArgs e)
        {
            load_savegame(null);
        }
        void load_savegame(string? filepath)
        {
            string ?path = filepath;
            int filesize = 0;
            if(savebuffer!=null&&path!=null)
            filesize = FileIO.load_file(ref savebuffer, ref path, dsfilter);
            versiontext.Text = "";

            if (filesize == SAV5.SIZERAW || filesize == SAV5.SIZERAW + 122)
            {
                //Convert DSV to SAV
                if (filesize == SAV5.SIZERAW + 122)
                    Array.Resize(ref savebuffer, SAV5.SIZERAW);

                savegamename.Text = path;
                if(savebuffer!=null)
                save = new SAV5(savebuffer);
             if(save!=null)
                if (save.B2W2)
                {
                    versiontext.Text = "黑2/白2";

                    dumper_but.Enabled = true;
                    chk_but.Enabled = true;
                    chk_updt_but.Enabled = true;
                    save_but.Enabled = true;
                    grotto_but.Enabled = true;
                    trainer_records_but.Enabled = true;
                    medal_but.Enabled = true;
                    forest_but.Enabled = true;
                    key_but.Enabled = true;
                    join_but.Enabled = true;
                    trainer_but.Enabled = true;
                    memory_but.Enabled = true;
                    dlc_but.Enabled = true;
                    dr_but.Enabled = true;
                    prop_but.Enabled = true;
                }
                else if (save.BW)
                {
                    versiontext.Text = "黑/白";

                    dumper_but.Enabled = true;
                    chk_but.Enabled = true;
                    chk_updt_but.Enabled = true;
                    save_but.Enabled = true;
                    grotto_but.Enabled = false;
                    trainer_records_but.Enabled = false;
                    medal_but.Enabled = false;
                    forest_but.Enabled = true;
                    key_but.Enabled = false;
                    join_but.Enabled = false;
                    trainer_but.Enabled = true;
                    memory_but.Enabled = false;
                    dlc_but.Enabled = true;
                    dr_but.Enabled = false;
                    prop_but.Enabled = true;
                }
                else versiontext.Text = "无效文件";


            }
            else
            {
                MessageBox.Show("无效文件");
                savegamename.Text = "";
                dumper_but.Enabled = false;
                chk_but.Enabled = false;
                chk_updt_but.Enabled = false;
                save_but.Enabled = false;
                grotto_but.Enabled = false;
                trainer_records_but.Enabled = false;
                medal_but.Enabled = false;
                forest_but.Enabled = false;
                key_but.Enabled = false;
                join_but.Enabled = false;
                trainer_but.Enabled = false;
                memory_but.Enabled = false;
                dlc_but.Enabled = false;
                dr_but.Enabled = false;
            }
        }
        void Save_butClick(object sender, EventArgs e)
        {
            if (save != null)
                FileIO.save_data(save.Data);
        }
        void Chk_butClick(object sender, EventArgs e)
        {
            if (save != null)
                save.chkCheck(false); //Only verify
        }
        void Chk_updt_butClick(object sender, EventArgs e)
        {
            if (save != null)
                save.chkCheck(true); //Recalculate checksums and set them to savefile
        }
        void Dumper_butClick(object sender, EventArgs e)
        {
            Form dumper = new Dumper();
            dumper.ShowDialog();
        }
        void Grotto_butClick(object sender, EventArgs e)
        {
            Form grotto = new Grotto();
            grotto.ShowDialog();
        }
        void Trainer_records_butClick(object sender, EventArgs e)
        {
            Form trainerrec = new TrainerRec();
            trainerrec.ShowDialog();
        }
        void Medal_butClick(object sender, EventArgs e)
        {
            Form medals = new Medals();
            medals.ShowDialog();
        }
        void Forest_butClick(object sender, EventArgs e)
        {
            Form forest = new Entralink();
            forest.ShowDialog();
        }
        void Key_butClick(object sender, EventArgs e)
        {
            Form keys = new KeySystem();
            keys.ShowDialog();
        }
        void Join_butClick(object sender, EventArgs e)
        {
            Form join = new Join_avenue();
            join.ShowDialog();
        }
        void Trainer_butClick(object sender, EventArgs e)
        {
            Form trainer = new TrainerInfo();
            trainer.ShowDialog();
        }
        void AboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("宝可梦GEN5存档工具by suloku '16\n\n许多曾提供帮助的人我或许已记不清名字，感谢你们。但有那么几位无论如何也不会忘记的：提供了许多研究和信息的BlackShark，用以参考的kaphotic的pkhex的源代码及其在projectpokemon论坛上的研究。\n\n");
        }
        void Memory_butClick(object sender, EventArgs e)
        {
            Form memory = new MemoryLink();
            memory.ShowDialog();
        }
        void Dlc_butClick(object sender, EventArgs e)
        {
            var sav =new SaveFile(saveFile);
            var dLCEditor = new DLCEditor();
            dLCEditor.cgearSkin = sav.cgearSkin;
            dLCEditor.pokedexSkin = sav.pokedexSkin;
            dLCEditor.musicalData = sav.musical;
            dLCEditor.Version = sav.version;
            dLCEditor.Show();
            sav.cgearSkin = dLCEditor.cgearSkin;
            sav.pokedexSkin = dLCEditor.pokedexSkin;
            sav.musical = dLCEditor.musicalData;
            save = new SAV5(sav.data);
        }
        void Dr_butClick(object sender, EventArgs e)
        {
            Form dr = new DreamRadar();
            dr.ShowDialog();
        }

        void Prop_butClick(object sender, EventArgs e)
        {
            Form propcase = new PropCase();
            propcase.ShowDialog();
        }
    }
}

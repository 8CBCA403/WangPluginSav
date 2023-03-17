/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 05/03/2016
 * Time: 11:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BW_tool
{
    /// <summary>
    /// Description of Entralink.
    /// </summary>
    public partial class Entralink : Form
    {
        public static FOREST forest;
        List<RadioButton> checkboxlist = new List<RadioButton>();
        public Entralink()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            sprite_warning.Text = "";

            checkboxlist.Add(checkdeep);
            checkboxlist.Add(check9c);
            checkboxlist.Add(check9l);
            checkboxlist.Add(check9r);
            checkboxlist.Add(check1c);
            checkboxlist.Add(check1l);
            checkboxlist.Add(check1r);
            checkboxlist.Add(check2c);
            checkboxlist.Add(check2l);
            checkboxlist.Add(check2r);
            checkboxlist.Add(check3c);
            checkboxlist.Add(check3l);
            checkboxlist.Add(check3r);
            checkboxlist.Add(check4c);
            checkboxlist.Add(check4l);
            checkboxlist.Add(check4r);
            checkboxlist.Add(check5c);
            checkboxlist.Add(check5l);
            checkboxlist.Add(check5r);
            checkboxlist.Add(check6c);
            checkboxlist.Add(check6l);
            checkboxlist.Add(check6r);
            checkboxlist.Add(check7c);
            checkboxlist.Add(check7l);
            checkboxlist.Add(check7r);
            checkboxlist.Add(check8c);
            checkboxlist.Add(check8l);
            checkboxlist.Add(check8r);

            dataGridView1.Rows.Add(19);

            forest = new FOREST(MainForm.save.B2W2 ? MainForm.save.getBlockDec(60) : MainForm.save.getBlockDec(61));
            unlock8box.SelectedIndex = forest.Unlock8;
            unlock9.SelectedIndex = forest.Unlock9;
            forest.Area = 4;
            forest.Indexpkm = 0;
            slot.Value = forest.Indexpkm;
            slot.Maximum = 19;
            check1c.Checked = true;
            updateslot();
            updatearea();


            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void updatearea()
        {
            int i = 0;
            foreach (RadioButton item in checkboxlist)
            {
                if (forest.Unlock9 == 1 && (i > 0 && i < 4))
                {
                    item.Enabled = true;
                }
                else if (forest.Unlock9 == 0 && (i > 0 && i < 4))
                {
                    item.Enabled = false;
                }
                switch (forest.Unlock8)
                {
                    case 0x0:
                        if (i > 3 && i < 10)
                            item.Enabled = true;
                        else if (i > 9)
                            item.Enabled = false;
                        break;
                    case 0x1:
                        if (i > 9 && i < 13)
                            item.Enabled = true;
                        else if (i >= 13)
                            item.Enabled = false;
                        break;
                    case 0x2:
                        if (i > 9 && i < 16)
                            item.Enabled = true;
                        else if (i >= 16)
                            item.Enabled = false;
                        break;
                    case 0x3:
                        if (i > 9 && i < 19)
                            item.Enabled = true;
                        else if (i >= 19)
                            item.Enabled = false;
                        break;
                    case 0x4:
                        if (i > 9 && i < 22)
                            item.Enabled = true;
                        else if (i >= 22)
                            item.Enabled = false;
                        break;
                    case 0x5:
                        if (i > 9 && i < 25)
                            item.Enabled = true;
                        else if (i >= 25)
                            item.Enabled = false;
                        break;
                    case 0x6:
                        if (i > 9 && i < 28)
                            item.Enabled = true;
                        else if (i >= 28)
                            //We should never reach this point
                            MessageBox.Show("更新区域错误 1");
                        break;
                    default:
                        MessageBox.Show("更新区域错误 2");
                        break;

                }
                i++;
            }

            i = 0;
            foreach (RadioButton item in checkboxlist)
            {
                if (item.Checked)
                {
                    forest.Area = i;
                }

                i++;
            }
            if (forest.Area > 0 && forest.Area < 4)
                slot.Maximum = 9;
            else
                slot.Maximum = 19;

            forest.Indexpkm = 0;
            slot.Value = forest.Indexpkm;

            if (forest.Area > 0 && forest.Area < 4) //Area 9 ony holds 10 pokes
            {

                hiderows.Visible = true;
                /*
        		if (dataGridView1.Rows.Count == 20)
        		{
        			for (i=18;i>9;i--)
        				dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
        		}*/

            }
            else
            {
                hiderows.Visible = false;
                /*
        		if (dataGridView1.Rows.Count == 10)
        		{

	        		for (i=0;i<10;i++)
		        		dataGridView1.Rows.Add();
        		}
        		*/
            }

            updateGrid();
            updateslot();

        }

        void updateslot()
        {
            spbox1.SelectedIndex = forest.Species;
            move1box.SelectedIndex = forest.Move;
            genderbox1.SelectedIndex = forest.Gender;
            formbox1.SelectedIndex = forest.Form;
            animbox1.SelectedIndex = (forest.Animation / 2);
        }

        void SlotValueChanged(object sender, EventArgs e)
        {
            forest.Indexpkm = (int)slot.Value;
            updateslot();

        }
        void areaChanged(object sender, EventArgs e)
        {
            updatearea();
            updateslot();
        }
        void Unlock8boxSelectedIndexChanged(object sender, EventArgs e)
        {
            forest.Unlock8 = (byte)unlock8box.SelectedIndex;
            updatearea();
            updateslot();
        }
        void Unlock9SelectedIndexChanged(object sender, EventArgs e)
        {
            forest.Unlock9 = (byte)unlock9.SelectedIndex;
            updatearea();
            updateslot();
        }
        void updateGrid()
        {
            int i;
            int temp = forest.Indexpkm;
            for (i = 0; i <= slot.Maximum; i++)
            {
                if (forest.Area > 0 && forest.Area <= 3 && i > 9)
                {
                    dataGridView1.Rows[i].Cells[0].Value = " ";
                    dataGridView1.Rows[i].Cells[1].Value = " ";
                    dataGridView1.Rows[i].Cells[2].Value = " ";
                    dataGridView1.Rows[i].Cells[3].Value = " ";
                    dataGridView1.Rows[i].Cells[4].Value = " ";
                }
                else
                {
                    forest.Indexpkm = i;
                    if (forest.Species == 0)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = " ";
                        dataGridView1.Rows[i].Cells[1].Value = " ";
                        dataGridView1.Rows[i].Cells[2].Value = " ";
                        dataGridView1.Rows[i].Cells[3].Value = " ";
                        dataGridView1.Rows[i].Cells[4].Value = " ";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[0].Value = TEXT.pkmlist[forest.Species];
                        dataGridView1.Rows[i].Cells[1].Value = TEXT.movelist[forest.Move];
                        switch (forest.Gender)
                        {
                            case 0:
                                dataGridView1.Rows[i].Cells[2].Value = "雄性";
                                break;
                            case 1:
                                dataGridView1.Rows[i].Cells[2].Value = "雌性";
                                break;
                            case 2:
                                dataGridView1.Rows[i].Cells[2].Value = "无性别";
                                break;
                        }
                        dataGridView1.Rows[i].Cells[3].Value = forest.Form;
                        //dataGridView1.Rows[i].Cells[4].Value = forest.Animation;
                        switch (forest.Animation)
                        {
                            case 0:
                                dataGridView1.Rows[i].Cells[4].Value = "0" + forest.Animation.ToString() + "- " + "随机转动";

                                break;
                            case 2:
                                dataGridView1.Rows[i].Cells[4].Value = "0" + forest.Animation.ToString() + "- " + "随机走动";
                                break;
                            case 4:
                                dataGridView1.Rows[i].Cells[4].Value = "0" + forest.Animation.ToString() + "- " + "随机走动";
                                break;
                            case 6:
                                dataGridView1.Rows[i].Cells[4].Value = "0" + forest.Animation.ToString() + "- " + "上下走动";
                                break;
                            case 8:
                                dataGridView1.Rows[i].Cells[4].Value = "0" + forest.Animation.ToString() + "- " + "左右走动";
                                break;
                            case 10:
                                dataGridView1.Rows[i].Cells[4].Value = forest.Animation.ToString() + "- " + "左右走动并随机上下观察";
                                break;
                            case 12:
                                dataGridView1.Rows[i].Cells[4].Value = forest.Animation.ToString() + "- " + "顺时针转动";
                                break;
                            case 14:
                                dataGridView1.Rows[i].Cells[4].Value = forest.Animation.ToString() + "- " + "逆时针转动";
                                break;
                            default:
                                dataGridView1.Rows[i].Cells[4].Value = forest.Animation.ToString() + "- " + "无效";
                                break;
                        }

                    }

                }
            }
            forest.Indexpkm = temp;
        }
        void DataGridView1CurrentCellChanged(object sender, EventArgs e)
        {
            slot.Value = (int)dataGridView1.CurrentRow.Index;
        }
        int animation()
        {
            //MessageBox.Show(animbox1.SelectedIndex.ToString());
            if (animbox1.SelectedIndex > 7)
                return Entralink_DreamWorld.random_form_anim();
            else
            {
                //MessageBox.Show((animbox1.SelectedIndex*2).ToString());
                return (int)(animbox1.SelectedIndex * 2);
            }
        }
        void Add_pkmClick(object sender, EventArgs e)
        {
            forest.add_pkm(forest.create_pkm((int)spbox1.SelectedIndex, (int)move1box.SelectedIndex, (int)genderbox1.SelectedIndex, (int)formbox1.SelectedIndex, animation()));
            updateGrid();
        }
        void Del_pkmClick(object sender, EventArgs e)
        {
            forest.delete_pkm();
            updateGrid();
        }
        void Edit_pkmClick(object sender, EventArgs e)
        {
            //If slot is empty, add pokemon instead
            if (forest.is_pkm_empty() == true)
            {
                forest.add_pkm(forest.create_pkm((int)spbox1.SelectedIndex, (int)move1box.SelectedIndex, (int)genderbox1.SelectedIndex, (int)formbox1.SelectedIndex, animation()));
                updateGrid();
            }
            else
            {
                forest.edit_pkm(forest.create_pkm((int)spbox1.SelectedIndex, (int)move1box.SelectedIndex, (int)genderbox1.SelectedIndex, (int)formbox1.SelectedIndex, animation()));
                updateGrid();
            }
        }
        void Exit_butClick(object sender, EventArgs e)
        {
            this.Close();
        }
        void Saveexit_butClick(object sender, EventArgs e)
        {
            if (MainForm.save.B2W2 == true)
                MainForm.save.setBlockCrypt(forest.Data, 60);
            else
                MainForm.save.setBlockCrypt(forest.Data, 61);

            this.Close();
        }
        void Export_areaClick(object sender, EventArgs e)
        {
            forest.dump_area();
        }
        void Import_areaClick(object sender, EventArgs e)
        {
            forest.import_area();
            updatearea();
        }
        void Export_forestClick(object sender, EventArgs e)
        {
            forest.export_forest();
            updatearea();
        }
        void Import_forestClick(object sender, EventArgs e)
        {
            forest.import_forest();
            updatearea();
        }

        public static int[] BW2_sprites =
        {
            505, 507, 510, 511, 513, 515, 519, 523, 525, 527,
            529, 531, 533, 535, 538, 539, 542, 545, 546, 548,
            550, 553, 556, 558, 559, 531, 564, 569, 572, 575,
            578, 580, 582, 587, 588, 594, 596, 600, 605, 607,
            610, 613, 616, 618, 619, 621, 622, 624, 626, 628,
            630, 631, 632
        };

        public static int[] BW_femaleonly =
        {
            029, 030, 031, 113, 115, 124, 238, 241, 242, 314,
            380, 413, 416, 440, 478, 488, 548, 549, 629, 630
        };

        public static int[] BW_maleonly =
        {
            032, 033, 034, 106, 107, 128, 236, 237, 313, 381,
            414, 475, 538, 539, 627, 628, 641, 642, 645
        };

        public static int[] BW_genderless =
        {
            081, 082, 100, 101, 120, 121, 132, 137, 144, 145,
            146, 150, 151, 201, 233, 243, 244, 245, 249, 250,
            251, 292, 337, 338, 343, 344, 374, 375, 376, 377,
            378, 379, 382, 383, 384, 385, 386, 436, 437, 462,
            474, 479, 480, 481, 482, 483, 484, 486, 487, 489,
            490, 491, 492, 493, 494, 599, 600, 601, 615, 622,
            623, 638, 639, 640, 643, 644, 646, 647, 648, 649
        };

        public static int[] BW_forms =
        {
            201, 386, 412, 413, 422, 423, 479, 487, 492, 550,
            585, 586, 648
        };

        void Spbox1SelectedIndexChanged(object sender, EventArgs e)
        {
            //Handle species without sprites
            int i = 0;
            if (MainForm.save.B2W2 == true && spbox1.SelectedIndex > 493)
            {

                for (i = 0; i < 53; i++)
                {
                    if (spbox1.SelectedIndex == BW2_sprites[i])
                    {
                        sprite_warning.Text = "";
                        break;
                    }
                    else
                        sprite_warning.Text = "选中的宝可梦不存在供黑白2的图像";
                }
            }
            else if (spbox1.SelectedIndex > 493)
            {
                sprite_warning.Text = "选中的宝可梦不存在供黑白的图像";
            }
            else
            {
                sprite_warning.Text = "";
            }

            //Handle genders
            bool special_gender = false;
            for (i = 0; i < BW_femaleonly.Length; i++)
            {
                if (spbox1.SelectedIndex == BW_femaleonly[i])
                {
                    //Only female
                    special_gender = true;
                    genderbox1.SelectedIndex = 1;
                    genderbox1.Enabled = false;
                }
            }

            for (i = 0; i < BW_maleonly.Length; i++)
            {
                if (spbox1.SelectedIndex == BW_maleonly[i])
                {
                    //Only male
                    special_gender = true;
                    genderbox1.SelectedIndex = 0;
                    genderbox1.Enabled = false;
                }
            }

            for (i = 0; i < BW_genderless.Length; i++)
            {
                if (spbox1.SelectedIndex == BW_genderless[i])
                {
                    //Only genderless
                    special_gender = true;
                    genderbox1.Items.Clear();
                    genderbox1.Items.AddRange(new object[] {
                        "雄性",
                        "雌性",
                        "无性别"});
                    genderbox1.SelectedIndex = 2;
                    genderbox1.Enabled = false;
                }
            }

            if (special_gender == false)
            {
                //Re-enable list
                genderbox1.Enabled = true;
                genderbox1.Items.Clear();
                genderbox1.Items.AddRange(new object[] {
                        "雄性",
                        "雌性"});
            }

            //Handle forms
            formbox1.Enabled = true;
            formbox1.Items.Clear();
            switch (spbox1.SelectedIndex)
            {
                case 201:
                    formbox1.Items.AddRange(new object[] {
                                "A",
                                "B",
                                "C",
                                "D",
                                "E",
                                "F",
                                "G",
                                "H",
                                "I",
                                "J",
                                "K",
                                "L",
                                "M",
                                "N",
                                "O",
                                "P",
                                "Q",
                                "R",
                                "S",
                                "T",
                                "U",
                                "V",
                                "W",
                                "X",
                                "Y",
                                "Z",
                                "!",
                                "?"});
                    if (forest.Form > 27)
                        formbox1.SelectedIndex = 0;
                    else
                        formbox1.SelectedIndex = forest.Form;
                    break;
                case 386:

                    formbox1.Items.AddRange(new object[] {
                        "普通形态",
                        "攻击的样子",
                        "防御的样子",
                        "速度的样子"});
                    if (forest.Form > 4)
                        formbox1.SelectedIndex = 0;
                    else
                        formbox1.SelectedIndex = forest.Form;
                    break;
                case 412:
                case 413:
                    formbox1.Items.AddRange(new object[] {
                        "草木蓑衣",
                        "砂土蓑衣",
                        "垃圾蓑衣"});
                    if (forest.Form > 3)
                        formbox1.SelectedIndex = 0;
                    else
                        formbox1.SelectedIndex = forest.Form;
                    break;
                case 422:
                case 423:
                    formbox1.Items.AddRange(new object[] {
                        "西海",
                        "东海"});
                    if (forest.Form > 2)
                        formbox1.SelectedIndex = 0;
                    else
                        formbox1.SelectedIndex = forest.Form;
                    break;
                case 479:
                    formbox1.Items.AddRange(new object[] {
                        "洛托姆",
                        "加热洛托姆",
                        "清洗洛托姆",
                        "结冰洛托姆",
                        "旋转洛托姆",
                        "切割洛托姆"});
                    if (forest.Form > 6)
                        formbox1.SelectedIndex = 0;
                    else
                        formbox1.SelectedIndex = forest.Form;
                    break;
                case 487:
                    formbox1.Items.AddRange(new object[] {
                        "别种形态",
                        "起源形态"});
                    if (forest.Form > 2)
                        formbox1.SelectedIndex = 0;
                    else
                        formbox1.SelectedIndex = forest.Form;
                    break;
                case 492:
                    formbox1.Items.AddRange(new object[] {
                        "陆上形态",
                        "天空形态"});
                    if (forest.Form > 2)
                        formbox1.SelectedIndex = 0;
                    else
                        formbox1.SelectedIndex = forest.Form;
                    break;
                case 550:
                    formbox1.Items.AddRange(new object[] {
                        "红条纹的样子",
                        "蓝条纹的样子"});
                    if (forest.Form > 2)
                        formbox1.SelectedIndex = 0;
                    else
                        formbox1.SelectedIndex = forest.Form;
                    break;
                case 585:
                case 586:
                    formbox1.Items.AddRange(new object[] {
                        "冬天的样子",
                        "春天的样子",
                        "夏天的样子",
                        "秋天的样子"});
                    if (forest.Form > 4)
                        formbox1.SelectedIndex = 0;
                    else
                        formbox1.SelectedIndex = forest.Form;
                    break;
                case 648:
                    formbox1.Items.AddRange(new object[] {
                        "歌声形态",
                        "舞步形态"});
                    if (forest.Form > 2)
                        formbox1.SelectedIndex = 0;
                    else
                        formbox1.SelectedIndex = forest.Form;
                    break;
                default:
                    formbox1.Enabled = false;
                    formbox1.Items.Add("");
                    formbox1.SelectedIndex = 0;
                    break;
            }

        }
        public static UInt32 dream_pkm = 0;
        void add_dw_pkm()
        {
            //Add dream pokemon!
            if (dream_pkm != 0)
            {

                //Arceus warning
                if ((dream_pkm & 0x7FF) == 493 && forest.Area != 1)
                    MessageBox.Show("警告！PGL阿尔宙斯是特殊事件，应当位于区域 中9！\n\n我不清楚是否有其他宝可梦被配信在特殊区域，我只知道象牙猪和多边兽曾和其它宝梦世界宝可梦被下载，所以阿尔宙斯应该是唯一的特殊情况。关于此主题的任何信息欢迎交流提供。");

                //If slot is empty, add pokemon instead
                if (forest.is_pkm_empty() == true)
                {
                    forest.add_pkm(dream_pkm);
                    updateGrid();
                }
                else
                {
                    forest.edit_pkm(dream_pkm);
                    updateGrid();
                }
            }
            dream_pkm = 0;
        }

        void Pleasant_butClick(object sender, EventArgs e)
        {
            Form dreamworld = new Entralink_DreamWorld(0, "小小森林");
            dreamworld.ShowDialog();
            add_dw_pkm();
        }
        void Wind_butClick(object sender, EventArgs e)
        {
            Form dreamworld = new Entralink_DreamWorld(1, "广阔天空");
            dreamworld.ShowDialog();
            add_dw_pkm();
        }
        void Spark_butClick(object sender, EventArgs e)
        {
            Form dreamworld = new Entralink_DreamWorld(2, "闪亮海洋");
            dreamworld.ShowDialog();
            add_dw_pkm();
        }
        void Spooky_butClick(object sender, EventArgs e)
        {
            Form dreamworld = new Entralink_DreamWorld(3, "古老洋馆");
            dreamworld.ShowDialog();
            add_dw_pkm();
        }
        void Rugged_butClick(object sender, EventArgs e)
        {
            Form dreamworld = new Entralink_DreamWorld(4, "崎岖山脉");
            dreamworld.ShowDialog();
            add_dw_pkm();
        }
        void Icy_butClick(object sender, EventArgs e)
        {
            Form dreamworld = new Entralink_DreamWorld(5, "凉爽洞穴");
            dreamworld.ShowDialog();
            add_dw_pkm();
        }
        void Dream_butClick(object sender, EventArgs e)
        {
            Form dreamworld = new Entralink_DreamWorld(6, "梦境公园");
            dreamworld.ShowDialog();
            add_dw_pkm();
        }
        void pkmcafe_butClick(object sender, EventArgs e)
        {
            Form dreamworld = new Entralink_DreamWorld(7, "宝可梦咖啡馆森林");
            dreamworld.ShowDialog();
            add_dw_pkm();
        }
        void Pgl_butClick(object sender, EventArgs e)
        {
            Form dreamworld = new Entralink_DreamWorld(8, "PGL促销");
            dreamworld.ShowDialog();
            add_dw_pkm();
        }


        public class FOREST
        {

            internal int Size = MainForm.save.B2W2 ? MainForm.save.getBlockLength(60) : MainForm.save.getBlockLength(61);

            public byte[] Data;
            public FOREST(byte[] data = null)
            {
                Data = data ?? new byte[Size];
            }

            private int area = 4;
            private int indexpkm = 0;
            private int total_areas = (9 * 3) + 1;
            private int area_size = 0x50;
            private int deep_area_size = 0x28;
            private int pkmnsize = 4;
            public int Area
            {
                get { return area; }
                set { if ((value >= 0) && (value < total_areas)) { area = value; } }
            }
            public int Indexpkm
            {
                get { return indexpkm; }
                set { if ((value >= 0) && (value < 20)) { indexpkm = (int)(value); } }
            }
            public byte Unlock9
            {
                get { return Data[0x848]; }
                set { Data[0x848] = value; }
            }
            public byte Unlock8
            {
                get { return Data[0x849]; }
                set { Data[0x849] = value; }
            }
            internal int get_pkmoffset()
            {

                if (area == 0) //Deepest area
                {
                    if (indexpkm > 19) return -1;
                    return indexpkm * pkmnsize;
                }
                else if (area > 0 && area < 4) //Area 9 ony holds 10 pokes
                {
                    if (indexpkm > 9) return -1;
                    return area_size + (indexpkm * pkmnsize) + deep_area_size * area - deep_area_size;
                }
                else if (area > 3 && area < 28) //Areas 1-8
                {
                    if (indexpkm > 19) return -1;
                    return area_size + (deep_area_size * 3) + ((area - 4) * area_size) + (indexpkm * pkmnsize);
                }
                else
                    return -1;
            }

            public void dump_area()
            {
                int tmp_slot = indexpkm;

                byte[] phl = new byte[4 * 20];

                indexpkm = 0;

                if (area > 0 && area < 4) //Area 9 ony holds 10 pokes
                {
                    for (indexpkm = 0; indexpkm < 10; indexpkm++)
                    {
                        BitConverter.GetBytes(get_pkm()).CopyTo(phl, indexpkm * 4);
                    }
                }
                else
                {
                    for (indexpkm = 0; indexpkm < 20; indexpkm++)
                    {
                        BitConverter.GetBytes(get_pkm()).CopyTo(phl, indexpkm * 4);
                    }
                }

                indexpkm = tmp_slot;

                FileIO.save_file(phl, "连入之森区域数据|*.phl|所有文件(*.*)|*.*");
            }

            public void import_area()
            {


                byte[] phl = new byte[4 * 20];
                string path = null;
                FileIO.load_file(ref phl, ref path, "连入之森区域数据|*.phl|所有文件(*.*)|*.*");

                UInt32 temp_pkm = 0;

                indexpkm = 0;

                if (area > 0 && area < 4) //Area 9 ony holds 10 pokes
                {
                    for (indexpkm = 0; indexpkm < 10; indexpkm++)
                    {
                        temp_pkm = BitConverter.ToUInt32(phl, indexpkm * 4);
                        edit_pkm(temp_pkm);
                    }
                }
                else
                {
                    for (indexpkm = 0; indexpkm < 20; indexpkm++)
                    {
                        temp_pkm = BitConverter.ToUInt32(phl, indexpkm * 4);
                        edit_pkm(temp_pkm);
                    }
                }

                indexpkm = 0;
            }

            public void export_forest()
            {
                FileIO.save_file(Data, "连入之森解密数据|*.efdd|所有文件(*.*)|*.*");
            }

            public void import_forest()
            {


                byte[] forest = new byte[2304];
                string path = null;
                FileIO.load_file(ref forest, ref path, "连入之森解密数据|*.efdd|所有文件(*.*)|*.*");

                Data = forest;

                indexpkm = 0;
            }

            /*
            Pokemon Structure (4 bytes)
            Bits
            00-10   Species
            11-20   Special Move
            21-22   Gender (0 -> male, 1 -> female, 2 -> genderless)
            23-27   Form
            28-31   Animation (only even numbers allowed, last bit makes Pokemon invisible)
            */
            private int species;
            private int move;
            private int gender;
            private int form;
            private int animation;

            public int Species
            {
                get { return (int)(BitConverter.ToInt32(Data, get_pkmoffset()) & 0x7FF); }
                set { species = value; }
            }
            public int Move
            {
                get { return (int)((BitConverter.ToInt32(Data, get_pkmoffset()) & 0x1FF800) >> 11); }
                set { move = value; }
            }
            public int Gender
            {
                get { return (int)((BitConverter.ToInt32(Data, get_pkmoffset()) & 0x600000) >> 21); }
                set { gender = value; }
            }
            public int Form
            {
                get { return (int)((BitConverter.ToInt32(Data, get_pkmoffset()) & 0xF800000) >> 23); }
                set { form = value; }
            }
            public int Animation
            {
                get { return (int)((BitConverter.ToInt32(Data, get_pkmoffset()) & 0xF0000000) >> 28); }
                set { animation = value; }
            }

            //Just return if there's a valid pkm in current slot
            public bool is_pkm_empty()
            {
                if (Species == 0)
                    return true;
                else
                    return false;
            }
            public UInt32 get_pkm() //Relies on current indexpkm
            {
                return BitConverter.ToUInt32(Data, get_pkmoffset());
            }
            //Build a u32 pkm for entralink forest
            public UInt32 create_pkm(int sp, int mv, int gdr, int frm, int anim)
            {
                return unchecked((UInt32)((sp & 0x7FF) | ((mv & 0x3FF) << 11) | ((gdr & 0x3) << 21) | ((frm & 0x1F) << 23) | ((anim & 0xF) << 28)));
            }
            //Sets pkm data to current slot
            public void edit_pkm(UInt32 pkm)
            {
                Array.Copy(BitConverter.GetBytes(pkm), 0, Data, get_pkmoffset(), 4);
            }
            //Sets pkm data to first available slot, if there's one
            public void add_pkm(UInt32 pkm)
            {
                int tmp_slot = indexpkm;
                bool found_empty = false;
                //Find first available slot
                if (area > 0 && area < 4) //Area 9 ony holds 10 pokes
                {
                    for (indexpkm = 0; indexpkm < 10; indexpkm++)
                    {
                        if (is_pkm_empty() == true)
                        {
                            found_empty = true;
                            break;
                        }
                    }
                }
                else
                {
                    for (indexpkm = 0; indexpkm < 20; indexpkm++)
                    {
                        if (is_pkm_empty() == true)
                        {
                            found_empty = true;
                            break;
                        }
                    }
                }

                if (found_empty == true)
                    Array.Copy(BitConverter.GetBytes(pkm), 0, Data, get_pkmoffset(), 4);
                else
                    MessageBox.Show("此区域没有多余槽位了");

                indexpkm = tmp_slot;
            }
            //deletes current slot
            //todo: move all slots up
            public void delete_pkm()
            {
                int tmp_slot = indexpkm;
                UInt32 temp_pkm = 0;

                //Delete selected pkm
                UInt32 delete = 0;
                Array.Copy(BitConverter.GetBytes(delete), 0, Data, get_pkmoffset(), 4);

                //Move all pkm up 1 slot
                int i;
                if (area > 0 && area < 4) //Area 9 ony holds 10 pokes
                {
                    if (indexpkm != 9)//If user didn't delete last slot
                    {
                        for (i = indexpkm; i < 9; i++)
                        {
                            //Get next pkm
                            indexpkm = indexpkm + 1;
                            temp_pkm = BitConverter.ToUInt32(Data, get_pkmoffset());
                            //Set to previous slot
                            indexpkm = indexpkm - 1;
                            edit_pkm(temp_pkm);
                            //Return index to next slot
                            indexpkm = indexpkm + 1;
                        }
                        //Now empty last slot
                        temp_pkm = 0;
                        edit_pkm(temp_pkm);
                    }
                }
                else
                {
                    if (indexpkm != 19)//If user didn't delete last slot
                    {
                        for (i = indexpkm; i < 19; i++)
                        {
                            //Get next pkm
                            indexpkm = indexpkm + 1;
                            temp_pkm = BitConverter.ToUInt32(Data, get_pkmoffset());
                            //Set to previous slot
                            indexpkm = indexpkm - 1;
                            edit_pkm(temp_pkm);
                            //Return index to next slot
                            indexpkm = indexpkm + 1;
                        }
                        //Now empty last slot
                        temp_pkm = 0;
                        edit_pkm(temp_pkm);
                    }
                }

                indexpkm = tmp_slot;
            }
        }
    }
}

/* Structure gathered by BlackShark

General Structure
0x000   encrypted data
0x84C   initial encryption seed
0x850   update counter
0x852   checksum from 0x000 to 0x84F (CRC16-CCITT)
 
Decrypted Data Structure (0x000 - 0x84B)
20 Pokemon in each area from 1 - 8 as well as in the deepest area.
10 Pokemon in 9th area.
So they let you store a total of 530 Pokemon there!
 
0x000   Deepest Area
0x050   9th Area center
0x078   9th Area left
0x0A0   9th Area right
0x0C8   1st Area center
0x118   1st Area left
0x168   1st Area right
0x1B8   2nd Area center
0x208   2nd Area left
0x258   2nd Area right
0x2A8   3rd Area center
0x2F8   3rd Area left
0x348   3rd Area right
0x398   4th Area center
0x3E8   4th Area left
0x438   4th Area right
0x488   5th Area center
0x4D8   5th Area left
0x528   5th Area right
0x578   6th Area center
0x5C8   6th Area left
0x618   6th Area right
0x668   7th Area center
0x6B8   7th Area left
0x708   7th Area right
0x758   8th Area center
0x7A8   8th Area left
0x7F8   8th Area right
0x848   Unlock Area 9 (0x01 to unlock)
0x849   Unlock Areas 3 - 8 (0x00 - 0x06, any higher value will corrupt your forest!) (Area 1 & 2 and the deepest Area are unlocked by default -> 0x00)
0x84A   0x00
0x84B   0x00
 
Pokemon Structure (4 bytes)
Bits
00-10   Species
11-20   Special Move
21-22   Gender (0 -> male, 1 -> female, 2 -> genderless)
23-27   Form
28-31   Animation (only even numbers allowed, last bit makes Pokemon invisible)
*/

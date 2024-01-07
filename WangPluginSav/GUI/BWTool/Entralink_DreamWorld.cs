/*
 * Created by SharpDevelop.
 * User: sergi
 * Date: 15/06/2016
 * Time: 10:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
    /// <summary>
    /// Description of Entralink_DreamWorld.
    /// </summary>
    public partial class Entralink_DreamWorld : Form
    {
        public Entralink_DreamWorld(int DW, string Area)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            area_label.Text = Area;
            exclusive_label.Text = "";
            world = DW;
            setup_world();
            if (DW < 8)
            {
                moveboxA.Visible = true;
                moveboxC.Visible = true;
                atkA.Visible = true;
                atkB.Visible = true;
                atkC.Visible = true;

                Move.Text = "招式";

                pgl_region_box.Visible = false;
                region_lab.Visible = false;
                move_lab.Visible = false;
            }
            else if (DW == 8)
            {
                moveboxA.Visible = false;
                moveboxC.Visible = false;
                atkA.Visible = false;
                atkB.Visible = false;
                atkC.Visible = false;

                Move.Text = "信息";

                pgl_region_box.Visible = true;
                region_lab.Visible = true;
                move_lab.Visible = true;
            }

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }



        private int world = 0;
        private void setup_world()
        {
            switch (world)
            {
                case 0://Pleasant forest
                    speciesbox.Items.Clear();
                    speciesbox.Items.AddRange(new object[] {
                        "小拉达",
                        "尼多兰(BW*)",
                        "尼多朗(BW*)",
                        "走路草",
                        "喇叭芽",
                        "小火马",
                        "大葱鸭",
                        "嘟嘟",
                        "蛋蛋",
                        "大舌头",
                        "蔓藤怪",
                        "袋兽",
                        "尾立",
                        "宝宝丁(BW*)",
                        "咩利羊",
                        "毽子草(BW*)",
                        "向日种子",
                        "惊角鹿",
                        "土狼犬",
                        "莲叶童子(BW*)",
                        "傲骨燕(BW*)",
                        "溜溜糖球",
                        "大牙狸",
                        "小猫怪",
                        "圆蝌蚪(B2W2*)",
                        "木棉球(B2W2*)",
                        "百合根娃娃(B2W2*)",
                        "盖盖虫(B2W2*)",
                        "小嘴蜗(B2W2*)",
                        "魅力喵",
                        "蜈蚣王(B2W2*)",
                        "可达鸭",
                        "卡蒂狗",
                        "飞天螳螂",
                        "肯泰罗",
                        "玛力露",
                        "树才怪",
                        "麒麟奇",
                        "大奶罐",
                        "蛇纹熊",
                        "落雷兽(BW*)",
                        "飘浮泡泡(BW*)",
                        "帕奇利兹(BW*)",
                        "卷卷耳",
                        "六尾",
                        "蚊香蝌蚪",
                        "天然雀",
                        "电击怪",
                        "向尾喵"});
                    speciesbox.SelectedIndex = 0;
                    break;
                case 1://Windskept Sky
                    speciesbox.Items.Clear();
                    speciesbox.Items.AddRange(new object[] {
                        "巴大蝶(BW*)",
                        "波波",
                        "烈雀",
                        "超音蝠",
                        "化石翼龙",
                        "咕咕(BW*)",
                        "芭瓢虫",
                        "毽子草",
                        "蜻蜻蜓",
                        "黑暗鸦",
                        "天蝎",
                        "信使鸟",
                        "傲骨燕",
                        "长翅鸥(BW*)",
                        "青绵鸟(BW*)",
                        "姆克鸟",
                        "豆豆鸽(B2W2*)",
                        "象征鸟(B2W2*)",
                        "鸭宝宝(B2W2*)",
                        "电飞鼠(B2W2*)",
                        "盔甲鸟",
                        "热带龙",
                        "飘飘球(BW*)",
                        "聒噪鸟(BW*)"});
                    speciesbox.SelectedIndex = 0;
                    break;
                case 2:
                    speciesbox.Items.Clear();
                    speciesbox.Items.AddRange(new object[] {
                        "呆呆兽(BW*)",
                        "小海狮",
                        "大舌贝",
                        "大钳蟹(BW*)",
                        "墨海马",
                        "角金鱼",
                        "金鱼王(BW*)",
                        "海星星(BW*)",
                        "鲤鱼王",
                        "菊石兽",
                        "化石盔",
                        "灯笼鱼",
                        "乌波",
                        "千针鱼",
                        "太阳珊瑚(BW*)",
                        "铁炮鱼",
                        "巨翅飞鱼",
                        "吼吼鲸",
                        "泥泥鳅",
                        "珍珠贝",
                        "古空棘鱼",
                        "爱心鱼",
                        "泳圈鼬",
                        "荧光鱼",
                        "野蛮鲈鱼(红条纹的样子)(B2W2*)",
                        "野蛮鲈鱼(蓝条纹的样子)(B2W2*)",
                        "保姆曼波(B2W2*)",
                        "泥巴鱼(B2W2*)",
                        "原盖海龟(B2W2*)",
                        "玛瑙水母",
                        "利牙鱼",
                        "龙虾小兵",
                        "触手百合",
                        "太古羽虫",
                        "丑丑鱼",
                        "无壳海兔(西海)(BW*)",
                        "无壳海兔(东海)(BW*)",
                        "拉普拉斯",
                        "迷你龙"});
                    speciesbox.SelectedIndex = 0;
                    break;
                case 3: // Spooky Mannor
                    speciesbox.Items.Clear();
                    speciesbox.Items.AddRange(new object[] {
                        "鬼斯",
                        "催眠貘",
                        "魔墙人偶",
                        "圆丝蛛",
                        "梦妖",
                        "果然翁(BW*)",
                        "戴鲁比",
                        "迷唇娃(BW*)",
                        "大嘴娃(BW*)",
                        "玛沙那(BW*)",
                        "跳跳猪",
                        "怨影娃娃",
                        "夜巡灵",
                        "风铃铃",
                        "臭鼬噗",
                        "铜镜怪(BW*)",
                        "小灰怪(B2W2*)",
                        "驹刀小兵(B2W2*)",
                        "电蜘蛛(B2W2*)",
                        "喵喵(BW*)",
                        "布鲁",
                        "图图犬",
                        "电萤虫",
                        "甜甜萤",
                        "洛托姆(BW*)",
                        "凯西",
                        "拉鲁拉丝(BW*)",
                        "勾魂眼(BW*)",
                        "花岩怪(BW*)",
                        "双卵细胞球(B2W2*)",
                        "泥偶小人(B2W2*)"});
                    speciesbox.SelectedIndex = 0;
                    break;
                case 4:
                    speciesbox.Items.Clear();
                    speciesbox.Items.AddRange(new object[] {
                        "猴怪(BW*)",
                        "腕力",
                        "小磁怪",
                        "瓦斯弹",
                        "独角犀牛(BW*)",
                        "熔岩虫",
                        "小小象(BW*)",
                        "幼基拉斯",
                        "煤炭龟",
                        "大颚蚁",
                        "刺球仙人掌",
                        "结草儿",
                        "沙河马",
                        "钳尾蝎(BW*)",
                        "熔蚁兽(B2W2*)",
                        "铁蚁(B2W2*)",
                        "沙铃仙人掌(B2W2*)",
                        "岩殿居蟹(B2W2*)",
                        "鸭嘴宝宝",
                        "熊宝宝(BW*)",
                        "幕下力士(BW*)",
                        "呆火驼",
                        "晃晃斑(BW*)",
                        "阿勃梭鲁",
                        "铁哑铃(BW*)",
                        "不良蛙",
                        "无畏小子",
                        "宝贝龙",
                        "流氓鳄(B2W2*)",
                        "利欧路(BW*)"});
                    speciesbox.SelectedIndex = 0;
                    break;
                case 5: //Icy cave
                    speciesbox.Items.Clear();
                    speciesbox.Items.AddRange(new object[] {
                        "穿山鼠",
                        "小拳石",
                        "大岩蛇",
                        "霹雳电球",
                        "卡拉卡拉",
                        "皮宝宝(BW*)",
                        "壶壶(BW*)",
                        "咕妞妞",
                        "朝北鼻(BW*)",
                        "可可多拉",
                        "月石",
                        "太阳岩",
                        "天秤偶",
                        "海豹球(BW*)",
                        "头盖龙(BW*)",
                        "雪笠怪",
                        "螺钉地鼠(B2W2*)",
                        "赤面龙(B2W2*)",
                        "地鼠",
                        "土龙弟弟(BW*)",
                        "地幔岩(B2W2*)",
                        "多多冰(B2W2*)",
                        "齿轮组(B2W2*)",
                        "狃拉",
                        "雪童子",
                        "盾甲龙(BW*)",
                        "小山猪",
                        "圆陆鲨",
                        "牙牙(B2W2*)"});
                    speciesbox.SelectedIndex = 0;
                    break;
                case 6: //Dream Park
                    speciesbox.Items.Clear();
                    speciesbox.Items.AddRange(new object[] {
                        "派拉斯",
                        "榛果球",
                        "刺尾虫",
                        "橡实果",
                        "懒人獭",
                        "土居忍士",
                        "正电拍拍",
                        "负电拍拍",
                        "溶食兽",
                        "变隐龙",
                        "圆法师",
                        "樱花宝",
                        "尖牙笼",
                        "差不多娃娃(B2W2*)",
                        "投摔鬼(B2W2*)",
                        "打击鬼(B2W2*)",
                        "滑滑小子(B2W2*)",
                        "毛球(BW*)",
                        "臭泥(BW*)",
                        "三蜜蜂(BW*)",
                        "大针蜂(BW*)",
                        "阿柏蛇",
                        "波克比",
                        "长尾怪手",
                        "蘑蘑菇",
                        "铁骨土人(B2W2*)",
                        "毒蔷薇",
                        "猫鼬斩(BW*)",
                        "饭匙蛇(BW*)",
                        "吉利蛋",
                        "凯罗斯",
                        "伊布",
                        "卡比兽",
                        "赫拉克罗斯"});
                    speciesbox.SelectedIndex = 0;
                    break;
                case 7://Pokemon Cafe forest
                    speciesbox.Items.Clear();
                    speciesbox.Items.AddRange(new object[] {
                        "蚊香君",
                        "伊布",
                        "图图犬",
                        "结草儿"});
                    speciesbox.SelectedIndex = 0;
                    break;
                case 8://PGL Promotions
                    speciesbox.Items.Clear();
                    speciesbox.Items.AddRange(new object[] {
                        "水伊布",
                        "雷伊布",
                        "火伊布",
                        "太阳伊布",
                        "月亮伊布",
                        "叶伊布",
                        "冰伊布",
                        "妙蛙种子",
                        "小火龙",
                        "杰尼龟",
                        "不良蛙",
                        "草苗龟",
                        "小火焰猴",
                        "波加曼",
                        "阿尔宙斯",
                        "木守宫",
                        "火稚鸡",
                        "水跃鱼",
                        "波克基斯",
                        "象牙猪",
                        "多边兽",
                        "烈空坐",
                        "诅咒娃娃",
                        "不良蛙",
                        "七夕青鸟",
                        "幸福蛋",
                        "路卡利欧",
                        "哥德小童",
                        "皮卡丘",
                        "毽子棉",
                        "花椰猴",
                        "爆香猴",
                        "冷水猴",
                        "草苗龟",
                        "小火焰猴",
                        "波加曼",
                        "哥德小童",
                        "巨钳螳螂",
                        "烈咬陆鲨",
                        "快龙",
                        "班基拉斯",
                        "快龙",
                        "巨金怪"});
                    speciesbox.SelectedIndex = 0;
                    break;
            }
            atkA.Checked = true;
            update_atk();
        }
        void Ok_butClick(object sender, EventArgs e)
        {
            if (world < 8)
            {
                //Handle forms
                if (world == 2 && (speciesbox.SelectedIndex == 25 || speciesbox.SelectedIndex == 36)) //Blue basculin, East Sea shellos
                    Entralink.dream_pkm = Entralink.forest.create_pkm(world_species[world][speciesbox.SelectedIndex], world_attacks[world][speciesbox.SelectedIndex][atk], gender, 1, random_form_anim());
                else
                    Entralink.dream_pkm = Entralink.forest.create_pkm(world_species[world][speciesbox.SelectedIndex], world_attacks[world][speciesbox.SelectedIndex][atk], gender, 0, random_form_anim());
            }
            else if (world == 8)
            {
                int anim = 0;
                //Random animation disabled and set to 0, as I've seen several PGL pokemon with animation 0 (Arceus, porygon, banette, croagunk, togekiss and lucario) and also a gothorita in a white 2 savegame
                //anim = random_form_anim();
                if (world_species[world][speciesbox.SelectedIndex] == 473)
                    anim = 4; //But Mamoswine has, for some reason, animation 04, being the only known exception (would need more legit saves with the events) 
                Entralink.dream_pkm = Entralink.forest.create_pkm(world_species[world][speciesbox.SelectedIndex], PGL_attacks[speciesbox.SelectedIndex], gender, 0, anim);
            }
            this.Close();
        }
        void Cancel_butClick(object sender, EventArgs e)
        {
            this.Close();
        }
        void SpeciesboxSelectedIndexChanged(object sender, EventArgs e)
        {
            //atkA.Checked = true;
            update_atk();
            update_gnd();

            bool exclusive = false;
            if (world < 8)
            {
                int i = 0;
                if (BWToolMainForm.save.B2W2 == true)
                {
                    for (i = 0; i < world_BW1_exclusives[world].Length; i++)
                    {
                        if (world_BW1_exclusives[world][i] == world_species[world][speciesbox.SelectedIndex])
                        {
                            exclusive = true;
                        }
                    }
                    if (exclusive == true)
                    {
                        exclusive_label.Text = "仅黑白";
                        ok_but.Enabled = false;
                    }

                }
                else
                {
                    for (i = 0; i < world_BW2_exclusives[world].Length; i++)
                    {
                        if (world_BW2_exclusives[world][i] == world_species[world][speciesbox.SelectedIndex])
                        {
                            exclusive = true;
                        }
                    }
                    if (exclusive == true)
                    {
                        exclusive_label.Text = "仅黑白2";
                        ok_but.Enabled = false;
                    }
                }

            }
            else if (world == 8)
            {
                if (BWToolMainForm.save.B2W2 == true)
                {
                    if (PGL_exclusives[speciesbox.SelectedIndex] == 0)
                    {
                        exclusive_label.Text = "仅黑白";
                        ok_but.Enabled = false;
                        exclusive = true;
                    }
                }
                else
                {
                    if (PGL_exclusives[speciesbox.SelectedIndex] == 1)
                    {
                        exclusive_label.Text = "仅黑白2";
                        ok_but.Enabled = false;
                        exclusive = true;
                    }
                }

                pgl_region_box.SelectedIndex = speciesbox.SelectedIndex;
            }

            if (exclusive == false)
            {
                exclusive_label.Text = "";
                ok_but.Enabled = true;
            }

        }


        int[][] world_species = new int[][]
        {
            new int[]{019, 029, 032, 043, 069, 077, 083, 084, 102, 108, 114, 115, 161, 174, 179, 187, 191, 234, 261, 270, 276, 283, 399, 403, 535, 546, 548, 588, 616, 431, 545, 054, 058, 123, 128, 183, 185, 203, 241, 263, 309, 351, 417, 427, 037, 060, 177, 239, 300},
            new int[]{12, 16, 21, 41, 142, 163, 165, 187, 193, 198, 207, 225, 276, 278, 333, 397, 519, 561, 580, 587, 227, 357, 425, 441},
            new int[]{79, 86, 90, 98, 116, 118, 119, 120, 129, 138, 140, 170, 194, 211, 222, 223, 226, 320, 339, 366, 369, 370, 418, 456, 550, 550, 594, 618, 564, 72, 318, 341, 345, 347, 349, 422, 422, 131, 147},
            new int[]{92, 96, 122, 167, 200, 202, 228, 238, 303, 307, 325, 353, 355, 358, 434, 436, 605, 624, 596, 52, 209, 235, 313, 314, 479, 63, 280, 302, 442, 578, 622},
            new int[]{56, 66, 81, 109, 111, 218, 231, 246, 324, 328, 331, 412, 449, 451, 631, 632, 556, 558, 240, 216, 296, 322, 327, 359, 374, 453, 236, 371, 553, 447},
            new int[]{27, 74, 95, 100, 104, 173, 213, 293, 299, 304, 337, 338, 343, 363, 408, 459, 529, 621, 50, 206, 525, 583, 600, 215, 361, 410, 220, 443, 610},
            new int[]{46, 204, 265, 273, 287, 290, 311, 312, 316, 352, 401, 420, 455, 531, 538, 539, 559, 48, 88, 415, 15, 23, 175, 190, 285, 533, 315, 335, 336, 113, 127, 133, 143, 214},
            new int[]{061, 133, 235, 412}, //Pokemon Cafe forest
			new int[]{134, 135, 136, 196, 197, 470, 471, 1, 4, 7, 453, 387, 390, 393, 493, 252, 255, 258, 468, 473, 137, 384, 354, 453, 334, 242, 448, 575, 25, 189, 511, 513, 515, 387, 390, 393, 575, 212, 445, 149, 248, 149, 376, 376}
        };

        int[][][] world_attacks = new int[][][]
        {
            new int[][]{ new int[]{98, 382, 231}, new int[]{10, 389, 162}, new int[]{64, 68, 162}, new int[]{230, 298, 202}, new int[]{22, 235, 402}, new int[]{33, 37, 257}, new int[]{210, 355, 348}, new int[]{45, 175, 355}, new int[]{140, 235, 202}, new int[]{122, 214, 431}, new int[]{79, 73, 402}, new int[]{252, 68, 409}, new int[]{10, 203, 343}, new int[]{47, 313, 270}, new int[]{84, 115, 351}, new int[]{235, 270, 331}, new int[]{72, 230, 414}, new int[]{33, 50, 285}, new int[]{336, 305, 399}, new int[]{71, 73, 352}, new int[]{64, 119, 366}, new int[]{145, 56, 202}, new int[]{33, 401, 290}, new int[]{268, 393, 400}, new int[]{496, 414, 352}, new int[]{73, 227, 388}, new int[]{79, 204, 230}, new int[]{203, 224, 450}, new int[]{51, 226, 227}, new int[]{252, 372, 290}, new int[]{342, 390, 276}, new int[]{346, 227, 362}, new int[]{44, 34, 203}, new int[]{98, 226, 366}, new int[]{99, 231, 431}, new int[]{111, 453, 8}, new int[]{175, 205, 272}, new int[]{93, 243, 285}, new int[]{111, 174, 231}, new int[]{33, 271, 387}, new int[]{86, 423, 324}, new int[]{52, 466, 352}, new int[]{98, 343, 351}, new int[]{193, 252, 409}, new int[]{46, 257, 399}, new int[]{95, 54, 214}, new int[]{101, 297, 202}, new int[]{84, 238, 393}, new int[]{193, 321, 445} },
            new int[][]{ new int[]{93, 355, 314}, new int[]{16, 211, 290}, new int[]{64, 185, 211}, new int[]{48, 95, 162}, new int[]{44, 372, 446}, new int[]{193, 101, 278}, new int[]{4, 450, 9}, new int[]{235, 227, 340}, new int[]{98, 364, 202}, new int[]{64, 109, 355}, new int[]{28, 364, 366}, new int[]{217, 420, 264}, new int[]{64, 203, 413}, new int[]{55, 239, 351}, new int[]{64, 297, 355}, new int[]{17, 297, 366}, new int[]{16, 95, 234}, new int[]{95, 500, 257}, new int[]{432, 362, 382}, new int[]{98, 403, 204}, new int[]{64, 65, 355}, new int[]{16, 73, 318}, new int[]{107, 95, 285}, new int[]{119, 417, 272} },
            new int[][]{ new int[]{281, 335, 362}, new int[]{29, 333, 214}, new int[]{110, 112, 196}, new int[]{11, 133, 290}, new int[]{145, 190, 362}, new int[]{64, 60, 352}, new int[]{352, 214, 203}, new int[]{55, 278, 196}, new int[]{150, 175, 340}, new int[]{44, 330, 196}, new int[]{71, 175, 446}, new int[]{86, 133, 351}, new int[]{55, 34, 401}, new int[]{40, 453, 290}, new int[]{145, 109, 446}, new int[]{199, 350, 362}, new int[]{48, 243, 314}, new int[]{55, 214, 340}, new int[]{189, 214, 209}, new int[]{250, 445, 392}, new int[]{55, 214, 414}, new int[]{204, 300, 196}, new int[]{346, 163, 352}, new int[]{213, 186, 352}, new int[]{29, 97, 428}, new int[]{29, 97, 428}, new int[]{392, 243, 220}, new int[]{189, 174, 281}, new int[]{205, 175, 334}, new int[]{48, 367, 202}, new int[]{44, 37, 399}, new int[]{106, 232, 283}, new int[]{51, 243, 202}, new int[]{10, 446, 440}, new int[]{150, 445, 243}, new int[]{189, 281, 290}, new int[]{189, 281, 290}, new int[]{109, 32, 196}, new int[]{86, 352, 225} },
            new int[][]{ new int[]{95, 50, 482}, new int[]{95, 427, 409}, new int[]{112, 298, 285}, new int[]{40, 527, 450}, new int[]{149, 194, 517}, new int[]{243, 204, 227}, new int[]{336, 364, 399}, new int[]{186, 445, 285}, new int[]{313, 424, 8}, new int[]{96, 409, 203}, new int[]{149, 285, 278}, new int[]{101, 194, 220}, new int[]{50, 220, 271}, new int[]{35, 95, 304}, new int[]{103, 492, 389}, new int[]{95, 285, 356}, new int[]{377, 112, 417}, new int[]{210, 427, 389}, new int[]{486, 50, 228}, new int[]{10, 95, 290}, new int[]{204, 370, 38}, new int[]{166, 445, 214}, new int[]{148, 271, 366}, new int[]{204, 313, 366}, new int[]{86, 351, 324}, new int[]{100, 285, 356}, new int[]{93, 194, 270}, new int[]{193, 389, 180}, new int[]{180, 220, 196}, new int[]{105, 286, 271}, new int[]{205, 7, 9} },
            new int[][]{ new int[]{67, 179, 9}, new int[]{67, 418, 270}, new int[]{319, 278, 356}, new int[]{123, 399, 482}, new int[]{30, 68, 38}, new int[]{52, 517, 257}, new int[]{175, 484, 402}, new int[]{44, 399, 446}, new int[]{52, 90, 446}, new int[]{44, 324, 202}, new int[]{71, 298, 9}, new int[]{182, 450, 173}, new int[]{44, 254, 276}, new int[]{44, 97, 401}, new int[]{510, 257, 202}, new int[]{210, 203, 422}, new int[]{42, 73, 191}, new int[]{157, 68, 400}, new int[]{52, 9, 257}, new int[]{313, 242, 264}, new int[]{292, 270, 8}, new int[]{52, 34, 257}, new int[]{383, 252, 276}, new int[]{364, 224, 276}, new int[]{36, 428, 442}, new int[]{40, 409, 441}, new int[]{252, 364, 183}, new int[]{44, 349, 200}, new int[]{242, 68, 212}, new int[]{203, 418, 264} },
            new int[][]{ new int[]{28, 68, 162}, new int[]{111, 446, 431}, new int[]{20, 446, 431}, new int[]{268, 324, 363}, new int[]{125, 195, 67}, new int[]{227, 312, 214}, new int[]{227, 270, 504}, new int[]{253, 283, 428}, new int[]{33, 446, 246}, new int[]{106, 283, 457}, new int[]{93, 414, 236}, new int[]{93, 428, 234}, new int[]{229, 356, 428}, new int[]{181, 90, 401}, new int[]{29, 442, 7}, new int[]{75, 419, 202}, new int[]{229, 319, 431}, new int[]{44, 424, 389}, new int[]{28, 251, 446}, new int[]{111, 277, 446}, new int[]{479, 174, 484}, new int[]{429, 420, 286}, new int[]{451, 356, 393}, new int[]{269, 8, 67}, new int[]{181, 311, 352}, new int[]{182, 68, 90}, new int[]{316, 246, 333}, new int[]{82, 200, 203}, new int[]{82, 68, 400} },
            new int[][]{ new int[]{78, 440, 235}, new int[]{120, 390, 356}, new int[]{40, 450, 173}, new int[]{74, 331, 492}, new int[]{281, 400, 389}, new int[]{141, 203, 400}, new int[]{86, 435, 324}, new int[]{86, 435, 324}, new int[]{139, 151, 202}, new int[]{185, 285, 513}, new int[]{522, 283, 253}, new int[]{73, 505, 331}, new int[]{44, 476, 380}, new int[]{270, 227, 281}, new int[]{20, 8, 276}, new int[]{249, 9, 530}, new int[]{67, 252, 409}, new int[]{50, 226, 285}, new int[]{139, 114, 425}, new int[]{16, 366, 314}, new int[]{31, 314, 210}, new int[]{40, 251, 399}, new int[]{118, 381, 253}, new int[]{10, 252, 7}, new int[]{78, 331, 264}, new int[]{67, 183, 409}, new int[]{74, 79, 129}, new int[]{98, 458, 67}, new int[]{44, 34, 401}, new int[]{45, 68, 270}, new int[]{11, 370, 382}, new int[]{28, 204, 129}, new int[]{133, 7, 278}, new int[]{30, 175, 264} },
            new int[][]{ new int[]{240, 114, 352}, new int[]{ 270, 204, 129}, new int[]{ 166, 445, 214}, new int[]{ 182, 450, 173} } //Pokemon Cafe forest
		};

        int[] PGL_attacks = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 217, 0, 0, 0, 538, 398, 206, 0, 418, 243, 29, 206, 437, 257, 56, 254, 252, 297, 286, 211, 0, 9, 69, 245, 38 };

        /* Method deprecated, it seems there's no gender restriction outside pokemon being male/female only or genderless
		int[][] world_gender = new int[][]
		{
			 // 0: only male, 1: only female, 2: genderless, 3: male/female
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{3, 3, 3, 3} //Pokemon Cafe forest
		};
		*/
        int[][] world_BW1_exclusives = new int[][]
        {
            new int[]{029, 032, 174, 187, 270, 276, 283, 309, 351, 417},//Pleasant Forest
			new int[]{012, 163, 278, 333, 425, 441},//Windswept Sky
			new int[]{079, 098, 119, 120, 222, 422, 422},
            new int[]{202, 238, 303, 307, 436, 052, 479, 280, 302, 442},
            new int[]{056, 111, 231, 451, 216, 296, 327, 374, 447},
            new int[]{173, 213, 299, 363, 408, 206, 410},
            new int[]{048, 88, 415, 15, 335, 336},
            new int[]{0} //Pokemon Cafe forest
		};

        int[][] world_BW2_exclusives = new int[][]
        {
            new int[]{535, 546, 548, 588, 616, 545},//Pleasant Forest
			new int[]{519, 561, 580, 587},//Windswept Sky
			new int[]{550, 550, 594, 618, 564},
            new int[]{605, 624, 596, 578},
            new int[]{631, 632, 556, 558, 553},
            new int[]{529, 621, 525, 583, 600, 610},
            new int[]{531, 538, 539, 559, 533},
            new int[]{0} //Pokemon Cafe forest
		};

        int[] PGL_exclusives = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 };

        public static int random_form_anim()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int anim = rnd.Next(15);
            if (IsOdd(anim) == true)
                anim = anim - 1;
            return anim;
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private int atk = 0;
        private void update_atk()
        {

            if (world < 8)
            {
                if (atkA.Checked == true)
                    atk = 0;
                else if (atkB.Checked == true)
                    atk = 1;
                else if (atkC.Checked == true)
                    atk = 2;

                moveboxA.SelectedIndex = world_attacks[world][speciesbox.SelectedIndex][0];
                movebox.SelectedIndex = world_attacks[world][speciesbox.SelectedIndex][1];
                moveboxC.SelectedIndex = world_attacks[world][speciesbox.SelectedIndex][2];
            }
            else if (world == 8)
            {
                movebox.SelectedIndex = PGL_attacks[speciesbox.SelectedIndex];
            }

        }
        void AtkACheckedChanged(object sender, EventArgs e)
        {
            update_atk();
        }
        void AtkBCheckedChanged(object sender, EventArgs e)
        {
            update_atk();
        }
        void AtkCCheckedChanged(object sender, EventArgs e)
        {
            update_atk();
        }

        private int gender = 0;
        private void update_gnd()
        {
            //Handle genders		
            bool special_gender = false;
            int i = 0;
            for (i = 0; i < Entralink.BW_femaleonly.Length; i++)
            {
                if (world_species[world][speciesbox.SelectedIndex] == Entralink.BW_femaleonly[i])
                {
                    //Only female
                    special_gender = true;
                    gnd_female.Checked = true;
                    gnd_male.Enabled = false;
                    gnd_female.Enabled = true;
                    gnd_none.Enabled = false;
                }
            }

            for (i = 0; i < Entralink.BW_maleonly.Length; i++)
            {
                if (world_species[world][speciesbox.SelectedIndex] == Entralink.BW_maleonly[i])
                {
                    //Only male
                    special_gender = true;
                    gnd_male.Checked = true;
                    gnd_male.Enabled = true;
                    gnd_female.Enabled = false;
                    gnd_none.Enabled = false;
                }
            }

            for (i = 0; i < Entralink.BW_genderless.Length; i++)
            {
                if (world_species[world][speciesbox.SelectedIndex] == Entralink.BW_genderless[i])
                {
                    //Only genderless
                    special_gender = true;
                    gnd_none.Checked = true;
                    gnd_male.Enabled = false;
                    gnd_female.Enabled = false;
                    gnd_none.Enabled = true;
                }
            }

            if (special_gender == false)
            {
                //Male/female
                if (gender == 2 || (world == 8))
                {
                    if (world == 8 && speciesbox.SelectedIndex == 22) //Banette is the only female pokemon distributed via PGL
                    {
                        gnd_female.Checked = true;
                        gnd_male.Enabled = false;
                        gnd_female.Enabled = true;
                    }
                    else
                    {
                        if (world == 8)
                            gnd_female.Enabled = false;
                        gnd_male.Checked = true;
                        gnd_male.Enabled = true;
                    }
                }
                if (gnd_male.Checked == false && gnd_female.Checked == false && gnd_none.Checked == false)
                {
                    if (world == 8 && speciesbox.SelectedIndex == 22) //Banette is the only female pokemon distributed via PGL
                    {
                        gnd_female.Enabled = true;
                        gnd_female.Checked = true;
                        gnd_male.Enabled = false;
                    }
                    else
                    {
                        if (world == 8)
                            gnd_female.Enabled = false;
                        gnd_male.Checked = true;
                        gnd_male.Enabled = true;
                    }
                }
                if (world != 8)
                    gnd_male.Enabled = true;
                if (world != 8)
                    gnd_female.Enabled = true;
                gnd_none.Enabled = false;
            }

            /*	
                switch(world_gender[world][speciesbox.SelectedIndex])
                {
                    case 0://male only
                        gnd_male.Checked = true;
                        gnd_male.Enabled = true;
                        gnd_female.Enabled = false;
                        gnd_none.Enabled = false;
                        break;
                    case 1://female only
                        gnd_female.Checked = true;
                        gnd_male.Enabled = false;
                        gnd_female.Enabled = true;
                        gnd_none.Enabled = false;
                        break;
                    case 2://genderless
                        gnd_none.Checked = true;
                        gnd_male.Enabled = false;
                        gnd_female.Enabled = false;
                        gnd_none.Enabled = true;
                        break;
                    default://male/female
                        if (gender == 2)
                            gnd_male.Checked = true;
                        if (gnd_male.Checked == false && gnd_female.Checked == false && gnd_none.Checked == false)
                            gnd_male.Checked = true;
                        gnd_male.Enabled = true;
                        gnd_female.Enabled = true;
                        gnd_none.Enabled = false;
                        break;
                }
             */

            if (gnd_male.Checked == true)
                gender = 0;
            else if (gnd_female.Checked == true)
                gender = 1;
            else if (gnd_none.Checked == true)
                gender = 2;

        }

        void Gnd_maleCheckedChanged(object sender, EventArgs e)
        {
            update_gnd();
        }
        void Gnd_femaleCheckedChanged(object sender, EventArgs e)
        {
            update_gnd();
        }
        void Gnd_noneCheckedChanged(object sender, EventArgs e)
        {
            update_gnd();
        }

    }
}

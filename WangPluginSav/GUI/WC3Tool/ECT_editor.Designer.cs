using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WC3Tool
{
    partial class ECT_editor
    {
        private TextBox ect_path;

        private Button save_ect_but;

        private Button load_ect_but;

        private Label label1;

        private ComboBox tower_appearance;

        private Label label2;

        private ComboBox trainer_class;

        private Button helpclass_but;

        private Label label3;

        private NumericUpDown tower_floor;

        private ComboBox textA1;

        private ComboBox textA2;

        private ComboBox textA3;

        private ComboBox textA4;

        private ComboBox textA5;

        private ComboBox textA6;

        private GroupBox groupBox1;

        private GroupBox groupBox2;

        private ComboBox textB6;

        private ComboBox textB5;

        private ComboBox textB4;

        private ComboBox textB3;

        private ComboBox textB2;

        private ComboBox textB1;

        private GroupBox groupBox3;

        private ComboBox textC6;

        private ComboBox textC5;

        private ComboBox textC4;

        private ComboBox textC3;

        private ComboBox textC2;

        private ComboBox textC1;

        private ComboBox pkm3;

        private ComboBox pkm2;

        private ComboBox pkm1;

        private Label label9;

        private Label label8;

        private Label label7;

        private Button pkm3_edit_but;

        private Button pkm2_edit_but;

        private Button pkm1_edit_but;

        private Label label6;

        private NumericUpDown SID;

        private NumericUpDown TID;

        private Label label5;

        private Label label4;

        private TextBox name;

        private CheckBox jap_check;

        private RadioButton radio_rs;

        private RadioButton radio_e;

        private RadioButton radio_FRLG;

        private GroupBox groupBox4;

        private NumericUpDown tower_appearance_num;

        private NumericUpDown trainer_class_value;

        private GroupBox groupBox5;

        private RadioButton jap;

        private RadioButton esp;

        private RadioButton ita;

        private RadioButton ger;

        private RadioButton fre;

        private RadioButton eng;
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECT_editor));
            ect_path = new TextBox();
            save_ect_but = new Button();
            load_ect_but = new Button();
            label1 = new Label();
            tower_appearance = new ComboBox();
            label2 = new Label();
            trainer_class = new ComboBox();
            helpclass_but = new Button();
            label3 = new Label();
            tower_floor = new NumericUpDown();
            textA1 = new ComboBox();
            textA2 = new ComboBox();
            textA3 = new ComboBox();
            textA4 = new ComboBox();
            textA5 = new ComboBox();
            textA6 = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textB6 = new ComboBox();
            textB5 = new ComboBox();
            textB4 = new ComboBox();
            textB3 = new ComboBox();
            textB2 = new ComboBox();
            textB1 = new ComboBox();
            groupBox3 = new GroupBox();
            textC6 = new ComboBox();
            textC5 = new ComboBox();
            textC4 = new ComboBox();
            textC3 = new ComboBox();
            textC2 = new ComboBox();
            textC1 = new ComboBox();
            pkm3 = new ComboBox();
            pkm2 = new ComboBox();
            pkm1 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pkm3_edit_but = new Button();
            pkm2_edit_but = new Button();
            pkm1_edit_but = new Button();
            label6 = new Label();
            SID = new NumericUpDown();
            TID = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            name = new TextBox();
            jap_check = new CheckBox();
            radio_rs = new RadioButton();
            radio_e = new RadioButton();
            radio_FRLG = new RadioButton();
            groupBox4 = new GroupBox();
            tower_appearance_num = new NumericUpDown();
            trainer_class_value = new NumericUpDown();
            groupBox5 = new GroupBox();
            jap = new RadioButton();
            esp = new RadioButton();
            ita = new RadioButton();
            ger = new RadioButton();
            fre = new RadioButton();
            eng = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)tower_floor).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TID).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tower_appearance_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainer_class_value).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // ect_path
            // 
            ect_path.Location = new Point(456, 16);
            ect_path.Margin = new Padding(4);
            ect_path.Name = "ect_path";
            ect_path.ReadOnly = true;
            ect_path.Size = new Size(590, 25);
            ect_path.TabIndex = 5;
            // 
            // save_ect_but
            // 
            save_ect_but.Enabled = false;
            save_ect_but.Location = new Point(250, 16);
            save_ect_but.Margin = new Padding(4);
            save_ect_but.Name = "save_ect_but";
            save_ect_but.Size = new Size(186, 26);
            save_ect_but.TabIndex = 4;
            save_ect_but.Text = "保存e卡训练家文件";
            save_ect_but.UseVisualStyleBackColor = true;
            save_ect_but.Click += Save_ect_butClick;
            // 
            // load_ect_but
            // 
            load_ect_but.Location = new Point(56, 16);
            load_ect_but.Margin = new Padding(4);
            load_ect_but.Name = "load_ect_but";
            load_ect_but.Size = new Size(186, 26);
            load_ect_but.TabIndex = 3;
            load_ect_but.Text = "读取e卡训练家文件";
            load_ect_but.UseVisualStyleBackColor = true;
            load_ect_but.Click += Load_ect_butClick;
            // 
            // label1
            // 
            label1.Location = new Point(19, 268);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 6;
            label1.Text = "对战塔外观：";
            // 
            // tower_appearance
            // 
            tower_appearance.FormattingEnabled = true;
            tower_appearance.Items.AddRange(new object[] { "绿岭市秘密民居", "对战塔Lv50挑战", "对战塔Lv100挑战" });
            tower_appearance.Location = new Point(193, 264);
            tower_appearance.Margin = new Padding(4);
            tower_appearance.Name = "tower_appearance";
            tower_appearance.Size = new Size(253, 23);
            tower_appearance.TabIndex = 7;
            tower_appearance.Visible = false;
            // 
            // label2
            // 
            label2.Location = new Point(19, 298);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 26);
            label2.TabIndex = 8;
            label2.Text = "训练家类型：";
            // 
            // trainer_class
            // 
            trainer_class.FormattingEnabled = true;
            trainer_class.Location = new Point(193, 296);
            trainer_class.Margin = new Padding(4);
            trainer_class.Name = "trainer_class";
            trainer_class.Size = new Size(253, 23);
            trainer_class.TabIndex = 9;
            trainer_class.SelectedIndexChanged += Trainer_classSelectedIndexChanged;
            // 
            // helpclass_but
            // 
            helpclass_but.Location = new Point(456, 296);
            helpclass_but.Margin = new Padding(4);
            helpclass_but.Name = "helpclass_but";
            helpclass_but.Size = new Size(29, 26);
            helpclass_but.TabIndex = 10;
            helpclass_but.Text = "?";
            helpclass_but.UseVisualStyleBackColor = true;
            helpclass_but.Click += Helpclass_butClick;
            // 
            // label3
            // 
            label3.Location = new Point(19, 328);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 11;
            label3.Text = "对战塔层数：";
            // 
            // tower_floor
            // 
            tower_floor.Location = new Point(119, 324);
            tower_floor.Margin = new Padding(4);
            tower_floor.Name = "tower_floor";
            tower_floor.Size = new Size(172, 25);
            tower_floor.TabIndex = 12;
            // 
            // textA1
            // 
            textA1.FormattingEnabled = true;
            textA1.Location = new Point(36, 26);
            textA1.Margin = new Padding(4);
            textA1.Name = "textA1";
            textA1.Size = new Size(160, 23);
            textA1.TabIndex = 19;
            // 
            // textA2
            // 
            textA2.FormattingEnabled = true;
            textA2.Location = new Point(205, 26);
            textA2.Margin = new Padding(4);
            textA2.Name = "textA2";
            textA2.Size = new Size(160, 23);
            textA2.TabIndex = 20;
            // 
            // textA3
            // 
            textA3.FormattingEnabled = true;
            textA3.Location = new Point(375, 26);
            textA3.Margin = new Padding(4);
            textA3.Name = "textA3";
            textA3.Size = new Size(160, 23);
            textA3.TabIndex = 21;
            // 
            // textA4
            // 
            textA4.FormattingEnabled = true;
            textA4.Location = new Point(36, 58);
            textA4.Margin = new Padding(4);
            textA4.Name = "textA4";
            textA4.Size = new Size(160, 23);
            textA4.TabIndex = 22;
            // 
            // textA5
            // 
            textA5.FormattingEnabled = true;
            textA5.Location = new Point(205, 58);
            textA5.Margin = new Padding(4);
            textA5.Name = "textA5";
            textA5.Size = new Size(160, 23);
            textA5.TabIndex = 23;
            // 
            // textA6
            // 
            textA6.FormattingEnabled = true;
            textA6.Location = new Point(375, 58);
            textA6.Margin = new Padding(4);
            textA6.Name = "textA6";
            textA6.Size = new Size(160, 23);
            textA6.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textA6);
            groupBox1.Controls.Add(textA5);
            groupBox1.Controls.Add(textA4);
            groupBox1.Controls.Add(textA3);
            groupBox1.Controls.Add(textA2);
            groupBox1.Controls.Add(textA1);
            groupBox1.Location = new Point(493, 49);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(553, 96);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "战前文本：";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textB6);
            groupBox2.Controls.Add(textB5);
            groupBox2.Controls.Add(textB4);
            groupBox2.Controls.Add(textB3);
            groupBox2.Controls.Add(textB2);
            groupBox2.Controls.Add(textB1);
            groupBox2.Location = new Point(493, 152);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(553, 96);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "胜利文本：";
            // 
            // textB6
            // 
            textB6.FormattingEnabled = true;
            textB6.Location = new Point(375, 58);
            textB6.Margin = new Padding(4);
            textB6.Name = "textB6";
            textB6.Size = new Size(160, 23);
            textB6.TabIndex = 24;
            // 
            // textB5
            // 
            textB5.FormattingEnabled = true;
            textB5.Location = new Point(205, 58);
            textB5.Margin = new Padding(4);
            textB5.Name = "textB5";
            textB5.Size = new Size(160, 23);
            textB5.TabIndex = 23;
            // 
            // textB4
            // 
            textB4.FormattingEnabled = true;
            textB4.Location = new Point(36, 58);
            textB4.Margin = new Padding(4);
            textB4.Name = "textB4";
            textB4.Size = new Size(160, 23);
            textB4.TabIndex = 22;
            // 
            // textB3
            // 
            textB3.FormattingEnabled = true;
            textB3.Location = new Point(375, 26);
            textB3.Margin = new Padding(4);
            textB3.Name = "textB3";
            textB3.Size = new Size(160, 23);
            textB3.TabIndex = 21;
            // 
            // textB2
            // 
            textB2.FormattingEnabled = true;
            textB2.Location = new Point(205, 26);
            textB2.Margin = new Padding(4);
            textB2.Name = "textB2";
            textB2.Size = new Size(160, 23);
            textB2.TabIndex = 20;
            // 
            // textB1
            // 
            textB1.FormattingEnabled = true;
            textB1.Location = new Point(36, 26);
            textB1.Margin = new Padding(4);
            textB1.Name = "textB1";
            textB1.Size = new Size(160, 23);
            textB1.TabIndex = 19;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textC6);
            groupBox3.Controls.Add(textC5);
            groupBox3.Controls.Add(textC4);
            groupBox3.Controls.Add(textC3);
            groupBox3.Controls.Add(textC2);
            groupBox3.Controls.Add(textC1);
            groupBox3.Location = new Point(493, 254);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(553, 96);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "战败文本：";
            // 
            // textC6
            // 
            textC6.FormattingEnabled = true;
            textC6.Location = new Point(375, 58);
            textC6.Margin = new Padding(4);
            textC6.Name = "textC6";
            textC6.Size = new Size(160, 23);
            textC6.TabIndex = 24;
            // 
            // textC5
            // 
            textC5.FormattingEnabled = true;
            textC5.Location = new Point(205, 58);
            textC5.Margin = new Padding(4);
            textC5.Name = "textC5";
            textC5.Size = new Size(160, 23);
            textC5.TabIndex = 23;
            // 
            // textC4
            // 
            textC4.FormattingEnabled = true;
            textC4.Location = new Point(36, 58);
            textC4.Margin = new Padding(4);
            textC4.Name = "textC4";
            textC4.Size = new Size(160, 23);
            textC4.TabIndex = 22;
            // 
            // textC3
            // 
            textC3.FormattingEnabled = true;
            textC3.Location = new Point(375, 26);
            textC3.Margin = new Padding(4);
            textC3.Name = "textC3";
            textC3.Size = new Size(160, 23);
            textC3.TabIndex = 21;
            // 
            // textC2
            // 
            textC2.FormattingEnabled = true;
            textC2.Location = new Point(205, 26);
            textC2.Margin = new Padding(4);
            textC2.Name = "textC2";
            textC2.Size = new Size(160, 23);
            textC2.TabIndex = 20;
            // 
            // textC1
            // 
            textC1.FormattingEnabled = true;
            textC1.Location = new Point(36, 26);
            textC1.Margin = new Padding(4);
            textC1.Name = "textC1";
            textC1.Size = new Size(160, 23);
            textC1.TabIndex = 19;
            // 
            // pkm3
            // 
            pkm3.FormattingEnabled = true;
            pkm3.Items.AddRange(new object[] { "无", "妙蛙种子", "妙蛙草", "妙蛙花", "小火龙", "火恐龙", "喷火龙", "杰尼龟", "卡咪龟", "水箭龟", "绿毛虫", "铁甲蛹", "巴大蝶", "独角虫", "铁壳蛹", "大针蜂", "波波", "比比鸟", "大比鸟", "小拉达", "拉达", "烈雀", "大嘴雀", "阿柏蛇", "阿柏怪", "皮卡丘", "雷丘", "穿山鼠", "穿山王", "尼多兰", "尼多娜", "尼多后", "尼多朗", "尼多力诺", "尼多王", "皮皮", "皮可西", "六尾", "九尾", "胖丁", "胖可丁", "超音蝠", "大嘴蝠", "走路草", "臭臭花", "霸王花", "派拉斯", "派拉斯特", "毛球", "摩鲁蛾", "地鼠", "三地鼠", "喵喵", "猫老大", "可达鸭", "哥达鸭", "猴怪", "火暴猴", "卡蒂狗", "风速狗", "蚊香蝌蚪", "蚊香君", "蚊香泳士", "凯西", "勇基拉", "胡地", "腕力", "豪力", "怪力", "喇叭芽", "口呆花", "大食花", "玛瑙水母", "毒刺水母", "小拳石", "隆隆石", "隆隆岩", "小火马", "烈焰马", "呆呆兽", "呆壳兽", "小磁怪", "三合一磁怪", "大葱鸭", "嘟嘟", "嘟嘟利", "小海狮", "白海狮", "臭泥", "臭臭泥", "大舌贝", "刺甲贝", "鬼斯", "鬼斯通", "耿鬼", "大岩蛇", "催眠貘", "引梦貘人", "大钳蟹", "巨钳蟹", "霹雳电球", "顽皮雷弹", "蛋蛋", "椰蛋树", "卡拉卡拉", "嘎啦嘎啦", "飞腿郎", "快拳郎", "大舌头", "瓦斯弹", "双弹瓦斯", "独角犀牛", "钻角犀兽", "吉利蛋", "蔓藤怪", "袋兽", "墨海马", "海刺龙", "角金鱼", "金鱼王", "海星星", "宝石海星", "魔墙人偶", "飞天螳螂", "迷唇姐", "电击兽", "鸭嘴火兽", "凯罗斯", "肯泰罗", "鲤鱼王", "暴鲤龙", "拉普拉斯", "百变怪", "伊布", "水伊布", "雷伊布", "火伊布", "多边兽", "菊石兽", "多刺菊石兽", "化石盔", "镰刀盔", "化石翼龙", "卡比兽", "急冻鸟", "闪电鸟", "火焰鸟", "迷你龙", "哈克龙", "快龙", "超梦", "梦幻", "菊草叶", "月桂叶", "大竺葵", "火球鼠", "火岩鼠", "火暴兽", "小锯鳄", "蓝鳄", "大力鳄", "尾立", "大尾立", "咕咕", "猫头夜鹰", "芭瓢虫", "安瓢虫", "圆丝蛛", "阿利多斯", "叉字蝠", "灯笼鱼", "电灯怪", "皮丘", "皮宝宝", "宝宝丁", "波克比", "波克基古", "天然雀", "天然鸟", "咩利羊", "茸茸羊", "电龙", "美丽花", "玛力露", "玛力露丽", "树才怪", "蚊香蛙皇", "毽子草", "毽子花", "毽子棉", "长尾怪手", "向日种子", "向日花怪", "蜻蜻蜓", "乌波", "沼王", "太阳伊布", "月亮伊布", "黑暗鸦", "呆呆王", "梦妖", "未知图腾A", "果然翁", "麒麟奇", "榛果球", "佛烈托斯", "土龙弟弟", "天蝎", "大钢蛇", "布鲁", "布鲁皇", "千针鱼", "巨钳螳螂", "壶壶", "赫拉克罗斯", "狃拉", "熊宝宝", "圈圈熊", "熔岩虫", "熔岩蜗牛", "小山猪", "长毛猪", "太阳珊瑚", "铁炮鱼", "章鱼桶", "信使鸟", "巨翅飞鱼", "盔甲鸟", "戴鲁比", "黑鲁加", "刺龙王", "小小象", "顿甲", "多边兽Ⅱ", "惊角鹿", "图图犬", "无畏小子", "战舞郎", "迷唇娃", "电击怪", "鸭嘴宝宝", "大奶罐", "幸福蛋", "雷公", "炎帝", "水君", "幼基拉斯", "沙基拉斯", "班基拉斯", "洛奇亚", "凤王", "时拉比", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "木守宫", "森林蜥蜴", "蜥蜴王", "火稚鸡", "力壮鸡", "火焰鸡", "水跃鱼", "沼跃鱼", "巨沼怪", "土狼犬", "大狼犬", "蛇纹熊", "直冲熊", "刺尾虫", "甲壳茧", "狩猎凤蝶", "盾甲茧", "毒粉蛾", "莲叶童子", "莲帽小童", "乐天河童", "橡实果", "长鼻叶", "狡猾天狗", "土居忍士", "铁面忍者", "脱壳忍者", "傲骨燕", "大王燕", "蘑蘑菇", "斗笠菇", "晃晃斑", "长翅鸥", "大嘴鸥", "溜溜糖球", "雨翅蛾", "吼吼鲸", "吼鲸王", "向尾喵", "优雅猫", "变隐龙", "天秤偶", "念力土偶", "朝北鼻", "煤炭龟", "勾魂眼", "泥泥鳅", "鲶鱼王", "爱心鱼", "龙虾小兵", "铁螯龙虾", "丑丑鱼", "美纳斯", "利牙鱼", "巨牙鲨", "大颚蚁", "超音波幼虫", "沙漠蜻蜓", "幕下力士", "铁掌力士", "落雷兽", "雷电兽", "呆火驼", "喷火驼", "海豹球", "海魔狮", "帝牙海狮", "刺球仙人掌", "梦歌仙人掌", "雪童子", "冰鬼护", "月石", "太阳岩", "露力丽", "跳跳猪", "噗噗猪", "正电拍拍", "负电拍拍", "大嘴娃", "玛沙那", "恰雷姆", "青绵鸟", "七夕青鸟", "小果然", "夜巡灵", "彷徨夜灵", "毒蔷薇", "懒人獭", "过动猿", "请假王", "溶食兽", "吞食兽", "热带龙", "咕妞妞", "吼爆弹", "爆音怪", "珍珠贝", "猎斑鱼", "樱花鱼", "阿勃梭鲁", "怨影娃娃", "诅咒娃娃", "饭匙蛇", "猫鼬斩", "古空棘鱼", "可可多拉", "可多拉", "波士可多拉", "飘浮泡泡", "电萤虫", "甜甜萤", "触手百合", "摇篮百合", "太古羽虫", "太古盔甲", "拉鲁拉丝", "奇鲁莉安", "沙奈朵", "宝贝龙", "甲壳龙", "暴飞龙", "铁哑铃", "金属怪", "巨金怪", "雷吉洛克", "雷吉艾斯", "雷吉斯奇鲁", "盖欧卡", "固拉多", "烈空坐", "拉帝亚斯", "拉帝欧斯", "基拉祈", "代欧奇希斯", "风铃铃", "蛋", "未知图腾B", "未知图腾C", "未知图腾D", "未知图腾E", "未知图腾F", "未知图腾G", "未知图腾H", "未知图腾I", "未知图腾J", "未知图腾K", "未知图腾L", "未知图腾M", "未知图腾N", "未知图腾O", "未知图腾P", "未知图腾Q", "未知图腾R", "未知图腾S", "未知图腾T", "未知图腾U", "未知图腾V", "未知图腾W", "未知图腾X", "未知图腾Y", "未知图腾Z", "未知图腾!", "未知图腾?" });
            pkm3.Location = new Point(119, 208);
            pkm3.Margin = new Padding(4);
            pkm3.Name = "pkm3";
            pkm3.Size = new Size(213, 23);
            pkm3.TabIndex = 51;
            // 
            // pkm2
            // 
            pkm2.FormattingEnabled = true;
            pkm2.Items.AddRange(new object[] { "无", "妙蛙种子", "妙蛙草", "妙蛙花", "小火龙", "火恐龙", "喷火龙", "杰尼龟", "卡咪龟", "水箭龟", "绿毛虫", "铁甲蛹", "巴大蝶", "独角虫", "铁壳蛹", "大针蜂", "波波", "比比鸟", "大比鸟", "小拉达", "拉达", "烈雀", "大嘴雀", "阿柏蛇", "阿柏怪", "皮卡丘", "雷丘", "穿山鼠", "穿山王", "尼多兰", "尼多娜", "尼多后", "尼多朗", "尼多力诺", "尼多王", "皮皮", "皮可西", "六尾", "九尾", "胖丁", "胖可丁", "超音蝠", "大嘴蝠", "走路草", "臭臭花", "霸王花", "派拉斯", "派拉斯特", "毛球", "摩鲁蛾", "地鼠", "三地鼠", "喵喵", "猫老大", "可达鸭", "哥达鸭", "猴怪", "火暴猴", "卡蒂狗", "风速狗", "蚊香蝌蚪", "蚊香君", "蚊香泳士", "凯西", "勇基拉", "胡地", "腕力", "豪力", "怪力", "喇叭芽", "口呆花", "大食花", "玛瑙水母", "毒刺水母", "小拳石", "隆隆石", "隆隆岩", "小火马", "烈焰马", "呆呆兽", "呆壳兽", "小磁怪", "三合一磁怪", "大葱鸭", "嘟嘟", "嘟嘟利", "小海狮", "白海狮", "臭泥", "臭臭泥", "大舌贝", "刺甲贝", "鬼斯", "鬼斯通", "耿鬼", "大岩蛇", "催眠貘", "引梦貘人", "大钳蟹", "巨钳蟹", "霹雳电球", "顽皮雷弹", "蛋蛋", "椰蛋树", "卡拉卡拉", "嘎啦嘎啦", "飞腿郎", "快拳郎", "大舌头", "瓦斯弹", "双弹瓦斯", "独角犀牛", "钻角犀兽", "吉利蛋", "蔓藤怪", "袋兽", "墨海马", "海刺龙", "角金鱼", "金鱼王", "海星星", "宝石海星", "魔墙人偶", "飞天螳螂", "迷唇姐", "电击兽", "鸭嘴火兽", "凯罗斯", "肯泰罗", "鲤鱼王", "暴鲤龙", "拉普拉斯", "百变怪", "伊布", "水伊布", "雷伊布", "火伊布", "多边兽", "菊石兽", "多刺菊石兽", "化石盔", "镰刀盔", "化石翼龙", "卡比兽", "急冻鸟", "闪电鸟", "火焰鸟", "迷你龙", "哈克龙", "快龙", "超梦", "梦幻", "菊草叶", "月桂叶", "大竺葵", "火球鼠", "火岩鼠", "火暴兽", "小锯鳄", "蓝鳄", "大力鳄", "尾立", "大尾立", "咕咕", "猫头夜鹰", "芭瓢虫", "安瓢虫", "圆丝蛛", "阿利多斯", "叉字蝠", "灯笼鱼", "电灯怪", "皮丘", "皮宝宝", "宝宝丁", "波克比", "波克基古", "天然雀", "天然鸟", "咩利羊", "茸茸羊", "电龙", "美丽花", "玛力露", "玛力露丽", "树才怪", "蚊香蛙皇", "毽子草", "毽子花", "毽子棉", "长尾怪手", "向日种子", "向日花怪", "蜻蜻蜓", "乌波", "沼王", "太阳伊布", "月亮伊布", "黑暗鸦", "呆呆王", "梦妖", "未知图腾A", "果然翁", "麒麟奇", "榛果球", "佛烈托斯", "土龙弟弟", "天蝎", "大钢蛇", "布鲁", "布鲁皇", "千针鱼", "巨钳螳螂", "壶壶", "赫拉克罗斯", "狃拉", "熊宝宝", "圈圈熊", "熔岩虫", "熔岩蜗牛", "小山猪", "长毛猪", "太阳珊瑚", "铁炮鱼", "章鱼桶", "信使鸟", "巨翅飞鱼", "盔甲鸟", "戴鲁比", "黑鲁加", "刺龙王", "小小象", "顿甲", "多边兽Ⅱ", "惊角鹿", "图图犬", "无畏小子", "战舞郎", "迷唇娃", "电击怪", "鸭嘴宝宝", "大奶罐", "幸福蛋", "雷公", "炎帝", "水君", "幼基拉斯", "沙基拉斯", "班基拉斯", "洛奇亚", "凤王", "时拉比", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "木守宫", "森林蜥蜴", "蜥蜴王", "火稚鸡", "力壮鸡", "火焰鸡", "水跃鱼", "沼跃鱼", "巨沼怪", "土狼犬", "大狼犬", "蛇纹熊", "直冲熊", "刺尾虫", "甲壳茧", "狩猎凤蝶", "盾甲茧", "毒粉蛾", "莲叶童子", "莲帽小童", "乐天河童", "橡实果", "长鼻叶", "狡猾天狗", "土居忍士", "铁面忍者", "脱壳忍者", "傲骨燕", "大王燕", "蘑蘑菇", "斗笠菇", "晃晃斑", "长翅鸥", "大嘴鸥", "溜溜糖球", "雨翅蛾", "吼吼鲸", "吼鲸王", "向尾喵", "优雅猫", "变隐龙", "天秤偶", "念力土偶", "朝北鼻", "煤炭龟", "勾魂眼", "泥泥鳅", "鲶鱼王", "爱心鱼", "龙虾小兵", "铁螯龙虾", "丑丑鱼", "美纳斯", "利牙鱼", "巨牙鲨", "大颚蚁", "超音波幼虫", "沙漠蜻蜓", "幕下力士", "铁掌力士", "落雷兽", "雷电兽", "呆火驼", "喷火驼", "海豹球", "海魔狮", "帝牙海狮", "刺球仙人掌", "梦歌仙人掌", "雪童子", "冰鬼护", "月石", "太阳岩", "露力丽", "跳跳猪", "噗噗猪", "正电拍拍", "负电拍拍", "大嘴娃", "玛沙那", "恰雷姆", "青绵鸟", "七夕青鸟", "小果然", "夜巡灵", "彷徨夜灵", "毒蔷薇", "懒人獭", "过动猿", "请假王", "溶食兽", "吞食兽", "热带龙", "咕妞妞", "吼爆弹", "爆音怪", "珍珠贝", "猎斑鱼", "樱花鱼", "阿勃梭鲁", "怨影娃娃", "诅咒娃娃", "饭匙蛇", "猫鼬斩", "古空棘鱼", "可可多拉", "可多拉", "波士可多拉", "飘浮泡泡", "电萤虫", "甜甜萤", "触手百合", "摇篮百合", "太古羽虫", "太古盔甲", "拉鲁拉丝", "奇鲁莉安", "沙奈朵", "宝贝龙", "甲壳龙", "暴飞龙", "铁哑铃", "金属怪", "巨金怪", "雷吉洛克", "雷吉艾斯", "雷吉斯奇鲁", "盖欧卡", "固拉多", "烈空坐", "拉帝亚斯", "拉帝欧斯", "基拉祈", "代欧奇希斯", "风铃铃", "蛋", "未知图腾B", "未知图腾C", "未知图腾D", "未知图腾E", "未知图腾F", "未知图腾G", "未知图腾H", "未知图腾I", "未知图腾J", "未知图腾K", "未知图腾L", "未知图腾M", "未知图腾N", "未知图腾O", "未知图腾P", "未知图腾Q", "未知图腾R", "未知图腾S", "未知图腾T", "未知图腾U", "未知图腾V", "未知图腾W", "未知图腾X", "未知图腾Y", "未知图腾Z", "未知图腾!", "未知图腾?" });
            pkm2.Location = new Point(119, 182);
            pkm2.Margin = new Padding(4);
            pkm2.Name = "pkm2";
            pkm2.Size = new Size(213, 23);
            pkm2.TabIndex = 50;
            // 
            // pkm1
            // 
            pkm1.FormattingEnabled = true;
            pkm1.Items.AddRange(new object[] { "无", "妙蛙种子", "妙蛙草", "妙蛙花", "小火龙", "火恐龙", "喷火龙", "杰尼龟", "卡咪龟", "水箭龟", "绿毛虫", "铁甲蛹", "巴大蝶", "独角虫", "铁壳蛹", "大针蜂", "波波", "比比鸟", "大比鸟", "小拉达", "拉达", "烈雀", "大嘴雀", "阿柏蛇", "阿柏怪", "皮卡丘", "雷丘", "穿山鼠", "穿山王", "尼多兰", "尼多娜", "尼多后", "尼多朗", "尼多力诺", "尼多王", "皮皮", "皮可西", "六尾", "九尾", "胖丁", "胖可丁", "超音蝠", "大嘴蝠", "走路草", "臭臭花", "霸王花", "派拉斯", "派拉斯特", "毛球", "摩鲁蛾", "地鼠", "三地鼠", "喵喵", "猫老大", "可达鸭", "哥达鸭", "猴怪", "火暴猴", "卡蒂狗", "风速狗", "蚊香蝌蚪", "蚊香君", "蚊香泳士", "凯西", "勇基拉", "胡地", "腕力", "豪力", "怪力", "喇叭芽", "口呆花", "大食花", "玛瑙水母", "毒刺水母", "小拳石", "隆隆石", "隆隆岩", "小火马", "烈焰马", "呆呆兽", "呆壳兽", "小磁怪", "三合一磁怪", "大葱鸭", "嘟嘟", "嘟嘟利", "小海狮", "白海狮", "臭泥", "臭臭泥", "大舌贝", "刺甲贝", "鬼斯", "鬼斯通", "耿鬼", "大岩蛇", "催眠貘", "引梦貘人", "大钳蟹", "巨钳蟹", "霹雳电球", "顽皮雷弹", "蛋蛋", "椰蛋树", "卡拉卡拉", "嘎啦嘎啦", "飞腿郎", "快拳郎", "大舌头", "瓦斯弹", "双弹瓦斯", "独角犀牛", "钻角犀兽", "吉利蛋", "蔓藤怪", "袋兽", "墨海马", "海刺龙", "角金鱼", "金鱼王", "海星星", "宝石海星", "魔墙人偶", "飞天螳螂", "迷唇姐", "电击兽", "鸭嘴火兽", "凯罗斯", "肯泰罗", "鲤鱼王", "暴鲤龙", "拉普拉斯", "百变怪", "伊布", "水伊布", "雷伊布", "火伊布", "多边兽", "菊石兽", "多刺菊石兽", "化石盔", "镰刀盔", "化石翼龙", "卡比兽", "急冻鸟", "闪电鸟", "火焰鸟", "迷你龙", "哈克龙", "快龙", "超梦", "梦幻", "菊草叶", "月桂叶", "大竺葵", "火球鼠", "火岩鼠", "火暴兽", "小锯鳄", "蓝鳄", "大力鳄", "尾立", "大尾立", "咕咕", "猫头夜鹰", "芭瓢虫", "安瓢虫", "圆丝蛛", "阿利多斯", "叉字蝠", "灯笼鱼", "电灯怪", "皮丘", "皮宝宝", "宝宝丁", "波克比", "波克基古", "天然雀", "天然鸟", "咩利羊", "茸茸羊", "电龙", "美丽花", "玛力露", "玛力露丽", "树才怪", "蚊香蛙皇", "毽子草", "毽子花", "毽子棉", "长尾怪手", "向日种子", "向日花怪", "蜻蜻蜓", "乌波", "沼王", "太阳伊布", "月亮伊布", "黑暗鸦", "呆呆王", "梦妖", "未知图腾A", "果然翁", "麒麟奇", "榛果球", "佛烈托斯", "土龙弟弟", "天蝎", "大钢蛇", "布鲁", "布鲁皇", "千针鱼", "巨钳螳螂", "壶壶", "赫拉克罗斯", "狃拉", "熊宝宝", "圈圈熊", "熔岩虫", "熔岩蜗牛", "小山猪", "长毛猪", "太阳珊瑚", "铁炮鱼", "章鱼桶", "信使鸟", "巨翅飞鱼", "盔甲鸟", "戴鲁比", "黑鲁加", "刺龙王", "小小象", "顿甲", "多边兽Ⅱ", "惊角鹿", "图图犬", "无畏小子", "战舞郎", "迷唇娃", "电击怪", "鸭嘴宝宝", "大奶罐", "幸福蛋", "雷公", "炎帝", "水君", "幼基拉斯", "沙基拉斯", "班基拉斯", "洛奇亚", "凤王", "时拉比", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "木守宫", "森林蜥蜴", "蜥蜴王", "火稚鸡", "力壮鸡", "火焰鸡", "水跃鱼", "沼跃鱼", "巨沼怪", "土狼犬", "大狼犬", "蛇纹熊", "直冲熊", "刺尾虫", "甲壳茧", "狩猎凤蝶", "盾甲茧", "毒粉蛾", "莲叶童子", "莲帽小童", "乐天河童", "橡实果", "长鼻叶", "狡猾天狗", "土居忍士", "铁面忍者", "脱壳忍者", "傲骨燕", "大王燕", "蘑蘑菇", "斗笠菇", "晃晃斑", "长翅鸥", "大嘴鸥", "溜溜糖球", "雨翅蛾", "吼吼鲸", "吼鲸王", "向尾喵", "优雅猫", "变隐龙", "天秤偶", "念力土偶", "朝北鼻", "煤炭龟", "勾魂眼", "泥泥鳅", "鲶鱼王", "爱心鱼", "龙虾小兵", "铁螯龙虾", "丑丑鱼", "美纳斯", "利牙鱼", "巨牙鲨", "大颚蚁", "超音波幼虫", "沙漠蜻蜓", "幕下力士", "铁掌力士", "落雷兽", "雷电兽", "呆火驼", "喷火驼", "海豹球", "海魔狮", "帝牙海狮", "刺球仙人掌", "梦歌仙人掌", "雪童子", "冰鬼护", "月石", "太阳岩", "露力丽", "跳跳猪", "噗噗猪", "正电拍拍", "负电拍拍", "大嘴娃", "玛沙那", "恰雷姆", "青绵鸟", "七夕青鸟", "小果然", "夜巡灵", "彷徨夜灵", "毒蔷薇", "懒人獭", "过动猿", "请假王", "溶食兽", "吞食兽", "热带龙", "咕妞妞", "吼爆弹", "爆音怪", "珍珠贝", "猎斑鱼", "樱花鱼", "阿勃梭鲁", "怨影娃娃", "诅咒娃娃", "饭匙蛇", "猫鼬斩", "古空棘鱼", "可可多拉", "可多拉", "波士可多拉", "飘浮泡泡", "电萤虫", "甜甜萤", "触手百合", "摇篮百合", "太古羽虫", "太古盔甲", "拉鲁拉丝", "奇鲁莉安", "沙奈朵", "宝贝龙", "甲壳龙", "暴飞龙", "铁哑铃", "金属怪", "巨金怪", "雷吉洛克", "雷吉艾斯", "雷吉斯奇鲁", "盖欧卡", "固拉多", "烈空坐", "拉帝亚斯", "拉帝欧斯", "基拉祈", "代欧奇希斯", "风铃铃", "蛋", "未知图腾B", "未知图腾C", "未知图腾D", "未知图腾E", "未知图腾F", "未知图腾G", "未知图腾H", "未知图腾I", "未知图腾J", "未知图腾K", "未知图腾L", "未知图腾M", "未知图腾N", "未知图腾O", "未知图腾P", "未知图腾Q", "未知图腾R", "未知图腾S", "未知图腾T", "未知图腾U", "未知图腾V", "未知图腾W", "未知图腾X", "未知图腾Y", "未知图腾Z", "未知图腾!", "未知图腾?" });
            pkm1.Location = new Point(119, 150);
            pkm1.Margin = new Padding(4);
            pkm1.Name = "pkm1";
            pkm1.Size = new Size(213, 23);
            pkm1.TabIndex = 49;
            // 
            // label9
            // 
            label9.Location = new Point(19, 212);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 48;
            label9.Text = "宝可梦3：";
            // 
            // label8
            // 
            label8.Location = new Point(19, 184);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(133, 21);
            label8.TabIndex = 47;
            label8.Text = "宝可梦2：";
            // 
            // label7
            // 
            label7.Location = new Point(19, 152);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 23);
            label7.TabIndex = 46;
            label7.Text = "宝可梦1：";
            // 
            // pkm3_edit_but
            // 
            pkm3_edit_but.Enabled = false;
            pkm3_edit_but.Location = new Point(348, 206);
            pkm3_edit_but.Margin = new Padding(4);
            pkm3_edit_but.Name = "pkm3_edit_but";
            pkm3_edit_but.Size = new Size(100, 26);
            pkm3_edit_but.TabIndex = 45;
            pkm3_edit_but.Text = "EDIT";
            pkm3_edit_but.UseVisualStyleBackColor = true;
            pkm3_edit_but.Click += Pkm3_edit_butClick;
            // 
            // pkm2_edit_but
            // 
            pkm2_edit_but.Enabled = false;
            pkm2_edit_but.Location = new Point(348, 178);
            pkm2_edit_but.Margin = new Padding(4);
            pkm2_edit_but.Name = "pkm2_edit_but";
            pkm2_edit_but.Size = new Size(100, 26);
            pkm2_edit_but.TabIndex = 44;
            pkm2_edit_but.Text = "编辑";
            pkm2_edit_but.UseVisualStyleBackColor = true;
            pkm2_edit_but.Click += Pkm2_edit_butClick;
            // 
            // pkm1_edit_but
            // 
            pkm1_edit_but.Enabled = false;
            pkm1_edit_but.Location = new Point(348, 148);
            pkm1_edit_but.Margin = new Padding(4);
            pkm1_edit_but.Name = "pkm1_edit_but";
            pkm1_edit_but.Size = new Size(100, 26);
            pkm1_edit_but.TabIndex = 43;
            pkm1_edit_but.Text = "编辑";
            pkm1_edit_but.UseVisualStyleBackColor = true;
            pkm1_edit_but.Click += Pkm1_edit_butClick;
            // 
            // label6
            // 
            label6.Location = new Point(32, 117);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 26);
            label6.TabIndex = 42;
            label6.Text = "SID:";
            // 
            // SID
            // 
            SID.Location = new Point(119, 118);
            SID.Margin = new Padding(4);
            SID.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            SID.Name = "SID";
            SID.Size = new Size(215, 25);
            SID.TabIndex = 41;
            // 
            // TID
            // 
            TID.Location = new Point(119, 88);
            TID.Margin = new Padding(4);
            TID.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            TID.Name = "TID";
            TID.Size = new Size(215, 25);
            TID.TabIndex = 40;
            // 
            // label5
            // 
            label5.Location = new Point(32, 90);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 26);
            label5.TabIndex = 39;
            label5.Text = "TID:";
            // 
            // label4
            // 
            label4.Location = new Point(32, 62);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 26);
            label4.TabIndex = 38;
            label4.Text = "名字：";
            // 
            // name
            // 
            name.Location = new Point(119, 58);
            name.Margin = new Padding(4);
            name.MaxLength = 7;
            name.Name = "name";
            name.Size = new Size(213, 25);
            name.TabIndex = 37;
            // 
            // jap_check
            // 
            jap_check.Enabled = false;
            jap_check.Location = new Point(341, 56);
            jap_check.Margin = new Padding(4);
            jap_check.Name = "jap_check";
            jap_check.Size = new Size(139, 28);
            jap_check.TabIndex = 52;
            jap_check.Text = "日文解码";
            jap_check.UseVisualStyleBackColor = true;
            jap_check.CheckedChanged += Jap_checkCheckedChanged;
            // 
            // radio_rs
            // 
            radio_rs.Location = new Point(8, 22);
            radio_rs.Margin = new Padding(4);
            radio_rs.Name = "radio_rs";
            radio_rs.Size = new Size(139, 20);
            radio_rs.TabIndex = 53;
            radio_rs.TabStop = true;
            radio_rs.Text = "红宝石/蓝宝石";
            radio_rs.UseVisualStyleBackColor = true;
            radio_rs.CheckedChanged += Radio_rsCheckedChanged;
            // 
            // radio_e
            // 
            radio_e.Location = new Point(8, 41);
            radio_e.Margin = new Padding(4);
            radio_e.Name = "radio_e";
            radio_e.Size = new Size(117, 23);
            radio_e.TabIndex = 54;
            radio_e.TabStop = true;
            radio_e.Text = "绿宝石";
            radio_e.UseVisualStyleBackColor = true;
            radio_e.CheckedChanged += Radio_eCheckedChanged;
            // 
            // radio_FRLG
            // 
            radio_FRLG.Location = new Point(8, 62);
            radio_FRLG.Margin = new Padding(4);
            radio_FRLG.Name = "radio_FRLG";
            radio_FRLG.Size = new Size(165, 26);
            radio_FRLG.TabIndex = 55;
            radio_FRLG.TabStop = true;
            radio_FRLG.Text = "火红/叶绿";
            radio_FRLG.UseVisualStyleBackColor = true;
            radio_FRLG.CheckedChanged += Radio_FRLGCheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radio_rs);
            groupBox4.Controls.Add(radio_e);
            groupBox4.Controls.Add(radio_FRLG);
            groupBox4.Location = new Point(299, 326);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(181, 124);
            groupBox4.TabIndex = 56;
            groupBox4.TabStop = false;
            groupBox4.Text = "训练家类型列表";
            // 
            // tower_appearance_num
            // 
            tower_appearance_num.Location = new Point(119, 262);
            tower_appearance_num.Margin = new Padding(4);
            tower_appearance_num.Name = "tower_appearance_num";
            tower_appearance_num.Size = new Size(66, 25);
            tower_appearance_num.TabIndex = 57;
            // 
            // trainer_class_value
            // 
            trainer_class_value.Hexadecimal = true;
            trainer_class_value.Location = new Point(119, 296);
            trainer_class_value.Margin = new Padding(4);
            trainer_class_value.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            trainer_class_value.Name = "trainer_class_value";
            trainer_class_value.Size = new Size(67, 25);
            trainer_class_value.TabIndex = 58;
            trainer_class_value.ValueChanged += Trainer_class_valueValueChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(jap);
            groupBox5.Controls.Add(esp);
            groupBox5.Controls.Add(ita);
            groupBox5.Controls.Add(ger);
            groupBox5.Controls.Add(fre);
            groupBox5.Controls.Add(eng);
            groupBox5.Location = new Point(493, 360);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(552, 90);
            groupBox5.TabIndex = 59;
            groupBox5.TabStop = false;
            groupBox5.Text = "简单会话系统语言";
            // 
            // jap
            // 
            jap.Location = new Point(375, 47);
            jap.Margin = new Padding(4);
            jap.Name = "jap";
            jap.Size = new Size(139, 28);
            jap.TabIndex = 3;
            jap.TabStop = true;
            jap.Text = "日语";
            jap.UseVisualStyleBackColor = true;
            jap.CheckedChanged += JapCheckedChanged;
            // 
            // esp
            // 
            esp.Location = new Point(205, 47);
            esp.Margin = new Padding(4);
            esp.Name = "esp";
            esp.Size = new Size(139, 28);
            esp.TabIndex = 61;
            esp.TabStop = true;
            esp.Text = "西班牙语";
            esp.UseVisualStyleBackColor = true;
            esp.CheckedChanged += EspCheckedChanged;
            // 
            // ita
            // 
            ita.Location = new Point(36, 47);
            ita.Margin = new Padding(4);
            ita.Name = "ita";
            ita.Size = new Size(139, 28);
            ita.TabIndex = 60;
            ita.TabStop = true;
            ita.Text = "意大利语";
            ita.UseVisualStyleBackColor = true;
            ita.CheckedChanged += ItaCheckedChanged;
            // 
            // ger
            // 
            ger.Location = new Point(375, 22);
            ger.Margin = new Padding(4);
            ger.Name = "ger";
            ger.Size = new Size(139, 28);
            ger.TabIndex = 2;
            ger.TabStop = true;
            ger.Text = "德语";
            ger.UseVisualStyleBackColor = true;
            ger.CheckedChanged += GerCheckedChanged;
            // 
            // fre
            // 
            fre.Location = new Point(205, 22);
            fre.Margin = new Padding(4);
            fre.Name = "fre";
            fre.Size = new Size(139, 28);
            fre.TabIndex = 1;
            fre.TabStop = true;
            fre.Text = "法语";
            fre.UseVisualStyleBackColor = true;
            fre.CheckedChanged += FreCheckedChanged;
            // 
            // eng
            // 
            eng.Location = new Point(36, 22);
            eng.Margin = new Padding(4);
            eng.Name = "eng";
            eng.Size = new Size(139, 28);
            eng.TabIndex = 0;
            eng.TabStop = true;
            eng.Text = "英语";
            eng.UseVisualStyleBackColor = true;
            eng.CheckedChanged += EngCheckedChanged;
            // 
            // ECT_editor
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 481);
            Controls.Add(groupBox5);
            Controls.Add(trainer_class_value);
            Controls.Add(tower_appearance_num);
            Controls.Add(groupBox4);
            Controls.Add(jap_check);
            Controls.Add(pkm3);
            Controls.Add(pkm2);
            Controls.Add(pkm1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pkm3_edit_but);
            Controls.Add(pkm2_edit_but);
            Controls.Add(pkm1_edit_but);
            Controls.Add(label6);
            Controls.Add(SID);
            Controls.Add(TID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(name);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tower_floor);
            Controls.Add(label3);
            Controls.Add(helpclass_but);
            Controls.Add(trainer_class);
            Controls.Add(label2);
            Controls.Add(tower_appearance);
            Controls.Add(label1);
            Controls.Add(ect_path);
            Controls.Add(save_ect_but);
            Controls.Add(load_ect_but);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ECT_editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e卡训练家编辑器";
            DragDrop += ECT_editorDragDrop;
            DragEnter += ECT_editorDragEnter;
            ((System.ComponentModel.ISupportInitialize)tower_floor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SID).EndInit();
            ((System.ComponentModel.ISupportInitialize)TID).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tower_appearance_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainer_class_value).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

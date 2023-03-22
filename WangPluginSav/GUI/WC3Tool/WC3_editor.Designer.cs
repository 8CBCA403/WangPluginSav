using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class WC3_editor
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WC3_editor));
            load_wc3_but = new Button();
            save_wc3_but = new Button();
            wc3_path = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            header1 = new TextBox();
            header2 = new TextBox();
            body1 = new TextBox();
            body2 = new TextBox();
            body3 = new TextBox();
            body4 = new TextBox();
            footer1 = new TextBox();
            footer2 = new TextBox();
            export_script_but = new Button();
            import_script_but = new Button();
            custom_script = new CheckBox();
            iconbox = new ComboBox();
            label9 = new Label();
            colorbox = new ComboBox();
            label10 = new Label();
            icon_num = new NumericUpDown();
            distro_but_always = new RadioButton();
            groupBox1 = new GroupBox();
            distro_but_no = new RadioButton();
            distro_but_one = new RadioButton();
            regionlab = new Label();
            giveEgg_but = new Button();
            groupBox2 = new GroupBox();
            map_help = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            map_npc = new NumericUpDown();
            map_map = new NumericUpDown();
            map_bank = new NumericUpDown();
            xse_import = new Button();
            xse_export = new Button();
            xse_help = new Button();
            giveEggExt_but = new Button();
            faketoogle = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)icon_num).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)map_npc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)map_map).BeginInit();
            ((System.ComponentModel.ISupportInitialize)map_bank).BeginInit();
            SuspendLayout();
            // 
            // load_wc3_but
            // 
            load_wc3_but.Location = new Point(65, 13);
            load_wc3_but.Margin = new Padding(4);
            load_wc3_but.Name = "load_wc3_but";
            load_wc3_but.Size = new Size(100, 26);
            load_wc3_but.TabIndex = 0;
            load_wc3_but.Text = "读取神秘\r卡片文件";
            load_wc3_but.UseVisualStyleBackColor = true;
            load_wc3_but.Click += Load_wc3_butClick;
            // 
            // save_wc3_but
            // 
            save_wc3_but.Enabled = false;
            save_wc3_but.Location = new Point(173, 13);
            save_wc3_but.Margin = new Padding(4);
            save_wc3_but.Name = "save_wc3_but";
            save_wc3_but.Size = new Size(100, 26);
            save_wc3_but.TabIndex = 1;
            save_wc3_but.Text = "Save WC3";
            save_wc3_but.UseVisualStyleBackColor = true;
            save_wc3_but.Click += Save_wc3_butClick;
            // 
            // wc3_path
            // 
            wc3_path.Location = new Point(295, 15);
            wc3_path.Margin = new Padding(4);
            wc3_path.Name = "wc3_path";
            wc3_path.ReadOnly = true;
            wc3_path.Size = new Size(695, 25);
            wc3_path.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(61, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 26);
            label1.TabIndex = 3;
            label1.Text = "标题1";
            // 
            // label2
            // 
            label2.Location = new Point(61, 161);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 26);
            label2.TabIndex = 4;
            label2.Text = "标题2";
            // 
            // label3
            // 
            label3.Location = new Point(61, 188);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 26);
            label3.TabIndex = 5;
            label3.Text = "正文1";
            // 
            // label4
            // 
            label4.Location = new Point(61, 214);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 26);
            label4.TabIndex = 6;
            label4.Text = "正文2";
            // 
            // label5
            // 
            label5.Location = new Point(61, 242);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 26);
            label5.TabIndex = 7;
            label5.Text = "正文3";
            // 
            // label6
            // 
            label6.Location = new Point(61, 268);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 26);
            label6.TabIndex = 8;
            label6.Text = "正文4";
            // 
            // label7
            // 
            label7.Location = new Point(61, 294);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 26);
            label7.TabIndex = 9;
            label7.Text = "页脚1";
            // 
            // label8
            // 
            label8.Location = new Point(61, 321);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(133, 26);
            label8.TabIndex = 10;
            label8.Text = "页脚2";
            // 
            // header1
            // 
            header1.Location = new Point(152, 131);
            header1.Margin = new Padding(4);
            header1.MaxLength = 40;
            header1.Name = "header1";
            header1.Size = new Size(504, 25);
            header1.TabIndex = 11;
            header1.TextChanged += Header1TextChanged;
            // 
            // header2
            // 
            header2.Location = new Point(152, 158);
            header2.Margin = new Padding(4);
            header2.MaxLength = 40;
            header2.Name = "header2";
            header2.Size = new Size(504, 25);
            header2.TabIndex = 12;
            header2.TextChanged += Header2TextChanged;
            // 
            // body1
            // 
            body1.Location = new Point(152, 184);
            body1.Margin = new Padding(4);
            body1.MaxLength = 40;
            body1.Name = "body1";
            body1.Size = new Size(504, 25);
            body1.TabIndex = 13;
            body1.TextChanged += Body1TextChanged;
            // 
            // body2
            // 
            body2.Location = new Point(152, 212);
            body2.Margin = new Padding(4);
            body2.MaxLength = 40;
            body2.Name = "body2";
            body2.Size = new Size(504, 25);
            body2.TabIndex = 14;
            body2.TextChanged += Body2TextChanged;
            // 
            // body3
            // 
            body3.Location = new Point(152, 238);
            body3.Margin = new Padding(4);
            body3.MaxLength = 40;
            body3.Name = "body3";
            body3.Size = new Size(504, 25);
            body3.TabIndex = 15;
            body3.TextChanged += Body3TextChanged;
            // 
            // body4
            // 
            body4.Location = new Point(152, 264);
            body4.Margin = new Padding(4);
            body4.MaxLength = 40;
            body4.Name = "body4";
            body4.Size = new Size(504, 25);
            body4.TabIndex = 16;
            body4.TextChanged += Body4TextChanged;
            // 
            // footer1
            // 
            footer1.Location = new Point(152, 291);
            footer1.Margin = new Padding(4);
            footer1.MaxLength = 40;
            footer1.Name = "footer1";
            footer1.Size = new Size(504, 25);
            footer1.TabIndex = 17;
            footer1.TextChanged += Footer1TextChanged;
            // 
            // footer2
            // 
            footer2.Location = new Point(152, 317);
            footer2.Margin = new Padding(4);
            footer2.MaxLength = 40;
            footer2.Name = "footer2";
            footer2.Size = new Size(504, 25);
            footer2.TabIndex = 18;
            footer2.TextChanged += Footer2TextChanged;
            // 
            // export_script_but
            // 
            export_script_but.Enabled = false;
            export_script_but.Location = new Point(65, 351);
            export_script_but.Margin = new Padding(4);
            export_script_but.Name = "export_script_but";
            export_script_but.Size = new Size(100, 26);
            export_script_but.TabIndex = 19;
            export_script_but.Text = "导出脚本";
            export_script_but.UseVisualStyleBackColor = true;
            export_script_but.Click += Export_script_butClick;
            // 
            // import_script_but
            // 
            import_script_but.Enabled = false;
            import_script_but.Location = new Point(173, 351);
            import_script_but.Margin = new Padding(4);
            import_script_but.Name = "import_script_but";
            import_script_but.Size = new Size(100, 26);
            import_script_but.TabIndex = 20;
            import_script_but.Text = "导入脚本";
            import_script_but.UseVisualStyleBackColor = true;
            import_script_but.Click += Import_script_butClick;
            // 
            // custom_script
            // 
            custom_script.AutoCheck = false;
            custom_script.Location = new Point(287, 351);
            custom_script.Margin = new Padding(4);
            custom_script.Name = "custom_script";
            custom_script.Size = new Size(148, 28);
            custom_script.TabIndex = 21;
            custom_script.Text = "读取自制脚本";
            custom_script.UseVisualStyleBackColor = true;
            // 
            // iconbox
            // 
            iconbox.FormattingEnabled = true;
            iconbox.Items.AddRange(new object[] { "????????", "妙蛙种子", "妙蛙草", "妙蛙花", "小火龙", "火恐龙", "喷火龙", "杰尼龟", "卡咪龟", "水箭龟", "绿毛虫", "铁甲蛹", "巴大蝶", "独角虫", "铁壳蛹", "大针蜂", "波波", "比比鸟", "大比鸟", "小拉达", "拉达", "烈雀", "大嘴雀", "阿柏蛇", "阿柏怪", "皮卡丘", "雷丘", "穿山鼠", "穿山王", "尼多兰", "尼多娜", "尼多后", "尼多朗", "尼多力诺", "尼多王", "皮皮", "皮可西", "六尾", "九尾", "胖丁", "胖可丁", "超音蝠", "大嘴蝠", "走路草", "臭臭花", "霸王花", "派拉斯", "派拉斯特", "毛球", "摩鲁蛾", "地鼠", "三地鼠", "喵喵", "猫老大", "可达鸭", "哥达鸭", "猴怪", "火暴猴", "卡蒂狗", "风速狗", "蚊香蝌蚪", "蚊香君", "蚊香泳士", "凯西", "勇基拉", "胡地", "腕力", "豪力", "怪力", "喇叭芽", "口呆花", "大食花", "玛瑙水母", "毒刺水母", "小拳石", "隆隆石", "隆隆岩", "小火马", "烈焰马", "呆呆兽", "呆壳兽", "小磁怪", "三合一磁怪", "大葱鸭", "嘟嘟", "嘟嘟利", "小海狮", "白海狮", "臭泥", "臭臭泥", "大舌贝", "刺甲贝", "鬼斯", "鬼斯通", "耿鬼", "大岩蛇", "催眠貘", "引梦貘人", "大钳蟹", "巨钳蟹", "霹雳电球", "顽皮雷弹", "蛋蛋", "椰蛋树", "卡拉卡拉", "嘎啦嘎啦", "飞腿郎", "快拳郎", "大舌头", "瓦斯弹", "双弹瓦斯", "独角犀牛", "钻角犀兽", "吉利蛋", "蔓藤怪", "袋兽", "墨海马", "海刺龙", "角金鱼", "金鱼王", "海星星", "宝石海星", "魔墙人偶", "飞天螳螂", "迷唇姐", "电击兽", "鸭嘴火兽", "凯罗斯", "肯泰罗", "鲤鱼王", "暴鲤龙", "拉普拉斯", "百变怪", "伊布", "水伊布", "雷伊布", "火伊布", "多边兽", "菊石兽", "多刺菊石兽", "化石盔", "镰刀盔", "化石翼龙", "卡比兽", "急冻鸟", "闪电鸟", "火焰鸟", "迷你龙", "哈克龙", "快龙", "超梦", "梦幻", "菊草叶", "月桂叶", "大竺葵", "火球鼠", "火岩鼠", "火暴兽", "小锯鳄", "蓝鳄", "大力鳄", "尾立", "大尾立", "咕咕", "猫头夜鹰", "芭瓢虫", "安瓢虫", "圆丝蛛", "阿利多斯", "叉字蝠", "灯笼鱼", "电灯怪", "皮丘", "皮宝宝", "宝宝丁", "波克比", "波克基古", "天然雀", "天然鸟", "咩利羊", "茸茸羊", "电龙", "美丽花", "玛力露", "玛力露丽", "树才怪", "蚊香蛙皇", "毽子草", "毽子花", "毽子棉", "长尾怪手", "向日种子", "向日花怪", "蜻蜻蜓", "乌波", "沼王", "太阳伊布", "月亮伊布", "黑暗鸦", "呆呆王", "梦妖", "未知图腾A", "果然翁", "麒麟奇", "榛果球", "佛烈托斯", "土龙弟弟", "天蝎", "大钢蛇", "布鲁", "布鲁皇", "千针鱼", "巨钳螳螂", "壶壶", "赫拉克罗斯", "狃拉", "熊宝宝", "圈圈熊", "熔岩虫", "熔岩蜗牛", "小山猪", "长毛猪", "太阳珊瑚", "铁炮鱼", "章鱼桶", "信使鸟", "巨翅飞鱼", "盔甲鸟", "戴鲁比", "黑鲁加", "刺龙王", "小小象", "顿甲", "多边兽Ⅱ", "惊角鹿", "图图犬", "无畏小子", "战舞郎", "迷唇娃", "电击怪", "鸭嘴宝宝", "大奶罐", "幸福蛋", "雷公", "炎帝", "水君", "幼基拉斯", "沙基拉斯", "班基拉斯", "洛奇亚", "凤王", "时拉比", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "木守宫", "森林蜥蜴", "蜥蜴王", "火稚鸡", "力壮鸡", "火焰鸡", "水跃鱼", "沼跃鱼", "巨沼怪", "土狼犬", "大狼犬", "蛇纹熊", "直冲熊", "刺尾虫", "甲壳茧", "狩猎凤蝶", "盾甲茧", "毒粉蛾", "莲叶童子", "莲帽小童", "乐天河童", "橡实果", "长鼻叶", "狡猾天狗", "土居忍士", "铁面忍者", "脱壳忍者", "傲骨燕", "大王燕", "蘑蘑菇", "斗笠菇", "晃晃斑", "长翅鸥", "大嘴鸥", "溜溜糖球", "雨翅蛾", "吼吼鲸", "吼鲸王", "向尾喵", "优雅猫", "变隐龙", "天秤偶", "念力土偶", "朝北鼻", "煤炭龟", "勾魂眼", "泥泥鳅", "鲶鱼王", "爱心鱼", "龙虾小兵", "铁螯龙虾", "丑丑鱼", "美纳斯", "利牙鱼", "巨牙鲨", "大颚蚁", "超音波幼虫", "沙漠蜻蜓", "幕下力士", "铁掌力士", "落雷兽", "雷电兽", "呆火驼", "喷火驼", "海豹球", "海魔狮", "帝牙海狮", "刺球仙人掌", "梦歌仙人掌", "雪童子", "冰鬼护", "月石", "太阳岩", "露力丽", "跳跳猪", "噗噗猪", "正电拍拍", "负电拍拍", "大嘴娃", "玛沙那", "恰雷姆", "青绵鸟", "七夕青鸟", "小果然", "夜巡灵", "彷徨夜灵", "毒蔷薇", "懒人獭", "过动猿", "请假王", "溶食兽", "吞食兽", "热带龙", "咕妞妞", "吼爆弹", "爆音怪", "珍珠贝", "猎斑鱼", "樱花鱼", "阿勃梭鲁", "怨影娃娃", "诅咒娃娃", "饭匙蛇", "猫鼬斩", "古空棘鱼", "可可多拉", "可多拉", "波士可多拉", "飘浮泡泡", "电萤虫", "甜甜萤", "触手百合", "摇篮百合", "太古羽虫", "太古盔甲", "拉鲁拉丝", "奇鲁莉安", "沙奈朵", "宝贝龙", "甲壳龙", "暴飞龙", "铁哑铃", "金属怪", "巨金怪", "雷吉洛克", "雷吉艾斯", "雷吉斯奇鲁", "盖欧卡", "固拉多", "烈空坐", "拉帝亚斯", "拉帝欧斯", "基拉祈", "代欧奇希斯", "风铃铃", "蛋", "未知图腾B", "未知图腾C", "未知图腾D", "未知图腾E", "未知图腾F", "未知图腾G", "未知图腾H", "未知图腾I", "未知图腾J", "未知图腾K", "未知图腾L", "未知图腾M", "未知图腾N", "未知图腾O", "未知图腾P", "未知图腾Q", "未知图腾R", "未知图腾S", "未知图腾T", "未知图腾U", "未知图腾V", "未知图腾W", "未知图腾X", "未知图腾Y", "未知图腾Z", "未知图腾!", "未知图腾?", "按索引设置  --->" });
            iconbox.Location = new Point(153, 98);
            iconbox.Margin = new Padding(4);
            iconbox.Name = "iconbox";
            iconbox.Size = new Size(323, 23);
            iconbox.TabIndex = 23;
            iconbox.SelectedIndexChanged += IconboxSelectedIndexChanged;
            // 
            // label9
            // 
            label9.Location = new Point(61, 101);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 16);
            label9.TabIndex = 24;
            label9.Text = "Icon";
            // 
            // colorbox
            // 
            colorbox.FormattingEnabled = true;
            colorbox.Items.AddRange(new object[] { "深黄色+方块图案 (0x00)", "深蓝/绿色+方块图案 (0x04)", "红色+线条图案 (0x08)", "绿色+线条图案 (0x0c)", "蓝色+线条图案 (0x10)", "黄色+线条图案 (0x14)", "黄色+精灵球图案 (0x18)", "灰色+精灵球图案 (0x1c)" });
            colorbox.Location = new Point(153, 67);
            colorbox.Margin = new Padding(4);
            colorbox.Name = "colorbox";
            colorbox.Size = new Size(323, 23);
            colorbox.TabIndex = 25;
            colorbox.SelectedIndexChanged += ColorboxSelectedIndexChanged;
            // 
            // label10
            // 
            label10.Location = new Point(41, 69);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(104, 22);
            label10.TabIndex = 26;
            label10.Text = "颜色及图案";
            // 
            // icon_num
            // 
            icon_num.Location = new Point(497, 99);
            icon_num.Margin = new Padding(4);
            icon_num.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            icon_num.Name = "icon_num";
            icon_num.Size = new Size(160, 25);
            icon_num.TabIndex = 27;
            icon_num.ValueChanged += Icon_numValueChanged;
            // 
            // distro_but_always
            // 
            distro_but_always.Location = new Point(8, 22);
            distro_but_always.Margin = new Padding(4);
            distro_but_always.Name = "distro_but_always";
            distro_but_always.Size = new Size(188, 28);
            distro_but_always.TabIndex = 28;
            distro_but_always.TabStop = true;
            distro_but_always.Text = "永久";
            distro_but_always.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(distro_but_no);
            groupBox1.Controls.Add(distro_but_one);
            groupBox1.Controls.Add(distro_but_always);
            groupBox1.Location = new Point(665, 45);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(205, 110);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "是否可再分享配信";
            // 
            // distro_but_no
            // 
            distro_but_no.Location = new Point(8, 75);
            distro_but_no.Margin = new Padding(4);
            distro_but_no.Name = "distro_but_no";
            distro_but_no.Size = new Size(188, 28);
            distro_but_no.TabIndex = 30;
            distro_but_no.TabStop = true;
            distro_but_no.Text = "禁用";
            distro_but_no.UseVisualStyleBackColor = true;
            // 
            // distro_but_one
            // 
            distro_but_one.Location = new Point(8, 49);
            distro_but_one.Margin = new Padding(4);
            distro_but_one.Name = "distro_but_one";
            distro_but_one.Size = new Size(188, 28);
            distro_but_one.TabIndex = 29;
            distro_but_one.TabStop = true;
            distro_but_one.Text = "接收者不能再分享";
            distro_but_one.UseVisualStyleBackColor = true;
            // 
            // regionlab
            // 
            regionlab.Location = new Point(497, 69);
            regionlab.Margin = new Padding(4, 0, 4, 0);
            regionlab.Name = "regionlab";
            regionlab.Size = new Size(133, 26);
            regionlab.TabIndex = 30;
            regionlab.Text = "美/欧版";
            // 
            // giveEgg_but
            // 
            giveEgg_but.Location = new Point(65, 428);
            giveEgg_but.Margin = new Padding(4);
            giveEgg_but.Name = "giveEgg_but";
            giveEgg_but.Size = new Size(180, 26);
            giveEgg_but.TabIndex = 31;
            giveEgg_but.Text = "注入赠蛋脚本";
            giveEgg_but.UseVisualStyleBackColor = true;
            giveEgg_but.Click += GiveEgg_butClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(map_help);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(map_npc);
            groupBox2.Controls.Add(map_map);
            groupBox2.Controls.Add(map_bank);
            groupBox2.Location = new Point(386, 374);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(271, 130);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "脚本关联";
            // 
            // map_help
            // 
            map_help.Location = new Point(232, 13);
            map_help.Margin = new Padding(4);
            map_help.Name = "map_help";
            map_help.Size = new Size(28, 26);
            map_help.TabIndex = 7;
            map_help.Text = "?";
            map_help.UseVisualStyleBackColor = true;
            map_help.Click += Map_helpClick;
            // 
            // label14
            // 
            label14.Location = new Point(167, 36);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(96, 83);
            label14.TabIndex = 6;
            label14.Text = "全255时为宝可梦中心邮递员";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Location = new Point(23, 96);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(48, 26);
            label13.TabIndex = 5;
            label13.Text = "NPC:";
            // 
            // label12
            // 
            label12.Location = new Point(23, 66);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(48, 26);
            label12.TabIndex = 4;
            label12.Text = "Map:";
            // 
            // label11
            // 
            label11.Location = new Point(23, 36);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 21);
            label11.TabIndex = 3;
            label11.Text = "Bank:";
            // 
            // map_npc
            // 
            map_npc.Location = new Point(79, 94);
            map_npc.Margin = new Padding(4);
            map_npc.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            map_npc.Name = "map_npc";
            map_npc.Size = new Size(80, 25);
            map_npc.TabIndex = 2;
            // 
            // map_map
            // 
            map_map.Location = new Point(79, 64);
            map_map.Margin = new Padding(4);
            map_map.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            map_map.Name = "map_map";
            map_map.Size = new Size(80, 25);
            map_map.TabIndex = 1;
            // 
            // map_bank
            // 
            map_bank.Location = new Point(79, 34);
            map_bank.Margin = new Padding(4);
            map_bank.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            map_bank.Name = "map_bank";
            map_bank.Size = new Size(80, 25);
            map_bank.TabIndex = 0;
            // 
            // xse_import
            // 
            xse_import.Enabled = false;
            xse_import.Location = new Point(173, 384);
            xse_import.Margin = new Padding(4);
            xse_import.Name = "xse_import";
            xse_import.Size = new Size(100, 26);
            xse_import.TabIndex = 34;
            xse_import.Text = "XSE导入";
            xse_import.UseVisualStyleBackColor = true;
            xse_import.Click += Xse_importClick;
            // 
            // xse_export
            // 
            xse_export.Enabled = false;
            xse_export.Location = new Point(65, 384);
            xse_export.Margin = new Padding(4);
            xse_export.Name = "xse_export";
            xse_export.Size = new Size(100, 26);
            xse_export.TabIndex = 33;
            xse_export.Text = "XSE导出";
            xse_export.UseVisualStyleBackColor = true;
            xse_export.Click += Xse_exportClick;
            // 
            // xse_help
            // 
            xse_help.Location = new Point(281, 386);
            xse_help.Margin = new Padding(4);
            xse_help.Name = "xse_help";
            xse_help.Size = new Size(28, 26);
            xse_help.TabIndex = 8;
            xse_help.Text = "?";
            xse_help.UseVisualStyleBackColor = true;
            xse_help.Click += Xse_helpClick;
            // 
            // giveEggExt_but
            // 
            giveEggExt_but.Location = new Point(65, 461);
            giveEggExt_but.Margin = new Padding(4);
            giveEggExt_but.Name = "giveEggExt_but";
            giveEggExt_but.Size = new Size(180, 40);
            giveEggExt_but.TabIndex = 35;
            giveEggExt_but.Text = "注入赠蛋脚本(拓展版)";
            giveEggExt_but.UseVisualStyleBackColor = true;
            giveEggExt_but.Click += GiveEggExt_butClick;
            // 
            // faketoogle
            // 
            faketoogle.Location = new Point(173, 44);
            faketoogle.Margin = new Padding(4);
            faketoogle.Name = "faketoogle";
            faketoogle.Size = new Size(168, 20);
            faketoogle.TabIndex = 36;
            faketoogle.Text = "Fake saved WC ID";
            faketoogle.UseVisualStyleBackColor = true;
            faketoogle.Visible = false;
            // 
            // WC3_editor
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 517);
            Controls.Add(faketoogle);
            Controls.Add(giveEggExt_but);
            Controls.Add(xse_help);
            Controls.Add(xse_import);
            Controls.Add(xse_export);
            Controls.Add(groupBox2);
            Controls.Add(giveEgg_but);
            Controls.Add(regionlab);
            Controls.Add(groupBox1);
            Controls.Add(icon_num);
            Controls.Add(label10);
            Controls.Add(colorbox);
            Controls.Add(label9);
            Controls.Add(iconbox);
            Controls.Add(custom_script);
            Controls.Add(import_script_but);
            Controls.Add(export_script_but);
            Controls.Add(footer2);
            Controls.Add(footer1);
            Controls.Add(body4);
            Controls.Add(body3);
            Controls.Add(body2);
            Controls.Add(body1);
            Controls.Add(header2);
            Controls.Add(header1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wc3_path);
            Controls.Add(save_wc3_but);
            Controls.Add(load_wc3_but);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "WC3_editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "神秘卡片编辑器";
            Load += WC3_editorLoad;
            DragDrop += WC3_editorDragDrop;
            DragEnter += WC3_editorDragEnter;
            ((System.ComponentModel.ISupportInitialize)icon_num).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)map_npc).EndInit();
            ((System.ComponentModel.ISupportInitialize)map_map).EndInit();
            ((System.ComponentModel.ISupportInitialize)map_bank).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class TV_editor
    {
        private System.ComponentModel.IContainer components = null;
        private Button save_but;

        private GroupBox groupBox1;

        private NumericUpDown event_days;

        private ComboBox event_id;

        private ComboBox event_status;

        private NumericUpDown event_slot;

        private Label label1;

        private Label label5;

        private Label label4;

        private Label label3;

        private Label label2;

        private GroupBox groupBox2;

        private NumericUpDown current_appearance;

        private NumericUpDown current_map;

        private NumericUpDown current_level;

        private ComboBox current_species;

        private ComboBox current_move4;

        private ComboBox current_move3;

        private ComboBox current_move2;

        private ComboBox current_move1;

        private NumericUpDown current_remaining;

        private Label label14;

        private Label label10;

        private Label label11;

        private Label label12;

        private Label label13;

        private Label label9;

        private Label label8;

        private Label label7;

        private Label label6;

        private GroupBox groupBox3;

        private Button swarm_delete;

        private NumericUpDown tv_mix_tid;

        private Label label15;

        private NumericUpDown tv_tid;

        private Label label16;

        private NumericUpDown tv_id;

        private Label label17;

        private Label label18;

        private ComboBox tv_status;

        private NumericUpDown tv_slot;

        private Label label19;

        private Label label20;

        private GroupBox tv_outbreak_group;

        private NumericUpDown outbreak_activation;

        private Label label31;

        private Label label28;

        private Label label29;

        private Label label24;

        private NumericUpDown outbreak_level;

        private NumericUpDown outbreak_remaining;

        private ComboBox outbreak_species;

        private Label label25;

        private Label label23;

        private Label label26;

        private Label label21;

        private Label label27;

        private ComboBox outbreak_move4;

        private NumericUpDown outbreak_map;

        private ComboBox outbreak_move3;

        private Label label22;

        private ComboBox outbreak_move2;

        private NumericUpDown outbreak_availability;

        private ComboBox outbreak_move1;

        private Button outbreak_apply;

        private Button swarm_apply;

        private Button event_apply;

        private Label label30;

        private Label label32;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TV_editor));
            save_but = new Button();
            groupBox1 = new GroupBox();
            event_apply = new Button();
            label5 = new Label();
            event_days = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            event_id = new ComboBox();
            event_status = new ComboBox();
            event_slot = new NumericUpDown();
            label1 = new Label();
            groupBox2 = new GroupBox();
            swarm_apply = new Button();
            swarm_delete = new Button();
            current_remaining = new NumericUpDown();
            label14 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            current_appearance = new NumericUpDown();
            current_map = new NumericUpDown();
            current_level = new NumericUpDown();
            current_species = new ComboBox();
            current_move4 = new ComboBox();
            current_move3 = new ComboBox();
            current_move2 = new ComboBox();
            current_move1 = new ComboBox();
            groupBox3 = new GroupBox();
            tv_id = new NumericUpDown();
            label20 = new Label();
            tv_mix_tid = new NumericUpDown();
            label15 = new Label();
            tv_tid = new NumericUpDown();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            tv_status = new ComboBox();
            tv_slot = new NumericUpDown();
            label19 = new Label();
            tv_outbreak_group = new GroupBox();
            outbreak_apply = new Button();
            outbreak_activation = new NumericUpDown();
            label31 = new Label();
            label28 = new Label();
            label29 = new Label();
            label24 = new Label();
            outbreak_level = new NumericUpDown();
            outbreak_remaining = new NumericUpDown();
            outbreak_species = new ComboBox();
            label25 = new Label();
            label23 = new Label();
            label26 = new Label();
            label21 = new Label();
            label27 = new Label();
            outbreak_move4 = new ComboBox();
            outbreak_map = new NumericUpDown();
            outbreak_move3 = new ComboBox();
            label22 = new Label();
            outbreak_move2 = new ComboBox();
            outbreak_availability = new NumericUpDown();
            outbreak_move1 = new ComboBox();
            label30 = new Label();
            label32 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)event_days).BeginInit();
            ((System.ComponentModel.ISupportInitialize)event_slot).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)current_remaining).BeginInit();
            ((System.ComponentModel.ISupportInitialize)current_appearance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)current_map).BeginInit();
            ((System.ComponentModel.ISupportInitialize)current_level).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tv_id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tv_mix_tid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tv_tid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tv_slot).BeginInit();
            tv_outbreak_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)outbreak_activation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outbreak_level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outbreak_remaining).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outbreak_map).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outbreak_availability).BeginInit();
            SuspendLayout();
            // 
            // save_but
            // 
            save_but.Location = new Point(353, 590);
            save_but.Margin = new Padding(4);
            save_but.Name = "save_but";
            save_but.Size = new Size(100, 26);
            save_but.TabIndex = 7;
            save_but.Text = "写入记录";
            save_but.UseVisualStyleBackColor = true;
            save_but.Click += Save_butClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(event_apply);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(event_days);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(event_id);
            groupBox1.Controls.Add(event_status);
            groupBox1.Controls.Add(event_slot);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 14);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(511, 176);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "电视-事件";
            // 
            // event_apply
            // 
            event_apply.Location = new Point(361, 127);
            event_apply.Margin = new Padding(4);
            event_apply.Name = "event_apply";
            event_apply.Size = new Size(129, 26);
            event_apply.TabIndex = 31;
            event_apply.Text = "应用当前更改";
            event_apply.UseVisualStyleBackColor = true;
            event_apply.Click += Event_applyClick;
            // 
            // label5
            // 
            label5.Location = new Point(8, 147);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(345, 25);
            label5.TabIndex = 8;
            label5.Text = "注：预告节目将在事件激活的前2天开始播出。";
            // 
            // event_days
            // 
            event_days.Location = new Point(152, 114);
            event_days.Margin = new Padding(4);
            event_days.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            event_days.Name = "event_days";
            event_days.Size = new Size(95, 25);
            event_days.TabIndex = 4;
            event_days.ValueChanged += Event_daysValueChanged;
            // 
            // label4
            // 
            label4.Location = new Point(8, 116);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 24);
            label4.TabIndex = 7;
            label4.Text = "事件激活倒计天数：";
            // 
            // label3
            // 
            label3.Location = new Point(8, 86);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 24);
            label3.TabIndex = 6;
            label3.Text = "事件：";
            // 
            // label2
            // 
            label2.Location = new Point(8, 56);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 5;
            label2.Text = "状态：";
            // 
            // event_id
            // 
            event_id.FormattingEnabled = true;
            event_id.Items.AddRange(new object[] { "无", "大减价 (凯那市场能量专家)", "会员服务日 (紫堇游戏城)", "大甩卖 (水静百货公司)", "树果混合名人(水静华丽大赛会场)(仅绿宝石!)" });
            event_id.Location = new Point(152, 83);
            event_id.Margin = new Padding(4);
            event_id.Name = "event_id";
            event_id.Size = new Size(349, 23);
            event_id.TabIndex = 3;
            event_id.SelectedIndexChanged += Event_idSelectedIndexChanged;
            // 
            // event_status
            // 
            event_status.FormattingEnabled = true;
            event_status.Items.AddRange(new object[] { "已收看", "未收看", "已收看+事件已激活" });
            event_status.Location = new Point(152, 52);
            event_status.Margin = new Padding(4);
            event_status.Name = "event_status";
            event_status.Size = new Size(349, 23);
            event_status.TabIndex = 2;
            event_status.SelectedIndexChanged += Event_statusSelectedIndexChanged;
            // 
            // event_slot
            // 
            event_slot.Location = new Point(152, 22);
            event_slot.Margin = new Padding(4);
            event_slot.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            event_slot.Name = "event_slot";
            event_slot.Size = new Size(95, 25);
            event_slot.TabIndex = 0;
            event_slot.ValueChanged += Event_slotValueChanged;
            // 
            // label1
            // 
            label1.Location = new Point(8, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 24);
            label1.TabIndex = 1;
            label1.Text = "槽位：";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(swarm_apply);
            groupBox2.Controls.Add(swarm_delete);
            groupBox2.Controls.Add(current_remaining);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(current_appearance);
            groupBox2.Controls.Add(current_map);
            groupBox2.Controls.Add(current_level);
            groupBox2.Controls.Add(current_species);
            groupBox2.Controls.Add(current_move4);
            groupBox2.Controls.Add(current_move3);
            groupBox2.Controls.Add(current_move2);
            groupBox2.Controls.Add(current_move1);
            groupBox2.Location = new Point(541, 14);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(289, 358);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "当前大量出现";
            // 
            // swarm_apply
            // 
            swarm_apply.Location = new Point(9, 317);
            swarm_apply.Margin = new Padding(4);
            swarm_apply.Name = "swarm_apply";
            swarm_apply.Size = new Size(129, 26);
            swarm_apply.TabIndex = 30;
            swarm_apply.Text = "应用当前更改";
            swarm_apply.UseVisualStyleBackColor = true;
            swarm_apply.Click += Swarm_applyClick;
            // 
            // swarm_delete
            // 
            swarm_delete.Location = new Point(152, 317);
            swarm_delete.Margin = new Padding(4);
            swarm_delete.Name = "swarm_delete";
            swarm_delete.Size = new Size(129, 26);
            swarm_delete.TabIndex = 18;
            swarm_delete.Text = "删除";
            swarm_delete.UseVisualStyleBackColor = true;
            swarm_delete.Click += Swarm_deleteClick;
            // 
            // current_remaining
            // 
            current_remaining.Location = new Point(119, 262);
            current_remaining.Margin = new Padding(4);
            current_remaining.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            current_remaining.Name = "current_remaining";
            current_remaining.Size = new Size(160, 25);
            current_remaining.TabIndex = 8;
            // 
            // label14
            // 
            label14.Location = new Point(9, 259);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(104, 26);
            label14.TabIndex = 17;
            label14.Text = "剩余天数";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Location = new Point(9, 233);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(104, 26);
            label10.TabIndex = 16;
            label10.Text = "相遇率%";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Location = new Point(9, 202);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(104, 26);
            label11.TabIndex = 15;
            label11.Text = "地图编号";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Location = new Point(9, 171);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(104, 26);
            label12.TabIndex = 14;
            label12.Text = "招式4";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.Location = new Point(9, 141);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(104, 26);
            label13.TabIndex = 13;
            label13.Text = "招式3";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new Point(9, 111);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(104, 26);
            label9.TabIndex = 12;
            label9.Text = "招式2";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(9, 80);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 26);
            label8.TabIndex = 11;
            label8.Text = "招式1";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(9, 49);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 26);
            label7.TabIndex = 10;
            label7.Text = "等级";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(9, 19);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 26);
            label6.TabIndex = 9;
            label6.Text = "种族";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // current_appearance
            // 
            current_appearance.Location = new Point(119, 232);
            current_appearance.Margin = new Padding(4);
            current_appearance.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            current_appearance.Name = "current_appearance";
            current_appearance.Size = new Size(160, 25);
            current_appearance.TabIndex = 7;
            // 
            // current_map
            // 
            current_map.Location = new Point(119, 202);
            current_map.Margin = new Padding(4);
            current_map.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            current_map.Name = "current_map";
            current_map.Size = new Size(160, 25);
            current_map.TabIndex = 6;
            // 
            // current_level
            // 
            current_level.Location = new Point(121, 52);
            current_level.Margin = new Padding(4);
            current_level.Name = "current_level";
            current_level.Size = new Size(160, 25);
            current_level.TabIndex = 5;
            current_level.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // current_species
            // 
            current_species.FormattingEnabled = true;
            current_species.Items.AddRange(new object[] { "无", "妙蛙种子", "妙蛙草", "妙蛙花", "小火龙", "火恐龙", "喷火龙", "杰尼龟", "卡咪龟", "水箭龟", "绿毛虫", "铁甲蛹", "巴大蝶", "独角虫", "铁壳蛹", "大针蜂", "波波", "比比鸟", "大比鸟", "小拉达", "拉达", "烈雀", "大嘴雀", "阿柏蛇", "阿柏怪", "皮卡丘", "雷丘", "穿山鼠", "穿山王", "尼多兰", "尼多娜", "尼多后", "尼多朗", "尼多力诺", "尼多王", "皮皮", "皮可西", "六尾", "九尾", "胖丁", "胖可丁", "超音蝠", "大嘴蝠", "走路草", "臭臭花", "霸王花", "派拉斯", "派拉斯特", "毛球", "摩鲁蛾", "地鼠", "三地鼠", "喵喵", "猫老大", "可达鸭", "哥达鸭", "猴怪", "火暴猴", "卡蒂狗", "风速狗", "蚊香蝌蚪", "蚊香君", "蚊香泳士", "凯西", "勇基拉", "胡地", "腕力", "豪力", "怪力", "喇叭芽", "口呆花", "大食花", "玛瑙水母", "毒刺水母", "小拳石", "隆隆石", "隆隆岩", "小火马", "烈焰马", "呆呆兽", "呆壳兽", "小磁怪", "三合一磁怪", "大葱鸭", "嘟嘟", "嘟嘟利", "小海狮", "白海狮", "臭泥", "臭臭泥", "大舌贝", "刺甲贝", "鬼斯", "鬼斯通", "耿鬼", "大岩蛇", "催眠貘", "引梦貘人", "大钳蟹", "巨钳蟹", "霹雳电球", "顽皮雷弹", "蛋蛋", "椰蛋树", "卡拉卡拉", "嘎啦嘎啦", "飞腿郎", "快拳郎", "大舌头", "瓦斯弹", "双弹瓦斯", "独角犀牛", "钻角犀兽", "吉利蛋", "蔓藤怪", "袋兽", "墨海马", "海刺龙", "角金鱼", "金鱼王", "海星星", "宝石海星", "魔墙人偶", "飞天螳螂", "迷唇姐", "电击兽", "鸭嘴火兽", "凯罗斯", "肯泰罗", "鲤鱼王", "暴鲤龙", "拉普拉斯", "百变怪", "伊布", "水伊布", "雷伊布", "火伊布", "多边兽", "菊石兽", "多刺菊石兽", "化石盔", "镰刀盔", "化石翼龙", "卡比兽", "急冻鸟", "闪电鸟", "火焰鸟", "迷你龙", "哈克龙", "快龙", "超梦", "梦幻", "菊草叶", "月桂叶", "大竺葵", "火球鼠", "火岩鼠", "火暴兽", "小锯鳄", "蓝鳄", "大力鳄", "尾立", "大尾立", "咕咕", "猫头夜鹰", "芭瓢虫", "安瓢虫", "圆丝蛛", "阿利多斯", "叉字蝠", "灯笼鱼", "电灯怪", "皮丘", "皮宝宝", "宝宝丁", "波克比", "波克基古", "天然雀", "天然鸟", "咩利羊", "茸茸羊", "电龙", "美丽花", "玛力露", "玛力露丽", "树才怪", "蚊香蛙皇", "毽子草", "毽子花", "毽子棉", "长尾怪手", "向日种子", "向日花怪", "蜻蜻蜓", "乌波", "沼王", "太阳伊布", "月亮伊布", "黑暗鸦", "呆呆王", "梦妖", "未知图腾A", "果然翁", "麒麟奇", "榛果球", "佛烈托斯", "土龙弟弟", "天蝎", "大钢蛇", "布鲁", "布鲁皇", "千针鱼", "巨钳螳螂", "壶壶", "赫拉克罗斯", "狃拉", "熊宝宝", "圈圈熊", "熔岩虫", "熔岩蜗牛", "小山猪", "长毛猪", "太阳珊瑚", "铁炮鱼", "章鱼桶", "信使鸟", "巨翅飞鱼", "盔甲鸟", "戴鲁比", "黑鲁加", "刺龙王", "小小象", "顿甲", "多边兽Ⅱ", "惊角鹿", "图图犬", "无畏小子", "战舞郎", "迷唇娃", "电击怪", "鸭嘴宝宝", "大奶罐", "幸福蛋", "雷公", "炎帝", "水君", "幼基拉斯", "沙基拉斯", "班基拉斯", "洛奇亚", "凤王", "时拉比", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "木守宫", "森林蜥蜴", "蜥蜴王", "火稚鸡", "力壮鸡", "火焰鸡", "水跃鱼", "沼跃鱼", "巨沼怪", "土狼犬", "大狼犬", "蛇纹熊", "直冲熊", "刺尾虫", "甲壳茧", "狩猎凤蝶", "盾甲茧", "毒粉蛾", "莲叶童子", "莲帽小童", "乐天河童", "橡实果", "长鼻叶", "狡猾天狗", "土居忍士", "铁面忍者", "脱壳忍者", "傲骨燕", "大王燕", "蘑蘑菇", "斗笠菇", "晃晃斑", "长翅鸥", "大嘴鸥", "溜溜糖球", "雨翅蛾", "吼吼鲸", "吼鲸王", "向尾喵", "优雅猫", "变隐龙", "天秤偶", "念力土偶", "朝北鼻", "煤炭龟", "勾魂眼", "泥泥鳅", "鲶鱼王", "爱心鱼", "龙虾小兵", "铁螯龙虾", "丑丑鱼", "美纳斯", "利牙鱼", "巨牙鲨", "大颚蚁", "超音波幼虫", "沙漠蜻蜓", "幕下力士", "铁掌力士", "落雷兽", "雷电兽", "呆火驼", "喷火驼", "海豹球", "海魔狮", "帝牙海狮", "刺球仙人掌", "梦歌仙人掌", "雪童子", "冰鬼护", "月石", "太阳岩", "露力丽", "跳跳猪", "噗噗猪", "正电拍拍", "负电拍拍", "大嘴娃", "玛沙那", "恰雷姆", "青绵鸟", "七夕青鸟", "小果然", "夜巡灵", "彷徨夜灵", "毒蔷薇", "懒人獭", "过动猿", "请假王", "溶食兽", "吞食兽", "热带龙", "咕妞妞", "吼爆弹", "爆音怪", "珍珠贝", "猎斑鱼", "樱花鱼", "阿勃梭鲁", "怨影娃娃", "诅咒娃娃", "饭匙蛇", "猫鼬斩", "古空棘鱼", "可可多拉", "可多拉", "波士可多拉", "飘浮泡泡", "电萤虫", "甜甜萤", "触手百合", "摇篮百合", "太古羽虫", "太古盔甲", "拉鲁拉丝", "奇鲁莉安", "沙奈朵", "宝贝龙", "甲壳龙", "暴飞龙", "铁哑铃", "金属怪", "巨金怪", "雷吉洛克", "雷吉艾斯", "雷吉斯奇鲁", "盖欧卡", "固拉多", "烈空坐", "拉帝亚斯", "拉帝欧斯", "基拉祈", "代欧奇希斯", "风铃铃", "蛋", "未知图腾B", "未知图腾C", "未知图腾D", "未知图腾E", "未知图腾F", "未知图腾G", "未知图腾H", "未知图腾I", "未知图腾J", "未知图腾K", "未知图腾L", "未知图腾M", "未知图腾N", "未知图腾O", "未知图腾P", "未知图腾Q", "未知图腾R", "未知图腾S", "未知图腾T", "未知图腾U", "未知图腾V", "未知图腾W", "未知图腾X", "未知图腾Y", "未知图腾Z", "未知图腾!", "未知图腾?" });
            current_species.Location = new Point(120, 21);
            current_species.Margin = new Padding(4);
            current_species.Name = "current_species";
            current_species.Size = new Size(160, 23);
            current_species.TabIndex = 4;
            // 
            // current_move4
            // 
            current_move4.FormattingEnabled = true;
            current_move4.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            current_move4.Location = new Point(119, 171);
            current_move4.Margin = new Padding(4);
            current_move4.Name = "current_move4";
            current_move4.Size = new Size(160, 23);
            current_move4.TabIndex = 3;
            // 
            // current_move3
            // 
            current_move3.FormattingEnabled = true;
            current_move3.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            current_move3.Location = new Point(119, 143);
            current_move3.Margin = new Padding(4);
            current_move3.Name = "current_move3";
            current_move3.Size = new Size(160, 23);
            current_move3.TabIndex = 2;
            // 
            // current_move2
            // 
            current_move2.FormattingEnabled = true;
            current_move2.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            current_move2.Location = new Point(119, 113);
            current_move2.Margin = new Padding(4);
            current_move2.Name = "current_move2";
            current_move2.Size = new Size(160, 23);
            current_move2.TabIndex = 1;
            // 
            // current_move1
            // 
            current_move1.FormattingEnabled = true;
            current_move1.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            current_move1.Location = new Point(119, 82);
            current_move1.Margin = new Padding(4);
            current_move1.Name = "current_move1";
            current_move1.Size = new Size(160, 23);
            current_move1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tv_id);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(tv_mix_tid);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(tv_tid);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(tv_status);
            groupBox3.Controls.Add(tv_slot);
            groupBox3.Controls.Add(label19);
            groupBox3.Location = new Point(23, 196);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(511, 176);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "电视-节目";
            // 
            // tv_id
            // 
            tv_id.Hexadecimal = true;
            tv_id.Location = new Point(152, 50);
            tv_id.Margin = new Padding(4);
            tv_id.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            tv_id.Name = "tv_id";
            tv_id.ReadOnly = true;
            tv_id.Size = new Size(95, 25);
            tv_id.TabIndex = 17;
            tv_id.ValueChanged += Tv_idValueChanged;
            // 
            // label20
            // 
            label20.Location = new Point(268, 20);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(223, 49);
            label20.TabIndex = 16;
            label20.Text = "注：槽位０对应游戏内生成的大量出现电视节目。";
            // 
            // tv_mix_tid
            // 
            tv_mix_tid.Location = new Point(152, 139);
            tv_mix_tid.Margin = new Padding(4);
            tv_mix_tid.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            tv_mix_tid.Name = "tv_mix_tid";
            tv_mix_tid.Size = new Size(95, 25);
            tv_mix_tid.TabIndex = 14;
            tv_mix_tid.ValueChanged += Tv_mix_tidValueChanged;
            // 
            // label15
            // 
            label15.Location = new Point(8, 141);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(136, 24);
            label15.TabIndex = 15;
            label15.Text = "混合记录TID：";
            // 
            // tv_tid
            // 
            tv_tid.Location = new Point(152, 111);
            tv_tid.Margin = new Padding(4);
            tv_tid.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            tv_tid.Name = "tv_tid";
            tv_tid.Size = new Size(95, 25);
            tv_tid.TabIndex = 12;
            tv_tid.ValueChanged += Tv_tidValueChanged;
            // 
            // label16
            // 
            label16.Location = new Point(8, 113);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(120, 24);
            label16.TabIndex = 13;
            label16.Text = "游戏TID：";
            // 
            // label17
            // 
            label17.Location = new Point(8, 52);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(153, 24);
            label17.TabIndex = 10;
            label17.Text = "ID（十六进制）：";
            // 
            // label18
            // 
            label18.Location = new Point(8, 80);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(120, 24);
            label18.TabIndex = 5;
            label18.Text = "状态：";
            // 
            // tv_status
            // 
            tv_status.FormattingEnabled = true;
            tv_status.Items.AddRange(new object[] { "已收看", "未收看" });
            tv_status.Location = new Point(152, 80);
            tv_status.Margin = new Padding(4);
            tv_status.Name = "tv_status";
            tv_status.Size = new Size(349, 23);
            tv_status.TabIndex = 2;
            tv_status.SelectedIndexChanged += Tv_statusSelectedIndexChanged;
            // 
            // tv_slot
            // 
            tv_slot.Location = new Point(152, 22);
            tv_slot.Margin = new Padding(4);
            tv_slot.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            tv_slot.Name = "tv_slot";
            tv_slot.Size = new Size(95, 25);
            tv_slot.TabIndex = 0;
            tv_slot.ValueChanged += Tv_slotValueChanged;
            // 
            // label19
            // 
            label19.Location = new Point(8, 24);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(80, 24);
            label19.TabIndex = 1;
            label19.Text = "槽位：";
            // 
            // tv_outbreak_group
            // 
            tv_outbreak_group.Controls.Add(outbreak_apply);
            tv_outbreak_group.Controls.Add(outbreak_activation);
            tv_outbreak_group.Controls.Add(label31);
            tv_outbreak_group.Controls.Add(label28);
            tv_outbreak_group.Controls.Add(label29);
            tv_outbreak_group.Controls.Add(label24);
            tv_outbreak_group.Controls.Add(outbreak_level);
            tv_outbreak_group.Controls.Add(outbreak_remaining);
            tv_outbreak_group.Controls.Add(outbreak_species);
            tv_outbreak_group.Controls.Add(label25);
            tv_outbreak_group.Controls.Add(label23);
            tv_outbreak_group.Controls.Add(label26);
            tv_outbreak_group.Controls.Add(label21);
            tv_outbreak_group.Controls.Add(label27);
            tv_outbreak_group.Controls.Add(outbreak_move4);
            tv_outbreak_group.Controls.Add(outbreak_map);
            tv_outbreak_group.Controls.Add(outbreak_move3);
            tv_outbreak_group.Controls.Add(label22);
            tv_outbreak_group.Controls.Add(outbreak_move2);
            tv_outbreak_group.Controls.Add(outbreak_availability);
            tv_outbreak_group.Controls.Add(outbreak_move1);
            tv_outbreak_group.Enabled = false;
            tv_outbreak_group.Location = new Point(23, 379);
            tv_outbreak_group.Margin = new Padding(4);
            tv_outbreak_group.Name = "tv_outbreak_group";
            tv_outbreak_group.Padding = new Padding(4);
            tv_outbreak_group.Size = new Size(808, 204);
            tv_outbreak_group.TabIndex = 10;
            tv_outbreak_group.TabStop = false;
            tv_outbreak_group.Text = "电视-节目（大量出现）编辑器";
            // 
            // outbreak_apply
            // 
            outbreak_apply.Location = new Point(73, 154);
            outbreak_apply.Margin = new Padding(4);
            outbreak_apply.Name = "outbreak_apply";
            outbreak_apply.Size = new Size(141, 26);
            outbreak_apply.TabIndex = 29;
            outbreak_apply.Text = "应用当前更改";
            outbreak_apply.UseVisualStyleBackColor = true;
            outbreak_apply.Click += Outbreak_applyClick;
            // 
            // outbreak_activation
            // 
            outbreak_activation.Location = new Point(152, 22);
            outbreak_activation.Margin = new Padding(4);
            outbreak_activation.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            outbreak_activation.Name = "outbreak_activation";
            outbreak_activation.Size = new Size(160, 25);
            outbreak_activation.TabIndex = 27;
            // 
            // label31
            // 
            label31.Location = new Point(8, 24);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(153, 24);
            label31.TabIndex = 28;
            label31.Text = "事件激活倒计天数";
            // 
            // label28
            // 
            label28.Location = new Point(439, 49);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(104, 26);
            label28.TabIndex = 22;
            label28.Text = "等级";
            label28.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            label29.Location = new Point(439, 19);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(104, 26);
            label29.TabIndex = 21;
            label29.Text = "种族";
            label29.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.Location = new Point(440, 171);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(104, 26);
            label24.TabIndex = 26;
            label24.Text = "招式4";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // outbreak_level
            // 
            outbreak_level.Location = new Point(551, 52);
            outbreak_level.Margin = new Padding(4);
            outbreak_level.Name = "outbreak_level";
            outbreak_level.Size = new Size(160, 25);
            outbreak_level.TabIndex = 20;
            outbreak_level.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // outbreak_remaining
            // 
            outbreak_remaining.Location = new Point(152, 112);
            outbreak_remaining.Margin = new Padding(4);
            outbreak_remaining.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            outbreak_remaining.Name = "outbreak_remaining";
            outbreak_remaining.Size = new Size(160, 25);
            outbreak_remaining.TabIndex = 21;
            // 
            // outbreak_species
            // 
            outbreak_species.FormattingEnabled = true;
            outbreak_species.Items.AddRange(new object[] { "无", "妙蛙种子", "妙蛙草", "妙蛙花", "小火龙", "火恐龙", "喷火龙", "杰尼龟", "卡咪龟", "水箭龟", "绿毛虫", "铁甲蛹", "巴大蝶", "独角虫", "铁壳蛹", "大针蜂", "波波", "比比鸟", "大比鸟", "小拉达", "拉达", "烈雀", "大嘴雀", "阿柏蛇", "阿柏怪", "皮卡丘", "雷丘", "穿山鼠", "穿山王", "尼多兰", "尼多娜", "尼多后", "尼多朗", "尼多力诺", "尼多王", "皮皮", "皮可西", "六尾", "九尾", "胖丁", "胖可丁", "超音蝠", "大嘴蝠", "走路草", "臭臭花", "霸王花", "派拉斯", "派拉斯特", "毛球", "摩鲁蛾", "地鼠", "三地鼠", "喵喵", "猫老大", "可达鸭", "哥达鸭", "猴怪", "火暴猴", "卡蒂狗", "风速狗", "蚊香蝌蚪", "蚊香君", "蚊香泳士", "凯西", "勇基拉", "胡地", "腕力", "豪力", "怪力", "喇叭芽", "口呆花", "大食花", "玛瑙水母", "毒刺水母", "小拳石", "隆隆石", "隆隆岩", "小火马", "烈焰马", "呆呆兽", "呆壳兽", "小磁怪", "三合一磁怪", "大葱鸭", "嘟嘟", "嘟嘟利", "小海狮", "白海狮", "臭泥", "臭臭泥", "大舌贝", "刺甲贝", "鬼斯", "鬼斯通", "耿鬼", "大岩蛇", "催眠貘", "引梦貘人", "大钳蟹", "巨钳蟹", "霹雳电球", "顽皮雷弹", "蛋蛋", "椰蛋树", "卡拉卡拉", "嘎啦嘎啦", "飞腿郎", "快拳郎", "大舌头", "瓦斯弹", "双弹瓦斯", "独角犀牛", "钻角犀兽", "吉利蛋", "蔓藤怪", "袋兽", "墨海马", "海刺龙", "角金鱼", "金鱼王", "海星星", "宝石海星", "魔墙人偶", "飞天螳螂", "迷唇姐", "电击兽", "鸭嘴火兽", "凯罗斯", "肯泰罗", "鲤鱼王", "暴鲤龙", "拉普拉斯", "百变怪", "伊布", "水伊布", "雷伊布", "火伊布", "多边兽", "菊石兽", "多刺菊石兽", "化石盔", "镰刀盔", "化石翼龙", "卡比兽", "急冻鸟", "闪电鸟", "火焰鸟", "迷你龙", "哈克龙", "快龙", "超梦", "梦幻", "菊草叶", "月桂叶", "大竺葵", "火球鼠", "火岩鼠", "火暴兽", "小锯鳄", "蓝鳄", "大力鳄", "尾立", "大尾立", "咕咕", "猫头夜鹰", "芭瓢虫", "安瓢虫", "圆丝蛛", "阿利多斯", "叉字蝠", "灯笼鱼", "电灯怪", "皮丘", "皮宝宝", "宝宝丁", "波克比", "波克基古", "天然雀", "天然鸟", "咩利羊", "茸茸羊", "电龙", "美丽花", "玛力露", "玛力露丽", "树才怪", "蚊香蛙皇", "毽子草", "毽子花", "毽子棉", "长尾怪手", "向日种子", "向日花怪", "蜻蜻蜓", "乌波", "沼王", "太阳伊布", "月亮伊布", "黑暗鸦", "呆呆王", "梦妖", "未知图腾A", "果然翁", "麒麟奇", "榛果球", "佛烈托斯", "土龙弟弟", "天蝎", "大钢蛇", "布鲁", "布鲁皇", "千针鱼", "巨钳螳螂", "壶壶", "赫拉克罗斯", "狃拉", "熊宝宝", "圈圈熊", "熔岩虫", "熔岩蜗牛", "小山猪", "长毛猪", "太阳珊瑚", "铁炮鱼", "章鱼桶", "信使鸟", "巨翅飞鱼", "盔甲鸟", "戴鲁比", "黑鲁加", "刺龙王", "小小象", "顿甲", "多边兽Ⅱ", "惊角鹿", "图图犬", "无畏小子", "战舞郎", "迷唇娃", "电击怪", "鸭嘴宝宝", "大奶罐", "幸福蛋", "雷公", "炎帝", "水君", "幼基拉斯", "沙基拉斯", "班基拉斯", "洛奇亚", "凤王", "时拉比", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "木守宫", "森林蜥蜴", "蜥蜴王", "火稚鸡", "力壮鸡", "火焰鸡", "水跃鱼", "沼跃鱼", "巨沼怪", "土狼犬", "大狼犬", "蛇纹熊", "直冲熊", "刺尾虫", "甲壳茧", "狩猎凤蝶", "盾甲茧", "毒粉蛾", "莲叶童子", "莲帽小童", "乐天河童", "橡实果", "长鼻叶", "狡猾天狗", "土居忍士", "铁面忍者", "脱壳忍者", "傲骨燕", "大王燕", "蘑蘑菇", "斗笠菇", "晃晃斑", "长翅鸥", "大嘴鸥", "溜溜糖球", "雨翅蛾", "吼吼鲸", "吼鲸王", "向尾喵", "优雅猫", "变隐龙", "天秤偶", "念力土偶", "朝北鼻", "煤炭龟", "勾魂眼", "泥泥鳅", "鲶鱼王", "爱心鱼", "龙虾小兵", "铁螯龙虾", "丑丑鱼", "美纳斯", "利牙鱼", "巨牙鲨", "大颚蚁", "超音波幼虫", "沙漠蜻蜓", "幕下力士", "铁掌力士", "落雷兽", "雷电兽", "呆火驼", "喷火驼", "海豹球", "海魔狮", "帝牙海狮", "刺球仙人掌", "梦歌仙人掌", "雪童子", "冰鬼护", "月石", "太阳岩", "露力丽", "跳跳猪", "噗噗猪", "正电拍拍", "负电拍拍", "大嘴娃", "玛沙那", "恰雷姆", "青绵鸟", "七夕青鸟", "小果然", "夜巡灵", "彷徨夜灵", "毒蔷薇", "懒人獭", "过动猿", "请假王", "溶食兽", "吞食兽", "热带龙", "咕妞妞", "吼爆弹", "爆音怪", "珍珠贝", "猎斑鱼", "樱花鱼", "阿勃梭鲁", "怨影娃娃", "诅咒娃娃", "饭匙蛇", "猫鼬斩", "古空棘鱼", "可可多拉", "可多拉", "波士可多拉", "飘浮泡泡", "电萤虫", "甜甜萤", "触手百合", "摇篮百合", "太古羽虫", "太古盔甲", "拉鲁拉丝", "奇鲁莉安", "沙奈朵", "宝贝龙", "甲壳龙", "暴飞龙", "铁哑铃", "金属怪", "巨金怪", "雷吉洛克", "雷吉艾斯", "雷吉斯奇鲁", "盖欧卡", "固拉多", "烈空坐", "拉帝亚斯", "拉帝欧斯", "基拉祈", "代欧奇希斯", "风铃铃", "蛋", "未知图腾B", "未知图腾C", "未知图腾D", "未知图腾E", "未知图腾F", "未知图腾G", "未知图腾H", "未知图腾I", "未知图腾J", "未知图腾K", "未知图腾L", "未知图腾M", "未知图腾N", "未知图腾O", "未知图腾P", "未知图腾Q", "未知图腾R", "未知图腾S", "未知图腾T", "未知图腾U", "未知图腾V", "未知图腾W", "未知图腾X", "未知图腾Y", "未知图腾Z", "未知图腾!", "未知图腾?" });
            outbreak_species.Location = new Point(549, 21);
            outbreak_species.Margin = new Padding(4);
            outbreak_species.Name = "outbreak_species";
            outbreak_species.Size = new Size(160, 23);
            outbreak_species.TabIndex = 19;
            // 
            // label25
            // 
            label25.Location = new Point(440, 141);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(104, 26);
            label25.TabIndex = 25;
            label25.Text = "招式3";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            label23.Location = new Point(8, 52);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(115, 26);
            label23.TabIndex = 22;
            label23.Text = "地图编号";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            label26.Location = new Point(440, 111);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(104, 26);
            label26.TabIndex = 24;
            label26.Text = "招式2";
            label26.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.Location = new Point(8, 109);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(115, 26);
            label21.TabIndex = 24;
            label21.Text = "剩余天数";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            label27.Location = new Point(440, 80);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(104, 26);
            label27.TabIndex = 23;
            label27.Text = "招式1";
            label27.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // outbreak_move4
            // 
            outbreak_move4.FormattingEnabled = true;
            outbreak_move4.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            outbreak_move4.Location = new Point(549, 171);
            outbreak_move4.Margin = new Padding(4);
            outbreak_move4.Name = "outbreak_move4";
            outbreak_move4.Size = new Size(160, 23);
            outbreak_move4.TabIndex = 22;
            // 
            // outbreak_map
            // 
            outbreak_map.Location = new Point(152, 52);
            outbreak_map.Margin = new Padding(4);
            outbreak_map.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            outbreak_map.Name = "outbreak_map";
            outbreak_map.Size = new Size(160, 25);
            outbreak_map.TabIndex = 19;
            // 
            // outbreak_move3
            // 
            outbreak_move3.FormattingEnabled = true;
            outbreak_move3.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            outbreak_move3.Location = new Point(549, 143);
            outbreak_move3.Margin = new Padding(4);
            outbreak_move3.Name = "outbreak_move3";
            outbreak_move3.Size = new Size(160, 23);
            outbreak_move3.TabIndex = 21;
            // 
            // label22
            // 
            label22.Location = new Point(8, 83);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(104, 26);
            label22.TabIndex = 23;
            label22.Text = "相遇率%";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // outbreak_move2
            // 
            outbreak_move2.FormattingEnabled = true;
            outbreak_move2.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            outbreak_move2.Location = new Point(549, 113);
            outbreak_move2.Margin = new Padding(4);
            outbreak_move2.Name = "outbreak_move2";
            outbreak_move2.Size = new Size(160, 23);
            outbreak_move2.TabIndex = 20;
            // 
            // outbreak_availability
            // 
            outbreak_availability.Location = new Point(152, 82);
            outbreak_availability.Margin = new Padding(4);
            outbreak_availability.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            outbreak_availability.Name = "outbreak_availability";
            outbreak_availability.Size = new Size(160, 25);
            outbreak_availability.TabIndex = 20;
            // 
            // outbreak_move1
            // 
            outbreak_move1.FormattingEnabled = true;
            outbreak_move1.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            outbreak_move1.Location = new Point(549, 82);
            outbreak_move1.Margin = new Padding(4);
            outbreak_move1.Name = "outbreak_move1";
            outbreak_move1.Size = new Size(160, 23);
            outbreak_move1.TabIndex = 19;
            // 
            // label30
            // 
            label30.Location = new Point(517, 590);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(313, 26);
            label30.TabIndex = 11;
            label30.Text = "注：可使用AdvanceMap查看地图编号";
            // 
            // label32
            // 
            label32.ForeColor = Color.Red;
            label32.Location = new Point(22, 587);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(323, 47);
            label32.TabIndex = 12;
            label32.Text = "本工具仅为半成品！\r请确保您的存档已进行备份！";
            // 
            // TV_editor
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 639);
            Controls.Add(label32);
            Controls.Add(label30);
            Controls.Add(tv_outbreak_group);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(save_but);
            Controls.Add(groupBox3);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "TV_editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "电视和大量出现编辑器";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)event_days).EndInit();
            ((System.ComponentModel.ISupportInitialize)event_slot).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)current_remaining).EndInit();
            ((System.ComponentModel.ISupportInitialize)current_appearance).EndInit();
            ((System.ComponentModel.ISupportInitialize)current_map).EndInit();
            ((System.ComponentModel.ISupportInitialize)current_level).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tv_id).EndInit();
            ((System.ComponentModel.ISupportInitialize)tv_mix_tid).EndInit();
            ((System.ComponentModel.ISupportInitialize)tv_tid).EndInit();
            ((System.ComponentModel.ISupportInitialize)tv_slot).EndInit();
            tv_outbreak_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)outbreak_activation).EndInit();
            ((System.ComponentModel.ISupportInitialize)outbreak_level).EndInit();
            ((System.ComponentModel.ISupportInitialize)outbreak_remaining).EndInit();
            ((System.ComponentModel.ISupportInitialize)outbreak_map).EndInit();
            ((System.ComponentModel.ISupportInitialize)outbreak_availability).EndInit();
            ResumeLayout(false);
        }
    }
}

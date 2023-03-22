using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class ME3_editor
    {
        private System.ComponentModel.IContainer components = null;
        private Button load_me3_but;

        private Button save_me3_but;

        private TextBox me3_path;

        private Button export_script_but;

        private Button import_script_but;

        private Label label1;

        private Label label2;

        private Label label3;

        private ComboBox itembox;

        private NumericUpDown amountbox;

        private NumericUpDown counterbox;

        private CheckBox custom_script;

        private Button removescript_but;

        private CheckBox script_check;

        private GroupBox groupBox1;

        private RadioButton radio_E;

        private RadioButton radio_RS;

        private NumericUpDown map_bank;

        private NumericUpDown map_num;

        private NumericUpDown map_npc;

        private Label label4;

        private Label label5;

        private Label label6;

        private GroupBox groupBox2;

        private Button help_npc;

        private Button counter_help;

        private Button amount_help;

        private Button item_help;

        private Button xse_help;

        private Button xse_import;

        private Button xse_export;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ME3_editor));
            load_me3_but = new Button();
            save_me3_but = new Button();
            me3_path = new TextBox();
            export_script_but = new Button();
            import_script_but = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            itembox = new ComboBox();
            amountbox = new NumericUpDown();
            counterbox = new NumericUpDown();
            custom_script = new CheckBox();
            script_check = new CheckBox();
            removescript_but = new Button();
            groupBox1 = new GroupBox();
            radio_E = new RadioButton();
            radio_RS = new RadioButton();
            map_bank = new NumericUpDown();
            map_num = new NumericUpDown();
            map_npc = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            help_npc = new Button();
            counter_help = new Button();
            amount_help = new Button();
            item_help = new Button();
            xse_help = new Button();
            xse_import = new Button();
            xse_export = new Button();
            ((System.ComponentModel.ISupportInitialize)amountbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counterbox).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)map_bank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)map_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)map_npc).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // load_me3_but
            // 
            load_me3_but.Location = new Point(16, 14);
            load_me3_but.Margin = new Padding(4, 4, 4, 4);
            load_me3_but.Name = "load_me3_but";
            load_me3_but.Size = new Size(100, 26);
            load_me3_but.TabIndex = 0;
            load_me3_but.Text = "读取神秘事件文件";
            load_me3_but.UseVisualStyleBackColor = true;
            load_me3_but.Click += Load_me3_butClick;
            // 
            // save_me3_but
            // 
            save_me3_but.Enabled = false;
            save_me3_but.Location = new Point(124, 14);
            save_me3_but.Margin = new Padding(4, 4, 4, 4);
            save_me3_but.Name = "save_me3_but";
            save_me3_but.Size = new Size(100, 26);
            save_me3_but.TabIndex = 1;
            save_me3_but.Text = "保存神秘事件文件";
            save_me3_but.UseVisualStyleBackColor = true;
            save_me3_but.Click += Save_me3_butClick;
            // 
            // me3_path
            // 
            me3_path.Location = new Point(16, 47);
            me3_path.Margin = new Padding(4, 4, 4, 4);
            me3_path.Name = "me3_path";
            me3_path.ReadOnly = true;
            me3_path.Size = new Size(411, 25);
            me3_path.TabIndex = 2;
            // 
            // export_script_but
            // 
            export_script_but.Enabled = false;
            export_script_but.Location = new Point(16, 246);
            export_script_but.Margin = new Padding(4, 4, 4, 4);
            export_script_but.Name = "export_script_but";
            export_script_but.Size = new Size(100, 26);
            export_script_but.TabIndex = 3;
            export_script_but.Text = "导出脚本";
            export_script_but.UseVisualStyleBackColor = true;
            export_script_but.Click += Export_script_butClick;
            // 
            // import_script_but
            // 
            import_script_but.Enabled = false;
            import_script_but.Location = new Point(124, 246);
            import_script_but.Margin = new Padding(4, 4, 4, 4);
            import_script_but.Name = "import_script_but";
            import_script_but.Size = new Size(100, 26);
            import_script_but.TabIndex = 4;
            import_script_but.Text = "导入脚本";
            import_script_but.UseVisualStyleBackColor = true;
            import_script_but.Click += Import_script_butClick;
            // 
            // label1
            // 
            label1.Location = new Point(35, 101);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 26);
            label1.TabIndex = 5;
            label1.Text = "道具";
            // 
            // label2
            // 
            label2.Location = new Point(35, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 26);
            label2.TabIndex = 6;
            label2.Text = "总数量";
            // 
            // label3
            // 
            label3.Location = new Point(35, 161);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 26);
            label3.TabIndex = 7;
            label3.Text = "可分享次数";
            // 
            // itembox
            // 
            itembox.FormattingEnabled = true;
            itembox.Items.AddRange(new object[] { "无", "大师球", "高级球", "超级球", "精灵球", "狩猎球", "捕网球", "潜水球", "巢穴球", "重复球", "计时球", "豪华球", "纪念球", "伤药", "解毒药", "灼伤药", "解冻药", "解眠药", "解麻药", "全复药", "全满药", "厉害伤药", "好伤药", "万灵药", "活力碎片", "活力块", "美味之水", "劲爽汽水", "果汁牛奶", "哞哞鲜奶", "元气粉", "元气根", "万能粉", "复活草", "ＰＰ单项小补剂", "ＰＰ单项全补剂", "ＰＰ多项小补剂", "ＰＰ多项全补剂", "釜炎仙贝", "蓝色玻璃哨", "黄色玻璃哨", "红色玻璃哨", "黑色玻璃哨", "白色玻璃哨", "树果汁", "圣灰", "浅滩海盐", "浅滩贝壳", "红色碎片", "蓝色碎片", "黄色碎片", "绿色碎片", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "ＨＰ增强剂", "攻击增强剂", "防御增强剂", "速度增强剂", "特攻增强剂", "神奇糖果", "ＰＰ提升剂", "特防增强剂", "ＰＰ极限提升剂", "未知", "能力防守", "要害攻击", "力量强化", "防御强化", "速度强化", "命中强化", "特攻强化", "皮皮玩偶", "向尾喵的尾巴", "未知", "白银喷雾", "黄金喷雾", "离洞绳", "除虫喷雾", "未知", "未知", "未知", "未知", "未知", "未知", "日之石", "月之石", "火之石", "雷之石", "水之石", "叶之石", "未知", "未知", "未知", "未知", "小蘑菇", "大蘑菇", "未知", "珍珠", "大珍珠", "星星沙子", "星星碎片", "金珠", "心之鳞片", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "橙色邮件", "港口邮件", "闪亮邮件", "机械邮件", "木纹邮件", "波涛邮件", "珠宝邮件", "影子邮件", "热带邮件", "梦境邮件", "奇迹邮件", "复古邮件", "樱子果", "零余果", "桃桃果", "莓莓果", "利木果", "苹野果", "橙橙果", "柿仔果", "木子果", "文柚果", "勿花果", "异奇果", "芒芒果", "乐芭果", "芭亚果", "蔓莓果", "墨莓果", "蕉香果", "西梨果", "凰梨果", "榴石果", "藻根果", "比巴果", "哈密果", "萄葡果", "茄番果", "玉黍果", "岳竹果", "茸丹果", "檬柠果", "刺角果", "椰木果", "瓜西果", "金枕果", "靛莓果", "枝荔果", "龙睛果", "沙鳞果", "龙火果", "杏仔果", "兰萨果", "星桃果", "谜芝果", "未知", "未知", "未知", "光粉", "白色香草", "强制锻炼器", "学习装置", "先制之爪", "安抚之铃", "心灵香草", "讲究头带", "王者之证", "银粉", "护符金币", "洁净之符", "心之水滴", "深海之牙", "深海鳞片", "烟雾球", "不变之石", "气势头带", "幸运蛋", "焦点镜", "金属膜", "吃剩的东西", "龙之鳞片", "电气球", "柔软沙子", "硬石头", "奇迹种子", "黑色眼镜", "黑带", "磁铁", "神秘水滴", "锐利鸟嘴", "毒针", "不融冰", "诅咒之符", "弯曲的汤匙", "木炭", "龙之牙", "丝绸围巾", "升级数据", "贝壳之铃", "海潮薰香", "悠闲薰香", "吉利拳", "金属粉", "粗骨头", "大葱", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "红色头巾", "蓝色头巾", "粉红头巾", "绿色头巾", "黄色头巾", "音速自行车", "代币盒", "探宝器", "破旧钓竿", "好钓竿", "厉害钓竿", "船票", "华丽大赛参加证", "未知", "吼吼鲸喷壶", "得文的物品", "集灰袋", "地下钥匙", "越野自行车", "宝可方块盒", "给大吾的信", "无限船票", "朱红色宝珠", "靛蓝色宝珠", "探测器", "ＧＯＧＯ护目镜", "陨石", "１号客房的钥匙", "２号客房的钥匙", "４号客房的钥匙", "６号客房的钥匙", "仓库钥匙", "根状化石", "爪子化石", "得文侦测镜", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "HM07", "HM08", "未知", "未知", "包裹* (仅绿宝石)", "宝可梦之笛* (仅绿宝石)", "秘密钥匙* (仅绿宝石)", "兑换券* (仅绿宝石)", "金假牙* (仅绿宝石)", "秘密琥珀* (仅绿宝石)", "钥匙卡* (仅绿宝石)", "电梯钥匙* (仅绿宝石)", "贝壳化石* (仅绿宝石)", "甲壳化石* (仅绿宝石)", "西尔佛检视镜* (仅绿宝石)", "自行车* (仅绿宝石)", "城镇地图* (仅绿宝石)", "对战搜寻器* (仅绿宝石)", "声音记录器* (仅绿宝石)", "招式学习器盒* (仅绿宝石)", "树果袋* (仅绿宝石)", "教学电视* (仅绿宝石)", "三岛通行证* (仅绿宝石)", "七岛通行证* (仅绿宝石)", "茶* (仅绿宝石)", "神秘船票* (仅绿宝石)", "极光船票* (仅绿宝石)", "粉末收集瓶* (仅绿宝石)", "红宝石* (仅绿宝石)", "蓝宝石* (仅绿宝石)", "熔岩标志* (仅绿宝石)", "古航海图* (仅绿宝石)" });
            itembox.Location = new Point(176, 98);
            itembox.Margin = new Padding(4, 4, 4, 4);
            itembox.Name = "itembox";
            itembox.Size = new Size(251, 23);
            itembox.TabIndex = 8;
            itembox.SelectedIndexChanged += ItemboxSelectedIndexChanged;
            // 
            // amountbox
            // 
            amountbox.Location = new Point(176, 129);
            amountbox.Margin = new Padding(4, 4, 4, 4);
            amountbox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            amountbox.Name = "amountbox";
            amountbox.Size = new Size(252, 25);
            amountbox.TabIndex = 9;
            // 
            // counterbox
            // 
            counterbox.Location = new Point(176, 159);
            counterbox.Margin = new Padding(4, 4, 4, 4);
            counterbox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            counterbox.Name = "counterbox";
            counterbox.Size = new Size(252, 25);
            counterbox.TabIndex = 10;
            counterbox.ValueChanged += CounterboxValueChanged;
            // 
            // custom_script
            // 
            custom_script.AutoCheck = false;
            custom_script.Location = new Point(272, 246);
            custom_script.Margin = new Padding(4, 4, 4, 4);
            custom_script.Name = "custom_script";
            custom_script.Size = new Size(139, 28);
            custom_script.TabIndex = 11;
            custom_script.Text = "自制脚本";
            custom_script.UseVisualStyleBackColor = true;
            // 
            // script_check
            // 
            script_check.AutoCheck = false;
            script_check.Location = new Point(272, 212);
            script_check.Margin = new Padding(4, 4, 4, 4);
            script_check.Name = "script_check";
            script_check.Size = new Size(139, 28);
            script_check.TabIndex = 12;
            script_check.Text = "脚本展示";
            script_check.UseVisualStyleBackColor = true;
            // 
            // removescript_but
            // 
            removescript_but.Enabled = false;
            removescript_but.Location = new Point(44, 212);
            removescript_but.Margin = new Padding(4, 4, 4, 4);
            removescript_but.Name = "removescript_but";
            removescript_but.Size = new Size(152, 26);
            removescript_but.TabIndex = 13;
            removescript_but.Text = "移除脚本";
            removescript_but.UseVisualStyleBackColor = true;
            removescript_but.Click += Removescript_butClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio_E);
            groupBox1.Controls.Add(radio_RS);
            groupBox1.Location = new Point(27, 313);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(169, 107);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "游戏版本";
            // 
            // radio_E
            // 
            radio_E.Location = new Point(8, 62);
            radio_E.Margin = new Padding(4, 4, 4, 4);
            radio_E.Name = "radio_E";
            radio_E.Size = new Size(139, 28);
            radio_E.TabIndex = 1;
            radio_E.TabStop = true;
            radio_E.Text = "绿宝石（仅日版）";
            radio_E.UseVisualStyleBackColor = true;
            // 
            // radio_RS
            // 
            radio_RS.Location = new Point(8, 28);
            radio_RS.Margin = new Padding(4, 4, 4, 4);
            radio_RS.Name = "radio_RS";
            radio_RS.Size = new Size(139, 28);
            radio_RS.TabIndex = 0;
            radio_RS.TabStop = true;
            radio_RS.Text = "红宝石/蓝宝石";
            radio_RS.UseVisualStyleBackColor = true;
            // 
            // map_bank
            // 
            map_bank.Location = new Point(109, 16);
            map_bank.Margin = new Padding(4, 4, 4, 4);
            map_bank.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            map_bank.Name = "map_bank";
            map_bank.Size = new Size(95, 25);
            map_bank.TabIndex = 15;
            // 
            // map_num
            // 
            map_num.Location = new Point(109, 46);
            map_num.Margin = new Padding(4, 4, 4, 4);
            map_num.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            map_num.Name = "map_num";
            map_num.Size = new Size(95, 25);
            map_num.TabIndex = 16;
            // 
            // map_npc
            // 
            map_npc.Location = new Point(109, 76);
            map_npc.Margin = new Padding(4, 4, 4, 4);
            map_npc.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            map_npc.Name = "map_npc";
            map_npc.Size = new Size(95, 25);
            map_npc.TabIndex = 17;
            // 
            // label4
            // 
            label4.Location = new Point(8, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 18;
            label4.Text = "Map Bank";
            // 
            // label5
            // 
            label5.Location = new Point(8, 49);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 26);
            label5.TabIndex = 19;
            label5.Text = "Map #";
            // 
            // label6
            // 
            label6.Location = new Point(8, 79);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 26);
            label6.TabIndex = 20;
            label6.Text = "Map NPC";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(map_bank);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(map_num);
            groupBox2.Controls.Add(map_npc);
            groupBox2.Location = new Point(207, 313);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(221, 107);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "脚本NPC";
            // 
            // help_npc
            // 
            help_npc.Location = new Point(436, 326);
            help_npc.Margin = new Padding(4, 4, 4, 4);
            help_npc.Name = "help_npc";
            help_npc.Size = new Size(23, 24);
            help_npc.TabIndex = 22;
            help_npc.Text = "?";
            help_npc.UseVisualStyleBackColor = true;
            help_npc.Click += Help_npcClick;
            // 
            // counter_help
            // 
            counter_help.Location = new Point(436, 157);
            counter_help.Margin = new Padding(4, 4, 4, 4);
            counter_help.Name = "counter_help";
            counter_help.Size = new Size(23, 24);
            counter_help.TabIndex = 23;
            counter_help.Text = "?";
            counter_help.UseVisualStyleBackColor = true;
            counter_help.Click += Counter_helpClick;
            // 
            // amount_help
            // 
            amount_help.Location = new Point(436, 127);
            amount_help.Margin = new Padding(4, 4, 4, 4);
            amount_help.Name = "amount_help";
            amount_help.Size = new Size(23, 24);
            amount_help.TabIndex = 24;
            amount_help.Text = "?";
            amount_help.UseVisualStyleBackColor = true;
            amount_help.Click += Amount_helpClick;
            // 
            // item_help
            // 
            item_help.Location = new Point(436, 97);
            item_help.Margin = new Padding(4, 4, 4, 4);
            item_help.Name = "item_help";
            item_help.Size = new Size(23, 24);
            item_help.TabIndex = 25;
            item_help.Text = "?";
            item_help.UseVisualStyleBackColor = true;
            item_help.Click += Item_helpClick;
            // 
            // xse_help
            // 
            xse_help.Location = new Point(232, 281);
            xse_help.Margin = new Padding(4, 4, 4, 4);
            xse_help.Name = "xse_help";
            xse_help.Size = new Size(28, 26);
            xse_help.TabIndex = 35;
            xse_help.Text = "?";
            xse_help.UseVisualStyleBackColor = true;
            xse_help.Click += Xse_helpClick;
            // 
            // xse_import
            // 
            xse_import.Location = new Point(124, 279);
            xse_import.Margin = new Padding(4, 4, 4, 4);
            xse_import.Name = "xse_import";
            xse_import.Size = new Size(100, 26);
            xse_import.TabIndex = 37;
            xse_import.Text = "XSE导入";
            xse_import.UseVisualStyleBackColor = true;
            xse_import.Click += Xse_importClick;
            // 
            // xse_export
            // 
            xse_export.Location = new Point(16, 279);
            xse_export.Margin = new Padding(4, 4, 4, 4);
            xse_export.Name = "xse_export";
            xse_export.Size = new Size(100, 26);
            xse_export.TabIndex = 36;
            xse_export.Text = "XSE导出";
            xse_export.UseVisualStyleBackColor = true;
            xse_export.Click += Xse_exportClick;
            // 
            // ME3_editor
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 428);
            Controls.Add(xse_help);
            Controls.Add(xse_import);
            Controls.Add(xse_export);
            Controls.Add(item_help);
            Controls.Add(amount_help);
            Controls.Add(counter_help);
            Controls.Add(help_npc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(removescript_but);
            Controls.Add(script_check);
            Controls.Add(custom_script);
            Controls.Add(counterbox);
            Controls.Add(amountbox);
            Controls.Add(itembox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(import_script_but);
            Controls.Add(export_script_but);
            Controls.Add(me3_path);
            Controls.Add(save_me3_but);
            Controls.Add(load_me3_but);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "ME3_editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "神秘事件编辑器";
            DragDrop += ME3_editorDragDrop;
            DragEnter += ME3_editorDragEnter;
            ((System.ComponentModel.ISupportInitialize)amountbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)counterbox).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)map_bank).EndInit();
            ((System.ComponentModel.ISupportInitialize)map_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)map_npc).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 03/03/2016
 * Time: 19:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
    partial class Medals
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown day;
        private System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox indexbox;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button saveexit_but;
        private System.Windows.Forms.CheckBox flag1box;
        private System.Windows.Forms.CheckBox flag2box;
        private System.Windows.Forms.CheckBox flag3box;
        private System.Windows.Forms.CheckBox flag4box;
        private System.Windows.Forms.DateTimePicker medal_date;
        private System.Windows.Forms.CheckBox obtained;
        private System.Windows.Forms.Panel red_panel;
        private System.Windows.Forms.Button delete_but;
        private System.Windows.Forms.TextBox date_hex;
        private System.Windows.Forms.TextBox flag_hex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medals));
            day = new NumericUpDown();
            month = new NumericUpDown();
            year = new NumericUpDown();
            indexbox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            flag1box = new CheckBox();
            flag2box = new CheckBox();
            flag3box = new CheckBox();
            flag4box = new CheckBox();
            medal_date = new DateTimePicker();
            obtained = new CheckBox();
            red_panel = new Panel();
            delete_but = new Button();
            date_hex = new TextBox();
            flag_hex = new TextBox();
            label4 = new Label();
            label5 = new Label();
            exit_but = new Button();
            saveexit_but = new Button();
            ((System.ComponentModel.ISupportInitialize)day).BeginInit();
            ((System.ComponentModel.ISupportInitialize)month).BeginInit();
            ((System.ComponentModel.ISupportInitialize)year).BeginInit();
            SuspendLayout();
            // 
            // day
            // 
            day.Location = new Point(65, 45);
            day.Margin = new Padding(4);
            day.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            day.Name = "day";
            day.Size = new Size(61, 25);
            day.TabIndex = 0;
            day.ValueChanged += DayValueChanged;
            // 
            // month
            // 
            month.Location = new Point(187, 45);
            month.Margin = new Padding(4);
            month.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            month.Name = "month";
            month.Size = new Size(61, 25);
            month.TabIndex = 1;
            month.ValueChanged += MonthValueChanged;
            // 
            // year
            // 
            year.Location = new Point(305, 45);
            year.Margin = new Padding(4);
            year.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            year.Name = "year";
            year.Size = new Size(61, 25);
            year.TabIndex = 2;
            year.ValueChanged += YearValueChanged;
            // 
            // indexbox
            // 
            indexbox.FormattingEnabled = true;
            indexbox.Items.AddRange(new object[] { " ======= 特别奖牌 =======", "000 - 开始的一步", "001 - 目标奖励", "002 - 新秀奖牌得主", "003 - 精英奖牌得主", "004 - 大师奖牌得主", "005 - 传说奖牌得主", "006 - 王牌奖牌得主", "======= 冒险奖牌 =======", "007 - 轻级跑者", "008 - 中级跑者", "009 - 重级跑者", "010 - 名誉的足迹", "011 - 简短纪录者", "012 - 匆忙纪录者", "013 - 流畅纪录者", "014 - 奇迹笔尖", "015 - 宝可梦中心粉丝", "016 - 公告牌入门", "017 - 公告牌专家", "018 - 涂鸦千里眼", "019 - 初始骑行旅", "020 - 简单骑行旅", "021 - 困难骑行旅", "022 - 奔驰的传说", "023 - 破旧钓竿垂钓者", "024 - 好钓竿垂钓者", "025 - 厉害钓竿垂钓者", "026 - 妙手渔夫", "027 - 一般收集者", "028 - 火收集者", "029 - 水收集者", "030 - 电收集者", "031 - 草收集者", "032 - 冰收集者", "033 - 格斗收集者", "034 - 毒收集者", "035 - 地面收集者", "036 - 飞行收集者", "037 - 超能力收集者", "038 - 虫收集者", "039 - 岩石收集者", "040 - 幽灵收集者", "041 - 龙收集者", "042 - 恶收集者", "043 - 钢收集者", "044 - 合众收集者", "045 - 全国收集者", "046 - 装箱30", "047 - 装箱120", "048 - 装箱360", "049 - 箱子极限", "050 - 收服之王", "051 - 贩卖机大师", "052 - 再来一瓶", "053 - 进化希望", "054 - 进化技术高手", "055 - 进化专家", "056 - 行走的进化论", "057 - 王牌飞行员", "058 - 活化肌肉", "059 - 搜寻达人", "060 - 失物搜寻者", "061 - 失物猎人", "062 - 失物收集者", "063 - 探测之王", "064 - 起名之王", "065 - 电视小孩", "066 - 常客", "067 - 奢侈入门", "068 - 奢侈大户", "069 - 奢侈贵宾", "070 - 超级百万富翁", "071 - 购物能手", "072 - 甜蜜的家", "073 - 初次交错", "074 - 交错30", "075 - 交错100", "076 - 高峰时刻", "077 - 释出之力+", "078 - 释出之力++", "079 - 释出之力+++", "080 - 释出之力MAX", "081 - 迷糊收服者", "082 - 安眠收服者", "083 - 酣然收服者", "084 - 梦中相会", "085 - 隐藏洞穴达人", "086 - 孵蛋初学者", "087 - 孵蛋饲养员", "088 - 孵蛋运动员", "089 - 生命的奥秘", "090 - 培育屋狂", "091 - 古代浪漫家", "092 - 纯真无邪", "093 - 幸运色", "094 - 宝可病毒猎人", "095 - 飞云番长", "096 - 铁路狂", "097 - 吼鲸王观察者", "098 - 露面纪念", "099 - 重机狂", "100 - 遗迹大师", "101 - 冰晶", "102 - 桥梁狂", "103 - 环游合众", "104 - 冒险之王", "======= 对战奖牌 =======", "105 - 对战门生", "106 - 对战教练", "107 - 对战师傅", "108 - 历战的猛者", "109 - 对决新生", "110 - 对决先驱者", "111 - 对决专家", "112 - 为对战而生", "113 - 鲤鱼王奖", "114 - 永不言弃", "115 - 空打名人", "116 - 绝佳达人", "117 - 对战空档", "118 - 对战油门", "119 - 对战高速档", "120 - 失控特快车", "121 - 单人快车", "122 - 双人快车", "123 - 多人快车", "124 - 检定初学者", "125 - 检定粉丝", "126 - 检定狂", "127 - 热身大师", "128 - EXP百万富翁", "129 - ＢＰ百万富翁", "130 - 探索猎人", "131 - 对战重复者", "132 - 夕阳巡航", "133 - 帆巴最强", "134 - 租借之王", "135 - 混合之王", "136 - 合众最强", "137 - 关都最强", "138 - 城都最强", "139 - 丰缘最强", "140 - 神奥最强", "141 - 馆主最强", "142 - 世界最强", "143 - 租借之帝", "144 - 混合之帝", "145 - 全属性之王", "146 - 摩天楼过半", "147 - 摩天楼大师", "148 - 树洞过半", "149 - 树洞大师", "150 - 20人斩", "151 - 50人斩", "152 - 100人斩", "153 - 千人胜者", "154 - 全破简单", "155 - 全破大师", "156 - 狙击简单", "157 - 狙击大师", "158 - 速攻简单", "159 - 速攻大师", "160 - 对战将军", "======= 娱乐奖牌 =======", "161 - 最初交换", "162 - 慌张交换", "163 - 精明交换", "164 - 稻草富翁", "165 - 反转交换", "166 - 好朋友", "167 - 舞台天才", "168 - 出道明星", "169 - 中坚明星", "170 - 资深明星", "171 - 音乐剧首席", "172 - 时尚番长", "173 - 10个追随者", "174 - 朋友入门", "175 - 朋友广阔", "176 - 朋友拓展", "177 - 世界链接", "178 - 转蛋大师", "179 - 感情大师", "180 - 心之王牌", "181 - 约会达人", "182 - 引导新人", "183 - 引导精英", "184 - 引导老手", "185 - 引路之王", "186 - 店铺制造者", "187 - 店铺建造者", "188 - 店铺创造者", "189 - 商店之王", "190 - 便宜礼物", "191 - 昂贵礼物", "192 - 豪华礼物", "193 - 纪念品之王", "194 - 我的梦想大道", "195 - 小游戏爱好者", "196 - 小游戏狂", "197 - 小游戏名人", "198 - 最佳小游戏玩家", "199 - 气球新人", "200 - 气球技术高手", "201 - 气球行家", "202 - 气球之王", "203 - 新人英雄", "204 - 明星英雄", "205 - 警察电影大师", "206 - UFO电影大师", "207 - 怪兽专家", "208 - 科幻电影专家", "209 - 浪漫明星", "210 - 幻想大师", "211 - 喜剧明星", "212 - 惊悚明星", "213 - 机器人电影专家", "214 - 鬼怪电影大师", "215 - 英雄大团圆", "216 - 当红电影之星", "217 - 电影大卖", "218 - 名作电影之星", "219 - 最初的邪典", "220 - 邪典电影之星", "221 - 10人庆典", "222 - 30人庆典", "223 - 得分破百", "224 - 得分破千", "225 - 举办Lv1", "226 - 举办Lv2", "227 - 参加Lv1", "228 - 参加Lv2", "229 - 达成Lv1", "230 - 达成Lv2", "231 - 庆典完成", "232 - 晚安", "233 - 回忆的开始", "234 - 全部的回忆", "235 - 娱乐大师", "======= 挑战奖牌 =======", "236 - 一般冠军", "237 - 火冠军", "238 - 水冠军", "239 - 电冠军", "240 - 草冠军", "241 - 冰冠军", "242 - 格斗冠军", "243 - 毒冠军", "244 - 地面冠军", "245 - 飞行冠军", "246 - 超能力冠军", "247 - 虫冠军", "248 - 岩石冠军", "249 - 幽灵冠军", "250 - 龙冠军", "251 - 恶冠军", "252 - 钢冠军", "253 - 唯我独尊", "254 - 挑战天才" });
            indexbox.Location = new Point(16, 14);
            indexbox.Margin = new Padding(4);
            indexbox.MaxDropDownItems = 10;
            indexbox.Name = "indexbox";
            indexbox.Size = new Size(349, 23);
            indexbox.TabIndex = 4;
            indexbox.SelectedIndexChanged += ComboBox1SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(16, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 22);
            label1.TabIndex = 5;
            label1.Text = "日";
            // 
            // label2
            // 
            label2.Location = new Point(135, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 26);
            label2.TabIndex = 6;
            label2.Text = "月";
            // 
            // label3
            // 
            label3.Location = new Point(256, 47);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 26);
            label3.TabIndex = 7;
            label3.Text = "年";
            // 
            // flag1box
            // 
            flag1box.Location = new Point(16, 84);
            flag1box.Margin = new Padding(4);
            flag1box.Name = "flag1box";
            flag1box.Size = new Size(139, 28);
            flag1box.TabIndex = 10;
            flag1box.Text = "旗标1";
            flag1box.UseVisualStyleBackColor = true;
            flag1box.CheckedChanged += Flag1boxCheckedChanged;
            // 
            // flag2box
            // 
            flag2box.Location = new Point(109, 84);
            flag2box.Margin = new Padding(4);
            flag2box.Name = "flag2box";
            flag2box.Size = new Size(139, 28);
            flag2box.TabIndex = 11;
            flag2box.Text = "旗标2";
            flag2box.UseVisualStyleBackColor = true;
            flag2box.CheckedChanged += Flag2boxCheckedChanged;
            // 
            // flag3box
            // 
            flag3box.Location = new Point(16, 124);
            flag3box.Margin = new Padding(4);
            flag3box.Name = "flag3box";
            flag3box.Size = new Size(139, 28);
            flag3box.TabIndex = 12;
            flag3box.Text = "旗标3";
            flag3box.UseVisualStyleBackColor = true;
            flag3box.CheckedChanged += Flag3boxCheckedChanged;
            // 
            // flag4box
            // 
            flag4box.Location = new Point(109, 124);
            flag4box.Margin = new Padding(4);
            flag4box.Name = "flag4box";
            flag4box.Size = new Size(139, 28);
            flag4box.TabIndex = 13;
            flag4box.Text = "旗标4";
            flag4box.UseVisualStyleBackColor = true;
            flag4box.CheckedChanged += Flag4boxCheckedChanged;
            // 
            // medal_date
            // 
            medal_date.Location = new Point(16, 45);
            medal_date.Margin = new Padding(4);
            medal_date.Name = "medal_date";
            medal_date.RightToLeft = RightToLeft.No;
            medal_date.Size = new Size(349, 25);
            medal_date.TabIndex = 14;
            medal_date.ValueChanged += Medal_dateValueChanged;
            // 
            // obtained
            // 
            obtained.AutoCheck = false;
            obtained.Location = new Point(16, 171);
            obtained.Margin = new Padding(4);
            obtained.Name = "obtained";
            obtained.Size = new Size(147, 26);
            obtained.TabIndex = 15;
            obtained.Text = "已获得";
            obtained.UseVisualStyleBackColor = true;
            // 
            // red_panel
            // 
            red_panel.Location = new Point(16, 46);
            red_panel.Margin = new Padding(4);
            red_panel.Name = "red_panel";
            red_panel.Size = new Size(309, 21);
            red_panel.TabIndex = 16;
            // 
            // delete_but
            // 
            delete_but.Location = new Point(16, 204);
            delete_but.Margin = new Padding(4);
            delete_but.Name = "delete_but";
            delete_but.Size = new Size(111, 40);
            delete_but.TabIndex = 17;
            delete_but.Text = "删除奖牌";
            delete_but.UseVisualStyleBackColor = true;
            delete_but.Click += Delete_butClick;
            // 
            // date_hex
            // 
            date_hex.Location = new Point(281, 84);
            date_hex.Margin = new Padding(4);
            date_hex.Name = "date_hex";
            date_hex.Size = new Size(84, 25);
            date_hex.TabIndex = 18;
            // 
            // flag_hex
            // 
            flag_hex.Location = new Point(281, 122);
            flag_hex.Margin = new Padding(4);
            flag_hex.Name = "flag_hex";
            flag_hex.Size = new Size(84, 25);
            flag_hex.TabIndex = 19;
            // 
            // label4
            // 
            label4.Location = new Point(187, 75);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 45);
            label4.TabIndex = 20;
            label4.Text = "数据\r\n(十六进制):";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(188, 115);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 46);
            label5.TabIndex = 21;
            label5.Text = "旗标\r\n(十六进制):";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exit_but
            // 
            exit_but.Location = new Point(237, 212);
            exit_but.Margin = new Padding(4);
            exit_but.Name = "exit_but";
            exit_but.Size = new Size(129, 32);
            exit_but.TabIndex = 8;
            exit_but.Text = "退出";
            exit_but.UseVisualStyleBackColor = true;
            exit_but.Click += Exit_butClick;
            // 
            // saveexit_but
            // 
            saveexit_but.Location = new Point(237, 250);
            saveexit_but.Margin = new Padding(4);
            saveexit_but.Name = "saveexit_but";
            saveexit_but.Size = new Size(132, 34);
            saveexit_but.TabIndex = 9;
            saveexit_but.Text = "保存并退出";
            saveexit_but.UseVisualStyleBackColor = true;
            saveexit_but.Click += Saveexit_butClick;
            // 
            // Medals
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 298);
            Controls.Add(flag_hex);
            Controls.Add(date_hex);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(delete_but);
            Controls.Add(red_panel);
            Controls.Add(obtained);
            Controls.Add(medal_date);
            Controls.Add(flag4box);
            Controls.Add(flag3box);
            Controls.Add(flag2box);
            Controls.Add(flag1box);
            Controls.Add(saveexit_but);
            Controls.Add(exit_but);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(indexbox);
            Controls.Add(year);
            Controls.Add(month);
            Controls.Add(day);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Medals";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "奖牌";
            ((System.ComponentModel.ISupportInitialize)day).EndInit();
            ((System.ComponentModel.ISupportInitialize)month).EndInit();
            ((System.ComponentModel.ISupportInitialize)year).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

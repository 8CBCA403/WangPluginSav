using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class ECT_pkedit
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;

        private ComboBox item_box;

        private Label label2;

        private Label label3;

        private Label label4;

        private ComboBox move1;

        private ComboBox move2;

        private ComboBox move3;

        private Label label5;

        private NumericUpDown level;

        private NumericUpDown pp1;

        private NumericUpDown pp2;

        private NumericUpDown pp3;

        private Label label6;

        private Label label7;

        private Label label8;

        private NumericUpDown otid;

        private NumericUpDown otsid;

        private NumericUpDown pid;

        private Label label9;

        private NumericUpDown ability;

        private Label label10;

        private Label label11;

        private NumericUpDown friendship;

        private TextBox namebox;

        private Label label12;

        private Label label13;

        private NumericUpDown iv1;

        private NumericUpDown iv2;

        private NumericUpDown iv3;

        private NumericUpDown iv4;

        private NumericUpDown iv5;

        private NumericUpDown iv6;

        private NumericUpDown ev5;

        private NumericUpDown ev4;

        private NumericUpDown ev3;

        private NumericUpDown ev2;

        private NumericUpDown ev1;

        private Label label14;

        private Label label15;

        private Label label16;

        private Label label17;

        private Label label18;

        private Label label19;

        private Label label20;

        private Button save;

        private Button cancel;

        private Label label21;

        private ComboBox move4;

        private NumericUpDown pp4;

        private NumericUpDown ev6;

        private CheckBox jap_check;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECT_pkedit));
            label1 = new Label();
            item_box = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            move1 = new ComboBox();
            move2 = new ComboBox();
            move3 = new ComboBox();
            label5 = new Label();
            level = new NumericUpDown();
            pp1 = new NumericUpDown();
            pp2 = new NumericUpDown();
            pp3 = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            otid = new NumericUpDown();
            otsid = new NumericUpDown();
            pid = new NumericUpDown();
            label9 = new Label();
            ability = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            friendship = new NumericUpDown();
            namebox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            iv1 = new NumericUpDown();
            iv2 = new NumericUpDown();
            iv3 = new NumericUpDown();
            iv4 = new NumericUpDown();
            iv5 = new NumericUpDown();
            iv6 = new NumericUpDown();
            ev6 = new NumericUpDown();
            ev5 = new NumericUpDown();
            ev4 = new NumericUpDown();
            ev3 = new NumericUpDown();
            ev2 = new NumericUpDown();
            ev1 = new NumericUpDown();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            save = new Button();
            cancel = new Button();
            label21 = new Label();
            move4 = new ComboBox();
            pp4 = new NumericUpDown();
            jap_check = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pp1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pp2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pp3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)otid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)otsid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ability).BeginInit();
            ((System.ComponentModel.ISupportInitialize)friendship).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iv2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iv3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iv4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iv5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iv6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ev6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ev5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ev4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ev3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ev2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ev1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pp4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(39, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "持有物：";
            // 
            // item_box
            // 
            item_box.FormattingEnabled = true;
            item_box.Items.AddRange(new object[] { "无", "大师球", "高级球", "超级球", "精灵球", "狩猎球", "捕网球", "潜水球", "巢穴球", "重复球", "计时球", "豪华球", "纪念球", "伤药", "解毒药", "灼伤药", "解冻药", "解眠药", "解麻药", "全复药", "全满药", "厉害伤药", "好伤药", "万灵药", "活力碎片", "活力块", "美味之水", "劲爽汽水", "果汁牛奶", "哞哞鲜奶", "元气粉", "元气根", "万能粉", "复活草", "ＰＰ单项小补剂", "ＰＰ单项全补剂", "ＰＰ多项小补剂", "ＰＰ多项全补剂", "釜炎仙贝", "蓝色玻璃哨", "黄色玻璃哨", "红色玻璃哨", "黑色玻璃哨", "白色玻璃哨", "树果汁", "圣灰", "浅滩海盐", "浅滩贝壳", "红色碎片", "蓝色碎片", "黄色碎片", "绿色碎片", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "ＨＰ增强剂", "攻击增强剂", "防御增强剂", "速度增强剂", "特攻增强剂", "神奇糖果", "ＰＰ提升剂", "特防增强剂", "ＰＰ极限提升剂", "未知", "能力防守", "要害攻击", "力量强化", "防御强化", "速度强化", "命中强化", "特攻强化", "皮皮玩偶", "向尾喵的尾巴", "未知", "白银喷雾", "黄金喷雾", "离洞绳", "除虫喷雾", "未知", "未知", "未知", "未知", "未知", "未知", "日之石", "月之石", "火之石", "雷之石", "水之石", "叶之石", "未知", "未知", "未知", "未知", "小蘑菇", "大蘑菇", "未知", "珍珠", "大珍珠", "星星沙子", "星星碎片", "金珠", "心之鳞片", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "橙色邮件", "港口邮件", "闪亮邮件", "机械邮件", "木纹邮件", "波涛邮件", "珠宝邮件", "影子邮件", "热带邮件", "梦境邮件", "奇迹邮件", "复古邮件", "樱子果", "零余果", "桃桃果", "莓莓果", "利木果", "苹野果", "橙橙果", "柿仔果", "木子果", "文柚果", "勿花果", "异奇果", "芒芒果", "乐芭果", "芭亚果", "蔓莓果", "墨莓果", "蕉香果", "西梨果", "凰梨果", "榴石果", "藻根果", "比巴果", "哈密果", "萄葡果", "茄番果", "玉黍果", "岳竹果", "茸丹果", "檬柠果", "刺角果", "椰木果", "瓜西果", "金枕果", "靛莓果", "枝荔果", "龙睛果", "沙鳞果", "龙火果", "杏仔果", "兰萨果", "星桃果", "谜芝果", "未知", "未知", "未知", "光粉", "白色香草", "强制锻炼器", "学习装置", "先制之爪", "安抚之铃", "心灵香草", "讲究头带", "王者之证", "银粉", "护符金币", "洁净之符", "心之水滴", "深海之牙", "深海鳞片", "烟雾球", "不变之石", "气势头带", "幸运蛋", "焦点镜", "金属膜", "吃剩的东西", "龙之鳞片", "电气球", "柔软沙子", "硬石头", "奇迹种子", "黑色眼镜", "黑带", "磁铁", "神秘水滴", "锐利鸟嘴", "毒针", "不融冰", "诅咒之符", "弯曲的汤匙", "木炭", "龙之牙", "丝绸围巾", "升级数据", "贝壳之铃", "海潮薰香", "悠闲薰香", "吉利拳", "金属粉", "粗骨头", "大葱", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "未知", "红色头巾", "蓝色头巾", "粉红头巾", "绿色头巾", "黄色头巾", "音速自行车", "代币盒", "探宝器", "破旧钓竿", "好钓竿", "厉害钓竿", "船票", "华丽大赛参加证", "未知", "吼吼鲸喷壶", "得文的物品", "集灰袋", "地下钥匙", "越野自行车", "宝可方块盒", "给大吾的信", "无限船票", "朱红色宝珠", "靛蓝色宝珠", "探测器", "ＧＯＧＯ护目镜", "陨石", "１号客房的钥匙", "２号客房的钥匙", "４号客房的钥匙", "６号客房的钥匙", "仓库钥匙", "根状化石", "爪子化石", "得文侦测镜", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "HM07", "HM08", "未知", "未知", "包裹* (仅火红叶绿)", "宝可梦之笛* (仅火红叶绿)", "秘密钥匙* (仅火红叶绿)", "兑换券* (仅火红叶绿)", "金假牙* (仅火红叶绿)", "秘密琥珀* (仅火红叶绿)", "钥匙卡* (仅火红叶绿)", "电梯钥匙* (仅火红叶绿)", "贝壳化石* (仅火红叶绿)", "甲壳化石* (仅火红叶绿)", "西尔佛检视镜* (仅火红叶绿)", "自行车* (仅火红叶绿)", "城镇地图* (仅火红叶绿)", "对战搜寻器* (仅火红叶绿)", "声音记录器* (仅火红叶绿)", "招式学习器盒* (仅火红叶绿)", "树果袋* (仅火红叶绿)", "教学电视* (仅火红叶绿)", "三岛通行证* (仅火红叶绿)", "七岛通行证* (仅火红叶绿)", "茶* (仅火红叶绿)", "神秘船票* (仅火红叶绿)", "极光船票* (仅火红叶绿)", "粉末收集瓶* (仅火红叶绿)", "红宝石* (仅火红叶绿)", "蓝宝石* (仅火红叶绿)", "熔岩标志* (仅绿宝石)", "古航海图* (仅绿宝石)" });
            item_box.Location = new Point(128, 71);
            item_box.Margin = new Padding(4);
            item_box.Name = "item_box";
            item_box.Size = new Size(217, 23);
            item_box.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(39, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 26);
            label2.TabIndex = 2;
            label2.Text = "招式1：";
            // 
            // label3
            // 
            label3.Location = new Point(39, 161);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 26);
            label3.TabIndex = 3;
            label3.Text = "招式2：";
            // 
            // label4
            // 
            label4.Location = new Point(39, 190);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 26);
            label4.TabIndex = 4;
            label4.Text = "招式3：";
            // 
            // move1
            // 
            move1.FormattingEnabled = true;
            move1.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            move1.Location = new Point(128, 127);
            move1.Margin = new Padding(4);
            move1.Name = "move1";
            move1.Size = new Size(217, 23);
            move1.TabIndex = 5;
            // 
            // move2
            // 
            move2.FormattingEnabled = true;
            move2.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进", "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            move2.Location = new Point(128, 158);
            move2.Margin = new Padding(4);
            move2.Name = "move2";
            move2.Size = new Size(217, 23);
            move2.TabIndex = 6;
            // 
            // move3
            // 
            move3.FormattingEnabled = true;
            move3.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进", "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            move3.Location = new Point(128, 187);
            move3.Margin = new Padding(4);
            move3.Name = "move3";
            move3.Size = new Size(217, 23);
            move3.TabIndex = 7;
            // 
            // label5
            // 
            label5.Location = new Point(721, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 26);
            label5.TabIndex = 8;
            label5.Text = "等级：";
            // 
            // level
            // 
            level.Location = new Point(777, 26);
            level.Margin = new Padding(4);
            level.Name = "level";
            level.Size = new Size(160, 25);
            level.TabIndex = 9;
            // 
            // pp1
            // 
            pp1.Location = new Point(355, 128);
            pp1.Margin = new Padding(4);
            pp1.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            pp1.Name = "pp1";
            pp1.Size = new Size(49, 25);
            pp1.TabIndex = 10;
            // 
            // pp2
            // 
            pp2.Location = new Point(355, 159);
            pp2.Margin = new Padding(4);
            pp2.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            pp2.Name = "pp2";
            pp2.Size = new Size(49, 25);
            pp2.TabIndex = 11;
            // 
            // pp3
            // 
            pp3.Location = new Point(355, 188);
            pp3.Margin = new Padding(4);
            pp3.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            pp3.Name = "pp3";
            pp3.Size = new Size(49, 25);
            pp3.TabIndex = 12;
            // 
            // label6
            // 
            label6.Location = new Point(355, 110);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 13;
            label6.Text = "PP提升";
            // 
            // label7
            // 
            label7.Location = new Point(672, 130);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(155, 14);
            label7.TabIndex = 14;
            label7.Text = "初训家TID：";
            // 
            // label8
            // 
            label8.Location = new Point(672, 156);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 15;
            label8.Text = "初训家SID：";
            // 
            // otid
            // 
            otid.Location = new Point(777, 127);
            otid.Margin = new Padding(4);
            otid.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            otid.Name = "otid";
            otid.Size = new Size(160, 25);
            otid.TabIndex = 16;
            // 
            // otsid
            // 
            otsid.Location = new Point(777, 158);
            otsid.Margin = new Padding(4);
            otsid.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            otsid.Name = "otsid";
            otsid.Size = new Size(160, 25);
            otsid.TabIndex = 17;
            // 
            // pid
            // 
            pid.Location = new Point(777, 187);
            pid.Margin = new Padding(4);
            pid.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            pid.Name = "pid";
            pid.Size = new Size(160, 25);
            pid.TabIndex = 18;
            // 
            // label9
            // 
            label9.Location = new Point(672, 187);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 26);
            label9.TabIndex = 19;
            label9.Text = "性格值PID：";
            // 
            // ability
            // 
            ability.Location = new Point(777, 86);
            ability.Margin = new Padding(4);
            ability.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            ability.Name = "ability";
            ability.Size = new Size(160, 25);
            ability.TabIndex = 20;
            // 
            // label10
            // 
            label10.Location = new Point(699, 88);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 26);
            label10.TabIndex = 21;
            label10.Text = "特性位：";
            // 
            // label11
            // 
            label11.Location = new Point(699, 58);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(81, 26);
            label11.TabIndex = 22;
            label11.Text = "亲密度：";
            // 
            // friendship
            // 
            friendship.Location = new Point(777, 56);
            friendship.Margin = new Padding(4);
            friendship.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            friendship.Name = "friendship";
            friendship.Size = new Size(160, 25);
            friendship.TabIndex = 23;
            // 
            // namebox
            // 
            namebox.Location = new Point(128, 41);
            namebox.Margin = new Padding(4);
            namebox.MaxLength = 10;
            namebox.Name = "namebox";
            namebox.Size = new Size(287, 25);
            namebox.TabIndex = 24;
            // 
            // label12
            // 
            label12.Location = new Point(39, 45);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(57, 16);
            label12.TabIndex = 25;
            label12.Text = "名字：";
            // 
            // label13
            // 
            label13.Location = new Point(446, 37);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(37, 26);
            label13.TabIndex = 26;
            label13.Text = "HP";
            // 
            // iv1
            // 
            iv1.Location = new Point(520, 38);
            iv1.Margin = new Padding(4);
            iv1.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            iv1.Name = "iv1";
            iv1.Size = new Size(68, 25);
            iv1.TabIndex = 28;
            // 
            // iv2
            // 
            iv2.Location = new Point(520, 68);
            iv2.Margin = new Padding(4);
            iv2.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            iv2.Name = "iv2";
            iv2.Size = new Size(68, 25);
            iv2.TabIndex = 29;
            // 
            // iv3
            // 
            iv3.Location = new Point(520, 98);
            iv3.Margin = new Padding(4);
            iv3.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            iv3.Name = "iv3";
            iv3.Size = new Size(68, 25);
            iv3.TabIndex = 30;
            // 
            // iv4
            // 
            iv4.Location = new Point(520, 128);
            iv4.Margin = new Padding(4);
            iv4.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            iv4.Name = "iv4";
            iv4.Size = new Size(68, 25);
            iv4.TabIndex = 31;
            // 
            // iv5
            // 
            iv5.Location = new Point(520, 158);
            iv5.Margin = new Padding(4);
            iv5.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            iv5.Name = "iv5";
            iv5.Size = new Size(68, 25);
            iv5.TabIndex = 32;
            // 
            // iv6
            // 
            iv6.Location = new Point(520, 188);
            iv6.Margin = new Padding(4);
            iv6.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            iv6.Name = "iv6";
            iv6.Size = new Size(68, 25);
            iv6.TabIndex = 33;
            // 
            // ev6
            // 
            ev6.Location = new Point(596, 188);
            ev6.Margin = new Padding(4);
            ev6.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ev6.Name = "ev6";
            ev6.Size = new Size(68, 25);
            ev6.TabIndex = 40;
            // 
            // ev5
            // 
            ev5.Location = new Point(596, 158);
            ev5.Margin = new Padding(4);
            ev5.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ev5.Name = "ev5";
            ev5.Size = new Size(68, 25);
            ev5.TabIndex = 39;
            // 
            // ev4
            // 
            ev4.Location = new Point(596, 128);
            ev4.Margin = new Padding(4);
            ev4.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ev4.Name = "ev4";
            ev4.Size = new Size(68, 25);
            ev4.TabIndex = 38;
            // 
            // ev3
            // 
            ev3.Location = new Point(596, 98);
            ev3.Margin = new Padding(4);
            ev3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ev3.Name = "ev3";
            ev3.Size = new Size(68, 25);
            ev3.TabIndex = 37;
            // 
            // ev2
            // 
            ev2.Location = new Point(596, 68);
            ev2.Margin = new Padding(4);
            ev2.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ev2.Name = "ev2";
            ev2.Size = new Size(68, 25);
            ev2.TabIndex = 36;
            // 
            // ev1
            // 
            ev1.Location = new Point(596, 38);
            ev1.Margin = new Padding(4);
            ev1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ev1.Name = "ev1";
            ev1.Size = new Size(68, 25);
            ev1.TabIndex = 35;
            // 
            // label14
            // 
            label14.Location = new Point(446, 68);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(43, 26);
            label14.TabIndex = 41;
            label14.Text = "攻击";
            // 
            // label15
            // 
            label15.Location = new Point(446, 99);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(43, 26);
            label15.TabIndex = 42;
            label15.Text = "防御";
            // 
            // label16
            // 
            label16.Location = new Point(446, 129);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(43, 26);
            label16.TabIndex = 43;
            label16.Text = "速度";
            // 
            // label17
            // 
            label17.Location = new Point(446, 160);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(71, 21);
            label17.TabIndex = 44;
            label17.Text = "特攻";
            // 
            // label18
            // 
            label18.Location = new Point(446, 189);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(43, 26);
            label18.TabIndex = 45;
            label18.Text = "特防";
            // 
            // label19
            // 
            label19.Location = new Point(520, 18);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(77, 15);
            label19.TabIndex = 46;
            label19.Text = "个体值";
            // 
            // label20
            // 
            label20.Location = new Point(596, 18);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(88, 16);
            label20.TabIndex = 47;
            label20.Text = "基础点数";
            // 
            // save
            // 
            save.Location = new Point(20, 260);
            save.Margin = new Padding(4);
            save.Name = "save";
            save.Size = new Size(100, 26);
            save.TabIndex = 48;
            save.Text = "写入记录";
            save.UseVisualStyleBackColor = true;
            save.Click += SaveClick;
            // 
            // cancel
            // 
            cancel.Location = new Point(128, 260);
            cancel.Margin = new Padding(4);
            cancel.Name = "cancel";
            cancel.Size = new Size(100, 26);
            cancel.TabIndex = 49;
            cancel.Text = "取消";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += CancelClick;
            // 
            // label21
            // 
            label21.Location = new Point(39, 224);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(133, 26);
            label21.TabIndex = 50;
            label21.Text = "招式4：";
            // 
            // move4
            // 
            move4.FormattingEnabled = true;
            move4.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进", "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            move4.Location = new Point(128, 220);
            move4.Margin = new Padding(4);
            move4.Name = "move4";
            move4.Size = new Size(217, 23);
            move4.TabIndex = 51;
            // 
            // pp4
            // 
            pp4.Location = new Point(355, 221);
            pp4.Margin = new Padding(4);
            pp4.Name = "pp4";
            pp4.Size = new Size(49, 25);
            pp4.TabIndex = 52;
            // 
            // jap_check
            // 
            jap_check.Location = new Point(128, 7);
            jap_check.Margin = new Padding(4);
            jap_check.Name = "jap_check";
            jap_check.Size = new Size(171, 28);
            jap_check.TabIndex = 53;
            jap_check.Text = "日文解码";
            jap_check.UseVisualStyleBackColor = true;
            jap_check.CheckedChanged += Jap_checkCheckedChanged;
            // 
            // ECT_pkedit
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 300);
            Controls.Add(jap_check);
            Controls.Add(pp4);
            Controls.Add(move4);
            Controls.Add(label21);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(ev6);
            Controls.Add(ev5);
            Controls.Add(ev4);
            Controls.Add(ev3);
            Controls.Add(ev2);
            Controls.Add(ev1);
            Controls.Add(iv6);
            Controls.Add(iv5);
            Controls.Add(iv4);
            Controls.Add(iv3);
            Controls.Add(iv2);
            Controls.Add(iv1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(namebox);
            Controls.Add(friendship);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(ability);
            Controls.Add(label9);
            Controls.Add(pid);
            Controls.Add(otsid);
            Controls.Add(otid);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pp3);
            Controls.Add(pp2);
            Controls.Add(pp1);
            Controls.Add(level);
            Controls.Add(label5);
            Controls.Add(move3);
            Controls.Add(move2);
            Controls.Add(move1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(item_box);
            Controls.Add(label1);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ECT_pkedit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "训练家宝可梦编辑器";
            ((System.ComponentModel.ISupportInitialize)level).EndInit();
            ((System.ComponentModel.ISupportInitialize)pp1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pp2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pp3).EndInit();
            ((System.ComponentModel.ISupportInitialize)otid).EndInit();
            ((System.ComponentModel.ISupportInitialize)otsid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ability).EndInit();
            ((System.ComponentModel.ISupportInitialize)friendship).EndInit();
            ((System.ComponentModel.ISupportInitialize)iv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iv2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iv3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iv4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iv5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iv6).EndInit();
            ((System.ComponentModel.ISupportInitialize)ev6).EndInit();
            ((System.ComponentModel.ISupportInitialize)ev5).EndInit();
            ((System.ComponentModel.ISupportInitialize)ev4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ev3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ev2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ev1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pp4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

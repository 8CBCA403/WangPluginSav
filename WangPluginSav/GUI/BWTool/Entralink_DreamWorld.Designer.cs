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
    partial class Entralink_DreamWorld
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox speciesbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Move;
        private System.Windows.Forms.ComboBox movebox;
        private System.Windows.Forms.RadioButton atkC;
        private System.Windows.Forms.RadioButton atkB;
        private System.Windows.Forms.RadioButton atkA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton gnd_none;
        private System.Windows.Forms.RadioButton gnd_male;
        private System.Windows.Forms.RadioButton gnd_female;
        private System.Windows.Forms.Label area_label;
        private System.Windows.Forms.Button ok_but;
        private System.Windows.Forms.Button cancel_but;
        private System.Windows.Forms.Label exclusive_label;
        private System.Windows.Forms.ComboBox moveboxC;
        private System.Windows.Forms.ComboBox moveboxA;
        private System.Windows.Forms.ComboBox pgl_region_box;
        private System.Windows.Forms.Label move_lab;
        private System.Windows.Forms.Label region_lab;

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
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entralink_DreamWorld));
            speciesbox = new ComboBox();
            label1 = new Label();
            Move = new GroupBox();
            move_lab = new Label();
            region_lab = new Label();
            pgl_region_box = new ComboBox();
            movebox = new ComboBox();
            moveboxC = new ComboBox();
            moveboxA = new ComboBox();
            atkC = new RadioButton();
            atkB = new RadioButton();
            atkA = new RadioButton();
            groupBox1 = new GroupBox();
            gnd_none = new RadioButton();
            gnd_male = new RadioButton();
            gnd_female = new RadioButton();
            area_label = new Label();
            ok_but = new Button();
            cancel_but = new Button();
            exclusive_label = new Label();
            Move.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // speciesbox
            // 
            speciesbox.FormattingEnabled = true;
            speciesbox.Location = new Point(7, 109);
            speciesbox.Margin = new Padding(4, 4, 4, 4);
            speciesbox.Name = "speciesbox";
            speciesbox.Size = new Size(288, 23);
            speciesbox.TabIndex = 0;
            speciesbox.SelectedIndexChanged += SpeciesboxSelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(15, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 24);
            label1.TabIndex = 1;
            label1.Text = "种族";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Move
            // 
            Move.Controls.Add(move_lab);
            Move.Controls.Add(region_lab);
            Move.Controls.Add(pgl_region_box);
            Move.Controls.Add(movebox);
            Move.Controls.Add(moveboxC);
            Move.Controls.Add(moveboxA);
            Move.Controls.Add(atkC);
            Move.Controls.Add(atkB);
            Move.Controls.Add(atkA);
            Move.Location = new Point(7, 140);
            Move.Margin = new Padding(4, 4, 4, 4);
            Move.Name = "Move";
            Move.Padding = new Padding(4, 4, 4, 4);
            Move.Size = new Size(288, 111);
            Move.TabIndex = 2;
            Move.TabStop = false;
            Move.Text = "招式";
            // 
            // move_lab
            // 
            move_lab.Location = new Point(8, 49);
            move_lab.Margin = new Padding(4, 0, 4, 0);
            move_lab.Name = "move_lab";
            move_lab.Size = new Size(42, 19);
            move_lab.TabIndex = 8;
            move_lab.Text = "招式";
            // 
            // region_lab
            // 
            region_lab.Location = new Point(8, 25);
            region_lab.Margin = new Padding(4, 0, 4, 0);
            region_lab.Name = "region_lab";
            region_lab.Size = new Size(42, 20);
            region_lab.TabIndex = 7;
            region_lab.Text = "区域";
            // 
            // pgl_region_box
            // 
            pgl_region_box.DropDownStyle = ComboBoxStyle.Simple;
            pgl_region_box.FormattingEnabled = true;
            pgl_region_box.Items.AddRange(new object[] { "全部", "全部", "全部", "全部", "全部", "全部", "全部", "日、韩", "日、韩", "日、韩", "日、韩", "日、韩", "日、韩", "日、韩", "日、美、欧", "日", "日", "日", "全部", "全部", "全部", "韩", "全部", "欧", "日", "日、韩", "全部", "全部", "日、美、欧 (用于德、意、英)", "韩", "日", "日", "日", "美、欧 (仅用于美)", "美、欧 (仅用于美)", "美、欧 (仅用于美)", "日", "美、欧", "美、欧", "日、韩", "美、欧", "美、欧", "美、欧" });
            pgl_region_box.Location = new Point(119, 18);
            pgl_region_box.Margin = new Padding(4, 4, 4, 4);
            pgl_region_box.Name = "pgl_region_box";
            pgl_region_box.Size = new Size(157, 24);
            pgl_region_box.TabIndex = 6;
            // 
            // movebox
            // 
            movebox.DropDownStyle = ComboBoxStyle.Simple;
            movebox.FormattingEnabled = true;
            movebox.Items.AddRange(new object[] { "----------------------", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "混乱", "超能力", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "不参加", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "节拍器", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "返还", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进", "羽栖", "重力", "奇迹之眼", "唤醒巴掌", "臂锤", "陀螺球", "治愈之愿", "盐水", "自然之恩", "佯攻", "啄食", "顺风", "点穴", "金属爆炸", "急速折返", "近身战", "以牙还牙", "恶意追击", "查封", "投掷", "精神转移", "王牌", "回复封锁", "绞紧", "力量戏法", "胃液", "幸运咒语", "抢先一步", "仿效", "力量互换", "防守互换", "惩罚", "珍藏", "烦恼种子", "突袭", "毒菱", "心灵互换", "水流环", "电磁飘浮", "闪焰冲锋", "发劲", "波导弹", "岩石打磨", "毒击", "恶之波动", "暗袭要害", "水流尾", "种子炸弹", "空气斩", "十字剪", "虫鸣", "龙之波动", "龙之俯冲", "力量宝石", "吸取拳", "真空波", "真气弹", "能量球", "勇鸟猛攻", "大地之力", "掉包", "终极冲击", "诡计", "子弹拳", "雪崩", "冰砾", "暗影爪", "雷电牙", "冰冻牙", "火焰牙", "影子偷袭", "泥巴炸弹", "精神利刃", "意念头锤", "镜光射击", "加农光炮", "攀岩", "名镜", "戏法空间", "流星群", "放电", "喷烟", "飞叶风暴", "强力鞭打", "岩石炮", "十字毒刃", "垃圾射击", "铁头", "磁铁炸弹", "尖石攻击", "诱惑", "隐形岩", "打草结", "日常", "制裁光砾", "虫咬", "充电光束", "木槌", "水流喷射", "攻击指令", "防御指令", "回复指令", "双刃头锤", "二连击", "时光咆哮", "亚空裂斩", "新月舞", "捏碎", "熔岩风暴", "暗黑洞", "种子闪光", "奇异之风", "暗影潜袭", "磨爪", "广域防守", "防守平分", "力量平分", "奇妙空间", "精神冲击", "毒液冲击", "身体轻量化", "愤怒粉", "意念移物", "魔法空间", "击落", "山岚摔", "烈焰溅射", "污泥波", "蝶舞", "重磅冲撞", "同步干扰", "电球", "浸水", "蓄能焰袭", "盘蜷", "下盘踢", "酸液炸弹", "欺诈", "单纯光束", "找伙伴", "您先请", "轮唱", "回声", "逐步击破", "清除之烟", "辅助力量", "快速防守", "交换场地", "热水", "破壳", "治愈波动", "祸不单行", "自由落体", "换档", "巴投", "烧尽", "延后", "杂技", "镜面属性", "报仇", "搏命", "传递礼物", "炼狱", "水之誓约", "火之誓约", "草之誓约", "伏特替换", "虫之抵抗", "重踏", "冰息", "龙尾", "自我激励", "电网", "疯狂伏特", "直冲钻", "二连劈", "爱心印章", "木角", "圣剑", "贝壳刃", "高温重压", "青草搅拌器", "疯狂滚压", "棉花防守", "暗黑爆破", "精神击破", "扫尾拍打", "暴风", "爆炸头突击", "齿轮飞盘", "火焰弹", "高科技光炮", "古老之歌", "神秘之剑", "冰封世界", "雷击", "青焰", "火之舞", "冰冻伏特", "极寒冷焰", "大声咆哮", "冰柱坠击", "Ｖ热焰", "交错火焰", "交错闪电" });
            movebox.Location = new Point(119, 45);
            movebox.Margin = new Padding(4, 4, 4, 4);
            movebox.Name = "movebox";
            movebox.Size = new Size(157, 24);
            movebox.TabIndex = 3;
            // 
            // moveboxC
            // 
            moveboxC.DropDownStyle = ComboBoxStyle.Simple;
            moveboxC.FormattingEnabled = true;
            moveboxC.Items.AddRange(new object[] { "----------------------", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "混乱", "超能力", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "不参加", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "节拍器", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "返还", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进", "羽栖", "重力", "奇迹之眼", "唤醒巴掌", "臂锤", "陀螺球", "治愈之愿", "盐水", "自然之恩", "佯攻", "啄食", "顺风", "点穴", "金属爆炸", "急速折返", "近身战", "以牙还牙", "恶意追击", "查封", "投掷", "精神转移", "王牌", "回复封锁", "绞紧", "力量戏法", "胃液", "幸运咒语", "抢先一步", "仿效", "力量互换", "防守互换", "惩罚", "珍藏", "烦恼种子", "突袭", "毒菱", "心灵互换", "水流环", "电磁飘浮", "闪焰冲锋", "发劲", "波导弹", "岩石打磨", "毒击", "恶之波动", "暗袭要害", "水流尾", "种子炸弹", "空气斩", "十字剪", "虫鸣", "龙之波动", "龙之俯冲", "力量宝石", "吸取拳", "真空波", "真气弹", "能量球", "勇鸟猛攻", "大地之力", "掉包", "终极冲击", "诡计", "子弹拳", "雪崩", "冰砾", "暗影爪", "雷电牙", "冰冻牙", "火焰牙", "影子偷袭", "泥巴炸弹", "精神利刃", "意念头锤", "镜光射击", "加农光炮", "攀岩", "名镜", "戏法空间", "流星群", "放电", "喷烟", "飞叶风暴", "强力鞭打", "岩石炮", "十字毒刃", "垃圾射击", "铁头", "磁铁炸弹", "尖石攻击", "诱惑", "隐形岩", "打草结", "日常", "制裁光砾", "虫咬", "充电光束", "木槌", "水流喷射", "攻击指令", "防御指令", "回复指令", "双刃头锤", "二连击", "时光咆哮", "亚空裂斩", "新月舞", "捏碎", "熔岩风暴", "暗黑洞", "种子闪光", "奇异之风", "暗影潜袭", "磨爪", "广域防守", "防守平分", "力量平分", "奇妙空间", "精神冲击", "毒液冲击", "身体轻量化", "愤怒粉", "意念移物", "魔法空间", "击落", "山岚摔", "烈焰溅射", "污泥波", "蝶舞", "重磅冲撞", "同步干扰", "电球", "浸水", "蓄能焰袭", "盘蜷", "下盘踢", "酸液炸弹", "欺诈", "单纯光束", "找伙伴", "您先请", "轮唱", "回声", "逐步击破", "清除之烟", "辅助力量", "快速防守", "交换场地", "热水", "破壳", "治愈波动", "祸不单行", "自由落体", "换档", "巴投", "烧尽", "延后", "杂技", "镜面属性", "报仇", "搏命", "传递礼物", "炼狱", "水之誓约", "火之誓约", "草之誓约", "伏特替换", "虫之抵抗", "重踏", "冰息", "龙尾", "自我激励", "电网", "疯狂伏特", "直冲钻", "二连劈", "爱心印章", "木角", "圣剑", "贝壳刃", "高温重压", "青草搅拌器", "疯狂滚压", "棉花防守", "暗黑爆破", "精神击破", "扫尾拍打", "暴风", "爆炸头突击", "齿轮飞盘", "火焰弹", "高科技光炮", "古老之歌", "神秘之剑", "冰封世界", "雷击", "青焰", "火之舞", "冰冻伏特", "极寒冷焰", "大声咆哮", "冰柱坠击", "Ｖ热焰", "交错火焰", "交错闪电" });
            moveboxC.Location = new Point(119, 70);
            moveboxC.Margin = new Padding(4, 4, 4, 4);
            moveboxC.Name = "moveboxC";
            moveboxC.Size = new Size(157, 24);
            moveboxC.TabIndex = 5;
            // 
            // moveboxA
            // 
            moveboxA.DropDownStyle = ComboBoxStyle.Simple;
            moveboxA.FormattingEnabled = true;
            moveboxA.Items.AddRange(new object[] { "----------------------", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "混乱", "超能力", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "不参加", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "节拍器", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "返还", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进", "羽栖", "重力", "奇迹之眼", "唤醒巴掌", "臂锤", "陀螺球", "治愈之愿", "盐水", "自然之恩", "佯攻", "啄食", "顺风", "点穴", "金属爆炸", "急速折返", "近身战", "以牙还牙", "恶意追击", "查封", "投掷", "精神转移", "王牌", "回复封锁", "绞紧", "力量戏法", "胃液", "幸运咒语", "抢先一步", "仿效", "力量互换", "防守互换", "惩罚", "珍藏", "烦恼种子", "突袭", "毒菱", "心灵互换", "水流环", "电磁飘浮", "闪焰冲锋", "发劲", "波导弹", "岩石打磨", "毒击", "恶之波动", "暗袭要害", "水流尾", "种子炸弹", "空气斩", "十字剪", "虫鸣", "龙之波动", "龙之俯冲", "力量宝石", "吸取拳", "真空波", "真气弹", "能量球", "勇鸟猛攻", "大地之力", "掉包", "终极冲击", "诡计", "子弹拳", "雪崩", "冰砾", "暗影爪", "雷电牙", "冰冻牙", "火焰牙", "影子偷袭", "泥巴炸弹", "精神利刃", "意念头锤", "镜光射击", "加农光炮", "攀岩", "名镜", "戏法空间", "流星群", "放电", "喷烟", "飞叶风暴", "强力鞭打", "岩石炮", "十字毒刃", "垃圾射击", "铁头", "磁铁炸弹", "尖石攻击", "诱惑", "隐形岩", "打草结", "日常", "制裁光砾", "虫咬", "充电光束", "木槌", "水流喷射", "攻击指令", "防御指令", "回复指令", "双刃头锤", "二连击", "时光咆哮", "亚空裂斩", "新月舞", "捏碎", "熔岩风暴", "暗黑洞", "种子闪光", "奇异之风", "暗影潜袭", "磨爪", "广域防守", "防守平分", "力量平分", "奇妙空间", "精神冲击", "毒液冲击", "身体轻量化", "愤怒粉", "意念移物", "魔法空间", "击落", "山岚摔", "烈焰溅射", "污泥波", "蝶舞", "重磅冲撞", "同步干扰", "电球", "浸水", "蓄能焰袭", "盘蜷", "下盘踢", "酸液炸弹", "欺诈", "单纯光束", "找伙伴", "您先请", "轮唱", "回声", "逐步击破", "清除之烟", "辅助力量", "快速防守", "交换场地", "热水", "破壳", "治愈波动", "祸不单行", "自由落体", "换档", "巴投", "烧尽", "延后", "杂技", "镜面属性", "报仇", "搏命", "传递礼物", "炼狱", "水之誓约", "火之誓约", "草之誓约", "伏特替换", "虫之抵抗", "重踏", "冰息", "龙尾", "自我激励", "电网", "疯狂伏特", "直冲钻", "二连劈", "爱心印章", "木角", "圣剑", "贝壳刃", "高温重压", "青草搅拌器", "疯狂滚压", "棉花防守", "暗黑爆破", "精神击破", "扫尾拍打", "暴风", "爆炸头突击", "齿轮飞盘", "火焰弹", "高科技光炮", "古老之歌", "神秘之剑", "冰封世界", "雷击", "青焰", "火之舞", "冰冻伏特", "极寒冷焰", "大声咆哮", "冰柱坠击", "Ｖ热焰", "交错火焰", "交错闪电" });
            moveboxA.Location = new Point(119, 18);
            moveboxA.Margin = new Padding(4, 4, 4, 4);
            moveboxA.Name = "moveboxA";
            moveboxA.Size = new Size(157, 24);
            moveboxA.TabIndex = 4;
            // 
            // atkC
            // 
            atkC.Location = new Point(58, 66);
            atkC.Margin = new Padding(4, 4, 4, 4);
            atkC.Name = "atkC";
            atkC.Size = new Size(139, 28);
            atkC.TabIndex = 2;
            atkC.TabStop = true;
            atkC.Text = "C";
            atkC.UseVisualStyleBackColor = true;
            atkC.CheckedChanged += AtkCCheckedChanged;
            // 
            // atkB
            // 
            atkB.Location = new Point(58, 42);
            atkB.Margin = new Padding(4, 4, 4, 4);
            atkB.Name = "atkB";
            atkB.Size = new Size(139, 28);
            atkB.TabIndex = 1;
            atkB.TabStop = true;
            atkB.Text = "B";
            atkB.UseVisualStyleBackColor = true;
            atkB.CheckedChanged += AtkBCheckedChanged;
            // 
            // atkA
            // 
            atkA.Location = new Point(58, 18);
            atkA.Margin = new Padding(4, 4, 4, 4);
            atkA.Name = "atkA";
            atkA.Size = new Size(139, 28);
            atkA.TabIndex = 0;
            atkA.TabStop = true;
            atkA.Text = "A";
            atkA.UseVisualStyleBackColor = true;
            atkA.CheckedChanged += AtkACheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gnd_none);
            groupBox1.Controls.Add(gnd_male);
            groupBox1.Controls.Add(gnd_female);
            groupBox1.Location = new Point(7, 259);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(128, 109);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "性别";
            // 
            // gnd_none
            // 
            gnd_none.Location = new Point(8, 70);
            gnd_none.Margin = new Padding(4, 4, 4, 4);
            gnd_none.Name = "gnd_none";
            gnd_none.Size = new Size(112, 28);
            gnd_none.TabIndex = 6;
            gnd_none.TabStop = true;
            gnd_none.Text = "无性别";
            gnd_none.UseVisualStyleBackColor = true;
            gnd_none.CheckedChanged += Gnd_noneCheckedChanged;
            // 
            // gnd_male
            // 
            gnd_male.Location = new Point(8, 22);
            gnd_male.Margin = new Padding(4, 4, 4, 4);
            gnd_male.Name = "gnd_male";
            gnd_male.Size = new Size(96, 28);
            gnd_male.TabIndex = 4;
            gnd_male.TabStop = true;
            gnd_male.Text = "雄性";
            gnd_male.UseVisualStyleBackColor = true;
            gnd_male.CheckedChanged += Gnd_maleCheckedChanged;
            // 
            // gnd_female
            // 
            gnd_female.Location = new Point(8, 46);
            gnd_female.Margin = new Padding(4, 4, 4, 4);
            gnd_female.Name = "gnd_female";
            gnd_female.Size = new Size(96, 28);
            gnd_female.TabIndex = 5;
            gnd_female.TabStop = true;
            gnd_female.Text = "雌性";
            gnd_female.UseVisualStyleBackColor = true;
            gnd_female.CheckedChanged += Gnd_femaleCheckedChanged;
            // 
            // area_label
            // 
            area_label.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            area_label.Location = new Point(7, 10);
            area_label.Margin = new Padding(4, 0, 4, 0);
            area_label.Name = "area_label";
            area_label.Size = new Size(261, 69);
            area_label.TabIndex = 4;
            area_label.Text = "梦世界区域";
            area_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ok_but
            // 
            ok_but.Location = new Point(168, 283);
            ok_but.Margin = new Padding(4, 4, 4, 4);
            ok_but.Name = "ok_but";
            ok_but.Size = new Size(100, 26);
            ok_but.TabIndex = 5;
            ok_but.Text = "确认";
            ok_but.UseVisualStyleBackColor = true;
            ok_but.Click += Ok_butClick;
            // 
            // cancel_but
            // 
            cancel_but.Location = new Point(168, 317);
            cancel_but.Margin = new Padding(4, 4, 4, 4);
            cancel_but.Name = "cancel_but";
            cancel_but.Size = new Size(100, 26);
            cancel_but.TabIndex = 6;
            cancel_but.Text = "取消";
            cancel_but.UseVisualStyleBackColor = true;
            cancel_but.Click += Cancel_butClick;
            // 
            // exclusive_label
            // 
            exclusive_label.ForeColor = Color.Red;
            exclusive_label.Location = new Point(208, 80);
            exclusive_label.Margin = new Padding(4, 0, 4, 0);
            exclusive_label.Name = "exclusive_label";
            exclusive_label.Size = new Size(87, 26);
            exclusive_label.TabIndex = 7;
            exclusive_label.Text = "仅黑白2";
            exclusive_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Entralink_DreamWorld
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 388);
            Controls.Add(exclusive_label);
            Controls.Add(cancel_but);
            Controls.Add(ok_but);
            Controls.Add(area_label);
            Controls.Add(groupBox1);
            Controls.Add(Move);
            Controls.Add(label1);
            Controls.Add(speciesbox);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "Entralink_DreamWorld";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "梦世界";
            Move.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}

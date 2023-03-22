﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class WC3_editor_givegg
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox species_box;

        private Label label1;

        private ComboBox move_box;

        private Label label2;

        private ComboBox game_box;

        private ComboBox lang_box;

        private Label label3;

        private Label label4;

        private Button save_but;

        private Button cancel_but;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WC3_editor_givegg));
            species_box = new ComboBox();
            label1 = new Label();
            move_box = new ComboBox();
            label2 = new Label();
            game_box = new ComboBox();
            lang_box = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            save_but = new Button();
            cancel_but = new Button();
            SuspendLayout();
            // 
            // species_box
            // 
            species_box.FormattingEnabled = true;
            species_box.Items.AddRange(new object[] { "无", "妙蛙种子", "妙蛙草", "妙蛙花", "小火龙", "火恐龙", "喷火龙", "杰尼龟", "卡咪龟", "水箭龟", "绿毛虫", "铁甲蛹", "巴大蝶", "独角虫", "铁壳蛹", "大针蜂", "波波", "比比鸟", "大比鸟", "小拉达", "拉达", "烈雀", "大嘴雀", "阿柏蛇", "阿柏怪", "皮卡丘", "雷丘", "穿山鼠", "穿山王", "尼多兰", "尼多娜", "尼多后", "尼多朗", "尼多力诺", "尼多王", "皮皮", "皮可西", "六尾", "九尾", "胖丁", "胖可丁", "超音蝠", "大嘴蝠", "走路草", "臭臭花", "霸王花", "派拉斯", "派拉斯特", "毛球", "摩鲁蛾", "地鼠", "三地鼠", "喵喵", "猫老大", "可达鸭", "哥达鸭", "猴怪", "火暴猴", "卡蒂狗", "风速狗", "蚊香蝌蚪", "蚊香君", "蚊香泳士", "凯西", "勇基拉", "胡地", "腕力", "豪力", "怪力", "喇叭芽", "口呆花", "大食花", "玛瑙水母", "毒刺水母", "小拳石", "隆隆石", "隆隆岩", "小火马", "烈焰马", "呆呆兽", "呆壳兽", "小磁怪", "三合一磁怪", "大葱鸭", "嘟嘟", "嘟嘟利", "小海狮", "白海狮", "臭泥", "臭臭泥", "大舌贝", "刺甲贝", "鬼斯", "鬼斯通", "耿鬼", "大岩蛇", "催眠貘", "引梦貘人", "大钳蟹", "巨钳蟹", "霹雳电球", "顽皮雷弹", "蛋蛋", "椰蛋树", "卡拉卡拉", "嘎啦嘎啦", "飞腿郎", "快拳郎", "大舌头", "瓦斯弹", "双弹瓦斯", "独角犀牛", "钻角犀兽", "吉利蛋", "蔓藤怪", "袋兽", "墨海马", "海刺龙", "角金鱼", "金鱼王", "海星星", "宝石海星", "魔墙人偶", "飞天螳螂", "迷唇姐", "电击兽", "鸭嘴火兽", "凯罗斯", "肯泰罗", "鲤鱼王", "暴鲤龙", "拉普拉斯", "百变怪", "伊布", "水伊布", "雷伊布", "火伊布", "多边兽", "菊石兽", "多刺菊石兽", "化石盔", "镰刀盔", "化石翼龙", "卡比兽", "急冻鸟", "闪电鸟", "火焰鸟", "迷你龙", "哈克龙", "快龙", "超梦", "梦幻", "菊草叶", "月桂叶", "大竺葵", "火球鼠", "火岩鼠", "火暴兽", "小锯鳄", "蓝鳄", "大力鳄", "尾立", "大尾立", "咕咕", "猫头夜鹰", "芭瓢虫", "安瓢虫", "圆丝蛛", "阿利多斯", "叉字蝠", "灯笼鱼", "电灯怪", "皮丘", "皮宝宝", "宝宝丁", "波克比", "波克基古", "天然雀", "天然鸟", "咩利羊", "茸茸羊", "电龙", "美丽花", "玛力露", "玛力露丽", "树才怪", "蚊香蛙皇", "毽子草", "毽子花", "毽子棉", "长尾怪手", "向日种子", "向日花怪", "蜻蜻蜓", "乌波", "沼王", "太阳伊布", "月亮伊布", "黑暗鸦", "呆呆王", "梦妖", "未知图腾A", "果然翁", "麒麟奇", "榛果球", "佛烈托斯", "土龙弟弟", "天蝎", "大钢蛇", "布鲁", "布鲁皇", "千针鱼", "巨钳螳螂", "壶壶", "赫拉克罗斯", "狃拉", "熊宝宝", "圈圈熊", "熔岩虫", "熔岩蜗牛", "小山猪", "长毛猪", "太阳珊瑚", "铁炮鱼", "章鱼桶", "信使鸟", "巨翅飞鱼", "盔甲鸟", "戴鲁比", "黑鲁加", "刺龙王", "小小象", "顿甲", "多边兽Ⅱ", "惊角鹿", "图图犬", "无畏小子", "战舞郎", "迷唇娃", "电击怪", "鸭嘴宝宝", "大奶罐", "幸福蛋", "雷公", "炎帝", "水君", "幼基拉斯", "沙基拉斯", "班基拉斯", "洛奇亚", "凤王", "时拉比", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "?(空）", "木守宫", "森林蜥蜴", "蜥蜴王", "火稚鸡", "力壮鸡", "火焰鸡", "水跃鱼", "沼跃鱼", "巨沼怪", "土狼犬", "大狼犬", "蛇纹熊", "直冲熊", "刺尾虫", "甲壳茧", "狩猎凤蝶", "盾甲茧", "毒粉蛾", "莲叶童子", "莲帽小童", "乐天河童", "橡实果", "长鼻叶", "狡猾天狗", "土居忍士", "铁面忍者", "脱壳忍者", "傲骨燕", "大王燕", "蘑蘑菇", "斗笠菇", "晃晃斑", "长翅鸥", "大嘴鸥", "溜溜糖球", "雨翅蛾", "吼吼鲸", "吼鲸王", "向尾喵", "优雅猫", "变隐龙", "天秤偶", "念力土偶", "朝北鼻", "煤炭龟", "勾魂眼", "泥泥鳅", "鲶鱼王", "爱心鱼", "龙虾小兵", "铁螯龙虾", "丑丑鱼", "美纳斯", "利牙鱼", "巨牙鲨", "大颚蚁", "超音波幼虫", "沙漠蜻蜓", "幕下力士", "铁掌力士", "落雷兽", "雷电兽", "呆火驼", "喷火驼", "海豹球", "海魔狮", "帝牙海狮", "刺球仙人掌", "梦歌仙人掌", "雪童子", "冰鬼护", "月石", "太阳岩", "露力丽", "跳跳猪", "噗噗猪", "正电拍拍", "负电拍拍", "大嘴娃", "玛沙那", "恰雷姆", "青绵鸟", "七夕青鸟", "小果然", "夜巡灵", "彷徨夜灵", "毒蔷薇", "懒人獭", "过动猿", "请假王", "溶食兽", "吞食兽", "热带龙", "咕妞妞", "吼爆弹", "爆音怪", "珍珠贝", "猎斑鱼", "樱花鱼", "阿勃梭鲁", "怨影娃娃", "诅咒娃娃", "饭匙蛇", "猫鼬斩", "古空棘鱼", "可可多拉", "可多拉", "波士可多拉", "飘浮泡泡", "电萤虫", "甜甜萤", "触手百合", "摇篮百合", "太古羽虫", "太古盔甲", "拉鲁拉丝", "奇鲁莉安", "沙奈朵", "宝贝龙", "甲壳龙", "暴飞龙", "铁哑铃", "金属怪", "巨金怪", "雷吉洛克", "雷吉艾斯", "雷吉斯奇鲁", "盖欧卡", "固拉多", "烈空坐", "拉帝亚斯", "拉帝欧斯", "基拉祈", "代欧奇希斯", "风铃铃", "蛋", "未知图腾B", "未知图腾C", "未知图腾D", "未知图腾E", "未知图腾F", "未知图腾G", "未知图腾H", "未知图腾I", "未知图腾J", "未知图腾K", "未知图腾L", "未知图腾M", "未知图腾N", "未知图腾O", "未知图腾P", "未知图腾Q", "未知图腾R", "未知图腾S", "未知图腾T", "未知图腾U", "未知图腾V", "未知图腾W", "未知图腾X", "未知图腾Y", "未知图腾Z", "未知图腾!", "未知图腾?" });
            species_box.Location = new Point(16, 80);
            species_box.Margin = new Padding(4, 4, 4, 4);
            species_box.Name = "species_box";
            species_box.Size = new Size(225, 23);
            species_box.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(16, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 17);
            label1.TabIndex = 1;
            label1.Text = "Pokemon:";
            // 
            // move_box
            // 
            move_box.FormattingEnabled = true;
            move_box.Items.AddRange(new object[] { "-无-", "拍击", "空手劈", "连环巴掌", "连续拳", "百万吨重拳", "聚宝功", "火焰拳", "冰冻拳", "雷电拳", "抓", "夹住", "断头钳", "旋风刀", "剑舞", "居合斩", "起风", "翅膀攻击", "吹飞", "飞翔", "绑紧", "摔打", "藤鞭", "踩踏", "二连踢", "百万吨重踢", "飞踢", "回旋踢", "泼沙", "头锤", "角撞", "乱击", "角钻", "撞击", "泰山压顶", "紧束", "猛撞", "大闹一番", "舍身冲撞", "摇尾巴", "毒针", "双针", "飞弹针", "瞪眼", "咬住", "叫声", "吼叫", "唱歌", "超音波", "音爆", "定身法", "溶解液", "火花", "喷射火焰", "白雾", "水枪", "水炮", "冲浪", "冰冻光束", "暴风雪", "幻象光线", "泡沫光线", "极光束", "破坏光线", "啄", "啄钻", "地狱翻滚", "踢倒", "双倍奉还", "地球上投", "怪力", "吸取", "超级吸取", "寄生种子", "生长", "飞叶快刀", "日光束", "毒粉", "麻痹粉", "催眠粉", "花瓣舞", "吐丝", "龙之怒", "火焰旋涡", "电击", "十万伏特", "电磁波", "打雷", "落石", "地震", "地裂", "挖洞", "剧毒", "念力", "精神强念", "催眠术", "瑜伽姿势", "高速移动", "电光一闪", "愤怒", "瞬间移动", "黑夜魔影", "模仿", "刺耳声", "影子分身", "自我再生", "变硬", "变小", "烟幕", "奇异之光", "缩入壳中", "变圆", "屏障", "光墙", "黑雾", "反射壁", "聚气", "忍耐", "挥指", "鹦鹉学舌", "自爆", "炸蛋", "舌舔", "浊雾", "污泥攻击", "骨棒", "大字爆炎", "攀瀑", "贝壳夹击", "高速星星", "火箭头锤", "尖刺加农炮", "缠绕", "瞬间失忆", "折弯汤匙", "生蛋", "飞膝踢", "大蛇瞪眼", "食梦", "毒瓦斯", "投球", "吸血", "恶魔之吻", "神鸟猛击", "变身", "泡沫", "迷昏拳", "蘑菇孢子", "闪光", "精神波", "跃起", "溶化", "蟹钳锤", "大爆炸", "乱抓", "骨头回力镖", "睡觉", "岩崩", "必杀门牙", "棱角化", "纹理", "三重攻击", "愤怒门牙", "劈开", "替身", "挣扎", "写生", "三连踢", "小偷", "蛛网", "心之眼", "恶梦", "火焰轮", "打鼾", "诅咒", "抓狂", "纹理２", "气旋攻击", "棉孢子", "起死回生", "怨恨", "细雪", "守住", "音速拳", "鬼面", "出奇一击", "天使之吻", "腹鼓", "污泥炸弹", "掷泥", "章鱼桶炮", "撒菱", "电磁炮", "识破", "同命", "灭亡之歌", "冰冻之风", "看穿", "骨棒乱打", "锁定", "逆鳞", "沙暴", "终极吸取", "挺住", "撒娇", "滚动", "点到为止", "虚张声势", "喝牛奶", "电光", "连斩", "钢翼", "黑色目光", "迷人", "梦话", "治愈铃声", "报恩", "礼物", "迁怒", "神秘守护", "分担痛楚", "神圣之火", "震级", "爆裂拳", "超级角击", "龙息", "接棒", "再来一次", "追打", "高速旋转", "甜甜香气", "铁尾", "金属爪", "借力摔", "晨光", "光合作用", "月光", "觉醒力量", "十字劈", "龙卷风", "求雨", "大晴天", "咬碎", "镜面反射", "自我暗示", "神速", "原始之力", "暗影球", "预知未来", "碎岩", "潮旋", "围攻", "击掌奇袭", "吵闹", "蓄力", "喷出", "吞下", "热风", "冰雹", "无理取闹", "吹捧", "鬼火", "临别礼物", "硬撑", "真气拳", "清醒", "看我嘛", "自然之力", "充电", "挑衅", "帮助", "戏法", "扮演", "祈愿", "借助", "扎根", "蛮力", "魔法反射", "回收利用", "报复", "劈瓦", "哈欠", "拍落", "蛮干", "喷火", "特性互换", "封印", "焕然一新", "怨念", "抢夺", "秘密之力", "潜水", "猛推", "保护色", "萤火", "洁净光芒", "薄雾球", "羽毛舞", "摇晃舞", "火焰踢", "玩泥巴", "冰球", "尖刺臂", "偷懒", "巨声", "剧毒牙", "撕裂爪", "爆炸烈焰", "加农水炮", "彗星拳", "惊吓", "气象球", "芳香治疗", "假哭", "空气利刃", "过热", "气味侦测", "岩石封锁", "银色旋风", "金属音", "草笛", "挠痒", "宇宙力量", "喷水", "信号光束", "暗影拳", "神通力", "冲天拳", "流沙地狱", "绝对零度", "浊流", "种子机关枪", "燕返", "冰锥", "铁壁", "挡路", "长嚎", "龙爪", "疯狂植物", "健美", "弹跳", "泥巴射击", "毒尾", "渴望", "伏特攻击", "魔法叶", "玩水", "冥想", "叶刃", "龙之舞", "岩石爆击", "电击波", "水之波动", "破灭之愿", "精神突进" });
            move_box.Location = new Point(251, 80);
            move_box.Margin = new Padding(4, 4, 4, 4);
            move_box.Name = "move_box";
            move_box.Size = new Size(225, 23);
            move_box.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(251, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 17);
            label2.TabIndex = 3;
            label2.Text = "特殊招式：";
            // 
            // game_box
            // 
            game_box.FormattingEnabled = true;
            game_box.Items.AddRange(new object[] { "绿宝石", "火红/叶绿" });
            game_box.Location = new Point(16, 32);
            game_box.Margin = new Padding(4, 4, 4, 4);
            game_box.Name = "game_box";
            game_box.Size = new Size(225, 23);
            game_box.TabIndex = 4;
            // 
            // lang_box
            // 
            lang_box.FormattingEnabled = true;
            lang_box.Items.AddRange(new object[] { "日语", "英语", "法语", "意大利语", "德语", "西班牙语" });
            lang_box.Location = new Point(251, 32);
            lang_box.Margin = new Padding(4, 4, 4, 4);
            lang_box.Name = "lang_box";
            lang_box.Size = new Size(225, 23);
            lang_box.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(16, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 6;
            label3.Text = "游戏版本：";
            // 
            // label4
            // 
            label4.Location = new Point(251, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 17);
            label4.TabIndex = 7;
            label4.Text = "语种：";
            // 
            // save_but
            // 
            save_but.Location = new Point(143, 111);
            save_but.Margin = new Padding(4, 4, 4, 4);
            save_but.Name = "save_but";
            save_but.Size = new Size(100, 26);
            save_but.TabIndex = 8;
            save_but.Text = "注入";
            save_but.UseVisualStyleBackColor = true;
            save_but.Click += Save_butClick;
            // 
            // cancel_but
            // 
            cancel_but.Location = new Point(251, 111);
            cancel_but.Margin = new Padding(4, 4, 4, 4);
            cancel_but.Name = "cancel_but";
            cancel_but.Size = new Size(100, 26);
            cancel_but.TabIndex = 9;
            cancel_but.Text = "取消";
            cancel_but.UseVisualStyleBackColor = true;
            cancel_but.Click += Cancel_butClick;
            // 
            // WC3_editor_givegg
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 146);
            Controls.Add(cancel_but);
            Controls.Add(save_but);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lang_box);
            Controls.Add(game_box);
            Controls.Add(label2);
            Controls.Add(move_box);
            Controls.Add(label1);
            Controls.Add(species_box);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "WC3_editor_givegg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ROM赠蛋脚本编辑器";
            ResumeLayout(false);
        }
    }
}

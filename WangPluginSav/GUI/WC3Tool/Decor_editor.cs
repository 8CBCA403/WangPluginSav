using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WangPluginSav.Util.WC3;

namespace WC3Tool;

partial class Decor_editor : Form
{
    private byte[] decorbuff;

    private SAV3 sav3file;

    public string savfilter = WC3ToolMainForm.savfilter;

    private int[] desk_ref = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    private int[] chair_ref = new int[9] { 10, 11, 12, 13, 14, 15, 16, 17, 18 };

    private int[] plant_ref = new int[6] { 19, 20, 21, 22, 23, 24 };

    private int[] ornament_ref = new int[23]
    {
        25, 26, 27, 28, 29, 30, 31, 32, 33, 34,
        35, 36, 37, 38, 39, 40, 41, 42, 43, 44,
        45, 46, 47
    };

    private int[] mat_ref = new int[18]
    {
        48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
        58, 59, 60, 61, 62, 63, 64, 65
    };

    private int[] poster_ref = new int[10] { 66, 67, 68, 69, 70, 71, 72, 73, 74, 75 };

    private int[] doll_ref = new int[35]
    {
        76, 77, 78, 79, 80, 81, 82, 83, 84, 85,
        86, 87, 88, 89, 90, 91, 92, 93, 94, 95,
        96, 97, 98, 99, 100, 111, 112, 113, 114, 115,
        116, 117, 118, 119, 120
    };

    private int[] cushion_ref = new int[10] { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110 };

    private int[] slots_max = new int[8] { 10, 10, 10, 30, 30, 10, 40, 10 };

    object[] Desks = new object[] {
            "空",
            "小型桌子",
            "精灵球桌子",
            "沉重桌子",
            "粗糙桌子",
            "松软桌子",
            "漂亮桌子",
            "砖块桌子",
            "露营桌子",
            "坚硬桌子"};
    object[] Chairs = new object[] {
            "空",
            "小型椅子",
            "精灵球椅子",
            "沉重椅子",
            "粗糙椅子",
            "松软椅子",
            "漂亮椅子",
            "砖块椅子",
            "露营椅子",
            "坚硬椅子"};
    object[] Plants = new object[] {
            "空",
            "鲜红盆栽",
            "南国盆栽",
            "可爱的花",
            "鲜艳盆栽",
            "大盆栽",
            "高大盆栽"};
    object[] Ornament = new object[] {
            "空",
            "红色砖块",
            "黄色砖块",
            "蓝色砖块",
            "红色气球",
            "蓝色气球",
            "黄色气球",
            "红色帐篷",
            "蓝色帐篷",
            "结实木板",
            "溜滑梯",
            "纵栅栏",
            "横栅栏",
            "轮胎",
            "大平台",
            "泥巴丸子",
            "可以打破的门",
            "砂子的装饰品",
            "银牌",
            "金牌",
            "玻璃工艺品",
            "电视机",
            "圆形电视机",
            "可爱电视机"};
    object[] Mats = new object[] {
            "空",
            "闪亮地毯",
            "跳跃地毯",
            "旋转地毯",
            "低Ｃ音符地毯",
            "Ｄ音符地毯",
            "Ｅ音符地毯",
            "Ｆ音符地毯",
            "Ｇ音符地毯",
            "Ａ音符地毯",
            "Ｂ音符地毯",
            "高Ｃ音符地毯",
            "冲浪地毯",
            "打雷地毯",
            "大字爆炎地毯",
            "细雪地毯",
            "迷人地毯",
            "地裂地毯",
            "撒菱地毯"};
    object[] Posters = new object[] {
            "空",
            "精灵球海报",
            "绿色海报",
            "红色海报",
            "水色海报",
            "可爱海报",
            "皮卡皮卡海报",
            "长的海报",
            "大海海报",
            "天空海报",
            "飞吻海报"};
    object[] Dolls = new object[] {
            "空",
            "皮丘布偶",
            "皮卡丘布偶",
            "玛力露布偶",
            "波克比布偶",
            "火球鼠布偶",
            "菊草叶布偶",
            "小锯鳄布偶",
            "胖丁布偶",
            "喵喵布偶",
            "皮皮布偶",
            "百变怪布偶",
            "迷唇娃布偶",
            "木守宫布偶",
            "火稚鸡布偶",
            "水跃鱼布偶",
            "夜巡灵布偶",
            "小果然布偶",
            "天秤偶布偶",
            "变隐龙布偶",
            "露力丽布偶",
            "向尾喵布偶",
            "青绵鸟布偶",
            "溶食兽布偶",
            "莲叶童子布偶",
            "橡实果布偶",
            "卡比兽布偶",
            "钻角犀兽布偶",
            "拉普拉斯布偶",
            "妙蛙花布偶",
            "喷火龙布偶",
            "水箭龟布偶",
            "吼吼鲸布偶",
            "雷吉洛克布偶",
            "雷吉艾斯布偶",
            "雷吉斯奇鲁布偶"};
    object[] Cushions = new object[] {
            "空",
            "皮卡丘垫子",
            "圆形垫子",
            "亲吻垫子",
            "蛇纹熊垫子",
            "团团转垫子",
            "钻石垫子",
            "精灵球垫子",
            "草垫子",
            "火垫子",
            "水垫子"};
    public Decor_editor(SAV3 save)
    {
        InitializeComponent();
        sav3file = save;
        decorbuff = sav3file.get_decorations();
        decortypebox.SelectedIndex = 0;
        numericUpDown1.Maximum = slots_max[decortypebox.SelectedIndex];
        decorationbox.SelectedIndex = 0;
        load_decor();
    }

    private void del_item()
    {
        int num = 0;
        for (int i = 0; i < decortypebox.SelectedIndex; i++)
        {
            num += slots_max[i];
        }
        decorbuff[num + (int)numericUpDown1.Value - 1] = 0;
    }

    private void set_item(int newitem)
    {
        int num = 0;
        for (int i = 0; i < decortypebox.SelectedIndex; i++)
        {
            num += slots_max[i];
        }
        int[] array = desk_ref;
        switch (decortypebox.SelectedIndex)
        {
            case 0:
                array = desk_ref;
                break;
            case 1:
                array = chair_ref;
                break;
            case 2:
                array = plant_ref;
                break;
            case 3:
                array = ornament_ref;
                break;
            case 4:
                array = mat_ref;
                break;
            case 5:
                array = poster_ref;
                break;
            case 6:
                array = doll_ref;
                break;
            case 7:
                array = cushion_ref;
                break;
        }
        decorbuff[num + (int)numericUpDown1.Value - 1] = (byte)array[newitem];
    }

    private byte get_item(int modifier)
    {
        int num = (int)numericUpDown1.Value - 1;
        if (num + modifier < 0)
        {
            modifier = 0;
        }
        int num2 = 0;
        for (int i = 0; i < decortypebox.SelectedIndex; i++)
        {
            num2 += slots_max[i];
        }
        return decorbuff[num2 + num + modifier];
    }

    private void load_decor()
    {
        byte b = get_item(0);
        int[] array = desk_ref;
        switch (decortypebox.SelectedIndex)
        {
            case 0:
                array = desk_ref;
                break;
            case 1:
                array = chair_ref;
                break;
            case 2:
                array = plant_ref;
                break;
            case 3:
                array = ornament_ref;
                break;
            case 4:
                array = mat_ref;
                break;
            case 5:
                array = poster_ref;
                break;
            case 6:
                array = doll_ref;
                break;
            case 7:
                array = cushion_ref;
                break;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (b == array[i])
            {
                decorationbox.SelectedIndex = i + 1;
                break;
            }
            decorationbox.SelectedIndex = 0;
        }
    }

    private void NumericUpDown1ValueChanged(object sender, EventArgs e)
    {
        if (get_item(-1) == 0)
        {
            if (numericUpDown1.Value - 1m < numericUpDown1.Minimum)
            {
                numericUpDown1.Value = numericUpDown1.Minimum;
            }
            else
            {
                numericUpDown1.Value -= 1m;
            }
        }
        else
        {
            load_decor();
        }
    }

    private void DecortypeboxSelectedIndexChanged(object sender, EventArgs e)
    {
        numericUpDown1.Value = 1m;
        numericUpDown1.Maximum = slots_max[decortypebox.SelectedIndex];
        decorationbox.Items.Clear();
        switch (decortypebox.SelectedIndex)
        {
            case 0:
                decorationbox.Items.AddRange(Desks);
                break;
            case 1:
                decorationbox.Items.AddRange(Chairs);
                break;
            case 2:
                decorationbox.Items.AddRange(Plants);
                break;
            case 3:
                decorationbox.Items.AddRange(Ornament);
                break;
            case 4:
                decorationbox.Items.AddRange(Mats);
                break;
            case 5:
                decorationbox.Items.AddRange(Posters);
                break;
            case 6:
                decorationbox.Items.AddRange(Dolls);
                break;
            case 7:
                decorationbox.Items.AddRange(Cushions);
                break;
        }
        numericUpDown1.Value = 1m;
        numericUpDown1.Maximum = slots_max[decortypebox.SelectedIndex];
        decorationbox.SelectedIndex = 0;
        load_decor();
    }

    private void Save_butClick(object sender, EventArgs e)
    {
        sav3file.set_decoration(decorbuff);
        sav3file.update_section_chk(3);
        FileIO.save_data(sav3file.Data, savfilter);
    }

    private void DecorationboxSelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void Add_butClick(object sender, EventArgs e)
    {
        if (decorationbox.SelectedIndex != 0)
        {
            set_item(decorationbox.SelectedIndex - 1);
        }
    }

    private void Del_butClick(object sender, EventArgs e)
    {
        if (numericUpDown1.Value != numericUpDown1.Maximum && get_item(1) != 0)
        {
            MessageBox.Show("请只删除最后占用的槽位。");
            return;
        }
        del_item();
        load_decor();
    }




}

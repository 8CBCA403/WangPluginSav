using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WangPluginSav
{
    internal class NPC
    {
            private int No;
            private int lifePoints;
            private int operation;
          
            
            public NPC(int no, int hp, int op)
            {
                No = no;
                lifePoints = hp;
                operation = op;
            }

            public int getNo()
            {
                return No;
            }

            public int getLp()
            {
                return lifePoints;
            }

            public int getOp()
            {
                return operation;
            }
        
    }
    internal class NPCName
    {
        public string? Name { get; set; }
        public string? PKMName { get; set; }
        public int ID { get; set; }
        public static string[] WhiteForestNPCPKM = { "波波", "刺尾虫", "鬼斯", "毽子草", "电击怪", "波克比", "腕力", "懒人翁", "小猫怪", "小鸭嘴龙", "小磁怪", "拉鲁拉丝", "姆克儿", "露力丽", "含羞苞", "走路草", "咩利羊", "可可多拉", "喇叭芽", "橡实果", "铁甲犀牛", "莲叶童子", "大颚蚁", "凯西", "尼多朗", "尼多兰", "咕妞妞", "3D龙", "好运蛋", "宝贝龙" };
        public static List<NPCName> IDList(ISaveFileProvider sav)
        {
            var L = new List<NPCName>();
            NPCName None = new NPCName
            {
                Name = "None 编号：-1",
                ID = -1,
                PKMName = "None",
            };
            NPCName Silvia = new NPCName
            {
                Name = "裕子 编号：1",
                ID = 1,
                PKMName = "刺尾虫",
            };
            NPCName Dave = new NPCName
            {
                Name = "拓郎 编号：2",
                ID = 2,
                PKMName = "鬼斯",
            };
            NPCName Robbie = new NPCName
            {
                Name = "正男 编号：4",
                ID = 4,
                PKMName = "电击怪",
            };
            NPCName Miki = new NPCName
            {
                Name = "美纪 编号：5",
                ID = 5,
                PKMName = "波克比",
            };
            NPCName Ryder = new NPCName
            {
                Name = "拓马 编号：6",
                ID = 6,
                PKMName = "腕力",
            };
            NPCName Karenna = new NPCName
            {
                Name = "卡莲 编号：7",
                ID = 7,
                PKMName = "懒人獭",
            };
            NPCName Doug = new NPCName
            {
                Name = "智隆 编号：8",
                ID = 8,
                PKMName = "小猫怪",
            };
            NPCName Marie = new NPCName
            {
                Name = "数穗 编号：10",
                ID = 10,
                PKMName = "小磁怪",
            };
            NPCName Jacques = new NPCName
            {
                Name = "悟 编号：25",
                ID = 25,
                PKMName = "尼多兰",
            };
            NPCName Lena = new NPCName
            {
                Name = "玲奈 编号：11",
                ID = 11,
                PKMName = "拉鲁拉斯",
            };
            NPCName Vincent = new NPCName
            {
                Name = "淳一 编号：9",
                ID = 9,
                PKMName = "鸭嘴宝宝",
            };
            NPCName Carlos = new NPCName
            {
                Name = "卡罗斯 编号：12",
                ID = 12,
                PKMName = "姆克儿",
            };
            NPCName Emi = new NPCName
            {
                Name = "艾米 编号：28",
                ID = 28,
                PKMName = "小福蛋",
            };
            NPCName Lynette = new NPCName
            {
                Name = "诗织 编号：15",
                ID = 15,
                PKMName = "走路草",
            };
            NPCName Pierce = new NPCName
            {
                Name = "仁嗣 编号：16",
                ID = 16,
                PKMName = "咩利羊",
            };
            NPCName Gene = new NPCName
            {
                Name = "岳人 编号：17",
                ID = 17,
                PKMName = "可可多拉",
            };
            NPCName Leo = new NPCName
            {
                Name = "秀作 编号：0",
                ID = 0,
                PKMName = "波波",
            };
            NPCName Piper = new NPCName
            {
                Name = "由美子 编号：18",
                ID = 18,
                PKMName = "喇叭芽",
            };
            NPCName Britney = new NPCName
            {
                Name = "慧子 编号：3",
                ID = 3,
                PKMName = "毽子草",
            };
            NPCName Miho = new NPCName
            {
                Name = "美保 编号：19",
                ID = 19,
                PKMName = "橡实果",
            };
            NPCName Shane = new NPCName
            {
                Name = "俊信 编号：20",
                ID = 20,
                PKMName = "独角犀牛",
            };
            NPCName Ralph = new NPCName
            {
                Name = "苍介 编号：21",
                ID = 21,
                PKMName = "莲叶童子",
            };
            NPCName Eliza = new NPCName
            {
                Name = "艾丽莎 编号：22",
                ID = 22,
                PKMName = "大颚蚁",
            };
            NPCName Collin = new NPCName
            {
                Name = "裕典 编号：23",
                ID = 23,
                PKMName = "凯西",
            };
            NPCName Rosa = new NPCName
            {
                Name = "罗莎 编号：26",
                ID = 26,
                PKMName = "咕妞妞",
            };
            NPCName Ken = new NPCName
            {
                Name = "健 编号：24",
                ID = 24,
                PKMName = "尼多朗",
            };
            NPCName Grace = new NPCName
            {
                Name = "格蕾丝 编号：29",
                ID = 29,
                PKMName = "宝贝龙",
            };
            NPCName Frederic = new NPCName
            {
                Name = "常一 编号：14",
                ID = 14,
                PKMName = "含羞苞",
            };
            NPCName Herman = new NPCName
            {
                Name = "博明 编号：27",
                ID = 27,
                PKMName = "多边兽",
            };
            NPCName Molly = new NPCName
            {
                Name = "博美 编号：13",
                ID = 13,
                PKMName = "露力丽",
            };
            L.Add(None);
            L.Add(Leo);
            L.Add(Silvia);
            L.Add(Dave);
            L.Add(Britney);
            L.Add(Robbie);
            L.Add(Miki);
            L.Add(Ryder);
            L.Add(Karenna);
            L.Add(Doug);
            L.Add(Vincent);
            L.Add(Marie);
            L.Add(Lena);
            L.Add(Carlos);
            L.Add(Molly);
            L.Add(Frederic);
            L.Add(Lynette);
            L.Add(Pierce);
            L.Add(Gene);
            L.Add(Piper);
            L.Add(Miho);
            L.Add(Shane);
            L.Add(Ralph);
            L.Add(Eliza);
            L.Add(Collin);
            L.Add(Ken);
            L.Add(Jacques);
            L.Add(Rosa);
            L.Add(Herman);
            L.Add(Emi);
            L.Add(Grace);
            return L;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WangPluginSav.BlockImportUtil
{
    internal class SWSHRaidConstants
    {
        // Base Game
        public static readonly Block BonusRewards = (0xEFCAE04E, "bonus_rewards");
        public static readonly Block DiaEncounter = (0xAD3920F5, "dai_encount");
        public static readonly Block DropRewards = (0x680EEB85, "drop_rewards");
        public static readonly Block NormalEncount = (0xAD9DFA6A, "normal_encount");
        // Isle of Armor DLC
        public static readonly Block NormalEncountRigel1 = (0x0E615A8C, "normal_encount_rigel1");
        // Crown Tundra DLC
        public static readonly Block NormalEncountRigel2 = (0x11615F45, "normal_encount_rigel2");

        // Block Lists
        public static readonly IReadOnlyList<Block> BaseGameBlocks = new List<Block>() { BonusRewards, DiaEncounter, DropRewards, NormalEncount };
        public static readonly IReadOnlyList<Block> IsleOfArmorBlocks = new List<Block>(BaseGameBlocks) { NormalEncountRigel1 };
        public static readonly IReadOnlyList<Block> CrownTundraBlocks = new List<Block>(IsleOfArmorBlocks) { NormalEncountRigel2 };
    }
}

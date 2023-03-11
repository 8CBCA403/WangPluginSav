using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WangPluginSav.BlockImportUtil
{
    internal class SVRaidConstants
    {
        // Base Game
        public static readonly Block EventRaidIdentifier = (0x37B99B4D, "event_raid_identifier");
        public static readonly Block FixedRewardItemArray = (0x7D6C2B82, "fixed_reward_item_array");
        public static readonly Block LotteryRewardItemArray = (0xA52B4811, "lottery_reward_item_array");
        public static readonly Block RaidEnemyArray = (0x0520A1B0, "raid_enemy_array");
        public static readonly Block RaidPriorityArray = (0x095451E4, "raid_priority_array");

        // Block Lists
        public static readonly IReadOnlyList<Block> BaseGameBlocks = new List<Block>() { EventRaidIdentifier, FixedRewardItemArray, LotteryRewardItemArray, RaidEnemyArray, RaidPriorityArray };
    }
}

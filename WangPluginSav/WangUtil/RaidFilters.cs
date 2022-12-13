using PKHeX.Core;
using System.Collections.Generic;
using System.Runtime;
using WangPluginSav.WangDataBase;
using WangPluginSav.WangUtil;

namespace WangPluginSav
{
    public  class RaidFilters
    {
        public  Species? Species =null;
        public  int? Stars = null;
        public  bool Shiny;
        public bool Sour;
        public bool Sweet;
        public bool Bitter;
        public bool Spicy;
        public bool Salty;
        public  Nature? Nature =  null;
        public Gend? Gender = null;
        public MoveType? Tera= null;
        public int minHP =0;
        public int maxHP= 31;
        //
        public int minAtk  = 0;
        public int maxAtk= 31;
        //
        public int minDef  = 0;
        public int maxDef = 31;
        //
        public int minSpA= 0;
        public int maxSpA = 31;
        //
        public int minSpD = 0;
        public int maxSpD  = 31;
        //
        public int minSpe = 0;
        public int maxSpe  = 31;

        public  bool IsFilterSet()
        {
            if (Species == null && Stars == null && Shiny == false && Nature == null)
                return false;
            return true;
        }

        public  bool IsSpeciesSatisfied(Raid raid, int StoryProgress)
        {
            if (Species == PKHeX.Core.Species.None)
                return true;
            if (Species == null)
                return true;
            ITeraRaid? encounter = TeraEncounter.GetEncounter(raid.Seed, StoryProgress, raid.IsBlack);
            if (encounter == null)
                return false;
            return encounter.Species == (int)Species;
        }

        public  bool IsStarsSatisfied(Raid raid, int StoryProgress)
        {
            if (Stars == null)
                return true;
            return (int)Stars == Raid.GetStarCount(raid.Difficulty, StoryProgress, raid.IsBlack);
        }

        public  bool IsShinySatisfied(Raid raid)
        {
            if (Shiny == false)
                return true;
            return raid.IsShiny == true;
        }

        public bool IsNatureSatisfied(Raid raid, int StoryProgress)
        {
            if (Nature == PKHeX.Core.Nature.Random)
                return true;
            if (Nature == null)
                return true;
            ITeraRaid? encounter = TeraEncounter.GetEncounter(raid.Seed, StoryProgress, raid.IsBlack);
            if (encounter == null)
                return false;
            var pi = PersonalTable.SV.GetFormEntry(encounter.Species, encounter.Form);
            var StarCount = Raid.GetStarCount(raid.Difficulty, StoryProgress, raid.IsBlack);
            var param = new GenerateParam9((byte)pi.Gender, (byte)(StarCount - 1), 1, 0, 0, 0, encounter.Ability, encounter.Shiny);
            var blank = new PK9();
            blank.Species = encounter.Species;
            blank.Form = encounter.Form;
            Encounter9RNG.GenerateData(blank, param, EncounterCriteria.Unrestricted, raid.Seed);
            return blank.Nature == (int)Nature;
        }
        public bool IsGenderSatisfied(Raid raid, int StoryProgress)
        {
            if (Gender == Gend.Random)
                return true;
            if (Gender == null)
                return true;
            ITeraRaid? encounter = TeraEncounter.GetEncounter(raid.Seed, StoryProgress, raid.IsBlack);
            if (encounter == null)
                return false;
            var pi = PersonalTable.SV.GetFormEntry(encounter.Species, encounter.Form);
            var StarCount = Raid.GetStarCount(raid.Difficulty, StoryProgress, raid.IsBlack);
            var param = new GenerateParam9((byte)pi.Gender, (byte)(StarCount - 1), 1, 0, 0, 0, encounter.Ability, encounter.Shiny);
            var blank = new PK9();
            blank.Species = encounter.Species;
            blank.Form = encounter.Form;
            Encounter9RNG.GenerateData(blank, param, EncounterCriteria.Unrestricted, raid.Seed);
            return (Gend)blank.Gender == Gender;
        }
        public bool IsTeraSatisfied(Raid raid)
        {
           var Teratype =(MoveType)Raid.GetTeranType(raid.Seed);
            if (Tera == (MoveType)18)
                return true;
            return Teratype == Tera;
        }
        public  bool IsIVsSatisfied(Raid raid, int StoryProgress, int EventProgress)
        {
            var progress = raid.IsEvent ? EventProgress : StoryProgress;
            ITeraRaid? encounter = raid.Encounter(progress);
            if (encounter == null)
                return false;
            var ivs = raid.GetIVs(raid.Seed, encounter.FlawlessIVCount);
            if (ivs[0] < minHP || ivs[0] > maxHP)
                return false;
            if (ivs[1] < minAtk || ivs[1] > maxAtk)
                return false;
            if (ivs[2] < minDef || ivs[2] > maxDef)
                return false;
            if (ivs[3] < minSpA || ivs[3] > maxSpA)
                return false;
            if (ivs[4] < minSpD || ivs[4] > maxSpD)
                return false;
            if (ivs[5] < minSpe || ivs[5] > maxSpe)
                return false;

            return true;
        }
        public bool IsItemsSatisfied(Raid raid, int StoryProgress, int EventProgress, List<DeliveryRaidFixedRewardItem>? fixed_rewards, List<DeliveryRaidLotteryRewardItem>? lottery_rewards, List<RaidFixedRewards>? Rfixed_rewards, List<RaidLotteryRewards>? Rlottery_rewards,int boost)
        {
            var progress = raid.IsEvent ? EventProgress : StoryProgress;
            ITeraRaid? encounter = raid.Encounter(progress);
            bool bSweet = false;
            bool bSalty = false;
            bool bSour = false;
            bool bBitter = false;
            bool bSpicy = false;

            var rewards = encounter switch
            {
                TeraDistribution => TeraDistribution.GetRewards((TeraDistribution)encounter, raid.Seed, fixed_rewards, lottery_rewards, boost),
                TeraEncounter => TeraEncounter.GetRewards((TeraEncounter)encounter, raid.Seed, Rfixed_rewards, Rlottery_rewards,boost),
                _ => null,
            };
            if (rewards == null)
                return false;
            for(int i=0;i<rewards.Count;i++)
            {
                if ((Sweet==true&&rewards[i].Item1 == 1904)||Sweet==false)
                    bSweet=true;
                if ((Salty == true && rewards[i].Item1 == 1905 )|| Salty == false)
                    bSalty = true;
                if ((Sour == true && rewards[i].Item1 == 1906) || Sour == false)
                    bSour = true;
                if ((Bitter == true && rewards[i].Item1 == 1907) || Bitter == false )
                    bBitter = true;
                if ((Spicy == true && rewards[i].Item1 == 1908) || Spicy == false)
                    bSpicy = true;
            }
            if (bSweet == false||bSalty==false||bSour==false||bBitter==false||bSpicy==false)
                return false;
         
            return true;
        }
       
        public  bool FilterSatisfied(Raid raid, int StoryProgress, int EventProgress,List<DeliveryRaidFixedRewardItem>? fixed_rewards, List<DeliveryRaidLotteryRewardItem>? lottery_rewards, List<RaidFixedRewards>? Rfixed_rewards, List<RaidLotteryRewards>? Rlottery_rewards, int boost) 
            => IsSpeciesSatisfied(raid, StoryProgress) && 
            IsStarsSatisfied(raid, StoryProgress) && 
            IsIVsSatisfied(raid, StoryProgress, EventProgress) && 
            IsShinySatisfied(raid) && IsNatureSatisfied(raid, StoryProgress) && 
            IsGenderSatisfied(raid, StoryProgress)&& IsTeraSatisfied(raid)&& 
            IsItemsSatisfied(raid, StoryProgress, EventProgress, fixed_rewards, lottery_rewards, Rfixed_rewards, Rlottery_rewards, boost);
      /*  public  bool FilterSatisfied(List<Raid> Raids, int StoryProgress, int EventProgress)
        {
            foreach (Raid raid in Raids)
            {
                if (FilterSatisfied(raid, StoryProgress,  EventProgress))
                    return true;
            }
            return false;
        }*/
    }
}
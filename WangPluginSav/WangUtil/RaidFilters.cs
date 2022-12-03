using PKHeX.Core;
using System.Collections.Generic;
using System.Runtime;

namespace WangPluginSav
{
    public  class RaidFilters
    {
        public  Species? Species =null;
        public  int? Stars = null;
        public  bool Shiny;
        public  Nature? Nature =  null;
        public Gender? Gender = null;
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
            if (Gender == PKHeX.Core.Gender.Random)
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
            return (Gender)blank.Gender == Gender;
        }
        public bool IsTeraSatisfied(Raid raid)
        {
           var Teratype =(MoveType)Raid.GetTeranType(raid.Seed);
            if (Tera == (MoveType)18)
                return true;
            return Teratype == Tera;
        }
        public  bool IsIVsSatisfied(Raid raid, int StoryProgress)
        {
            int StarCount = Raid.GetStarCount(raid.Difficulty, StoryProgress, raid.IsBlack);
            var ivs = raid.GetIVs(raid.Seed, StarCount - 1);
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

        public  bool FilterSatisfied(Raid raid, int StoryProgress) => IsSpeciesSatisfied(raid, StoryProgress) && IsStarsSatisfied(raid, StoryProgress) && IsIVsSatisfied(raid, StoryProgress) && IsShinySatisfied(raid) && IsNatureSatisfied(raid, StoryProgress) && IsGenderSatisfied(raid, StoryProgress)&& IsTeraSatisfied(raid);
        public  bool FilterSatisfied(List<Raid> Raids, int StoryProgress, int EventProgress)
        {
            foreach (Raid raid in Raids)
            {
                if (FilterSatisfied(raid, StoryProgress))
                    return true;
            }
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WangPluginSav.WangDataBase
{
    internal class TeraPKMList
    {
       public List<TeraRaidPKMClass> OneStar()
        {
            List<TeraRaidPKMClass> a = new();
            TeraRaidPKMClass Pichu = new TeraRaidPKMClass()
            {
                Name = "皮丘",
                Species = 172,
                Star = 1,
            };
            a.Add(Pichu);
            return a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WangPluginSav
{
    public class SVTeraRaidPKM
    {
       public uint EC { get; set; }

       public uint PID { get; set; }

        public int[]? IVS { get; set; }

        public ulong Ability { get; set; }

        public ulong Nature { get; set; }

        public int hp { get; set; }

        public int def { get; set; }
         public int atk { get; set; }
        public int spa { get; set; }
        public int spd { get; set; }
        public int spe { get; set; }

        public bool isshiny { get; set; }
         
        public int diff { get; set;}

        public int shiny { get; set; }

        public int Species { get; set; }

        public uint Tera { get; set; } 
    }
}

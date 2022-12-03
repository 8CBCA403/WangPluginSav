using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WangPluginSav.Plugins
{
    internal class BWNPC_Plugin: WangPluginSav
    {

       protected void Open()
        {
            var sav = SaveFileEditor.SAV;
            var game = (GameVersion)sav.Game;
            if ( !GameVersion.Gen5.Contains(game))
                return;
            var frm = new BWNPCForm(SaveFileEditor);
            frm.Show();
        }

      
    }
    
}

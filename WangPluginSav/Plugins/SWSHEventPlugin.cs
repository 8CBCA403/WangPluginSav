using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WangPluginSav.GUI;

namespace WangPluginSav.Plugins
{
    internal class SWSHEventPlugin : WangPluginSav
    {
        public override string Name => "剑盾事件修改器";
        public override int Priority => 4;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.SWSH
            };
#pragma warning disable CS8622
            ctrl.Click += OpenForm;
            ctrl.Name = "剑盾事件修改器";
            modmenu.DropDownItems.Add(ctrl);

        }

        private void OpenForm(object sender, EventArgs e)
        {
            if (SaveFileEditor.SAV.Version != GameVersion.SH
               && SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SWSH)
            {
                MessageBox.Show("此工具只适用于剑盾！");
                return;
            }
            if(SaveFileEditor.SAV.OT=="PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new WorldEventsForm(WorldEventsForm.Pages.Main, SaveFileEditor);
            
            form.Show();
        }

    }
}

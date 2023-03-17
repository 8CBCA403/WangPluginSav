using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WangPluginSav.GUI;
using WC3Tool;

namespace WangPluginSav.Plugins
{
    internal class Gen3EventPlugin : WangPluginSav
    {
        public override string Name => "Gen3事件修改器";
        public override int Priority => 0;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.Gen3SAV
            };
            var MirageIsland = new ToolStripMenuItem("幻影岛修改器")
            {
                Image = Properties.Resources.MirageIsland
            };
            var WC3Tool = new ToolStripMenuItem("神秘礼物编辑器")
            {
                Image = Properties.Resources.MysteryGift
            };
#pragma warning disable CS8622
            MirageIsland.Click += OpenFormMirageIsland;
            WC3Tool.Click += OpenFormWC3Tool;
            ctrl.Name = "Gen3事件修改器";
            ctrl.DropDownItems.Add(MirageIsland);
            ctrl.DropDownItems.Add(WC3Tool);
            modmenu.DropDownItems.Add(ctrl);

        }

        private void OpenFormMirageIsland(object sender, EventArgs e)
        {
            if (SaveFileEditor.SAV.Version != GameVersion.E
              && SaveFileEditor.SAV.Version != GameVersion.R 
              && SaveFileEditor.SAV.Version != GameVersion.S
               && SaveFileEditor.SAV.Version != GameVersion.RSE
               && SaveFileEditor.SAV.Version != GameVersion.RS)
            {
                MessageBox.Show("此工具只适用于宝石版本！");
                return;
            }
            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new MirageIslandForm((PKHeX.Core.SAV3)SaveFileEditor.SAV);

            form.Show();
        }
        private void OpenFormWC3Tool(object sender, EventArgs e)
        {
            if (SaveFileEditor.SAV.Version != GameVersion.E
              && SaveFileEditor.SAV.Version != GameVersion.R
              && SaveFileEditor.SAV.Version != GameVersion.S
               && SaveFileEditor.SAV.Version != GameVersion.RSE
               && SaveFileEditor.SAV.Version != GameVersion.RS)
            {
                MessageBox.Show("此工具只适用于宝石版本！");
                return;
            }
            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new MainScreen(new WC3Tool.SAV3(SaveFileEditor.SAV.Data));

            form.Show();
        }
    }

}

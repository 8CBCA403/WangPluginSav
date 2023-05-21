using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WangPluginSav.GUI;

namespace WangPluginSav.Plugins
{
    public class Gen9EventPlugin : WangPluginSav
    {
        public override string Name => "Gen9事件修改器";
        public override int Priority => 7;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.SV
            };
            var SVTera = new ToolStripMenuItem("太晶坑修改器")
            {
                Image = Properties.Resources.Tera
            };
            var Vivillon = new ToolStripMenuItem("彩粉蝶修改器")
            {
                Image = Properties.Resources.F18_Fancy
            };
#pragma warning disable CS8622
            SVTera.Click += SVTeraOpenForm;
            SVTera.Name = "太晶坑修改器";
            Vivillon.Click += VivillonOpenForm;
            Vivillon.Name = "彩粉蝶修改器";
            ctrl.DropDownItems.Add(SVTera);
            ctrl.DropDownItems.Add(Vivillon);
            modmenu.DropDownItems.Add(ctrl);

        }

        private void SVTeraOpenForm(object sender, EventArgs e)
        {
            if (SaveFileEditor.SAV.Version != GameVersion.SL
              && SaveFileEditor.SAV.Version != GameVersion.SV && SaveFileEditor.SAV.Version != GameVersion.VL)
            {
                MessageBox.Show("此工具只适用于朱紫！");
                return;
            }
            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new SVTeraRaidForm(SaveFileEditor, PKMEditor);

            form.Show();
        }

        private void VivillonOpenForm(object sender, EventArgs e)
        {
            if (SaveFileEditor.SAV.Version != GameVersion.SL
              && SaveFileEditor.SAV.Version != GameVersion.SV && SaveFileEditor.SAV.Version != GameVersion.VL)
            {
                MessageBox.Show("此工具只适用于朱紫！");
                return;
            }
            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new VivillonForm((SAV9SV)SaveFileEditor.SAV);

            form.Show();
        }

    }
}

using PKHeX.Core;
using WangPluginSav.GUI;

namespace WangPluginSav.Plugins
{
    internal class SVTeraRaidPlugin:WangPluginSav
    {
        public override string Name => "太晶坑修改器";
        public override int Priority => 6;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.Tera
            };
#pragma warning disable CS8622
            ctrl.Click += OpenForm;
            ctrl.Name = "太晶坑修改器";
            modmenu.DropDownItems.Add(ctrl);

        }

        private void OpenForm(object sender, EventArgs e)
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
            var form = new SVTeraRaidForm(SaveFileEditor,PKMEditor);
           
            form.Show();
        }



    }
}

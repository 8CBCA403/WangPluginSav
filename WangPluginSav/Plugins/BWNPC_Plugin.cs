using PKHeX.Core;
using WangPluginSav.GUI;

namespace WangPluginSav.Plugins
{
    internal class BWNPC_Plugin: WangPluginSav
    {

        public override string Name => "黑城白森NPC修改器";
        public override int Priority => 1;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.BW
            };
#pragma warning disable CS8622
            ctrl.Click += OpenForm;
            ctrl.Name = "黑城白森NPC修改器";
            modmenu.DropDownItems.Add(ctrl);

        }

        private void OpenForm(object sender, EventArgs e)
        {
            if (SaveFileEditor.SAV.Version != GameVersion.B
               && SaveFileEditor.SAV.Version != GameVersion.W && SaveFileEditor.SAV.Version != GameVersion.BW)
            {
                MessageBox.Show("此工具只适用于黑白！");
                return;
            }
            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new BWNPCForm(SaveFileEditor);
           
            form.Show();
        }


    }
    
}

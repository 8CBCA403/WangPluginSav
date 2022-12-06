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
            ctrl.Click += OpenForm;
            ctrl.Name = "黑城白森NPC修改器";
            modmenu.DropDownItems.Add(ctrl);

        }

        private void OpenForm(object sender, EventArgs e)
        {

            var form = new BWNPCForm(SaveFileEditor);
            form.Show();
        }


    }
    
}

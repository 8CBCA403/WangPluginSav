using WangPluginSav.GUI;

namespace WangPluginSav.Plugins
{
    internal class SVTeraRaidSeedCalcPlugin:WangPluginSav
    {
        public override string Name => "太晶坑修改器";
        public override int Priority => 0;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.Tera
            };
            ctrl.Click += OpenForm;
            ctrl.Name = "太晶坑修改器";
            modmenu.DropDownItems.Add(ctrl);

        }

        private void OpenForm(object sender, EventArgs e)
        {

            var form = new SVTeraRaidSeedCalcForm(SaveFileEditor,PKMEditor);
            form.Show();
        }



    }
}

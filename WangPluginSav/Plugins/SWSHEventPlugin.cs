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
            ctrl.Click += OpenForm;
            ctrl.Name = "剑盾事件修改器";
            modmenu.DropDownItems.Add(ctrl);

        }

        private void OpenForm(object sender, EventArgs e)
        {

            using (WorldEventsForm form = new WorldEventsForm(WorldEventsForm.Pages.Main,SaveFileEditor))
            {
                form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
                form.ShowDialog();
            }
        }

    }
}

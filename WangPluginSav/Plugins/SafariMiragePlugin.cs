using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYORAS_Safari_Mirage_Tool;

namespace WangPluginSav.Plugins
{
    public class SafariMiragePlugin : WangPluginSav
    {
        public override string Name => "XYORAS幻岛修改器";
        public override int Priority => 3;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.XY
            };
#pragma warning disable CS8622
            ctrl.Click += OpenForm;
            ctrl.Name = "XYORAS幻岛修改器";
            modmenu.DropDownItems.Add(ctrl);

        }

        private void OpenForm(object sender, EventArgs e)
        {
            if (!(SaveFileEditor.SAV is SAV6XY or SAV6AO ))
            {
                MessageBox.Show("此工具只适用于第六世代版本！");
                return;
            }

            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new SafariMirageForm();

            form.Show();
        }
    }
}

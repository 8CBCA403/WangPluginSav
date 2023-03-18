using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WangPluginSav.Plugins
{
    internal class FeebasLocatorPlugin : WangPluginSav
    {
        public override string Name => "丑丑鱼钓点修改器";
        public override int Priority =>1;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.Feebas
            };
#pragma warning disable CS8622
            ctrl.Click += OpenForm;
            ctrl.Name = "丑丑鱼钓点修改器";
            modmenu.DropDownItems.Add(ctrl);

        }

        private void OpenForm(object sender, EventArgs e)
        {
            if (!(SaveFileEditor.SAV is SAV3RS or  SAV3E or SAV4DP or SAV4Pt))
            {
                MessageBox.Show("此工具只适用于宝石和珍钻白金版本！");
                return;
            }
           
            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new  FeebasLocatorForm(SaveFileEditor.SAV);

            form.Show();
        }



    }
}

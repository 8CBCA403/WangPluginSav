using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BW_tool;
using WangPluginSav.GUI;
using LTDCE;

namespace WangPluginSav.Plugins
{
    public class Gen5EventPlugin : WangPluginSav
    {
        public override string Name => "Gen5事件修改器";
        public override int Priority => 2;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.Gen5SAV
            };
            var BWNPC = new ToolStripMenuItem("黑城白森NPC修改器")
            {
                Image = Properties.Resources.BW
            };
            var BWTool = new ToolStripMenuItem("BWTool")
            {
                Image = Properties.Resources.BWTool
            };
            var LTDCE = new ToolStripMenuItem("自由船票编辑器")
            {
                Image = Properties.Resources.liberty
            };
            ctrl.DropDownItems.Add(BWTool);
            ctrl.DropDownItems.Add(BWNPC);
            ctrl.DropDownItems.Add(LTDCE);
#pragma warning disable CS8622
            BWTool.Click += BWToolOpenForm;
            BWNPC.Click += BWNPCOpenForm;
            LTDCE.Click += LTDCEOpenForm;
            ctrl.Name = "Gen5事件修改器";
            modmenu.DropDownItems.Add(ctrl);

        }
        private void BWNPCOpenForm(object sender, EventArgs e)
        {
            if (SaveFileEditor.SAV.Version != GameVersion.B
               && SaveFileEditor.SAV.Version != GameVersion.W && SaveFileEditor.SAV.Version != GameVersion.BW)
            {
                MessageBox.Show("此工具只适用于黑白版本！");
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
        private void BWToolOpenForm(object sender, EventArgs e)
        {
            if (!(SaveFileEditor.SAV is SAV5BW or SAV5B2W2))
            {
                MessageBox.Show("此工具只适用于黑白,黑二白二版本！");
                return;
            }

            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new BWToolMainForm(SaveFileEditor.SAV.Data);

            form.Show();
        }
        private void LTDCEOpenForm(object sender, EventArgs e)
        {
            if (!(SaveFileEditor.SAV is SAV5BW or SAV5B2W2))
            {
                MessageBox.Show("此工具只适用于黑白,黑二白二版本！");
                return;
            }
            var form = new LTDCEForm();
            form.Show();
        }

    }
}

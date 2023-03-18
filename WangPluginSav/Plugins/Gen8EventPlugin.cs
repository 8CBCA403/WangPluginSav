using NPCmonEditor;
using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NXWonderRecord;

namespace WangPluginSav.Plugins
{
    internal class Gen8EventPlugin : WangPluginSav
    {
        public override string Name => "Gen8事件修改器";
        public override int Priority => 5;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.Gen8Editor
            };
            var SWSHEventEditor = new ToolStripMenuItem("剑盾事件修改器")
            {
                Image = Properties.Resources.SWSH
            };
            var LANPCmonEditor = new ToolStripMenuItem("阿尔宙斯NPC修改器")
            {
                Image = Properties.Resources.Arceus
            };
            var NXWREditor = new ToolStripMenuItem("第八世代神秘礼物导入器")
            {
                Image = Properties.Resources.Gen8Gift
            };
#pragma warning disable CS8622
            LANPCmonEditor.Click += LANPCOpenForm;
            LANPCmonEditor.Name = "阿尔宙斯NPC修改器";
            NXWREditor.Click += NXWROpenForm;
            NXWREditor.Name = "第八世代神秘礼物导入器";
            modmenu.DropDownItems.Add(ctrl);
            SWSHEventEditor.Name = "剑盾事件修改器";
#pragma warning disable CS8622
            SWSHEventEditor.Click += SWSHOpenForm;
            ctrl.DropDownItems.Add(SWSHEventEditor);
            ctrl.DropDownItems.Add(LANPCmonEditor);
            ctrl.DropDownItems.Add(NXWREditor);
            ctrl.Name = "Gen8事件修改器";
            modmenu.DropDownItems.Add(ctrl);

        }

        private void SWSHOpenForm(object sender, EventArgs e)
        {
            if (SaveFileEditor.SAV.Version != GameVersion.SH
               && SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SWSH)
            {
                MessageBox.Show("此工具只适用于剑盾！");
                return;
            }
            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new WorldEventsForm(WorldEventsForm.Pages.Main, SaveFileEditor);

            form.Show();
        }
        private void LANPCOpenForm(object sender, EventArgs e)
        {
            if (!(SaveFileEditor.SAV is SAV8LA))
            {
                MessageBox.Show("此工具只适用于阿尔宙斯版本！");
                return;
            }

            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            var form = new NPCmonEditorForm(SaveFileEditor.SAV, PKMEditor);

            form.Show();
        }
        private void NXWROpenForm(object sender, EventArgs e)
        {
            if (SaveFileEditor.SAV.OT == "PKHeX")
            {
                MessageBox.Show("检测到空档，请导入有效存档");
                return;
            }
            GameVersion version = SaveFileEditor.SAV.Version;
            if (version == GameVersion.SW || version == GameVersion.SH)
            {
                new WonderRecordSWSH(SaveFileEditor.SAV).Show();
                return;
            }

           else if (version == GameVersion.GP || version == GameVersion.GE)
            {
                new WonderRecordLGPE(SaveFileEditor.SAV).Show();
                return;
            }

           else if (version == GameVersion.BD || version == GameVersion.SP)
            {
                new WonderRecordBDSP(SaveFileEditor.SAV).Show();
            }
            else if (SaveFileEditor.SAV.Version == GameVersion.PLA)
            {
                new WonderRecordPLA(SaveFileEditor.SAV).Show();
            }
            else
            {
                    MessageBox.Show("此工具只适用于第八世代！");
                    return;
                
            }
        }
    }
}

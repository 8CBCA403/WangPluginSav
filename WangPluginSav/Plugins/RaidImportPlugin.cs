using Microsoft.VisualBasic;
using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WangPluginSav.BlockImportUtil;

namespace WangPluginSav.Plugins
{
    internal class RaidImportPlugin : WangPluginSav
    {
        public override string Name => "Raid导入器";
        public override int Priority => 3;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.Raid
            };
            ctrl.Click += delegate
            {
                ImportRaid();
            };
            ctrl.Name = "Raid导入器";
            modmenu.DropDownItems.Add(ctrl);

        }
        private void ImportRaid()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string raidPath = dialog.SelectedPath;
                IReadOnlyList<Block> blocks = null!;
                if (SaveFileEditor.SAV is SAV8SWSH sav8SwSh)
                {
                    if (sav8SwSh.SaveRevision == 0) blocks = SWSHRaidConstants.BaseGameBlocks;
                    else if (sav8SwSh.SaveRevision == 1) blocks = SWSHRaidConstants.IsleOfArmorBlocks;
                    else if (sav8SwSh.SaveRevision == 2) blocks = SWSHRaidConstants.CrownTundraBlocks;
                }
                else if (SaveFileEditor.SAV is SAV9SV)
                {
                    raidPath += @"\Files";
                    blocks = SVRaidConstants.BaseGameBlocks;
                }
                ImportRaid(raidPath, (dynamic)SaveFileEditor.SAV, blocks);
            }
        }
        private static void ImportRaid<S>(string raidPath, S sav, IReadOnlyList<Block> blocks) where S : SaveFile, ISCBlockArray, ISaveFileRevision
        {
            string RaidFilePath(string file) => $@"{raidPath}\{file}";
            if (blocks.All(b => File.Exists(RaidFilePath(b.Path))))
            {
                foreach ((uint blockLocation, string file) in blocks)
                    sav.Accessor.GetBlock(blockLocation).ChangeData(File.ReadAllBytes(RaidFilePath(file)));
                sav.State.Edited = true;
                MessageBox.Show("Raid导入成功", "Raid导入器");
            }
            else
            {
                MessageBox.Show($@"确保所有必需的文件都在{raidPath}", "Raid导入器", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

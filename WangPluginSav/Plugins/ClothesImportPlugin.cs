using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WangPluginSav.GUI;

namespace WangPluginSav.Plugins
{
    internal class ClothesImportPlugin:WangPluginSav
    {
        public override string Name => "服装导入器";
        public override int Priority => 2;

        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.Clothes
            };
            ctrl.Click += delegate
            {
                ImportClothes();
            };
            ctrl.Name = "服装导入器";
            modmenu.DropDownItems.Add(ctrl);

        }

        private void ImportClothes()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                IReadOnlyList<Block>? readOnlyList = null;
                if (SaveFileEditor.SAV is SAV9SV)
                {
                    readOnlyList = SVClothesConstants.ClothesBlocks;
                }
                else if (SaveFileEditor.SAV is SAV8LA)
                {
                    readOnlyList = LAClothesConstants.ClothesBlocks;
                }
                ImportClothes(selectedPath, (dynamic)SaveFileEditor.SAV, readOnlyList);
            }
        }

        private static void ImportClothes<S>(string ClothesPath, S sav, IReadOnlyList<Block> blocks) where S : SaveFile, ISCBlockArray, ISaveFileRevision
        {
            string ClothesPath2 = ClothesPath;
            if (blocks.All((Block b) => File.Exists(ClothesFilePath(b.Path))))
            {
                foreach (var (key, file2) in blocks)
                {
                    sav.Accessor.GetBlock(key).ChangeData(File.ReadAllBytes(ClothesFilePath(file2)));
                }
                sav.State.Edited = true;
                MessageBox.Show("服装导入成功", "服装导入器");
            }
            else
            {
                MessageBox.Show("确保所有必需的文件都在 " + ClothesPath2, "服装导入器", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            string ClothesFilePath(string file)
            {
                return ClothesPath2 + "\\" + file;
            }
        }
    }
}

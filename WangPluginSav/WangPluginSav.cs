using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PKHeX.Core;
using WangPluginSav.GUI;

namespace WangPluginSav
{
    public abstract class WangPluginSav : IPlugin
    {
        public string Name => "超王插件SAV";
        public int Priority => 1;

        private ToolStripMenuItem WangPlugin = new();

        public ISaveFileProvider SaveFileEditor { get; private set; } = null!;
        public IPKMView PKMEditor { get; private set; } = null!;

        public void Initialize(params object[] args)
        {
          
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider);
            PKMEditor = (IPKMView)Array.Find(args, z => z is IPKMView);
            var menu = (ToolStrip)Array.Find(args, z => z is ToolStrip);
            LoadMenuStrip(menu);
        }

        private void LoadMenuStrip(ToolStrip menuStrip)
        {
            var items = menuStrip.Items;
            if (!(items.Find("Menu_Tools", false)[0] is ToolStripDropDownItem tools))
                throw new ArgumentException(nameof(menuStrip));
            AddPluginControl(tools);
        }

        private void AddPluginControl(ToolStripDropDownItem tools)
        {
            var frm = new SVTeraRaidSeedCalcForm(SaveFileEditor, PKMEditor);
            var frm1 = new BWNPCForm(SaveFileEditor);
            var ctrl = new ToolStripMenuItem(Name)
            {
                Image = Properties.Resources.WangPluginSav,
                Name = "超王插件SAV",
             };
            tools.DropDownItems.Insert(1, ctrl);
            var c2 = new ToolStripMenuItem($"朱紫太晶坑Seed生成器")
            {
                Image = Properties.Resources.Tera,
             };
            c2.Click += (s, e) => frm.Show();
            var c3 = new ToolStripMenuItem($"黑白黑城白森NPC修改器")
            {
                Image = Properties.Resources.BW,
             };
            c3.Click += (s, e) => frm1.Show();
            ctrl.DropDownItems.Add(c2);
            ctrl.DropDownItems.Add(c3);
        }
      
        

        public void NotifySaveLoaded()
        {
            Console.WriteLine($"{Name} was notified that a Save File was just loaded.");
            if (WangPlugin == null)
                return;
        }
        public bool TryLoadFile(string filePath)
        {
            Console.WriteLine($"{Name} was provided with the file path, but chose to do nothing with it.");
            return false; // no action taken
        }
    }
}

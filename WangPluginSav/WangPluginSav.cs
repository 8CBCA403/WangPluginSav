using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PKHeX.Core;

namespace WangPluginSav
{
    public abstract class WangPluginSav : IPlugin
    {
        private const string ParentMenuParent = "Menu_Tools";
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
            if (items.Find(ParentMenuParent, false)[0] is not ToolStripDropDownItem tools)
                return;
            WangPlugin = new ToolStripMenuItem(Name) 
            { 
                Visible = true ,
                Image = Properties.Resources.WangPluginSav
                
            };
            WangPlugin.Click += (s, e) => Open();
            tools.DropDownItems.Insert(1,WangPlugin);
        }
        protected abstract void Open();
        

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

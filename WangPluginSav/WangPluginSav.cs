using PKHeX.Core;
using WangPluginSav.Util.EventFlags;
namespace WangPluginSav
{
    public abstract class WangPluginSav : IPlugin
    {
        private const string ParentMenuName = "SuperWangSav";
        private const string ParentMenuText = "超王插件SAV";
        private const string ParentMenuParent = "Menu_Tools";
        public abstract string Name { get; }
        public abstract int Priority { get; }
        public ISaveFileProvider SaveFileEditor { get; private set; } = null!;
        public IPKMView PKMEditor { get; private set; } = null!;
        public object[]? globalArgs;

        public void Initialize(params object[] args)
        {
            globalArgs = args;
            LocalizedStrings.Initialize(GameInfo.CurrentLanguage);
#pragma warning disable CS8601 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider);
            PKMEditor = (IPKMView)Array.Find(args, z => z is IPKMView);
            var menu = (ToolStrip)Array.Find(args, z => z is ToolStrip);
            if (menu != null)
                LoadMenuStrip(menu);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8601 // Converting null literal or possible null value to non-nullable type.

        }
        private void LoadMenuStrip(ToolStrip menuStrip)
        {
            var items = menuStrip.Items;
            if (items.Find(ParentMenuParent, false)[0] is not ToolStripDropDownItem tools)
                return;
            var toolsitems = tools.DropDownItems;
            var modmenusearch = toolsitems.Find(ParentMenuName, false);
            var modmenu = GetModMenu(tools, modmenusearch);
            AddPluginControl(modmenu);
        }
        private static ToolStripMenuItem GetModMenu(ToolStripDropDownItem tools, IReadOnlyList<ToolStripItem> search)
        {
            if (search.Count != 0)
                return (ToolStripMenuItem)search[0];

            var modmenu = CreateBaseGroupItem();
            tools.DropDownItems.Insert(1, modmenu);
            return modmenu;
        }

        private static ToolStripMenuItem CreateBaseGroupItem() => new(ParentMenuText)
        {
            Image = Properties.Resources.WangPluginSav,
            Name = ParentMenuName,
        };
        protected abstract void AddPluginControl(ToolStripDropDownItem modmenu);
        public abstract void NotifySaveLoaded();
        public bool TryLoadFile(string filePath)
        {
            return false; // no action taken
        }
    }
}

using WangPluginSav.Util.EventFlags;

namespace WangPluginSav.Plugins
{
    public class FlagEventsEX : WangPluginSav
    {
        public override string Name => "超绝の事件旗标修改器";
        public override int Priority => 8;
        private ToolStripMenuItem? ctrl;


        private ToolStripMenuItem? menuEntry_EditFlags;
        private ToolStripMenuItem? menuEntry_DumpAllFlags;
        protected override void AddPluginControl(ToolStripDropDownItem modmenu)
        {

            ctrl = new ToolStripMenuItem(Name);
            ctrl.Enabled = true;
            modmenu.DropDownItems.Add(ctrl);

            menuEntry_DumpAllFlags = new ToolStripMenuItem(LocalizedStrings.Find("FlagsEditorEX.menuEntry_DumpAllFlags", "Dump all Flags"));
            menuEntry_DumpAllFlags.Enabled = true;
            menuEntry_DumpAllFlags.Click += DumpAllFlags_UIEvt;
            ctrl.DropDownItems.Add(menuEntry_DumpAllFlags);

            menuEntry_EditFlags = new ToolStripMenuItem(LocalizedStrings.Find("FlagsEditorEX.menuEntry_EditFlags", "Edit flags..."));
            menuEntry_EditFlags.Enabled = true;
            menuEntry_EditFlags.Click += EditFlags_UIEvt;
            ctrl.DropDownItems.Add(menuEntry_EditFlags);

        }
        private void DumpAllFlags_UIEvt(object? sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text File|*.txt",
                FileName = string.Format("flags_dump_{0}.txt", SaveFileEditor.SAV.Version),
            };
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var flagsOrganizer = FlagsOrganizer.CreateFlagsOrganizer(SaveFileEditor.SAV, resData: null);
                System.IO.File.WriteAllText(saveFileDialog.FileName, flagsOrganizer.DumpAllFlags());
            }
            saveFileDialog.Dispose();
        }

        private void EditFlags_UIEvt(object? sender, EventArgs e)
        {
            var flagsOrganizer = FlagsOrganizer.CreateFlagsOrganizer(SaveFileEditor.SAV, resData: null);
            var form = new MainWin(flagsOrganizer);
            form.ShowDialog();
            form.Dispose();
        }

        public override void NotifySaveLoaded()
        {
            /*   ctrl!.Enabled = true;
               menuEntry_DumpAllFlags!.Enabled = true;
               menuEntry_EditFlags!.Enabled = true;

               var savData = SaveFileEditor.SAV;

               // Prevent usage if state is not Exportable
               if (!savData.State.Exportable)
               {
                   ctrl.Enabled = false;
                   return;
               }

               ctrl.Enabled = savData.Version switch
               {
                   GameVersion.Any or
                   GameVersion.RBY or
                   GameVersion.StadiumJ or
                   GameVersion.Stadium or
                   GameVersion.Stadium2 or
                   GameVersion.RSBOX or
                   GameVersion.COLO or
                   GameVersion.XD or
                   GameVersion.CXD or
                   GameVersion.BATREV or
                   GameVersion.ORASDEMO or
                   GameVersion.GO or
                   GameVersion.Unknown or
                   GameVersion.Invalid
                       => false,

                   // Check for AS Demo
                   GameVersion.AS
                       => savData is not SAV6AODemo,

                   // Check for SN Demo
                   GameVersion.SN
                       // Can't have a renamed box which is locked in non-demo version
                       => !(((SAV7SM)savData).BoxLayout.BoxesUnlocked == 8 && string.IsNullOrWhiteSpace(((SAV7SM)savData).BoxLayout.GetBoxName(10))),

                   _ => true
               };

   #if DEBUG
               // Quick dump all flags on load during DEBUG
               if (ctrl.Enabled)
               {
                   var flagsOrganizer = FlagsOrganizer.CreateFlagsOrganizer(SaveFileEditor.SAV, resData: null);
                   System.IO.File.WriteAllText(string.Format("flags_dump_{0}.txt", SaveFileEditor.SAV.Version), flagsOrganizer.DumpAllFlags());
               }
   #endif*/
        }



    }
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace WC3Tool;

partial class WC3_editor_givegg : Form
{
    public WC3_editor_givegg()
    {
        InitializeComponent();
        game_box.SelectedIndex = 0;
        lang_box.SelectedIndex = 1;
        species_box.SelectedIndex = 172;
        move_box.SelectedIndex = 57;
    }

    private void Save_butClick(object sender, EventArgs e)
    {
        string text = ((game_box.SelectedIndex != 1) ? "E" : "FR");
        string text2 = "Eng";
        switch (lang_box.SelectedIndex)
        {
            case 0:
                text2 = "Jap";
                break;
            case 1:
                text2 = "Eng";
                break;
            case 2:
                text2 = "Fre";
                break;
            case 3:
                text2 = "Ita";
                break;
            case 4:
                text2 = "Deu";
                break;
            case 5:
                text2 = "Esp";
                break;
        }
        byte[] array = (byte[])new ResourceManager("WangPluginSav.GiveEggOrg", Assembly.GetExecutingAssembly()).GetObject("ROM_" + text + "_GiveEgg_" + text2);
        ushort value = (ushort)move_box.SelectedIndex;
        BitConverter.GetBytes(value).ToArray().CopyTo(array, 134);
        BitConverter.GetBytes(value).ToArray().CopyTo(array, 140);
        BitConverter.GetBytes(value).ToArray().CopyTo(array, 146);
        BitConverter.GetBytes(value).ToArray().CopyTo(array, 152);
        BitConverter.GetBytes(value).ToArray().CopyTo(array, 158);
        BitConverter.GetBytes((ushort)species_box.SelectedIndex).ToArray().CopyTo(array, 66);
        WC3_editor.wc3file.set_script(array);
        WC3_editor.script_injected = true;
        Close();
    }

    private void Cancel_butClick(object sender, EventArgs e)
    {
        Close();
    }


}

using System.Reflection;
using System.Resources;
namespace WC3Tool;
partial class WC3_editor_giveggExt : Form
{
    public WC3_editor_giveggExt()
    {
        InitializeComponent();
        game_box.SelectedIndex = 0;
        lang_box.SelectedIndex = 1;
        species_box.SelectedIndex = 172;
        move_box.SelectedIndex = 57;
        move2.SelectedIndex = 57;
        move3.SelectedIndex = 57;
        move4.SelectedIndex = 57;
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
        ResourceManager resourceManager = new ResourceManager("WangPluginSav.GiveEggOrg", Assembly.GetExecutingAssembly());
        byte[] array = ((!killscript.Checked) ? ((byte[])resourceManager.GetObject("ROM_" + text + "_GiveEgg_" + text2 + "_4moves")) : ((byte[])resourceManager.GetObject("ROM_" + text + "_GiveEgg_" + text2 + "_4moves_kill")));
        int num = 4;
        if (killscript.Checked)
        {
            array[5 + num] = 0;
            num -= 15;
        }
        ushort value = (ushort)move_box.SelectedIndex;
        BitConverter.GetBytes(value).ToArray().CopyTo(array, 177 + num);
        BitConverter.GetBytes(value).ToArray().CopyTo(array, 199 + num);
        BitConverter.GetBytes(value).ToArray().CopyTo(array, 221 + num);
        BitConverter.GetBytes(value).ToArray().CopyTo(array, 243 + num);
        BitConverter.GetBytes(value).ToArray().CopyTo(array, 265 + num);
        num += 5;
        ushort value2 = (ushort)move2.SelectedIndex;
        BitConverter.GetBytes(value2).ToArray().CopyTo(array, 177 + num);
        BitConverter.GetBytes(value2).ToArray().CopyTo(array, 199 + num);
        BitConverter.GetBytes(value2).ToArray().CopyTo(array, 221 + num);
        BitConverter.GetBytes(value2).ToArray().CopyTo(array, 243 + num);
        BitConverter.GetBytes(value2).ToArray().CopyTo(array, 265 + num);
        num += 5;
        ushort value3 = (ushort)move3.SelectedIndex;
        BitConverter.GetBytes(value3).ToArray().CopyTo(array, 177 + num);
        BitConverter.GetBytes(value3).ToArray().CopyTo(array, 199 + num);
        BitConverter.GetBytes(value3).ToArray().CopyTo(array, 221 + num);
        BitConverter.GetBytes(value3).ToArray().CopyTo(array, 243 + num);
        BitConverter.GetBytes(value3).ToArray().CopyTo(array, 265 + num);
        num += 5;
        ushort value4 = (ushort)move4.SelectedIndex;
        BitConverter.GetBytes(value4).ToArray().CopyTo(array, 177 + num);
        BitConverter.GetBytes(value4).ToArray().CopyTo(array, 199 + num);
        BitConverter.GetBytes(value4).ToArray().CopyTo(array, 221 + num);
        BitConverter.GetBytes(value4).ToArray().CopyTo(array, 243 + num);
        BitConverter.GetBytes(value4).ToArray().CopyTo(array, 265 + num);
        ushort value5 = (ushort)species_box.SelectedIndex;
        if (killscript.Checked)
        {
            BitConverter.GetBytes(value5).ToArray().CopyTo(array, 97);
        }
        else
        {
            BitConverter.GetBytes(value5).ToArray().CopyTo(array, 112);
        }
        WC3_editor.wc3file.set_script(array.Skip(4).Take(996).ToArray());
        WC3_editor.script_injected = true;
        Close();
    }

    private void Cancel_butClick(object sender, EventArgs e)
    {
        Close();
    }

    private void Script_helpClick(object sender, EventArgs e)
    {
        MessageBox.Show("使用rom事件旗标：该脚本将使用在ROM中找到的用于标记已接收礼物蛋的事件旗标。神秘卡片将被发送，接收者将能够收到一个蛋（如果存档内的事件旗标未被标记）。" +
            "\n\n杀死脚本：存档内不会设置旗标，所以最终只会收到一个蛋。脚本会被从存档内删除，所以分享神秘卡片不会让接收者获得蛋。");
    }


}

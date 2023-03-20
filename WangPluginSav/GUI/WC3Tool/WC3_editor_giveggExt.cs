using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

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
		ResourceManager resourceManager = new ResourceManager("WC3Tool.WC3.GiveEggOrg", Assembly.GetExecutingAssembly());
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
		MessageBox.Show("Use rom event flag: the script will use the flag that the Egg event found in the ROM uses to mark the EGG as received. The wondercard will be able to be sent and the receiver will be able to receive an egg (if the savegame still has the flag unset).\n\nKillscript: no flags are set in the savegame, so the only outcome is that the egg is received. The script gets erased from the savegame, so sharing the wondercard won't allow receiver to get an egg.");
	}

	
}

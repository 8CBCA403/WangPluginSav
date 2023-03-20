using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WangPluginSav.Util.WC3.PKHeX;

namespace WC3Tool;

partial class ECT_pkedit : Form
{
	private int pk;



	
	public uint IV32
	{
		get
		{
			return BitConverter.ToUInt32(ECT_editor.ectfile.Data, pk + 24);
		}
		set
		{
			BitConverter.GetBytes(value).CopyTo(ECT_editor.ectfile.Data, 24);
		}
	}

	public int IV_HP
	{
		get
		{
			return (int)(IV32 & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -32) | ((value > 31) ? 31u : ((uint)value)));
		}
	}

	public int IV_ATK
	{
		get
		{
			return (int)((IV32 >> 5) & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -993) | (uint)(((value > 31) ? 31 : value) << 5));
		}
	}

	public int IV_DEF
	{
		get
		{
			return (int)((IV32 >> 10) & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -31745) | (uint)(((value > 31) ? 31 : value) << 10));
		}
	}

	public int IV_SPE
	{
		get
		{
			return (int)((IV32 >> 15) & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -1015809) | (uint)(((value > 31) ? 31 : value) << 15));
		}
	}

	public int IV_SPA
	{
		get
		{
			return (int)((IV32 >> 20) & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -32505857) | (uint)(((value > 31) ? 31 : value) << 20));
		}
	}

	public int IV_SPD
	{
		get
		{
			return (int)((IV32 >> 25) & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -1040187393) | (uint)(((value > 31) ? 31 : value) << 25));
		}
	}

	public int IV_Ability
	{
		get
		{
			return (int)((IV32 >> 31) & 1);
		}
		set
		{
			IV32 = (IV32 & 0x7FFFFFFFu) | ((value == 1) ? 2147483648u : 0u);
		}
	}

	public byte PPUP
	{
		get
		{
			return ECT_editor.ectfile.Data[pk + 13];
		}
		set
		{
			ECT_editor.ectfile.Data[pk + 13] = value;
		}
	}

	public int PPUP_1
	{
		get
		{
			return PPUP & 3;
		}
		set
		{
			PPUP = (byte)((PPUP & 0xFFFFFFFCu) | (byte)((value > 3) ? 3u : ((uint)value)));
		}
	}

	public int PPUP_2
	{
		get
		{
			return (PPUP >> 2) & 3;
		}
		set
		{
			PPUP = (byte)((PPUP & 0xFFFFFFF3u) | (byte)(((value > 3) ? 3 : value) << 2));
		}
	}

	public int PPUP_3
	{
		get
		{
			return (PPUP >> 4) & 3;
		}
		set
		{
			PPUP = (byte)((PPUP & 0xFFFFFFCFu) | (byte)(((value > 3) ? 3 : value) << 4));
		}
	}

	public int PPUP_4
	{
		get
		{
			return (PPUP >> 6) & 3;
		}
		set
		{
			PPUP = (byte)((PPUP & 0xFFFFFF3Fu) | (byte)(((value > 3) ? 3 : value) << 6));
		}
	}

	public ECT_pkedit(int index)
	{
		InitializeComponent();
		pid.Maximum = -1m;
		pk = 52 + index * 44;
		populate();
	}

	private void populate()
	{
		item_box.SelectedIndex = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 2, 2), 0);
		namebox.Text = PKM.getG3Str(ECT_editor.ectfile.getData(pk + 32, 11), jap_check.Checked);
		move1.SelectedIndex = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 4, 2), 0);
		move2.SelectedIndex = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 6, 2), 0);
		move3.SelectedIndex = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 8, 2), 0);
		move4.SelectedIndex = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 10, 2), 0);
		pp1.Value = PPUP_1;
		pp2.Value = PPUP_2;
		pp3.Value = PPUP_3;
		pp4.Value = PPUP_4;
		level.Value = ECT_editor.ectfile.Data[pk + 12];
		friendship.Value = ECT_editor.ectfile.Data[pk + 43];
		otid.Value = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 20, 2), 0);
		otsid.Value = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 22, 2), 0);
		pid.Value = BitConverter.ToUInt32(ECT_editor.ectfile.getData(pk + 28, 4), 0);
		ev1.Value = ECT_editor.ectfile.Data[pk + 14];
		ev2.Value = ECT_editor.ectfile.Data[pk + 15];
		ev3.Value = ECT_editor.ectfile.Data[pk + 16];
		ev4.Value = ECT_editor.ectfile.Data[pk + 17];
		ev5.Value = ECT_editor.ectfile.Data[pk + 18];
		ev6.Value = ECT_editor.ectfile.Data[pk + 19];
		iv1.Value = IV_HP;
		iv2.Value = IV_ATK;
		iv3.Value = IV_DEF;
		iv4.Value = IV_SPE;
		iv5.Value = IV_SPA;
		iv6.Value = IV_SPD;
		ability.Value = IV_Ability;
	}

	private void save_edits()
	{
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)item_box.SelectedIndex).ToArray(), pk + 2);
		ECT_editor.ectfile.setData(PKM.setG3Str(namebox.Text, jap_check.Checked), pk + 32);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)move1.SelectedIndex).ToArray(), pk + 4);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)move2.SelectedIndex).ToArray(), pk + 6);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)move3.SelectedIndex).ToArray(), pk + 8);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)move4.SelectedIndex).ToArray(), pk + 10);
		PPUP_1 = (int)pp1.Value;
		PPUP_2 = (int)pp1.Value;
		PPUP_3 = (int)pp1.Value;
		PPUP_4 = (int)pp1.Value;
		ECT_editor.ectfile.Data[pk + 12] = (byte)level.Value;
		ECT_editor.ectfile.Data[pk + 43] = (byte)friendship.Value;
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)otid.Value).ToArray(), pk + 20);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)otsid.Value).ToArray(), pk + 22);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((uint)pid.Value).ToArray(), pk + 28);
		ECT_editor.ectfile.Data[pk + 14] = (byte)ev1.Value;
		ECT_editor.ectfile.Data[pk + 15] = (byte)ev2.Value;
		ECT_editor.ectfile.Data[pk + 16] = (byte)ev3.Value;
		ECT_editor.ectfile.Data[pk + 17] = (byte)ev4.Value;
		ECT_editor.ectfile.Data[pk + 18] = (byte)ev5.Value;
		ECT_editor.ectfile.Data[pk + 19] = (byte)ev6.Value;
		IV_HP = (int)iv1.Value;
		IV_ATK = (int)iv1.Value;
		IV_DEF = (int)iv3.Value;
		IV_SPE = (int)iv4.Value;
		IV_SPA = (int)iv5.Value;
		IV_SPD = (int)iv6.Value;
		IV_Ability = (int)ability.Value;
	}

	private void CancelClick(object sender, EventArgs e)
	{
		Close();
	}

	private void SaveClick(object sender, EventArgs e)
	{
		save_edits();
		Close();
	}

	private void Jap_checkCheckedChanged(object sender, EventArgs e)
	{
		namebox.Text = PKM.getG3Str(ECT_editor.ectfile.getData(pk + 32, 11), jap_check.Checked);
	}


}

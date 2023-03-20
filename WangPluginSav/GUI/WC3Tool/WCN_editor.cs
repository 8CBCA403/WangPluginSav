using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using WangPluginSav.Util.WC3;

namespace WC3Tool;

partial class WCN_editor : Form
{
	public string wcnfilter = "Wonder News file|*.wn3|All Files (*.*)|*.*";

	public byte[] wcnbuffer = new byte[448];

	public static wc3 wcnfile;

	public bool japanese;

	private Graphics GFX;

	private ResourceManager resources = new ResourceManager("WC3Tool.WC3.Image.Cards", Assembly.GetExecutingAssembly());

	private Image bitmap;

	public WCN_editor()
	{
		InitializeComponent();
		regionlab.Text = "";
		GFX = CreateGraphics();
		colorbox.SelectedIndex = 0;
	}

	private void update_wcdata()
	{
		switch (wcnfile.distributable)
		{
		case 0:
			distrocheck.Checked = false;
			break;
		case 1:
			distrocheck.Checked = true;
			break;
		default:
			distrocheck.Checked = false;
			break;
		}
		colorbox.SelectedIndex = wcnfile.cardcolor;
		header1.Text = wcnfile.get_wn_text_2(0);
		body1.Text = wcnfile.get_wn_text_2(1);
		body2.Text = wcnfile.get_wn_text_2(2);
		body3.Text = wcnfile.get_wn_text_2(3);
		body4.Text = wcnfile.get_wn_text_2(4);
		body5.Text = wcnfile.get_wn_text_2(5);
		body6.Text = wcnfile.get_wn_text_2(6);
		body7.Text = wcnfile.get_wn_text_2(7);
		body8.Text = wcnfile.get_wn_text_2(8);
		body9.Text = wcnfile.get_wn_text_2(9);
		body10.Text = wcnfile.get_wn_text_2(10);
	}

	private void set_wcndata()
	{
		wcnfile.clear_wn_text();
		wcnfile.insert_wn_text_2(header1.Text, 0);
		wcnfile.insert_wn_text_2(body1.Text, 1);
		wcnfile.insert_wn_text_2(body2.Text, 2);
		wcnfile.insert_wn_text_2(body3.Text, 3);
		wcnfile.insert_wn_text_2(body4.Text, 4);
		wcnfile.insert_wn_text_2(body5.Text, 5);
		wcnfile.insert_wn_text_2(body6.Text, 6);
		wcnfile.insert_wn_text_2(body7.Text, 7);
		wcnfile.insert_wn_text_2(body8.Text, 8);
		wcnfile.insert_wn_text_2(body9.Text, 9);
		wcnfile.insert_wn_text_2(body10.Text, 10);
	}

	private void Load_WCN(string path)
	{
		int num = FileIO.load_file(ref wcnbuffer, ref path, wcnfilter);
		if (num == 448 || num == 228)
		{
			if (num == 228)
			{
				japanese = true;
				regionlab.Text = "JAP";
				header1.MaxLength = 20;
				body1.MaxLength = 20;
				body2.MaxLength = 20;
				body3.MaxLength = 20;
				body4.MaxLength = 20;
				body5.MaxLength = 20;
				body6.MaxLength = 20;
				body7.MaxLength = 20;
				body8.MaxLength = 20;
				body9.MaxLength = 20;
				body10.MaxLength = 20;
			}
			else
			{
				japanese = false;
				regionlab.Text = "USA/EUR";
				header1.MaxLength = 40;
				body1.MaxLength = 40;
				body2.MaxLength = 40;
				body3.MaxLength = 40;
				body4.MaxLength = 40;
				body5.MaxLength = 40;
				body6.MaxLength = 40;
				body7.MaxLength = 40;
				body8.MaxLength = 40;
				body9.MaxLength = 40;
				body10.MaxLength = 40;
			}
			wc3_path.Text = path;
			wcnfile = new wc3(wcnbuffer);
			update_wcdata();
			save_wc3_but.Enabled = true;
		}
		else
		{
			MessageBox.Show("Invalid file size.");
		}
	}

	private void Load_wc3_butClick(object sender, EventArgs e)
	{
		Load_WCN(null);
	}

	private void Save_wc3_butClick(object sender, EventArgs e)
	{
		int distro = 0;
		if (distrocheck.Checked)
		{
			distro = 1;
		}
		wcnfile.set_wcn_color_distro(colorbox.SelectedIndex, distro);
		set_wcndata();
		wcnfile.fix_wcn_checksum();
		FileIO.save_data(wcnfile.Data, wcnfilter);
	}

	private void WCN_editorLoad(object sender, EventArgs e)
	{
	}

	private void drawCard()
	{
		bitmap = (Image)resources.GetObject("News_" + colorbox.SelectedIndex);
		GFX.DrawImage(bitmap, 500, 166, 260, 140);
		GFX.DrawImage(bitmap, 500, 140, 260, 140);
		GFX.DrawString(header1.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 144f);
		GFX.DrawString(body1.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 161f);
		GFX.DrawString(body2.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 175f);
		GFX.DrawString(body3.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 189f);
		GFX.DrawString(body4.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 203f);
		GFX.DrawString(body5.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 217f);
		GFX.DrawString(body6.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 231f);
		GFX.DrawString(body7.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 245f);
		GFX.DrawString(body8.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 259f);
		GFX.DrawString(body9.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 273f);
		GFX.DrawString(body10.Text, new Font("Calibri", 8f), Brushes.Black, 507f, 287f);
	}

	private void ColorboxSelectedIndexChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Header1TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body1TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body2TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body3TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body4TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body5TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body6TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body7TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body8TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body9TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void Body10TextChanged(object sender, EventArgs e)
	{
		drawCard();
	}

	private void WCN_editorDragEnter(object sender, DragEventArgs e)
	{
		e.Effect = DragDropEffects.All;
	}

	private void WCN_editorDragDrop(object sender, DragEventArgs e)
	{
		string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, autoConvert: false);
		Load_WCN(array[0]);
	}

	
}

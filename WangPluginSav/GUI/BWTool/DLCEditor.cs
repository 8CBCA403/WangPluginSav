using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pikaedit;

public class DLCEditor : Form
{
	private Musical musical;

	private CgearSkin cgear;

	private PokedexSkin pokedex;

	private SaveFile.Version version;

	private IContainer components;

	private OpenFileDialog loadDialog;

	private SaveFileDialog saveDialog;

	internal Button extractMusical;

	internal CheckBox activeMusical;

	internal Button changeMusical;

	internal GroupBox GroupBox3;

	internal Button extractPokedex;

	internal CheckBox activePokedex;

	internal Button changePokedex;

	internal GroupBox GroupBox2;

	internal Button extractCGear;

	internal Button changeCGear;

	internal CheckBox activeCGear;

	internal GroupBox GroupBox1;

	private Label label1;

	private TextBox musicalTitle;

	public Musical musicalData
	{
		get
		{
			return musical;
		}
		set
		{
			musical = value;
			if (musical.isEmpty())
			{
				extractMusical.Enabled = false;
				activeMusical.Enabled = false;
			}
			if (musical.active)
			{
				activeMusical.Checked = true;
			}
			musicalTitle.Text = musical.title;
		}
	}

	public CgearSkin cgearSkin
	{
		get
		{
			return cgear;
		}
		set
		{
			cgear = value;
			if (cgear.isEmpty())
			{
				extractCGear.Enabled = false;
				activeCGear.Enabled = false;
			}
			if (cgear.active)
			{
				activeCGear.Checked = true;
			}
		}
	}

	public PokedexSkin pokedexSkin
	{
		get
		{
			return pokedex;
		}
		set
		{
			pokedex = value;
			if (pokedex.isEmpty())
			{
				extractPokedex.Enabled = false;
				activePokedex.Enabled = false;
			}
			if (pokedex.active)
			{
				activePokedex.Checked = true;
			}
		}
	}

	public SaveFile.Version Version
	{
		set
		{
			version = value;
		}
	}

	public DLCEditor()
	{
		InitializeComponent();
	}

	private void change(object sender, EventArgs e)
	{
		if (!(sender is Button))
		{
			return;
		}
		Button button = (Button)sender;
		if (button.Equals(changeCGear))
		{
			if (version == SaveFile.Version.BW2)
			{
				loadDialog.Filter = "Pokemon C-Gear Skin (*.cgb)|*.cgb";
			}
			else
			{
				loadDialog.Filter = "Pokemon C-Gear Skin (*.psk)|*.psk";
			}
		}
		if (button.Equals(changePokedex))
		{
			loadDialog.Filter = "Pokemon Pokedex Skin (*.pds)|*.pds";
		}
		if (button.Equals(changeMusical))
		{
			loadDialog.Filter = "Pokemon Musical Data (*.pms)|*.pms";
		}
		DialogResult dialogResult = loadDialog.ShowDialog();
		if (dialogResult == DialogResult.OK && loadDialog.FileName != "")
		{
			if (button.Equals(changeCGear))
			{
				cgear = new CgearSkin(File.ReadAllBytes(loadDialog.FileName), active: true);
				activeCGear.Checked = !cgear.isEmpty();
			}
			if (button.Equals(changePokedex))
			{
				pokedex = new PokedexSkin(File.ReadAllBytes(loadDialog.FileName), active: true);
				activePokedex.Checked = !pokedex.isEmpty();
			}
		}
		if (button.Equals(changeMusical))
		{
			musical = new Musical(File.ReadAllBytes(loadDialog.FileName), version, active: true);
			activeMusical.Checked = !musical.isEmpty();
			musicalTitle.Text = musical.title;
		}
	}

	private void extract(object sender, EventArgs e)
	{
		if (!(sender is Button))
		{
			return;
		}
		Button button = (Button)sender;
		if (button.Equals(extractCGear))
		{
			if (version == SaveFile.Version.BW2)
			{
				saveDialog.Filter = "Pokemon C-Gear Skin (*.cgb)|*.cgb";
			}
			else
			{
				saveDialog.Filter = "Pokemon C-Gear Skin (*.psk)|*.psk";
			}
		}
		if (button.Equals(extractPokedex))
		{
			saveDialog.Filter = "Pokemon Pokedex Skin (*.pds)|*.pds";
		}
		if (button.Equals(extractMusical))
		{
			saveDialog.Filter = "Pokemon Musical Data (*.pms)|*.pms";
		}
		DialogResult dialogResult = saveDialog.ShowDialog();
		if (dialogResult == DialogResult.OK)
		{
			if (button.Equals(extractCGear))
			{
				File.WriteAllBytes(saveDialog.FileName, cgear.data);
			}
			if (button.Equals(extractPokedex))
			{
				File.WriteAllBytes(saveDialog.FileName, pokedex.data);
			}
			if (button.Equals(extractMusical))
			{
				File.WriteAllBytes(saveDialog.FileName, musical.data);
			}
		}
	}

	private void activate(object sender, EventArgs e)
	{
		if (sender is CheckBox)
		{
			CheckBox checkBox = (CheckBox)sender;
			if (checkBox.Equals(changeCGear))
			{
				cgear.active = checkBox.Checked;
			}
			if (checkBox.Equals(extractPokedex))
			{
				pokedex.active = checkBox.Checked;
			}
			if (checkBox.Equals(extractMusical))
			{
				musical.active = checkBox.Checked;
			}
		}
	}

	private void musicalTitle_TextChanged(object sender, EventArgs e)
	{
		musical.title = musicalTitle.Text;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pikaedit.DLCEditor));
		this.loadDialog = new System.Windows.Forms.OpenFileDialog();
		this.saveDialog = new System.Windows.Forms.SaveFileDialog();
		this.extractMusical = new System.Windows.Forms.Button();
		this.activeMusical = new System.Windows.Forms.CheckBox();
		this.changeMusical = new System.Windows.Forms.Button();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.extractPokedex = new System.Windows.Forms.Button();
		this.activePokedex = new System.Windows.Forms.CheckBox();
		this.changePokedex = new System.Windows.Forms.Button();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.extractCGear = new System.Windows.Forms.Button();
		this.changeCGear = new System.Windows.Forms.Button();
		this.activeCGear = new System.Windows.Forms.CheckBox();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.musicalTitle = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.GroupBox3.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.extractMusical.Location = new System.Drawing.Point(6, 71);
		this.extractMusical.Name = "extractMusical";
		this.extractMusical.Size = new System.Drawing.Size(75, 23);
		this.extractMusical.TabIndex = 8;
		this.extractMusical.Text = "Extract";
		this.extractMusical.UseVisualStyleBackColor = true;
		this.extractMusical.Click += new System.EventHandler(extract);
		this.activeMusical.AutoSize = true;
		this.activeMusical.Location = new System.Drawing.Point(6, 19);
		this.activeMusical.Name = "activeMusical";
		this.activeMusical.Size = new System.Drawing.Size(56, 17);
		this.activeMusical.TabIndex = 6;
		this.activeMusical.Text = "Active";
		this.activeMusical.UseVisualStyleBackColor = true;
		this.activeMusical.CheckedChanged += new System.EventHandler(activate);
		this.changeMusical.Location = new System.Drawing.Point(6, 42);
		this.changeMusical.Name = "changeMusical";
		this.changeMusical.Size = new System.Drawing.Size(75, 23);
		this.changeMusical.TabIndex = 7;
		this.changeMusical.Text = "Change";
		this.changeMusical.UseVisualStyleBackColor = true;
		this.changeMusical.Click += new System.EventHandler(change);
		this.GroupBox3.Controls.Add(this.label1);
		this.GroupBox3.Controls.Add(this.musicalTitle);
		this.GroupBox3.Controls.Add(this.extractMusical);
		this.GroupBox3.Controls.Add(this.activeMusical);
		this.GroupBox3.Controls.Add(this.changeMusical);
		this.GroupBox3.Location = new System.Drawing.Point(312, 2);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(263, 110);
		this.GroupBox3.TabIndex = 12;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Musical Data";
		this.extractPokedex.Location = new System.Drawing.Point(6, 71);
		this.extractPokedex.Name = "extractPokedex";
		this.extractPokedex.Size = new System.Drawing.Size(75, 23);
		this.extractPokedex.TabIndex = 8;
		this.extractPokedex.Text = "Extract";
		this.extractPokedex.UseVisualStyleBackColor = true;
		this.extractPokedex.Click += new System.EventHandler(extract);
		this.activePokedex.AutoSize = true;
		this.activePokedex.Location = new System.Drawing.Point(6, 19);
		this.activePokedex.Name = "activePokedex";
		this.activePokedex.Size = new System.Drawing.Size(56, 17);
		this.activePokedex.TabIndex = 6;
		this.activePokedex.Text = "Active";
		this.activePokedex.UseVisualStyleBackColor = true;
		this.activePokedex.CheckedChanged += new System.EventHandler(activate);
		this.changePokedex.Location = new System.Drawing.Point(6, 42);
		this.changePokedex.Name = "changePokedex";
		this.changePokedex.Size = new System.Drawing.Size(75, 23);
		this.changePokedex.TabIndex = 7;
		this.changePokedex.Text = "Change";
		this.changePokedex.UseVisualStyleBackColor = true;
		this.changePokedex.Click += new System.EventHandler(change);
		this.GroupBox2.Controls.Add(this.extractPokedex);
		this.GroupBox2.Controls.Add(this.activePokedex);
		this.GroupBox2.Controls.Add(this.changePokedex);
		this.GroupBox2.Location = new System.Drawing.Point(162, 2);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(144, 110);
		this.GroupBox2.TabIndex = 11;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Pokedex Skin";
		this.extractCGear.Location = new System.Drawing.Point(6, 71);
		this.extractCGear.Name = "extractCGear";
		this.extractCGear.Size = new System.Drawing.Size(75, 23);
		this.extractCGear.TabIndex = 5;
		this.extractCGear.Text = "Extract";
		this.extractCGear.UseVisualStyleBackColor = true;
		this.extractCGear.Click += new System.EventHandler(extract);
		this.changeCGear.Location = new System.Drawing.Point(6, 42);
		this.changeCGear.Name = "changeCGear";
		this.changeCGear.Size = new System.Drawing.Size(75, 23);
		this.changeCGear.TabIndex = 4;
		this.changeCGear.Text = "Change";
		this.changeCGear.UseVisualStyleBackColor = true;
		this.changeCGear.Click += new System.EventHandler(change);
		this.activeCGear.AutoSize = true;
		this.activeCGear.Location = new System.Drawing.Point(6, 19);
		this.activeCGear.Name = "activeCGear";
		this.activeCGear.Size = new System.Drawing.Size(56, 17);
		this.activeCGear.TabIndex = 3;
		this.activeCGear.Text = "Active";
		this.activeCGear.UseVisualStyleBackColor = true;
		this.activeCGear.CheckedChanged += new System.EventHandler(activate);
		this.GroupBox1.Controls.Add(this.extractCGear);
		this.GroupBox1.Controls.Add(this.changeCGear);
		this.GroupBox1.Controls.Add(this.activeCGear);
		this.GroupBox1.Location = new System.Drawing.Point(3, 2);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(153, 110);
		this.GroupBox1.TabIndex = 10;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "C-Gear Skin";
		this.musicalTitle.Location = new System.Drawing.Point(92, 42);
		this.musicalTitle.MaxLength = 14;
		this.musicalTitle.Name = "musicalTitle";
		this.musicalTitle.Size = new System.Drawing.Size(163, 20);
		this.musicalTitle.TabIndex = 13;
		this.musicalTitle.TextChanged += new System.EventHandler(musicalTitle_TextChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(89, 20);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(66, 13);
		this.label1.TabIndex = 14;
		this.label1.Text = "Musical Title";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(579, 116);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DLCEditor";
		this.Text = "DLC";
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
	}
}

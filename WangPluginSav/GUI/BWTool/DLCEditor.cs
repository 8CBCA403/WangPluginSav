using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WangPluginSav.Util.Pikaedit;

namespace Pikaedit;

partial class DLCEditor : Form
{
    private Musical musical;

    private CgearSkin cgear;

    private PokedexSkin pokedex;

    private SaveFile.Version version;

    private OpenFileDialog loadDialog;

    private SaveFileDialog saveDialog;



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


}

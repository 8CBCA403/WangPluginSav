using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using PKHeX.Core;
using PKHeX.Drawing;
using PKHeX.Drawing.PokeSprite;
using PKHeX.Drawing.PokeSprite.Properties;

namespace NPCmonEditor;

partial class NPCmonEditorForm : Form
{
    public bool counter = false;

    private int ClickedSlot = 0;

    private readonly SaveFile sav;

    private bool InitialLoad = false;

    public bool ChangedByProgram = false;

    public PA8 _PA8Editor;

    public IPKMView PKMEditor;

    public bool performcancel = false;

    private SCBlock WRBlock;

    private DataTable dt = new DataTable();

    private int dtrowcounter = 0;

    private int usage = 0;

    private static AutoResetEvent resetEvent = new AutoResetEvent(initialState: false);

   

    public NPCmonEditorForm(SaveFile sav, IPKMView pKMEditor)
    {
        InitialLoad = true;
        this.sav = sav;
        ChangedByProgram = true;
        PKMEditor = pKMEditor;
        if (sav is SAV8LA sAV8LA)
        {
            WRBlock = sAV8LA.Blocks.GetBlock(767455748u);
            _PA8Editor = (PA8)PKMEditor.Data;
        }
        ChangedByProgram = false;
        InitializeComponent();
        InitialLoading();
        InitialLoad = false;
        ((PictureBox)base.Controls["pictureBox" + 1]).BorderStyle = BorderStyle.Fixed3D;
    }

    public void InitialLoading()
    {
        if (InitialLoad)
        {
        }
    }

    private void Overworld8_Load(object sender, EventArgs e)
    {
        InitialLoad = true;
        InitialLoading();
        InitialLoad = false;
        Control.CheckForIllegalCrossThreadCalls = false;
        for (int i = 0; i < 32; i++)
        {
            UpdateEntriesPLA(WRBlock, i);
        }
    }

    public void UpdateEntriesPLA(SCBlock TempBlock, int Index)
    {
        if (!InitialLoad)
        {
            Image image = null;
            byte[] array = new byte[360];
            for (int i = 0; i < 360; i++)
            {
                array[i] = TempBlock.Data[i + Index * 384];
            }
            PA8 pA = (_PA8Editor = new PA8(PokeCrypto.DecryptArray8A(array)));
            Shiny shiny = Shiny.Never;
            if (_PA8Editor.IsShiny)
            {
                shiny = Shiny.Always;
            }
            image = SpriteUtil.GetSprite(_PA8Editor.Species, _PA8Editor.Form, _PA8Editor.Gender, 0u, 0, false, shiny, EntityContext.None);
            if (pA != null && ((IAlpha)pA).IsAlpha)
            {
                Image alpha = Resources.alpha;
                image = ImageUtil.LayerImage(image, alpha, 45, 0);
            }
            ((PictureBox)base.Controls["pictureBox" + (Index + 1)]).Image = image;
        }
    }

    private void Border_Change(object sender, EventArgs e)
    {
        Border_Change(sender);
        if (checkBox2.Checked)
        {
            byte[] array = new byte[360];
            for (int i = 0; i < 360; i++)
            {
                array[i] = WRBlock.Data[i + ClickedSlot * 384];
            }
            PA8 pk = new PA8(PokeCrypto.DecryptArray8A(array));
            PKMEditor.PopulateFields(pk);
        }
    }

    private void Border_Change(object sender)
    {
        string s = ((PictureBox)sender).Name.Replace("pictureBox", "");
        ClickedSlot = ushort.Parse(s) - 1;
        int num = 0;
        for (num = 0; num < 32; num++)
        {
            ((PictureBox)base.Controls["pictureBox" + (num + 1)]).BorderStyle = BorderStyle.FixedSingle;
        }
        ((PictureBox)base.Controls["pictureBox" + (ClickedSlot + 1)]).BorderStyle = BorderStyle.Fixed3D;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        byte[] array = new byte[360];
        for (int i = 0; i < 360; i++)
        {
            array[i] = WRBlock.Data[i + ClickedSlot * 384];
        }
        PA8 pk = new PA8(PokeCrypto.DecryptArray8A(array));
        PKMEditor.PopulateFields(pk);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        PA8 pA = (PA8)PKMEditor.Data;
        byte[] array = new byte[360];
        array = PokeCrypto.EncryptArray8A(pA.Data);
        for (int i = 0; i < 360; i++)
        {
            WRBlock.Data[i + ClickedSlot * 384] = array[i];
        }
        for (int j = 0; j < 32; j++)
        {
            UpdateEntriesPLA(WRBlock, j);
        }
    }

   
}

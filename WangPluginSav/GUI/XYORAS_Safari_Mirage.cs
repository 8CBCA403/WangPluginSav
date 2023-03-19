using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace XYORAS_Safari_Mirage_Tool;

public class SafariMirageForm : Form
{
    private int game;

    private string linkfile;

    private byte[] savebuffer_XY = new byte[415232];

    private byte[] savebuffer_ORAS = new byte[483328];

    private byte[] linkbuffer = new byte[2631];

    private int[] mirage_slots = new int[10];

    private int pss_slot;

    private Button loadsave;

    private TextBox savegamename;

    private TextBox currgame;

    private Label label35;

    private NumericUpDown ev_5;

    private NumericUpDown ev_4;

    private NumericUpDown ev_3;

    private NumericUpDown ev_2;

    private NumericUpDown ev_1;

    private NumericUpDown ev_0;

    private GroupBox groupBox7;

    private Button unlock_safari;

    private ComboBox comboBox2;

    private Label label2;

    private GroupBox orasbox;

    private GroupBox mdv_box;

    private Label u32;

    private Label label3;

    private Label u16;

    private NumericUpDown tid_hi;

    private Label label4;

    private NumericUpDown tid_lo;

    private NumericUpDown mdv3;

    private NumericUpDown mdv0;

    private NumericUpDown mdv2;

    private NumericUpDown mdv1;

    private Button mdv_advanced;

    private Button infobut;

    private Button oras_save;

    private Label spot8;

    private Label spot7;

    private Label spot6;

    private Label spot5;

    private Label spot4;

    private Label spot3;

    private Label spot2;

    private Label spot1;

    private Label spot0;

    private Label spot9;

    private Panel panel_info;

    private Label label5;

    private Label label6;

    private Button close_info;

    private Label label7;

    private GroupBox groupBox1;

    private RadioButton but8;

    private RadioButton but7;

    private RadioButton but6;

    private RadioButton but5;

    private RadioButton but4;

    private RadioButton but3;

    private RadioButton but2;

    private RadioButton but1;

    private RadioButton but0;

    private RadioButton but9;

    public SafariMirageForm()
    {
        InitializeComponent();
        base.Size = new Size(755, 270);
    }

    public static byte[] ccitt16(byte[] data)
    {
        int num = data.Length;
        ushort num2 = ushort.MaxValue;
        for (uint num3 = 0u; num3 < num; num3++)
        {
            num2 = (ushort)(num2 ^ (ushort)((uint)(data[num3] << 8) & 0xFFFFu));
            for (uint num4 = 0u; num4 < 8; num4++)
            {
                num2 = (((num2 & 0x8000) <= 0) ? ((ushort)(num2 << 1)) : ((ushort)(((ushort)((uint)(num2 << 1) & 0xFFFFu) ^ 0x1021u) & 0xFFFFu)));
            }
        }
        return BitConverter.GetBytes(num2);
    }

    public static void ReadWholeArray(Stream stream, byte[] data)
    {
        int num = 0;
        int num2 = data.Length;
        while (num2 > 0)
        {
            int num3 = stream.Read(data, num, num2);
            if (num3 <= 0)
            {
                throw new EndOfStreamException($"End of stream reached with {num2} bytes left to read");
            }
            num2 -= num3;
            num += num3;
        }
    }

    private void Read_data()
    {
        FileStream fileStream = new FileStream(savegamename.Text, FileMode.Open);
        if (fileStream.Length != 415232 && fileStream.Length != 483328)
        {
            savegamename.Text = "";
            MessageBox.Show("Invalid file length", "Error");
        }
        else if (fileStream.Length == 415232)
        {
            game = 1;
            currgame.Text = "X/Y";
            ReadWholeArray(fileStream, savebuffer_XY);
            fileStream.Close();
            unlock_safari.Enabled = true;
            orasbox.Enabled = false;
        }
        else if (fileStream.Length == 483328)
        {
            game = 2;
            currgame.Text = "OR/AS";
            ReadWholeArray(fileStream, savebuffer_ORAS);
            tid_lo.Value = savebuffer_ORAS[81920];
            tid_hi.Value = savebuffer_ORAS[81921];
            update_tid();
            mdv0.Value = savebuffer_ORAS[5632];
            mdv1.Value = savebuffer_ORAS[5633];
            mdv2.Value = savebuffer_ORAS[5634];
            mdv3.Value = savebuffer_ORAS[5635];
            update_mdv();
            pss_slot = 0;
            int num = 0;
            for (num = 0; num < 10; num++)
            {
                mirage_slots[num] = savebuffer_ORAS[198612 + num * 4];
            }
            update_mirages();
            savebuffer_ORAS.Skip(135167).Take(2631).ToArray()
                .CopyTo(linkbuffer, 0);
            fileStream.Close();
            unlock_safari.Enabled = false;
            orasbox.Enabled = true;
        }
    }

    private void Get_save_data()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "VI gen save data|main|All Files (*.*)|*.*";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            savegamename.Text = openFileDialog.FileName;
            Read_data();
        }
    }

    private void Save_data()
    {
        if (savegamename.Text.Length < 1)
        {
            return;
        }
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "VI gen save data|main|All Files (*.*)|*.*";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
            if (game == 1)
            {
                fileStream.Write(savebuffer_XY, 0, savebuffer_XY.Length);
            }
            else if (game == 2)
            {
                fileStream.Write(savebuffer_ORAS, 0, savebuffer_ORAS.Length);
            }
            fileStream.Close();
            MessageBox.Show("File Saved.", "Save file");
        }
    }

    private void Dump_link_data()
    {
        if (savegamename.Text.Length < 1)
        {
            return;
        }
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Pokémon Link Data|*.bin|All Files (*.*)|*.*";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
            if (game == 1)
            {
                fileStream.Write(savebuffer_XY, 131071, 2631);
            }
            else if (game == 2)
            {
                fileStream.Write(savebuffer_ORAS, 135167, 2631);
            }
            fileStream.Close();
            MessageBox.Show("Pokémon Link data dumped to:\r" + saveFileDialog.FileName + ".");
        }
    }

    private void Read_link_data()
    {
        FileStream fileStream = new FileStream(linkfile, FileMode.Open);
        if (fileStream.Length != 2631)
        {
            MessageBox.Show("Invalid file length", "Error");
            return;
        }
        ReadWholeArray(fileStream, linkbuffer);
        fileStream.Close();
        InjectNsave();
    }

    private void Get_link_data()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Pokémon Link Data|*.bin|All Files (*.*)|*.*";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            linkfile = openFileDialog.FileName;
            Read_link_data();
        }
    }

    private void InjectNsave()
    {
        if (game == 1)
        {
            for (int i = 1; i < 101; i++)
            {
                if (savebuffer_XY[124927 + 21 * i] != 0)
                {
                    savebuffer_XY[124927 + 21 * i] = 61;
                }
            }
            byte[] array = new byte[2100];
            Array.Copy(savebuffer_XY, 124928, array, 0, 2100);
            byte[] array2 = new byte[2];
            array2 = ccitt16(array);
            Array.Copy(array2, 0, savebuffer_XY, 415106, 2);
        }
        else if (game == 2)
        {
            Array.Copy(linkbuffer, 0, savebuffer_ORAS, 135167, 2631);
            savebuffer_ORAS[81920] = (byte)tid_lo.Value;
            savebuffer_ORAS[81921] = (byte)tid_hi.Value;
            byte[] array3 = new byte[368];
            Array.Copy(savebuffer_ORAS, 81920, array3, 0, 368);
            byte[] array4 = new byte[2];
            array4 = ccitt16(array3);
            Array.Copy(array4, 0, savebuffer_ORAS, 482978, 2);
            savebuffer_ORAS[5632] = (byte)mdv0.Value;
            savebuffer_ORAS[5633] = (byte)mdv1.Value;
            savebuffer_ORAS[5634] = (byte)mdv2.Value;
            savebuffer_ORAS[5635] = (byte)mdv3.Value;
            byte[] array5 = new byte[4];
            Array.Copy(savebuffer_ORAS, 5632, array5, 0, 4);
            array4 = ccitt16(array5);
            Array.Copy(array4, 0, savebuffer_ORAS, 482882, 2);
            int num = 0;
            for (num = 0; num < 10; num++)
            {
                savebuffer_ORAS[198612 + num * 4] = (byte)mirage_slots[num];
            }
            byte[] array6 = new byte[30896];
            Array.Copy(savebuffer_ORAS, 177664, array6, 0, 30896);
            array4 = ccitt16(array6);
            Array.Copy(array4, 0, savebuffer_ORAS, 483282, 2);
        }
        Save_data();
    }

    private void LoadsaveClick(object sender, EventArgs e)
    {
        Get_save_data();
    }

    private void Dump_butClick(object sender, EventArgs e)
    {
        if (savegamename.Text.Length >= 1)
        {
            Dump_link_data();
        }
    }

    private void SavegamenameTextChanged(object sender, EventArgs e)
    {
        if (savegamename.Text.Length > 0)
        {
            if (game == 1)
            {
                unlock_safari.Enabled = true;
            }
        }
        else
        {
            unlock_safari.Enabled = false;
        }
    }

    private void Inject_butClick(object sender, EventArgs e)
    {
        Get_link_data();
    }

    private void Mdv_advancedClick(object sender, EventArgs e)
    {
        GroupBox groupBox = mdv_box;
        groupBox.Visible = !groupBox.Visible;
        if (!mdv_box.Visible)
        {
            base.Size = new Size(755, 270);
        }
        else
        {
            base.Size = new Size(755, 394);
        }
    }

    private void GroupBox1Enter(object sender, EventArgs e)
    {
    }

    private void InfobutClick(object sender, EventArgs e)
    {
        panel_info.Visible = true;
        base.Size = new Size(755, 532);
    }

    private void Oras_saveClick(object sender, EventArgs e)
    {
        InjectNsave();
    }

    private void Unlock_safariClick(object sender, EventArgs e)
    {
        InjectNsave();
    }

    private void update_tid()
    {
        u16.Text = ((ushort)((ushort)tid_lo.Value | ((ushort)tid_hi.Value << 8))).ToString("00000") + "   (u16)\n0x" + ((ushort)((ushort)tid_lo.Value | ((ushort)tid_hi.Value << 8))).ToString("X4") + "  (hex) ";
    }

    private void Tid_hiValueChanged(object sender, EventArgs e)
    {
        update_tid();
    }

    private void Tid_loValueChanged(object sender, EventArgs e)
    {
        update_tid();
    }

    private void update_mdv()
    {
        u32.Text = ((uint)mdv0.Value | ((uint)mdv1.Value << 8) | ((uint)mdv2.Value << 16) | ((uint)mdv3.Value << 24)).ToString("0000000000") + "  (u32)\n0x" + ((uint)mdv0.Value | ((uint)mdv1.Value << 8) | ((uint)mdv2.Value << 16) | ((uint)mdv3.Value << 24)).ToString("X8") + "  (hex) ";
    }

    private void Mdv0ValueChanged(object sender, EventArgs e)
    {
        update_mdv();
    }

    private void Mdv1ValueChanged(object sender, EventArgs e)
    {
        update_mdv();
    }

    private void Mdv2ValueChanged(object sender, EventArgs e)
    {
        update_mdv();
    }

    private void Mdv3ValueChanged(object sender, EventArgs e)
    {
        update_mdv();
    }

    private void update_mirages()
    {
        spot0.Text = mirage_slots[0].ToString("00");
        spot1.Text = mirage_slots[1].ToString("00");
        spot2.Text = mirage_slots[2].ToString("00");
        spot3.Text = mirage_slots[3].ToString("00");
        spot4.Text = mirage_slots[4].ToString("00");
        spot5.Text = mirage_slots[5].ToString("00");
        spot6.Text = mirage_slots[6].ToString("00");
        spot7.Text = mirage_slots[7].ToString("00");
        spot8.Text = mirage_slots[8].ToString("00");
        spot9.Text = mirage_slots[9].ToString("00");
        comboBox2.SelectedIndex = mirage_slots[pss_slot];
    }

    private void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
    {
        mirage_slots[pss_slot] = comboBox2.SelectedIndex;
        update_mirages();
    }

    private void Close_infoClick(object sender, EventArgs e)
    {
        panel_info.Visible = false;
        if (!mdv_box.Visible)
        {
            base.Size = new Size(755, 270);
        }
        else
        {
            base.Size = new Size(755, 394);
        }
    }

    private void update_radio()
    {
        if (but0.Checked)
        {
            pss_slot = 0;
        }
        else if (but1.Checked)
        {
            pss_slot = 1;
        }
        else if (but2.Checked)
        {
            pss_slot = 2;
        }
        else if (but3.Checked)
        {
            pss_slot = 3;
        }
        else if (but4.Checked)
        {
            pss_slot = 4;
        }
        else if (but5.Checked)
        {
            pss_slot = 5;
        }
        else if (but6.Checked)
        {
            pss_slot = 6;
        }
        else if (but7.Checked)
        {
            pss_slot = 7;
        }
        else if (but8.Checked)
        {
            pss_slot = 8;
        }
        else if (but9.Checked)
        {
            pss_slot = 9;
        }
        else
        {
            pss_slot = 0;
        }
        comboBox2.SelectedIndex = mirage_slots[pss_slot];
    }

    private void But0CheckedChanged(object sender, EventArgs e)
    {
        update_radio();
    }

    private void But1CheckedChanged(object sender, EventArgs e)
    {
        update_radio();
    }

    private void But2CheckedChanged(object sender, EventArgs e)
    {
        update_radio();
    }

    private void But3CheckedChanged(object sender, EventArgs e)
    {
        update_radio();
    }

    private void But4CheckedChanged(object sender, EventArgs e)
    {
        update_radio();
    }

    private void But5CheckedChanged(object sender, EventArgs e)
    {
        update_radio();
    }

    private void But6CheckedChanged(object sender, EventArgs e)
    {
        update_radio();
    }

    private void But7CheckedChanged(object sender, EventArgs e)
    {
        update_radio();
    }

    private void But8CheckedChanged(object sender, EventArgs e)
    {
        update_radio();
    }

    private void But9CheckedChanged(object sender, EventArgs e)
    {
        update_radio();
    }

    private void InitializeComponent()
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(SafariMirageForm));
        loadsave = new Button();
        savegamename = new TextBox();
        currgame = new TextBox();
        label35 = new Label();
        ev_5 = new NumericUpDown();
        ev_4 = new NumericUpDown();
        ev_3 = new NumericUpDown();
        ev_2 = new NumericUpDown();
        ev_1 = new NumericUpDown();
        ev_0 = new NumericUpDown();
        groupBox7 = new GroupBox();
        unlock_safari = new Button();
        comboBox2 = new ComboBox();
        label2 = new Label();
        orasbox = new GroupBox();
        groupBox1 = new GroupBox();
        spot9 = new Label();
        but9 = new RadioButton();
        oras_save = new Button();
        mdv_advanced = new Button();
        spot8 = new Label();
        but8 = new RadioButton();
        spot7 = new Label();
        but7 = new RadioButton();
        spot6 = new Label();
        but6 = new RadioButton();
        but5 = new RadioButton();
        spot5 = new Label();
        but4 = new RadioButton();
        spot4 = new Label();
        but3 = new RadioButton();
        spot3 = new Label();
        but2 = new RadioButton();
        spot2 = new Label();
        but1 = new RadioButton();
        spot1 = new Label();
        but0 = new RadioButton();
        spot0 = new Label();
        mdv_box = new GroupBox();
        infobut = new Button();
        u32 = new Label();
        label3 = new Label();
        u16 = new Label();
        tid_hi = new NumericUpDown();
        label4 = new Label();
        tid_lo = new NumericUpDown();
        mdv3 = new NumericUpDown();
        mdv0 = new NumericUpDown();
        mdv2 = new NumericUpDown();
        mdv1 = new NumericUpDown();
        panel_info = new Panel();
        close_info = new Button();
        label5 = new Label();
        label7 = new Label();
        label6 = new Label();
        ((ISupportInitialize)ev_5).BeginInit();
        ((ISupportInitialize)ev_4).BeginInit();
        ((ISupportInitialize)ev_3).BeginInit();
        ((ISupportInitialize)ev_2).BeginInit();
        ((ISupportInitialize)ev_1).BeginInit();
        ((ISupportInitialize)ev_0).BeginInit();
        groupBox7.SuspendLayout();
        orasbox.SuspendLayout();
        groupBox1.SuspendLayout();
        mdv_box.SuspendLayout();
        ((ISupportInitialize)tid_hi).BeginInit();
        ((ISupportInitialize)tid_lo).BeginInit();
        ((ISupportInitialize)mdv3).BeginInit();
        ((ISupportInitialize)mdv0).BeginInit();
        ((ISupportInitialize)mdv2).BeginInit();
        ((ISupportInitialize)mdv1).BeginInit();
        panel_info.SuspendLayout();
        SuspendLayout();
        // 
        // loadsave
        // 
        loadsave.Location = new Point(27, 30);
        loadsave.Margin = new Padding(4, 4, 4, 4);
        loadsave.Name = "loadsave";
        loadsave.Size = new Size(216, 26);
        loadsave.TabIndex = 0;
        loadsave.Text = "Load XY/ORAS Savegame";
        loadsave.UseVisualStyleBackColor = true;
        loadsave.Click += LoadsaveClick;
        // 
        // savegamename
        // 
        savegamename.Location = new Point(27, 64);
        savegamename.Margin = new Padding(4, 4, 4, 4);
        savegamename.Name = "savegamename";
        savegamename.Size = new Size(439, 25);
        savegamename.TabIndex = 1;
        // 
        // currgame
        // 
        currgame.Location = new Point(251, 32);
        currgame.Margin = new Padding(4, 4, 4, 4);
        currgame.Name = "currgame";
        currgame.ReadOnly = true;
        currgame.Size = new Size(96, 25);
        currgame.TabIndex = 5;
        currgame.TextAlign = HorizontalAlignment.Center;
        // 
        // label35
        // 
        label35.Location = new Point(1513, 251);
        label35.Margin = new Padding(4, 0, 4, 0);
        label35.Name = "label35";
        label35.Size = new Size(49, 26);
        label35.TabIndex = 102;
        label35.Text = "EVs";
        label35.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ev_5
        // 
        ev_5.Location = new Point(1513, 405);
        ev_5.Margin = new Padding(4, 4, 4, 4);
        ev_5.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        ev_5.Name = "ev_5";
        ev_5.Size = new Size(49, 25);
        ev_5.TabIndex = 101;
        // 
        // ev_4
        // 
        ev_4.Location = new Point(1513, 380);
        ev_4.Margin = new Padding(4, 4, 4, 4);
        ev_4.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        ev_4.Name = "ev_4";
        ev_4.Size = new Size(49, 25);
        ev_4.TabIndex = 100;
        // 
        // ev_3
        // 
        ev_3.Location = new Point(1513, 354);
        ev_3.Margin = new Padding(4, 4, 4, 4);
        ev_3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        ev_3.Name = "ev_3";
        ev_3.Size = new Size(49, 25);
        ev_3.TabIndex = 99;
        // 
        // ev_2
        // 
        ev_2.Location = new Point(1513, 328);
        ev_2.Margin = new Padding(4, 4, 4, 4);
        ev_2.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        ev_2.Name = "ev_2";
        ev_2.Size = new Size(49, 25);
        ev_2.TabIndex = 98;
        // 
        // ev_1
        // 
        ev_1.Location = new Point(1513, 304);
        ev_1.Margin = new Padding(4, 4, 4, 4);
        ev_1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        ev_1.Name = "ev_1";
        ev_1.Size = new Size(49, 25);
        ev_1.TabIndex = 97;
        // 
        // ev_0
        // 
        ev_0.Location = new Point(1513, 278);
        ev_0.Margin = new Padding(4, 4, 4, 4);
        ev_0.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        ev_0.Name = "ev_0";
        ev_0.Size = new Size(49, 25);
        ev_0.TabIndex = 96;
        // 
        // groupBox7
        // 
        groupBox7.Controls.Add(currgame);
        groupBox7.Controls.Add(savegamename);
        groupBox7.Controls.Add(loadsave);
        groupBox7.Location = new Point(24, 14);
        groupBox7.Margin = new Padding(4, 4, 4, 4);
        groupBox7.Name = "groupBox7";
        groupBox7.Padding = new Padding(4, 4, 4, 4);
        groupBox7.Size = new Size(487, 103);
        groupBox7.TabIndex = 143;
        groupBox7.TabStop = false;
        groupBox7.Text = "Savegame";
        // 
        // unlock_safari
        // 
        unlock_safari.Enabled = false;
        unlock_safari.Location = new Point(537, 46);
        unlock_safari.Margin = new Padding(4, 4, 4, 4);
        unlock_safari.Name = "unlock_safari";
        unlock_safari.Size = new Size(137, 41);
        unlock_safari.TabIndex = 144;
        unlock_safari.Text = "Unlock all Friend Safari (XY only)";
        unlock_safari.UseVisualStyleBackColor = true;
        unlock_safari.Click += Unlock_safariClick;
        // 
        // comboBox2
        // 
        comboBox2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        comboBox2.FormattingEnabled = true;
        comboBox2.Items.AddRange(new object[] { "00: NONE", "01: 467 - Crescent Isle           - Cresselia", "02: 184 - East of Mossdeep        - Tangela, Sunkern, Glameow, Minccino", "03: 185 - North of Route 124      - Tangela, Sunkern, Purugly, Vulpix", "04: 186 - West of Route 114       - Tangela, Sunkern, Purugly, Petilil", "05: 187 - North of Lilycove       - Tangela, Sunkern, Purugly, Cherrim", "06: 188 - South of Route 132      - Sunkern, Petilil, Audino", "07: 189 - West of Route 105       - Forretress, Happiny", "08: 190 - South of Route 109      - Audino, Sunkern", "09: 191 - North of Route 111      - Kricketune, Larvesta", "10: 192 - West of Rustboro        - Tynamo, Klink, Boldore, Graveler", "11: 193 - North of Fortree        - Klink, Tynamo, Excadrill, Onix", "12: 194 - South of Pacifidlog     - Tynamo, Cofagrigus, Slowpoke", "13: 195 - South of Route 107      - Unown", "14: 196 - North of Route 124      - Klink, Cofagrigus, Graveler, Boldore", "15: 197 - North of Route 132      - Ditto, Excadrill, Tynamo", "16: 198 - Southeast of Route 129  - Tynamo, Onix, Graveler, Boldore", "17: 199 - North of Fallarbor      - Slowpoke, Tynamo", "18: 200 - West of Route 104       - Venomoth, Xatu, Zebstrika, Darmanitan", "19: 201 - South of Route 134      - Venomoth, Xatu, Zebstrika, Maractus", "20: 202 - North of Route 124      - Venomoth, Xatu, Zebstrika, Persian", "21: 203 - West of Dewford Town    - Venomoth, Xatu, Zebstrika, Tangela", "22: 204 - South of Pacifidlog     - Audino, Xatu", "23: 205 - South of Route 132      - Munna, Ditto", "24: 206 - North of Route 113      - Darmanitan, Larvesta", "25: 207 - East of Shoal Cave      - Purugly, Porygon", "26: 208 - West of Route 104       - Forretress, Donphan, Kricketune, Stantler", "27: 460 - North of Lilycove       - Forretress, Donphan, Kricketune, Rufflet", "28: 461 - Northeast of Route 125  - Forretress, Donphan, Kricketune, Vullaby", "29: 462 - West of Route 131       - Donphan, Kricketune, Girafarig", "30: 463 - North of Mossdeep       - Magby, Darmanitan", "31: 464 - South of Route 129      - Zebstrika, Elekid", "32: 465 - Southeast of Route 129  - Porygon, Xatu, Munna", "33: 466 - East of Mossdeep        - Audino, Happiny, Tangela" });
        comboBox2.Location = new Point(136, 83);
        comboBox2.Margin = new Padding(4, 4, 4, 4);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(753, 25);
        comboBox2.TabIndex = 147;
        comboBox2.SelectedIndexChanged += ComboBox2SelectedIndexChanged;
        // 
        // label2
        // 
        label2.Location = new Point(16, 86);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(117, 22);
        label2.TabIndex = 148;
        label2.Text = "Mirage Spot:";
        label2.TextAlign = ContentAlignment.TopRight;
        // 
        // orasbox
        // 
        orasbox.Controls.Add(groupBox1);
        orasbox.Controls.Add(mdv_box);
        orasbox.Enabled = false;
        orasbox.Location = new Point(24, 134);
        orasbox.Margin = new Padding(4, 4, 4, 4);
        orasbox.Name = "orasbox";
        orasbox.Padding = new Padding(4, 4, 4, 4);
        orasbox.Size = new Size(947, 266);
        orasbox.TabIndex = 149;
        orasbox.TabStop = false;
        orasbox.Text = "OR/AS Mirage Spot";
        orasbox.Enter += GroupBox1Enter;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(spot9);
        groupBox1.Controls.Add(but9);
        groupBox1.Controls.Add(oras_save);
        groupBox1.Controls.Add(mdv_advanced);
        groupBox1.Controls.Add(spot8);
        groupBox1.Controls.Add(but8);
        groupBox1.Controls.Add(spot7);
        groupBox1.Controls.Add(but7);
        groupBox1.Controls.Add(spot6);
        groupBox1.Controls.Add(but6);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(but5);
        groupBox1.Controls.Add(spot5);
        groupBox1.Controls.Add(but4);
        groupBox1.Controls.Add(spot4);
        groupBox1.Controls.Add(but3);
        groupBox1.Controls.Add(spot3);
        groupBox1.Controls.Add(but2);
        groupBox1.Controls.Add(spot2);
        groupBox1.Controls.Add(but1);
        groupBox1.Controls.Add(spot1);
        groupBox1.Controls.Add(but0);
        groupBox1.Controls.Add(spot0);
        groupBox1.Controls.Add(comboBox2);
        groupBox1.Location = new Point(11, 17);
        groupBox1.Margin = new Padding(4, 4, 4, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 4, 4, 4);
        groupBox1.Size = new Size(919, 116);
        groupBox1.TabIndex = 195;
        groupBox1.TabStop = false;
        groupBox1.Text = "PSS Mirage Spot";
        groupBox1.Enter += GroupBox1Enter;
        // 
        // spot9
        // 
        spot9.Location = new Point(669, 56);
        spot9.Margin = new Padding(4, 0, 4, 0);
        spot9.Name = "spot9";
        spot9.Size = new Size(29, 21);
        spot9.TabIndex = 173;
        spot9.Text = "01";
        // 
        // but9
        // 
        but9.Location = new Point(659, 28);
        but9.Margin = new Padding(4, 4, 4, 4);
        but9.Name = "but9";
        but9.Size = new Size(61, 20);
        but9.TabIndex = 194;
        but9.Text = "09";
        but9.UseVisualStyleBackColor = true;
        but9.CheckedChanged += But9CheckedChanged;
        // 
        // oras_save
        // 
        oras_save.Location = new Point(8, 37);
        oras_save.Margin = new Padding(4, 4, 4, 4);
        oras_save.Name = "oras_save";
        oras_save.Size = new Size(100, 26);
        oras_save.TabIndex = 163;
        oras_save.Text = "Save";
        oras_save.UseVisualStyleBackColor = true;
        oras_save.Click += Oras_saveClick;
        // 
        // mdv_advanced
        // 
        mdv_advanced.Location = new Point(733, 28);
        mdv_advanced.Margin = new Padding(4, 4, 4, 4);
        mdv_advanced.Name = "mdv_advanced";
        mdv_advanced.Size = new Size(157, 45);
        mdv_advanced.TabIndex = 149;
        mdv_advanced.Text = "Daily Mirage Spot (advanced)";
        mdv_advanced.UseVisualStyleBackColor = true;
        mdv_advanced.Click += Mdv_advancedClick;
        // 
        // spot8
        // 
        spot8.Location = new Point(603, 56);
        spot8.Margin = new Padding(4, 0, 4, 0);
        spot8.Name = "spot8";
        spot8.Size = new Size(29, 21);
        spot8.TabIndex = 172;
        spot8.Text = "01";
        // 
        // but8
        // 
        but8.Location = new Point(596, 28);
        but8.Margin = new Padding(4, 4, 4, 4);
        but8.Name = "but8";
        but8.Size = new Size(61, 20);
        but8.TabIndex = 189;
        but8.Text = "08";
        but8.UseVisualStyleBackColor = true;
        but8.CheckedChanged += But8CheckedChanged;
        // 
        // spot7
        // 
        spot7.Location = new Point(552, 56);
        spot7.Margin = new Padding(4, 0, 4, 0);
        spot7.Name = "spot7";
        spot7.Size = new Size(29, 21);
        spot7.TabIndex = 171;
        spot7.Text = "01";
        // 
        // but7
        // 
        but7.Location = new Point(545, 28);
        but7.Margin = new Padding(4, 4, 4, 4);
        but7.Name = "but7";
        but7.Size = new Size(61, 20);
        but7.TabIndex = 193;
        but7.Text = "07";
        but7.UseVisualStyleBackColor = true;
        but7.CheckedChanged += But7CheckedChanged;
        // 
        // spot6
        // 
        spot6.Location = new Point(497, 56);
        spot6.Margin = new Padding(4, 0, 4, 0);
        spot6.Name = "spot6";
        spot6.Size = new Size(29, 21);
        spot6.TabIndex = 170;
        spot6.Text = "01";
        // 
        // but6
        // 
        but6.Location = new Point(489, 28);
        but6.Margin = new Padding(4, 4, 4, 4);
        but6.Name = "but6";
        but6.Size = new Size(61, 20);
        but6.TabIndex = 188;
        but6.Text = "06";
        but6.UseVisualStyleBackColor = true;
        but6.CheckedChanged += But6CheckedChanged;
        // 
        // but5
        // 
        but5.Location = new Point(437, 28);
        but5.Margin = new Padding(4, 4, 4, 4);
        but5.Name = "but5";
        but5.Size = new Size(61, 20);
        but5.TabIndex = 192;
        but5.Text = "05";
        but5.UseVisualStyleBackColor = true;
        but5.CheckedChanged += But5CheckedChanged;
        // 
        // spot5
        // 
        spot5.Location = new Point(445, 56);
        spot5.Margin = new Padding(4, 0, 4, 0);
        spot5.Name = "spot5";
        spot5.Size = new Size(29, 21);
        spot5.TabIndex = 169;
        spot5.Text = "01";
        // 
        // but4
        // 
        but4.Location = new Point(377, 28);
        but4.Margin = new Padding(4, 4, 4, 4);
        but4.Name = "but4";
        but4.Size = new Size(61, 20);
        but4.TabIndex = 187;
        but4.Text = "04";
        but4.UseVisualStyleBackColor = true;
        but4.CheckedChanged += But4CheckedChanged;
        // 
        // spot4
        // 
        spot4.Location = new Point(384, 56);
        spot4.Margin = new Padding(4, 0, 4, 0);
        spot4.Name = "spot4";
        spot4.Size = new Size(29, 21);
        spot4.TabIndex = 168;
        spot4.Text = "01";
        // 
        // but3
        // 
        but3.Location = new Point(315, 28);
        but3.Margin = new Padding(4, 4, 4, 4);
        but3.Name = "but3";
        but3.Size = new Size(61, 20);
        but3.TabIndex = 191;
        but3.Text = "03";
        but3.UseVisualStyleBackColor = true;
        but3.CheckedChanged += But3CheckedChanged;
        // 
        // spot3
        // 
        spot3.Location = new Point(320, 56);
        spot3.Margin = new Padding(4, 0, 4, 0);
        spot3.Name = "spot3";
        spot3.Size = new Size(29, 21);
        spot3.TabIndex = 167;
        spot3.Text = "01";
        // 
        // but2
        // 
        but2.Location = new Point(256, 28);
        but2.Margin = new Padding(4, 4, 4, 4);
        but2.Name = "but2";
        but2.Size = new Size(61, 20);
        but2.TabIndex = 186;
        but2.Text = "02";
        but2.UseVisualStyleBackColor = true;
        but2.CheckedChanged += But2CheckedChanged;
        // 
        // spot2
        // 
        spot2.Location = new Point(263, 56);
        spot2.Margin = new Padding(4, 0, 4, 0);
        spot2.Name = "spot2";
        spot2.Size = new Size(29, 21);
        spot2.TabIndex = 166;
        spot2.Text = "01";
        // 
        // but1
        // 
        but1.Location = new Point(197, 28);
        but1.Margin = new Padding(4, 4, 4, 4);
        but1.Name = "but1";
        but1.Size = new Size(61, 20);
        but1.TabIndex = 190;
        but1.Text = "01";
        but1.UseVisualStyleBackColor = true;
        but1.CheckedChanged += But1CheckedChanged;
        // 
        // spot1
        // 
        spot1.Location = new Point(212, 56);
        spot1.Margin = new Padding(4, 0, 4, 0);
        spot1.Name = "spot1";
        spot1.Size = new Size(29, 21);
        spot1.TabIndex = 165;
        spot1.Text = "01";
        // 
        // but0
        // 
        but0.Checked = true;
        but0.Location = new Point(137, 28);
        but0.Margin = new Padding(4, 4, 4, 4);
        but0.Name = "but0";
        but0.Size = new Size(61, 20);
        but0.TabIndex = 185;
        but0.TabStop = true;
        but0.Text = "00";
        but0.UseVisualStyleBackColor = true;
        but0.CheckedChanged += But0CheckedChanged;
        // 
        // spot0
        // 
        spot0.Location = new Point(144, 56);
        spot0.Margin = new Padding(4, 0, 4, 0);
        spot0.Name = "spot0";
        spot0.Size = new Size(29, 21);
        spot0.TabIndex = 164;
        spot0.Text = "01";
        // 
        // mdv_box
        // 
        mdv_box.Controls.Add(infobut);
        mdv_box.Controls.Add(u32);
        mdv_box.Controls.Add(label3);
        mdv_box.Controls.Add(u16);
        mdv_box.Controls.Add(tid_hi);
        mdv_box.Controls.Add(label4);
        mdv_box.Controls.Add(tid_lo);
        mdv_box.Controls.Add(mdv3);
        mdv_box.Controls.Add(mdv0);
        mdv_box.Controls.Add(mdv2);
        mdv_box.Controls.Add(mdv1);
        mdv_box.Location = new Point(85, 140);
        mdv_box.Margin = new Padding(4, 4, 4, 4);
        mdv_box.Name = "mdv_box";
        mdv_box.Padding = new Padding(4, 4, 4, 4);
        mdv_box.Size = new Size(737, 109);
        mdv_box.TabIndex = 150;
        mdv_box.TabStop = false;
        mdv_box.Text = "Advanced (direct HEX view)";
        mdv_box.Visible = false;
        // 
        // infobut
        // 
        infobut.Location = new Point(627, 75);
        infobut.Margin = new Padding(4, 4, 4, 4);
        infobut.Name = "infobut";
        infobut.Size = new Size(100, 26);
        infobut.TabIndex = 162;
        infobut.Text = "Info";
        infobut.UseVisualStyleBackColor = true;
        infobut.Click += InfobutClick;
        // 
        // u32
        // 
        u32.Location = new Point(355, 46);
        u32.Margin = new Padding(4, 0, 4, 0);
        u32.Name = "u32";
        u32.Size = new Size(264, 56);
        u32.TabIndex = 160;
        u32.Text = "MDV u32";
        // 
        // label3
        // 
        label3.Location = new Point(8, 19);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(60, 22);
        label3.TabIndex = 151;
        label3.Text = "TID:";
        label3.TextAlign = ContentAlignment.TopRight;
        // 
        // u16
        // 
        u16.Location = new Point(76, 46);
        u16.Margin = new Padding(4, 0, 4, 0);
        u16.Name = "u16";
        u16.Size = new Size(159, 56);
        u16.TabIndex = 159;
        u16.Text = "TID u16";
        // 
        // tid_hi
        // 
        tid_hi.Hexadecimal = true;
        tid_hi.Location = new Point(144, 16);
        tid_hi.Margin = new Padding(4, 4, 4, 4);
        tid_hi.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        tid_hi.Name = "tid_hi";
        tid_hi.Size = new Size(60, 25);
        tid_hi.TabIndex = 152;
        tid_hi.ValueChanged += Tid_hiValueChanged;
        // 
        // label4
        // 
        label4.Location = new Point(287, 20);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(60, 26);
        label4.TabIndex = 158;
        label4.Text = "MDV:";
        label4.TextAlign = ContentAlignment.TopRight;
        // 
        // tid_lo
        // 
        tid_lo.Hexadecimal = true;
        tid_lo.Location = new Point(76, 16);
        tid_lo.Margin = new Padding(4, 4, 4, 4);
        tid_lo.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        tid_lo.Name = "tid_lo";
        tid_lo.Size = new Size(60, 25);
        tid_lo.TabIndex = 153;
        tid_lo.ValueChanged += Tid_loValueChanged;
        // 
        // mdv3
        // 
        mdv3.Hexadecimal = true;
        mdv3.Location = new Point(559, 17);
        mdv3.Margin = new Padding(4, 4, 4, 4);
        mdv3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        mdv3.Name = "mdv3";
        mdv3.Size = new Size(60, 25);
        mdv3.TabIndex = 157;
        mdv3.ValueChanged += Mdv3ValueChanged;
        // 
        // mdv0
        // 
        mdv0.Hexadecimal = true;
        mdv0.Location = new Point(355, 17);
        mdv0.Margin = new Padding(4, 4, 4, 4);
        mdv0.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        mdv0.Name = "mdv0";
        mdv0.Size = new Size(60, 25);
        mdv0.TabIndex = 154;
        mdv0.ValueChanged += Mdv0ValueChanged;
        // 
        // mdv2
        // 
        mdv2.Hexadecimal = true;
        mdv2.Location = new Point(491, 17);
        mdv2.Margin = new Padding(4, 4, 4, 4);
        mdv2.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        mdv2.Name = "mdv2";
        mdv2.Size = new Size(60, 25);
        mdv2.TabIndex = 156;
        mdv2.ValueChanged += Mdv2ValueChanged;
        // 
        // mdv1
        // 
        mdv1.Hexadecimal = true;
        mdv1.Location = new Point(423, 17);
        mdv1.Margin = new Padding(4, 4, 4, 4);
        mdv1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        mdv1.Name = "mdv1";
        mdv1.Size = new Size(60, 25);
        mdv1.TabIndex = 155;
        mdv1.ValueChanged += Mdv1ValueChanged;
        // 
        // panel_info
        // 
        panel_info.Controls.Add(close_info);
        panel_info.Controls.Add(label5);
        panel_info.Controls.Add(label7);
        panel_info.Controls.Add(label6);
        panel_info.Dock = DockStyle.Fill;
        panel_info.Location = new Point(0, 0);
        panel_info.Margin = new Padding(4, 4, 4, 4);
        panel_info.Name = "panel_info";
        panel_info.Size = new Size(985, 570);
        panel_info.TabIndex = 0;
        panel_info.Visible = false;
        // 
        // close_info
        // 
        close_info.Location = new Point(876, 531);
        close_info.Margin = new Padding(4, 4, 4, 4);
        close_info.Name = "close_info";
        close_info.Size = new Size(80, 26);
        close_info.TabIndex = 2;
        close_info.Text = "Close";
        close_info.UseVisualStyleBackColor = true;
        close_info.Click += Close_infoClick;
        // 
        // label5
        // 
        label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(16, 100);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(905, 459);
        label5.TabIndex = 0;
        // 
        // label7
        // 
        label7.Location = new Point(16, 46);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(940, 51);
        label7.TabIndex = 3;
        // 
        // label6
        // 
        label6.Location = new Point(16, 10);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(940, 51);
        label6.TabIndex = 1;
        // 
        // SafariMirageForm
        // 
        AutoScaleDimensions = new SizeF(8F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(985, 570);
        Controls.Add(panel_info);
        Controls.Add(orasbox);
        Controls.Add(unlock_safari);
        Controls.Add(groupBox7);
        Controls.Add(label35);
        Controls.Add(ev_0);
        Controls.Add(ev_1);
        Controls.Add(ev_2);
        Controls.Add(ev_3);
        Controls.Add(ev_4);
        Controls.Add(ev_5);
        Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 4, 4, 4);
        Name = "SafariMirageForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "XYORAS Safari Mirage Tool";
        ((ISupportInitialize)ev_5).EndInit();
        ((ISupportInitialize)ev_4).EndInit();
        ((ISupportInitialize)ev_3).EndInit();
        ((ISupportInitialize)ev_2).EndInit();
        ((ISupportInitialize)ev_1).EndInit();
        ((ISupportInitialize)ev_0).EndInit();
        groupBox7.ResumeLayout(false);
        groupBox7.PerformLayout();
        orasbox.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        mdv_box.ResumeLayout(false);
        ((ISupportInitialize)tid_hi).EndInit();
        ((ISupportInitialize)tid_lo).EndInit();
        ((ISupportInitialize)mdv3).EndInit();
        ((ISupportInitialize)mdv0).EndInit();
        ((ISupportInitialize)mdv2).EndInit();
        ((ISupportInitialize)mdv1).EndInit();
        panel_info.ResumeLayout(false);
        ResumeLayout(false);
    }
}

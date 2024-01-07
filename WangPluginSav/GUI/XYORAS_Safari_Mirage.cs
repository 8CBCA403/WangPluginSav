namespace XYORAS_Safari_Mirage_Tool;
partial class SafariMirageForm : Form
{
    private int game;

    private string linkfile;

    private byte[] savebuffer_XY = new byte[415232];

    private byte[] savebuffer_ORAS = new byte[483328];

    private byte[] linkbuffer = new byte[2631];

    private int[] mirage_slots = new int[10];

    private int pss_slot;



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


}

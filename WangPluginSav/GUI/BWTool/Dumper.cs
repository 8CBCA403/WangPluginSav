/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 02/03/2016
 * Time: 0:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BW_tool
{
    /// <summary>
    /// Description of Form1.
    /// </summary>
    public partial class Dumper : Form
    {
        public Dumper()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            if (BWToolMainForm.save.B2W2)
            {
                selectedblock.Visible = true;
                BW_blocklist.Visible = false;
                selectedblock.SelectedIndex = 0;
                selectedblock.DropDownStyle = ComboBoxStyle.DropDownList;
                blockindex = (int)selectedblock.SelectedIndex;

            }
            else
            {
                selectedblock.Visible = false;
                BW_blocklist.Visible = true;
                BW_blocklist.SelectedIndex = 0;
                BW_blocklist.DropDownStyle = ComboBoxStyle.DropDownList;
                blockindex = (int)BW_blocklist.SelectedIndex;
            }

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        internal int blockindex = 0;

        public string binaryfilter = "Binary data|*.bin|All Files (*.*)|*.*";
        void Dump_butClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            //saveFD.InitialDirectory = "c:\\";
            saveFD.Filter = binaryfilter;
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream saveFile;
                saveFile = new FileStream(saveFD.FileName, FileMode.Create);
                //Write file
                saveFile.Write(BWToolMainForm.save.getBlock(blockindex), 0, BWToolMainForm.save.getBlockLength(blockindex));
                saveFile.Close();
                MessageBox.Show("File Saved.", "Save file");
            }
        }
        public byte[] injectfile;
        void Inject_butClick(object sender, EventArgs e)
        {
            string path = null;
            FileIO.load_file(ref injectfile, ref path, binaryfilter);
            BWToolMainForm.save.setBlock(injectfile, blockindex);
            //MessageBox.Show(injectfile.Length.ToString());
        }
        void Dump_dec_butClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            //saveFD.InitialDirectory = "c:\\";
            saveFD.Filter = binaryfilter;
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream saveFile;
                saveFile = new FileStream(saveFD.FileName, FileMode.Create);
                //Write file
                saveFile.Write(BWToolMainForm.save.getBlockDec(blockindex), 0, BWToolMainForm.save.getBlockLength(blockindex));
                saveFile.Close();
                MessageBox.Show("File Saved.", "Save file");
            }
        }
        void Inject_crypt_butClick(object sender, EventArgs e)
        {
            string path = null;
            FileIO.load_file(ref injectfile, ref path, binaryfilter);
            BWToolMainForm.save.setBlockCrypt(injectfile, blockindex);
            //MessageBox.Show(injectfile.Length.ToString());
        }
        void Crypt_checkCheckedChanged(object sender, EventArgs e)
        {
            if (BWToolMainForm.save.blocks[blockindex].encrypted)
            {
                dump_dec_but.Enabled = true;
                inject_crypt_but.Enabled = true;
            }
            else
            {
                dump_dec_but.Enabled = false;
                inject_crypt_but.Enabled = false;
            }
        }
        void SelectedblockSelectedIndexChanged(object sender, EventArgs e)
        {
            blockindex = (int)selectedblock.SelectedIndex;
            if (BWToolMainForm.save.blocks[blockindex].encrypted)
                crypt_check.Checked = true;
            else
                crypt_check.Checked = false;
        }
        void BW_blocklistSelectedIndexChanged(object sender, EventArgs e)
        {
            blockindex = (int)BW_blocklist.SelectedIndex;
            if (BWToolMainForm.save.blocks[blockindex].encrypted)
                crypt_check.Checked = true;
            else
                crypt_check.Checked = false;
        }
    }
}

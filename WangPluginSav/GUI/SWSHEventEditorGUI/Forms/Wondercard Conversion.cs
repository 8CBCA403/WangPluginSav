using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using PKHeX.Core;

namespace WangPluginSav
{
    public partial class Wonder2FashionForm : Form
    {
        public SAV8SWSH SAV;
        string[] fashionItems;
#pragma warning disable CS8618
        public Wonder2FashionForm(ISaveFileProvider Save)
        {
            SAV = (SAV8SWSH)Save.SAV;
            InitializeComponent();
            fashionItems = Array.Empty<string>();
        }

        string[] OpenWonderCardDLG(string type)
        {
            string[] temp = Array.Empty<string>();
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Multiselect = true;
                dlg.Title = $"请选择 Wondercard {type} 文件";
                dlg.Filter = "Gen 8 Wondercard 文件 (*.wc8)|*.wc8";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    temp = dlg.FileNames;
                }
            }
            return temp;
        }
        #region Fashion


        private void fash_openwc8_BTN_Click(object sender, EventArgs e)
        {
            fashionItems = OpenWonderCardDLG("Fasion");
            string[] array = fashionItems;
            for (int i = 0; i < array.Length; i++)
            {
                _ = array[i];
            }
        }

        private void fash_applywc8_BTN_Click(object sender, EventArgs e)
        {
            fashion_Convert();

        }

        private void fashion_Convert()
        {
            List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
            int num = 32;
            if (SAV.Gender == 1)
            {
                num += 48;
            }
            string[] array = fashionItems;
            for (int i = 0; i < array.Length; i++)
            {
                using (BinaryReader binaryReader = new BinaryReader(File.Open(array[i], FileMode.Open)))
                {
                    binaryReader.BaseStream.Position = num;
                    for (int j = 0; j < 6; j++)
                    {
                        int key = binaryReader.ReadInt32();
                        int value = binaryReader.ReadInt32();
                        list.Add(new KeyValuePair<int, int>(key, value));
                    }
                    binaryReader.Close();
                }
                for (int k = 0; k < 6; k++)
                {
                    _ = list[k].Value;
                    _ = -1;
                }
            }
        }


        #endregion

        private void ts_apply_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

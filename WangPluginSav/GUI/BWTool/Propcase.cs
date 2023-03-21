/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 15/03/2021
 * Time: 20:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;

using System.Collections.Generic;
using System.Reflection;
using System.Resources;

namespace BW_tool
{
    /// <summary>
    /// Description of PropCase.
    /// </summary>
    public partial class PropCase : Form
    {
        ResourceManager resources = new ResourceManager("BW_tool.Propcase", Assembly.GetExecutingAssembly());

        PROPCASE myProps;
        public PropCase()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            myProps = new PROPCASE(BWToolMainForm.save.getData(0x1F958, 13));//Same offset for BW1 and BW2. Should update to block management...
            Proplist.SelectedIndex = 0;
            hasprop_checkbox.Checked = myProps.getProp(Proplist.SelectedIndex);
            //propHex.Text = "0x" + BitConverter.ToString(myProps.Data).Replace("-", string.Empty);
            propHex.Text = "0x" + BitConverter.ToString(myProps.Data);


            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        Bitmap sprites_data;
        void showProp()
        {
            string cur_sprite = "Prop_" + Proplist.Text + "_Sprite";
            cur_sprite = cur_sprite.Replace(" ", "_");
            cur_sprite = cur_sprite.Replace("'", string.Empty);
            sprites_data = (Bitmap)resources.GetObject(cur_sprite);
            spriteBox.Image = sprites_data;
        }

        public class PROPCASE
        {
            internal int Size = 13;
            internal int max_props = 99;
            public int props_offset = 0x1F958;

            public byte[] Data;
            public PROPCASE(byte[] data = null)
            {
                Data = data ?? new byte[Size];

            }
            public byte[] getData(int Offset, int Length)
            {
                return Data.Skip(Offset).Take(Length).ToArray();
            }
            public void setData(byte[] input, int Offset)
            {
                input.CopyTo(Data, Offset);
            }

            public bool getProp(int Pos)
            {

                if (Pos > 99)
                    Pos = 99;
                int curbyte = Pos / 8;
                return ((Data[curbyte] & (0x1 << Pos - (curbyte * 8))) != 0);
            }

            public void setProp(int Pos, bool Obtained)
            {
                if (Pos > 99)
                    Pos = 99;
                int curbyte = Pos / 8;
                if (Obtained == true)
                    Data[curbyte] |= (byte)(0x1 << (Pos - (curbyte * 8)));
                else
                    Data[curbyte] &= unchecked((byte)(~(0x1 << (Pos - (curbyte * 8)))));
            }

        }

        void ProplistSelectedIndexChanged(object sender, EventArgs e)
        {
            hasprop_checkbox.Checked = myProps.getProp(Proplist.SelectedIndex);
            showProp();
        }

        void Hasprop_checkboxCheckedChanged(object sender, EventArgs e)
        {
            myProps.setProp(Proplist.SelectedIndex, hasprop_checkbox.Checked);
            propHex.Text = "0x" + BitConverter.ToString(myProps.Data);
        }

        void Exit_butClick(object sender, EventArgs e)
        {
            this.Close();
        }

        void Saveexit_butClick(object sender, EventArgs e)
        {
            //Check that there's at least one prop
            int i = 0;
            while (i < 100)
            {
                if (myProps.getProp(i) == true) break;
                i++;
                if (i == 100)
                {
                    MessageBox.Show("Warning! Game will freeze if you have no props. Pink Barrette has been set by default.");
                    myProps.setProp(0, true); //Set at least one prop
                }
            }

            BWToolMainForm.save.setData(myProps.Data, 0x1F958);
            //Mirror
            BWToolMainForm.save.setData(myProps.Data, 0x45958);
            //Update Checksum
            BWToolMainForm.save.block_crc_recalc(42);
            this.Close();
        }

        void Button1Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < 100; i++)
                myProps.setProp(i, true);
            propHex.Text = "0x" + BitConverter.ToString(myProps.Data);
            hasprop_checkbox.Checked = myProps.getProp(Proplist.SelectedIndex);
            showProp();
        }

        void RemoveAllButClick(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < 100; i++)
                myProps.setProp(i, false);
            propHex.Text = "0x" + BitConverter.ToString(myProps.Data);
            hasprop_checkbox.Checked = myProps.getProp(Proplist.SelectedIndex);
            showProp();
        }
    }
}

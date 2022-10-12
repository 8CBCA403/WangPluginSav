using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WangPluginSav
{
    
    public partial class BWNPCForm : Form
    {
        private ISaveFileProvider SAV { get; }
        private List<NPCName>[] L = new List<NPCName>[10];
      
        private NPCName[] NPC = new NPCName[10];
       
        public BWNPCForm(ISaveFileProvider sav)
        {
            SAV = sav;
            InitializeComponent();
            Initialize();
            BindingData();
        }
        private void BindingData()
        {
           
            for(int i=0;i<10;i++)
            {
                NPC[i] = new NPCName()
                {
                    Name = "None",
                    ID = -1,
                    PKMName = "None"
                 };
            }
            for(int i=0;i<10;i++)
            {
                L[i] = NPCName.IDList(SAV);
                var bindingSource = new BindingSource
                {
                    DataSource = L[i]
                };
                NPCComboBox[i].DataSource = bindingSource.DataSource;
                NPCComboBox[i].DisplayMember = "Name";
                NPCComboBox[i].ValueMember = "ID";
             
            }
            Check(0);
            Check(1);
            Check(2);
            Check(3);
            Check(4);
            Check(5);
            Check(6);
            Check(7);
            Check(8);
            Check(9);
        }
        private void Check(int i)
        {
            this.NPCComboBox[i].SelectedIndexChanged += (_, __) =>
            {
                NPC[i] = (NPCName)this.NPCComboBox[i].SelectedItem;
                NPCTextBox[i].Text = NPC[i].PKMName;
            };
        }
        private void ReadFile()
        {
            var NPCList = new NPC[20];
            var sav = SAV.SAV;
            int p = 129544;
           
            for (int i = 0; i < 20; i++) {
                var b = sav.GetData(p, 1);
                int p2 = p + 1;
                var b2 = sav.GetData(p2, 1);
                int p3 = p2 + 1;
                var b3 = sav.GetData(p3, 1);
                int p4 = p3 + 1;
                var b4 = sav.GetData(p4, 1);
                int p5 = p4 + 1;
                if (b[0] == 1)
                {
                    NPCList[i] = new NPC(b2[0], b3[0], b4[0]);
                }
               
                p = p5 + 20;
            }
            for(int i=0;i<10;i++)
            {
                NPCComboBox[i].SelectedIndex= NPCList[i].getNo()+1;
                FriendsTextBox[i].Text = $"{NPCList[i].getLp()}";
            }
           
        }
        private void WriteFile()
        {
            var sav = SAV.SAV;
            int hp;
            int p1 = 129544;
            int p2 = 277000;
            byte[] b = new byte[1];
            byte[] c = new byte[1];
            for (int i = 0; i < 10; i++)
            {
                if (NPCComboBox[i].SelectedIndex != 0)
                {
                    b[0] = 1;
                    c[0] = (byte)(NPCComboBox[i].SelectedIndex - 1);
                    sav.SetData(b, p1);
                    sav.SetData(b, p2);
                    int p12 = p1 + 1;
                    int p22 = p2 + 1;
                    sav.SetData(c, p12);
                    sav.SetData(c, p22);
                    int p13 = p12 + 1;
                    int p23 = p22 + 1;
                    try
                    {
                        hp = Int16.Parse(FriendsTextBox[i].Text);

                    }
                    catch (Exception e2)
                    {
                        hp = 100;
                    }
                    b[0] = (byte)hp;
                    sav.SetData(b, p13);
                    sav.SetData(b, p23);
                    int p14 = p13 + 1;
                    int p24 = p23 + 1;
                    b[0] = 7;
                    sav.SetData(b, p14);
                    sav.SetData(b, p24);
                    p1 = p14 + 1;
                    p2 = p24 + 1;
                    for (int j = 0; j < 20; j++)
                    {
                        b[0] = 0;
                        sav.SetData(b, p1);
                        sav.SetData(b, p2);
                        p1++;
                        p2++;
                    }
                }
                else
                {
                    for (int j2 = 0; j2 < 24; j2++)
                    {
                        b[0] = 0;
                        sav.SetData(b, p1);
                        sav.SetData(b, p2);
                        p1++;
                        p2++;
                    }
                }
            }
        }

        private void Load_Click(object sender, System.EventArgs e)
        {
            ReadFile();
        }

        private void Save_Click(object sender, System.EventArgs e)
        {
            WriteFile();
        }
    }
}

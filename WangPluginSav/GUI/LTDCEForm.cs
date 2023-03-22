namespace LTDCE
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    public class LTDCEForm : Form
    {
        private uint BGOffset = 0x3d0ce;
        private Button button_OpenPGF;
        private Button button_OpenROM;
        private Button button_SavePGF;
        private Button button_SaveROM;
        private Button button_SaveText;
        private uint CardOffset = 0x3ce00;
        private CheckBox checkBox_BG;
        private CheckBox checkBox_SaveAll;
        private ComboBox comboBox_List;
        private IContainer components;
        private uint DateOffset = 0x3e484;
        private uint JPOffset = 0x3dedf;
        private uint KOROffset = 0x3e1af;
        private Label label_Title;
        private MemoryStream ms = new MemoryStream(0);
        private uint PGFOffset = 0x3ce04;
        private uint ReadLetter;
        private TextBox textBox_Text;
        private uint TextOffset = 0x3ced4;
        private bool ValidROM;
        private Label label1;
        private uint VersionOffset = 0x3ced2;

        public LTDCEForm()
        {
            this.InitializeComponent();
        }

        private void button_OpenPGF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "打开宝可梦神秘礼物文件",
                Filter = "宝可梦神秘礼物文件(*.pgf)|*.pgf"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryReader reader = new BinaryReader(File.OpenRead(dialog.FileName));
                if (reader.BaseStream.Length == 0xccL)
                {
                    if (this.checkBox_SaveAll.Checked)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            this.ms.Position = this.PGFOffset + (i * 720);
                            reader.BaseStream.Position = 0L;
                            for (int j = 0; j < reader.BaseStream.Length; j++)
                            {
                                this.ms.WriteByte(reader.ReadByte());
                            }
                        }
                        reader.Close();
                    }
                    else
                    {
                        this.ms.Position = this.PGFOffset + (this.comboBox_List.SelectedIndex * 720);
                        reader.BaseStream.Position = 0L;
                        for (int k = 0; k < reader.BaseStream.Length; k++)
                        {
                            this.ms.WriteByte(reader.ReadByte());
                        }
                        reader.Close();
                    }
                    this.ShowText();
                }
                else
                {
                    MessageBox.Show("这似乎并不是一个可用的PGF文件", "不可用的PGF文件", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void button_OpenROM_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "打开NDS官方配信ROM",
                Filter = "NDS官方配信ROM(*.nds)|*.nds"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryReader reader = new BinaryReader(File.OpenRead(dialog.FileName))
                {
                    BaseStream = { Position = 0L }
                };
                byte[] buffer = new byte[0x12];
                reader.Read(buffer, 0, 0x12);
                if (Encoding.UTF8.GetString(buffer) == "POKWBLIBERTYY8KP01")
                {
                    this.ValidROM = true;
                    this.button_SaveROM.Enabled = true;
                    this.button_OpenPGF.Enabled = true;
                    this.button_SavePGF.Enabled = true;
                    this.button_SaveText.Enabled = true;
                    this.comboBox_List.Enabled = true;
                    this.textBox_Text.Enabled = true;
                    this.checkBox_SaveAll.Enabled = true;
                    this.checkBox_BG.Enabled = true;
                }
                else
                {
                    this.ValidROM = false;
                    this.button_SaveROM.Enabled = false;
                    this.button_OpenPGF.Enabled = false;
                    this.button_SavePGF.Enabled = false;
                    this.button_SaveText.Enabled = false;
                    this.comboBox_List.Enabled = false;
                    this.textBox_Text.Enabled = false;
                    this.checkBox_SaveAll.Enabled = false;
                    this.checkBox_BG.Enabled = false;
                    this.label_Title.Text = "";
                    this.textBox_Text.Text = "";
                    this.comboBox_List.SelectedIndex = 0;
                    reader.Close();
                    MessageBox.Show("这似乎并不是官方配信自由船票ROM", "不可用的ROM", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                if (this.ValidROM)
                {
                    reader.BaseStream.Position = 0L;
                    this.ms.Position = 0L;
                    byte[] buffer2 = new byte[reader.BaseStream.Length];
                    reader.Read(buffer2, 0, (int)reader.BaseStream.Length);
                    this.ms.Write(buffer2, 0, (int)reader.BaseStream.Length);
                    reader.Close();
                    this.ShowText();
                }
            }
        }

        private void button_SavePGF_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Title = "保存宝可梦神秘礼物文件",
                Filter = "宝可梦神秘礼物文件(*.pgf)|*.pgf"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter writer = new BinaryWriter(File.Create(dialog.FileName));
                this.ms.Position = this.PGFOffset + (this.comboBox_List.SelectedIndex * 720);
                writer.BaseStream.Position = 0L;
                for (int i = 0; i < 0xcc; i++)
                {
                    writer.Write((byte)this.ms.ReadByte());
                }
                writer.Close();
                this.ShowText();
            }
        }

        private void button_SaveROM_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Title = "生成NDS自制配信ROM",
                Filter = "NDS自制配信ROM(*.nds)|*.nds"
            };
            this.ms.Position = this.DateOffset;
            for (int i = 0; i < 7; i++)
            {
                this.ms.WriteByte(0);
                this.ms.WriteByte(0);
                this.ms.WriteByte(1);
                this.ms.WriteByte(1);
                this.ms.WriteByte(0xff);
                this.ms.WriteByte(0xff);
                this.ms.WriteByte(12);
                this.ms.WriteByte(0x1f);
            }
            for (int j = 0; j < 7; j++)
            {
                this.ms.Position = this.VersionOffset + (j * 720);
                this.ms.WriteByte(240);
            }
            this.ms.Position = this.CardOffset;
            this.ms.WriteByte(7);
            this.ms.Position = this.JPOffset;
            this.ms.WriteByte(1);
            this.ms.Position = this.KOROffset;
            this.ms.WriteByte(8);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(dialog.FileName, this.ms.ToArray());
            }
        }

        private void button_SaveText_Click(object sender, EventArgs e)
        {
            if (this.checkBox_SaveAll.Checked)
            {
                for (int i = 0; i < 7; i++)
                {
                    this.ms.Position = this.TextOffset + (i * 720);
                    for (int j = 0; j < 0x1fa; j++)
                    {
                        this.ms.WriteByte(0xff);
                    }
                    this.ms.Position = this.TextOffset + (i * 720);
                    for (int k = 0; k < this.textBox_Text.Text.Length; k++)
                    {
                        if (this.textBox_Text.Text[k] != '\r')
                        {
                            this.ms.WriteByte(Convert.ToByte((int)(this.textBox_Text.Text[k] - ((this.textBox_Text.Text[k] / 'Ā') * 0x100))));
                            this.ms.WriteByte(Convert.ToByte((int)(this.textBox_Text.Text[k] / 'Ā')));
                        }
                        else
                        {
                            this.ms.WriteByte(0xfe);
                            this.ms.WriteByte(0xff);
                            k++;
                        }
                    }
                }
            }
            else
            {
                this.ms.Position = this.TextOffset + (this.comboBox_List.SelectedIndex * 720);
                for (int m = 0; m < 0x1fa; m++)
                {
                    this.ms.WriteByte(0xff);
                }
                this.ms.Position = this.TextOffset + (this.comboBox_List.SelectedIndex * 720);
                for (int n = 0; n < this.textBox_Text.Text.Length; n++)
                {
                    if (this.textBox_Text.Text[n] != '\r')
                    {
                        this.ms.WriteByte(Convert.ToByte((int)(this.textBox_Text.Text[n] - ((this.textBox_Text.Text[n] / 'Ā') * 0x100))));
                        this.ms.WriteByte(Convert.ToByte((int)(this.textBox_Text.Text[n] / 'Ā')));
                    }
                    else
                    {
                        this.ms.WriteByte(0xfe);
                        this.ms.WriteByte(0xff);
                        n++;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_SaveAll.Checked)
            {
                for (int i = 0; i < 7; i++)
                {
                    this.ms.Position = this.BGOffset + (i * 720);
                    if (this.checkBox_BG.Checked)
                    {
                        this.ms.WriteByte(1);
                    }
                    else
                    {
                        this.ms.WriteByte(0);
                    }
                }
            }
            else
            {
                this.ms.Position = this.BGOffset + (this.comboBox_List.SelectedIndex * 720);
                if (this.checkBox_BG.Checked)
                {
                    this.ms.WriteByte(1);
                }
                else
                {
                    this.ms.WriteByte(0);
                }
            }
        }

        private void comboBox_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ValidROM)
            {
                this.ShowText();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox_List.SelectedIndex = 0;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(LTDCEForm));
            button_OpenROM = new Button();
            button_SaveROM = new Button();
            button_OpenPGF = new Button();
            button_SavePGF = new Button();
            button_SaveText = new Button();
            comboBox_List = new ComboBox();
            label_Title = new Label();
            textBox_Text = new TextBox();
            checkBox_BG = new CheckBox();
            checkBox_SaveAll = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_OpenROM
            // 
            button_OpenROM.Location = new Point(16, 8);
            button_OpenROM.Margin = new Padding(4);
            button_OpenROM.Name = "button_OpenROM";
            button_OpenROM.Size = new Size(149, 50);
            button_OpenROM.TabIndex = 0;
            button_OpenROM.Text = "打开官方配信ROM";
            button_OpenROM.UseVisualStyleBackColor = true;
            button_OpenROM.Click += button_OpenROM_Click;
            // 
            // button_SaveROM
            // 
            button_SaveROM.Enabled = false;
            button_SaveROM.Location = new Point(191, 8);
            button_SaveROM.Margin = new Padding(4);
            button_SaveROM.Name = "button_SaveROM";
            button_SaveROM.Size = new Size(149, 50);
            button_SaveROM.TabIndex = 1;
            button_SaveROM.Text = "生成自制配信ROM";
            button_SaveROM.UseVisualStyleBackColor = true;
            button_SaveROM.Click += button_SaveROM_Click;
            // 
            // button_OpenPGF
            // 
            button_OpenPGF.Enabled = false;
            button_OpenPGF.Location = new Point(16, 62);
            button_OpenPGF.Margin = new Padding(4);
            button_OpenPGF.Name = "button_OpenPGF";
            button_OpenPGF.Size = new Size(149, 44);
            button_OpenPGF.TabIndex = 2;
            button_OpenPGF.Text = "导入神秘礼物\nPGF文件";
            button_OpenPGF.UseVisualStyleBackColor = true;
            button_OpenPGF.Click += button_OpenPGF_Click;
            // 
            // button_SavePGF
            // 
            button_SavePGF.Enabled = false;
            button_SavePGF.Location = new Point(191, 62);
            button_SavePGF.Margin = new Padding(4);
            button_SavePGF.Name = "button_SavePGF";
            button_SavePGF.Size = new Size(149, 44);
            button_SavePGF.TabIndex = 3;
            button_SavePGF.Text = "导出神秘礼物\nPGF文件";
            button_SavePGF.UseVisualStyleBackColor = true;
            button_SavePGF.Click += button_SavePGF_Click;
            // 
            // button_SaveText
            // 
            button_SaveText.BackgroundImageLayout = ImageLayout.Center;
            button_SaveText.Enabled = false;
            button_SaveText.Location = new Point(360, 62);
            button_SaveText.Margin = new Padding(4);
            button_SaveText.Name = "button_SaveText";
            button_SaveText.Size = new Size(120, 44);
            button_SaveText.TabIndex = 4;
            button_SaveText.Text = "保存文本";
            button_SaveText.UseVisualStyleBackColor = true;
            button_SaveText.Click += button_SaveText_Click;
            // 
            // comboBox_List
            // 
            comboBox_List.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_List.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_List.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_List.Enabled = false;
            comboBox_List.FormattingEnabled = true;
            comboBox_List.Items.AddRange(new object[] { "英语", "法语", "意大利语", "德语", "西班牙语", "日语", "韩语" });
            comboBox_List.Location = new Point(360, 32);
            comboBox_List.Margin = new Padding(4);
            comboBox_List.Name = "comboBox_List";
            comboBox_List.Size = new Size(119, 23);
            comboBox_List.TabIndex = 5;
            comboBox_List.SelectedIndexChanged += comboBox_List_SelectedIndexChanged;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Location = new Point(16, 112);
            label_Title.Margin = new Padding(4, 0, 4, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(0, 15);
            label_Title.TabIndex = 7;
            // 
            // textBox_Text
            // 
            textBox_Text.Enabled = false;
            textBox_Text.Location = new Point(16, 141);
            textBox_Text.Margin = new Padding(4);
            textBox_Text.MaxLength = 252;
            textBox_Text.Multiline = true;
            textBox_Text.Name = "textBox_Text";
            textBox_Text.Size = new Size(463, 114);
            textBox_Text.TabIndex = 8;
            // 
            // checkBox_BG
            // 
            checkBox_BG.AutoSize = true;
            checkBox_BG.Enabled = false;
            checkBox_BG.Location = new Point(244, 262);
            checkBox_BG.Margin = new Padding(4);
            checkBox_BG.Name = "checkBox_BG";
            checkBox_BG.Size = new Size(93, 19);
            checkBox_BG.TabIndex = 10;
            checkBox_BG.Text = "黑色背景";
            checkBox_BG.UseVisualStyleBackColor = true;
            checkBox_BG.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox_SaveAll
            // 
            checkBox_SaveAll.AutoSize = true;
            checkBox_SaveAll.Enabled = false;
            checkBox_SaveAll.Location = new Point(16, 262);
            checkBox_SaveAll.Margin = new Padding(4);
            checkBox_SaveAll.Name = "checkBox_SaveAll";
            checkBox_SaveAll.Size = new Size(189, 19);
            checkBox_SaveAll.TabIndex = 11;
            checkBox_SaveAll.Text = "将变化保存到所有槽位";
            checkBox_SaveAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(357, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 35;
            label1.Text = "语种：";
            // 
            // LTDCEForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 289);
            Controls.Add(label1);
            Controls.Add(checkBox_SaveAll);
            Controls.Add(checkBox_BG);
            Controls.Add(textBox_Text);
            Controls.Add(label_Title);
            Controls.Add(comboBox_List);
            Controls.Add(button_SaveText);
            Controls.Add(button_SavePGF);
            Controls.Add(button_OpenPGF);
            Controls.Add(button_SaveROM);
            Controls.Add(button_OpenROM);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LTDCEForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liberty Ticket Distribution Card Editor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void ShowText()
        {
            this.ms.Position = (this.PGFOffset + (this.comboBox_List.SelectedIndex * 720)) + 0x60L;
            this.label_Title.Text = "";
            for (int i = 0; i < 0x24; i++)
            {
                this.label_Title.Text = this.label_Title.Text + Convert.ToChar((int)(this.ms.ReadByte() + (this.ms.ReadByte() * 0x100)));
            }
            this.ms.Position = this.TextOffset + (this.comboBox_List.SelectedIndex * 720);
            this.textBox_Text.Text = "";
            for (int j = 0; j < 0xfb; j++)
            {
                this.ReadLetter = Convert.ToUInt32((int)(this.ms.ReadByte() + (this.ms.ReadByte() * 0x100)));
                if ((this.ReadLetter != 0xffff) && (this.ReadLetter != 0xfffe))
                {
                    this.textBox_Text.Text = this.textBox_Text.Text + Convert.ToChar(this.ReadLetter);
                }
                else if (this.ReadLetter == 0xfffe)
                {
                    this.textBox_Text.Text = this.textBox_Text.Text + "\r\n";
                }
            }
            this.ms.Position = this.BGOffset + (this.comboBox_List.SelectedIndex * 720);
            this.ReadLetter = (uint)this.ms.ReadByte();
            if (this.ReadLetter == 0)
            {
                this.checkBox_BG.Checked = false;
            }
            else
            {
                this.checkBox_BG.Checked = true;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class WCN_editor
    {
        private System.ComponentModel.IContainer components = null;
        private Button load_wc3_but;

        private Button save_wc3_but;

        private TextBox wc3_path;

        private Label label1;

        private Label label2;

        private Label label3;

        private Label label4;

        private Label label5;

        private Label label6;

        private Label label7;

        private Label label8;

        private TextBox header1;

        private TextBox body5;

        private TextBox body1;

        private TextBox body2;

        private TextBox body3;

        private TextBox body4;

        private TextBox body6;

        private TextBox body7;

        private CheckBox distrocheck;

        private Label label9;

        private ComboBox colorbox;

        private Label label10;

        private Label label11;

        private Label label12;

        private TextBox body8;

        private TextBox body9;

        private TextBox body10;

        private Label regionlab;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WCN_editor));
            load_wc3_but = new Button();
            save_wc3_but = new Button();
            wc3_path = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            header1 = new TextBox();
            body5 = new TextBox();
            body1 = new TextBox();
            body2 = new TextBox();
            body3 = new TextBox();
            body4 = new TextBox();
            body6 = new TextBox();
            body7 = new TextBox();
            distrocheck = new CheckBox();
            colorbox = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            body8 = new TextBox();
            body9 = new TextBox();
            body10 = new TextBox();
            regionlab = new Label();
            SuspendLayout();
            // 
            // load_wc3_but
            // 
            load_wc3_but.Location = new Point(36, 13);
            load_wc3_but.Margin = new Padding(4);
            load_wc3_but.Name = "load_wc3_but";
            load_wc3_but.Size = new Size(100, 26);
            load_wc3_but.TabIndex = 0;
            load_wc3_but.Text = "读取神秘\r新闻文件";
            load_wc3_but.UseVisualStyleBackColor = true;
            load_wc3_but.Click += Load_wc3_butClick;
            // 
            // save_wc3_but
            // 
            save_wc3_but.Enabled = false;
            save_wc3_but.Location = new Point(144, 12);
            save_wc3_but.Margin = new Padding(4);
            save_wc3_but.Name = "save_wc3_but";
            save_wc3_but.Size = new Size(105, 26);
            save_wc3_but.TabIndex = 1;
            save_wc3_but.Text = "保存神秘\r新闻文件";
            save_wc3_but.UseVisualStyleBackColor = true;
            save_wc3_but.Click += Save_wc3_butClick;
            // 
            // wc3_path
            // 
            wc3_path.Location = new Point(257, 13);
            wc3_path.Margin = new Padding(4);
            wc3_path.Name = "wc3_path";
            wc3_path.ReadOnly = true;
            wc3_path.Size = new Size(370, 25);
            wc3_path.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(36, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 26);
            label1.TabIndex = 3;
            label1.Text = "标题";
            // 
            // label2
            // 
            label2.Location = new Point(36, 214);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 26);
            label2.TabIndex = 4;
            label2.Text = "正文5";
            // 
            // label3
            // 
            label3.Location = new Point(36, 108);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 26);
            label3.TabIndex = 5;
            label3.Text = "正文1";
            // 
            // label4
            // 
            label4.Location = new Point(36, 135);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 26);
            label4.TabIndex = 6;
            label4.Text = "正文2";
            // 
            // label5
            // 
            label5.Location = new Point(36, 161);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 26);
            label5.TabIndex = 7;
            label5.Text = "正文3";
            // 
            // label6
            // 
            label6.Location = new Point(36, 188);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 26);
            label6.TabIndex = 8;
            label6.Text = "正文4";
            // 
            // label7
            // 
            label7.Location = new Point(36, 241);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 26);
            label7.TabIndex = 9;
            label7.Text = "正文6";
            // 
            // label8
            // 
            label8.Location = new Point(36, 268);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(133, 26);
            label8.TabIndex = 10;
            label8.Text = "正文7";
            // 
            // header1
            // 
            header1.Location = new Point(123, 78);
            header1.Margin = new Padding(4);
            header1.MaxLength = 40;
            header1.Name = "header1";
            header1.Size = new Size(504, 25);
            header1.TabIndex = 11;
            header1.TextChanged += Header1TextChanged;
            // 
            // body5
            // 
            body5.Location = new Point(123, 211);
            body5.Margin = new Padding(4);
            body5.MaxLength = 40;
            body5.Name = "body5";
            body5.Size = new Size(504, 25);
            body5.TabIndex = 16;
            body5.TextChanged += Body5TextChanged;
            // 
            // body1
            // 
            body1.Location = new Point(123, 105);
            body1.Margin = new Padding(4);
            body1.MaxLength = 40;
            body1.Name = "body1";
            body1.Size = new Size(504, 25);
            body1.TabIndex = 12;
            body1.TextChanged += Body1TextChanged;
            // 
            // body2
            // 
            body2.Location = new Point(123, 131);
            body2.Margin = new Padding(4);
            body2.MaxLength = 40;
            body2.Name = "body2";
            body2.Size = new Size(504, 25);
            body2.TabIndex = 13;
            body2.TextChanged += Body2TextChanged;
            // 
            // body3
            // 
            body3.Location = new Point(123, 158);
            body3.Margin = new Padding(4);
            body3.MaxLength = 40;
            body3.Name = "body3";
            body3.Size = new Size(504, 25);
            body3.TabIndex = 14;
            body3.TextChanged += Body3TextChanged;
            // 
            // body4
            // 
            body4.Location = new Point(123, 184);
            body4.Margin = new Padding(4);
            body4.MaxLength = 40;
            body4.Name = "body4";
            body4.Size = new Size(504, 25);
            body4.TabIndex = 15;
            body4.TextChanged += Body4TextChanged;
            // 
            // body6
            // 
            body6.Location = new Point(123, 238);
            body6.Margin = new Padding(4);
            body6.MaxLength = 40;
            body6.Name = "body6";
            body6.Size = new Size(504, 25);
            body6.TabIndex = 17;
            body6.TextChanged += Body6TextChanged;
            // 
            // body7
            // 
            body7.Location = new Point(123, 264);
            body7.Margin = new Padding(4);
            body7.MaxLength = 40;
            body7.Name = "body7";
            body7.Size = new Size(504, 25);
            body7.TabIndex = 18;
            body7.TextChanged += Body7TextChanged;
            // 
            // distrocheck
            // 
            distrocheck.Location = new Point(489, 44);
            distrocheck.Margin = new Padding(4);
            distrocheck.Name = "distrocheck";
            distrocheck.Size = new Size(138, 28);
            distrocheck.TabIndex = 22;
            distrocheck.Text = "是否可再分享";
            distrocheck.UseVisualStyleBackColor = true;
            // 
            // colorbox
            // 
            colorbox.FormattingEnabled = true;
            colorbox.Items.AddRange(new object[] { "黄色 (0x00)", "水晶 (0x01)", "红色 (0x02)", "绿色 (0x03)", "蓝色 (0x04)", "棕色 (0x05)", "金色 (0x06)", "银色 (0x07)" });
            colorbox.Location = new Point(123, 47);
            colorbox.Margin = new Padding(4);
            colorbox.Name = "colorbox";
            colorbox.Size = new Size(275, 23);
            colorbox.TabIndex = 25;
            colorbox.SelectedIndexChanged += ColorboxSelectedIndexChanged;
            // 
            // label10
            // 
            label10.Location = new Point(35, 47);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(62, 22);
            label10.TabIndex = 26;
            label10.Text = "颜色";
            // 
            // label9
            // 
            label9.Location = new Point(36, 294);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 26);
            label9.TabIndex = 27;
            label9.Text = "正文8";
            // 
            // label11
            // 
            label11.Location = new Point(36, 320);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(133, 26);
            label11.TabIndex = 28;
            label11.Text = "正文9";
            // 
            // label12
            // 
            label12.Location = new Point(36, 347);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(133, 26);
            label12.TabIndex = 29;
            label12.Text = "正文10";
            // 
            // body8
            // 
            body8.Location = new Point(123, 290);
            body8.Margin = new Padding(4);
            body8.MaxLength = 40;
            body8.Name = "body8";
            body8.Size = new Size(504, 25);
            body8.TabIndex = 19;
            body8.TextChanged += Body8TextChanged;
            // 
            // body9
            // 
            body9.Location = new Point(123, 317);
            body9.Margin = new Padding(4);
            body9.MaxLength = 40;
            body9.Name = "body9";
            body9.Size = new Size(504, 25);
            body9.TabIndex = 20;
            body9.TextChanged += Body9TextChanged;
            // 
            // body10
            // 
            body10.Location = new Point(123, 344);
            body10.Margin = new Padding(4);
            body10.MaxLength = 40;
            body10.Name = "body10";
            body10.Size = new Size(504, 25);
            body10.TabIndex = 21;
            body10.TextChanged += Body10TextChanged;
            // 
            // regionlab
            // 
            regionlab.Location = new Point(406, 50);
            regionlab.Margin = new Padding(4, 0, 4, 0);
            regionlab.Name = "regionlab";
            regionlab.Size = new Size(75, 19);
            regionlab.TabIndex = 30;
            regionlab.Text = "美/欧版";
            // 
            // WCN_editor
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 386);
            Controls.Add(regionlab);
            Controls.Add(body10);
            Controls.Add(body9);
            Controls.Add(body8);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(colorbox);
            Controls.Add(distrocheck);
            Controls.Add(body7);
            Controls.Add(body6);
            Controls.Add(body4);
            Controls.Add(body3);
            Controls.Add(body2);
            Controls.Add(body1);
            Controls.Add(body5);
            Controls.Add(header1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wc3_path);
            Controls.Add(save_wc3_but);
            Controls.Add(load_wc3_but);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "WCN_editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "神秘新闻编辑器";
            Load += WCN_editorLoad;
            DragDrop += WCN_editorDragDrop;
            DragEnter += WCN_editorDragEnter;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

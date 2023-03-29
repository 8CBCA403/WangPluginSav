using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikaedit
{
    partial class DLCEditor
    {
        internal Button extractMusical;

        internal CheckBox activeMusical;

        internal Button changeMusical;

        internal GroupBox GroupBox3;

        internal Button extractPokedex;

        internal CheckBox activePokedex;

        internal Button changePokedex;

        internal GroupBox GroupBox2;

        internal Button extractCGear;

        internal Button changeCGear;

        internal CheckBox activeCGear;

        internal GroupBox GroupBox1;

        private Label label1;

        private TextBox musicalTitle;
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLCEditor));
            loadDialog = new OpenFileDialog();
            saveDialog = new SaveFileDialog();
            extractMusical = new Button();
            activeMusical = new CheckBox();
            changeMusical = new Button();
            GroupBox3 = new GroupBox();
            label1 = new Label();
            musicalTitle = new TextBox();
            extractPokedex = new Button();
            activePokedex = new CheckBox();
            changePokedex = new Button();
            GroupBox2 = new GroupBox();
            extractCGear = new Button();
            changeCGear = new Button();
            activeCGear = new CheckBox();
            GroupBox1 = new GroupBox();
            GroupBox3.SuspendLayout();
            GroupBox2.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // extractMusical
            // 
            extractMusical.Location = new Point(8, 109);
            extractMusical.Margin = new Padding(4, 5, 4, 5);
            extractMusical.Name = "extractMusical";
            extractMusical.Size = new Size(100, 35);
            extractMusical.TabIndex = 8;
            extractMusical.Text = "提取";
            extractMusical.UseVisualStyleBackColor = true;
            extractMusical.Click += extract;
            // 
            // activeMusical
            // 
            activeMusical.AutoSize = true;
            activeMusical.Location = new Point(8, 29);
            activeMusical.Margin = new Padding(4, 5, 4, 5);
            activeMusical.Name = "activeMusical";
            activeMusical.Size = new Size(72, 24);
            activeMusical.TabIndex = 6;
            activeMusical.Text = "已激活";
            activeMusical.UseVisualStyleBackColor = true;
            activeMusical.CheckedChanged += activate;
            // 
            // changeMusical
            // 
            changeMusical.Location = new Point(8, 65);
            changeMusical.Margin = new Padding(4, 5, 4, 5);
            changeMusical.Name = "changeMusical";
            changeMusical.Size = new Size(100, 35);
            changeMusical.TabIndex = 7;
            changeMusical.Text = "更换";
            changeMusical.UseVisualStyleBackColor = true;
            changeMusical.Click += change;
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(label1);
            GroupBox3.Controls.Add(musicalTitle);
            GroupBox3.Controls.Add(extractMusical);
            GroupBox3.Controls.Add(activeMusical);
            GroupBox3.Controls.Add(changeMusical);
            GroupBox3.Location = new Point(416, 3);
            GroupBox3.Margin = new Padding(4, 5, 4, 5);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Padding = new Padding(4, 5, 4, 5);
            GroupBox3.Size = new Size(351, 169);
            GroupBox3.TabIndex = 12;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "音乐剧 数据";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 14;
            label1.Text = "音乐剧 标题";
            // 
            // musicalTitle
            // 
            musicalTitle.Location = new Point(123, 65);
            musicalTitle.Margin = new Padding(4, 5, 4, 5);
            musicalTitle.MaxLength = 14;
            musicalTitle.Name = "musicalTitle";
            musicalTitle.Size = new Size(216, 27);
            musicalTitle.TabIndex = 13;
            musicalTitle.TextChanged += musicalTitle_TextChanged;
            // 
            // extractPokedex
            // 
            extractPokedex.Location = new Point(8, 109);
            extractPokedex.Margin = new Padding(4, 5, 4, 5);
            extractPokedex.Name = "extractPokedex";
            extractPokedex.Size = new Size(100, 35);
            extractPokedex.TabIndex = 8;
            extractPokedex.Text = "提取";
            extractPokedex.UseVisualStyleBackColor = true;
            extractPokedex.Click += extract;
            // 
            // activePokedex
            // 
            activePokedex.AutoSize = true;
            activePokedex.Location = new Point(8, 29);
            activePokedex.Margin = new Padding(4, 5, 4, 5);
            activePokedex.Name = "activePokedex";
            activePokedex.Size = new Size(72, 24);
            activePokedex.TabIndex = 6;
            activePokedex.Text = "已激活";
            activePokedex.UseVisualStyleBackColor = true;
            activePokedex.CheckedChanged += activate;
            // 
            // changePokedex
            // 
            changePokedex.Location = new Point(8, 65);
            changePokedex.Margin = new Padding(4, 5, 4, 5);
            changePokedex.Name = "changePokedex";
            changePokedex.Size = new Size(100, 35);
            changePokedex.TabIndex = 7;
            changePokedex.Text = "更换";
            changePokedex.UseVisualStyleBackColor = true;
            changePokedex.Click += change;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(extractPokedex);
            GroupBox2.Controls.Add(activePokedex);
            GroupBox2.Controls.Add(changePokedex);
            GroupBox2.Location = new Point(216, 3);
            GroupBox2.Margin = new Padding(4, 5, 4, 5);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Padding = new Padding(4, 5, 4, 5);
            GroupBox2.Size = new Size(192, 169);
            GroupBox2.TabIndex = 11;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "图鉴 皮肤";
            // 
            // extractCGear
            // 
            extractCGear.Location = new Point(8, 109);
            extractCGear.Margin = new Padding(4, 5, 4, 5);
            extractCGear.Name = "extractCGear";
            extractCGear.Size = new Size(100, 35);
            extractCGear.TabIndex = 5;
            extractCGear.Text = "提取";
            extractCGear.UseVisualStyleBackColor = true;
            extractCGear.Click += extract;
            // 
            // changeCGear
            // 
            changeCGear.Location = new Point(8, 65);
            changeCGear.Margin = new Padding(4, 5, 4, 5);
            changeCGear.Name = "changeCGear";
            changeCGear.Size = new Size(100, 35);
            changeCGear.TabIndex = 4;
            changeCGear.Text = "更换";
            changeCGear.UseVisualStyleBackColor = true;
            changeCGear.Click += change;
            // 
            // activeCGear
            // 
            activeCGear.AutoSize = true;
            activeCGear.Location = new Point(8, 29);
            activeCGear.Margin = new Padding(4, 5, 4, 5);
            activeCGear.Name = "activeCGear";
            activeCGear.Size = new Size(72, 24);
            activeCGear.TabIndex = 3;
            activeCGear.Text = "已激活";
            activeCGear.UseVisualStyleBackColor = true;
            activeCGear.CheckedChanged += activate;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(extractCGear);
            GroupBox1.Controls.Add(changeCGear);
            GroupBox1.Controls.Add(activeCGear);
            GroupBox1.Location = new Point(4, 3);
            GroupBox1.Margin = new Padding(4, 5, 4, 5);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4, 5, 4, 5);
            GroupBox1.Size = new Size(204, 169);
            GroupBox1.TabIndex = 10;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "C-装置 皮肤";
            // 
            // DLCEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 178);
            Controls.Add(GroupBox3);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DLCEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DLC";
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
        }
    }
}

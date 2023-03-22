using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class Decor_editor
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private ComboBox decortypebox;

        private Label label1;

        private NumericUpDown numericUpDown1;

        private Label label2;

        private ComboBox decorationbox;

        private Label Decoration;

        private Button save_but;

        private Button add_but;

        private Button del_but;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decor_editor));
            decortypebox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            decorationbox = new ComboBox();
            Decoration = new Label();
            save_but = new Button();
            numericUpDown1 = new NumericUpDown();
            add_but = new Button();
            del_but = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // decortypebox
            // 
            decortypebox.FormattingEnabled = true;
            decortypebox.Items.AddRange(new object[] { "桌子", "椅子", "盆栽", "物品", "地毯", "海报", "布偶", "垫子" });
            decortypebox.Location = new Point(12, 44);
            decortypebox.Margin = new Padding(4);
            decortypebox.Name = "decortypebox";
            decortypebox.Size = new Size(395, 23);
            decortypebox.TabIndex = 0;
            decortypebox.SelectedIndexChanged += DecortypeboxSelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(12, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 22);
            label1.TabIndex = 1;
            label1.Text = "装饰类型";
            // 
            // label2
            // 
            label2.Location = new Point(12, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 3;
            label2.Text = "槽位";
            // 
            // decorationbox
            // 
            decorationbox.FormattingEnabled = true;
            decorationbox.Items.AddRange(new object[] { "空", "小型桌子", "精灵球桌子", "沉重桌子", "粗糙桌子", "松软桌子", "漂亮桌子", "砖块桌子", "露营桌子", "坚硬桌子" });
            decorationbox.Location = new Point(180, 105);
            decorationbox.Margin = new Padding(4);
            decorationbox.Name = "decorationbox";
            decorationbox.Size = new Size(227, 23);
            decorationbox.TabIndex = 4;
            decorationbox.SelectedIndexChanged += DecorationboxSelectedIndexChanged;
            // 
            // Decoration
            // 
            Decoration.Location = new Point(180, 84);
            Decoration.Margin = new Padding(4, 0, 4, 0);
            Decoration.Name = "Decoration";
            Decoration.Size = new Size(133, 15);
            Decoration.TabIndex = 5;
            Decoration.Text = "装饰物品";
            // 
            // save_but
            // 
            save_but.Location = new Point(145, 150);
            save_but.Margin = new Padding(4);
            save_but.Name = "save_but";
            save_but.Size = new Size(100, 26);
            save_but.TabIndex = 6;
            save_but.Text = "写入记录";
            save_but.UseVisualStyleBackColor = true;
            save_but.Click += Save_butClick;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 103);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(160, 25);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += NumericUpDown1ValueChanged;
            // 
            // add_but
            // 
            add_but.Location = new Point(416, 84);
            add_but.Margin = new Padding(4);
            add_but.Name = "add_but";
            add_but.Size = new Size(49, 26);
            add_but.TabIndex = 7;
            add_but.Text = "添加";
            add_but.UseVisualStyleBackColor = true;
            add_but.Click += Add_butClick;
            // 
            // del_but
            // 
            del_but.Location = new Point(416, 118);
            del_but.Margin = new Padding(4);
            del_but.Name = "del_but";
            del_but.Size = new Size(49, 26);
            del_but.TabIndex = 8;
            del_but.Text = "删除";
            del_but.UseVisualStyleBackColor = true;
            del_but.Click += Del_butClick;
            // 
            // Decor_editor
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 190);
            Controls.Add(del_but);
            Controls.Add(add_but);
            Controls.Add(save_but);
            Controls.Add(Decoration);
            Controls.Add(decorationbox);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(decortypebox);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Decor_editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "装饰物品库存编辑器";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }
    }
}

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
            this.decortypebox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decorationbox = new System.Windows.Forms.ComboBox();
            this.Decoration = new System.Windows.Forms.Label();
            this.save_but = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.add_but = new System.Windows.Forms.Button();
            this.del_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
            base.SuspendLayout();
            this.decortypebox.FormattingEnabled = true;
            this.decortypebox.Items.AddRange(new object[8] { "Desk", "Chair", "Plant", "Ornament", "Mat", "Poster", "Doll", "Cushion" });
            this.decortypebox.Location = new System.Drawing.Point(9, 38);
            this.decortypebox.Name = "decortypebox";
            this.decortypebox.Size = new System.Drawing.Size(297, 21);
            this.decortypebox.TabIndex = 0;
            this.decortypebox.SelectedIndexChanged += new System.EventHandler(DecortypeboxSelectedIndexChanged);
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decoration type";
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slot";
            this.decorationbox.FormattingEnabled = true;
            this.decorationbox.Items.AddRange(new object[10] { "Empty", "Small Desk", "Pokémon Desk", "Heavy Desk", "Ragged Desk", "Comfort Desk", "Pretty Desk", "Brick Desk", "Camp Desk", "Hard Desk" });
            this.decorationbox.Location = new System.Drawing.Point(135, 88);
            this.decorationbox.Name = "decorationbox";
            this.decorationbox.Size = new System.Drawing.Size(171, 21);
            this.decorationbox.TabIndex = 4;
            this.decorationbox.SelectedIndexChanged += new System.EventHandler(DecorationboxSelectedIndexChanged);
            this.Decoration.Location = new System.Drawing.Point(135, 73);
            this.Decoration.Name = "Decoration";
            this.Decoration.Size = new System.Drawing.Size(100, 13);
            this.Decoration.TabIndex = 5;
            this.Decoration.Text = "Decoration";
            this.save_but.Location = new System.Drawing.Point(109, 130);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(75, 23);
            this.save_but.TabIndex = 6;
            this.save_but.Text = "Save";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(Save_butClick);
            this.numericUpDown1.Location = new System.Drawing.Point(9, 89);
            this.numericUpDown1.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[4] { 1, 0, 0, 0 });
            this.numericUpDown1.ValueChanged += new System.EventHandler(NumericUpDown1ValueChanged);
            this.add_but.Location = new System.Drawing.Point(312, 73);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(37, 23);
            this.add_but.TabIndex = 7;
            this.add_but.Text = "Add";
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.Click += new System.EventHandler(Add_butClick);
            this.del_but.Location = new System.Drawing.Point(312, 102);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(37, 23);
            this.del_but.TabIndex = 8;
            this.del_but.Text = "Del";
            this.del_but.UseVisualStyleBackColor = true;
            this.del_but.Click += new System.EventHandler(Del_butClick);
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(366, 165);
            base.Controls.Add(this.del_but);
            base.Controls.Add(this.add_but);
            base.Controls.Add(this.save_but);
            base.Controls.Add(this.Decoration);
            base.Controls.Add(this.decorationbox);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.numericUpDown1);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.decortypebox);
            base.Name = "Decor_editor";
            this.Text = "Decoration Inventory Editor";
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
            base.ResumeLayout(false);
        }
    }
}

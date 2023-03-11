namespace WangPluginSav
{
    partial class Wonder2FashionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            ts_apply_BTN = new ToolStripButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            wondercardControl1 = new GUI.SWSHEventEditorGUI.Controls.WondercardControl();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ts_apply_BTN });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // ts_apply_BTN
            // 
            ts_apply_BTN.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ts_apply_BTN.ImageTransparentColor = Color.Magenta;
            ts_apply_BTN.Name = "ts_apply_BTN";
            ts_apply_BTN.Size = new Size(117, 24);
            ts_apply_BTN.Text = "Apply Selection";
            ts_apply_BTN.Click += ts_apply_BTN_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 27);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 665);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(wondercardControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(776, 632);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Fashion";
            // 
            // wondercardControl1
            // 
            wondercardControl1.Dock = DockStyle.Left;
            wondercardControl1.Location = new Point(4, 5);
            wondercardControl1.Margin = new Padding(5, 8, 5, 8);
            wondercardControl1.Name = "wondercardControl1";
            wondercardControl1.Size = new Size(770, 622);
            wondercardControl1.TabIndex = 0;
            // 
            // Wonder2FashionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 692);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Wonder2FashionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wondercard Conversion";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_apply_BTN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private GUI.SWSHEventEditorGUI.Controls.WondercardControl wondercardControl1;
    }
}
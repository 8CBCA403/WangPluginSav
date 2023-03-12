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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wonder2FashionForm));
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
            toolStrip1.Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ts_apply_BTN });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // ts_apply_BTN
            // 
            ts_apply_BTN.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ts_apply_BTN.ImageTransparentColor = Color.Magenta;
            ts_apply_BTN.Name = "ts_apply_BTN";
            ts_apply_BTN.Size = new Size(107, 22);
            ts_apply_BTN.Text = "应用所选内容";
            ts_apply_BTN.Click += ts_apply_BTN_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 280);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(wondercardControl1);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(776, 251);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "服装";
            // 
            // wondercardControl1
            // 
            wondercardControl1.Dock = DockStyle.Left;
            wondercardControl1.Location = new Point(4, 4);
            wondercardControl1.Margin = new Padding(5, 6, 5, 6);
            wondercardControl1.Name = "wondercardControl1";
            wondercardControl1.Size = new Size(762, 243);
            wondercardControl1.TabIndex = 0;
            // 
            // Wonder2FashionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 305);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Wonder2FashionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "神秘礼物转换";
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
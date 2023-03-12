namespace WangPluginSav.GUI.SWSHEventEditorGUI.Controls
{
    partial class WondercardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            main_LB = new ListBox();
            open_wondercard_BTN = new Button();
            clearlist_BTN = new Button();
            delete_BTN = new Button();
            SuspendLayout();
            // 
            // main_LB
            // 
            main_LB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            main_LB.FormattingEnabled = true;
            main_LB.ItemHeight = 15;
            main_LB.Location = new Point(0, 0);
            main_LB.Margin = new Padding(4, 4, 4, 4);
            main_LB.Name = "main_LB";
            main_LB.Size = new Size(176, 139);
            main_LB.TabIndex = 0;
            main_LB.SelectedIndexChanged += main_LB_SelectedIndexChanged;
            // 
            // open_wondercard_BTN
            // 
            open_wondercard_BTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            open_wondercard_BTN.Location = new Point(185, 4);
            open_wondercard_BTN.Margin = new Padding(4, 4, 4, 4);
            open_wondercard_BTN.Name = "open_wondercard_BTN";
            open_wondercard_BTN.Size = new Size(181, 37);
            open_wondercard_BTN.TabIndex = 1;
            open_wondercard_BTN.Text = "打开神秘礼物文件";
            open_wondercard_BTN.UseVisualStyleBackColor = true;
            open_wondercard_BTN.Click += open_wondercard_BTN_Click;
            // 
            // clearlist_BTN
            // 
            clearlist_BTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearlist_BTN.Enabled = false;
            clearlist_BTN.Location = new Point(185, 47);
            clearlist_BTN.Margin = new Padding(4, 4, 4, 4);
            clearlist_BTN.Name = "clearlist_BTN";
            clearlist_BTN.Size = new Size(181, 37);
            clearlist_BTN.TabIndex = 2;
            clearlist_BTN.Text = "清除列表";
            clearlist_BTN.UseVisualStyleBackColor = true;
            clearlist_BTN.Click += clearlist_BTN_Click;
            // 
            // delete_BTN
            // 
            delete_BTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            delete_BTN.Enabled = false;
            delete_BTN.Location = new Point(185, 92);
            delete_BTN.Margin = new Padding(4, 4, 4, 4);
            delete_BTN.Name = "delete_BTN";
            delete_BTN.Size = new Size(181, 37);
            delete_BTN.TabIndex = 3;
            delete_BTN.Text = "删除";
            delete_BTN.UseVisualStyleBackColor = true;
            delete_BTN.Click += delete_BTN_Click;
            // 
            // WondercardControl
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(delete_BTN);
            Controls.Add(clearlist_BTN);
            Controls.Add(open_wondercard_BTN);
            Controls.Add(main_LB);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "WondercardControl";
            Size = new Size(371, 140);
            Load += WondercardControl_Load;
            Resize += WondercardControl_Resize;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox main_LB;
        private System.Windows.Forms.Button open_wondercard_BTN;
        private System.Windows.Forms.Button clearlist_BTN;
        private System.Windows.Forms.Button delete_BTN;
    }
}

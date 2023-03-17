namespace WangPluginSav;

partial class MirageIslandForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MirageIslandForm));
        LocationLabel = new Label();
        SaveButton = new Button();
        label1 = new Label();
        label2 = new Label();
        groupBox1 = new GroupBox();
        PKMList = new ListBox();
        label3 = new Label();
        MirageIslandSeedBox = new NumericUpDown();
        Reload_BTN = new Button();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)MirageIslandSeedBox).BeginInit();
        SuspendLayout();
        // 
        // LocationLabel
        // 
        LocationLabel.AutoSize = true;
        LocationLabel.Location = new Point(11, 10);
        LocationLabel.Margin = new Padding(5, 0, 5, 0);
        LocationLabel.Name = "LocationLabel";
        LocationLabel.Size = new Size(151, 15);
        LocationLabel.TabIndex = 3;
        LocationLabel.Text = "幻影岛 (130号水路)";
        // 
        // SaveButton
        // 
        SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        SaveButton.Location = new Point(476, 178);
        SaveButton.Margin = new Padding(5, 3, 5, 3);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(80, 30);
        SaveButton.TabIndex = 5;
        SaveButton.Text = "保存";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(11, 10);
        label1.Margin = new Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(39, 15);
        label1.TabIndex = 0;
        label1.Text = "幻岛";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label2.AutoSize = true;
        label2.Location = new Point(11, 186);
        label2.Margin = new Padding(5, 0, 5, 0);
        label2.Name = "label2";
        label2.Size = new Size(39, 15);
        label2.TabIndex = 3;
        label2.Text = "Seed";
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        groupBox1.Controls.Add(PKMList);
        groupBox1.Location = new Point(16, 40);
        groupBox1.Margin = new Padding(5, 3, 5, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(5, 3, 5, 3);
        groupBox1.Size = new Size(540, 126);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "可以让你看到幻影岛的宝可梦";
        // 
        // PKMList
        // 
        PKMList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        PKMList.FormattingEnabled = true;
        PKMList.ItemHeight = 15;
        PKMList.Location = new Point(9, 23);
        PKMList.Margin = new Padding(5, 3, 5, 3);
        PKMList.Name = "PKMList";
        PKMList.SelectionMode = SelectionMode.None;
        PKMList.Size = new Size(521, 94);
        PKMList.TabIndex = 0;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label3.Font = new Font("SimHei", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(151, 171);
        label3.Margin = new Padding(5, 0, 5, 0);
        label3.Name = "label3";
        label3.Size = new Size(225, 50);
        label3.TabIndex = 4;
        label3.Text = "Seed必须匹配您所拥有的宝可梦 PID 的最后4个字符";
        // 
        // MirageIslandSeedBox
        // 
        MirageIslandSeedBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        MirageIslandSeedBox.Hexadecimal = true;
        MirageIslandSeedBox.Location = new Point(63, 183);
        MirageIslandSeedBox.Margin = new Padding(5, 3, 5, 3);
        MirageIslandSeedBox.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        MirageIslandSeedBox.Name = "MirageIslandSeedBox";
        MirageIslandSeedBox.Size = new Size(80, 25);
        MirageIslandSeedBox.TabIndex = 2;
        MirageIslandSeedBox.ValueChanged += MirageIslandSeedBox_ValueChanged;
        // 
        // Reload_BTN
        // 
        Reload_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        Reload_BTN.Location = new Point(386, 177);
        Reload_BTN.Margin = new Padding(5, 3, 5, 3);
        Reload_BTN.Name = "Reload_BTN";
        Reload_BTN.Size = new Size(80, 30);
        Reload_BTN.TabIndex = 6;
        Reload_BTN.Text = "重载";
        Reload_BTN.UseVisualStyleBackColor = true;
        Reload_BTN.Click += Reload_BTN_Click;
        // 
        // MirageIslandForm
        // 
        AutoScaleDimensions = new SizeF(8F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(572, 228);
        Controls.Add(Reload_BTN);
        Controls.Add(MirageIslandSeedBox);
        Controls.Add(label3);
        Controls.Add(groupBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(SaveButton);
        Controls.Add(LocationLabel);
        Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(5, 3, 5, 3);
        MaximizeBox = false;
        MaximumSize = new Size(594, 860);
        MinimumSize = new Size(416, 268);
        Name = "MirageIslandForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "幻影岛工具";
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)MirageIslandSeedBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.Label LocationLabel;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox PKMList;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown MirageIslandSeedBox;
    private Button Reload_BTN;
}
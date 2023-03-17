namespace WangPluginSav;

partial class FeebasLocatorForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeebasLocatorForm));
        TilePanel = new Panel();
        FeebasLocatorPanel = new Panel();
        LocationLabel = new Label();
        FeebasSeedLabel = new Label();
        SaveButton = new Button();
        FeebasSeedBox = new TextBox();
        FeebasLocatorPanel.SuspendLayout();
        SuspendLayout();
        // 
        // TilePanel
        // 
        TilePanel.Location = new Point(0, 0);
        TilePanel.Margin = new Padding(5, 3, 5, 3);
        TilePanel.Name = "TilePanel";
        TilePanel.Size = new Size(266, 115);
        TilePanel.TabIndex = 0;
        // 
        // FeebasLocatorPanel
        // 
        FeebasLocatorPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        FeebasLocatorPanel.AutoScroll = true;
        FeebasLocatorPanel.BorderStyle = BorderStyle.FixedSingle;
        FeebasLocatorPanel.Controls.Add(TilePanel);
        FeebasLocatorPanel.Location = new Point(16, 29);
        FeebasLocatorPanel.Margin = new Padding(5, 3, 5, 3);
        FeebasLocatorPanel.Name = "FeebasLocatorPanel";
        FeebasLocatorPanel.Size = new Size(266, 115);
        FeebasLocatorPanel.TabIndex = 4;
        // 
        // LocationLabel
        // 
        LocationLabel.AutoSize = true;
        LocationLabel.Location = new Point(11, 10);
        LocationLabel.Margin = new Padding(5, 0, 5, 0);
        LocationLabel.Name = "LocationLabel";
        LocationLabel.Size = new Size(0, 15);
        LocationLabel.TabIndex = 3;
        // 
        // FeebasSeedLabel
        // 
        FeebasSeedLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        FeebasSeedLabel.AutoSize = true;
        FeebasSeedLabel.Location = new Point(11, 274);
        FeebasSeedLabel.Margin = new Padding(5, 0, 5, 0);
        FeebasSeedLabel.Name = "FeebasSeedLabel";
        FeebasSeedLabel.Size = new Size(71, 15);
        FeebasSeedLabel.TabIndex = 2;
        FeebasSeedLabel.Text = "钓点Seed";
        // 
        // SaveButton
        // 
        SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        SaveButton.Location = new Point(268, 267);
        SaveButton.Margin = new Padding(5, 3, 5, 3);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(96, 28);
        SaveButton.TabIndex = 1;
        SaveButton.Text = "保存";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // FeebasSeedBox
        // 
        FeebasSeedBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        FeebasSeedBox.CharacterCasing = CharacterCasing.Upper;
        FeebasSeedBox.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FeebasSeedBox.Location = new Point(113, 268);
        FeebasSeedBox.Margin = new Padding(5, 3, 5, 3);
        FeebasSeedBox.Name = "FeebasSeedBox";
        FeebasSeedBox.Size = new Size(132, 27);
        FeebasSeedBox.TabIndex = 5;
        FeebasSeedBox.TextChanged += FeebasSeedBox_TextChanged;
        // 
        // FeebasLocatorForm
        // 
        AutoScaleDimensions = new SizeF(8F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(378, 301);
        Controls.Add(FeebasSeedBox);
        Controls.Add(SaveButton);
        Controls.Add(FeebasSeedLabel);
        Controls.Add(LocationLabel);
        Controls.Add(FeebasLocatorPanel);
        Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(5, 3, 5, 3);
        MaximizeBox = false;
        Name = "FeebasLocatorForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "丑丑鱼钓点工具";
        FeebasLocatorPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel TilePanel;
    private System.Windows.Forms.Panel FeebasLocatorPanel;
    private System.Windows.Forms.Label LocationLabel;
    private System.Windows.Forms.Label FeebasSeedLabel;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.TextBox FeebasSeedBox;
}
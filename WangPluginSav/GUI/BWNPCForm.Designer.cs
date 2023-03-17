namespace WangPluginSav.GUI
{
    partial class BWNPCForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ComboBox[] NPCComboBox = new ComboBox[10];
        private TextBox[] NPCTextBox = new TextBox[10];
        private TextBox[] FriendsTextBox = new TextBox[10];

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BWNPCForm));
            Load_BTN = new Button();
            Save_BTN = new Button();
            SuspendLayout();
            // 
            // Load_BTN
            // 
            Load_BTN.Location = new Point(65, 386);
            Load_BTN.Name = "Load_BTN";
            Load_BTN.Size = new Size(121, 23);
            Load_BTN.TabIndex = 0;
            Load_BTN.Text = "Load";
            Load_BTN.UseVisualStyleBackColor = true;
            Load_BTN.Click += Load_Click;
            // 
            // Save_BTN
            // 
            Save_BTN.Location = new Point(361, 386);
            Save_BTN.Name = "Save_BTN";
            Save_BTN.Size = new Size(121, 23);
            Save_BTN.TabIndex = 1;
            Save_BTN.Text = "Save";
            Save_BTN.UseVisualStyleBackColor = true;
            Save_BTN.Click += Save_Click;
            // 
            // BWNPCForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 431);
            Controls.Add(Save_BTN);
            Controls.Add(Load_BTN);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BWNPCForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Wang";
            ResumeLayout(false);
        }

        #endregion
        private void Initialize()
        {
            for (int i = 0; i < 10; i++)
            {
                NPCComboBox[i] = new ComboBox()
                {
                    FormattingEnabled = true,
                    Location = new System.Drawing.Point(50, 12 + i * 30),
                    Name = $"NPC{i}ComboBox",
                    Size = new System.Drawing.Size(121, 23),
                    TabIndex = 2 + i,

                };
                this.Controls.Add(NPCComboBox[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                NPCTextBox[i] = new TextBox()
                {
                    Location = new System.Drawing.Point(180, 12 + i * 30),
                    Name = $"NPC{i}TextBox",
                    Size = new System.Drawing.Size(121, 25),
                    Text = "None",
                    TabIndex = 12 + i,

                };
                this.Controls.Add(NPCTextBox[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                FriendsTextBox[i] = new TextBox()
                {
                    Location = new System.Drawing.Point(310, 12 + i * 30),
                    Name = $"Friend{i}TextBox",
                    Size = new System.Drawing.Size(121, 25),
                    Text = "0",
                    TabIndex = 22 + i,

                };
                this.Controls.Add(FriendsTextBox[i]);
            }
        }
        private System.Windows.Forms.Button Load_BTN;
        private System.Windows.Forms.Button Save_BTN;


    }
}
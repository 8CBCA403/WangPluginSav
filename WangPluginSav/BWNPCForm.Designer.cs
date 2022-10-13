using System.Windows.Forms;
namespace WangPluginSav
{
    partial class BWNPCForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ComboBox[] NPCComboBox =new ComboBox[10];
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
            this.Load_BTN = new System.Windows.Forms.Button();
            this.Save_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Load_BTN
            // 
            this.Load_BTN.Location = new System.Drawing.Point(105, 386);
            this.Load_BTN.Name = "Load_BTN";
            this.Load_BTN.Size = new System.Drawing.Size(121, 23);
            this.Load_BTN.TabIndex = 0;
            this.Load_BTN.Text = "Load";
            this.Load_BTN.UseVisualStyleBackColor = true;
            this.Load_BTN.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save_BTN
            // 
            this.Save_BTN.Location = new System.Drawing.Point(361, 386);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.Size = new System.Drawing.Size(121, 23);
            this.Save_BTN.TabIndex = 1;
            this.Save_BTN.Text = "Save";
            this.Save_BTN.UseVisualStyleBackColor = true;
            this.Save_BTN.Click += new System.EventHandler(this.Save_Click);
            // 
            // BWNPCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 431);
            this.Controls.Add(this.Save_BTN);
            this.Controls.Add(this.Load_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BWNPCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Wang";
            this.ResumeLayout(false);

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
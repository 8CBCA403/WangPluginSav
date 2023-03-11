namespace WangPluginSav.GUI.SWSHEventEditorGUI.Controls
{
    partial class PokemonBaseUC
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
            components = new System.ComponentModel.Container();
            caught_CB = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            caughtToolStripMenuItem = new ToolStripMenuItem();
            viewHintToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            illegalToolStripMenuItem = new ToolStripMenuItem();
            pokeName = new Label();
            pokemonRenderUC1 = new PokemonRenderUC();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // caught_CB
            // 
            caught_CB.AutoSize = true;
            caught_CB.Location = new Point(99, 25);
            caught_CB.Margin = new Padding(4, 5, 4, 5);
            caught_CB.Name = "caught_CB";
            caught_CB.Size = new Size(78, 24);
            caught_CB.TabIndex = 1;
            caught_CB.Text = "Caught";
            caught_CB.UseVisualStyleBackColor = true;
            caught_CB.CheckedChanged += caught_CB_CheckedChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { caughtToolStripMenuItem, viewHintToolStripMenuItem, toolStripSeparator1, illegalToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(147, 88);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // caughtToolStripMenuItem
            // 
            caughtToolStripMenuItem.CheckOnClick = true;
            caughtToolStripMenuItem.Image = Properties.Resources._ball4;
            caughtToolStripMenuItem.Name = "caughtToolStripMenuItem";
            caughtToolStripMenuItem.Size = new Size(146, 26);
            caughtToolStripMenuItem.Text = "Caught";
            caughtToolStripMenuItem.Click += caughtToolStripMenuItem_Click;
            // 
            // viewHintToolStripMenuItem
            // 
            viewHintToolStripMenuItem.Image = Properties.Resources.hint;
            viewHintToolStripMenuItem.Name = "viewHintToolStripMenuItem";
            viewHintToolStripMenuItem.Size = new Size(146, 26);
            viewHintToolStripMenuItem.Text = "View Hint";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(143, 6);
            // 
            // illegalToolStripMenuItem
            // 
            illegalToolStripMenuItem.Image = Properties.Resources.warn;
            illegalToolStripMenuItem.Name = "illegalToolStripMenuItem";
            illegalToolStripMenuItem.Size = new Size(146, 26);
            illegalToolStripMenuItem.Text = "Illegal";
            illegalToolStripMenuItem.Click += illegalToolStripMenuItem_Click;
            // 
            // pokeName
            // 
            pokeName.AutoSize = true;
            pokeName.Location = new Point(4, 0);
            pokeName.Margin = new Padding(4, 0, 4, 0);
            pokeName.Name = "pokeName";
            pokeName.Size = new Size(114, 20);
            pokeName.TabIndex = 2;
            pokeName.Text = "Pokemon Name";
            // 
            // pokemonRenderUC1
            // 
            pokemonRenderUC1.Caught = false;
            pokemonRenderUC1.ContextMenuStrip = contextMenuStrip1;
            pokemonRenderUC1.DrawDynaxMaxIcon = false;
            pokemonRenderUC1.Legalility = PokemonRenderUC.LegalStatus.Illegal;
            pokemonRenderUC1.Location = new Point(0, 25);
            pokemonRenderUC1.Margin = new Padding(5, 8, 5, 8);
            pokemonRenderUC1.MaximumSize = new Size(91, 86);
            pokemonRenderUC1.MinimumSize = new Size(91, 86);
            pokemonRenderUC1.Name = "pokemonRenderUC1";
            pokemonRenderUC1.Pokemon = 0;
            pokemonRenderUC1.PokemonSubForm = "0";
            pokemonRenderUC1.ShowMessageIcon = false;
            pokemonRenderUC1.Size = new Size(91, 86);
            pokemonRenderUC1.TabIndex = 0;
            pokemonRenderUC1.ToolTip = "";
            pokemonRenderUC1.LegaliltyCheck_OnClick += pokemonRenderUC1_LegaliltyCheck_OnClick;
            pokemonRenderUC1.Caught_OnClick += pokemonRenderUC1_Caught_OnClick;
            // 
            // PokemonBaseUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pokeName);
            Controls.Add(caught_CB);
            Controls.Add(pokemonRenderUC1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(213, 111);
            MinimumSize = new Size(213, 111);
            Name = "PokemonBaseUC";
            Size = new Size(213, 111);
            Load += PokemonBaseUC_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PokemonRenderUC pokemonRenderUC1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem caughtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHintToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem illegalToolStripMenuItem;
        private System.Windows.Forms.CheckBox caught_CB;
        private System.Windows.Forms.Label pokeName;
    }
}

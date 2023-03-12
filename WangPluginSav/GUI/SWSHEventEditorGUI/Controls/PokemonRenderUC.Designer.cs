namespace WangPluginSav.GUI.SWSHEventEditorGUI.Controls
{
    partial class PokemonRenderUC
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
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // PokemonRenderUC
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            DoubleBuffered = true;
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            MaximumSize = new Size(95, 95);
            MinimumSize = new Size(95, 95);
            Name = "PokemonRenderUC";
            Size = new Size(95, 95);
            Load += PokemonRenderUC_Load;
            Paint += PokemonRenderUC_Paint;
            KeyDown += PokemonRenderUC_KeyDown;
            KeyUp += PokemonRenderUC_KeyUp;
            MouseDown += PokemonRenderUC_MouseDown;
            MouseEnter += PokemonRenderUC_MouseEnter;
            MouseLeave += PokemonRenderUC_MouseLeave;
            MouseMove += PokemonRenderUC_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
    }
}

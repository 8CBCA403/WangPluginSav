using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WangPluginSav.GUI.SWSHEventEditorGUI.Controls
{
    public partial class PokemonBaseUC : UserControl
    {
        public PokemonBaseUC()
        {
            InitializeComponent();
        }

        public int Pokemon
        {
            get { return pokemonRenderUC1.Pokemon; }
            set
            {
                pokemonRenderUC1.Pokemon = value;
            }
        }
        public string PokemonSubform
        {
            get { return pokemonRenderUC1.PokemonSubForm; }
            set
            {
                pokemonRenderUC1.PokemonSubForm = value;
            }
        }

        public PokemonRenderUC.LegalStatus Legalility
        {
            get { return pokemonRenderUC1.Legalility; }
            set
            {
                pokemonRenderUC1.Legalility = value;
            }
        }

        public bool Caught
        {
            get { return pokemonRenderUC1.Caught; }
            set
            {
                pokemonRenderUC1.Caught = value;

                caught_CB.Checked = value;
                pokemonRenderUC1.Invalidate();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //Just to make sure the values are correct
            caughtToolStripMenuItem.Checked = Caught;
            illegalToolStripMenuItem.Text = Legalility == PokemonRenderUC.LegalStatus.Illegal ? "Illegal" : "Legal";
            illegalToolStripMenuItem.Image = Legalility == PokemonRenderUC.LegalStatus.Illegal ? Properties.Resources.warn : Properties.Resources.valid;

        }
        public bool DrawDynaxMaxIcon
        {
            get { return pokemonRenderUC1.DrawDynaxMaxIcon; }
            set { pokemonRenderUC1.DrawDynaxMaxIcon = value; }
        }
        public string ToolTip
        {
            get { return pokemonRenderUC1.ToolTip; }
            set
            {
                pokemonRenderUC1.ToolTip = value;
            }
        }

        public string PokemonName
        {
            get { return pokeName.Text; }
            set { pokeName.Text = value; }
        }

        public event EventHandler LegaliltyCheck_OnClick;

        public event EventHandler Caught_OnClick;

        private void PokemonBaseUC_Load(object sender, EventArgs e)
        {

        }
        private void caught_CB_CheckedChanged(object sender, EventArgs e)
        {
            Caught = caught_CB.Checked;
        }

        private void caughtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caught = caughtToolStripMenuItem.Checked;
        }

        private void pokemonRenderUC1_LegaliltyCheck_OnClick(object sender, EventArgs e)
        {
            LegaliltyCheck_OnClick?.Invoke(sender, e);
        }

        private void illegalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LegaliltyCheck_OnClick?.Invoke(sender, e);
        }

        private void pokemonRenderUC1_Caught_OnClick(object sender, EventArgs e)
        {
            caught_CB.Checked = Caught;
            Caught_OnClick?.Invoke(sender, e);
        }
    }
}

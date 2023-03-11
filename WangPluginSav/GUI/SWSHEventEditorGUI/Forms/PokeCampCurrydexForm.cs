using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKHeX.Core;

namespace WangPluginSav.Forms
{
    public partial class PokeCampCurrydexForm : Form
    {
        public SAV8SWSH SAV;
        public PokeCampCurrydexForm()
        {
            InitializeComponent();
        }

        private void CurrdexForm_Load(object sender, EventArgs e)
        {
            SetupMain();
            SetupCamp();

            //label1.Text = SAV.Blocks.GetBlock(0x68EED750).Type.ToString();

        }

        #region Camp
        void SetupCamp()
        {
            camp_ball_fresh_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_FRESH_BALL"]).Type == SCTypeCode.Bool2;
            camp_ball_weighted_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_HEAVY_BALL"]).Type == SCTypeCode.Bool2;
            camp_ball_soothe_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_YASURAGI_BALL"]).Type == SCTypeCode.Bool2;
            camp_ball_mirror_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_MIRROR_BALL"]).Type == SCTypeCode.Bool2;
            camp_ball_tympole_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_OTAMA_BALL"]).Type == SCTypeCode.Bool2;
            camp_ball_champion_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_CHAMPION_BALL"]).Type == SCTypeCode.Bool2;

            camp_has_golden_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_GOLDEN_KITCHENWARE"]).Type == SCTypeCode.Bool2;
            camp_use_golden_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_USE_GOLDEN_KITCHENWARE"]).Type == SCTypeCode.Bool2;

            camp_type_CMB.SelectedIndex = Convert.ToInt32(SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["SYS_WORK_POKECAMP_TENT_COLOR"]).GetValue());


        }

        void SaveCamp()
        {
            var b_fresh_ball = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_FRESH_BALL"]);
            var b_weighted_ball = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_HEAVY_BALL"]);
            var b_soothe_ball = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_YASURAGI_BALL"]);
            var b_mirror_ball = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_MIRROR_BALL"]);
            var b_tympole_ball = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_OTAMA_BALL"]);
            var b_champion_ball = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_CHAMPION_BALL"]);

            var b_has_golden_CB = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_OPEN_GOLDEN_KITCHENWARE"]);
            var b_use_golden_CB = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["FSYS_POKECAMP_USE_GOLDEN_KITCHENWARE"]);

            var b_tent_color = SAV.Blocks.GetBlock(Definitions.memkeys_PokeCamp["SYS_WORK_POKECAMP_TENT_COLOR"]);

            b_fresh_ball.ChangeBooleanType(camp_ball_fresh_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_weighted_ball.ChangeBooleanType(camp_ball_weighted_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_soothe_ball.ChangeBooleanType(camp_ball_soothe_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_mirror_ball.ChangeBooleanType(camp_ball_mirror_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_tympole_ball.ChangeBooleanType(camp_ball_tympole_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_champion_ball.ChangeBooleanType(camp_ball_champion_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

            b_has_golden_CB.ChangeBooleanType(camp_has_golden_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_use_golden_CB.ChangeBooleanType(camp_use_golden_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

            b_tent_color.SetValue(Convert.ToUInt32(camp_type_CMB.SelectedIndex));



        }

        private void camp_type_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            camp_type_PB.Invalidate();
        }

        private void camp_type_PB_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Magenta);
            if (camp_type_CMB.SelectedIndex != -1)
                e.Graphics.DrawImage((Bitmap)Properties.Resources.ResourceManager.GetObject($"type_icon_{camp_type_CMB.SelectedIndex}")!, 0, 0);
        }
        #endregion

        #region main
        void SetupMain()
        {

        }

        #endregion

        private void ts_applyBTN_Click(object sender, EventArgs e)
        {
            SaveCamp();
            this.Close();
        }
    }
}

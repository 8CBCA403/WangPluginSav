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

namespace WangPluginSav
{
    public partial class SOJForm : Form
    {
        public SOJForm()
        {
            InitializeComponent();
        }

        public SAV8SWSH? SAV;

        private void SOJForm_Load(object sender, EventArgs e)
        {

            var b_cobalion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["Cobalion"]);
            var b_terrakion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["Terrakion"]);
            var b_virizion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["Virizion"]);

            var b_keldeo = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["Keldeo"]);

            var b_cobalionf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["Cobalion"]);
            var b_terrakionf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["Terrakion"]);
            var b_virizionf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["Virizion"]);

            if (b_cobalion?.Type == SCTypeCode.Bool2 && Convert.ToInt32(b_cobalionf?.GetValue()) != 100 || Convert.ToInt32(b_cobalionf?.GetValue()) % 2 != 0) //illegal!
            {
                if (MessageBox.Show("Data in your save file shows potentially illegal Cobalion encounter data, would you like to fix it?\nIf you believe this to be an error, please click \'No\' and report it.", "Illegal Cobalion Encounter", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    cobalion_CB.Checked = false;
                else
                {
                    legality_CB.Checked = false;
                    cobalion_CB.Checked = b_cobalion?.Type == SCTypeCode.Bool2 ? true : false;
                }
            }
            else cobalion_CB.Checked = b_cobalion?.Type == SCTypeCode.Bool2 ? true : false;
            cfootper_NUD.Value = Convert.ToInt32(b_cobalionf?.GetValue());

            if (b_terrakion?.Type == SCTypeCode.Bool2 && Convert.ToInt32(b_terrakionf?.GetValue()) != 100 || Convert.ToInt32(b_terrakionf?.GetValue()) % 2 != 0) //illegal!
            {
                if (MessageBox.Show("Data in your save file shows potentially illegal Terrakion encounter data, would you like to fix it?\nIf you believe this to be an error, please click \'No\' and report it.", "Illegal Terrakion Encounter", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    terrakion_CB.Checked = false;
                else
                {
                    legality_CB.Checked = false;
                    terrakion_CB.Checked = b_terrakion?.Type == SCTypeCode.Bool2 ? true : false;
                }
            }
            else terrakion_CB.Checked = b_terrakion?.Type == SCTypeCode.Bool2 ? true : false;
            tfootper_NUD.Value = Convert.ToInt32(b_terrakionf?.GetValue());

            if (b_virizion?.Type == SCTypeCode.Bool2 && Convert.ToInt32(b_virizionf?.GetValue()) != 100 || Convert.ToInt32(b_virizionf?.GetValue()) % 2 != 0) //illegal!
            {
                if (MessageBox.Show("Data in your save file shows potentially illegal Virizion encounter data, would you like to fix it?\nIf you believe this to be an error, please click \'No\' and report it.", "Illegal Virizion Encounter", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    virizion_CB.Checked = false;
                else
                {
                    legality_CB.Checked = false;
                    virizion_CB.Checked = b_virizion?.Type == SCTypeCode.Bool2 ? true : false;
                }
            }
            else virizion_CB.Checked = b_virizion?.Type == SCTypeCode.Bool2 ? true : false;

            vfootper_NUD.Value = Convert.ToInt32(b_virizionf?.GetValue());

            if ((b_virizion?.Type == SCTypeCode.Bool1 && b_cobalion?.Type == SCTypeCode.Bool1 && b_terrakion?.Type == SCTypeCode.Bool1) && b_keldeo?.Type == SCTypeCode.Bool2)
            {
                if (MessageBox.Show("Data in your save file shows potentially illegal Keldeo encounter data, would you like to fix it?\nIf you believe this to be an error, please click \'No\' and report it.", "Illegal Keldeo Encounter", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    keldeo_CB.Checked = false;
                else
                {
                    legality_CB.Checked = false;
                    keldeo_CB.Checked = true;
                }
            }
            else keldeo_CB.Checked = b_keldeo?.Type == SCTypeCode.Bool2 ? true : false;
            CheckLegality();
        }


        private void cobalion_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (legality_CB.Checked) SetKeldeoLegal();
            CheckLegality();
        }

        private void terrakion_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (legality_CB.Checked) SetKeldeoLegal();
            CheckLegality();
        }

        private void virizion_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (legality_CB.Checked) SetKeldeoLegal();
            CheckLegality();
        }

        private void keldeo_CB_CheckedChanged(object sender, EventArgs e)
        {
            CheckLegality();
        }

        private void cfootper_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (legality_CB.Checked) SetCobalionLegal();
            CheckLegality();
        }

        private void tfootper_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (legality_CB.Checked) SetTerrakionLegal();
            CheckLegality();
        }

        private void vfootper_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (legality_CB.Checked) SetVirizionLegal();
            CheckLegality();
        }

        void SetCobalionLegal()
        {
            if (cfootper_NUD.Value % 2 != 0)
            {
                MessageBox.Show("Value must be a multiple of 2!", "Error");
                cfootper_NUD.Value = ((int)(cfootper_NUD.Value / 2)) * 2;
            }

            if (cfootper_NUD.Value == 100) cobalion_CB.Enabled = true;
            else
            {
                cobalion_CB.Enabled = false;
                cobalion_CB.Checked = false;
            }
        }

        void SetTerrakionLegal()
        {
            if (tfootper_NUD.Value % 2 != 0)
            {
                MessageBox.Show("Value must be a multiple of 2!", "Error");
                tfootper_NUD.Value = ((int)(tfootper_NUD.Value / 2)) * 2;
            }

            if (tfootper_NUD.Value == 100) terrakion_CB.Enabled = true;
            else
            {
                terrakion_CB.Enabled = false;
                terrakion_CB.Checked = false;
            }
        }

        void SetVirizionLegal()
        {
            if (vfootper_NUD.Value % 2 != 0)
            {
                MessageBox.Show("Value must be a multiple of 2!", "Error");
                vfootper_NUD.Value = ((int)(vfootper_NUD.Value / 2)) * 2;
            }

            if (vfootper_NUD.Value == 100) virizion_CB.Enabled = true;
            else
            {
                virizion_CB.Enabled = false;
                virizion_CB.Checked = false;
            }
        }

        void SetKeldeoLegal()
        {
            keldeo_CB.Enabled = (virizion_CB.Checked && terrakion_CB.Checked && cobalion_CB.Checked);
            if (keldeo_CB.Checked && !keldeo_CB.Enabled) keldeo_CB.Checked = false;
        }

        void CheckLegality()
        {
            if (CheckCobalionLegality() && CheckTerrakionLegality() && CheckVirizionLegality() && CheckKeldeoLegality()) legality_LBL.Text = "Legal Status: Legal!";
            else
            {
                legality_LBL.Text = "Legal Status: Potentially Illegal!";
            }
        }

        bool CheckCobalionLegality()
        {
            return ((cobalion_CB.Checked && cfootper_NUD.Value == 100) || (!cobalion_CB.Checked && cfootper_NUD.Value <= 100) && cfootper_NUD.Value % 2 == 0);
        }
        bool CheckTerrakionLegality()
        {
            return ((terrakion_CB.Checked && tfootper_NUD.Value == 100) || (!terrakion_CB.Checked && tfootper_NUD.Value <= 100) && tfootper_NUD.Value % 2 == 0);
        }
        bool CheckVirizionLegality()
        {
            return ((virizion_CB.Checked && vfootper_NUD.Value == 100) || (!virizion_CB.Checked && vfootper_NUD.Value <= 100) && vfootper_NUD.Value % 2 == 0);
        }

        bool CheckKeldeoLegality()
        {
            if (virizion_CB.Checked && terrakion_CB.Checked && cobalion_CB.Checked) return true;
            else
            {
                if (keldeo_CB.Checked) return false;
                else return true;
            }
        }

        private void legality_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (legality_CB.Checked)
            {
                SetCobalionLegal();
                SetTerrakionLegal();
                SetVirizionLegal();
                SetKeldeoLegal();
            }
            else
            {
                if (!cobalion_CB.Enabled) cobalion_CB.Enabled = true;
                if (!terrakion_CB.Enabled) terrakion_CB.Enabled = true;
                if (!virizion_CB.Enabled) virizion_CB.Enabled = true;
                if (!keldeo_CB.Enabled) keldeo_CB.Enabled = true;
            }


            CheckLegality();
        }

        private void apply_BTN_Click(object sender, EventArgs e)
        {
            var b_cobalion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["Cobalion"]);
            var b_terrakion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["Terrakion"]);
            var b_virizion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["Virizion"]);

            var b_keldeo = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["Keldeo"]);

            var b_cobalionf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["Cobalion"]);
            var b_terrakionf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["Terrakion"]);
            var b_virizonf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["Virizion"]);

            b_cobalion?.ChangeBooleanType(cobalion_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_terrakion?.ChangeBooleanType(terrakion_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_virizion?.ChangeBooleanType(virizion_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

            b_keldeo?.ChangeBooleanType(keldeo_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

            b_cobalionf?.SetValue(Convert.ToUInt32(cfootper_NUD.Value));
            b_terrakionf?.SetValue(Convert.ToUInt32(tfootper_NUD.Value));
            b_virizonf?.SetValue(Convert.ToUInt32(vfootper_NUD.Value));


            this.DialogResult = DialogResult.OK;
            this.Close();

        }


    }
}

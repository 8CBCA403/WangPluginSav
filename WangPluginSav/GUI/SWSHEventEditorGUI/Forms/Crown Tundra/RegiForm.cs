﻿using PKHeX.Core;

namespace WangPluginSav
{
    public partial class RegiForm : Form
    {
        public SAV8SWSH? SAV;
        public RegiForm(ISaveFileProvider Save)
        {
            SAV = (SAV8SWSH)Save.SAV;
            InitializeComponent();
        }



        private void RegiForm_Load(object sender, EventArgs e)
        {
            //Check Regi values
            for (int i = 0; i < Definitions.memkeys_Regis.Count - 2; i++) //-2 so we do all of them except for Regieleki and regidrago
            {
                if (SAV?.Blocks.GetBlock(Definitions.memkeys_Regis.ElementAt(i).Value).Type == SCTypeCode.Bool2) regi_clistbox.SetItemChecked(i, true);

            }

            legailty_CB.Checked = true;


            var eleki = SAV?.Blocks.GetBlock(Definitions.memkeys_Regis["雷吉艾勒奇"]);
            var drago = SAV?.Blocks.GetBlock(Definitions.memkeys_Regis["雷吉铎拉戈"]);
            var pattern = SAV?.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern);


            if (eleki?.Type == SCTypeCode.Bool2) //Regieleki
            {
                regieleki_RBTN.Checked = true;
                //Check if the pattern provided by the player matches the regi
                if (Convert.ToInt32(pattern?.GetValue()) != 1) // 1 = regieleki pattern
                {
                    if (ShowPatternMisMatchMSG() == DialogResult.Yes) pattern?.SetValue((UInt32)1);
                    else legailty_CB.Checked = false;
                }
            }

            if (drago?.Type == SCTypeCode.Bool2) //Regidrago
            {
                regidrago_RBTN.Checked = true;
                //Check if the pattern provided by the player matches the regi
                if (Convert.ToInt32(pattern?.GetValue()) != 2) // 2 = regidrago pattern
                {
                    if (ShowPatternMisMatchMSG() == DialogResult.Yes) pattern?.SetValue((UInt32)2);
                    else legailty_CB.Checked = false;

                }
            }

            MatchRegiPattern();
            regipatternNUD.Value = Convert.ToInt32(pattern?.GetValue());

        }


        void CheckLegality()
        {
            if (CheckElekiLegal() || CheckDragoLegal() || CheckNeitherLegal())
                legalLBL.Text = "合法性:合法";
            else legalLBL.Text = "合法性:可能非法";
        }

        bool CheckNeitherLegal()
        {
            return (GetRegiPattern() <= 2 && reginone_RBTN.Checked);
        }
        bool CheckElekiLegal()
        {
            return (((GetRegiPattern() == 1) && regieleki_RBTN.Checked) && !((GetRegiPattern() == 2) && regidrago_RBTN.Checked)) || regieleki_patrBTN.Checked;
        }
        bool CheckDragoLegal()
        {
            return (((GetRegiPattern() == 2) && regidrago_RBTN.Checked) && !((GetRegiPattern() == 1) && regieleki_RBTN.Checked)) || regidrago_patrBTN.Checked;
        }


        /// <summary>
        /// 0 - None
        /// <para>1 - Regieleki</para>
        /// <para>2 - Regidrago</para>
        /// </summary>
        /// <returns></returns>
        int GetRegiPattern()
        {
            if (regiother_patrBTN.Checked) return (int)regipatternNUD.Value;
            else return regidrago_patrBTN.Checked ? 2 : regieleki_patrBTN.Checked ? 1 : 0;

        }
        /// <summary>
        /// Match the regi (drago or eleki or neither) to the pattern value
        /// </summary>
        void MatchRegiPattern()
        {

            if (regieleki_RBTN.Checked)
            {
                regieleki_patrBTN.Checked = true;
            }
            else if (regidrago_RBTN.Checked)
            {
                regidrago_patrBTN.Checked = true;
            }


        }

        DialogResult ShowPatternMisMatchMSG()
        {
            return MessageBox.Show($"检测到与收到的雷吉及其所需模式的差异.\n你想自动更正吗?", "错误", MessageBoxButtons.YesNo);
        }

        private void regiother_patrBTN_CheckedChanged(object sender, EventArgs e)
        {
            regipatternNUD.Enabled = regiother_patrBTN.Checked;
        }

        private void reginone_patrBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (legailty_CB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void regidrago_patrBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (legailty_CB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void regieleki_patrBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (legailty_CB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void regipatternNUD_ValueChanged(object sender, EventArgs e)
        {
            if (legailty_CB.Checked) MatchRegiPattern();
            CheckLegality();
        }


        private void reginone_RBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (legailty_CB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void regidrago_RBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (legailty_CB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void regieleki_RBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (legailty_CB.Checked) MatchRegiPattern();
            CheckLegality();
        }


        private void forcematchCB_CheckedChanged(object sender, EventArgs e)
        {
            if (legailty_CB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void applyBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Definitions.memkeys_Regis.Count - 2; i++) //do all except for eleki and drago
            {
                SAV?.Blocks.GetBlock(Definitions.memkeys_Regis.ElementAt(i).Value).ChangeBooleanType(regi_clistbox.GetItemChecked(i) ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            }

            SAV?.Blocks.GetBlock(Definitions.memkeys_Regis["雷吉艾勒奇"]).ChangeBooleanType(regieleki_RBTN.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            SAV?.Blocks.GetBlock(Definitions.memkeys_Regis["雷吉铎拉戈"]).ChangeBooleanType(regidrago_RBTN.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

            //If you don't cast the int, you will get an exeception that will crash the plugin.
            if (regieleki_patrBTN.Checked) SAV?.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)1);
            else if (regidrago_patrBTN.Checked) SAV?.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)2);
            else if (reginone_patrBTN.Checked) SAV?.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)0);
            else SAV?.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)regipatternNUD.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}

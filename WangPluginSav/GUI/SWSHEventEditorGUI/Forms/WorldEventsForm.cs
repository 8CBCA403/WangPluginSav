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
    public partial class WorldEventsForm : Form
    {
        public enum Pages { Main, IsleOfArmor, CrownTundra }
        public SAV8SWSH? SAV;
        bool loading;
        public ISaveFileProvider SaveFileEditor { get; private set; } = null!;
        public WorldEventsForm(Pages StartingPage, ISaveFileProvider Save)
        {
            SaveFileEditor = Save;
            SAV = (SAV8SWSH)Save.SAV;
            InitializeComponent();
            switch (StartingPage)
            {
                case (Pages.Main):
                    tabControl1.SelectedIndex = 0;
                    break;
                case (Pages.IsleOfArmor):
                    tabControl1.SelectedIndex = 1;
                    break;
                case (Pages.CrownTundra):
                    tabControl1.SelectedIndex = 2;
                    break;
            }

        }

        private void WorldEvents_Load(object sender, EventArgs e)
        {
            loading = true;
            SetupMain();
            SetupCrownTundra();
            loading = false;
        }

        #region Main Game

        #region Lets go
        private void main_geevee_PB_Caught_OnClick(object sender, EventArgs e)
        {
            string[] issues = main_checklegal_Eevee();
            if (main_letsgo_forcelegal_CB.Checked)
                if (main_geevee_PB.Legalility == GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal)
                    main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
        }

        private void main_geevee_PB_LegaliltyCheck_OnClick(object sender, EventArgs e)
        {
            string[] issues = main_checklegal_Eevee();
            main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
        }
        private void main_eevee_save_data_CB_CheckedChanged(object sender, EventArgs e)
        {
            string[] issues = main_checklegal_Eevee();
            if (main_letsgo_forcelegal_CB.Checked)
                if (main_geevee_PB.Legalility == GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal)
                    main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
        }

        string[] main_checklegal_Eevee()
        {
            List<string> Issues = new List<string>();
            if (main_geevee_PB.Caught && !main_eevee_save_data_CB.Checked)
            {
                Issues.Add("Gift Eevee cannot be had while the player has no \"Let's Go: Eevee!\" save data!");
            }
            if (Issues.Count == 0)
                main_geevee_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            else
                main_geevee_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal;
            return Issues.ToArray();
        }

        string[] main_checklegal_Pikachu()
        {
            List<string> Issues = new List<string>();
            if (main_gpikachu_PB.Caught && !main_pikachu_save_data_CB.Checked)
            {
                Issues.Add("Gift Pikachu cannot be had while the player has no \"Let's Go: Pikachu!\" save data!");
            }

            if (Issues.Count == 0)
                main_gpikachu_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            else
                main_gpikachu_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal;
            return Issues.ToArray();
        }
        private void main_gpikachu_PB_Caught_OnClick(object sender, EventArgs e)
        {
            string[] issues = main_checklegal_Pikachu();
            if (main_letsgo_forcelegal_CB.Checked)
                if (main_gpikachu_PB.Legalility == GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal)
                    main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
        }
        private void main_pikachu_save_data_CB_CheckedChanged(object sender, EventArgs e)
        {
            string[] issues = main_checklegal_Pikachu();
            if (main_letsgo_forcelegal_CB.Checked)
                if (main_gpikachu_PB.Legalility == GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal)
                    main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
        }

        private void main_gpikachu_PB_LegaliltyCheck_OnClick(object sender, EventArgs e)
        {
            string[] issues = main_checklegal_Pikachu();
            main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
        }

        private void main_letsgo_forcelegal_CB_CheckedChanged(object sender, EventArgs e)
        {
            string[] issuese = main_checklegal_Eevee();
            if (main_letsgo_forcelegal_CB.Checked)
                if (main_geevee_PB.Legalility == GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal)
                    main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issuese);

            string[] issuesp = main_checklegal_Pikachu();
            if (main_letsgo_forcelegal_CB.Checked)
                if (main_gpikachu_PB.Legalility == GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal)
                    main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issuesp);
        }
        #endregion

        void SetupMain()
        {

            main_eevee_save_data_CB.Checked = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["FSYS_PLAY_LETSGO_EEVEE"]).Type == SCTypeCode.Bool2;
            main_pikachu_save_data_CB.Checked = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["FSYS_PLAY_LETSGO_PIKACHU"]).Type == SCTypeCode.Bool2;

            main_geevee_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_037_EEVEE_CLEAR"]).Type == SCTypeCode.Bool2;
            main_gpikachu_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_037_PIKACHU_CLEAR"]).Type == SCTypeCode.Bool2;

            main_gift_gcharmander_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["z_t0101_i0202_MONSBALL"]).Type == SCTypeCode.Bool2;
            main_gift_typenull_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["z_bt0101_POKE_NUL"]).Type == SCTypeCode.Bool2;
            main_gift_toxel_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_005_CLEAR"]).Type == SCTypeCode.Bool2;

        }

        void SaveMain()
        {
            var b_pikachu_save_data = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["FSYS_PLAY_LETSGO_PIKACHU"]);
            var b_eevee_save_data = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["FSYS_PLAY_LETSGO_EEVEE"]);

            var b_geevee_caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_037_EEVEE_CLEAR"]);
            var b_gpikachu_caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_037_PIKACHU_CLEAR"]);

            var b_gift_gcharmander_caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["z_t0101_i0202_MONSBALL"]);
            var b_gift_typenull_caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["z_bt0101_POKE_NUL"]);
            var b_gift_toxel_caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_005_CLEAR"]);


            b_pikachu_save_data?.ChangeBooleanType(main_pikachu_save_data_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_eevee_save_data?.ChangeBooleanType(main_eevee_save_data_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

            b_geevee_caught?.ChangeBooleanType(main_geevee_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_gpikachu_caught?.ChangeBooleanType(main_gpikachu_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

            b_gift_gcharmander_caught?.ChangeBooleanType(main_gift_gcharmander_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_gift_typenull_caught?.ChangeBooleanType(main_gift_typenull_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_gift_toxel_caught?.ChangeBooleanType(main_gift_toxel_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

        }



        #endregion

        #region Crown Tundra
        void SetupCrownTundra()
        {

            //Setup Birds
            ct_garticuno_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Articuno"]).Type == SCTypeCode.Bool2 ? true : false;
            ct_gzapdos_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Zapdos"]).Type == SCTypeCode.Bool2 ? true : false;
            ct_gmoltres_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Moltres"]).Type == SCTypeCode.Bool2 ? true : false;

            //Setup Cosmog
            ct_giftcosmog_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["z_wr0301_i0401_COSMOG"]).Type == SCTypeCode.Bool2 ? true : false;

            ct_gift_poipole_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["z_d0901_BEBENOM"]).Type == SCTypeCode.Bool2 ? true : false;
            //Setup Spiritomb
            ct_spiritomb_PB.Caught = SAV?.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["FE_CAPTURE_MIKARUGE"]).Type == SCTypeCode.Bool2 ? true : false;
            ct_spiritomb_visible_CB.Checked = SAV?.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["z_wr0321_SymbolEncountPokemonGimmickSpawner_WR03_Mikaruge"]).Type == SCTypeCode.Bool1 ? true : false;
            ct_spiritomb_players_NUD.Value = (uint)SAV?.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["KPlayersInteractedOnline"]).GetValue()!;


        }


        void SaveCrownTundra()
        {
            var b_garticuno = SAV?.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Articuno"]);
            var b_gzapdos = SAV?.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Zapdos"]);
            var b_gmoltres = SAV?.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Moltres"]);

            var b_giftcosmog = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["z_wr0301_i0401_COSMOG"]);

            var b_gift_poipole = SAV?.Blocks.GetBlock(Definitions.memkeys_Gifts["z_d0901_BEBENOM"]);

            var b_spiritomb_caught = SAV?.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["FE_CAPTURE_MIKARUGE"]);
            var b_spiritomb_visible = SAV?.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["z_wr0321_SymbolEncountPokemonGimmickSpawner_WR03_Mikaruge"]);

            var b_playersonline = SAV?.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["KPlayersInteractedOnline"]);

            b_garticuno?.ChangeBooleanType(ct_garticuno_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_gzapdos?.ChangeBooleanType(ct_gzapdos_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_gmoltres?.ChangeBooleanType(ct_gmoltres_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

            b_giftcosmog?.ChangeBooleanType(ct_giftcosmog_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

            b_gift_poipole?.ChangeBooleanType(ct_gift_poipole_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

            b_spiritomb_caught?.ChangeBooleanType(ct_spiritomb_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
            b_spiritomb_visible?.ChangeBooleanType(ct_spiritomb_visible_CB.Checked ? SCTypeCode.Bool1 : SCTypeCode.Bool2);

            b_playersonline?.SetValue(Convert.ToUInt32(ct_spiritomb_players_NUD.Value));

        }
        #region Spiritomb
        private void ct_spiritomb_forcelegal_CB_CheckedChanged(object sender, EventArgs e)
        {
            string[] issues = ct_checklegal_Spiritomb();
            if (ct_spiritomb_forcelegal_CB.Checked)
                if (ct_spiritomb_PB.Legalility == GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal)
                    ct_spiritomb_forcelegal_CB.Checked = ShowLegalMSG(issues);
        }

        private void ct_spiritomb_PB_LegaliltyCheck_OnClick(object sender, EventArgs e)
        {
            string[] issues = ct_checklegal_Spiritomb();
            ct_spiritomb_forcelegal_CB.Checked = ShowLegalMSG(issues);
        }


        private void ct_spiritomb_PB_Caught_OnClick(object sender, EventArgs e)
        {
            string[] issues = ct_checklegal_Spiritomb();
            if (ct_spiritomb_forcelegal_CB.Checked)
                if (ct_spiritomb_PB.Legalility == GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal)
                    ct_spiritomb_forcelegal_CB.Checked = ShowLegalMSG(issues);


        }
        private void ct_spiritomb_visible_CB_CheckedChanged(object sender, EventArgs e)
        {
            string[] issues = ct_checklegal_Spiritomb();
            if (ct_spiritomb_forcelegal_CB.Checked)
                if (ct_spiritomb_PB.Legalility == GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal)
                    ct_spiritomb_forcelegal_CB.Checked = ShowLegalMSG(issues);
        }

        private void ct_spiritomb_players_NUD_ValueChanged(object sender, EventArgs e)
        {
            string[] issues = ct_checklegal_Spiritomb();
            if (ct_spiritomb_forcelegal_CB.Checked)
                if (ct_spiritomb_PB.Legalility == GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal)
                    ct_spiritomb_forcelegal_CB.Checked = ShowLegalMSG(issues);
        }

        string[] ct_checklegal_Spiritomb()
        {
            List<string> Issues = new List<string>();

            if (ct_spiritomb_PB.Caught && ct_spiritomb_visible_CB.Checked)
            {
                Issues.Add("Spiritomb cannot be caught and visible in the overworld!");
            }
            if (ct_spiritomb_visible_CB.Checked && ct_spiritomb_players_NUD.Value < 30)
            {
                Issues.Add("Spiritomb visible in the overworld if the player has less than 30 online interactions!");
            }
            if (ct_spiritomb_PB.Caught && ct_spiritomb_players_NUD.Value < 30)
            {
                Issues.Add("Spiritomb caught if the player has less than 30 online interactions!");
            }
            if (!ct_spiritomb_PB.Caught && !ct_spiritomb_visible_CB.Checked && ct_spiritomb_players_NUD.Value >= 30)
            {
                Issues.Add("Spiritomb is not caught or visble/spawned in the overworld but player interactions >= 30!");
            }

            if (Issues.Count == 0) ct_spiritomb_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            else ct_spiritomb_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal;

            return Issues.ToArray();
        }

        #endregion
        private void ct_birds_caughtBTN_Click(object sender, EventArgs e)
        {
            ct_garticuno_PB.Caught = true;
            ct_gzapdos_PB.Caught = true;
            ct_gmoltres_PB.Caught = true;
        }

        private void ct_birds_uncaughtBTN_Click(object sender, EventArgs e)
        {
            ct_garticuno_PB.Caught = false;
            ct_gzapdos_PB.Caught = false;
            ct_gmoltres_PB.Caught = false;
        }

        #endregion
        bool ShowLegalMSG(string[] issues)
        {
            if (loading) return false;
            if (issues.Length == 0)
            {
                MessageBox.Show("Legal!", "Legal Status: Legal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                string temp = "** POTENTIALLY ILLEGAL SAVE DATA **\n";
                for (int i = 0; i < issues.Length; i++)
                {
                    temp += $"Invalid: {issues[i]}\n";
                }
                temp += "\nIf you believe this to be an error please click \"No\" and report the issue!\n" +
                        "Would you like to disable show legalilty corrections?";
                if (MessageBox.Show(temp, "Legal Status: Potentially Illegal", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return true;
                else
                    return false;
            }
        }
        private void ts_applyBTN_Click(object sender, EventArgs e)
        {
            SaveMain();
            SaveCrownTundra();

            this.Close();
        }

        private void CurryDex_BTN_Click(object sender, EventArgs e)
        {
            var form = new Forms.PokeCampCurrydexForm(SaveFileEditor);
            form.Show();
        }

        private void WonderCard_BTN_Click(object sender, EventArgs e)
        {
            var form = new Wonder2FashionForm(SaveFileEditor);


            form.Show();

        }

        private void Dynamax_BTN_Click(object sender, EventArgs e)
        {
            var form = new DynamaxResetForm(SaveFileEditor);
            {
                if (SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SH)
                {
                    var result = MessageBox.Show(
                        $"The given save is null, or is not of Sword/Shield type. If you believe this to be a mistake, please contact the current repos maintainers.\nYou are running: {SaveFileEditor.SAV.Version}\nDo you wish to continue anyway?",
                        $"Error",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;
                }

                form.Show();
            }
        }

        private void RegiForm_BTN_Click(object sender, EventArgs e)
        {
            var form = new RegiForm(SaveFileEditor);
            {
                if (SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SH || !SaveFileEditor.SAV.State.Exportable)
                {
                    var result = MessageBox.Show(
                        $"The given save is null, or is not of Sword/Shield type. If you believe this to be a mistake, please contact the current repos maintainers.\nYou are running: {SaveFileEditor.SAV.Version}\nDo you wish to continue anyway?",
                        $"Error",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;
                }

                form.Show();
            }
        }

        private void SOJForm_BTN_Click(object sender, EventArgs e)
        {
            var form = new SOJForm(SaveFileEditor);
            {
                if (SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SH || !SaveFileEditor.SAV.State.Exportable)
                {
                    var result = MessageBox.Show(
                        $"The given save is null, or is not of Sword/Shield type. If you believe this to be a mistake, please contact the current repos maintainers.\nYou are running: {SaveFileEditor.SAV.Version}\nDo you wish to continue anyway?",
                        $"Error",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;
                }

                form.Show();
            }
        }
    }
}

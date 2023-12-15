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
        public SAV8SWSH? SAV;
        public SOJForm(ISaveFileProvider Save)
        {
            SAV = (SAV8SWSH)Save.SAV;
            InitializeComponent();
        }

       

        private void SOJForm_Load(object sender, EventArgs e)
        {

            var b_cobalion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["勾帕路翁"]);
            var b_terrakion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["代拉基翁"]);
            var b_virizion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["毕力吉翁"]);

            var b_keldeo = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["凯路迪欧"]);

            var b_cobalionf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["勾帕路翁"]);
            var b_terrakionf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["代拉基翁"]);
            var b_virizionf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["毕力吉翁"]);

            if (b_cobalion?.Type == SCTypeCode.Bool2 && Convert.ToInt32(b_cobalionf?.GetValue()) != 100 || Convert.ToInt32(b_cobalionf?.GetValue()) % 2 != 0) //illegal!
            {
                if (MessageBox.Show("您保存的文件中的数据显示潜在的非法勾帕路翁遭遇数据，您要修复它吗?\n如果您认为这是一个错误，请点击 '否' 并报告它.", "非法勾帕路翁遭遇", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                if (MessageBox.Show("您保存的文件中的数据显示潜在的非法代拉基翁遭遇数据，您要修复它吗?\n如果您认为这是一个错误，请点击 '否' 并报告它.", "非法代拉基翁遭遇", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                if (MessageBox.Show("您保存的文件中的数据显示潜在的非法毕力吉翁遭遇数据，您要修复它吗?\n如果您认为这是一个错误，请点击 '否' 并报告它.", "非法毕力吉翁遭遇", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                if (MessageBox.Show("您保存的文件中的数据显示潜在的非法凯路迪欧遭遇数据，您要修复它吗?\n如果您认为这是一个错误，请点击 '否' 并报告它.", "非法凯路迪欧遭遇战", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                MessageBox.Show("值必须是2的倍数!", "错误");
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
                MessageBox.Show("值必须是2的倍数!", "错误");
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
                MessageBox.Show("值必须是2的倍数!", "错误");
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
            if (CheckCobalionLegality() && CheckTerrakionLegality() && CheckVirizionLegality() && CheckKeldeoLegality()) legality_LBL.Text = "合法性:合法!";
            else
            {
                legality_LBL.Text = "合法性:可能非法!";
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
            var b_cobalion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["勾帕路翁"]);
            var b_terrakion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["代拉基翁"]);
            var b_virizion = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["毕力吉翁"]);

            var b_keldeo = SAV?.Blocks.GetBlock(Definitions.memkeys_SwordsofJustice["凯路迪欧"]);

            var b_cobalionf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["勾帕路翁"]);
            var b_terrakionf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["代拉基翁"]);
            var b_virizonf = SAV?.Blocks.GetBlock(Definitions.memkeys_FootprintPercentage["毕力吉翁"]);

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

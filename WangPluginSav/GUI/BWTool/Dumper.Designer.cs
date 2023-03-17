/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 02/03/2016
 * Time: 0:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
    partial class Dumper
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button dump_but;
        private System.Windows.Forms.Button inject_but;
        private System.Windows.Forms.Button dump_dec_but;
        private System.Windows.Forms.Button inject_crypt_but;
        private System.Windows.Forms.ComboBox selectedblock;
        private System.Windows.Forms.CheckBox crypt_check;
        private System.Windows.Forms.ComboBox BW_blocklist;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dumper));
            dump_but = new Button();
            inject_but = new Button();
            dump_dec_but = new Button();
            inject_crypt_but = new Button();
            selectedblock = new ComboBox();
            crypt_check = new CheckBox();
            BW_blocklist = new ComboBox();
            SuspendLayout();
            // 
            // dump_but
            // 
            dump_but.Location = new Point(339, 45);
            dump_but.Margin = new Padding(4, 4, 4, 4);
            dump_but.Name = "dump_but";
            dump_but.Size = new Size(100, 26);
            dump_but.TabIndex = 1;
            dump_but.Text = "导出";
            dump_but.UseVisualStyleBackColor = true;
            dump_but.Click += Dump_butClick;
            // 
            // inject_but
            // 
            inject_but.Location = new Point(471, 45);
            inject_but.Margin = new Padding(4, 4, 4, 4);
            inject_but.Name = "inject_but";
            inject_but.Size = new Size(100, 26);
            inject_but.TabIndex = 2;
            inject_but.Text = "导入";
            inject_but.UseVisualStyleBackColor = true;
            inject_but.Click += Inject_butClick;
            // 
            // dump_dec_but
            // 
            dump_dec_but.Enabled = false;
            dump_dec_but.Location = new Point(272, 79);
            dump_dec_but.Margin = new Padding(4, 4, 4, 4);
            dump_dec_but.Name = "dump_dec_but";
            dump_dec_but.Size = new Size(167, 26);
            dump_dec_but.TabIndex = 3;
            dump_dec_but.Text = "导出并解密";
            dump_dec_but.UseVisualStyleBackColor = true;
            dump_dec_but.Click += Dump_dec_butClick;
            // 
            // inject_crypt_but
            // 
            inject_crypt_but.Enabled = false;
            inject_crypt_but.Location = new Point(471, 79);
            inject_crypt_but.Margin = new Padding(4, 4, 4, 4);
            inject_crypt_but.Name = "inject_crypt_but";
            inject_crypt_but.Size = new Size(167, 26);
            inject_crypt_but.TabIndex = 4;
            inject_crypt_but.Text = "导入并重新加密";
            inject_crypt_but.UseVisualStyleBackColor = true;
            inject_crypt_but.Click += Inject_crypt_butClick;
            // 
            // selectedblock
            // 
            selectedblock.FormattingEnabled = true;
            selectedblock.Items.AddRange(new object[] { "00 - 盒子名称", "01 - 盒子1", "02 - 盒子2", "03 - 盒子3", "04 - 盒子4", "05 - 盒子5", "06 - 盒子6", "07 - 盒子7", "08 - 盒子8", "09 - 盒子9", "10 - 盒子10", "11 - 盒子11", "12 - 盒子12", "13 - 盒子13", "14 - 盒子14", "15 - 盒子15", "16 - 盒子16", "17 - 盒子17", "18 - 盒子18", "19 - 盒子19", "20 - 盒子20", "21 - 盒子21", "22 - 盒子22", "23 - 盒子23", "24 - 盒子24", "25 - 库存？", "26 - 同行宝可梦", "27 - 训练家信息", "28 - 训练家状态", "29 - 联合塔和调查的东西", "30 - 朋友手册玩家数据 (30d)", "31 - 朋友手册朋友数据", "32 - 设置 / 皮肤信息, C装置", "33 - 训练家卡片", "34 - 神秘礼物", "35 - 梦世界的东西（目录）", "36 - 通讯器？", "37 - 冒险数据 http://projectpokemon.org/forums/showthread.php?24589-B2W2-General-ROM-Info&p=167300&viewfull=1#post167300", "38 - 训练家卡片记录", "39 - ???", "40 - 邮件(40d)", "41 - ???", "42 - 包含旗标以及下载数据(音乐剧）的参考", "43 - Fused Reshiram/Zekrom Storage", "44 - 红外IR", "45 - Const Data Block and Event Flag Block (0x35E is the split)", "46 - ???", "47 - 锦标赛", "48 - Gimmick", "49 - 对战盒", "50 - 饲育屋块(50d)", "51 - Strength Boulder Status Block", "52 - 徽章旗标，零花钱，训练家发言", "53 - 连入连接 (等级&释出之力等)", "54 - 宝可梦图鉴", "55 - 大量出现和其他全局信息 - 2C - 大量出现, 2D - 喷雾剂步数, 2E 喷雾类型", "56 - 对战地铁游玩信息", "57 - 对战地铁得分信息", "58 - 对战地铁WIFI信息", "59 - 联网记录", "60 - 连入之森-解密 (60d)", "61 - ???", "62 - ???", "63 - PWT相关数据", "64 - ???", "65 - ???", "66 - Hollow/劲敌 块", "67 - 汇合大道块", "68 - 奖牌数据", "69 - 钥匙相关数据", "70 - 庆典任务 (70d)", "71 - ???", "72 - 3DS连接相关数据", "73 - 校验值块 (73d)" });
            selectedblock.Location = new Point(16, 14);
            selectedblock.Margin = new Padding(4, 4, 4, 4);
            selectedblock.MaxDropDownItems = 10;
            selectedblock.Name = "selectedblock";
            selectedblock.Size = new Size(921, 23);
            selectedblock.TabIndex = 5;
            selectedblock.SelectedIndexChanged += SelectedblockSelectedIndexChanged;
            // 
            // crypt_check
            // 
            crypt_check.AutoCheck = false;
            crypt_check.Location = new Point(16, 44);
            crypt_check.Margin = new Padding(4, 4, 4, 4);
            crypt_check.Name = "crypt_check";
            crypt_check.Size = new Size(139, 28);
            crypt_check.TabIndex = 6;
            crypt_check.Text = "加密";
            crypt_check.UseVisualStyleBackColor = true;
            crypt_check.CheckedChanged += Crypt_checkCheckedChanged;
            // 
            // BW_blocklist
            // 
            BW_blocklist.FormattingEnabled = true;
            BW_blocklist.Items.AddRange(new object[] { "00 - 盒子名称", "01 - 盒子1", "02 - 盒子2", "03 - 盒子3", "04 - 盒子4", "05 - 盒子5", "06 - 盒子6", "07 - 盒子7", "08 - 盒子8", "09 - 盒子9", "10 - 盒子10", "11 - 盒子11", "12 - 盒子12", "13 - 盒子13", "14 - 盒子14", "15 - 盒子15", "16 - 盒子16", "17 - 盒子17", "18 - 盒子18", "19 - 盒子19", "20 - 盒子20", "21 - 盒子21", "22 - 盒子22", "23 - 盒子23", "24 - 盒子24", "25 - 库存？", "26 - 同行宝可梦", "27 - 训练家数据", "28 - 训练家状态", "29 - 联合塔和调查的东西", "30 - 朋友手册玩家数据", "31 - 朋友手册朋友数据", "32 - 皮肤信息", "33 - ??? - 道观徽章数据", "34 - 神秘礼物", "35 - 梦世界的东西（目录）", "36 - 通讯器？", "37 - 冒险信息", "38 - 训练家卡片记录", "39 - ???", "40 - ???", "41 - ???", "42 - 包含旗标以及下载数据(音乐剧）的参考", "43 - ???", "44 - ???", "45 - ???", "46 - ???", "47 - 锦标赛", "48 - ???", "49 - 对战盒", "50 - 饲育屋块", "51 - Strength Boulder Status Block", "52 - 徽章旗标，零花钱，训练家发言", "53 - 连入连接 (等级&释出之力等)", "54 - ???", "55 - 宝可梦图鉴", "56 - 大量出现和其他全局信息 - 2C - 大量出现, 2D - 喷雾剂步数, 2E 喷雾类型", "57 - ???", "58 - 对战地铁", "59 - ???", "60 - 联网记录", "61 - 连入之森宝可梦数据", "62 - ???", "63 - ???", "64 - ???", "65 - ???", "66 - ???", "67 - ???", "68 - ???", "69 - 校验值块(73d)" });
            BW_blocklist.Location = new Point(16, 14);
            BW_blocklist.Margin = new Padding(4, 4, 4, 4);
            BW_blocklist.MaxDropDownItems = 10;
            BW_blocklist.Name = "BW_blocklist";
            BW_blocklist.Size = new Size(921, 23);
            BW_blocklist.TabIndex = 7;
            BW_blocklist.SelectedIndexChanged += BW_blocklistSelectedIndexChanged;
            // 
            // Dumper
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 118);
            Controls.Add(BW_blocklist);
            Controls.Add(crypt_check);
            Controls.Add(selectedblock);
            Controls.Add(inject_crypt_but);
            Controls.Add(dump_dec_but);
            Controls.Add(inject_but);
            Controls.Add(dump_but);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "Dumper";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "存档块导出导入器";
            ResumeLayout(false);
        }
    }
}

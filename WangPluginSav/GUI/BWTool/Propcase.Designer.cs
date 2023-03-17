/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 15/03/2021
 * Time: 20:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
    partial class PropCase
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropCase));
            Proplist = new ComboBox();
            hasprop_checkbox = new CheckBox();
            unloackAllBut = new Button();
            label1 = new Label();
            propHex = new Label();
            Exit_but = new Button();
            Saveexit_but = new Button();
            spriteBox = new PictureBox();
            removeAllBut = new Button();
            ((System.ComponentModel.ISupportInitialize)spriteBox).BeginInit();
            SuspendLayout();
            // 
            // Proplist
            // 
            Proplist.FormattingEnabled = true;
            Proplist.Items.AddRange(new object[] { "粉色发夹", "蓝色发夹", "红色发夹", "蓝色花朵", "红色围巾", "红色花朵", "大型发夹", "发箍", "方框眼镜", "条纹发夹", "小型发夹", "装饰缎带", "手提袋", "项链", "艳丽花朵", "圆形纽扣", "绿色发夹", "草帽", "雪结晶", "单枝的花", "画笔", "贝雷帽", "打蛋器", "汤勺", "蛋糕模型", "厨师帽", "平底锅", "围嘴", "红色阳伞", "伤风口罩", "铁锤", "缤纷阳伞", "扳手", "手提油灯", "发条", "安全头盔", "褶边围裙", "洋装领结", "丝质礼帽", "红色披风", "玩具刀", "玩具剑", "海贼帽", "牛仔帽", "坚硬盾牌", "漆黑之翼", "女巫帽子", "纯白之翼", "茶色皮带", "带角头盔", "三叉戟", "魔杖", "红鼻子", "小丑帽", "晕晕眼镜", "王冠", "黑色领带", "黑色披风", "华丽眼镜", "褶边头带", "白色面具", "白色披风", "绅士帽", "手杖", "斜纹领带", "小怀表", "蝴蝶领结", "后冠", "蔷薇花", "单片眼镜", "横纹领带", "爆炸头", "立式话筒", "铃鼓", "小帽子", "手持话筒", "响葫芦", "喇叭", "桂冠", "白色绒球", "旗子", "球", "优胜腰带", "球拍", "电吉他", "玩具钓竿", "笑笑面具", "假肚脐", "博士帽", "草裙", "厚重的书", "捧花", "骨头仿品", "圆圆蘑菇", "手里剑", "红色帽子", "大布袋", "糖果", "密密胡子", "礼物盒" });
            Proplist.Location = new Point(35, 32);
            Proplist.Margin = new Padding(4, 4, 4, 4);
            Proplist.Name = "Proplist";
            Proplist.Size = new Size(160, 23);
            Proplist.TabIndex = 0;
            Proplist.SelectedIndexChanged += ProplistSelectedIndexChanged;
            // 
            // hasprop_checkbox
            // 
            hasprop_checkbox.Location = new Point(224, 32);
            hasprop_checkbox.Margin = new Padding(4, 4, 4, 4);
            hasprop_checkbox.Name = "hasprop_checkbox";
            hasprop_checkbox.Size = new Size(139, 28);
            hasprop_checkbox.TabIndex = 1;
            hasprop_checkbox.Text = "已获得";
            hasprop_checkbox.UseVisualStyleBackColor = true;
            hasprop_checkbox.CheckedChanged += Hasprop_checkboxCheckedChanged;
            // 
            // unloackAllBut
            // 
            unloackAllBut.Location = new Point(35, 79);
            unloackAllBut.Margin = new Padding(4, 4, 4, 4);
            unloackAllBut.Name = "unloackAllBut";
            unloackAllBut.Size = new Size(136, 26);
            unloackAllBut.TabIndex = 2;
            unloackAllBut.Text = "解锁全部";
            unloackAllBut.UseVisualStyleBackColor = true;
            unloackAllBut.Click += Button1Click;
            // 
            // label1
            // 
            label1.Location = new Point(35, 109);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 26);
            label1.TabIndex = 3;
            label1.Text = "十六进制：";
            // 
            // propHex
            // 
            propHex.Location = new Point(124, 109);
            propHex.Margin = new Padding(4, 0, 4, 0);
            propHex.Name = "propHex";
            propHex.Size = new Size(387, 26);
            propHex.TabIndex = 4;
            propHex.Text = "0x";
            // 
            // Exit_but
            // 
            Exit_but.Location = new Point(35, 128);
            Exit_but.Margin = new Padding(4, 4, 4, 4);
            Exit_but.Name = "Exit_but";
            Exit_but.Size = new Size(136, 26);
            Exit_but.TabIndex = 21;
            Exit_but.Text = "退出";
            Exit_but.UseVisualStyleBackColor = true;
            Exit_but.Click += Exit_butClick;
            // 
            // Saveexit_but
            // 
            Saveexit_but.Location = new Point(177, 128);
            Saveexit_but.Margin = new Padding(4, 4, 4, 4);
            Saveexit_but.Name = "Saveexit_but";
            Saveexit_but.Size = new Size(136, 26);
            Saveexit_but.TabIndex = 20;
            Saveexit_but.Text = "保存并退出";
            Saveexit_but.UseVisualStyleBackColor = true;
            Saveexit_but.Click += Saveexit_butClick;
            // 
            // spriteBox
            // 
            spriteBox.Location = new Point(339, 10);
            spriteBox.Margin = new Padding(4, 4, 4, 4);
            spriteBox.Name = "spriteBox";
            spriteBox.Size = new Size(129, 73);
            spriteBox.SizeMode = PictureBoxSizeMode.AutoSize;
            spriteBox.TabIndex = 22;
            spriteBox.TabStop = false;
            // 
            // removeAllBut
            // 
            removeAllBut.Location = new Point(177, 79);
            removeAllBut.Margin = new Padding(4, 4, 4, 4);
            removeAllBut.Name = "removeAllBut";
            removeAllBut.Size = new Size(136, 26);
            removeAllBut.TabIndex = 23;
            removeAllBut.Text = "移除全部";
            removeAllBut.UseVisualStyleBackColor = true;
            removeAllBut.Click += RemoveAllButClick;
            // 
            // PropCase
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 163);
            Controls.Add(removeAllBut);
            Controls.Add(unloackAllBut);
            Controls.Add(spriteBox);
            Controls.Add(Exit_but);
            Controls.Add(Saveexit_but);
            Controls.Add(propHex);
            Controls.Add(label1);
            Controls.Add(hasprop_checkbox);
            Controls.Add(Proplist);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "PropCase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "物品箱编辑器";
            ((System.ComponentModel.ISupportInitialize)spriteBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button removeAllBut;
        private System.Windows.Forms.PictureBox spriteBox;
        private System.Windows.Forms.Button Saveexit_but;
        private System.Windows.Forms.Button Exit_but;
        private System.Windows.Forms.Label propHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button unloackAllBut;
        private System.Windows.Forms.CheckBox hasprop_checkbox;
        private System.Windows.Forms.ComboBox Proplist;
    }
}

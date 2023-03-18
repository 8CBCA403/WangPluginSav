/*
 * Created by SharpDevelop.
 * User: sergi
 * Date: 17/06/2016
 * Time: 21:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
    partial class TrainerInfo
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rival_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown seconds;
        private System.Windows.Forms.NumericUpDown minutes;
        private System.Windows.Forms.NumericUpDown hours;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown tid;
        private System.Windows.Forms.NumericUpDown sid;
        private System.Windows.Forms.ComboBox tnr_class;
        private System.Windows.Forms.ComboBox tnr_nature;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox rival_name;
        private System.Windows.Forms.NumericUpDown money;
        private System.Windows.Forms.NumericUpDown bp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Button Exit_but;
        private System.Windows.Forms.Button Saveexit_but;
        private System.Windows.Forms.CheckBox badge1;
        private System.Windows.Forms.DateTimePicker badge1_date;
        private System.Windows.Forms.DateTimePicker badge2_date;
        private System.Windows.Forms.CheckBox badge2;
        private System.Windows.Forms.DateTimePicker badge3_date;
        private System.Windows.Forms.CheckBox badge3;
        private System.Windows.Forms.DateTimePicker badge4_date;
        private System.Windows.Forms.CheckBox badge4;
        private System.Windows.Forms.DateTimePicker badge5_date;
        private System.Windows.Forms.CheckBox badge5;
        private System.Windows.Forms.DateTimePicker badge6_date;
        private System.Windows.Forms.CheckBox badge6;
        private System.Windows.Forms.DateTimePicker badge7_date;
        private System.Windows.Forms.CheckBox badge7;
        private System.Windows.Forms.DateTimePicker badge8_date;
        private System.Windows.Forms.CheckBox badge8;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerInfo));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rival_label = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            seconds = new NumericUpDown();
            minutes = new NumericUpDown();
            hours = new NumericUpDown();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tid = new NumericUpDown();
            sid = new NumericUpDown();
            tnr_class = new ComboBox();
            tnr_nature = new ComboBox();
            name = new TextBox();
            rival_name = new TextBox();
            money = new NumericUpDown();
            bp = new NumericUpDown();
            label12 = new Label();
            gender = new ComboBox();
            Exit_but = new Button();
            Saveexit_but = new Button();
            badge1 = new CheckBox();
            badge1_date = new DateTimePicker();
            badge2_date = new DateTimePicker();
            badge2 = new CheckBox();
            badge3_date = new DateTimePicker();
            badge3 = new CheckBox();
            badge4_date = new DateTimePicker();
            badge4 = new CheckBox();
            badge5_date = new DateTimePicker();
            badge5 = new CheckBox();
            badge6_date = new DateTimePicker();
            badge6 = new CheckBox();
            badge7_date = new DateTimePicker();
            badge7 = new CheckBox();
            badge8_date = new DateTimePicker();
            badge8 = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)money).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bp).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(16, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 26);
            label1.TabIndex = 0;
            label1.Text = "主人公";
            // 
            // label2
            // 
            label2.Location = new Point(16, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 26);
            label2.TabIndex = 1;
            label2.Text = "TID";
            // 
            // label3
            // 
            label3.Location = new Point(16, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 26);
            label3.TabIndex = 2;
            label3.Text = "SID";
            // 
            // rival_label
            // 
            rival_label.Location = new Point(19, 309);
            rival_label.Margin = new Padding(4, 0, 4, 0);
            rival_label.Name = "rival_label";
            rival_label.Size = new Size(68, 26);
            rival_label.TabIndex = 3;
            rival_label.Text = "劲敌";
            // 
            // label5
            // 
            label5.Location = new Point(333, 32);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 26);
            label5.TabIndex = 4;
            label5.Text = "零花钱";
            // 
            // label6
            // 
            label6.Location = new Point(16, 122);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(123, 26);
            label6.TabIndex = 5;
            label6.Text = "训练家类型";
            // 
            // label7
            // 
            label7.Location = new Point(16, 154);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 26);
            label7.TabIndex = 6;
            label7.Text = "训练家性格";
            // 
            // label8
            // 
            label8.Location = new Point(333, 65);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 26);
            label8.TabIndex = 7;
            label8.Text = "对战点数";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(seconds);
            groupBox1.Controls.Add(minutes);
            groupBox1.Controls.Add(hours);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(16, 182);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(279, 107);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "游戏时间";
            // 
            // seconds
            // 
            seconds.Location = new Point(111, 75);
            seconds.Margin = new Padding(4);
            seconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            seconds.Name = "seconds";
            seconds.Size = new Size(160, 25);
            seconds.TabIndex = 13;
            // 
            // minutes
            // 
            minutes.Location = new Point(111, 49);
            minutes.Margin = new Padding(4);
            minutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minutes.Name = "minutes";
            minutes.Size = new Size(160, 25);
            minutes.TabIndex = 12;
            // 
            // hours
            // 
            hours.Location = new Point(111, 22);
            hours.Margin = new Padding(4);
            hours.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            hours.Name = "hours";
            hours.Size = new Size(160, 25);
            hours.TabIndex = 11;
            // 
            // label11
            // 
            label11.Location = new Point(8, 77);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(115, 26);
            label11.TabIndex = 10;
            label11.Text = "秒";
            // 
            // label10
            // 
            label10.Location = new Point(8, 51);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(115, 26);
            label10.TabIndex = 10;
            label10.Text = "分钟";
            // 
            // label9
            // 
            label9.Location = new Point(8, 24);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(115, 26);
            label9.TabIndex = 9;
            label9.Text = "小时";
            // 
            // tid
            // 
            tid.Location = new Point(127, 58);
            tid.Margin = new Padding(4);
            tid.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            tid.Name = "tid";
            tid.Size = new Size(160, 25);
            tid.TabIndex = 9;
            // 
            // sid
            // 
            sid.Location = new Point(127, 88);
            sid.Margin = new Padding(4);
            sid.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            sid.Name = "sid";
            sid.Size = new Size(160, 25);
            sid.TabIndex = 10;
            // 
            // tnr_class
            // 
            tnr_class.FormattingEnabled = true;
            tnr_class.Items.AddRange(new object[] { "短裤小子", "精英训练家", "宝可梦巡护员", "宝可梦培育家", "研究员", "登山男", "光头男", "幼儿园小朋友" });
            tnr_class.Location = new Point(125, 118);
            tnr_class.Margin = new Padding(4);
            tnr_class.Name = "tnr_class";
            tnr_class.Size = new Size(160, 23);
            tnr_class.TabIndex = 11;
            // 
            // tnr_nature
            // 
            tnr_nature.FormattingEnabled = true;
            tnr_nature.Items.AddRange(new object[] { "勤奋", "怕寂寞", "勇勇", "固执", "顽皮", "大胆", "坦率", "悠哉", "淘气", "乐天", "胆小", "急躁", "认真", "爽朗", "天真", "内敛", "慢吞吞", "冷静", "害羞", "马虎", "温和", "温顺", "自大", "慎重", "浮躁" });
            tnr_nature.Location = new Point(125, 150);
            tnr_nature.Margin = new Padding(4);
            tnr_nature.Name = "tnr_nature";
            tnr_nature.Size = new Size(160, 23);
            tnr_nature.TabIndex = 12;
            // 
            // name
            // 
            name.Location = new Point(125, 28);
            name.Margin = new Padding(4);
            name.MaxLength = 8;
            name.Name = "name";
            name.Size = new Size(159, 25);
            name.TabIndex = 13;
            // 
            // rival_name
            // 
            rival_name.Location = new Point(125, 306);
            rival_name.Margin = new Padding(4);
            rival_name.MaxLength = 8;
            rival_name.Name = "rival_name";
            rival_name.Size = new Size(159, 25);
            rival_name.TabIndex = 14;
            // 
            // money
            // 
            money.Location = new Point(440, 30);
            money.Margin = new Padding(4);
            money.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            money.Name = "money";
            money.Size = new Size(160, 25);
            money.TabIndex = 14;
            // 
            // bp
            // 
            bp.Location = new Point(440, 62);
            bp.Margin = new Padding(4);
            bp.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            bp.Name = "bp";
            bp.Size = new Size(160, 25);
            bp.TabIndex = 15;
            // 
            // label12
            // 
            label12.Location = new Point(333, 94);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(95, 26);
            label12.TabIndex = 16;
            label12.Text = "性别";
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "男", "女" });
            gender.Location = new Point(440, 90);
            gender.Margin = new Padding(4);
            gender.Name = "gender";
            gender.Size = new Size(160, 23);
            gender.TabIndex = 17;
            // 
            // Exit_but
            // 
            Exit_but.Location = new Point(16, 358);
            Exit_but.Margin = new Padding(4);
            Exit_but.Name = "Exit_but";
            Exit_but.Size = new Size(136, 26);
            Exit_but.TabIndex = 19;
            Exit_but.Text = "退出";
            Exit_but.UseVisualStyleBackColor = true;
            Exit_but.Click += Exit_butClick;
            // 
            // Saveexit_but
            // 
            Saveexit_but.Location = new Point(159, 358);
            Saveexit_but.Margin = new Padding(4);
            Saveexit_but.Name = "Saveexit_but";
            Saveexit_but.Size = new Size(136, 26);
            Saveexit_but.TabIndex = 18;
            Saveexit_but.Text = "保存并退出";
            Saveexit_but.UseVisualStyleBackColor = true;
            Saveexit_but.Click += Saveexit_butClick;
            // 
            // badge1
            // 
            badge1.Location = new Point(333, 145);
            badge1.Margin = new Padding(4);
            badge1.Name = "badge1";
            badge1.Size = new Size(167, 34);
            badge1.TabIndex = 20;
            badge1.Text = "徽章1";
            badge1.UseVisualStyleBackColor = true;
            // 
            // badge1_date
            // 
            badge1_date.Location = new Point(423, 146);
            badge1_date.Margin = new Padding(4);
            badge1_date.Name = "badge1_date";
            badge1_date.Size = new Size(265, 25);
            badge1_date.TabIndex = 21;
            // 
            // badge2_date
            // 
            badge2_date.Location = new Point(423, 176);
            badge2_date.Margin = new Padding(4);
            badge2_date.Name = "badge2_date";
            badge2_date.Size = new Size(265, 25);
            badge2_date.TabIndex = 23;
            // 
            // badge2
            // 
            badge2.Location = new Point(333, 175);
            badge2.Margin = new Padding(4);
            badge2.Name = "badge2";
            badge2.Size = new Size(167, 34);
            badge2.TabIndex = 22;
            badge2.Text = "徽章2";
            badge2.UseVisualStyleBackColor = true;
            // 
            // badge3_date
            // 
            badge3_date.Location = new Point(423, 206);
            badge3_date.Margin = new Padding(4);
            badge3_date.Name = "badge3_date";
            badge3_date.Size = new Size(265, 25);
            badge3_date.TabIndex = 25;
            // 
            // badge3
            // 
            badge3.Location = new Point(333, 205);
            badge3.Margin = new Padding(4);
            badge3.Name = "badge3";
            badge3.Size = new Size(167, 34);
            badge3.TabIndex = 24;
            badge3.Text = "徽章3";
            badge3.UseVisualStyleBackColor = true;
            // 
            // badge4_date
            // 
            badge4_date.Location = new Point(423, 236);
            badge4_date.Margin = new Padding(4);
            badge4_date.Name = "badge4_date";
            badge4_date.Size = new Size(265, 25);
            badge4_date.TabIndex = 27;
            // 
            // badge4
            // 
            badge4.Location = new Point(333, 235);
            badge4.Margin = new Padding(4);
            badge4.Name = "badge4";
            badge4.Size = new Size(167, 34);
            badge4.TabIndex = 26;
            badge4.Text = "徽章4";
            badge4.UseVisualStyleBackColor = true;
            // 
            // badge5_date
            // 
            badge5_date.Location = new Point(423, 266);
            badge5_date.Margin = new Padding(4);
            badge5_date.Name = "badge5_date";
            badge5_date.Size = new Size(265, 25);
            badge5_date.TabIndex = 29;
            // 
            // badge5
            // 
            badge5.Location = new Point(333, 265);
            badge5.Margin = new Padding(4);
            badge5.Name = "badge5";
            badge5.Size = new Size(167, 34);
            badge5.TabIndex = 28;
            badge5.Text = "徽章5";
            badge5.UseVisualStyleBackColor = true;
            // 
            // badge6_date
            // 
            badge6_date.Location = new Point(423, 296);
            badge6_date.Margin = new Padding(4);
            badge6_date.Name = "badge6_date";
            badge6_date.Size = new Size(265, 25);
            badge6_date.TabIndex = 31;
            // 
            // badge6
            // 
            badge6.Location = new Point(333, 295);
            badge6.Margin = new Padding(4);
            badge6.Name = "badge6";
            badge6.Size = new Size(167, 34);
            badge6.TabIndex = 30;
            badge6.Text = "徽章6";
            badge6.UseVisualStyleBackColor = true;
            // 
            // badge7_date
            // 
            badge7_date.Location = new Point(423, 326);
            badge7_date.Margin = new Padding(4);
            badge7_date.Name = "badge7_date";
            badge7_date.Size = new Size(265, 25);
            badge7_date.TabIndex = 33;
            // 
            // badge7
            // 
            badge7.Location = new Point(333, 325);
            badge7.Margin = new Padding(4);
            badge7.Name = "badge7";
            badge7.Size = new Size(167, 34);
            badge7.TabIndex = 32;
            badge7.Text = "徽章7";
            badge7.UseVisualStyleBackColor = true;
            // 
            // badge8_date
            // 
            badge8_date.Location = new Point(423, 356);
            badge8_date.Margin = new Padding(4);
            badge8_date.Name = "badge8_date";
            badge8_date.Size = new Size(265, 25);
            badge8_date.TabIndex = 35;
            // 
            // badge8
            // 
            badge8.Location = new Point(333, 355);
            badge8.Margin = new Padding(4);
            badge8.Name = "badge8";
            badge8.Size = new Size(167, 34);
            badge8.TabIndex = 34;
            badge8.Text = "徽章8";
            badge8.UseVisualStyleBackColor = true;
            // 
            // TrainerInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 401);
            Controls.Add(badge8_date);
            Controls.Add(badge8);
            Controls.Add(badge7_date);
            Controls.Add(badge7);
            Controls.Add(badge6_date);
            Controls.Add(badge6);
            Controls.Add(badge5_date);
            Controls.Add(badge5);
            Controls.Add(badge4_date);
            Controls.Add(badge4);
            Controls.Add(badge3_date);
            Controls.Add(badge3);
            Controls.Add(badge2_date);
            Controls.Add(badge2);
            Controls.Add(badge1_date);
            Controls.Add(badge1);
            Controls.Add(Exit_but);
            Controls.Add(Saveexit_but);
            Controls.Add(gender);
            Controls.Add(label12);
            Controls.Add(bp);
            Controls.Add(money);
            Controls.Add(rival_name);
            Controls.Add(name);
            Controls.Add(tnr_nature);
            Controls.Add(tnr_class);
            Controls.Add(sid);
            Controls.Add(tid);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rival_label);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TrainerInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "训练家信息";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)seconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)hours).EndInit();
            ((System.ComponentModel.ISupportInitialize)tid).EndInit();
            ((System.ComponentModel.ISupportInitialize)sid).EndInit();
            ((System.ComponentModel.ISupportInitialize)money).EndInit();
            ((System.ComponentModel.ISupportInitialize)bp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

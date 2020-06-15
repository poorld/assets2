using Assets.Common.Constant;
using Assets.Common.Enums;
namespace Assets.Views.LocaleManage.Add
{
    partial class LocaleAdd
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.localeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbEnable = new System.Windows.Forms.RadioButton();
            this.rbDisable = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbConsumables = new System.Windows.Forms.RadioButton();
            this.rbFixed = new System.Windows.Forms.RadioButton();
            this.tbExplain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "存放地点";
            // 
            // localeName
            // 
            this.localeName.Location = new System.Drawing.Point(103, 50);
            this.localeName.Margin = new System.Windows.Forms.Padding(2);
            this.localeName.Name = "localeName";
            this.localeName.Size = new System.Drawing.Size(238, 21);
            this.localeName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "选择状态";
            // 
            // rbEnable
            // 
            this.rbEnable.AutoSize = true;
            this.rbEnable.Location = new System.Drawing.Point(26, 30);
            this.rbEnable.Margin = new System.Windows.Forms.Padding(2);
            this.rbEnable.Name = "rbEnable";
            this.rbEnable.Size = new System.Drawing.Size(47, 16);
            this.rbEnable.TabIndex = 5;
            this.rbEnable.TabStop = true;
            this.rbEnable.Text = "正常";
            this.rbEnable.UseVisualStyleBackColor = true;
            // 
            // rbDisable
            // 
            this.rbDisable.AutoSize = true;
            this.rbDisable.Location = new System.Drawing.Point(133, 30);
            this.rbDisable.Margin = new System.Windows.Forms.Padding(2);
            this.rbDisable.Name = "rbDisable";
            this.rbDisable.Size = new System.Drawing.Size(47, 16);
            this.rbDisable.TabIndex = 6;
            this.rbDisable.TabStop = true;
            this.rbDisable.Text = "报废";
            this.rbDisable.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(166, 342);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(62, 27);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.confirmClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDisable);
            this.groupBox1.Controls.Add(this.rbEnable);
            this.groupBox1.Location = new System.Drawing.Point(103, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(237, 67);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "选择类型";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbConsumables);
            this.groupBox2.Controls.Add(this.rbFixed);
            this.groupBox2.Location = new System.Drawing.Point(103, 153);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(237, 67);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // rbConsumables
            // 
            this.rbConsumables.AutoSize = true;
            this.rbConsumables.Location = new System.Drawing.Point(133, 30);
            this.rbConsumables.Margin = new System.Windows.Forms.Padding(2);
            this.rbConsumables.Name = "rbConsumables";
            this.rbConsumables.Size = new System.Drawing.Size(71, 16);
            this.rbConsumables.TabIndex = 6;
            this.rbConsumables.TabStop = true;
            this.rbConsumables.Text = "耗材物品";
            this.rbConsumables.UseVisualStyleBackColor = true;
            // 
            // rbFixed
            // 
            this.rbFixed.AutoSize = true;
            this.rbFixed.Location = new System.Drawing.Point(26, 30);
            this.rbFixed.Margin = new System.Windows.Forms.Padding(2);
            this.rbFixed.Name = "rbFixed";
            this.rbFixed.Size = new System.Drawing.Size(71, 16);
            this.rbFixed.TabIndex = 5;
            this.rbFixed.TabStop = true;
            this.rbFixed.Text = "固定资产";
            this.rbFixed.UseVisualStyleBackColor = true;
            // 
            // tbExplain
            // 
            this.tbExplain.Location = new System.Drawing.Point(103, 254);
            this.tbExplain.Multiline = true;
            this.tbExplain.Name = "tbExplain";
            this.tbExplain.Size = new System.Drawing.Size(238, 66);
            this.tbExplain.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "说明";
            // 
            // LocaleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 402);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbExplain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.localeName);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LocaleAdd";
            this.Text = "存放地点添加";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void initRadioButton()
        {
            rbEnable.Select();
            rbFixed.Select();
            //localeCode.Text = CodePrefixConstant.getLocaleCode();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox localeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbEnable;
        private System.Windows.Forms.RadioButton rbDisable;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbConsumables;
        private System.Windows.Forms.RadioButton rbFixed;
        private System.Windows.Forms.TextBox tbExplain;
        private System.Windows.Forms.Label label5;
    }
}
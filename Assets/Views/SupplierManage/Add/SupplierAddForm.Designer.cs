using Assets.Common.Enums;
namespace Assets.Views.SupplierManage.Add
{
    partial class SupplierAddForm
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
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbEnable = new System.Windows.Forms.RadioButton();
            this.rbDisable = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbType3 = new System.Windows.Forms.RadioButton();
            this.rbType2 = new System.Windows.Forms.RadioButton();
            this.rbType1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbConstacts = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "供应商";
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(109, 26);
            this.tbSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(279, 21);
            this.tbSupplierName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 82);
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
            this.btnOk.Location = new System.Drawing.Point(191, 385);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(62, 27);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOkClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDisable);
            this.groupBox1.Controls.Add(this.rbEnable);
            this.groupBox1.Location = new System.Drawing.Point(109, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(279, 67);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "选择类型";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbType3);
            this.groupBox2.Controls.Add(this.rbType2);
            this.groupBox2.Controls.Add(this.rbType1);
            this.groupBox2.Location = new System.Drawing.Point(109, 129);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(279, 67);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // rbType3
            // 
            this.rbType3.AutoSize = true;
            this.rbType3.Location = new System.Drawing.Point(184, 30);
            this.rbType3.Margin = new System.Windows.Forms.Padding(2);
            this.rbType3.Name = "rbType3";
            this.rbType3.Size = new System.Drawing.Size(47, 16);
            this.rbType3.TabIndex = 7;
            this.rbType3.TabStop = true;
            this.rbType3.Text = SupplierType.零件.ToString();
            this.rbType3.UseVisualStyleBackColor = true;
            // 
            // rbType2
            // 
            this.rbType2.AutoSize = true;
            this.rbType2.Location = new System.Drawing.Point(109, 30);
            this.rbType2.Margin = new System.Windows.Forms.Padding(2);
            this.rbType2.Name = "rbType2";
            this.rbType2.Size = new System.Drawing.Size(59, 16);
            this.rbType2.TabIndex = 6;
            this.rbType2.TabStop = true;
            this.rbType2.Text = SupplierType.代理商.ToString();
            this.rbType2.UseVisualStyleBackColor = true;
            // 
            // rbType1
            // 
            this.rbType1.AutoSize = true;
            this.rbType1.Location = new System.Drawing.Point(26, 30);
            this.rbType1.Margin = new System.Windows.Forms.Padding(2);
            this.rbType1.Name = "rbType1";
            this.rbType1.Size = new System.Drawing.Size(59, 16);
            this.rbType1.TabIndex = 5;
            this.rbType1.TabStop = true;
            this.rbType1.Text = SupplierType.生产商.ToString();
            this.rbType1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "联系人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "电话";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "地址";
            // 
            // tbConstacts
            // 
            this.tbConstacts.Location = new System.Drawing.Point(109, 230);
            this.tbConstacts.Margin = new System.Windows.Forms.Padding(2);
            this.tbConstacts.Name = "tbConstacts";
            this.tbConstacts.Size = new System.Drawing.Size(279, 21);
            this.tbConstacts.TabIndex = 14;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(109, 275);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhone.MaxLength = 11;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(279, 21);
            this.tbPhone.TabIndex = 15;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(109, 323);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(279, 21);
            this.tbAddress.TabIndex = 16;
            // 
            // SupplierAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 440);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbConstacts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSupplierName);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupplierAddForm";
            this.Text = "供应商添加";
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
            rbType1.Select();
            //localeCode.Text = CodePrefixConstant.getLocaleCode();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbEnable;
        private System.Windows.Forms.RadioButton rbDisable;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbType2;
        private System.Windows.Forms.RadioButton rbType1;
        private System.Windows.Forms.RadioButton rbType3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbConstacts;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
    }
}
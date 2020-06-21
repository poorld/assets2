using System;

namespace Assets.Views.AssetsClassManage.Add
{
    partial class AssetsClassAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPCCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPCName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "资产类别编号";
            // 
            // tbPCCode
            // 
            this.tbPCCode.Location = new System.Drawing.Point(109, 36);
            this.tbPCCode.Name = "tbPCCode";
            this.tbPCCode.ReadOnly = true;
            this.tbPCCode.Size = new System.Drawing.Size(275, 21);
            this.tbPCCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "资产类别名称";
            // 
            // tbPCName
            // 
            this.tbPCName.Location = new System.Drawing.Point(109, 97);
            this.tbPCName.Name = "tbPCName";
            this.tbPCName.Size = new System.Drawing.Size(275, 21);
            this.tbPCName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 149);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOkClick);
            // 
            // AssetsClassAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPCCode);
            this.Controls.Add(this.label1);
            this.Name = "AssetsClassAddForm";
            this.Text = "资产类别添加";
            this.Load += new System.EventHandler(this.AssetsClassAddManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPCCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPCName;
        private System.Windows.Forms.Button button1;
    }
}
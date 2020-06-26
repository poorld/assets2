﻿namespace Assets.Views.AssetManage.Add
{
    partial class AssetsAdd
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
            this.AssetsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LocaleCB = new System.Windows.Forms.ComboBox();
            this.SupplierCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AssetsClassCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BrandCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "资产名称";
            // 
            // AssetsName
            // 
            this.AssetsName.Location = new System.Drawing.Point(139, 28);
            this.AssetsName.Name = "AssetsName";
            this.AssetsName.Size = new System.Drawing.Size(362, 28);
            this.AssetsName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "存放地点";
            // 
            // LocaleCB
            // 
            this.LocaleCB.FormattingEnabled = true;
            this.LocaleCB.Location = new System.Drawing.Point(139, 84);
            this.LocaleCB.Name = "LocaleCB";
            this.LocaleCB.Size = new System.Drawing.Size(362, 26);
            this.LocaleCB.TabIndex = 3;
            // 
            // SupplierCB
            // 
            this.SupplierCB.FormattingEnabled = true;
            this.SupplierCB.Location = new System.Drawing.Point(139, 139);
            this.SupplierCB.Name = "SupplierCB";
            this.SupplierCB.Size = new System.Drawing.Size(362, 26);
            this.SupplierCB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "供应商";
            // 
            // AssetsClassCB
            // 
            this.AssetsClassCB.FormattingEnabled = true;
            this.AssetsClassCB.Location = new System.Drawing.Point(139, 196);
            this.AssetsClassCB.Name = "AssetsClassCB";
            this.AssetsClassCB.Size = new System.Drawing.Size(362, 26);
            this.AssetsClassCB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "资产类别";
            // 
            // BrandCB
            // 
            this.BrandCB.FormattingEnabled = true;
            this.BrandCB.Location = new System.Drawing.Point(139, 259);
            this.BrandCB.Name = "BrandCB";
            this.BrandCB.Size = new System.Drawing.Size(362, 26);
            this.BrandCB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "品牌";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(457, 109);
            this.button1.TabIndex = 12;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AssetsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BrandCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AssetsClassCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SupplierCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LocaleCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AssetsName);
            this.Controls.Add(this.label1);
            this.Name = "AssetsAdd";
            this.Text = "AssetsAdd";
            this.Load += new System.EventHandler(this.AssetAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AssetsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LocaleCB;
        private System.Windows.Forms.ComboBox SupplierCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AssetsClassCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BrandCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}
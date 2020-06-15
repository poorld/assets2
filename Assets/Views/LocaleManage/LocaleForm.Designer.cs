using Assets.Common.Entity;
using Assets.Views.LocaleManage.Dao;
using System.Collections.Generic;
namespace Assets.PlaceManage
{
    partial class PlaceForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Column_brand_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Locale_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_brand_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_brand_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Locale_Explain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_brand_id,
            this.Column_Locale_Type,
            this.Column_brand_name,
            this.Column_brand_state,
            this.Column_Locale_Explain});
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(836, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.cellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 37);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(426, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "删除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.localeDelete);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(345, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.updateLocale);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "禁用";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.disableLocale);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(755, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "搜索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(649, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // Column_brand_id
            // 
            this.Column_brand_id.HeaderText = "序列";
            this.Column_brand_id.Name = "Column_brand_id";
            // 
            // Column_Locale_Type
            // 
            this.Column_Locale_Type.HeaderText = "类型";
            this.Column_Locale_Type.Name = "Column_Locale_Type";
            // 
            // Column_brand_name
            // 
            this.Column_brand_name.HeaderText = "存放地点";
            this.Column_brand_name.Name = "Column_brand_name";
            // 
            // Column_brand_state
            // 
            this.Column_brand_state.HeaderText = "状态";
            this.Column_brand_state.Name = "Column_brand_state";
            // 
            // Column_Locale_Explain
            // 
            this.Column_Locale_Explain.HeaderText = "说明";
            this.Column_Locale_Explain.Name = "Column_Locale_Explain";
            // 
            // PlaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 303);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlaceForm";
            this.Text = "存放地点";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;


        private void initData()
        {
            dataGridView1.Rows.Clear();
            LocaleDao dao = new LocaleDao();
            List<Locale> list = dao.getLocales();
            foreach (Locale locale in list)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Tag = locale;
                dataGridView1.Rows[index].Cells[0].Value = locale.LocaleId;
                dataGridView1.Rows[index].Cells[1].Value = locale.LocaleType;
                dataGridView1.Rows[index].Cells[2].Value = locale.LocaleName;
                dataGridView1.Rows[index].Cells[3].Value = locale.LocaleState;
                dataGridView1.Rows[index].Cells[4].Value = locale.LocaleExplain;
            }


        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Column_brand_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Locale_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_brand_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_brand_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Locale_Explain;
    }
}
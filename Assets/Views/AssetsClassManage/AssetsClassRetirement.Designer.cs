namespace Assets.AssetsClass
{
    partial class AssetsClassRetirement
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
            this.Column_pc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_pc_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_pc_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_pc_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_pc_id,
            this.Column_pc_code,
            this.Column_pc_name,
            this.Column_pc_state});
            this.dataGridView1.Location = new System.Drawing.Point(18, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column_pc_id
            // 
            this.Column_pc_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_pc_id.HeaderText = "序号";
            this.Column_pc_id.Name = "Column_pc_id";
            // 
            // Column_pc_code
            // 
            this.Column_pc_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_pc_code.HeaderText = "编号";
            this.Column_pc_code.Name = "Column_pc_code";
            // 
            // Column_pc_name
            // 
            this.Column_pc_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_pc_name.HeaderText = "名称";
            this.Column_pc_name.Name = "Column_pc_name";
            // 
            // Column_pc_state
            // 
            this.Column_pc_state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_pc_state.HeaderText = "状态";
            this.Column_pc_state.Name = "Column_pc_state";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pcAddClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.pcDelete);
            // 
            // AssetsClassRetirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AssetsClassRetirement";
            this.Text = "AssetsClassManager";
            this.Load += new System.EventHandler(this.AssetsClassManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_pc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_pc_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_pc_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_pc_state;
        private System.Windows.Forms.Button button2;
    }
}

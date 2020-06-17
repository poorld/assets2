namespace Assets.DepartmentManage
{
    partial class DepartmentForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_department_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_department_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetsDataSet = new Assets.assetsDataSet();
            this.departmentTableAdapter = new Assets.assetsDataSetTableAdapters.departmentTableAdapter();
            this.assetsDataSet1 = new Assets.assetsDataSet1();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter1 = new Assets.assetsDataSet1TableAdapters.departmentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_department_id,
            this.Column_department_code,
            this.Column_department_name});
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(860, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column_department_id
            // 
            this.Column_department_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_department_id.HeaderText = "序列";
            this.Column_department_id.Name = "Column_department_id";
            // 
            // Column_department_code
            // 
            this.Column_department_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_department_code.HeaderText = "部门编号";
            this.Column_department_code.Name = "Column_department_code";
            // 
            // Column_department_name
            // 
            this.Column_department_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_department_name.HeaderText = "部门名称";
            this.Column_department_name.Name = "Column_department_name";
            // 
            // assetsDataSet
            // 
            this.assetsDataSet.DataSetName = "assetsDataSet";
            this.assetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // assetsDataSet1
            // 
            this.assetsDataSet1.DataSetName = "assetsDataSet1";
            this.assetsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter1
            // 
            this.departmentTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.departmentAddClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.departmentUpdateClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.departmentRemoveClick);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 303);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartmentForm";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private assetsDataSet assetsDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private assetsDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private assetsDataSet1 assetsDataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private assetsDataSet1TableAdapters.departmentTableAdapter departmentTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_department_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_department_name;

    }
}
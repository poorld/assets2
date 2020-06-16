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
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetsDataSet = new Assets.assetsDataSet();
            this.departmentTableAdapter = new Assets.assetsDataSetTableAdapters.departmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentidDataGridViewTextBoxColumn,
            this.departmentcodeDataGridViewTextBoxColumn,
            this.departmentstateDataGridViewTextBoxColumn,
            this.departmentnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(860, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "序列";
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            // 
            // departmentcodeDataGridViewTextBoxColumn
            // 
            this.departmentcodeDataGridViewTextBoxColumn.DataPropertyName = "department_code";
            this.departmentcodeDataGridViewTextBoxColumn.HeaderText = "部门编号";
            this.departmentcodeDataGridViewTextBoxColumn.Name = "departmentcodeDataGridViewTextBoxColumn";
            // 
            // departmentstateDataGridViewTextBoxColumn
            // 
            this.departmentstateDataGridViewTextBoxColumn.DataPropertyName = "department_state";
            this.departmentstateDataGridViewTextBoxColumn.HeaderText = "部门状态";
            this.departmentstateDataGridViewTextBoxColumn.Name = "departmentstateDataGridViewTextBoxColumn";
            // 
            // departmentnameDataGridViewTextBoxColumn
            // 
            this.departmentnameDataGridViewTextBoxColumn.DataPropertyName = "department_name";
            this.departmentnameDataGridViewTextBoxColumn.HeaderText = "部门名称";
            this.departmentnameDataGridViewTextBoxColumn.Name = "departmentnameDataGridViewTextBoxColumn";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.assetsDataSet;
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
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 303);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartmentForm";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private assetsDataSet assetsDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private assetsDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentnameDataGridViewTextBoxColumn;

    }
}
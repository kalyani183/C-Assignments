namespace SGM_Student_Management_System
{
    partial class frm_View_All_Student_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_All_Student_List));
            this.dgv_View_All_Students_List = new System.Windows.Forms.DataGridView();
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.studentAppDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_App_DetailsTableAdapter = new SGM_Student_Management_System.Student_Details_TabledbDataSet3TableAdapters.Student_App_DetailsTableAdapter();
            this.student_Details_TabledbDataSet4 = new SGM_Student_Management_System.Student_Details_TabledbDataSet4();
            this.studentAppDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_App_DetailsTableAdapter1 = new SGM_Student_Management_System.Student_Details_TabledbDataSet4TableAdapters.Student_App_DetailsTableAdapter();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Students_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAppDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Details_TabledbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAppDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View_All_Students_List
            // 
            this.dgv_View_All_Students_List.AutoGenerateColumns = false;
            this.dgv_View_All_Students_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Students_List.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgv_View_All_Students_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Students_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_All_Students_List.DataSource = this.studentAppDetailsBindingSource1;
            this.dgv_View_All_Students_List.Location = new System.Drawing.Point(28, 95);
            this.dgv_View_All_Students_List.Name = "dgv_View_All_Students_List";
            this.dgv_View_All_Students_List.Size = new System.Drawing.Size(761, 325);
            this.dgv_View_All_Students_List.TabIndex = 0;
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.BackColor = System.Drawing.Color.Snow;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_View_Student_List.Location = new System.Drawing.Point(165, 27);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(503, 53);
            this.lbl_View_Student_List.TabIndex = 1;
            this.lbl_View_Student_List.Text = "View Student List";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Pink;
            this.btn_Logout.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Logout.Location = new System.Drawing.Point(774, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 30);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // student_App_DetailsTableAdapter
            // 
            this.student_App_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // student_Details_TabledbDataSet4
            // 
            this.student_Details_TabledbDataSet4.DataSetName = "Student_Details_TabledbDataSet4";
            this.student_Details_TabledbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentAppDetailsBindingSource1
            // 
            this.studentAppDetailsBindingSource1.DataMember = "Student_App_Details";
            this.studentAppDetailsBindingSource1.DataSource = this.student_Details_TabledbDataSet4;
            // 
            // student_App_DetailsTableAdapter1
            // 
            this.student_App_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // frm_View_All_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(861, 504);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_View_Student_List);
            this.Controls.Add(this.dgv_View_All_Students_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_View_All_Student_List";
            this.ShowInTaskbar = false;
            this.Text = "All Students LIst";
            this.Load += new System.EventHandler(this.frm_View_Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Students_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAppDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Details_TabledbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAppDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_All_Students_List;
        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.BindingSource studentAppDetailsBindingSource;
        private Student_Details_TabledbDataSet3TableAdapters.Student_App_DetailsTableAdapter student_App_DetailsTableAdapter;
        private Student_Details_TabledbDataSet4 student_Details_TabledbDataSet4;
        private System.Windows.Forms.BindingSource studentAppDetailsBindingSource1;
        private Student_Details_TabledbDataSet4TableAdapters.Student_App_DetailsTableAdapter student_App_DetailsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}
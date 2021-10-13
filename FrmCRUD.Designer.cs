
namespace MileStone2
{
    partial class FrmCRUD
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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModuleLink = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModuleDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModuleCode2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnInsertStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnInsertModule = new System.Windows.Forms.Button();
            this.btnDeleteModule = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.btnSearchModule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModuleCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(78, 27);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertModule);
            this.groupBox1.Controls.Add(this.btnDeleteModule);
            this.groupBox1.Controls.Add(this.btnUpdateModule);
            this.groupBox1.Controls.Add(this.btnSearchModule);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtModuleLink);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtModuleDescription);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtModuleName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtModuleCode2);
            this.groupBox1.Location = new System.Drawing.Point(234, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 399);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtModuleCode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.btnInsertStudent);
            this.groupBox2.Controls.Add(this.btnDeleteStudent);
            this.groupBox2.Controls.Add(this.btnUpdateStudent);
            this.groupBox2.Controls.Add(this.btnSearchStudent);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtGender);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtStudentID);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 416);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FirstName";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(80, 143);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(80, 92);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Link";
            // 
            // txtModuleLink
            // 
            this.txtModuleLink.Location = new System.Drawing.Point(86, 178);
            this.txtModuleLink.Name = "txtModuleLink";
            this.txtModuleLink.Size = new System.Drawing.Size(100, 20);
            this.txtModuleLink.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Description";
            // 
            // txtModuleDescription
            // 
            this.txtModuleDescription.Location = new System.Drawing.Point(78, 140);
            this.txtModuleDescription.Name = "txtModuleDescription";
            this.txtModuleDescription.Size = new System.Drawing.Size(100, 20);
            this.txtModuleDescription.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Name";
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(78, 96);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(100, 20);
            this.txtModuleName.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Module Code";
            // 
            // txtModuleCode2
            // 
            this.txtModuleCode2.Location = new System.Drawing.Point(78, 45);
            this.txtModuleCode2.Name = "txtModuleCode2";
            this.txtModuleCode2.Size = new System.Drawing.Size(100, 20);
            this.txtModuleCode2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 177);
            this.dataGridView1.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(470, 246);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 214);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(65, 257);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 10;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(65, 299);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStudent.TabIndex = 11;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // btnInsertStudent
            // 
            this.btnInsertStudent.Location = new System.Drawing.Point(65, 370);
            this.btnInsertStudent.Name = "btnInsertStudent";
            this.btnInsertStudent.Size = new System.Drawing.Size(75, 23);
            this.btnInsertStudent.TabIndex = 13;
            this.btnInsertStudent.Text = "Insert";
            this.btnInsertStudent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(65, 328);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 12;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnInsertModule
            // 
            this.btnInsertModule.Location = new System.Drawing.Point(59, 370);
            this.btnInsertModule.Name = "btnInsertModule";
            this.btnInsertModule.Size = new System.Drawing.Size(75, 23);
            this.btnInsertModule.TabIndex = 21;
            this.btnInsertModule.Text = "Insert";
            this.btnInsertModule.UseVisualStyleBackColor = true;
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.Location = new System.Drawing.Point(59, 328);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteModule.TabIndex = 20;
            this.btnDeleteModule.Text = "Delete";
            this.btnDeleteModule.UseVisualStyleBackColor = true;
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.Location = new System.Drawing.Point(59, 299);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateModule.TabIndex = 19;
            this.btnUpdateModule.Text = "Update";
            this.btnUpdateModule.UseVisualStyleBackColor = true;
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.Location = new System.Drawing.Point(59, 257);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Size = new System.Drawing.Size(75, 23);
            this.btnSearchModule.TabIndex = 18;
            this.btnSearchModule.Text = "Search";
            this.btnSearchModule.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Module Code";
            // 
            // txtModuleCode
            // 
            this.txtModuleCode.Location = new System.Drawing.Point(80, 171);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.Size = new System.Drawing.Size(100, 20);
            this.txtModuleCode.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(78, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // FrmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 472);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCRUD";
            this.Text = "FrmCRUD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertModule;
        private System.Windows.Forms.Button btnDeleteModule;
        private System.Windows.Forms.Button btnUpdateModule;
        private System.Windows.Forms.Button btnSearchModule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModuleLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModuleDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModuleCode2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModuleCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnInsertStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
    }
}
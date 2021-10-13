using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileStone2
{
    public partial class FrmCRUD : Form
    {
        public FrmCRUD()
        {
            InitializeComponent();
        }
        DataHandler dh = new DataHandler();
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = dh.SearchStudent(int.Parse(txtStudentID.Text));
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
           dh.UpdateStudent(int.Parse(txtStudentID.Text), txtName.Text, txtPhone.Text, txtPhone.Text, txtGender.Text, txtAddress.Text, txtModuleCode.Text);
            MessageBox.Show("Student Update success");
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            dh.DeleteStudent(int.Parse(txtStudentID.Text));
            MessageBox.Show("Student Delete success");
        }

        private void btnInsertStudent_Click(object sender, EventArgs e)
        {
            dh.CreateStudent(int.Parse(txtStudentID.Text), txtName.Text, txtPhone.Text, txtDOB.Text, txtPhone.Text, txtGender.Text, txtAddress.Text, txtModuleCode.Text);
            MessageBox.Show("Student Insert success");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= dh.ReadStudent();
        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource=  dh.SearchModule(txtModuleCode2.Text.ToUpper());
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            dh.UpdateModule(txtModuleCode2.Text, txtModuleName.Text, txtModuleDescription.Text, txtModuleLink.Text);
            MessageBox.Show("Module Update success");
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            dh.DeleteModule(txtModuleCode2.Text.ToUpper());
            MessageBox.Show("Module Delete success");
        }

        private void btnInsertModule_Click(object sender, EventArgs e)
        {
            dh.CreateModule(txtModuleCode2.Text, txtModuleName.Text, txtModuleDescription.Text, txtModuleLink.Text);
            MessageBox.Show("Module Update success");
        }

        private void btnDisplayModule_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= dh.ReadModule();
        }
    }
}

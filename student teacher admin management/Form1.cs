using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeelist
{


  
    public partial class student : Form
    {
        List<Class1> studentinfo = new List<Class1>();
        List<Teacher> teacher = new List<Teacher>();
        List<Admin> admin = new List<Admin>();
        public student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_salary_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_s1_Click(object sender, EventArgs e)
        {
            int  studentid = Convert.ToInt32(textBox_sID.Text);
            string studentname = textBox_sname.Text;
            int studentsemester = Convert.ToInt32(textBox_semester.Text);
            string studentdept = textBox_sdept.Text;

            Class1 dummy_std = new Class1();
            dummy_std.studentid = studentid;
            dummy_std.studentname = studentname;
            dummy_std.studentsemester = studentsemester;
            dummy_std.studentdept = studentdept;

            studentinfo.Add(dummy_std);
            MessageBox.Show("Info has been added successfully");

        }

        private void button_c1_Click(object sender, EventArgs e)
        {
            textBox_sID.Text = String.Empty;
            textBox_sname.Text = String.Empty;
            textBox_sdept.Text = String.Empty;
            textBox_semester.Text = String.Empty;

              MessageBox.Show("Info has been removed successfully");
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button_save2_Click(object sender, EventArgs e)
        {
            int tid = Convert.ToInt32(textBox_tid.Text);
            string tname = textBox_tname.Text;
            int salary = Convert.ToInt32( textBox_tsalary.Text);
            string tdesignation = textBox_desig.Text;
            string tdept = textBox_tdept.Text;

            Teacher dummy_teacher = new Teacher();
            dummy_teacher.tid = tid;
            dummy_teacher.tname = tname;
            dummy_teacher.salary = salary;
            dummy_teacher.tdept = tdept;
            dummy_teacher.tdesignation = tdesignation;


            teacher.Add(dummy_teacher);

            MessageBox.Show("Info has been added successfully");
        }

        private void button_c2_Click(object sender, EventArgs e)
        {
            textBox_tid.Text = String.Empty;
            textBox_tname.Text = String.Empty;
            textBox_tdept.Text = String.Empty;
            textBox_tsalary.Text = String.Empty;
            textBox_desig.Text = String.Empty;

            MessageBox.Show("Info has been removed successfully");
        }

        private void button_save3_Click(object sender, EventArgs e)
        {
            int aid = Convert.ToInt32(textBox_aid.Text);
            string aname = textBox_aname.Text;
            int asalary = Convert.ToInt32(textBox_asalary.Text);
            string adesignation = textBox_adesig.Text;
          

            Admin dummy_admin = new Admin();
            dummy_admin.aid = aid;
            dummy_admin.aname = aname;
            dummy_admin.asalary = asalary;
            dummy_admin.adesignation = adesignation;


            admin.Add(dummy_admin);

            MessageBox.Show("Info has been added successfully");
        }

        private void button_c3_Click(object sender, EventArgs e)
        {

            textBox_aid.Text = String.Empty;
            textBox_aname.Text = String.Empty;
            textBox_asalary.Text = String.Empty;
            textBox_adesig.Text = String.Empty;

            MessageBox.Show("Info has been removed successfully");

        }

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_showinfo1_Click(object sender, EventArgs e)
        { 
            foreach ( Class1 student in studentinfo)
            {
                StudentList.Items.Add(student.get_studentInfo());
            }
            
        }

        private void button_si3_Click(object sender, EventArgs e)
        {
            foreach (Admin ad_min in admin)
            {
                AdminPeopleList.Items.Add(ad_min.get_adminInfo());
            }
        }

        private void button_si2_Click(object sender, EventArgs e)
        {
            foreach (Teacher teacher in teacher)
            {
               TeacherList.Items.Add(teacher.get_teacherInfo());
            }
        }
    }
}

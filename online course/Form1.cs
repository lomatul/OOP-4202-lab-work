using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_course
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<course> courses = new List<course>();
        List<participent> participents = new List<participent>();
        List<Info> INFO = new List<Info>();
        private void button_add_Click(object sender, EventArgs e)
        {
            comboBox_student.Items.Add(textBox_reg.Text); 
            comboBox_Info.Items.Add(textBox_reg.Text); 

            string reg_no = textBox_reg.Text;
            string name = textBox_name.Text;
            int contact = Convert.ToInt32(textBox_contact.Text);
            string email = textBox_email.Text;
            string level, type;

           
            if (radioButton_student.Checked) type =null;
            {

                if (radioButton_professional.Checked) type = null;

                {
                    MessageBox.Show("PLEASE ADD TYPE");
                }

            }

             if (radioButton_student.Checked)
            {
                type = "Student";
            }
            else
                type = "Professional";


            // extra work - if radio button null --- 

            if (radioButton_course_ADvanced.Checked) level = "Advanced";
            else if (radioButton_intermediate.Checked) level = "Intermediate";
            else level = "Beginner";

            participent dummy_participent = new participent();
            
            dummy_participent.name = name;
            dummy_participent.reg_no = reg_no;
            dummy_participent.contact = contact;
            dummy_participent.email = email;
            dummy_participent.type = type;
            dummy_participent.level = level;

            participents.Add(dummy_participent);

            MessageBox.Show("THE INFORMATION ADDED");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton_student
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button_pay_Click(object sender, EventArgs e)
        {
            bool f = false;

            for(int i = 0; i < participents.Count; i++)
            {
                string s = participents[i].reg_no;
                if(s == comboBox_student.Text) 
                {
                    for (int j = 0; j < courses.Count; j++)
                    {
                        if (courses[j].Title == comboBox_course.Text)
                        {
                            if(participents[i].level == courses[j].Level)
                            {
                                double fee = courses[j].fee;
                                if (participents[i].type == "Professional")
                                    fee = courses[j].fee + (courses[j].fee / 10);

                                participents[i].fee += fee;
                                lol.Text = "  " + Convert.ToString(fee);

                                Info dummy = new Info();
                                dummy.Name = participents[i].name;
                                dummy.Reg_No = participents[i].reg_no;
                                dummy.fee = participents[i].fee;
                                dummy.Course = comboBox_course.Text;
                                dummy.Type = participents[i].type;

                                bool ff = false;
                                foreach(Info x in INFO)
                                {
                                    if(x.Reg_No == participents[i].reg_no)
                                    {
                                        x.fee += fee;
                                        ff = true;
                                        break;
                                    }
                                }

                                if(ff == false)
                                {
                                    INFO.Add(dummy);
                                }
                                
                                f = true;
                                break;
                            }
                            break;
                        }
                    }
                    break;
                }
            }

            if(f == false)
            {
                MessageBox.Show("NOT APPLICABLE");
            }
            else
            {
                MessageBox.Show("ADDED");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fee = Convert.ToDouble(textBox_fee.Text);
            string Title = textBox_title.Text;
            string level;
            if (radioButton_course_Intermediate.Checked) level = "Intermediate";
            else if (radioButton_course_ADvanced.Checked) level = "ADvanced";
            else level = "Beginner";

            comboBox_course.Items.Add(textBox_title.Text);

            course dummy_courses = new course();

            dummy_courses.fee = fee;
            dummy_courses.Title = Title;
            dummy_courses.Level = level;

            courses.Add(dummy_courses);//list

            MessageBox.Show("THE INFORMATION ADDED");

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox_show.Items.Clear();

            // main
            foreach (Info i in INFO)
            {
                if(i.Reg_No  == comboBox_Info.Text)
                {
                    listBox_show.Items.Add(i.Name + "   " + i.Reg_No + "    " + i.Type + "    " + i.Course + "    "
                        + i.fee);
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_professional_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton_professional
        }

        private void lol_Click(object sender, EventArgs e)
        {
        }

        private void label_fee_Click(object sender, EventArgs e)
        {

        }
    }
}

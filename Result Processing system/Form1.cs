using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace labfinal
{
    public partial class Form1 : Form
    {
        List<student> students = new List<student>();
        void Load_Lisbox()
        {
            foreach (student s in students)
            {
                listBox.Items.Add(s.student_ID + "\t" + s.NAME + "\t" + s.calculate_percent() + "%\t"  + s.calculate_grade());

            }

        }
        public Form1()
        {
            InitializeComponent();
            
        }

        public int total;
        public string grade;
        public double quiz_sum;
        public int viva;
        public double percent;

        
        private void Form1_Load(object sender, EventArgs e)
        {
               
            

            using (var reader = new StreamReader(@"C:\Users\HP\Downloads\SWE4201.csv"))
            {
                listBox.Items.Add("ID \t\t Name \t\t percentage");




                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');





                    student dummy_student = new student();

                    dummy_student.student_ID = values[0];
                    dummy_student.NAME = values[1];
                    if (values[2] != " ")
                    { dummy_student.attendance = values[2]; }
                    if (values[3] != " ")
                    { dummy_student.quiz1 = values[3]; }
                    if (values[4] != " ")
                    { dummy_student.quiz2 = values[4]; }
                    if (values[5] != "")
                    { dummy_student.quiz3 = values[5]; }
                    if (values[6] != "")
                    { dummy_student.quiz4 = values[6]; }
                    if (values[7] != "")
                    { dummy_student.mid = values[7]; }
                    if (values[8] != "")
                    { dummy_student.final = values[8]; }
                    if (values[9]!=" ")
                    dummy_student.viva = values[9];

                  

                    students.Add(dummy_student);

                    int viva = Convert.ToInt32(values[9]);
                    
                   
                 
                     





                }

                Load_Lisbox();

            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string student_id = textBox_id.Text;
            bool flag = false;


           
                           var std = from stud in students
                          where stud.student_ID == student_id
                          select stud;

            foreach (var stud in std)

            {


                label_attendance.Text = stud.attendance;
                label_final.Text = stud.final;
                label_mid.Text = stud.mid;
                label_quiz3.Text = stud.quiz3;
                label_quiz4.Text = stud.quiz4;
                quiz1.Text = stud.quiz1;
                quiz2.Text = stud.quiz2;
                label_quiz_total.Text = Convert.ToString( stud.quiz_sum);

                label_viva.Text = Convert.ToString(stud.viva);
                 lael_total.Text= Convert.ToString(stud.total);
                  label_percentage.Text = Convert.ToString(stud.percent) + "%";
                label_grade.Text = stud.grade ;


                

            }

                }



            




        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

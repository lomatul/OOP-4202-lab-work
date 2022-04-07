using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradesApp
{
    public partial class GradeApp : System.Windows.Forms.Form
    {
        public GradeApp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

      

     
     
      
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (text_name.Text!="" &&
                text_StudentId.Text!="" &&
                Semester.Text!="" &&
                text_attendedclases.Text!="" &&
                text_mid.Text!="" &&
                text_final.Text!="" &&
                text_quiz1.Text!="" &&
                text_quiz2.Text!="" &&
                text_quiz3.Text!="" &&
                text_quiz4.Text!="")

            {
                double attend = Convert.ToDouble(text_attendedclases.Text);
                attend = Math.Round((attend / 28) * 30, MidpointRounding.AwayFromZero);
                label_attend.Text = Convert.ToString(attend) + "/30";


                label_mid.Text = text_mid.Text + "/75";

                label_final.Text = text_final.Text + "/150";

                double quiz1num = Convert.ToDouble(text_quiz1.Text);
                double quiz3num = Convert.ToDouble(text_quiz3.Text);
                double quiz2num = Convert.ToDouble(text_quiz2.Text);
                double quiz4num = Convert.ToDouble(text_quiz4.Text);
                double[] quiz_ar = new double[4]
                { quiz1num, quiz2num, quiz3num, quiz4num };
                Array.Sort(quiz_ar);
                double quiz_sum = quiz_ar[1] + quiz_ar[2] + quiz_ar[3];
                label_quiz.Text = Convert.ToString(quiz_sum) + "/45";

                double totalsum = attend + Convert.ToDouble(text_mid.Text) + quiz_sum + Convert.ToDouble(text_final.Text);
                total.Text = Convert.ToString(totalsum) + "/300";

                String grade = null;
                double percent = (totalsum / 300) * 100;
                if (percent >= 80) grade = "A+";
                else if (percent < 80 && percent >= 70) grade = "A";
                else if (percent < 70 && percent >= 60) grade = "A-";
                else if (percent < 60 && percent >= 50) grade = "B";
                else if (percent < 50 && percent >= 40) grade = "C";
                else if (percent < 40 && percent >= 30) grade = "D";
                else grade = " F ";

                gradenum.Text = grade;

                percent = Math.Round(percent, MidpointRounding.AwayFromZero);
                result.Text = text_name.Text + " obtained " + Convert.ToString(percent) + "% marks.";
            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        private void GradeApp_Load(object sender, EventArgs e)
        {

        }
    }
}

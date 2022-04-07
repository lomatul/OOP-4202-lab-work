using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labfinal
{
    internal class student
    {

        public string student_ID;
        public string NAME;

        public string attendance = "0";
        public string quiz1 = "0";
        public string quiz2 = "0";
        public string quiz3 = "0";
        public string quiz4 = "0";
        public string mid = "0";
        public string final = "0";
        public string viva = "0";
        public double percent;
        public double quiz_sum;
        public string grade;
        public double total;



        public Double calculate_percent()
        {
            double quiz11 = Convert.ToDouble(quiz1);
            double quiz22 = Convert.ToDouble(quiz2);
            double quiz33 = Convert.ToDouble(quiz3);
            double quiz44 = Convert.ToDouble(quiz4);



            double[] quiz_ar = new double[4]
       { quiz11, quiz22, quiz33, quiz44};
            Array.Sort(quiz_ar);
            quiz_sum = Math.Round(quiz_ar[1] + quiz_ar[2] + quiz_ar[3]);

            total = Convert.ToInt32(quiz_sum) + Convert.ToInt32(mid) + Convert.ToInt32(final) + Convert.ToInt32(viva)+Convert.ToInt32(attendance);

            percent = Math.Round(total*100 / 300);

            return percent;
        }

        public string calculate_grade()
        {
            if (percent >= 80) grade = "A+";
            else if (percent < 80 && percent >= 75) grade = "A";
            else if (percent < 75 && percent >= 70) grade = "A-";
            else if (percent < 60 && percent >= 65) grade = "B+";
            else if (percent < 65 && percent >= 60) grade = "B";
            else if (percent < 60 && percent >= 55) grade = "B-";
            else if (percent < 55 && percent >= 50) grade = "C+";
            else if (percent < 50 && percent >= 45) grade = "C";
            else if (percent < 45 && percent >= 40) grade = "D";

            else grade = " F ";
            return grade;
        }
    }
}

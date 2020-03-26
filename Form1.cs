using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class student
        {
            public double score;
            public string name;
            private string grade;

            private string Name
            {
                get { return name; }
                set { name = value; }
            }

            private double Score
            {
                get { return score; }
                set { score = value; }
            }

           public string Calculate()
           {
                if ((Score >= 0 && Score <= 60))
                {
                    grade = "F";
                    return grade;
                }
                else if ((Score >= 61 && Score <= 70))
                {
                    grade = "D";
                    return grade;
                }
                else if ((Score >= 71 && Score <= 80))
                {
                    grade = "C";
                    return grade;
                }
                else if ((Score >= 81 && Score <= 90))
                {
                    grade = "B";
                    return grade;
                }
                else if ((Score >= 91 && Score <= 100))
                {
                    grade = "A";
                    return grade;
                }
                else
                {
                    grade = "Points must not exceed 100 points or negative points.";
                    return grade;
                }
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            student value = new student();
            value.name = "Teerapon";
            value.score = 100;
           
            Console.WriteLine("Name student: {0}", value.name);
            Console.WriteLine("Student score: {0}", value.score);
            Console.WriteLine("Student score: {0}", value.Calculate());
        }
    }
}

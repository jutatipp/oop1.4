using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalcuator
{
    public class Student
    {
        private string studentName;
        private double gpa;
        public Student(string name,double gpa)
        {
            this.studentName = name;
            this.gpa = gpa;
        }
        public double getGpa() 
        { 
            return gpa; 
        }
    }
}

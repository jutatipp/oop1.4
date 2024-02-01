using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace GPACalcuator
{
    public class GPACalcuator
    {
        private List<Student> _student = new List<Student>();
        private int Ga, Gbplus, gb, Gcplus, Gc, Gdplus, Gd, Gf;
        private double GPAs;
        public bool SetStudent(Student student)
        {
            this._student.Add(student);
            return true;
        }
        public double getGPAx()
        {
            double sum = 0;
            foreach (Student student in _student)
            {
                sum += student.getGpa();
            }
            return sum / this._student.Count;
        }
         public double getihghSc()
        {
            double highSc = 0;

            foreach (Student student in _student)
            {
                if (student.Gpa > highSc)
                {
                    highSc = student.Gpa;
                }
            }
            return highSc;
        }
        public double getlowSc()
        {
            double lowSc = getihghSc();

            foreach (Student student in _student)
            {
                if (student.Gpa < lowSc)
                {
                    lowSc = student.Gpa;
                }
            }
            return lowSc;
        }
        public string higna()
        {
            string highNm = string.Empty;
            double highSc = 0;
            foreach (Student student in _student)
            {
                if (student.Gpa > highSc)
                {
                    highSc = student.Gpa;
                    highNm = student.studentName;
                }
            }
            return highNm;
        }
        public string lowna()
        {
            string lowNm = higna();
            double lowSc = getihghSc();
            foreach (Student student in _student)
            {
                if (student.Gpa < lowSc)
                {
                    lowSc = student.Gpa;
                    lowNm = student.studentName;
                }
            }

            return lowNm;
        }

        public double getGPAx()
        {
            if (Score >= 80 && Score <= 100)
            {
                Score = 4.0;
                Ga++;
            }
            else if (Score >= 75 && Score < 79)
            {
                Score = 3.5;
                Gbplus++;
            }
            else if (Score >= 70 && Score < 74)
            {
                Score = 3.0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TepeGuvenlik
{
    public class Student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public int studentNumber { get; set; }
        public int classGrade { get; set; }
      
        public Student(int _id, string _name, string _surname, int _studentNumber, int _classGrade)
        {
            this.studentId = _id;
            this.studentName = _name;
            this.studentSurname = _surname;
            this.studentNumber = _studentNumber;
            this.classGrade = _classGrade;       
        }
      
    }
}
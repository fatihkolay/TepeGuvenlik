using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TepeGuvenlik
{
    public class StudentInformationAndLectureViewModel
    {
        public Student student { get; set; }
        public StudentLectureName lectureName { get; set; }
        public int lectureNote { get; set; }

        private static readonly Student Onur = new Student(1, "Onur", "Taşdemir", 160022, 12);
        private static readonly Student Fatih = new Student(2, "Fatih", "Kolay", 160010, 12);
        private static readonly Student Ozcan = new Student(3, "Özcan", "Sarı", 160015, 12);
        private static readonly StudentLectureName Math = new StudentLectureName(1, "Math");
        private static readonly StudentLectureName Chemistry = new StudentLectureName(2, " Chemistry");
        private static readonly StudentLectureName History = new StudentLectureName(3, " History");
        public static StudentInformationAndLectureViewModel[] MockData { get; } =
       {
            new StudentInformationAndLectureViewModel
            {
                lectureName = Math,
                student = Onur,
                lectureNote=75
            },
              new StudentInformationAndLectureViewModel
            {
                lectureName = Math,
                student = Fatih,
                lectureNote=30
            },
            new StudentInformationAndLectureViewModel
            {
                lectureName = Chemistry ,
                student = Fatih,
                lectureNote=100
            },
            new StudentInformationAndLectureViewModel
            {
                lectureName = History ,
                student = Ozcan,
                lectureNote=55
            }

       };

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TepeGuvenlik
{
    public class StudentLectureName
    {
        public int lectureId { get; set; }
        public string lectureName { get; set; }


        public StudentLectureName(int _lectureId, string _lectureName)
        {
            this.lectureId = _lectureId;
            this.lectureName = _lectureName;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace TepeGuvenlik
{
    /// <summary>
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]

    public class StudentService : System.Web.Services.WebService
    {
        StudentInformationAndLectureViewModel[] studentWithLecture = StudentInformationAndLectureViewModel.MockData;
        string _username = "tepe";
        string _password = "guvenlik";
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]

        public void getAllStudents(string username, string password)
        {

            if (_username == username && _password == password)
            {
                var students = (from student in studentWithLecture
                                select student.student).Distinct();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                HttpContext.Current.Response.Write(ser.Serialize(students));
            }

        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public void getStudentById(string username, string password, int studentId)
        {
            if (_username == username && _password == password)
            {
                var student =
                   (from data in studentWithLecture select data.student).Where(x => x.studentId == studentId).FirstOrDefault();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                HttpContext.Current.Response.Write(ser.Serialize(student));
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public void getLectureByStudentId(string username, string password, int studentId)
        {
            if (_username == username && _password == password)
            {
                var lecture =
               studentWithLecture.Where(x => x.student.studentId == studentId).Select(x => new { x.lectureName, x.lectureNote }).ToList();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                HttpContext.Current.Response.Write(ser.Serialize(lecture));
            }
        }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace SEPApplication3.Connect
{
    public class LoginData
    {
        public string Id { get; set; }
        public string Secret { get; set; }
    }
    public class LoginResult
    {
        public int Code { get; set; }
        public LoginData Data { get; set; }
        public string Message { get; set; }
    }
    public class CourseData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
    }
    public class GetCourseResult
    {
        public int Code { get; set; }
        public CourseData[] Data { get; set; }
        public string Message { get; set; }
    }
    public class StudentData
    {
        public string Id { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
    public class GetStudentResult
    {
        public int Code { get; set; }
        public StudentData[] Data { get; set; }
        public string Message { get; set; }
    }
    public class MemberData
    {
        public string Id { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
    public class GetMemberResult
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public MemberData[] Data { get; set; }
    }
    public class Connect_API
    {
        private string url = "http://125.234.238.137:8080/CMU/SEPAPI/SEP21"; // At Home
        //private string url = "http://cntttest.vanlanguni.edu.vn:8080/CMU/SEPAPI/SEP21"; // At School
        public LoginResult Login(string username, string password)
        {
            using (var client = new WebClient())
            {
                var form = new NameValueCollection();
                form["Username"] = username;
                form["Password"] = password;
                var result = client.UploadValues(url + "/Login", "POST", form);
                var json = Encoding.UTF8.GetString(result);
                return JsonConvert.DeserializeObject<LoginResult>(json);
            }    
        }

        public GetCourseResult GetCourse(string lecturerId)
        {
            using (var client = new WebClient())
            {
                var json = client.DownloadString(url + "/GetCourses?lecturerID=" + lecturerId);
                return JsonConvert.DeserializeObject<GetCourseResult>(json);
            }
        }

        public GetStudentResult GetStudent(string code)
        {
            using (var client = new WebClient())
            {
                var json = client.DownloadString(url + "/GetStudent?code=" + code);
                return JsonConvert.DeserializeObject<GetStudentResult>(json);
            }
        }

        //public GetStudentResult GetStudent(string code)
        //{
        //    using (var client = new WebClient())
        //    {
        //        var json = client.DownloadString(url + "/GetStudent?code=" + code);
        //        return JsonConvert.DeserializeObject<GetStudentResult>(json);
        //    }
        //}

        //public GetMemberResult GetMembers(string courseID)
        //{
        //    using (var client = new WebClient())
        //    {
        //        var json = client.DownloadString(url + "/GetMembers?courseID=" + courseID);
        //        return JsonConvert.DeserializeObject<GetMemberResult>(json);
        //    }
        //}
    }
}
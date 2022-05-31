using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel objStudentAttendanceDetailsModel1 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel objStudentAttendanceDetailsModel2 = new StudentAttendanceDetailsModel();
            objStudentAttendanceDetailsModel1.StudentID = 1;
            objStudentAttendanceDetailsModel1.StudentName = "Adam";
            objStudentAttendanceDetailsModel1.AttendencePercentage = 83.02;

            objStudentAttendanceDetailsModel2.StudentID = 2;
            objStudentAttendanceDetailsModel2.StudentName = "Brad";
            objStudentAttendanceDetailsModel2.AttendencePercentage = 71.02;
            List<StudentAttendanceDetailsModel> listObj = new List<StudentAttendanceDetailsModel>
            {
                objStudentAttendanceDetailsModel1,
                objStudentAttendanceDetailsModel2
            };
            return listObj;
        }
    }
}

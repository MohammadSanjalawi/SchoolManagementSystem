using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        {
            StudentAdmissionDetailsModel objStudentAdmissionDetailsModel1 = new StudentAdmissionDetailsModel();
            StudentAdmissionDetailsModel objStudentAdmissionDetailsModel2 = new StudentAdmissionDetailsModel();
            objStudentAdmissionDetailsModel1.StudentID = 1;
            objStudentAdmissionDetailsModel1.StudentName = "Adam";
            objStudentAdmissionDetailsModel1.StudentClass = "X";
            objStudentAdmissionDetailsModel1.DateofJoining = DateTime.Now;

            objStudentAdmissionDetailsModel2.StudentID = 2;
            objStudentAdmissionDetailsModel2.StudentName = "Brad";
            objStudentAdmissionDetailsModel2.StudentClass = "IX";
            objStudentAdmissionDetailsModel2.DateofJoining = DateTime.Now;
            List<StudentAdmissionDetailsModel> listofobj = new List<StudentAdmissionDetailsModel>
            {
                objStudentAdmissionDetailsModel1,
                objStudentAdmissionDetailsModel2
            };
            return listofobj;
        }
    }
}

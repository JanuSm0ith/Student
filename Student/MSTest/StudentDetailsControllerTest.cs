using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Student.Controllers;
using Student.Models.Domain;
using Student.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    [TestClass]
    public class StudentDetailsControllerTest
    {
        private Mock<IStudentDetailRepository> _studentDetailRepositoryMock;
        private Fixture _fixture;
        private StudentDetailsController _controller;

        public StudentDetailsControllerTest()
        {
            _fixture = new Fixture();
            _studentDetailRepositoryMock = new Mock<IStudentDetailRepository>();
        }
        [TestMethod]
        public async Task GetAllStudentDetailsAsync_Student_ReturnOk()
        {
            //var student = _fixture.CreateMany<StudentDetail>(3).ToList();
            //_studentDetailRepositoryMock.Setup(repo => repo.GetAllAsync)).Returns(student);
            //_controller = new StudentDetailsController(_studentDetailRepositoryMock.Object);

            //var studentsDTO = await _controller.GetAllStudentDetailsAsync();
            //var obj = studentsDTO as ObjectResult;
            //Assert.AreEqual(obj, student);

        }

    }
}

using AutoMapper;
using FakeItEasy;
using Student.Profiles;
using Student.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest.ControllerTest
{
    public class StudentDetailsControllerTest
    {
        private IStudentDetailRepository studentDetailRepository;
        //private  IMapper mapper;

        public StudentDetailsControllerTest()
        {
            //Dependencies

            studentDetailRepository = A.Fake<IStudentDetailRepository>();
            //mapper = A.Fake<IMapper>();
            //if (mapper == null)
            //{
            //    var mappingConfig = new MapperConfiguration(mc =>
            //    {
            //        mc.AddProfile(new StudentDetailsProfile());
            //    });
            //    IMapper mapper = mappingConfig.CreateMapper();
            //    mapper = mapper;
            //}
            [Fact]
            public void StudentDetailsController_DeleteStudentDetailAsync_ReturnSuccess()
            {
                //Arrange- what r required



                //Act

                //Assert
            }
        }
    }
}


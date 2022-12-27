using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Student.Models.Domain;
using Student.Repositories;

namespace Student.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentDetailsController : Controller
    {
        private IStudentDetailRepository studentDetailRepository;
        private IMapper mapper;

        public IMapper Mapper { get; }

        public StudentDetailsController(IStudentDetailRepository studentDetailRepository, IMapper mapper)
        {
            this.studentDetailRepository  =  studentDetailRepository;
            this.mapper = mapper;

        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllStudentDetails()
        {
           var students = await studentDetailRepository.GetAllAsync();

            //return DTO students
            //var studentsDTO = new List<Models.DTO.StudentDetail>();
            //students.ToList().ForEach(student =>
            //{
            //    var studentDTO = new Models.DTO.StudentDetail()
            //    {
            //        Id = student.Id,
            //        Name = student.Name,
            //        City = student.City,

            //    };

            //    studentsDTO.Add(studentDTO);

            //});

            var studentsDTO = mapper.Map<List<Models.DTO.StudentDetail>>(students);



            
            return Ok(studentsDTO);

        }

        
    }
}

﻿using AutoMapper;
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
        public async Task<IActionResult> GetAllStudentDetailsAsync()
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


        [HttpGet]
        [Route("{id:guid}")]
        [ActionName("GetStudentDetailAsync")]
        public async Task<IActionResult> GetStudentDetailAsync(Guid id)
        {
          var student =  await studentDetailRepository.GetAsync(id);

            if(student == null)
            {
                return NotFound();
            }
            var studentDTO = mapper.Map<Models.DTO.StudentDetail>(student);

            return Ok(studentDTO);



        }



        [HttpPost]
        public async Task<IActionResult> AddStudentDetailAsync(Models.DTO.AddStudentDetailRequest addStudentDetailRequest)
        {
            // Request(dto) to domain model
            var student = new Models.Domain.StudentDetail()
            {
                Name = addStudentDetailRequest.Name,
                 City = addStudentDetailRequest.City
            };

            //pass details to rep
           student =  await studentDetailRepository.AddAsync(student);

            //convert back to dto
            var studentDTO = new Models.DTO.StudentDetail
            {
                Id = student.Id,
                Name = student.Name,
                City = student.City

            };

            //201 success

            return CreatedAtAction(nameof(GetStudentDetailAsync), new {id = studentDTO.Id} , studentDTO);


        }

        [HttpDelete]
        [Route("{id:guid}")]

        public async Task<IActionResult> DeleteStudentDetailAsync(Guid id)
        {
            //get region from db
          var student =  await studentDetailRepository.DeleteAsync(id);

            //if null not found
            if(student ==null)
            {
                return NotFound();
            }

            //convert response back to dto
            var studentDTO = new Models.DTO.StudentDetail
            {
                Id = student.Id,
                Name = student.Name,
                City = student.City

            };

            //return ok response
            return Ok(studentDTO);
        }

        [HttpPut]
        [Route("{id:guid}")]

        public async Task<IActionResult> UpdateStudentDetailAsync([FromRoute]Guid id, [FromBody]Models.DTO.UpdateStudentDetailRequest updateStudentDetailRequest)
        {
            //convert dto to domain model
            var student = new Models.Domain.StudentDetail
            {
                Name = updateStudentDetailRequest.Name,
                City = updateStudentDetailRequest.City


            };


            //update region using repo
            student = await studentDetailRepository.UpdateAsync(id, student);



            //if null then not found
            if(student == null)
            {
                return NotFound();
            }

            //convert domain back to dto
            var studentDTO = new Models.DTO.StudentDetail
            {
                Id = student.Id,
                Name = student.Name,
                City = student.City

            };


            //return ok reponse
            return Ok(studentDTO);

        }

        


        
    }
}
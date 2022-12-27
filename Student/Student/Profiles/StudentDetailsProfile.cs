using AutoMapper;

namespace Student.Profiles
{
    public class StudentDetailsProfile : Profile
    {
        public StudentDetailsProfile()
        {
            //converting Domain  to Dto
            CreateMap<Models.Domain.StudentDetail, Models.DTO.StudentDetail>()
                .ReverseMap();


           }

    }
}

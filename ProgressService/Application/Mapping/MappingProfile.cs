using Application.Dtos.SubmisstionDtos;
using AutoMapper;
using Domain.Entities;
using Domain.ValueEntities;

namespace Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SubmissionAddDto, Submission>().ReverseMap();

            CreateMap<Submission, SubmissionIndexDto>().ReverseMap();

            CreateMap<EvaluationCriteriaDto, EvaluationCriteria>().ReverseMap();

            CreateMap<Submission, SubmisstionDetailDto>().ReverseMap();
        }
    }
}

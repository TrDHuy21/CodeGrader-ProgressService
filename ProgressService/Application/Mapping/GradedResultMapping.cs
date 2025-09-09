using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.RequestDtos;
using Application.Dtos.SubmisstionDtos;
using AutoMapper;

namespace Application.Mapping
{
    public class GradedResultMapping : Profile
    {
        protected GradedResultMapping()
        {
            CreateMap<GradedResult, SubmissionAddDto>();
              
        }
    }
}

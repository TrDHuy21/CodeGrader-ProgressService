using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.RequestDtos;
using Application.Dtos.SubmisstionDtos;
using Application.Services.Implementation;
using Application.Services.Interface;
using Application.Usecases.Interface;
using AutoMapper;
using Common.ResultPattern;
using Infrastructure.Repositories.Interface;

namespace Application.Usecases.Implementation
{
    public class ProgressUsecase : IProgressUsecase
    {
        //protected readonly IUerProgressService _userProgressServce;
        //protected readonly IProblemStatsService _problemStatsService;
        protected readonly ISubmissionService _submissionService;
        protected readonly IMapper _mapper;

        public ProgressUsecase(ISubmissionService submissionService, IMapper mapper)
        {
            _submissionService = submissionService;
            _mapper = mapper;
        }

        public async Task<Result> UpdateProgress(GradedResult gradedResult)
        {
            try
            {
                var submissionAddDto = _mapper.Map<SubmissionAddDto>(gradedResult);
                var updateSubmissionResul = await _submissionService.AddSubmission(submissionAddDto);
                return updateSubmissionResul;
            }
            catch (Exception ex)
            {
                return Result.Failure(ex.Message);
            }
        }
    }
}

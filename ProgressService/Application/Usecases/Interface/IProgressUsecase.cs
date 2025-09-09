using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.RequestDtos;
using Common.ResultPattern;

namespace Application.Usecases.Interface
{
    public interface IProgressUsecase
    {
        Task<Result> UpdateProgress(GradedResult gradedResult);
    }
}

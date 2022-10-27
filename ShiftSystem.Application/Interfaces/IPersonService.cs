using Azure.AI.FormRecognizer.DocumentAnalysis;
using ShiftSystem.Application.Generic.Interfaces;
using ShiftSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Interfaces
{
    public interface IPersonService 
    {
        Task<Domain.Entities.Person> Create(Domain.Entities.Person person);
        Task<List<Domain.Entities.Person>> Get(int top = 50);
        Task<Domain.Entities.Person> GetyById(int id);
        Task<Domain.Entities.Person> GetPersonFromAnalyzeResult(AnalyzeResult analyzeResult);

    }
}

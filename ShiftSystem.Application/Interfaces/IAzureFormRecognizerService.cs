using Azure.AI.FormRecognizer.DocumentAnalysis;
using ShiftSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Interfaces
{
    public interface IAzureFormRecognizerService
    {
        Task<AnalyzeResult> GetAnalyzeResultValue(AzureConfig azureConfig, Uri fileUri);
    }
}

using Azure;
using Azure.AI.FormRecognizer.DocumentAnalysis;
using ShiftSystem.Application.Interfaces;
using ShiftSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Infrastructure.Services
{
    public class AzureFormRecognizerService : IAzureFormRecognizerService
    {
        public async Task<AnalyzeResult> GetAnalyzeResultValue(AzureConfig azureConfig, Uri fileUri)
        {
            var client = new DocumentAnalysisClient(new Uri(azureConfig.endpoint), new AzureKeyCredential(azureConfig.key));

            var operation = await client.AnalyzeDocumentFromUriAsync(WaitUntil.Completed, azureConfig.modelId, fileUri);

            return operation.Value;
        }
    }
}

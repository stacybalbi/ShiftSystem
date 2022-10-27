using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Domain.Entities
{
    public class AzureConfig
    {
        public string key { get; set; }
        public string endpoint { get; set; }
        public string modelId { get; set; }
    }
}

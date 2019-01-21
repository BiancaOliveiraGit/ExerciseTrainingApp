using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAppAspCore.Dto
{
    public class ErrorDetailsDto
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}

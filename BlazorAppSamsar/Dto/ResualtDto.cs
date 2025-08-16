using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BlazorAppSamsar.Dto
{
    public class ResualtDto
    {
        public class ResultDto
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
        }
        public class ResultUploadDto : ResultDto
        {

            public string? Filename { get; set; } = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC_Service.Domain.Models
{
    public class BaseResult
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}

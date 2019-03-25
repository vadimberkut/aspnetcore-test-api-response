using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiResponse.Api.Models
{
    public class BaseResponseModel<T>
    {
        public T Data { get; set; }
        public bool Ok { get; set; }
        public string Message { get; set; }
    }
}

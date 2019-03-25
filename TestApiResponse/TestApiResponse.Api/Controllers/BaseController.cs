using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestApiResponse.Api.Models;

namespace TestApiResponse.Api.Controllers
{
    public class BaseController : Controller
    {
        protected IActionResult BaseResponse<T>(HttpStatusCode status, T data, string message = "")
        {
            var responseModel = new BaseResponseModel<T>()
            {
                Ok = status == HttpStatusCode.OK,
                Data = data,
                Message = message,
            };

            return new JsonResult(responseModel)
            {
                ContentType = "application/json",
                SerializerSettings = new JsonSerializerSettings() {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                },
                StatusCode = (int)status,
            };
        }
    }
}

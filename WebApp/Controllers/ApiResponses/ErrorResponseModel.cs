using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Controllers.ApiResponses
{
    public class ErrorResponseModel
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoachAndLaw.Service
{
    public class ResponseHelper
    {
        public object MakeErroResponse(int statusCode, bool success, string erroMessage)
        {
            var obj = new
            {
                statusCode = statusCode,
                success = success,
                errorMessage = erroMessage
            };

            return obj;
        }
        public object  MakeSuccessResponse(int statusCode, bool success)
        {
            var obj = new
            {
                statusCode = statusCode,
                success = success
            };

            return obj;
        }
    }
}

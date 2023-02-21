using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statuseCode, string message = null)
        {
            StatuseCode = statuseCode;
            Message = message ?? GetDefaultMessageForStatusCode(statuseCode);
        }

        public int StatuseCode { get; set; }
        public string  Message { get; set; }

        private static string GetDefaultMessageForStatusCode(int status)
        {
            return status switch
            {
                400 => "Bad Request",
                401 => "Unauthorized action",
                403 => "Forbidden action",
                404 => "Resource not found",
                500 => "Something went wrong, please try again",
                _ => null
            };
        }
    }
}

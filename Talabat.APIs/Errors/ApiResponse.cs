﻿
namespace Talabat.APIs.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public ApiResponse(int statusCode, string? message = null)
        {
            StatusCode = statusCode;
            Message = message ?? DefaultStatusCodeMessage(statusCode);
        }

        private string? DefaultStatusCodeMessage(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad Request",
                401 => "UnAutherized",
                404 => "Not Found",
                500 => "Server Error",
                _ => null
            };
        }
    }
}

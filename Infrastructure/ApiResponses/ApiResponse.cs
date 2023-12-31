﻿using System.Text.Json.Serialization;

namespace Infrastructure.ApiResponses
{
    public class ApiResponse<T>
    {
        public T? Data { get; set; }
        [JsonIgnore]public int StatusCode { get; set; }
        public List<string>? ErrorMessages { get; set; }

        public static ApiResponse<T> Success(int statusCode, T data)
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode,
                Data = data
            };
        }
        //Update ve Delete işlemlerinde veriyi NoData dönüyoruz o nedenle sadece başarılı kodu veren bir method isteriz. T zaten NoData 
        //alacak. NoData nında içi boş zaten buna hizmet etsin diye yazdık.
        public static ApiResponse<T> Success(int statusCode)
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode
            };
        }

        public static ApiResponse<T> Fail(int statusCode, string message, List<string> errorMessages)
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode,
                ErrorMessages = errorMessages
            };
        }
        public static ApiResponse<T> Fail(int statusCode, string errorMessage)
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode,
                ErrorMessages = new List<string> { errorMessage }
            };
        }


    }
}

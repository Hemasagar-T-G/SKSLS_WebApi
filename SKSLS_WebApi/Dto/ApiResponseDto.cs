namespace SKSLS_WebApi.Dto
{
    public class ApiResponseDto<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
        public byte[] ExcelFile { get; set; }
    }
}

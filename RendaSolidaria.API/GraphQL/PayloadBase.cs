namespace RendaSolidaria.API.GraphQL
{
    public record PayloadBase
    {
        public PayloadBase()
        {
            IsSuccess = true;
        }

        public bool IsSuccess { get; set; } 
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
    }
}

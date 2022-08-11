namespace MinimalApi.Net7.MediatR.Requests
{
    public class UpdateCustomerRequestParamaters : IHttpRequest
    {
        public int Id { get; set; }
    }
}

namespace MinimalApi.Net7.MediatR.Requests
{
    public class GetCustomerRequest: IHttpRequest
    {
        public int Id { get; set; }
    }
}

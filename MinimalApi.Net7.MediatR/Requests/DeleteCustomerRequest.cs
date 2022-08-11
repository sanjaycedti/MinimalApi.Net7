namespace MinimalApi.Net7.MediatR.Requests
{
    public class DeleteCustomerRequest : IHttpRequest
    {
        public int Id { get; set; }
    }
}

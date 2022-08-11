namespace MinimalApi.Net7.MediatR.Requests
{
    public class UpdateCustomerRequest : IHttpRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

namespace MinimalApi.Net7.MediatR.Requests
{
    public class AddCustomerRequest : IHttpRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

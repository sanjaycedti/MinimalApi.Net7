using MinimalApi.Net7.MediatR.Requests;

namespace MinimalApi.Net7.MediatR.Extensions
{
    public static class HttpMapperExtension
    {
        public static WebApplication MapCustomers(this WebApplication app)
        {
            app.MapMediatrGet<GetCustomerRequest>("customers/{id:int}");
            app.MapMediatrPost<AddCustomerRequest>("customers");
            app.MapMediatrPut<UpdateCustomerRequestParamaters, UpdateCustomerRequest>("customers/{id:int}");
            app.MapMediatrDelete<DeleteCustomerRequest>("customers/{id:int}");

            return app;
        }
    }
}

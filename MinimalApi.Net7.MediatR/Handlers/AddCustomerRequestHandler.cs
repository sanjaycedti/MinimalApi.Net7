using MediatR;
using MinimalApi.Net7.MediatR.Requests;

namespace MinimalApi.Net7.MediatR.Handlers
{
    public class AddCustomerRequestHandler : IRequestHandler<AddCustomerRequest, IResult>
    {
        public Task<IResult> Handle(AddCustomerRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Results.Created($"/customers/{request.Id}", request));
        }
    }
}

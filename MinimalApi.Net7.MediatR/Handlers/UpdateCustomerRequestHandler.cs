using MediatR;
using MinimalApi.Net7.MediatR.Requests;

namespace MinimalApi.Net7.MediatR.Handlers
{
    public class UpdateCustomerRequestHandler : IRequestHandler<UpdateCustomerRequest, IResult>
    {
        public Task<IResult> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Results.Ok(request));
        }
    }
}

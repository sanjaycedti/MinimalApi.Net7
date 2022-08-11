using MediatR;
using MinimalApi.Net7.MediatR.Requests;

namespace MinimalApi.Net7.MediatR.Handlers
{
    public class GetCustomerRequestHandler : IRequestHandler<GetCustomerRequest, IResult>
    {
        public Task<IResult> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Results.Ok(request));
        }
    }
}

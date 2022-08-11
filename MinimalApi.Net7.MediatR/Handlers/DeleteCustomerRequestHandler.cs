using MediatR;
using MinimalApi.Net7.MediatR.Requests;

namespace MinimalApi.Net7.MediatR.Handlers
{
    public class DeleteCustomerRequestHandler : IRequestHandler<DeleteCustomerRequest, IResult>
    {
        public Task<IResult> Handle(DeleteCustomerRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Results.NoContent());
        }
    }
}

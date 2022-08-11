using MediatR;

namespace MinimalApi.Net7.MediatR.Requests
{
    public interface IHttpRequest : IRequest<IResult>
    {
    }
}

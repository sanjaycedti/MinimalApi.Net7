using MediatR;
using MinimalApi.Net7.MediatR.Requests;
using System.Reflection;

namespace MinimalApi.Net7.MediatR.Extensions
{
    public static class MediatRMapApiExtension
    {
        public static WebApplication MapMediatrGet<TRequest>(this WebApplication app, string pattern) where TRequest : IHttpRequest
        {
            app.MapGet(pattern, async (IMediator mediator, [AsParameters] TRequest request) => await mediator.Send(request));

            return app;
        }

        public static WebApplication MapMediatrPost<TRequest>(this WebApplication app, string pattern) where TRequest : IHttpRequest
        {
            app.MapPost(pattern, async (IMediator mediator, TRequest request) => await mediator.Send(request));

            return app;
        }

        public static WebApplication MapMediatrPut<TRequestParameters, TRequestBody>(this WebApplication app, string pattern) where TRequestBody : IHttpRequest
        {
            var requestParamtersType = typeof(TRequestParameters);
            var requestBodyType = typeof(TRequestBody);

            var sourceProperties = requestParamtersType.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            app.MapPut(pattern, async (IMediator mediator, [AsParameters] TRequestParameters requestParams, TRequestBody requestBody) =>
            {
                foreach(var pi in sourceProperties)
                {
                    var value = pi.GetValue(requestParams);
                    var tpi = requestBodyType.GetProperty(pi.Name);

                    if (tpi is not null)
                    {
                        tpi.SetValue(requestBody, value);
                    }
                }

                return await mediator.Send(requestBody);
            });

            return app;
        }

        public static WebApplication MapMediatrDelete<TRequest>(this WebApplication app, string pattern) where TRequest : IHttpRequest
        {
            app.MapDelete(pattern, async (IMediator mediator, [AsParameters] TRequest request) => await mediator.Send(request));

            return app;
        }
    }
}

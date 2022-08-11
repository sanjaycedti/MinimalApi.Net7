using MediatR;
using MinimalApi.Net7.MediatR.Extensions;

var builder = WebApplication.CreateBuilder(args);

// ConfigureServices
builder.Services.AddMediatR(x => x.AsScoped(), typeof(Program));

var app = builder.Build();

// Configure
app.MapCustomers();

app.Run();
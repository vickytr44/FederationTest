var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("publish", c => c.BaseAddress = new Uri("http://localhost:61446/graphql"));
builder.Services.AddHttpClient("book", c => c.BaseAddress = new Uri("http://localhost:61445/graphql"));

builder.Services
    .AddGraphQLServer()
    .AddRemoteSchema("book")
    .AddRemoteSchema("publish"); 

var app = builder.Build();

app.MapGraphQL();

app.Run();

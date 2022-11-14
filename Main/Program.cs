var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .PublishSchemaDefinition(c => c
        .SetName("publish"));

var app = builder.Build();

app.MapGraphQL();

app.Run();

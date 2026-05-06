using Microsoft.Extensions.DependencyInjection;
using EndPointsII;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<Interface, ConsoleMessenger>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Step 4: POST endpoint
app.MapPost("/remove", (string message, Interface messenger) =>
{
    messenger.SendMessage(message);
    return Results.Ok($"Message sent: {message}");
})
    .WithName("RemoveMessage");


app.Run();

var builder = WebApplication.CreateBuilder(args);

// Register the hosted service
builder.Services.AddHostedService<HostAppConsole>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
Console.WriteLine("Startup");

app.Run();




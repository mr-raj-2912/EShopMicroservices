var builder = WebApplication.CreateBuilder(args);

// All Services are here

builder.Services.AddCarter();

builder.Services.AddMediatR(config =>
{
	config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

builder.Services.AddMarten(opts =>
{
	opts.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();

var app = builder.Build();

// After building the project use services 

app.MapCarter();

app.Run();

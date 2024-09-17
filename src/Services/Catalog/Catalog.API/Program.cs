var builder = WebApplication.CreateBuilder(args);

// All Services are here

builder.Services.AddCarter();

builder.Services.AddMediatR(config =>
{
	config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

// After building the project use services 

app.MapCarter();

app.Run();

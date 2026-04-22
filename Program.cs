
using MyfirstApp.services;
using MyfirstApp.services.Intersface;

var builder = WebApplication.CreateBuilder(args);


// swagger testing 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//controllers
builder.Services.AddControllers();

//register service for Dependency Inejection
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();

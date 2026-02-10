
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
// const string GetGameEndpointName = "GetName";
// List<GameDto> games = [
//     new(
//         1,
//         "Street Fighter",
//         "Fight",
//         19.99M,
//         new DateOnly(2003,7,15)
//     ),
//     new(
//         2,
//         "Final Fantasy VII Rebirth",
//         "RPG",
//         69.99M,
//         new DateOnly(2023,7,15)
//     ),new(
//         3,
//         "Astro Bot",
//         "Platform",
//         59.99M,
//         new DateOnly(2012,7,15)
//     ),
// ];

// app.MapGet("/games", ()=> games);
// app.MapGet("/games/{id}",(int id) =>games.Find(game => game.Id == id)).WithName(GetGameEndpointName);

// app.MapPost("/games", (CreateGameDto newGame) =>
// {
//     GameDto game = new(
//         games.Count + 1,
//         newGame.Name,
//         newGame.Genre,
//         newGame.Price,
//         newGame.ReleaseDate
//     );
//     games.Add(game);

//     return Results.CreatedAtRoute(GetGameEndpointName,new {id = game.Id},game);

    
// });

// app.MapPut("/games/{id}", (int id, UpdateGameDto updatedGame) =>
// {
//     var index = games.FindIndex(game => game.Id == id);

//     games[index] = new GameDto(
//         id,
//         updatedGame.Name,
//         updatedGame.Genre,
//         updatedGame.Price,
//         updatedGame.ReleaseDate
//     );
//     return Results.NoContent();
// });



app.MapControllers();
app.Run();

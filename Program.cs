using Microsoft.AspNetCore.Mvc;
using HelloApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Minimal API работает");

app.MapGet("/time", () => new {servetTime = DateTime.Now});

app.MapGet("/hello/{name}", (string name) => $"Hello {name}");


app.MapPost("/sum", (SumRequest req) => new {result = req.A + req.B } );

app.Run();

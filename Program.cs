using Microsoft.AspNetCore.Mvc;
using HelloApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Minimal API работает");

app.MapGet("/time", () => DateTime.Now.ToString("g"));

app.MapGet("/hello/{name}", (string name) => $"Hello {name}");



app.MapPost("/sum", (SumRequest req) => req.A + req.B);

app.Run();

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// We must add the DbContext to the dependency injection container to be usable in our app
// Uses a special extension method called AddDbContext
// This will register it using the "scoped" scope, meaning a new instance will be created for each request that the API receives
builder.Services.AddDbContext<ProjectDbContext>(o =>
    // For that reason we turn off query tracking to improve performance
    o.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Access db by adding to lambda params bc it is registered
// in the dep. injection container (which will provide us an instance)
app.MapGet("/projects", (ProjectDbContext dbContext) =>
    // all that's left is to return all project entities by accessing the Projects property
    // which is a collection of Project entities that will now be automatically serialized to JSON format
    // We use the LINQ Select method to project the entities into the DTOs
    dbContext.Projects.Select(p => new ProjectDTO(p.Id, p.Address, p.Country, p.Budget)));

app.Run();
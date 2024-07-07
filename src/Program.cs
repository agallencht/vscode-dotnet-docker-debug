using System.Collections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

System.Console.WriteLine( "====================================================");
System.Console.WriteLine( "VAR_TEST  "  + Environment.GetEnvironmentVariable("VAR_TEST"));
System.Console.WriteLine( "ASPNETCORE_ENVIRONMENT  "  + Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
System.Console.WriteLine( "ASPNETCORE_HTTP_PORTS  "  + Environment.GetEnvironmentVariable("ASPNETCORE_HTTP_PORTS"));
System.Console.WriteLine( "ASPNETCORE_HTTPS_PORTS  "  + Environment.GetEnvironmentVariable("ASPNETCORE_HTTPS_PORTS"));

foreach(DictionaryEntry e in System.Environment.GetEnvironmentVariables())
{
    Console.WriteLine(e.Key  + ":" + e.Value);
} 

System.Console.WriteLine( "====================================================");

app.Run();

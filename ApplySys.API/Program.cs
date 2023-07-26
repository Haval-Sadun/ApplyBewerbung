using ApplySys.Application;
using ApplySys.Infrastructure;
using ApplySys.Persistence;
using Keycloak.AuthServices.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();

AddSwaggerDoc(builder.Services);

var host = builder.Host;
var configuration = builder.Configuration;
var services = builder.Services;


// Add services to the container.
services.AddApplication();
services.AddInfrastructureServices(configuration);
services.AddPersistenceServices(configuration);

services.AddKeycloakAuthentication(configuration, o =>
{
    o.RequireHttpsMetadata = false;
    o.Audience = "account";
});





services.AddCors(o =>
{
    o.AddPolicy("CorsPolicy", builder =>
         builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

services.AddControllers();
services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
//put the swagger in the development environment when ...
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApplySys.API v1"));

app.UseHttpsRedirection();
app.UseRouting();

app.UseCors("CorsPolicy");
//app.UseCors(builder =>
//{
//    builder.WithOrigins("http://localhost:5173")
//        .AllowAnyHeader()
//        .AllowAnyMethod()
//        .AllowCredentials(); // Allow requests with credentials (cookies, authorization headers)
//});

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();


app.Run();

void AddSwaggerDoc(IServiceCollection services)
{
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "Apply System",

        });

    });
}

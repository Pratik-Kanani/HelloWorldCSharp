using System;
using Microsoft.AspNetCore.Builder;

var portVar = Environment.GetEnvironmentVariable("PORT");



WebApplicationBuilder webApplicationBuilder = WebApplication.CreateBuilder(args);
if(portVar is {Length: >0} && int.TryParse(portVar,out int port))
{
    webApplicationBuilder.WebHost.ConfigureKestrel(options =>
    {
        options.ListenAnyIP(port);
    });
}
WebApplication webApplication = webApplicationBuilder.Build();


webApplication.MapGet("/api/home",(Func<string>)(()=> "Hey listen, Get lost... I Mean Hello World!"));
webApplication.Run();
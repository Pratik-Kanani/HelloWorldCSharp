using System;
using Microsoft.AspNetCore.Builder;

WebApplicationBuilder webApplicationBuilder = WebApplication.CreateBuilder(args);
WebApplication webApplication = webApplicationBuilder.Build();

webApplication.MapGet("/api/home",(Func<string>)(()=> "Hey listen, Get lost... I Mean Hello World!"));
webApplication.Run();
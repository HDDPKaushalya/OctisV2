﻿
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using octisv2.Components;
using octisv2.Components.Hubs;
using octisv2.Components.Services;
using System;
using octisv2.Components.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;


namespace octisv2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddSingleton<Routedetails>();

            builder.Services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-strem" });
            });


            var app = builder.Build();
            app.UseResponseCompression();


            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }




            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();
            //app.MapHub<RoutedHub>("/routedhub");
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();
            app.Run();

        }
    }
}




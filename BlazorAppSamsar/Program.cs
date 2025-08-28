using BlazorAppSamsar.Components;
using BlazorAppSamsar.Data;
using BlazorAppSamsar.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddMudServices();
builder.Services.AddDbContext<DataContext>(item => item.UseSqlite("data source=c:\\samyardb\\samyar.db"));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(a =>
    {
        a.Cookie.Name = "samyarCookie";
        a.LoginPath = "/auth/login";
        a.AccessDeniedPath = "/auth/access-denied";
        a.LogoutPath = "/auth/logout";
        a.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        a.SlidingExpiration = true;
        a.Cookie.HttpOnly = true; //xss
        a.Cookie.SecurePolicy = CookieSecurePolicy.Always; //https
        a.Cookie.IsEssential = true;
    });

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<UploadedImagesService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

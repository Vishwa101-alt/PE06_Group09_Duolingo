using FSDProject.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FSDProject.Data;
using FSDProject.State;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<FSDProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FSDProjectContext") ?? throw new InvalidOperationException("Connection string 'FSDProjectContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddSingleton<NavState>();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

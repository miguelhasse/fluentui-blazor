using FluentUI.AdventureWorks.Server.Components;
using FluentUI.AdventureWorks.Server.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddFluentUIComponents()
    .AddDataGridEntityFrameworkAdapter(ex => ex is SqlException sqlEx && sqlEx.Errors.OfType<SqlError>()
        .Any(e => (e.Class == 11 && e.Number == 0) || (e.Class == 16 && e.Number == 3204)));

builder.Services.AddPooledDbContextFactory<AdventureWorksContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("AdventureWorks");
    options.UseSqlServer(connectionString, serverOptions =>
    {
        serverOptions.UseHierarchyId();
        serverOptions.UseNetTopologySuite();
        serverOptions.EnableRetryOnFailure();
    });
#if DEBUG
    options.EnableSensitiveDataLogging();
#endif
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

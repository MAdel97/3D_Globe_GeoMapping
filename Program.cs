using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
//using GeoMapping.BLL;
using GeoMapping.Context;
using Microsoft.EntityFrameworkCore;
using GeoMapping.BLL;
using Microsoft.AspNetCore.ResponseCompression;
using SignalRDemo.Hub;
using GeoMapping.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<GeoMappingContext>(options =>
               options.UseSqlServer("Server=Hady-Sharawi\\SQLEXPRESS;Database=GeoMapping;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true"));
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<GeoMappingBLL>();
builder.Services.AddBlazorBootstrap();
builder.Services.AddHttpClient<IAddressService, AddressService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7217/");
});
builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
          new[] { "application/octet-stream" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();            // new
    endpoints.MapBlazorHub();              // existing
    endpoints.MapFallbackToPage("/_Host"); // existing
});
app.MapHub<DataHub>("/datahub");
app.UseResponseCompression();
app.Run();

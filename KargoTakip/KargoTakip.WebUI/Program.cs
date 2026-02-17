using KargoTakip.Business.Abstract;
using KargoTakip.Business.Concrete;
using KargoTakip.Data.Abstract;
using KargoTakip.Data.Context;
using KargoTakip.Data.Ef;
using KargoTakip.DataAccess.Abstract;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMesajService, MesajManager>();
builder.Services.AddScoped<IMesajDal, EfMesajDal>();
builder.Services.AddDbContext<KargoContext>();
builder.Services.AddScoped<IAyarlarService, AyarlarManager>();
builder.Services.AddScoped<IAyarlarDal, EfAyarlarRepository>();
builder.Services.AddControllersWithViews().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
  pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();

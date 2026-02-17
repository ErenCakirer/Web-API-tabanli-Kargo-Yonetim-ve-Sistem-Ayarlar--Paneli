using KargoTakip.Business.Abstract;
using KargoTakip.Business.Concrete;
using KargoTakip.Data.Abstract;
using KargoTakip.Data.Context;
using KargoTakip.Data.Ef;
using KargoTakip.Data.Repositories;
using KargoTakip.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {

        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

        
        options.SerializerSettings.ContractResolver = new DefaultContractResolver();
    });


builder.Services.AddDbContext<KargoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IMesajService, MesajManager>();
builder.Services.AddScoped<IMesajDal, EfMesajDal>();
builder.Services.AddScoped<IAyarlarService, AyarlarManager>();
builder.Services.AddScoped<IAyarlarDal, EfAyarlarRepository>();
builder.Services.AddScoped<IKuryeService, KuryeManager>();
builder.Services.AddScoped<IKargoHareketService, KargoHareketManager>();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ISevkiyatService, SevkiyatManager>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();
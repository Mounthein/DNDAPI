using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<DndStoreDatabaseSettings>(builder.Configuration.GetSection(nameof(DndStoreDatabaseSettings)));
builder.Services.AddSingleton<IDndStoreDatabaseSettings>(sp => sp.GetRequiredService<IOptions<DndStoreDatabaseSettings>>().Value);
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("DndStoreDatabaseSettings:ConnectionString")));
builder.Services.AddScoped<IDamageTypeService, DamageTypeService>();
builder.Services.AddScoped<IAlignmentService, AlignmentService>();
builder.Services.AddScoped<IWeaponPropertyService, WeaponPropertyService>();
builder.Services.AddScoped<IConditionService, ConditionService>();
builder.Services.AddScoped<ILanguageService, LanguageService>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<IAbilityScoreService, AbilityScoreService>();
builder.Services.AddScoped<IClassesService, ClassesService>();
builder.Services.AddScoped<IBackgroundService, DNDAPI.Services.BackgroundService>();
builder.Services.AddScoped<IEquipmentService, EquipmentService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

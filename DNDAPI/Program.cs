using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication();
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
builder.Services.AddScoped<IClassesService, ClassesService>();
builder.Services.AddScoped<IEquipmentCategoryService, EquipmentCategoryService>();
builder.Services.AddScoped<IFeatService, FeatService>();
builder.Services.AddScoped<IFeatureService, FeatureService>();
builder.Services.AddScoped<ILevelService, LevelService>();
builder.Services.AddScoped<IMagicItemService, MagicItemService>();
builder.Services.AddScoped<IMagicSchoolService, MagicSchoolService>();
builder.Services.AddScoped<IProficiencyService, ProficiencyService>();
builder.Services.AddScoped<IRaceService, RaceService>();
builder.Services.AddScoped<ISpellService, SpellService>();
builder.Services.AddScoped<ISubclassService, SubclassService>();
builder.Services.AddScoped<ISubraceService, SubraceService>();
builder.Services.AddScoped<ITraitService, TraitService>();
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddScoped<IUserService, UserService>();



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

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.UseAuthentication();
app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();

using CDU_Music_Lessons_Application.Data;
using CDU_Music_Lessons_Application.Data.Services;
using CDU_Music_Lessons_Application.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependancies Injecton with AppDbContext
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

//Services Configuration
builder.Services.AddScoped<IStudentsService, StudentsService>();
builder.Services.AddScoped<ILessonsService, LessonsService>();
builder.Services.AddScoped<IDurationsService, DurationsService>();
builder.Services.AddScoped<ITutorsService, TutorsService>();
builder.Services.AddScoped<IInstrumentsService, InstrumentsService>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddControllersWithViews();

//
var app = builder.Build();

//Seed Database
AppDbInitializer.Seed(app);


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

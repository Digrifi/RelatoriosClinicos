using Microsoft.EntityFrameworkCore;
using SistemaClinicaRelatorio.Application.Service.Services;
using SistemaClinicaRelatorio.Domain.Contracts.Repositories;
using SistemaClinicaRelatorio.Domain.Contracts.Services;
using SistemaClinicaRelatorio.Infra.Data.Context;
using SistemaClinicaRelatorio.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// SQLServerContext
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer("Server=DESKTOP-UME51NM\\SQLMATEUS;Database=SistemaClinica;User Id=sa;Password=zuky;TrustServerCertificate=True;Encrypt=False;"));

// ### Dependency Injection
// # Repositories
builder.Services.AddScoped<IPatientReportRepository, PatientReportRepository>();
builder.Services.AddScoped<IDoctorQueryRepository, DoctorQueryReportRepository>();
builder.Services.AddScoped<IMonthQueriesReportRepository, MonthQueriesReportRepository>();

// # Services
builder.Services.AddScoped<IPatientReportService, PatientReportService>();
builder.Services.AddScoped<IDoctorQueryReportService, DoctorQueryReportService>();
builder.Services.AddScoped<IMonthQueriesReportService, MonthQueriesReportService>();


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

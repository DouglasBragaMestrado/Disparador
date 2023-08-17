using Microsoft.EntityFrameworkCore;
using site.Interface;
using site.Service;
using site.Utilitario;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// App está na fase de build
builder.Configuration.GetValue<string>("Env");
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<siteDBContext>(options =>
                  options.UseMySQL(connectionString));

builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IContatoService, ContatoService>();
builder.Services.AddSingleton<ISmtpService, SmtpService>();
builder.Services.AddSingleton<IWhatsAppService, WhatsAppService>();
builder.Services.AddSingleton<IUtil, Util>();
builder.Services.AddScoped<IConsultorService, ConsultorService>();
builder.Services.AddScoped<INivelService, NivelService>();
builder.Services.AddScoped<ILogService, LogService>();
builder.Services.AddScoped<IStatusService, StatusService>();
builder.Services.AddScoped<ILoginAcessoService, LoginAcessoService>();
builder.Services.AddScoped<ILoginDisparadorService, LoginDisparadorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// App já está pronto para ser executado
app.Configuration.GetValue<string>("Env");
//app.MapGet("/", () => app.Configuration.GetValue<string>("Env"));

//var smtp = new Configuration.SmtpConfiguration();
app.Configuration.GetSection("SmtpConfiguration");

app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
//pattern: "{controller=Home}/{action=Index}/{id?}");
pattern: "{controller=Home}/{action=temporario}/{id?}");

app.Run();

//Registro de Interface
//services.AddScoped<IfiltroReportService, filtroReportService>();
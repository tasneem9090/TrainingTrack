using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using TrainingTrack.data;
using TrainingTrack.Models;
using TrainingTrack.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddAutoMapper(config =>
//{
//    config.AddMaps(AppDomain.CurrentDomain.GetAssemblies());
//});
builder.Services.AddAutoMapper(cfg => { cfg.AddProfile<MappingProfile>(); });

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<TRContext>();
builder.Services.AddDbContext<TRContext>();
builder.Services.AddScoped<ITrainerServices, TrainerServices>();
builder.Services.AddScoped<IDailyReportServices, DailyReportServices>();
//builder.Services.AddScoped<IEnrollmentServices, EnrollmentServices>();
builder.Services.AddScoped<INationalityServices, NationalityServices>();
builder.Services.AddScoped<ITraineeServices, TraineeServices>();
//builder.Services.AddScoped<IAttendanceServices, AttendanceServices>();
builder.Services.AddScoped<IGovernorateServices, GovernorateServices>();
builder.Services.AddScoped<ITrainingServices, TrainingServices>();
builder.Services.AddScoped<IHallServices, HallServices>();
//builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IAccountServices, AccountServices>();
builder.Services.AddScoped<IBookDistributionServices, BookDistributionServices>();
builder.Services.AddScoped<IBookServices, BookServices>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 3;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
});
//builder.Services.ConfigureApplicationCookie(config =>
//{
//    config.LoginPath = "/Account/SignIn";
//});
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
    pattern: "{controller=Account}/{action=SignIn}/{id?}");

app.Run();

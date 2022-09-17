using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SiteWithMySkills.Service;
using SiteWithMySkills.Domain;
using SiteWithMySkills.Domain.Repositories.Abstract;
using SiteWithMySkills.Domain.Repositories.EntityFramework;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Configuration.AddJsonFile(@"appsettings.json");
builder.Configuration.Bind("Progect", new Config());

builder.Services.AddTransient<ITextFieldsRepository,EFTextFieldsRepository>();
builder.Services.AddTransient<IServiceItemRepository, EFServiceItemsRepository>();
builder.Services.AddTransient<ITovarsItemsRepository,EFTovarsItemsRepository>();
builder.Services.AddTransient<IDataRepository, EFDataItemsRepository>();
builder.Services.AddTransient<DataManager>();


builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));
var connectionString = Config.ConnectionString;
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>();

/*builder.Services.AddIdentity<IdentityUser, IdentityRole>(opts =>
{
    opts.User.RequireUniqueEmail = true;
    opts.Password.RequiredLength = 6;
    opts.Password.RequireNonAlphanumeric = false;
    opts.Password.RequireLowercase = false;
    opts.Password.RequireUppercase = false;
    opts.Password.RequireDigit = false;
}
    ).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();*/
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "SiteAuth";
    options.Cookie.HttpOnly = true;
    options.LoginPath = "/account/login";
    options.AccessDeniedPath = "/accountacessdenied";
    options.SlidingExpiration = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    
    app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute("GetDataForYearMonth", "{controller=ExcelData}/{action=ShowNew}/{year=2010}/{month=1}");

});
app.MapRazorPages();


app.Run();

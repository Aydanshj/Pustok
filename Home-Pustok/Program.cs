using Microsoft.EntityFrameworkCore;
using PustokTemplateTask.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PustokDbContext>(opt =>

opt.UseSqlServer("Server = DESKTOP-PV206RC\\SQLEXPRESS; Database = HomePustok; Integrated Security = true")

);
var app = builder.Build();

app.MapControllerRoute(
    
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    
    );

app.UseStaticFiles();
app.Run();

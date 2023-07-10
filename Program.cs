using EpargneRichard.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new AppDbContext())
{
    context.Database.EnsureDeleted();

    context.Database.EnsureCreated();

    var savingaccount = new SavingAccount
    {
        RIB = "12356489as1564",
        Name = "Richar",
        SavingRate = 0.15,
        Amount = 200000

    };

    context.Add(savingaccount);
    context.SaveChanges();

}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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


           

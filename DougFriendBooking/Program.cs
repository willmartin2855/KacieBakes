using DougFriendBooking.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ILocationRepo, LocationRepo>();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BookingDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:BookingSiteDbContextConnection"]);
});

// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//app.UseAuthorization();

//app.MapControllers();
app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();

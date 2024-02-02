using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Handlers;
using BakeryProject.CQRSPattern.Handlers.FiveProduct;
using BakeryProject.CQRSPattern.Handlers.Main;
using BakeryProject.CQRSPattern.Handlers.NewProduct;
using BakeryProject.CQRSPattern.Handlers.OnePage;
using BakeryProject.CQRSPattern.Handlers.Service;
using BakeryProject.CQRSPattern.Handlers.slider;
using BakeryProject.CQRSPattern.Handlers.TwoPage;
using BakeryProject.DAL.Context;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SaleContext>();


//Slider
builder.Services.AddScoped<GetSliderQueryHandler>();
builder.Services.AddScoped<CreateSliderCommandHandler>();
builder.Services.AddScoped<GetSliderByIdQueryHandler>();
builder.Services.AddScoped<UpdateSliderCommandHandler>();
builder.Services.AddScoped<RemoveSliderCommandHandler>();
//Slider Bitiþ
//Main
builder.Services.AddScoped<GetMainQueryHandler>();
builder.Services.AddScoped<CreateMainCommandHandler>();
builder.Services.AddScoped<GetMainByIdQueryHandler>();
builder.Services.AddScoped<UpdateMainCommandHandler>();
builder.Services.AddScoped<RemoveMainCommandHandler>();
//Main Bitiþ

builder.Services.AddScoped<GetFiveProductQueryHandler>();
builder.Services.AddScoped<CreateFiveProductCommandHandler>();
builder.Services.AddScoped<GetFiveProductByIdQueryHandler>();
builder.Services.AddScoped<UpdateFiveProductCommandHandler>();
builder.Services.AddScoped<RemoveFiveProductCommandHandler>();

builder.Services.AddScoped<GetNewProductQueryHandler>();
builder.Services.AddScoped<CreateNewProductCommandHandler>();
builder.Services.AddScoped<GetNewProductByIdQueryHandler>();
builder.Services.AddScoped<UpdateNewProductCommandHandler>();
builder.Services.AddScoped<RemoveNewProductCommandHandler>();


builder.Services.AddScoped<GetOnePageQueryHandler>();
builder.Services.AddScoped<CreateOnePageCommandHandler>();
builder.Services.AddScoped<GetOnePageByIdQueryHandler>();
builder.Services.AddScoped<UpdateOnePageCommandHandler>();
builder.Services.AddScoped<RemoveOnePageCommandHandler>();


builder.Services.AddScoped<GetServiceQueryHandler>();
builder.Services.AddScoped<CreateServiceCommandHandler>();
builder.Services.AddScoped<GetServiceByIdQueryHandler>();
builder.Services.AddScoped<UpdateServiceCommandHandler>();
builder.Services.AddScoped<RemoveServiceCommandHandler>();


builder.Services.AddScoped<GetTwoPageQueryHandler>();
builder.Services.AddScoped<CreateTwoPageCommandHandler>();
builder.Services.AddScoped<GetTwoPageByIdQueryHandler>();
builder.Services.AddScoped<UpdateTwoPageCommandHandler>();
builder.Services.AddScoped<RemoveTwoPageCommandHandler>();








//medaitr
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
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

using ECommerce.Application.Abstract;
using ECommerce.Application.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Context;
using ECommerce.DataAccess.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICategoryDal, EFCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<IOrderDetailDal, EFOrderDetailDal>();
builder.Services.AddScoped<IOrderDetailService, OrderDeatilService>();

builder.Services.AddScoped<IProductDal, EFProductDal>();
builder.Services.AddScoped<IProductService, ProductService >();

builder.Services.AddScoped<IOrderDetailExtendDal, EFOrderDetailExtendDal>();
builder.Services.AddScoped<IOrderDetailExtendService, OrderDetailExtendService>();

builder.Services.AddScoped<ISummaryOfSalesByQuarterDal, EFSummaryOfSalesByQuarterDal>();
builder.Services.AddScoped<ISummaryOfSalesByQuarterService, SummaryOfSalesByQuarterService>();

var conn = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<NorthWindDbContext>(opt =>
{
    opt.UseSqlServer(conn);
});


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

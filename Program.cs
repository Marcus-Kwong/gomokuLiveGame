using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// ✅ 添加 MVC 控制器和视图支持
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ✅ 启用 wwwroot 静态文件支持（如 CSS/JS）
app.UseStaticFiles();

// ✅ 使用默认的 MVC 路由模式
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();

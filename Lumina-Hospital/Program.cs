using Lumina_Hospital;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.Register(config);

var app = builder.Build();
app.UseHttpsRedirection();
app.UseSession();
app.UseCookiePolicy();

//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using FluentValidation.AspNetCore;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.AppUser;
using Lumina_Hospital.Mapper;
using Lumina_Hospital.Services.Abstract;
using Lumina_Hospital.Services.Concrete;
using Lumina_Hospital.ViewModel.Admin;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital
{
    public static class RegisterService
    {
        public static void Register(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllersWithViews().AddFluentValidation(opt => opt.RegisterValidatorsFromAssemblyContaining<AboutSectionEditVMValidator>()); ;

            services.AddDbContext<LuminaHospitalDbContex>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            services.AddAutoMapper(opt =>
            {
                opt.AddProfile(new MapperProfile());
            });
            services.AddSession(opt =>
            {
                opt.IdleTimeout = TimeSpan.FromMinutes(5);
            });
            services.AddScoped<IBasket, BasketService>();
            services.AddScoped<ISendEmail, SendEmailService>();
            services.AddHttpContextAccessor();

            services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.Password.RequiredUniqueChars = 3;
                opt.Password.RequireNonAlphanumeric = true;
                opt.Password.RequireDigit = true;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireUppercase = true;

                opt.User.RequireUniqueEmail = true;
                //opt.User.AllowedUserNameCharacters = default;

                opt.SignIn.RequireConfirmedEmail = true;

                opt.Lockout.MaxFailedAccessAttempts = 5;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                opt.Lockout.AllowedForNewUsers = true;


            }).AddDefaultTokenProviders().AddEntityFrameworkStores<LuminaHospitalDbContex>();


            services.AddAuthentication().AddFacebook(opt =>
            {
                opt.AppId = config["FacebookAppId"];
                opt.AppSecret = config["FacebookAppSecret"];
            });
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    options.Secure = CookieSecurePolicy.Always;
            //});
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            })
            .AddCookie(options =>
            {
                options.ForwardAuthenticate = IdentityConstants.ExternalScheme;
                options.Cookie.SameSite = SameSiteMode.None;
            });
            services.AddAuthentication().AddGoogle(opt =>
            {
                opt.ClientId = config["GoogleClientId"];
                opt.ClientSecret = config["GoogleClientSecret"];
            });

            

            
        }
    }
}

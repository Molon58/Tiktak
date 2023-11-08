using AspNetCoreTiktakProject.App.DataAccess.Contexts;
using AspNetCoreTiktakProject.App.DataAccess.Identities;
using AspNetCoreTiktakProject.App.DataAccess.UnitOfWorks;
using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.UnitOfWorks;
using AspNetCoreTiktakProject.App.Service.Mapping;
using AspNetCoreTiktakProject.App.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Service.Extentions
{
    public static class DependencyExtensions
    {
        public static void AddExtensions(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(
                opt =>
                {
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequiredLength = 5;
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireDigit = false;

                    opt.User.RequireUniqueEmail = true;
                    opt.Lockout.MaxFailedAccessAttempts = 3;
                    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);

                }
                ).AddEntityFrameworkStores<TiktakContext>();

            //çerezler için servis yazıyoruz.
            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Account/Login");
                opt.LogoutPath = new PathString("/Account/Logout");

                opt.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                opt.SlidingExpiration = true; //süre dolmadan kullanıcı tekrar logın olursa süre basatan baslar.
                opt.Cookie = new CookieBuilder()
                {
                    Name = "Tiktak.App.Cookie",
                    HttpOnly = true,

                };
            });

            services.AddScoped<IUnitOfWorks, UnitOfWorks>();
            services.AddScoped(typeof(ICarPropertyService), typeof(CarPropertyService));
            services.AddScoped(typeof(IAccountService), typeof(AccountService));
            services.AddScoped(typeof(ICarSaleService), typeof(CarSaleService));


            services.AddAutoMapper(typeof(MappingProfile));



        }



    }
}

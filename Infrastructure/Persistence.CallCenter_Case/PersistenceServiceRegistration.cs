using Application.CallCenter_Case.Abstractions.Services;
using Application.CallCenter_Case.Abstractions.Services.Authentications;
using Application.CallCenter_Case.Repositories;
using Domain.CallCenter_Case.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.CallCenter_Case.Contexts;
using Persistence.CallCenter_Case.Repositories;
using Persistence.CallCenter_Case.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.CallCenter_Case
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            //Add Db Context
            services.AddDbContext<CallCenterDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            //Identity Options
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<CallCenterDbContext>();


            services.AddScoped<ICallRecordWriteRepository, CallRecordWriteRepository>();
            services.AddScoped<ICallRecordReadRepository, CallRecordReadRepository>();

            services.AddScoped<IRequestReadRepository, RequestReadRepository>();
            services.AddScoped<IRequestWriteRepository, RequestWriteRepository>();

            services.AddScoped<IReportWriteRepository, ReportWriteRepository>();
            services.AddScoped<IReportReadRepository, ReportReadRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();

            services.AddScoped<IExternalAuthentication, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            services.AddScoped<IRoleService, RoleService>();


        }
    }
}

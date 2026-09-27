using CleanArch.application.Interfaces;
using CleanArch.application.Services;
using CleanArchDomain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //applicatiton layer
            services.AddScoped<ICourseService, CourseService>();

            //data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}

using System.Web.Http;
using WebActivatorEx;
using SkriptPrototyp;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SkriptPrototyp
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    { 
                        c.SingleApiVersion("v1", "SkriptPrototyp");  
                    })

                .EnableSwaggerUi(c =>
                    {});
        }
    }
}

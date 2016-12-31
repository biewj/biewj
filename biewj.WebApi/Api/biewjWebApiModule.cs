using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Swashbuckle.Application;
using System.Linq;
using System;
using System.IO;

namespace biewj.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(biewjApplicationModule))]
    public class biewjWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(biewjApplicationModule).Assembly, "app")
                .Build();

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));

            //调用SwaggerUi
            ConfigureSwaggerUi();
        }


        /// <summary>
        /// 配置SwaggerUi
        /// </summary>
        private void ConfigureSwaggerUi()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Swagger API文档");
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                    //将application层中的注释添加到SwaggerUI中
                    var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    var commentsFileName = "Bin//biewj.Application.xml";
                    var commentsFile = Path.Combine(baseDirectory, commentsFileName);
                    //将注释的XML文档添加到SwaggerUI中
                    c.IncludeXmlComments(commentsFile);
                })
                .EnableSwaggerUi("help/{*assetPath}", c =>
                {
                    c.InjectJavaScript(Assembly.GetExecutingAssembly(), "biewj.js.lang.zh-CN.js");
                });

        }
    }
}

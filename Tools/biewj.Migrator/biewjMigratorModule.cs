using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using biewj.EntityFramework;

namespace biewj.Migrator
{
    [DependsOn(typeof(biewjDataModule))]
    public class biewjMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<biewjDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
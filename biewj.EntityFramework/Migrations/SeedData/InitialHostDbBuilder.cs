using biewj.EntityFramework;
using EntityFramework.DynamicFilters;

namespace biewj.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly biewjDbContext _context;

        public InitialHostDbBuilder(biewjDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

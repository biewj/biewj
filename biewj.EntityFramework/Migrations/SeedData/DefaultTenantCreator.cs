using System.Linq;
using biewj.EntityFramework;
using biewj.MultiTenancy;

namespace biewj.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly biewjDbContext _context;

        public DefaultTenantCreator(biewjDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

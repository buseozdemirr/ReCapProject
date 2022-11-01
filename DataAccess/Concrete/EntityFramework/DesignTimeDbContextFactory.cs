using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ReCapProjectDbContext>
    {
        //code first yaklaşımı kullanıldığı için ve oluşturulan mimari katmanlı yapıda olduğundan
        //kullanılması gereken kod bloğudur.
        public ReCapProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ReCapProjectDbContext>();
            var connectionString = @"Server = (localdb)\MSSQLLocalDB";
            builder.UseSqlServer(connectionString);
            return new ReCapProjectDbContext(builder.Options);
        }
    }
}

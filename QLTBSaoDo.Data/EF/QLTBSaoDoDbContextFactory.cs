using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QLTBSaoDo.Data.EF
{
    public class QLTBSaoDoDbContextFactory : IDesignTimeDbContextFactory<QLTBDbContext>
    {
        public QLTBDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("QLTBDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<QLTBDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new QLTBDbContext(optionsBuilder.Options);
        }
    }
}

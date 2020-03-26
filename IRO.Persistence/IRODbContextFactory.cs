using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Persistence
{
    class IRODbContextFactory : IDesignTimeDbContextFactory<IRODbContext>
    {
        public IRODbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<IRODbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=InstantRO;Trusted_Connection=True;Application Name=InstantRO;");

            return new IRODbContext(optionsBuilder.Options);
        }
    }
}

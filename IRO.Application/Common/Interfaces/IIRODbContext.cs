using IRO.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IRO.Application.Common.Interfaces
{
    public interface IIRODbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<UserDmsLink> UserDmsLinks { get; set; }
        DbSet<UserVehicle> UserVehicles { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

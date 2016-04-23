using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingPrototype.Shared.Entities;

namespace TimeTrackingPrototype.Shared.DataAccess
{
    public class TimeTrackingContext
    {
    public DbSet<User> Users { get; set; }
    public DbSet<UserGroup> UserGroups { get; set; }
  }
}

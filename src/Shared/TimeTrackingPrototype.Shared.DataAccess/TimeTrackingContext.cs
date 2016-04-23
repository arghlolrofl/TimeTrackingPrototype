using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingPrototype.Shared.Entities;

namespace TimeTrackingPrototype.Shared.DataAccess {
  public class TimeTrackingContext : DbContext {
    const string DbConnectionStringName = "DbConnectionString";
    const string DataDirectoryKey = "DataDirectory";

    static readonly string DatabasePath;

    public DbSet<User> Users { get; set; }
    public DbSet<UserGroup> UserGroups { get; set; }


    /// <summary>
    /// Reads the database directory from the config file.
    /// </summary>
    static TimeTrackingContext() {
      Debug.WriteLine("Reading database path from config file");
      DatabasePath = ConfigurationManager.AppSettings[DataDirectoryKey];
    }

    /// <summary>
    /// Initializes a new instance of the database context class.
    /// </summary>
    public TimeTrackingContext() : base(DbConnectionStringName) {
      string path = AppDomain.CurrentDomain.GetData(DataDirectoryKey) as String;
      if (String.IsNullOrEmpty(path)) {
        // Set |DataDirectory| value
        AppDomain.CurrentDomain.SetData(DataDirectoryKey, DatabasePath);
        Debug.WriteLine("DataDirectory set to: " + DatabasePath);
      }

      //Database.SetInitializer(new MigrateDatabaseToLatestVersion<TimeTrackingContext, Migrations.Configuration>(DbConnectionStringName));
    }


    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);
    }
  }
}

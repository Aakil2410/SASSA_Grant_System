using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SASSAGrantSystem.EntityFrameworkCore
{
    public static class SASSAGrantSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SASSAGrantSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SASSAGrantSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

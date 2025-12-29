using Microsoft.Data.Sqlite;
using System.Data.Common;

namespace BPSR_ZDPS.Database.Migrations
{
    public class BaseMigration
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public float MinVersion { get; set; }
        public float NewVersion { get; set; }

        public string ErrorMsg = "";

        public virtual bool RunMigration(DbConnection dbConn, SqliteTransaction tx)
        {
            return false;
        }
    }
}

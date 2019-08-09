using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace T4Templates
{
    static class Program
    {
        struct Launch
        {
            public long Id;
            public string Mission;
            public string Rocket;
            public DateTime LaunchDateTime;
            public bool StageRecovery;
            public string NET;
            public string LaunchProvider;
            public string LaunchSite;
        }

        static IEnumerable<Launch> ReadLaunches(this IDbConnection dbConnection, string query)
        {
            var default_Id = 0L;
            var default_Mission = string.Empty;
            var default_LaunchDateTime = DateTime.MinValue;
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                using (var reader = cmd.ExecuteReader())
                {
                    var fc = reader.FieldCount;
                    var row = new object[fc];

                    var ord_Id = reader.GetOrdinal("Id");
                    var ord_Mission = reader.GetOrdinal("Mission");
                    var ord_LaunchDateTime = reader.GetOrdinal("LaunchdateTime");

                    while (reader.Read())
                    {
                        // TODO: Unnecessary boxing?
                        // TODO: Two strategies, one for wide rows and one for narrow rows?
                        var afc = reader.GetValues(row);
                        if (afc != fc)
                        {
                            throw new Exception($"Expected {fc} fields but got {afc} fields");
                        }

                        var val_Id = (row[ord_Id] is DBNull) ? default_Id : ((long)row[ord_Id]);
                        var val_MIssion = (row[ord_Mission] is DBNull) ? default_Mission : ((string)row[ord_Mission]);
                        var val_LaunchDateTime = (row[ord_LaunchDateTime] is DBNull) ? default_LaunchDateTime : ((DateTime)row[ord_LaunchDateTime]);

                        yield return new Launch
                        {
                            Id = val_Id,
                            Mission = val_MIssion,
                            LaunchDateTime = val_LaunchDateTime,
                        };

                    }
                }
            }

        }

        static void Main(string[] args)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RocketLaunches;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (var dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                var launches = dbConnection.ReadLaunches(@"SELECT * FROM Launch").ToArray();

                foreach (var launch in launches)
                {
                    Console.WriteLine($"{launch.Id}: {launch.Mission} {(launch.LaunchDateTime != DateTime.MinValue ? launch.LaunchDateTime.ToString() : "-")}");
                }
            }
        }
    }
}
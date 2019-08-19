





using System;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace Launch3
{
    public class LaunchView
    {
        public System.Int32 Id { get; set; }
        public System.String Mission { get; set; }
        public System.DateTime LaunchdateTime { get; set; }
        public System.String NET { get; set; }
        public System.String LaunchProvider { get; set; }
        public System.String Rocket { get; set; }
        public System.String Pad { get; set; }
        public System.String Location { get; set; }
        public System.Boolean StageRecovery { get; set; }
        public override string ToString ()
        {
            var sb = new StringBuilder ();
            sb.Append ("{ LaunchView ");
            sb.Append(", Id = ");
            sb.Append(Id);
            sb.Append(", Mission = ");
            sb.Append(Mission);
            sb.Append(", LaunchdateTime = ");
            sb.Append(LaunchdateTime);
            sb.Append(", NET = ");
            sb.Append(NET);
            sb.Append(", LaunchProvider = ");
            sb.Append(LaunchProvider);
            sb.Append(", Rocket = ");
            sb.Append(Rocket);
            sb.Append(", Pad = ");
            sb.Append(Pad);
            sb.Append(", Location = ");
            sb.Append(Location);
            sb.Append(", StageRecovery = ");
            sb.Append(StageRecovery);
            sb.Append (" }");    
            return sb.ToString ();
        }   
    }

    public static partial class T4pper
    {
        public static IEnumerable<LaunchView> TableScan_LaunchView(
            this IDbConnection dbConnection)
        {
             System.Int32 default_Id = default;
             System.String default_Mission = default;
             System.DateTime default_LaunchdateTime = default;
             System.String default_NET = default;
             System.String default_LaunchProvider = default;
             System.String default_Rocket = default;
             System.String default_Pad = default;
             System.String default_Location = default;
             System.Boolean default_StageRecovery = default;
   
           
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM LaunchView";
                using (var reader = cmd.ExecuteReader())
                {
                    var fc = reader.FieldCount;
                    var row = new object[fc];

                    var ord_Id = reader.GetOrdinal("Id");
                    var ord_Mission = reader.GetOrdinal("Mission");
                    var ord_LaunchdateTime = reader.GetOrdinal("LaunchdateTime");
                    var ord_NET = reader.GetOrdinal("NET");
                    var ord_LaunchProvider = reader.GetOrdinal("LaunchProvider");
                    var ord_Rocket = reader.GetOrdinal("Rocket");
                    var ord_Pad = reader.GetOrdinal("Pad");
                    var ord_Location = reader.GetOrdinal("Location");
                    var ord_StageRecovery = reader.GetOrdinal("StageRecovery");

                    while (reader.Read())
                    {
                        // TODO: Unnecessary boxing?
                        // TODO: Two strategies, one for wide rows and one for narrow rows?
                        var afc = reader.GetValues(row);
                        if (afc != fc)
                        {
                            throw new Exception($"Expected {fc} fields but got {afc} fields");
                        }

                        var val_Id = (row[ord_Id] is DBNull) ? default_Id : ((System.Int32)row[ord_Id]);
                        var val_Mission = (row[ord_Mission] is DBNull) ? default_Mission : ((System.String)row[ord_Mission]);
                        var val_LaunchdateTime = (row[ord_LaunchdateTime] is DBNull) ? default_LaunchdateTime : ((System.DateTime)row[ord_LaunchdateTime]);
                        var val_NET = (row[ord_NET] is DBNull) ? default_NET : ((System.String)row[ord_NET]);
                        var val_LaunchProvider = (row[ord_LaunchProvider] is DBNull) ? default_LaunchProvider : ((System.String)row[ord_LaunchProvider]);
                        var val_Rocket = (row[ord_Rocket] is DBNull) ? default_Rocket : ((System.String)row[ord_Rocket]);
                        var val_Pad = (row[ord_Pad] is DBNull) ? default_Pad : ((System.String)row[ord_Pad]);
                        var val_Location = (row[ord_Location] is DBNull) ? default_Location : ((System.String)row[ord_Location]);
                        var val_StageRecovery = (row[ord_StageRecovery] is DBNull) ? default_StageRecovery : ((System.Boolean)row[ord_StageRecovery]);


                        yield return new LaunchView
                        {

                            Id = val_Id,
                            Mission = val_Mission,
                            LaunchdateTime = val_LaunchdateTime,
                            NET = val_NET,
                            LaunchProvider = val_LaunchProvider,
                            Rocket = val_Rocket,
                            Pad = val_Pad,
                            Location = val_Location,
                            StageRecovery = val_StageRecovery,
 
                        };

                    }
                }
            }
        }
    }
    public class Launch
    {
        public System.Int64 Id { get; set; }
        public System.String Mission { get; set; }
        public System.Int64 LaunchProvider { get; set; }
        public System.Int64 Rocket { get; set; }
        public System.Int64 LaunchSite { get; set; }
        public System.String NET { get; set; }
        public System.Boolean StageRecovery { get; set; }
        public System.DateTime LaunchdateTime { get; set; }
        public override string ToString ()
        {
            var sb = new StringBuilder ();
            sb.Append ("{ Launch ");
            sb.Append(", Id = ");
            sb.Append(Id);
            sb.Append(", Mission = ");
            sb.Append(Mission);
            sb.Append(", LaunchProvider = ");
            sb.Append(LaunchProvider);
            sb.Append(", Rocket = ");
            sb.Append(Rocket);
            sb.Append(", LaunchSite = ");
            sb.Append(LaunchSite);
            sb.Append(", NET = ");
            sb.Append(NET);
            sb.Append(", StageRecovery = ");
            sb.Append(StageRecovery);
            sb.Append(", LaunchdateTime = ");
            sb.Append(LaunchdateTime);
            sb.Append (" }");    
            return sb.ToString ();
        }   
    }

    public static partial class T4pper
    {
        public static IEnumerable<Launch> TableScan_Launch(
            this IDbConnection dbConnection)
        {
             System.Int64 default_Id = default;
             System.String default_Mission = default;
             System.Int64 default_LaunchProvider = default;
             System.Int64 default_Rocket = default;
             System.Int64 default_LaunchSite = default;
             System.String default_NET = default;
             System.Boolean default_StageRecovery = default;
             System.DateTime default_LaunchdateTime = default;
   
           
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Launch";
                using (var reader = cmd.ExecuteReader())
                {
                    var fc = reader.FieldCount;
                    var row = new object[fc];

                    var ord_Id = reader.GetOrdinal("Id");
                    var ord_Mission = reader.GetOrdinal("Mission");
                    var ord_LaunchProvider = reader.GetOrdinal("LaunchProvider");
                    var ord_Rocket = reader.GetOrdinal("Rocket");
                    var ord_LaunchSite = reader.GetOrdinal("LaunchSite");
                    var ord_NET = reader.GetOrdinal("NET");
                    var ord_StageRecovery = reader.GetOrdinal("StageRecovery");
                    var ord_LaunchdateTime = reader.GetOrdinal("LaunchdateTime");

                    while (reader.Read())
                    {
                        // TODO: Unnecessary boxing?
                        // TODO: Two strategies, one for wide rows and one for narrow rows?
                        var afc = reader.GetValues(row);
                        if (afc != fc)
                        {
                            throw new Exception($"Expected {fc} fields but got {afc} fields");
                        }

                        var val_Id = (row[ord_Id] is DBNull) ? default_Id : ((System.Int64)row[ord_Id]);
                        var val_Mission = (row[ord_Mission] is DBNull) ? default_Mission : ((System.String)row[ord_Mission]);
                        var val_LaunchProvider = (row[ord_LaunchProvider] is DBNull) ? default_LaunchProvider : ((System.Int64)row[ord_LaunchProvider]);
                        var val_Rocket = (row[ord_Rocket] is DBNull) ? default_Rocket : ((System.Int64)row[ord_Rocket]);
                        var val_LaunchSite = (row[ord_LaunchSite] is DBNull) ? default_LaunchSite : ((System.Int64)row[ord_LaunchSite]);
                        var val_NET = (row[ord_NET] is DBNull) ? default_NET : ((System.String)row[ord_NET]);
                        var val_StageRecovery = (row[ord_StageRecovery] is DBNull) ? default_StageRecovery : ((System.Boolean)row[ord_StageRecovery]);
                        var val_LaunchdateTime = (row[ord_LaunchdateTime] is DBNull) ? default_LaunchdateTime : ((System.DateTime)row[ord_LaunchdateTime]);


                        yield return new Launch
                        {

                            Id = val_Id,
                            Mission = val_Mission,
                            LaunchProvider = val_LaunchProvider,
                            Rocket = val_Rocket,
                            LaunchSite = val_LaunchSite,
                            NET = val_NET,
                            StageRecovery = val_StageRecovery,
                            LaunchdateTime = val_LaunchdateTime,
 
                        };

                    }
                }
            }
        }
    }
    public class Rocket
    {
        public System.Int64 Id { get; set; }
        public System.String Name { get; set; }
        public override string ToString ()
        {
            var sb = new StringBuilder ();
            sb.Append ("{ Rocket ");
            sb.Append(", Id = ");
            sb.Append(Id);
            sb.Append(", Name = ");
            sb.Append(Name);
            sb.Append (" }");    
            return sb.ToString ();
        }   
    }

    public static partial class T4pper
    {
        public static IEnumerable<Rocket> TableScan_Rocket(
            this IDbConnection dbConnection)
        {
             System.Int64 default_Id = default;
             System.String default_Name = default;
   
           
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Rocket";
                using (var reader = cmd.ExecuteReader())
                {
                    var fc = reader.FieldCount;
                    var row = new object[fc];

                    var ord_Id = reader.GetOrdinal("Id");
                    var ord_Name = reader.GetOrdinal("Name");

                    while (reader.Read())
                    {
                        // TODO: Unnecessary boxing?
                        // TODO: Two strategies, one for wide rows and one for narrow rows?
                        var afc = reader.GetValues(row);
                        if (afc != fc)
                        {
                            throw new Exception($"Expected {fc} fields but got {afc} fields");
                        }

                        var val_Id = (row[ord_Id] is DBNull) ? default_Id : ((System.Int64)row[ord_Id]);
                        var val_Name = (row[ord_Name] is DBNull) ? default_Name : ((System.String)row[ord_Name]);


                        yield return new Rocket
                        {

                            Id = val_Id,
                            Name = val_Name,
 
                        };

                    }
                }
            }
        }
    }
    public class LaunchProvider
    {
        public System.Int64 Id { get; set; }
        public System.String Name { get; set; }
        public System.String Country { get; set; }
        public override string ToString ()
        {
            var sb = new StringBuilder ();
            sb.Append ("{ LaunchProvider ");
            sb.Append(", Id = ");
            sb.Append(Id);
            sb.Append(", Name = ");
            sb.Append(Name);
            sb.Append(", Country = ");
            sb.Append(Country);
            sb.Append (" }");    
            return sb.ToString ();
        }   
    }

    public static partial class T4pper
    {
        public static IEnumerable<LaunchProvider> TableScan_LaunchProvider(
            this IDbConnection dbConnection)
        {
             System.Int64 default_Id = default;
             System.String default_Name = default;
             System.String default_Country = default;
   
           
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM LaunchProvider";
                using (var reader = cmd.ExecuteReader())
                {
                    var fc = reader.FieldCount;
                    var row = new object[fc];

                    var ord_Id = reader.GetOrdinal("Id");
                    var ord_Name = reader.GetOrdinal("Name");
                    var ord_Country = reader.GetOrdinal("Country");

                    while (reader.Read())
                    {
                        // TODO: Unnecessary boxing?
                        // TODO: Two strategies, one for wide rows and one for narrow rows?
                        var afc = reader.GetValues(row);
                        if (afc != fc)
                        {
                            throw new Exception($"Expected {fc} fields but got {afc} fields");
                        }

                        var val_Id = (row[ord_Id] is DBNull) ? default_Id : ((System.Int64)row[ord_Id]);
                        var val_Name = (row[ord_Name] is DBNull) ? default_Name : ((System.String)row[ord_Name]);
                        var val_Country = (row[ord_Country] is DBNull) ? default_Country : ((System.String)row[ord_Country]);


                        yield return new LaunchProvider
                        {

                            Id = val_Id,
                            Name = val_Name,
                            Country = val_Country,
 
                        };

                    }
                }
            }
        }
    }
    public class LaunchSite
    {
        public System.Int64 Id { get; set; }
        public System.String Pad { get; set; }
        public System.String Location { get; set; }
        public override string ToString ()
        {
            var sb = new StringBuilder ();
            sb.Append ("{ LaunchSite ");
            sb.Append(", Id = ");
            sb.Append(Id);
            sb.Append(", Pad = ");
            sb.Append(Pad);
            sb.Append(", Location = ");
            sb.Append(Location);
            sb.Append (" }");    
            return sb.ToString ();
        }   
    }

    public static partial class T4pper
    {
        public static IEnumerable<LaunchSite> TableScan_LaunchSite(
            this IDbConnection dbConnection)
        {
             System.Int64 default_Id = default;
             System.String default_Pad = default;
             System.String default_Location = default;
   
           
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM LaunchSite";
                using (var reader = cmd.ExecuteReader())
                {
                    var fc = reader.FieldCount;
                    var row = new object[fc];

                    var ord_Id = reader.GetOrdinal("Id");
                    var ord_Pad = reader.GetOrdinal("Pad");
                    var ord_Location = reader.GetOrdinal("Location");

                    while (reader.Read())
                    {
                        // TODO: Unnecessary boxing?
                        // TODO: Two strategies, one for wide rows and one for narrow rows?
                        var afc = reader.GetValues(row);
                        if (afc != fc)
                        {
                            throw new Exception($"Expected {fc} fields but got {afc} fields");
                        }

                        var val_Id = (row[ord_Id] is DBNull) ? default_Id : ((System.Int64)row[ord_Id]);
                        var val_Pad = (row[ord_Pad] is DBNull) ? default_Pad : ((System.String)row[ord_Pad]);
                        var val_Location = (row[ord_Location] is DBNull) ? default_Location : ((System.String)row[ord_Location]);


                        yield return new LaunchSite
                        {

                            Id = val_Id,
                            Pad = val_Pad,
                            Location = val_Location,
 
                        };

                    }
                }
            }
        }
    }
}
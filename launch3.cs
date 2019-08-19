





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
        public static void Create_Launch( 
            this IDbConnection dbConnection, Launch rowData)
        {
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                var p_Mission = cmd.CreateParameter (); 
                p_Mission.ParameterName = "Mission";
                p_Mission.Value = rowData.Mission;
                p_Mission.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Mission);

                var p_LaunchProvider = cmd.CreateParameter (); 
                p_LaunchProvider.ParameterName = "LaunchProvider";
                p_LaunchProvider.Value = rowData.LaunchProvider;
                p_LaunchProvider.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_LaunchProvider);

                var p_Rocket = cmd.CreateParameter (); 
                p_Rocket.ParameterName = "Rocket";
                p_Rocket.Value = rowData.Rocket;
                p_Rocket.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Rocket);

                var p_LaunchSite = cmd.CreateParameter (); 
                p_LaunchSite.ParameterName = "LaunchSite";
                p_LaunchSite.Value = rowData.LaunchSite;
                p_LaunchSite.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_LaunchSite);

                var p_NET = cmd.CreateParameter (); 
                p_NET.ParameterName = "NET";
                p_NET.Value = rowData.NET;
                p_NET.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_NET);

                var p_StageRecovery = cmd.CreateParameter (); 
                p_StageRecovery.ParameterName = "StageRecovery";
                p_StageRecovery.Value = rowData.StageRecovery;
                p_StageRecovery.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_StageRecovery);

                var p_LaunchdateTime = cmd.CreateParameter (); 
                p_LaunchdateTime.ParameterName = "LaunchdateTime";
                p_LaunchdateTime.Value = rowData.LaunchdateTime;
                p_LaunchdateTime.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_LaunchdateTime);

 


                cmd.CommandText = "INSERT Launch(Mission, LaunchProvider, Rocket, LaunchSite, NET, StageRecovery, LaunchdateTime) VALUES(@Mission, @LaunchProvider, @Rocket, @LaunchSite, @NET, @StageRecovery, @LaunchdateTime)";
                cmd.ExecuteNonQuery();
                }
        }


        public static void Delete_Launch( 
            this IDbConnection dbConnection
            , System.Int64 val_Id 
            
            )
        {
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                var p_Id = cmd.CreateParameter ();
                p_Id.ParameterName = "Id";
                p_Id.Value = val_Id;
                p_Id.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Id);

 


                cmd.CommandText = "DELETE FROM Launch WHERE Id = @Id";
                cmd.ExecuteNonQuery();
            }
        }

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
        public static void Create_Rocket( 
            this IDbConnection dbConnection, Rocket rowData)
        {
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                var p_Name = cmd.CreateParameter (); 
                p_Name.ParameterName = "Name";
                p_Name.Value = rowData.Name;
                p_Name.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Name);

 


                cmd.CommandText = "INSERT Launch(Name) VALUES(@Name)";
                cmd.ExecuteNonQuery();
                }
        }


        public static void Delete_Rocket( 
            this IDbConnection dbConnection
            , System.Int64 val_Id 
            
            )
        {
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                var p_Id = cmd.CreateParameter ();
                p_Id.ParameterName = "Id";
                p_Id.Value = val_Id;
                p_Id.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Id);

 


                cmd.CommandText = "DELETE FROM Rocket WHERE Id = @Id";
                cmd.ExecuteNonQuery();
            }
        }

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
        public static void Create_LaunchProvider( 
            this IDbConnection dbConnection, LaunchProvider rowData)
        {
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                var p_Name = cmd.CreateParameter (); 
                p_Name.ParameterName = "Name";
                p_Name.Value = rowData.Name;
                p_Name.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Name);

                var p_Country = cmd.CreateParameter (); 
                p_Country.ParameterName = "Country";
                p_Country.Value = rowData.Country;
                p_Country.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Country);

 


                cmd.CommandText = "INSERT Launch(Name, Country) VALUES(@Name, @Country)";
                cmd.ExecuteNonQuery();
                }
        }


        public static void Delete_LaunchProvider( 
            this IDbConnection dbConnection
            , System.Int64 val_Id 
            
            )
        {
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                var p_Id = cmd.CreateParameter ();
                p_Id.ParameterName = "Id";
                p_Id.Value = val_Id;
                p_Id.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Id);

 


                cmd.CommandText = "DELETE FROM LaunchProvider WHERE Id = @Id";
                cmd.ExecuteNonQuery();
            }
        }

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
        public static void Create_LaunchSite( 
            this IDbConnection dbConnection, LaunchSite rowData)
        {
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                var p_Pad = cmd.CreateParameter (); 
                p_Pad.ParameterName = "Pad";
                p_Pad.Value = rowData.Pad;
                p_Pad.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Pad);

                var p_Location = cmd.CreateParameter (); 
                p_Location.ParameterName = "Location";
                p_Location.Value = rowData.Location;
                p_Location.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Location);

 


                cmd.CommandText = "INSERT Launch(Pad, Location) VALUES(@Pad, @Location)";
                cmd.ExecuteNonQuery();
                }
        }


        public static void Delete_LaunchSite( 
            this IDbConnection dbConnection
            , System.Int64 val_Id 
            
            )
        {
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                var p_Id = cmd.CreateParameter ();
                p_Id.ParameterName = "Id";
                p_Id.Value = val_Id;
                p_Id.Direction = ParameterDirection.Input; 
                cmd.Parameters.Add(p_Id);

 


                cmd.CommandText = "DELETE FROM LaunchSite WHERE Id = @Id";
                cmd.ExecuteNonQuery();
            }
        }

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
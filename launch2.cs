

using System;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace DataRows
{

public static partial class Reader
{
    public static IEnumerable<Launch2> ReadLaunch2(this IDbConnection dbConnection, string query)
    {

            long default_Id = default;
            string default_Mission = default;
            DateTime default_LaunchDateTime = default;
            string default_NET = default;
            bool default_StageRecovery = default;
     
           
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
                    var ord_LaunchDateTime = reader.GetOrdinal("LaunchDateTime");
                    var ord_NET = reader.GetOrdinal("NET");
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

                        var val_Id = (row[ord_Id] is DBNull) ? default_Id : ((long)row[ord_Id]);
                        var val_Mission = (row[ord_Mission] is DBNull) ? default_Mission : ((string)row[ord_Mission]);
                        var val_LaunchDateTime = (row[ord_LaunchDateTime] is DBNull) ? default_LaunchDateTime : ((DateTime)row[ord_LaunchDateTime]);
                        var val_NET = (row[ord_NET] is DBNull) ? default_NET : ((string)row[ord_NET]);
                        var val_StageRecovery = (row[ord_StageRecovery] is DBNull) ? default_StageRecovery : ((bool)row[ord_StageRecovery]);
                        
                        yield return new Launch2
                        {
                            Id = val_Id,
                            Mission = val_Mission,
                            LaunchDateTime = val_LaunchDateTime,
                            NET = val_NET,
                            StageRecovery = val_StageRecovery,
  
                        };

                    }
                }
            }
        }
}


    public class Launch2
    {
        public override string ToString ()
        {
            var sb = new StringBuilder ();

            sb.Append ("{ Launch2 ");
            sb.Append(", Id = ");
            sb.Append(Id);
             sb.Append(", Mission = ");
            sb.Append(Mission);
             sb.Append(", LaunchDateTime = ");
            sb.Append(LaunchDateTime);
             sb.Append(", NET = ");
            sb.Append(NET);
             sb.Append(", StageRecovery = ");
            sb.Append(StageRecovery);
            
            sb.Append (" }");
            
            return sb.ToString ();
        }
    public long Id { get; set;}
    public string Mission { get; set;}
    public DateTime LaunchDateTime { get; set;}
    public string NET { get; set;}
    public bool StageRecovery { get; set;}
    }
}


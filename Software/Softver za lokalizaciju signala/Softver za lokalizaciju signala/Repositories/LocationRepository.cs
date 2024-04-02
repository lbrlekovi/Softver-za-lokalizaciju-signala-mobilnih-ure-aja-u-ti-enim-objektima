using DBLayer;
using Softver_za_lokalizaciju_signala.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softver_za_lokalizaciju_signala.Repositories
{
    internal class LocationRepository
    {
        public static Location GetLocation(int id)
        {
            DB.SetConfiguration("lbrlekovi20_DB", "lbrlekovi20", "G}ex!}H0");
            Location location = null;
            string sql = $"SELECT * FROM Lokacije WHERE ID_Lokacije = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                location = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return location;
        }
        public static List<Location> GetLocations()
        {
            DB.SetConfiguration("lbrlekovi20_DB", "lbrlekovi20", "G}ex!}H0");
            List<Location> locations = new List<Location>();
            string sql = $"SELECT * FROM Lokacije";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Location location = CreateObject(reader);
                locations.Add(location);
            }
            reader.Close();
            DB.CloseConnection();
            return locations;
        }
        private static Location CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_Lokacije"].ToString());
            string naziv = reader["Naziv"].ToString();
            string opis = reader["Opis"].ToString();
            int lokacijaX = Int32.Parse(reader["LokacijaX"].ToString());
            int lokacijaY = Int32.Parse(reader["LokacijaY"].ToString());

            var lokacija = new Location
            {
                Id = id,
                Naziv = naziv,
                Opis = opis,
                LokacijaX = lokacijaX,
                LokacijaY = lokacijaY
            };

            return lokacija;
        }
    }
}

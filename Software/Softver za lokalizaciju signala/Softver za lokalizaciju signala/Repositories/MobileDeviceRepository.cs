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
    public class MobileDeviceRepository
    {
        public static MobileDevice GetMobileDevice(int id)
        {
            DB.SetConfiguration("lbrlekovi20_DB", "lbrlekovi20", "G}ex!}H0");
            MobileDevice mobileDevice = null;
            string sql = $"SELECT * FROM MobilniUredjaj WHERE ID_Mobitela = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                mobileDevice = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return mobileDevice;
        }
        public static List<MobileDevice> GetMobileDevices()
        {
            DB.SetConfiguration("lbrlekovi20_DB", "lbrlekovi20", "G}ex!}H0");
            List<MobileDevice> mobileDevices = new List<MobileDevice>();
            string sql = $"SELECT * FROM MobilniUredjaj";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                MobileDevice mobileDevice = CreateObject(reader);
                mobileDevices.Add(mobileDevice);
            }
            reader.Close();
            DB.CloseConnection();
            return mobileDevices;
        }
        private static MobileDevice CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_Mobitela"].ToString());
            int lokacija = Int32.Parse(reader["Lokacija"].ToString());
            int vlasnik = Int32.Parse(reader["Vlasnik"].ToString());
            bool dozvoljen = bool.Parse(reader["Dozvoljen"].ToString());

            var mobileDevice = new MobileDevice
            {
                Id = id,
                Lokacija = lokacija,
                Vlasnik = vlasnik,
                Dozvoljen = dozvoljen
            };

            return mobileDevice;
        }
    }
}

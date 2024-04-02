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
    internal class PersonRepository
    {
        public static Person GetPerson(int id)
        {
            DB.SetConfiguration("lbrlekovi20_DB", "lbrlekovi20", "G}ex!}H0");
            Person person = null;
            string sql = $"SELECT * FROM Osobe WHERE ID_Osobe = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                person = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return person;
        }
        public static List<Person> GetPeople()
        {
            DB.SetConfiguration("lbrlekovi20_DB", "lbrlekovi20", "G}ex!}H0");
            List<Person> people = new List<Person>();
            string sql = $"SELECT * FROM Osobe";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Person person = CreateObject(reader);
                people.Add(person);
            }
            reader.Close();
            DB.CloseConnection();
            return people;
        }
        private static Person CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_Osobe"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            int brojPrekrsaja = Int32.Parse(reader["BrojPrekrsaja"].ToString());
            int uloga = Int32.Parse(reader["Uloga"].ToString());
            var person = new Person
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                BrojPrekrsaja = brojPrekrsaja,
                Uloga = uloga
            };

            return person;
        }
    }
}

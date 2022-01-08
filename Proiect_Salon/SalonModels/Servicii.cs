using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Proiect_Salon.SalonModels
{
    public class Servicii
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Denumire { get; set; }

        public decimal Pret { get; set; }

        public TimeSpan Timp_Executie { get; set; }

    }
}

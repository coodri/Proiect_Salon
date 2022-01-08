using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_Salon.SalonModels
{
    public class Recenzii
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume_si_prenume { get; set; }
        public string Recenzie { get; set; }
        public int Nota_angajat { get; set; }
        public int Nota_serviciu { get; set; }
        public string Serviciu { get; set; }
        public DateTime Date { get; set; }
    }
}

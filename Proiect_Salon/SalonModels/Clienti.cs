using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proiect_Salon.SalonModels
{
    public class Clienti
    {
        [PrimaryKey, AutoIncrement]
        public int Id_client { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }

        [Column("E-mail")]
        public string E_mail { get; set; }
        public string Parola { get; set; }

    }
}

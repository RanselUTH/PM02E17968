using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PM02E10052.Models
{
  public  class Sitios
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public decimal latitud { get; set; }
        public decimal longitud { get; set; }
        public string descripcion { get; set; }
        public string image { get; set; }
    }
}

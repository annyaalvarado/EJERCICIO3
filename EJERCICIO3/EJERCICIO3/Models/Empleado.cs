using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO3.Models
{
    public class Empleado
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string nombre { get; set; }

        [MaxLength(100)]
        public string apellidos { get; set; }

        public int edad { set; get; }
        public string correo { set; get; }
        public string direccion { set; get; }
    }
}

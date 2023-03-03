using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Tarea3.MODEL
{
    class Personas
    {
        [PrimaryKey, AutoIncrement] 
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nombres { get; set; }

        [MaxLength(100)]
        public string Apellidos { get; set; }

        public int  Edad { get; set; }

        [MaxLength(100)]
        public string correo { get; set; }

        [MaxLength(150)]
        public string Direccion { get; set; }
    }
}

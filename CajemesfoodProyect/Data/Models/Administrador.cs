using System.Collections.Generic;

namespace CajemesfoodProyect.Data.Models
{
    public class Administrador
    {
        public int id { get; set; }
        public string nombre { get; set; }

        // Clave foránea para relacionar con Local
        public int? LocalId { get; set; }

        // Propiedad de navegación hacia Local
        public Local Local { get; set; }
    }

}


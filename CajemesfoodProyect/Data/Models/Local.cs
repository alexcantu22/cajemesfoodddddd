using System.Collections.Generic;

namespace CajemesfoodProyect.Data.Models
{
    public class Local
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }


        // Propiedades de navegación existentes
        public List<platillos_Local> platillos_Locals { get; set; }
        public List<Local_proveedor>? localProveedors { get; set; }

        // Nueva propiedad de navegación para varios administradores
        public List<Administrador>? administradors { get; set; }
    }

}

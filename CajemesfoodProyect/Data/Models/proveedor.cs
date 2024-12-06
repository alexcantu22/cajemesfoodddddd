using System.Collections.Generic;

namespace CajemesfoodProyect.Data.Models
{
    public class proveedor
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public List<Local_proveedor> localProveedors { get; set; }

    }
}

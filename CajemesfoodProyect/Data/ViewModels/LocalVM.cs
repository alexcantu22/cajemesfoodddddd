using CajemesfoodProyect.Data.Models;
using System.Collections.Generic;

namespace CajemesfoodProyect.Data.ViewModels
{
    public class LocalVM
    {
      
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        // Lista de IDs de los proveedores asociados
        public List<int> proveedorIDs { get; set; } = new List<int>();

        // Lista de IDs de los administradores asociados
        public List<int> administradorIDs { get; set; } = new List<int>();
    }
}

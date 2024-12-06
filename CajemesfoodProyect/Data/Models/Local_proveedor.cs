using System;

namespace CajemesfoodProyect.Data.Models
{
    public class Local_proveedor
    {
        public int id { get; set; }

        public int localId { get; set; }

        public Local localid {  get; set; }

        public int proveedorId { get; set; }

        public proveedor proveedor { get; set; }

    }
}


using System;
using System.Collections.Generic;

namespace CajemesfoodProyect.Data.Models
{
    public class platillos
    {
     public int id { get; set; }

     public string nombre { get; set; }

     public int precio {  get; set; }

     public string descripcion { get; set; }

     public DateTime? caducidad {  get; set; }


        //Propiedades de navegación (en esta parte es donde mapeamos)
        public List<platillos_Local> platillos_Locals { get; set; }

    }
}

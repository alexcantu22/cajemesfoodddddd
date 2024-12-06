using CajemesfoodProyect.Data.Models;
using CajemesfoodProyect.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CajemesfoodProyect.Data.Services
{
    public class platillosService
    {

        private AppDbContext _context;

        public platillosService(AppDbContext context)
        {
            _context = context;
        }


        //metodo que nos permite agregar un nuevo platillo a la base de datos
        public void Addplatillo(platillosVM platillo)
        {
            var _platillo = new platillos()
            {
                nombre = platillo.nombre,
                precio = platillo.precio,
                descripcion = platillo.descripcion,
                caducidad = DateTime.Now
            };
            _context.platillos.Add(_platillo);
            _context.SaveChanges();
        }


        //metodo que nos permite obtener el platillo espeificamente
        public List<platillos> GetAllPlatillos() => _context.platillos.ToList();


        //metodo que nos permite obtener todos 
        public platillos GetAllPlatilloById(int platilloid) => _context.platillos.FirstOrDefault(n => n.id == platilloid);



        //Metodo que nos permite modificar un platillo de la base de datos

        public platillos UpdatePLatilloById(int platilloid, platillosVM platillos)
        {
            var _platillo = _context.platillos.FirstOrDefault(n =>n.id == platilloid);
            if(_platillo != null)
            {
                _platillo.nombre = platillos.nombre;
                _platillo.precio = platillos.precio;
                _platillo.descripcion = platillos.descripcion;

                _context.SaveChanges();
                
            }
           return _platillo;
        }

        public void DeletePlatilloById(int platilloid)
        {
            var _platillo = _context.platillos.FirstOrDefault(n => n.id == platilloid);
            if (_platillo != null)
            {
                _context.platillos.Remove(_platillo);
                _context.SaveChanges();
            }
        
        }
    }
}

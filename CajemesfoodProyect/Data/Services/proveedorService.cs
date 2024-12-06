using CajemesfoodProyect.Data.Models;
using CajemesfoodProyect.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace CajemesfoodProyect.Data.Services
{
    public class proveedorService
    {
        private AppDbContext _context;

        public proveedorService(AppDbContext context)
        {
            _context = context;
        }

        //metodo que nos permite agregar un nuevo proveedor a la base de datos
        public void AddProveedor(proveedorVM proveedor)
        {
            var _proveedor = new proveedor()
            {
                nombre = proveedor.nombre,
                direccion = proveedor.direccion,
                telefono = proveedor.telefono
            };

            _context.proveedors.Add(_proveedor);
            _context.SaveChanges();
        }
        //metodo que nos permite obtener el platillo espeificamente
        public List<proveedor> GetAllProveedor() => _context.proveedors.ToList();


        //metodo que nos permite obtener todos 
        public proveedor GetAllProveedorById(int proveedorid) => _context.proveedors.FirstOrDefault(n => n.id == proveedorid);



        //Metodo que nos permite modificar un platillo de la base de datos

        public proveedor UpdateProveedorById(int proveedorid, proveedorVM proveedor)
        {
            var _proveedor = _context.proveedors.FirstOrDefault(n => n.id == proveedorid);
            if (_proveedor != null)
            {
                _proveedor.nombre = proveedor.nombre;
                _proveedor.direccion = proveedor.direccion;
                _proveedor.telefono = proveedor.telefono;

                _context.SaveChanges();

            }
            return _proveedor;
        }

        public void DeleteProveedorById(int proveedorid)
        {
            var _proveedor = _context.proveedors.FirstOrDefault(n => n.id == proveedorid);
            if (_proveedor != null)
            {
                _context.proveedors.Remove(_proveedor);
                _context.SaveChanges();
            }

        }
    }
}

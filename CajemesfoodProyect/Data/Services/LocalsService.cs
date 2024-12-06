using CajemesfoodProyect.Data.Models;
using CajemesfoodProyect.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CajemesfoodProyect.Data.Services
{
    public class LocalsService
    {
        private AppDbContext _context;

        public LocalsService(AppDbContext context)
        {
            _context = context;
        }

        //metodo que nos permite agregar un nuevo local a la base de datos
        public void AddLocalWithAdmins(LocalVM localVM)
        {
            // Crear el objeto Local
            var _local = new Local
            {
                nombre = localVM.nombre,
                direccion = localVM.direccion,
                telefono = localVM.telefono,
           
            };

            // Agregar el Local a la base de datos
            _context.local.Add(_local);
            _context.SaveChanges();

            // Relacionar el Local con los Administradores
            foreach (var adminId in localVM.administradorIDs)
            {
                var administrador = _context.administradors.FirstOrDefault(a => a.id == adminId);
                if (administrador != null)
                {
                    administrador.LocalId = _local.id; // Asignar relación
                }
            }

            // Relacionar el Local con los Proveedores
            foreach (var proveedorId in localVM.proveedorIDs)
            {
                var _localProveedor = new Local_proveedor
                {
                    localId = _local.id,
                    proveedorId = proveedorId
                };
                _context.localProveedors.Add(_localProveedor);
            }

            // Guardar todos los cambios
            _context.SaveChanges();
        }
        public List<Local> GetAllLocals() => _context.local.ToList();


        //metodo que nos permite obtener todos 
        public Local GetAlllocalById(int Localid) => _context.local.FirstOrDefault(n => n.id == Localid);

        
        public void DeletelocalById(int localid)
        {
            var _local = _context.local.FirstOrDefault(n => n.id == localid);
            if (_local != null)
            {
                _context.local.Remove(_local);
                _context.SaveChanges();
            }

        }
       


    }
}

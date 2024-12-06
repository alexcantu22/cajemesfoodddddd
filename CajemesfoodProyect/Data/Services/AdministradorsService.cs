using CajemesfoodProyect.Data.Models;
using CajemesfoodProyect.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace CajemesfoodProyect.Data.Services
{
    public class AdministradorsService
    {
        private AppDbContext _context;

        public AdministradorsService(AppDbContext context)
        {
            _context = context;
        }

        //metodo que nos permite agregar un nuevo administrador a la base de datos
        public void AddAdministrador(AdministradorVM administrador)
        {
            var _administrador = new Administrador()
            {
                nombre = administrador.nombre

            };

            _context.administradors.Add(_administrador);
            _context.SaveChanges();
        }
        public List<Administrador> GetAllAdmins() => _context.administradors.ToList();


        //metodo que nos permite obtener todos 
        public Administrador GetAllPlatilloById(int id) => _context.administradors.FirstOrDefault(n => n.id == id);

        public Administrador UpdateAdminById(int id, AdministradorVM administrador)
        {
            var _admin = _context.administradors.FirstOrDefault(n => n.id == id);
            if (_admin != null)
            {
                _admin.nombre = administrador.nombre;
               


                _context.SaveChanges();

            }
            return _admin;
        }

        public void DeleteadminById(int adminid)
        {
            var _admin = _context.administradors.FirstOrDefault(n => n.id == adminid);
            if (_admin != null)
            {
                _context.administradors.Remove(_admin);
                _context.SaveChanges();
            }

        }
    }
}
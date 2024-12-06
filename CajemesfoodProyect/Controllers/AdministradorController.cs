using CajemesfoodProyect.Data.Models;
using CajemesfoodProyect.Data.Services;
using CajemesfoodProyect.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CajemesfoodProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorController : ControllerBase
    {
        public AdministradorsService _administradorservice;

        public AdministradorController(AdministradorsService administradorSevice)
        {
            _administradorservice = administradorSevice;
        }

        [HttpGet("get-all-admins")]
        public IActionResult GetAllPlatillos()
        {
            var alladmins = _administradorservice.GetAllAdmins();
            return Ok(alladmins);
        }


        [HttpGet("get-Admins-By-Id/{id}")]
        public IActionResult GetPlatilloById(int id)
        {
            var administrador = _administradorservice.GetAllPlatilloById(id);
            return Ok(administrador);
        }


        [HttpPost("add-admins")]
        public IActionResult AddAdministrador([FromBody] AdministradorVM administrador)
        {
            _administradorservice.AddAdministrador(administrador);
            return Ok(administrador);
        }

        [HttpPut("update-admins")]

        public IActionResult UpdateAdminbyId(int id, [FromBody] AdministradorVM administrador)
        {
            var updateadmin = _administradorservice.UpdateAdminById(id, administrador);
            return Ok(updateadmin);



        }

        [HttpDelete("Delete-Admin-By-Id/{id}")]
        public IActionResult DeleteAdminById(int id)
        {
            _administradorservice.DeleteadminById(id);
            return Ok();
        }
    }
}

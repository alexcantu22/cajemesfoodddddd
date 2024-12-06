using CajemesfoodProyect.Data.Services;
using CajemesfoodProyect.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CajemesfoodProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        public proveedorService _proveedorService;

        public ProveedorController(proveedorService proveedorService)
        {
            _proveedorService = proveedorService;
        }

        [HttpGet("get-all-proveedors")]
        public IActionResult GetAllProveedors()
        {
            var allproveedors = _proveedorService.GetAllProveedor();
            return Ok(allproveedors);
        }


        [HttpGet("get-Proveedor-By-Id/{id}")]
        public IActionResult GetProveedorById(int id)
        {
            var proveedor = _proveedorService.GetAllProveedorById(id);
            return Ok(proveedor);
        }


        [HttpPost("add-proveedor")]
        public IActionResult AddProveedor([FromBody] proveedorVM proveedor)
        {
            _proveedorService.AddProveedor(proveedor);
            return Ok(proveedor);
        }


        [HttpPut("update-proveedeor-by-id/{id}")]
        public IActionResult UpdateProveedorById(int id, [FromBody] proveedorVM proveedor)
        {
            var updateproveedor = _proveedorService.UpdateProveedorById(id, proveedor);
            return Ok(updateproveedor);
        }

        [HttpDelete("Delete-proveedor-By-Id/{id}")]
        public IActionResult DeleteProveedorById(int id)
        {
            _proveedorService.DeleteProveedorById(id);
            return Ok();
        }

    }
}

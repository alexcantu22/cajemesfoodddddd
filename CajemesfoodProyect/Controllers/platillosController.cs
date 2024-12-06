using CajemesfoodProyect.Data.Services;
using CajemesfoodProyect.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CajemesfoodProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class platillosController : ControllerBase
    {
        public platillosService _platillosService;

        public platillosController(platillosService platillosService)
        {
            _platillosService = platillosService;
        }

        [HttpGet("get-all-platillos")]
        public IActionResult GetAllPlatillos()
        {
            var allplatillos = _platillosService.GetAllPlatillos();
            return Ok(allplatillos);
        }


        [HttpGet("get-Platillo-By-Id/{id}")]
        public IActionResult GetPlatilloById(int id)
        {
            var platillo = _platillosService.GetAllPlatilloById(id);
            return Ok(platillo);
        }


        [HttpPost("add-platillos")]
        public IActionResult Addplatillo([FromBody] platillosVM platillo)
        {
            _platillosService.Addplatillo(platillo);
            return Ok(platillo);
        }


        [HttpPut("update-platillo-by-id/{id}")]
        public IActionResult UpdatePlatilloById(int id, [FromBody] platillosVM platillo)
        {
            var updateplatillo = _platillosService.UpdatePLatilloById(id, platillo);
            return Ok(updateplatillo);
        }

        [HttpDelete("Delete-Platillo-By-Id/{id}")]
       public IActionResult DeletePlatilloById(int id) 
        {
            _platillosService.DeletePlatilloById(id);
            return Ok();
        }

    }
}

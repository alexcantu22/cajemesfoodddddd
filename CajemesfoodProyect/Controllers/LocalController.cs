using CajemesfoodProyect.Data.Services;
using CajemesfoodProyect.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CajemesfoodProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalController : ControllerBase
    {
        private LocalsService _localsService;

        public LocalController(LocalsService localsService)
        {
            _localsService = localsService;
        }

        [HttpPost("add-local")]
        public IActionResult AddLocalWithAdmins([FromBody] LocalVM local)
        {
            _localsService.AddLocalWithAdmins(local);
            return Ok(local);
        }
        [HttpGet("get-all-Locals")]
        public IActionResult GetAllPlatillos()
        {
            var alllocals = _localsService.GetAllLocals();
            return Ok(alllocals);
        }


        [HttpGet("{get-A}locals-By-Id/{id}")]
        public IActionResult GetPlatilloById(int id)
        {
            var local = _localsService.GetAlllocalById(id);
            return Ok(local);
        }


       
        [HttpDelete("Delete-local-By-Id/{id}")]
        public IActionResult DeletePlatilloById(int id)
        {
            _localsService.DeletelocalById(id);
            return Ok();
        }

    }

}

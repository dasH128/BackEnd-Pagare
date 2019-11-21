using Microsoft.AspNetCore.Mvc;
using Finanzas.Entity;
using Finanzas.Service.Interface;

namespace Finanzas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialController: ControllerBase
    {
        private IHistorialLetraService historialLetraService;
        public HistorialController(IHistorialLetraService historialLetraService){
            this.historialLetraService = historialLetraService;
        }

        [HttpPost]
        public ActionResult Post([FromBody] HistorialLetra historialLetra){
            return Ok(historialLetraService.Guardar(historialLetra));
        }
    }
}
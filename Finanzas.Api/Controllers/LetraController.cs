using Microsoft.AspNetCore.Mvc;
using Finanzas.Entity;
using Finanzas.Service.Interface;

namespace Finanzas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LetraController: ControllerBase
    {
        private ILetraService letraService;
        public LetraController(ILetraService letraService){
            this.letraService = letraService;
        }
        [HttpGet]
        public ActionResult Get(){
            return Ok(letraService.Listar());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Letra letra){
            return Ok(letraService.Guardar(letra));
        }

    }
}
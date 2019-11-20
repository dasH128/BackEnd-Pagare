using Microsoft.AspNetCore.Mvc;
using Finanzas.Entity;
using Finanzas.Service.Interface;

namespace Finanzas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiradoPersonaController: ControllerBase
    {
        private IGiradoPersonaService giradoPersonaService;
        public GiradoPersonaController(IGiradoPersonaService giradoPersonaService){
            this.giradoPersonaService = giradoPersonaService;
        }
    
        [HttpPost]
        public ActionResult Post([FromBody] GiradoPersona giradoPersona){
            return Ok(giradoPersonaService.Guardar(giradoPersona));
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Finanzas.Entity;
using Finanzas.Service.Interface;

namespace Finanzas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiradoController: ControllerBase
    {
        private IGiradoService giradoService;
        public GiradoController(IGiradoService giradoService){
            this.giradoService = giradoService;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Girado girado){
            return Ok(giradoService.Guardar(girado));
        }

        
        
    }
}
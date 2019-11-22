using Microsoft.AspNetCore.Mvc;
using Finanzas.Entity;
using Finanzas.Service.Interface;

namespace Finanzas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiradoEmpresaController: ControllerBase
    {
        private IGiradoEmpresaService giradoEmpresaService;
        public GiradoEmpresaController(IGiradoEmpresaService giradoEmpresaService){
            this.giradoEmpresaService = giradoEmpresaService;
        }

        [HttpPost]
        public ActionResult Post([FromBody] GiradoEmpresa giradoEmpresa){
            return Ok(giradoEmpresaService.Guardar(giradoEmpresa));
        }

        [HttpPost("insertar")]
        public ActionResult PostInsert([FromBody] GiradoEmpresa giradoEmpresa){
            return Ok(giradoEmpresaService.GiradoData(giradoEmpresa));
        }
    }
}
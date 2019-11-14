using Microsoft.AspNetCore.Mvc;
using Finanzas.Entity;
using Finanzas.Service.Interface;

namespace Finanzas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController: ControllerBase
    {
        private IUsuarioService usuarioService;
        public UsuarioController(IUsuarioService usuarioService){
            this.usuarioService = usuarioService;
        }


        [HttpGet]
        public ActionResult Get(){
            return Ok(usuarioService.Listar());
        }
        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario){
            return Ok(usuarioService.Guardar(usuario));
        }
        [HttpPut]
        public ActionResult Put([FromBody] Usuario usuario){
            return Ok(usuarioService.Actualizar(usuario));
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id){
            return Ok(usuarioService.Eliminar(id));
        }
        [HttpGet("id")]
        public ActionResult Get(int id){
            return Ok(usuarioService.ListarPorId(id));
        }

        [HttpPost("validate")]
        public ActionResult ValidarCuenta([FromBody] Usuario usuario){
            return Ok();
        }
    }
}
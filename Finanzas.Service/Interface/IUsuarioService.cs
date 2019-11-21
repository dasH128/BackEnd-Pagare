using Finanzas.Entity;

namespace Finanzas.Service.Interface
{
    public interface IUsuarioService: ICrudService<Usuario>
    {
        Usuario ValidarUsuario(string correo, string contrasena);
    }
}
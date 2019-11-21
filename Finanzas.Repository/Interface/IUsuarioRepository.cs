using Finanzas.Entity;

namespace Finanzas.Repository.Interface
{
    public interface IUsuarioRepository: ICrudRepository<Usuario>
    {
        Usuario ValidarUsuario(string correo, string contrasena);
    }
}
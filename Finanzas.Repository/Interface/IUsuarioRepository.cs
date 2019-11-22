using System.Collections.Generic;
using Finanzas.Entity;

namespace Finanzas.Repository.Interface
{
    public interface IUsuarioRepository: ICrudRepository<Usuario>
    {
        Usuario ValidarUsuario(string correo, string contrasena);

        IEnumerable<Departamento> ListarDepartamento();
        IEnumerable<Provincia> ListarProvincia(int idDepartamento);
        IEnumerable<Distrito> ListarDistrito(int idProvincia);
        IEnumerable<Moneda> ListarMoneda();
    }
}
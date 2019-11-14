using System.Collections.Generic;

namespace Finanzas.Repository.Interface
{
    public interface ICrudRepository<T>
    {
        bool Guardar(T entity);
        bool Actualizar(T entity);
        bool Eliminar(int id);
        IEnumerable<T> Listar();
        T ListarPorId(int id);
    }
}
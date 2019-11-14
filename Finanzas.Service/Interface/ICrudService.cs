using System.Collections.Generic;

namespace Finanzas.Service.Interface
{
    public interface ICrudService<T>
    {
        bool Guardar(T entity);
        bool Actualizar(T entity);
        bool Eliminar(int id);
        IEnumerable<T> Listar();
        T ListarPorId(int id);
    }
}
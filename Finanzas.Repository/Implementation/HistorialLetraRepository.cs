using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Context;
using Finanzas.Repository.Interface;

namespace Finanzas.Repository.Implementation
{
    public class HistorialLetraRepository : IHistorialLetraRepository
    {
        private ApplicationDbContext context;
        public HistorialLetraRepository(ApplicationDbContext context){
            this.context = context;
        }

        
        public bool Actualizar(HistorialLetra entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Guardar(HistorialLetra entity)
        {
            try{
                context.Add(entity);
                context.SaveChanges();
            }catch(System.Exception){
                return false;
            }
            return true;
        }

        public IEnumerable<HistorialLetra> Listar()
        {
            throw new System.NotImplementedException();
        }

        public HistorialLetra ListarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
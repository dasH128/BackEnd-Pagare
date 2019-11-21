using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Context;
using Finanzas.Repository.Interface;

namespace Finanzas.Repository.Implementation
{
    public class LetraRepository : ILetraRepository
    {
        private ApplicationDbContext context;
        public LetraRepository(ApplicationDbContext context){
            this.context = context;
        }


        public bool Actualizar(Letra entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Guardar(Letra entity)
        {
            try{
                context.Add(entity);
                context.SaveChanges();
            }catch(System.Exception){
                return false;
            }
            return true;
        }

        public IEnumerable<Letra> Listar()
        {
            throw new System.NotImplementedException();
        }

        public Letra ListarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
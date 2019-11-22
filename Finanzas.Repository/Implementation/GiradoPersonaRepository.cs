using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Context;
using Finanzas.Repository.Interface;

namespace Finanzas.Repository.Implementation
{
    public class GiradoPersonaRepository : IGiradoPersonaRepository
    {
        private ApplicationDbContext context;
        public GiradoPersonaRepository(ApplicationDbContext context){
            this.context = context;
        }


        public bool Actualizar(GiradoPersona entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

        

        public bool Guardar(GiradoPersona entity)
        {
            try{
                context.Add(entity);
                context.SaveChanges();
            }catch(System.Exception){
                return false;
            }
            return true;
        }

        public IEnumerable<GiradoPersona> Listar()
        {
            throw new System.NotImplementedException();
        }

        public GiradoPersona ListarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
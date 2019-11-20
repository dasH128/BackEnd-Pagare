using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Context;
using Finanzas.Repository.Interface;

namespace Finanzas.Repository.Implementation
{
    public class GiradoRepository : IGiradoRepository
    {
        private ApplicationDbContext context;
        public GiradoRepository(ApplicationDbContext context){
            this.context = context;
        }

        public bool Actualizar(Girado entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Guardar(Girado entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Girado> Listar()
        {
            throw new System.NotImplementedException();
        }

        public Girado ListarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
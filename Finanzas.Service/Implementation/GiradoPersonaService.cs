using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Interface;
using Finanzas.Service.Interface;

namespace Finanzas.Service.Implementation
{
    public class GiradoPersonaService : IGiradoPersonaService
    {
        private IGiradoPersonaRepository giradoPersonaRepository;
        public GiradoPersonaService(IGiradoPersonaRepository giradoPersonaRepository){
            this.giradoPersonaRepository=giradoPersonaRepository;
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
           return giradoPersonaRepository.Guardar(entity);
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
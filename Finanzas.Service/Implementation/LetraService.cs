using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Interface;
using Finanzas.Service.Interface;

namespace Finanzas.Service.Implementation
{
    public class LetraService : ILetraService
    {
        private ILetraRepository letraRepository;
        public LetraService(ILetraRepository letraRepository){
            this.letraRepository=letraRepository;
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
            return letraRepository.Guardar(entity);
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
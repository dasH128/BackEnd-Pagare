using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Interface;
using Finanzas.Service.Interface;

namespace Finanzas.Service.Implementation
{
    public class HistorialLetraService : IHistorialLetraService
    {
        private IHistorialLetraRepository historialLetraRepository;
        public HistorialLetraService(IHistorialLetraRepository historialLetraRepository){
            this.historialLetraRepository=historialLetraRepository;
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
            return historialLetraRepository.Guardar(entity);
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
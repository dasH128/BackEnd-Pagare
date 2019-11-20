using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Interface;
using Finanzas.Service.Interface;

namespace Finanzas.Service.Implementation
{
    public class GiradoService : IGiradoService
    {
        private IGiradoRepository giradoRepository;
        public GiradoService(IGiradoRepository giradoRepository){
            this.giradoRepository=giradoRepository;
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
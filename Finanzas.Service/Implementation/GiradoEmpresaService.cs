using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Interface;
using Finanzas.Service.Interface;

namespace Finanzas.Service.Implementation
{
    public class GiradoEmpresaService : IGiradoEmpresaService
    {
        private IGiradoEmpresaRepository giradoEmpresaRepository;
        public GiradoEmpresaService(IGiradoEmpresaRepository giradoEmpresaRepository){
            this.giradoEmpresaRepository=giradoEmpresaRepository;
        }


        public bool Actualizar(GiradoEmpresa entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Guardar(GiradoEmpresa entity)
        {
            return giradoEmpresaRepository.Guardar(entity);
        }

        public IEnumerable<GiradoEmpresa> Listar()
        {
            throw new System.NotImplementedException();
        }

        public GiradoEmpresa ListarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
        public GiradoEmpresa GiradoData(GiradoEmpresa giradoEmpresa){
            return giradoEmpresaRepository.GiradoData(giradoEmpresa);
        }
    }
}
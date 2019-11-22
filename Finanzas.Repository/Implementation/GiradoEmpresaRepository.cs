using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Context;
using Finanzas.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Finanzas.Repository.Implementation
{
    public class GiradoEmpresaRepository : IGiradoEmpresaRepository
    {
        private ApplicationDbContext context;
        public GiradoEmpresaRepository(ApplicationDbContext context){
            this.context = context;
        }


        public bool Actualizar(GiradoEmpresa entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

        public GiradoEmpresa GiradoData(GiradoEmpresa giradoEmpresa){
            var resultado = new GiradoEmpresa();
            try{
                context.Add(giradoEmpresa);
                context.SaveChanges();

                resultado = context.GiradoEmpresa.Include(i => i.Girado).Single(p=> p.Ruc == giradoEmpresa.Ruc);
            }catch(System.Exception){
                // return false;
            }
            return resultado;
        }

        public bool Guardar(GiradoEmpresa entity)
        {
            try{
                context.Add(entity);
                context.SaveChanges();
            }catch(System.Exception){
                return false;
            }
            return true;
        }

        public IEnumerable<GiradoEmpresa> Listar()
        {
            throw new System.NotImplementedException();
        }

        public GiradoEmpresa ListarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
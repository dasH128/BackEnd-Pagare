using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Context;
using Finanzas.Repository.Interface;
using Microsoft.EntityFrameworkCore;

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
            var resultado = new List<Letra>();

            try{
                resultado = context.Letra.Include(l =>l.Girado).Include(a =>a.Usuario).Include(m=>m.Moneda).ToList();
            }catch(System.Exception){
                throw;
            }
            return resultado;
        }

        public Letra ListarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
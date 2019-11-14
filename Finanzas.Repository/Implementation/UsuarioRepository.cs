using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Context;
using Finanzas.Repository.Interface;

namespace Finanzas.Repository.Implementation
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private ApplicationDbContext context;
        public UsuarioRepository(ApplicationDbContext context){
            this.context = context;
        }

        public bool Actualizar(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Guardar(Usuario entity)
        {
            try{
                context.Add(entity);
                context.SaveChanges();
            }catch(System.Exception){
                return false;
            }
            return true;
        }

        public IEnumerable<Usuario> Listar()
        {
            throw new System.NotImplementedException();
        }

        public Usuario ListarPorId(int id)
        {
            var resultado = new Usuario();

            try{
                resultado = context.Usuario.Single(e => e.Id == id);
            }catch(System.Exception){
                throw;
            }
            return resultado;
        }
    }
}
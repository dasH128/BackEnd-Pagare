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

        public Usuario ValidarUsuario(string correo, string contrasena)
        {
            var resultado = new Usuario();
            try{
                resultado = context.Usuario.Single(p => p.Correo == correo && p.Clave == contrasena);

            }catch(System.Exception){
                // throw;
            }
            return resultado;
        }

        public IEnumerable<Departamento> ListarDepartamento(){
            var resultado = new List<Departamento>();

            try{
                resultado = context.Departamento.ToList();
            }catch(System.Exception){
                throw;
            }
            return resultado;
        }

        public IEnumerable<Provincia> ListarProvincia(int idDepartamento){
            var resultado = new List<Provincia>();

            try{
                resultado = context.Provincia.Where(p=> p.DepartamentoId == idDepartamento).ToList();
            }catch(System.Exception){
                throw;
            }
            return resultado;
        }
        
        public IEnumerable<Distrito> ListarDistrito(int idProvincia){
            var resultado = new List<Distrito>();

            try{
                resultado = context.Distrito.Where(p=> p.ProvinciaId == idProvincia).ToList();
            }catch(System.Exception){
                throw;
            }
            return resultado;
        }

        public IEnumerable<Moneda> ListarMoneda(){
            var resultado = new List<Moneda>();

            try{
                resultado = context.Moneda.ToList();
            }catch(System.Exception){
                throw;
            }
            return resultado;
        }
    }
}
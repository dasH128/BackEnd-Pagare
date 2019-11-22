using System.Collections.Generic;
using System.Linq;
using Finanzas.Entity;
using Finanzas.Repository.Interface;
using Finanzas.Service.Interface;

namespace Finanzas.Service.Implementation
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository){
            this.usuarioRepository=usuarioRepository;
        }

        public bool Actualizar(Usuario entity)
        {
            return usuarioRepository.Actualizar(entity);
        }

        public bool Eliminar(int id)
        {
            return usuarioRepository.Eliminar(id);
        }

        public bool Guardar(Usuario entity)
        {
            return usuarioRepository.Guardar(entity);
        }

        public IEnumerable<Usuario> Listar()
        {
            return usuarioRepository.Listar();
        }

        public Usuario ListarPorId(int id)
        {
            return usuarioRepository.ListarPorId(id);
        }

        public Usuario ValidarUsuario(string correo, string contrasena)
        {
            return usuarioRepository.ValidarUsuario(correo, contrasena);
        }

        public IEnumerable<Departamento> ListarDepartamento(){
            return usuarioRepository.ListarDepartamento();
        }

        public IEnumerable<Provincia> ListarProvincia(int idDepartamento){
            return usuarioRepository.ListarProvincia(idDepartamento);
        }
        public IEnumerable<Distrito> ListarDistrito(int idProvincia){
            return usuarioRepository.ListarDistrito(idProvincia);
        }

        public  IEnumerable<Moneda> ListarMoneda(){
            return usuarioRepository.ListarMoneda();
        }
    }
}
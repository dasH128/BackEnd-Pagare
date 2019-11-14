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
    }
}
using api_c_.Data;
using api_c_.Models;
using api_c_.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_c_.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaDeTarefasDB _dbContext; 
        public UsuarioRepositorio(SistemaDeTarefasDB sistemaDeTarefas)
        {
            _dbContext = sistemaDeTarefas;
        }
     
        public async Task<UserModel> IUsuarioRepositorio.BuscarPorId(int id)
        {
            return await _dbContext.users.FirstOrDefaultAsync(x => x.Id == id);
        }

        Task<List<UserModel>> IUsuarioRepositorio.BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }
        Task<List<UserModel>> IUsuarioRepositorio.Adcionar(UserModel user)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUsuarioRepositorio.Apagar(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<UserModel>> IUsuarioRepositorio.Atualizar(UserModel user, int id)
        {
            throw new NotImplementedException();
        }

        
    }
}

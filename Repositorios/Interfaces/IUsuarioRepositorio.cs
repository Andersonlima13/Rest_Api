
using api_c_.Models;

namespace api_c_.Repositorios.Interfaces

{
    public interface IUsuarioRepositorio
    {
        Task<List<UserModel>>BuscarTodosUsuarios();
        Task<UserModel> BuscarPorId(int id);
        Task<List<UserModel>> Adcionar(UserModel user);
        Task<List<UserModel>> Atualizar(UserModel user, int id);

        Task<bool> Apagar(int id);



    }
}

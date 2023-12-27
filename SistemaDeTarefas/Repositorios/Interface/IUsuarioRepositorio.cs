using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interface
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> GetUsuarios();
        Task<UsuarioModel> GetId(int id);
        Task<UsuarioModel> Insert(UsuarioModel usuario);
        Task<UsuarioModel> Update(UsuarioModel usuario, int id);
        Task<bool> Delete(int id);
    }
}

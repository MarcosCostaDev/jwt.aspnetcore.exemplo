using Jwt.Exemplo.Domain.Command.Inputs;
using Jwt.Exemplo.Domain.Entities;

namespace Jwt.Exemplo.Domain.Repository
{
    public interface IUsuarioRepository
    {
        UsuarioEntity Login(LoginCommand command);
    }
}

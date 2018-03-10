using Flunt.Notifications;
using Jwt.Exemplo.Domain.Command.Inputs;
using Jwt.Exemplo.Domain.Entities;
using Jwt.Exemplo.Domain.Repository;

namespace Jwt.Exemplo.Infra.Repository
{
    public class UsuarioRepository : Notifiable, IUsuarioRepository
    {
        public UsuarioEntity Login(LoginCommand command)
        {
            var usuario = new UsuarioEntity(command.Usuario, command.Senha);
            AddNotifications(usuario);
            if (usuario.Usuario == "usuario" && usuario.Senha == "senha")
            {
                return usuario;
            }
            usuario.AddNotification("Usuario", "Usuario ou senha Inválido");
            return usuario;
        }
    }
}

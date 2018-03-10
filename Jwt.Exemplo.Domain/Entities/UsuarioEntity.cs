
using Flunt.Notifications;
using Flunt.Validations;

namespace Jwt.Exemplo.Domain.Entities
{
    public class UsuarioEntity : Notifiable
    {
        public UsuarioEntity(string usuario, string senha)
        {
            var contract = new Contract()
                .IsNotNullOrEmpty(usuario, "Usuario", "Usuário deve ser informado")
                .IsNotNullOrEmpty(senha, "Senha", "Senha deve ser informada");
            AddNotifications(contract);
            Usuario = usuario;
            Senha = senha;
        }

        public string Usuario { get; private set; }
        public string Senha { get; private set; }
    }
}

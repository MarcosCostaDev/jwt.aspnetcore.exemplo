using Jwt.Exemplo.Domain.Command.Inputs;
using Jwt.Exemplo.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Jwt.Exemplo.Authorize
{
    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        readonly Claim _claim;
        readonly IUsuarioRepository _usuarioRepository;
        public ClaimRequirementFilter(Claim claim, IUsuarioRepository usuarioRepository)
        {
            _claim = claim;
            _usuarioRepository = usuarioRepository;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var usuarioName = context.HttpContext.User.FindFirst("UsuarioName").Value;
            var usuario = _usuarioRepository.Permissao(new VerificarPermissaoCommand
            {
                Usuario = usuarioName,
                Permissao = _claim.Value
            });

            if (usuario.Invalid)
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}

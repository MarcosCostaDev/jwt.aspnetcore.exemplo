using Jwt.Exemplo.Authorize;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace jwt.exemplo.Authorize
{
    public class ClaimRequirementAttribute : TypeFilterAttribute
    {
        public ClaimRequirementAttribute(string claimValue) : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { new Claim("Permissao", claimValue) };
        }
    }
}
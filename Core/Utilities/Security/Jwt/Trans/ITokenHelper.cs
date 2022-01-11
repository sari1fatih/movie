using Core.Entities.Concrete;
using Core.Utilities.Security.Jwt.Entities;
using System.Collections.Generic;

namespace Core.Utilities.Security.Jwt.Trans
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}

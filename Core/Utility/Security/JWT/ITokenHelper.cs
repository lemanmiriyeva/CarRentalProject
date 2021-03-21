using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Concrete;

namespace Core.Utility.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}

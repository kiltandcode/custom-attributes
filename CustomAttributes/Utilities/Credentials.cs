using CustomAttributes.Attributes;
using System;

namespace CustomAttributes.Utilities
{
    [PermissionRequired("administrator")]
    [PermissionRequired("manager")]
    public class Credentials : ICredentials
    {
        public string[] GetCredentials()
        {
            throw new NotImplementedException();
        }
    }
}

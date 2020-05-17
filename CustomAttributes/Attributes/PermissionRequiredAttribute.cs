using System;

namespace CustomAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PermissionRequiredAttribute : Attribute
    {
        public PermissionRequiredAttribute(string permission)
        {
            Permission = permission;
        }

        public string Permission { get; }
    }
}

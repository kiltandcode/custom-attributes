using CustomAttributes.Attributes;
using CustomAttributes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What permissions are required for the {nameof(Credentials)} utility?");

            IEnumerable<string> permissions = 
                typeof(Credentials).GetCustomAttributes(
                    typeof(PermissionRequiredAttribute), true)
                        .Cast<PermissionRequiredAttribute>()
                        .Select(x => x.Permission);

            foreach (string permission in permissions)
            {
                Console.WriteLine($"Permission: {permission}");
            }

            Console.ReadLine();
        }
    }
}

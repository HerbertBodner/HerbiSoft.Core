using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace HerbiSoft.Core.CodeGenTemplates
{
    public class ClassReader
    {
        public static IEnumerable<Type> GetAllClassesFromAssembly(string absolutePathOfDll, string[] restrictedAssemblyNameLst = null)
        {
            if (!File.Exists(absolutePathOfDll))
            {
                throw new FileNotFoundException("File not found", absolutePathOfDll);
            }

            var assembly = Assembly.ReflectionOnlyLoadFrom(absolutePathOfDll);

            var types = assembly.GetTypes().Where(x => x.IsClass);

            if (restrictedAssemblyNameLst != null && restrictedAssemblyNameLst.Length > 0)
            {
                return
                    types.Where(
                        x => restrictedAssemblyNameLst.Any(y => String.Equals(x.Namespace, y, StringComparison.Ordinal)));
            }

            return types;
        }
    }
}

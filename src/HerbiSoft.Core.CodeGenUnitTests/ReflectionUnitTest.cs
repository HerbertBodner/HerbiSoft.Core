using System.IO;
using System.Linq;
using HerbiSoft.Core.CodeGenTemplates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HerbiSoft.Core.CodeGenUnitTests
{
    [TestClass]
    public class ReflectionUnitTest
    {
        const string AssemblyName = "HerbiSoft.Core.SampleModel";

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void AssemblyNotExists()
        {
            var absPathDll = Path.GetFullPath(Path.Combine(@"..\..\", AssemblyName, @"bin\Debug", AssemblyName + ".dll"));

            ClassReader.GetAllClassesFromAssembly(absPathDll);
        }


        [TestMethod]
        public void ReadClasses()
        {
            var absPathDll = Path.GetFullPath(Path.Combine(@"..\..\..\", AssemblyName, @"bin\Debug", AssemblyName + ".dll"));
            
            var classTypes = ClassReader.GetAllClassesFromAssembly(absPathDll, new[] { AssemblyName + ".Entities" }).ToList();

            Assert.AreNotEqual(null, classTypes.Count);
            Assert.AreEqual(4, classTypes.Count);

            Assert.IsNotNull(classTypes.FirstOrDefault(x => x.Name == "Person"));
            Assert.IsNotNull(classTypes.FirstOrDefault(x => x.Name == "Course"));
            Assert.IsNotNull(classTypes.FirstOrDefault(x => x.Name == "Student"));
            Assert.IsNotNull(classTypes.FirstOrDefault(x => x.Name == "Teacher"));
        }
    }
}

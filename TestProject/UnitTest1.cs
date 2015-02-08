using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace TestProject
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void TestMethod1()
      {
         var person = new Person("Sheldon");

         Assert.AreEqual(person.Name, "Sheldon");
      }
   }
}

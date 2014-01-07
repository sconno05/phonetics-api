using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phonetics;
using Phonetics.Controllers;

namespace Phonetics.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            PhoneticsController controller = new PhoneticsController();

            // Act
            IEnumerable<string> result = controller.Get(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("dog", result.ElementAt(0));
            Assert.AreEqual("cat", result.ElementAt(1));
        }
    }
}

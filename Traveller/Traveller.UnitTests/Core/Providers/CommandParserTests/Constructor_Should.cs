using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Core.Factories;
using Traveller.Core.Providers;

namespace Traveller.UnitTests.Core.Providers.CommandParserTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void ReturnsInstance_WhenParsesAreCorrect()
        {
            // Arrange
            var commandFactory = new Mock<ICommandFactory>();




            // Act
            var parse = new CommandParser(commandFactory.Object
                );

            // Assert
            Assert.IsNotNull(parse);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void ThrowException_WhencommandFactoryArgumentIsNull()
        {
            // Arrange
            var commandFactory = new Mock<ICommandFactory>();


            // Act & 

            var factoryNull = new CommandParser(null
                  );
            //Assert
            Assert.Fail();
        }
    }
}

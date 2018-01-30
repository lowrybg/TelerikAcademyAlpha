using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Commands.Creating;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Providers;

namespace Traveller.UnitTests.Creating.CreateTicketCommandTest
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void ReturnsInstance_WhenParametersAreCorrect()
        {
            // Arrange
            var factory = new Mock<ITravellerFactory>();
            var database = new Mock<IDatabase>();



            // Act
            var createTicket = new CreateTicketCommand(factory.Object,
                database.Object);

            // Assert
            Assert.IsNotNull(createTicket);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void ThrowException_WhenFactoryArgumentIsNull()
        {
            // Arrange
            var factory = new Mock<ITravellerFactory>();
            var database = new Mock<IDatabase>();

            // Act & 

            var factoryNull = new CreateTicketCommand(null,
                   database.Object);
            //Assert
            Assert.Fail();


        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void ThrowException_WhenDatabaseArgumentIsNull()
        {
            // Arrange
            var factory = new Mock<ITravellerFactory>();
            var database = new Mock<IDatabase>();

            // Act & 

            var factoryNull = new CreateTicketCommand(factory.Object,
                   null);
            //Assert
            Assert.Fail();
        }
    }
}

using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using FluentAssertions;

namespace MoqBasics.Test
{
    [TestFixture]
    public class BandControllerTest
    {
        [Test]
        public void Should_Return_ListOfBands()
        {
            Mock<IRepository> mockRepository = new Mock<IRepository>();

            var listOfBands = new List<Band>();
            listOfBands.Add(new Band { Name = "Bayside", Origin = "Queens, New York", Genre = "Alternative", BestSong = "I And I" });

            mockRepository.Setup(p => p.GetBands()).Returns(listOfBands);
            var controller = new BandController(mockRepository.Object);
            controller.Should().NotBeNull();

            var result = controller.GetBands();
            result.Should().Equal(listOfBands);
        }
    }
}
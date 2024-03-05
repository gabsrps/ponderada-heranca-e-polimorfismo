using Fusca.Dashboard.Repository;
using Fusca.Dashboard.Services.Stiba;
using Fusca.Dashboard.Services.ZenKlub;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Tests
{
    public class ZenKlubTest
    {
        private Mock<IZenKlubRepository> _mock;
        private IZenKlubService _zenKlubService;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IZenKlubRepository>();
            _zenKlubService = new ZenKlubService(_mock.Object);
        }

        [Test]
        public async Task TestGetTotalSessions()
        {
            var expectedResult = new ZenKlubModel() { TotalSessoes = 7146 };
            _mock.Setup(x => x.GetSessions()).ReturnsAsync(expectedResult);

            var result = await _zenKlubService.GetSessionsTotal();

            Assert.That(result.TotalSessoes, Is.Not.Null);
            Assert.That(result.TotalSessoes, Is.GreaterThan(-1));
            Assert.That(result.TotalSessoes, Is.TypeOf<int>());
        }

        [Test]
        public async Task TestGetSessionsFactory()
        {
        var expectedResult = new List<ZenKlubModel>
        {
            new ZenKlubModel
            {
                Departamento = "planta1",
                TotalSessoes = 5503,
            },
            new ZenKlubModel
            {
                Departamento = "planta2",
                TotalSessoes = 20,
            },
            new ZenKlubModel
            {
                Departamento = "planta3",
                TotalSessoes = 585,
            },
            new ZenKlubModel
            {
                Departamento = "planta4",
                TotalSessoes = 720,
            }
        };



            _mock.Setup(x => x.GetSessionsFactory()).ReturnsAsync(expectedResult);

            var result = await _zenKlubService.GetSessionsFactoryZenKlub();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<List<ZenKlubModel>>());
            foreach (var item in result)
            {
                Assert.That(item.Departamento, Is.Not.Null);
                Assert.That(item.TotalSessoes, Is.Not.Null);
            }

    }
    }
}

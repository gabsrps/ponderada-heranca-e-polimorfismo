using Moq;
using Fusca.Dashboard.Repository;
using Fusca.Dashboard.Services;
using Fusca.Dashboard.Services.Stiba;

namespace Fusca.Dashboard.Tests
{
    public class Tests
    {
        private Mock<IStibaRepository> _mock;
        private IStibaService _stibaService;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IStibaRepository>();
            _stibaService = new StibaService(_mock.Object);
        }

        [Test]
        public async Task TestParitipacaoSucess()
        {
            var expectedResult = new StibaInfoModel() { PorcentagemRespostas = 97 };
            _mock.Setup(x => x.RequisitarParticipacao()).ReturnsAsync(expectedResult);

            var result = await _stibaService.ObterParticipacao();

            Assert.That(result.PorcentagemRespostas, Is.Not.Null);
            Assert.That(result.PorcentagemRespostas, Is.LessThan(100));
        }

        //[Test]
        //public async Task TestParitipacaoError()
        //{
        //    var expectedResult = new StibaInfoModel() { PorcentagemRespostas = 103 };
        //    _mock.Setup(x => x.RequisitarParticipacao()).ReturnsAsync(expectedResult);

        //    var result = await _stibaService.ObterParticipacao();

        //    Assert.That(result.PorcentagemRespostas, Is.Not.Null);
        //    Assert.That(result.PorcentagemRespostas, Is.LessThan(100));
        //}

        [Test]
        public async Task TestRequisitarPesquisaStibaArea()
        {
            // Arrange
            var expectedResult = new List<StibaInfoModel>
    {
        new StibaInfoModel
        {
            OrigemResposta = "exc1",
            RespostasElegiveis = 47904,
            Respondentes = 45356,
            PorcentagemRespostas = 95,
            NotaStiba = "85,7"
        },
        new StibaInfoModel
        {
            OrigemResposta = "exArea2",
            RespostasElegiveis = 47876,
            Respondentes = 45328,
            PorcentagemRespostas = 95,
            NotaStiba = "85,7"
        },
        new StibaInfoModel
        {
            OrigemResposta = "exArea3",
            RespostasElegiveis = 20,
            Respondentes = 20,
            PorcentagemRespostas = 100,
            NotaStiba = "85,2"
        }
    };

            _mock.Setup(x => x.RequisitarPesquisaStibaArea()).ReturnsAsync(expectedResult);

            var result = await _stibaService.RequisitarPesquisaStibaArea();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<List<StibaInfoModel>>());
            Assert.That(result.Count, Is.EqualTo(expectedResult.Count));

        }


    }
}
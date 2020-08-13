using Domain.Clientes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Repository;
using Service.Clientes;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class ArgAny
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteService _clienteService;

        public ArgAny()
        {
            _clienteRepository = Substitute.For<IClienteRepository>();
            _clienteService = new ClienteService(_clienteRepository);
        }

        [TestMethod("Fazendo mock de métodos com Arg.Any<T>")]
        public void DicasDoMiltao()
        {
            //Arrange
            var mockClientesSC = new List<Cliente> { 
                new Cliente("Fritz", "Blumenau", "SC"),
                new Cliente("Frida", "Timbó", "SC"),
            };

            var mockClientesBA = new List<Cliente> { 
                new Cliente("Ivete Sangalo", "Salvador", "BA"),
                new Cliente("Caetano Veloso", "Santo Amaro", "BA"),
            };

            _clienteRepository.ObterClientesPorCidadeEstado(cidade: Arg.Any<string>(), estado: "SC").Returns(mockClientesSC);
            _clienteRepository.ObterClientesPorCidadeEstado(cidade: Arg.Any<string>(), estado: "BA").Returns(mockClientesBA);

            //Act
            var clientesSC = _clienteService.ObterClientesDaCidadeEstado("algumaCidade", "SC");
            var clientesBA = _clienteService.ObterClientesDaCidadeEstado("outraCidade", "BA");

            //Assert
            clientesSC.Should().BeEquivalentTo(mockClientesSC);
            clientesBA.Should().BeEquivalentTo(mockClientesBA);
        }

        [TestMethod("Fazendo mock de métodos com Arg.Any<T> / default")]
        public void DicasDoMiltaoB()
        {
            //Arrange
            var mockClientesSC = new List<Cliente> {
                new Cliente("Fritz", "Blumenau", "SC"),
                new Cliente("Frida", "Timbó", "SC"),
            };

            var mockClientesBA = new List<Cliente> {
                new Cliente("Ivete Sangalo", "Salvador", "BA"),
                new Cliente("Caetano Veloso", "Santo Amaro", "BA"),
            };

            _clienteRepository.ObterClientesPorCidadeEstado(cidade: Arg.Any<string>(), estado: "SC").Returns(mockClientesSC);
            _clienteRepository.ObterClientesPorCidadeEstado(cidade: Arg.Any<string>(), estado: "BA").Returns(mockClientesBA);

            //Act
            var clientesSC = _clienteService.ObterClientesDaCidadeEstado(default, "SC");
            var clientesBA = _clienteService.ObterClientesDaCidadeEstado(default, "BA");

            //Assert
            clientesSC.Should().BeEquivalentTo(mockClientesSC);
            clientesBA.Should().BeEquivalentTo(mockClientesBA);
        }
    }
}

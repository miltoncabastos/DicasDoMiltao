using Domain.Clientes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class DebuggerDisplay
    {
        [TestMethod("Demonstração de Debugger Display")]
        public void DemonstracaoDeDebuggerDisplay()
        {
            var cursos = new List<Cliente>
            {
                new Cliente(nome: "Miltao", cidade: "Salvador", estado: "BA"),
                new Cliente(nome: "Neymar Jr", cidade: "Mogi das Cruzes", estado: "SP"),
                new Cliente(nome: "Roberto Firmino", cidade: "Maceió", estado: "AL")
            };

            cursos.Should().HaveCount(3);
        }
    }
}

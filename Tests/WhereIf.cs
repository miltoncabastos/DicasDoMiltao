using Core;
using Domain.Clientes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class WhereIf
    {
        [TestMethod("Utilizando WhereIf para filtro LINQ em conjunto de dados")]
        [DataRow("Blumenau", 1)]
        [DataRow("", 2)]
        public void DicasDoMiltao(string cidadeParaPesquisa, int resultCount)
        {
            //Arrange 
            var cursos = new List<Cliente>
            {
                new Cliente(nome: "Gian", cidade: "Dr Pedrinho", estado: "SC"),
                new Cliente(nome: "Miltão", cidade: "Blumenau", estado: "SC")
            }.AsQueryable();

            var consultarCidade = !string.IsNullOrEmpty(cidadeParaPesquisa);

            // Como normalmente fazemos filtros
            var queryA = cursos.Where(x => x.Estado == "SC");
            if (consultarCidade)
                queryA = queryA.Where(x => x.Cidade == cidadeParaPesquisa);


            // Como podemos utilizar o WhereIf para facilitar
            var queryB = cursos
                .Where(x => x.Estado == "SC")
                .WhereIf(consultarCidade, x => x.Cidade == cidadeParaPesquisa);

            //Assert
            queryA.Should().HaveCount(resultCount);
            queryB.Should().HaveCount(resultCount);
        }
    }
}

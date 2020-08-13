using Domain.Cursos;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class TestandoColecoes
    {
        [TestMethod("Fluent Assertions - Testando Coleções")]
        public void CollectionAssert()
        {
            //Arrange 
            var cursosA = new List<Curso>
            {
                new Curso(nome: ".Net Core Iniciante", duracao: 4),
                new Curso(nome: "Testes de Unidade com C#", duracao: 6),
            };

            var cursosB = new List<Curso>
            {
                new Curso(nome: ".Net Core Iniciante", duracao: 4),
                new Curso(nome: "Testes de Unidade com C#", duracao: 6),
            };

            //Assert
            cursosA.Should().BeEquivalentTo(cursosB);
        }
    }
}

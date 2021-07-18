using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PokerComTDD.test
{
    public class AnalisadorDeVencedorTeste
    {
        private readonly Mock<IAnalisadorDeVencedorComMaiorCarta> _analisadorDeVencedorComMaiorCarta;
        private readonly Mock<IAnalisadorDeVencedorComParDeCartas> _analisadorDeVencedorComParDeCartas;
        private readonly AnalisadorDeVencedor _analisador;
        private readonly List<string> _cartasDoPrimeiroJogador;
        private readonly List<string> _cartasDoSegundoJogador;

        public AnalisadorDeVencedorTeste()
        {
            _analisadorDeVencedorComMaiorCarta = new Mock<IAnalisadorDeVencedorComMaiorCarta>();
            _analisadorDeVencedorComParDeCartas = new Mock<IAnalisadorDeVencedorComParDeCartas>();
            _analisador = new AnalisadorDeVencedor(_analisadorDeVencedorComMaiorCarta.Object, _analisadorDeVencedorComParDeCartas.Object);
            _cartasDoPrimeiroJogador = "2O,4C,3P,6C,7C".Split(',').ToList();
            _cartasDoSegundoJogador = "3O,5C,2E,9C,7P".Split(',').ToList();
        }

        [Fact]
        public void DeveAnalisarVencedorQueTemMaiorCarta()
        {
            _analisadorDeVencedorComMaiorCarta.Setup(analisador => analisador.Analisar(_cartasDoPrimeiroJogador, _cartasDoSegundoJogador)).Returns("Segundo Jogador");

            _analisador.Analisar(_cartasDoPrimeiroJogador, _cartasDoSegundoJogador);

            _analisadorDeVencedorComMaiorCarta.Verify(analisador => analisador.Analisar(_cartasDoPrimeiroJogador, _cartasDoSegundoJogador));
        }

        [Fact]
        public void DeveAnalisarVencedorQueTemParDeCartas()
        {
            _analisadorDeVencedorComParDeCartas.Setup(analisador => analisador.Analisar(_cartasDoPrimeiroJogador, _cartasDoSegundoJogador)).Returns("Segundo Jogador");

            _analisador.Analisar(_cartasDoPrimeiroJogador, _cartasDoSegundoJogador);

            _analisadorDeVencedorComParDeCartas.Verify(analisador => analisador.Analisar(_cartasDoPrimeiroJogador, _cartasDoSegundoJogador));
        }
        [Fact]
        public void NaoDeveAnalisarVencedorComMaiorCartaQuandoJogadaPar()
        {
            _analisadorDeVencedorComParDeCartas.Setup(analisador => analisador.Analisar(_cartasDoPrimeiroJogador, _cartasDoSegundoJogador)).Returns("Segundo Jogador");

            _analisador.Analisar(_cartasDoPrimeiroJogador, _cartasDoSegundoJogador);

            _analisadorDeVencedorComMaiorCarta.Verify(analisador => analisador.Analisar(_cartasDoPrimeiroJogador, _cartasDoSegundoJogador), Times.Never);
        }

    }
}
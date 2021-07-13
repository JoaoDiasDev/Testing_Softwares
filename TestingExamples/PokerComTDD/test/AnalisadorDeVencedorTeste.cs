using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PokerComTDD.test
{
    public class AnalisadorDeVencedorTeste
    {
        [Theory]
        [InlineData("20,4C,3P,6C,7C", "30,5C,2E,9C,7P", "Segundo Jogador")]
        [InlineData("30,5C,2E,9C,7P", "20,4C,3P,6C,7C", "Primeiro Jogador")]
        public void DeveAnalisarVencedorQuandoTiverMaiorCarta(string cartasDoPrimeiroJogadorString, string cartasDoSegundoJogadorString, string vencedorEsperado)
        {
            var cartasDoPrimeiroJogador = cartasDoPrimeiroJogadorString.Split(',').ToList();
            var cartasDoSegundoJogador = cartasDoSegundoJogadorString.Split(',').ToList();
            var analisador = new AnalisadorDeVencedor();

            var vencedor = analisador.Analisar(cartasDoPrimeiroJogador, cartasDoSegundoJogador);

            Assert.Equal(vencedorEsperado, vencedor);
        }
    }

    internal class AnalisadorDeVencedor
    {
        public AnalisadorDeVencedor()
        {

        }

        public string Analisar(List<string> cartasDoPrimeiroJogador, List<string> cartasDoSegundoJogador)
        {
            var maiorCartaDoPrimeiroJogador = cartasDoPrimeiroJogador.Select(carta => int.Parse(carta.Substring(0, 1)))
                                                                     .OrderBy(valorDaCarta => valorDaCarta)
                                                                     .Max();

            var maiorCartaDoSegundoJogador = cartasDoSegundoJogador.Select(carta => int.Parse(carta.Substring(0, 1)))
                                                                   .OrderBy(valorDaCarta => valorDaCarta)
                                                                   .Max();

            return maiorCartaDoPrimeiroJogador > maiorCartaDoSegundoJogador ? "Primeiro Jogador" : "Segundo Jogador";

        }
    }
}
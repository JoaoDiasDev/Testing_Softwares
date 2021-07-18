using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PokerComTDD.test
{
    public partial class CartaTeste
    {
        [Theory]
        [InlineData("A", "O", 14)]
        [InlineData("10", "E", 10)]
        [InlineData("2", "P", 2)]
        public void DeveCriarUmaCarta(string valorDaCarta, string naipeDaCarta, int peso)
        {
            var cartaEsperada = new
            {
                Valor = valorDaCarta,
                Naipe = naipeDaCarta,
                Peso = peso,
            };

            var carta = new Carta(cartaEsperada.Valor + cartaEsperada.Naipe);

            cartaEsperada.ToExpectedObject().ShouldMatch(carta);

        }

        [Theory]
        [InlineData("V", 11)]
        [InlineData("D", 12)]
        [InlineData("R", 13)]
        [InlineData("A", 14)]
        public void DeveCriarUmaCartaComPeso(string valorDaCarta, int pesoEsperado)
        {

            var carta = new Carta(valorDaCarta + "E");

            Assert.Equal(pesoEsperado, carta.Peso);

        }

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("15")]
        [InlineData("-1")]
        public void DeveValidarValorDaCarta(string valorDaCartaInvalido)
        {
            var mensagemDeErro = Assert.Throws<Exception>(() => new Carta(valorDaCartaInvalido + "O")).Message;
            Assert.Equal("Valor da carta inválida", mensagemDeErro);
        }

        [Theory]
        [InlineData("A")]
        [InlineData("Z")]
        public void DeveValidarNaipeDaCarta(string naipeDaCartaInvalido)
        {
            var mensagemDeErro = Assert.Throws<Exception>(() => new Carta("2" + naipeDaCartaInvalido)).Message;
            Assert.Equal("Naipe da carta inválido", mensagemDeErro);
        }
    }
}

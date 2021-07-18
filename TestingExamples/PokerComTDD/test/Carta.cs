using System;

namespace PokerComTDD.test
{
    public partial class CartaTeste
    {
        public class Carta

        {
            public string Valor { get; internal set; }
            public int Peso { get; internal set; }
            public string Naipe { get; internal set; }

            public Carta(string carta)
            {
                Naipe = carta.Substring(carta.Length - 1);
                Valor = carta.Replace(Naipe, string.Empty);

                if (Naipe != "O" && Naipe != "E" && Naipe != "P" && Naipe != "C")
                {
                    throw new Exception("Naipe da carta inválido");
                }

                ConverterParaPeso(Valor);

                if (Peso < 2 || Peso > 14)
                    throw new Exception("Valor da carta inválida");
            }

            private void ConverterParaPeso(string valorDaCarta)
            {
                if (!int.TryParse(valorDaCarta, out var valor))
                {
                    switch (valorDaCarta)
                    {
                        case "V":
                            valor = 11;
                            break;
                        case "D":
                            valor = 12;
                            break;
                        case "R":
                            valor = 13;
                            break;
                        case "A":
                            valor = 14;
                            break;
                    }
                }
                Peso = valor;
            }
        }
    }
}

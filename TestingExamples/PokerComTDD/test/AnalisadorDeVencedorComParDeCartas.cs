﻿using System;
using System.Collections.Generic;
using System.Linq;
using static PokerComTDD.test.CartaTeste;

namespace PokerComTDD.test
{
    public interface IAnalisadorDeVencedorComParDeCartas
    {
        string Analisar(List<string> cartasDoPrimeiroJogador, List<string> cartasDoSegundoJogador);
    }

    public class AnalisadorDeVencedorComParDeCartas
    {
        internal string Analisar(List<string> cartasDoPrimeiroJogador, List<string> cartasDoSegundoJogador)
        {
            var parDeCartasDoPrimeiroJogador = cartasDoPrimeiroJogador
                .Select(carta => new Carta(carta).Peso)
                .GroupBy(peso => peso)
                .Where(grupo => grupo.Count() > 1);


            var parDeCartasDoSegundoJogador = cartasDoSegundoJogador
                .Select(carta => new Carta(carta).Peso)
                .GroupBy(peso => peso)
                .Where(grupo => grupo.Count() > 1);

            if (parDeCartasDoPrimeiroJogador != null && parDeCartasDoPrimeiroJogador.Any() &&
                parDeCartasDoSegundoJogador != null && parDeCartasDoSegundoJogador.Any())
            {
                var maiorParDeCartasDoPrimeiroJogador = parDeCartasDoPrimeiroJogador.Select(valor => valor.Key).OrderBy(valor => valor).Max();
                var maiorParDeCartasDoSegundoJogador = parDeCartasDoSegundoJogador.Select(valor => valor.Key).OrderBy(valor => valor).Max();

                if (maiorParDeCartasDoPrimeiroJogador > maiorParDeCartasDoSegundoJogador)
                    return "Primeiro Jogador";
                else if (maiorParDeCartasDoSegundoJogador > maiorParDeCartasDoPrimeiroJogador)
                    return "Segundo Jogador";

            }


            else if (parDeCartasDoPrimeiroJogador != null && parDeCartasDoPrimeiroJogador.Any())
            {
                return "Primeiro Jogador";
            }

            else if (parDeCartasDoSegundoJogador != null && parDeCartasDoSegundoJogador.Any())
            {
                return "Segundo Jogador";
            }

            return null;

        }
    }
}

using System;
using System.Collections.Generic;

namespace CursoOnline.DominioTest.Cursos
{
    internal class Curso
    {
   

        public Curso(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, double valor)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("Nome Inválido");
            }

            if (cargaHoraria < 1)
            {
                throw new ArgumentException("Carga horária inválida");
            }

            if (valor < 1)
            {
                throw new ArgumentException("Valor inválido");
            }

            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }

        public string Nome { get; internal set; }
        public double CargaHoraria { get; internal set; }
        public double Valor { get; internal set; }
        public PublicoAlvo PublicoAlvo { get; internal set; }
    }
}
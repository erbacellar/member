using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace CashInBox
{
        enum PasswordScore
        {
            Blank = 0,
            VeryWeak = 1,
            Weak = 2,
            Medium = 3,
            Strong = 4,
            VeryStrong = 5
        }

        class ChecarForcaSenha
        {
            public static PasswordScore CheckStrength(string password)
            {
                int score = 0;
                int quantidadeMinimo = 4;
                int quantidadeMinusculo = 1;
                int quantidadeMaiusculo = 1;
                int quantidadeNumeros = 1;
                int quantidadeCaracteresEspeciais = 1;

                // Definição de letras minusculas
                Regex regTamanhoMinusculo = new Regex("[a-z]");

                // Definição de letras minusculas
                Regex regTamanhoMaiusculo = new Regex("[A-Z]");

                // Definição de letras minusculas
                Regex regTamanhoNumeros = new Regex("[0-9]");

                // Definição de letras minusculas
                Regex regCaracteresEspeciais = new Regex("[^a-zA-Z0-9]");

                // Verificando tamanho minimo
                if (password.Equals(""))
                    return PasswordScore.Blank;

                // Verificando tamanho minimo
                if (password.Length > quantidadeMinimo)
                    score++;

                // Verificando caracteres minusculos
                if (regTamanhoMinusculo.Matches(password).Count > quantidadeMinusculo)
                    score++;

                // Verificando caracteres maiusculos
                if (regTamanhoMaiusculo.Matches(password).Count >= quantidadeMaiusculo)
                    score++;

                // Verificando numeros
                if (regTamanhoNumeros.Matches(password).Count > quantidadeNumeros)
                    score++;

                // Verificando os diferentes
                if (regCaracteresEspeciais.Matches(password).Count >= quantidadeCaracteresEspeciais)
                    score++;

                return (PasswordScore)score;
            }

        }
}

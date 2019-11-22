using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    class NossoNumeroBoleto
    {

        #region Gerar valor para o campo "Nosso Numero" para boletos que permitam no max 14 casas

        public static string gerarNumero14Casas(string numCarteira, string numParcela, string numUnidade, string numOs)
        {
            return numParcela + formatarNumUnidade(numUnidade) + formatarNumOs14Casas(numOs);
        }

        #endregion

        #region Gerar valor para o campo "Nosso Numero" para boletos que permitam no max 12 casas

        public static string gerarNumero12Casas(string numCarteira, string numParcela, string numUnidade, string numOs)
        {
            return numParcela + formatarNumUnidade(numUnidade) + formatarNumOs12Casas(numOs);
        }

        #endregion

        #region Gerar valor para o campo "Nosso Numero" para boletos que permitam no max 11 casas

        public static string gerarNumero11Casas(string numCarteira, string numParcela, string numUnidade, string numOs)
        {
            return numParcela + formatarNumUnidade(numUnidade) + formatarNumOs11Casas(numOs);
        }

        #endregion

        #region Gerar valor para o campo "Nosso Numero" para boletos que permitam no max 10 casas

        public static string gerarNumero10Casas(string carteira, string numParcela, string numUnidade, string numOs)
        {
            return int.Parse(numParcela) + formatarNumUnidade(numUnidade) + formatarNumOs10Casas(numOs);
        }

        #endregion

        #region Gerar valor para o campo "Nosso Numero" para boletos que permitam no max 8 casas

        public static string gerarNumero8Casas(string carteira, string numParcela, string numUnidade, string numOs)
        {
            return int.Parse(numParcela) + numUnidade + formatarNumOs8Casas(numOs);
        }

        #endregion

        #region Gerar valor para o campo "Nosso Numero" para boletos que permitam no max 7 casas

        public static string gerarNumero7Casas(string carteira, string numParcela, string numUnidade, string numOs)
        {
            return int.Parse(numParcela) + numUnidade + formatarNumOs7Casas(numOs);
        }

        #endregion

        private static string formatarNumUnidade(string numUni)
        {
            int num = int.Parse(numUni);
            string numUnidadeFormatado = "";

            if (numUni.Length < 2)
            {
                numUnidadeFormatado = Utils.adicionarZerosEsquerda(num, 1);
            }
            else
            {
                numUnidadeFormatado = numUni;
            }

            return numUnidadeFormatado;
        }

        private static string formatarNumOs14Casas(string numOs)
        {
            int num = int.Parse(numOs);
            string numOsFormatado = "";


            if (numOs.Length == 10)
            {
                numOsFormatado = Utils.adicionarZerosEsquerda(num, 1);
            }
            else
            {
                if (numOs.Length == 9)
                {
                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 2);
                }
                else
                {
                    if (numOs.Length == 8)
                    {
                        numOsFormatado = Utils.adicionarZerosEsquerda(num, 3);
                    }
                    else
                    {
                        if (numOs.Length == 7)
                        {
                            numOsFormatado = Utils.adicionarZerosEsquerda(num, 4);
                        }
                        else
                        {
                            if (numOs.Length == 6)
                            {
                                numOsFormatado = Utils.adicionarZerosEsquerda(num, 5);
                            }
                            else
                            {

                                if (numOs.Length == 5)
                                {
                                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 6);
                                }
                                else
                                {
                                    if (numOs.Length == 4)
                                    {
                                        numOsFormatado = Utils.adicionarZerosEsquerda(num, 7);
                                    }
                                    else
                                    {
                                        if (numOs.Length == 3)
                                        {
                                            numOsFormatado = Utils.adicionarZerosEsquerda(num, 8);
                                        }
                                        else
                                        {
                                            if (numOs.Length == 2)
                                            {
                                                numOsFormatado = Utils.adicionarZerosEsquerda(num, 9);
                                            }
                                            else
                                            {
                                                if (numOs.Length == 1)
                                                {
                                                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 10);
                                                }
                                                else
                                                {
                                                    numOsFormatado = numOs;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return numOsFormatado;
        }

        private static string formatarNumOs12Casas(string numOs)
        {
            int num = int.Parse(numOs);
            string numOsFormatado = "";

            if (numOs.Length == 8)
            {
                numOsFormatado = Utils.adicionarZerosEsquerda(num, 1);
            }
            else
            {
                if (numOs.Length == 7)
                {
                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 2);
                }
                else
                {
                    if (numOs.Length == 6)
                    {
                        numOsFormatado = Utils.adicionarZerosEsquerda(num, 3);
                    }
                    else
                    {
                        if (numOs.Length == 5)
                        {
                            numOsFormatado = Utils.adicionarZerosEsquerda(num, 4);
                        }
                        else
                        {
                            if (numOs.Length == 4)
                            {
                                numOsFormatado = Utils.adicionarZerosEsquerda(num, 5);
                            }
                            else
                            {
                                if (numOs.Length == 3)
                                {
                                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 6);
                                }
                                else
                                {
                                    if (numOs.Length == 2)
                                    {
                                        numOsFormatado = Utils.adicionarZerosEsquerda(num, 7);
                                    }
                                    else
                                    {
                                        if (numOs.Length == 1)
                                        {
                                            numOsFormatado = Utils.adicionarZerosEsquerda(num, 8);
                                        }
                                        else
                                        {
                                            numOsFormatado = numOs;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return numOsFormatado;

        }

        private static string formatarNumOs11Casas(string numOs)
        {
            int num = int.Parse(numOs);
            string numOsFormatado = "";


            if (numOs.Length == 7)
            {
                numOsFormatado = Utils.adicionarZerosEsquerda(num, 1);
            }
            else
            {
                if (numOs.Length == 6)
                {
                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 2);
                }
                else
                {
                    if (numOs.Length == 5)
                    {
                        numOsFormatado = Utils.adicionarZerosEsquerda(num, 3);
                    }
                    else
                    {
                        if (numOs.Length == 4)
                        {
                            numOsFormatado = Utils.adicionarZerosEsquerda(num, 4);
                        }
                        else
                        {
                            if (numOs.Length == 3)
                            {
                                numOsFormatado = Utils.adicionarZerosEsquerda(num, 5);
                            }
                            else
                            {
                                if (numOs.Length == 2)
                                {
                                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 6);
                                }
                                else
                                {
                                    if (numOs.Length == 1)
                                    {
                                        numOsFormatado = Utils.adicionarZerosEsquerda(num, 7);
                                    }
                                    else
                                    {
                                        numOsFormatado = numOs;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return numOsFormatado;

        }

        private static string formatarNumOs10Casas(string numOs)
        {
            int num = int.Parse(numOs);
            string numOsFormatado = "";

            if (numOs.Length == 6)
            {
                numOsFormatado = Utils.adicionarZerosEsquerda(num, 1);
            }
            else
            {

                if (numOs.Length == 5)
                {
                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 2);
                }
                else
                {
                    if (numOs.Length == 4)
                    {
                        numOsFormatado = Utils.adicionarZerosEsquerda(num, 3);
                    }
                    else
                    {
                        if (numOs.Length == 3)
                        {
                            numOsFormatado = Utils.adicionarZerosEsquerda(num, 4);
                        }
                        else
                        {
                            if (numOs.Length == 2)
                            {
                                numOsFormatado = Utils.adicionarZerosEsquerda(num, 5);
                            }
                            else
                            {
                                if (numOs.Length == 1)
                                {
                                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 6);
                                }
                                else
                                {
                                    numOsFormatado = numOs;
                                }
                            }
                        }
                    }
                }
            }

            return numOsFormatado;
        }

        private static string formatarNumOs8Casas(string numOs)
        {
            int num = int.Parse(numOs);
            string numOsFormatado = "";


            if (numOs.Length == 5)
            {
                numOsFormatado = Utils.adicionarZerosEsquerda(num, 1);
            }
            else
            {
                if (numOs.Length == 4)
                {
                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 2);
                }
                else
                {
                    if (numOs.Length == 3)
                    {
                        numOsFormatado = Utils.adicionarZerosEsquerda(num, 3);
                    }
                    else
                    {
                        if (numOs.Length == 2)
                        {
                            numOsFormatado = Utils.adicionarZerosEsquerda(num, 4);
                        }
                        else
                        {
                            if (numOs.Length == 1)
                            {
                                numOsFormatado = Utils.adicionarZerosEsquerda(num, 5);
                            }
                            else
                            {
                                numOsFormatado = numOs;
                            }
                        }
                    }
                }
            }

            return numOsFormatado;
        }

        private static string formatarNumOs7Casas(string numOs)
        {
            int num = int.Parse(numOs);
            string numOsFormatado = "";


                if (numOs.Length == 4)
                {
                    numOsFormatado = Utils.adicionarZerosEsquerda(num, 1);
                }
                else
                {
                    if (numOs.Length == 3)
                    {
                        numOsFormatado = Utils.adicionarZerosEsquerda(num, 2);
                    }
                    else
                    {
                        if (numOs.Length == 2)
                        {
                            numOsFormatado = Utils.adicionarZerosEsquerda(num, 3);
                        }
                        else
                        {
                            if (numOs.Length == 1)
                            {
                                numOsFormatado = Utils.adicionarZerosEsquerda(num, 4);
                            }
                            else
                            {
                                numOsFormatado = numOs;
                            }
                        }
                    }
                }

            return numOsFormatado;
        }
    }
}

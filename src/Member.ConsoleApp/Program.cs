using Member.Common.Models;
using Member.Dao.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Member.ConsoleApp
{
    class Program
    {
        private static string path => @"C:/dados-membros.csv";

        static void Main(string[] args)
        {
            BulkInsertMembros();
        }


        private static List<string> ReadFromFile()
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                return lines.ToList();
            }

            return new List<string>();
        }

        private static List<Membro> ConvertFileToList()
        {
            var dados = ReadFromFile();
            List<Membro> membros = new List<Membro>();
            var count = 0;
            if (dados.Any())
            {

                foreach (var item in dados)
                {
                    string grupoDia, horario, dataNascimento, nome, cep, logradouro, numEnd, bairro, complemento, cidade, telefone1, telefone2, telefone3, email, cpf, rg, status, isento;

                    var infos = item.Split(';').ToList();
                    grupoDia = infos[0];
                    horario = infos[1];
                    dataNascimento = infos[2];
                    nome = infos[3];
                    cep = infos[4];
                    logradouro = infos[5];
                    numEnd = infos[6];
                    bairro = infos[7];
                    complemento = infos[8];
                    cidade = infos[9];
                    telefone1 = infos[10];
                    telefone2 = infos[11];
                    telefone3 = infos[12];
                    email = infos[13];
                    cpf = infos[14];
                    rg = infos[15];
                    status = infos[16];
                    isento = infos[17];


                    count = count + 1;
                    var membro = new Membro();
                    membro.Id = count;
                    membro.Numero = count.ToString();
                    membro.GrupoDia = grupoDia;
                    membro.GrupoHorario = horario;
                    membro.DataNascimento = !string.IsNullOrEmpty(dataNascimento) ? DateTime.Parse(dataNascimento) : DateTime.Now;
                    membro.DataEntrada = DateTime.Now;
                    membro.DataSaida = DateTime.Now;
                    membro.Nome = nome;
                    membro.Cep = cep;
                    membro.Logradouro = logradouro;
                    membro.NumEnd = numEnd;
                    membro.Bairro = bairro;
                    membro.Complemento = complemento;
                    membro.Cidade = cidade;
                    membro.Estado = "PR";
                    membro.Telefone1 = telefone1;
                    membro.Telefone2 = telefone2;
                    membro.Telefone3 = telefone3;
                    membro.Email = email;
                    membro.Cpf = cpf;
                    membro.Rg = rg;
                    membro.Status = status;
                    membro.Isento = !string.IsNullOrWhiteSpace(isento) ? isento == "0" ? false : true : false;

                    membros.Add(membro);
                }
            }

            return membros;
        }

        private static void BulkInsertMembros()
        {
            var membros = ConvertFileToList();

            Console.WriteLine($"Iniciando inclusao de {membros.Count} registros");
            var count = 0;
            foreach (var item in membros)
            {
                count = count + 1;
                Console.WriteLine($"Registro #{count}");
                var result = MembroDAO.Incluir(item).Result;
            }
            Console.WriteLine($"Finalizando inclusao de {membros.Count} registros");

            Console.ReadKey();
        }
    }
}

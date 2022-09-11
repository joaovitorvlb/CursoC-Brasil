// See https://aka.ms/new-console-template for more information
using Caelum.Stella.CSharp.Validation;
using Caelum.Stella.CSharp.Format;
using System;

namespace NumerosPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);

            string cnpj1 = "51241758000152";
            string cnpj2 = "14128481000127";

            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);

            string titulo1 = "041372570132";
            string titulo2 = "774387480130";

            ValidarTitulo(titulo1);
            ValidarTitulo(titulo2);

            Console.WriteLine(cpf1);
            string cpfFormatado = new CPFFormatter().Format(cpf1);
            Console.WriteLine(cpfFormatado);
            Console.WriteLine(new CPFFormatter().Format(cpfFormatado));
            Console.WriteLine(new CPFFormatter().Unformat(cpfFormatado));

            Console.WriteLine(cnpj1);
            Console.WriteLine(new CNPJFormatter().Format(cnpj1));

            Console.WriteLine(titulo1);
            Console.WriteLine(new TituloEleitoralFormatter().Format(titulo1));
        }
        
        private static void ValidarTitulo(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                Console.WriteLine("Título válido: " + titulo);
            }
            else
            {
                Console.WriteLine("Título inválido: " + titulo);
            }
        }

         private static void ValidarCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Console.WriteLine("CNPJ válido: " + cnpj);
            }
            else
            {
                Console.WriteLine("CNPJ inválido: " + cnpj);
            }
        }

         private static void ValidarCPF(string cpf)
        {
            if(new CPFValidator().IsValid(cpf))
            {
                Console.WriteLine("CPF válido: " + cpf);
            }
            else
            {
                Console.WriteLine("CPF inválido: " + cpf);
            }
        }
    }
}

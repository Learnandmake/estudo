﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiconsole.function
{
    class sessionine
    {
        public double calcareatriangulo(double baset, double alturat)
    {
            double resultado = (baset * alturat) / 2;
            return resultado;

    }

        public double calccircunferencia(double raio)
        {
        double pi = 3.14;
        double resultado = (pi * Math.Pow(raio, 2));

            return resultado;
        }

        public double calcperoctogono(double lado)
        {
            double resultado = lado * 8;

            return resultado;

        }

        

        public bool corprimaria (string cor)
        {
            bool resultado = false;
           if(cor =="amarelo"|| cor == "vermelho"||cor ==  "azul")
           {
                resultado = true;

           }

           else
           {
                resultado = false;
           }
            return resultado;
        }

        public string correprimaria (string cor1,string cor2)
        {
            string corresultante = "";
        if(cor1== "vermelho" && cor2 == "azul")
        {
                corresultante = "roxo";
         }
            if (cor1 == "azul" && cor2 == "amarelo")
            {
                corresultante = "verde";
           
            }

            if (cor1 == "vermelho" && cor2 == "amarelho")
            {
                corresultante = "laranja";
                
            }

            return corresultante;
        }

        
        
        public bool verificaridade (DateTime nascimento)
        { int ano = DateTime.Now.Year - nascimento.Year;
            bool resultado = false;
        if(ano >= 18 && nascimento.DayOfYear>=DateTime.Now.DayOfYear)
        {
                resultado = true;

        }

        else
        {
                resultado = false;
        }
            return resultado;

        }

        public bool verificarcpf (string cpf)
        {
            bool resultado = false;

            if(cpf.Length ==11)
            {
             resultado = true;
            }

            else
            {
                resultado = false;
            }

            return resultado;
        }

        public bool verificarsenha(string senha)
        {
            bool resultado = false;

            if(senha.Length>=8 && senha.Contains("!")== true && senha.Contains("@")==true && senha.Contains("#") == true && senha.Contains("$") == true && senha.Contains("%") == true && senha.Contains("&") == true && senha.Count()>0 && senha.Contains(" ")==false)
            { resultado = true; }

            else
            {
                resultado = false;
            }
            return resultado;
        }


    }
}

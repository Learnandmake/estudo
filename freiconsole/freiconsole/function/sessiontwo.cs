﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiconsole.function
{
    class sessiontwo
    {
        public int fmc(int idade)
        {
            int rfmc = 220 - idade;
            return rfmc;
        }

        public decimal imc(decimal peso, decimal altura)
        {
            decimal rimc = peso / (altura * altura);
            return rimc;
        }

        public decimal ingresso(decimal valor, int qtdinteira, int qtdmeia)
        {
            decimal vli = valor * qtdinteira;
            decimal vlm = (valor * qtdmeia) / 2;
            decimal resultado = vli + vlm;
            return resultado;

        }
        public string verificaridade(int idade)
        {
            string reidade = "";
            if (idade >= 18)
            {
                reidade = "sim";
                return reidade;
            }

            if (idade < 18)
            {
                reidade = "não";
                return reidade;
            }
            return reidade;
        }

        public string conselho(decimal nota)
        {
            string dica;
            if (0 <= 3)
            {
                dica = "Verifique os pontos de dificuldade antes de continuar.";
                return dica;
            }
            if (3 <= 5)
            {
                dica = "Trabalhe para entender os conceitos antes de programar.";
                return dica;
            }
            if (5 <= 8)
            {
                dica = "Trabalhe para entender os conceitos antes de programar.";
                return dica;
            }
            if (8 <= 10)
            {
                dica = " Treine com uma intensidade alta para ficar fluente e ágil.";
                return dica;
            }

            return dica;
        }

        public int calcalorias(int qcomida, int qbebida, int qsobremesa, string comida, string bebida, string sobremesa)
        {

            int ccomida = 0;
            int cbebida = 0;
            int csobremesa = 0;


            if (comida == "fast-food")
            {
                ccomida = 300 * qcomida;
            }
            if (comida == "churras")
            { ccomida = 400 * qcomida; }
            if (comida == "lanche-natural")
            { ccomida = 100 * qcomida; }

            if (bebida == "coca-cola")
            { cbebida = 200 * qbebida; }
            if (bebida == "suco-caixa")
            { cbebida = 150 * qbebida; }
            if (bebida == "suco-Natural")
            { cbebida = 80 * qbebida; }

            if (sobremesa == "açai")
            { csobremesa = 350 * qsobremesa; }
            if (sobremesa == "bolo")
            { csobremesa = 270 * qsobremesa; }
            if (sobremesa == "mousse")
            { csobremesa = 300 * qsobremesa; }

            int total = ccomida + cbebida + csobremesa;
            return total;

        }
        public int  contarhist (int ano)
        {
        

            while(ano<=2019)
            {
                ano++;
                Console.WriteLine(ano);
                return ano;    
            }
            
        }

        public void showhist(int ano)
        {
            string periodo = "";

            if (ano == 476)
            {
                Console.WriteLine( "Antiguidade-termino");

            }
            if (ano == -4000)
            {
                Console.WriteLine("Antiguidade-inicio");

            }


            if (ano == 477)
            {
                Console.WriteLine("idademedia-incio");

            }
            if (ano == 1453)
            {
                Console.WriteLine("idademedia-termino");

            }


            if (ano == 1454)
            {
                Console.WriteLine("idademoderna-incio");

            }
            if (ano == 1789)
            {
                Console.WriteLine("idademoderna-termino");

            }


            if (ano == 1790)
            {
                Console.WriteLine("idadecontemporanea-incio");

            }


          
        }

        public int tabuadaate100(int numero)
        {
            int tabuada = 0;
            int resultado = 0;

            while (tabuada <= 10)
            {
                resultado = numero * tabuada;
                tabuada++;


            }

            return resultado;

        }

        public int tabuada2atelimite(int limite)
        {

            int numero = 1;
            int resultado = 0;
            while (resultado <= limite)
            {
                resultado = numero * 2;

            }
            return resultado;
        }


        public bool imparoupa(decimal numero)
        {
            numero = Math.Ceiling(numero);
            bool par = false;
            decimal resto = numero % 2;

            if (resto == 0)
            {
                par = true;

            }

            if (resto == 0)
            {
                par = false;

            }

            return par;
        }

        public decimal arredondartemperatura(decimal numero)
        {
            decimal resultado = Math.Round(numero, 2);

            return resultado;

        }

        public double calcularhipotenusa(double cateto1, double cateto2)
        { double cateto3 = Math.Pow(cateto1,2);
            double cateto4 = Math.Pow(cateto2, 2);

            double somadocateto = cateto3 + cateto4;

            double raiz = Math.Sqrt(somadocateto);

            return raiz;
             }

             public string  calbaskhara( double a,double b,double c )
              {
            double delta = ((Math.Pow(b, 2)) - 4 * a * c);

            double xp = ((-b + (Math.Sqrt(delta)) / 2*a));

            double xn = ((-b + (Math.Sqrt(delta)) / 2 * a));

            string resultado = "O resultado positivo é " + Convert.ToString(xp) + " E o negativo é: " + Convert.ToString(xn) + ".";

            return resultado;
        }

     
        }
        }

    

      
  
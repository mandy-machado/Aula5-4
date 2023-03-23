using System;

namespace Aula5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] produto = new string[10];
            int[] estoque = new int[10];
            double[] preco = new double[10];
            string[] codigo = new string[10];
            string compra = "";
            int quantidade;

            produto[0] = "Baseball Cap ";
            produto[1] = "Bucket Hat   ";
            produto[2] = "Scarf        ";
            produto[3] = "Home Kit     ";
            produto[4] = "Away Kit     ";
            produto[5] = "Trainning Kit";
            produto[6] = "Pullover     ";
            produto[7] = "Coach Kit    ";
            produto[8] = "Socks        ";
            produto[9] = "Hoodie       ";

            for (int y = 0; y < 10; y++)
            {
                estoque[y] = 10;
            }
            
            preco[0] = 30.00;
            preco[1] = 28.00;
            preco[2] = 40.00;
            preco[3] = 80.00;
            preco[4] = 80.00;
            preco[5] = 75.00;
            preco[6] = 100.00;
            preco[7] = 90.00;
            preco[8] = 15.00;
            preco[9] = 120.00;

            codigo[0] = "RMD001";
            codigo[1] = "RMD002";
            codigo[2] = "RMD003";
            codigo[3] = "RMD004";
            codigo[4] = "RMD005";
            codigo[5] = "RMD006";
            codigo[6] = "RMD007";
            codigo[7] = "RMD008";
            codigo[8] = "RMD009";
            codigo[9] = "RMD010";


            Console.WriteLine("LOJA RICHMOND");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("CODIGO  PRODUTO         ESTOQUE PREÇO");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(codigo[i] + "\t" + produto[i] + "\t" + estoque[i] + "\t" + preco[i]);
            }

            Console.WriteLine("-------------------------------------");
            Console.Write("Digite o código do Produto :");
            compra = Console.ReadLine().ToUpper();

            for (int x = 0; x < 10; x++)
            {
                if (compra == codigo[x])
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("CODIGO  PRODUTO         ESTOQUE PREÇO");
                    Console.WriteLine(codigo[x] + "\t" + produto[x] + "\t" + estoque[x] + "\t" + preco[x]);
                    Console.WriteLine(" ");
                    Console.Write("Quantos produtos você quer comprar? ");
                    quantidade = int.Parse(Console.ReadLine());

                    estoque[x] = estoque[x] - quantidade;

                    Console.WriteLine(" ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("CODIGO  PRODUTO         ESTOQUE VALOR TOTAL");
                    Console.WriteLine(codigo[x] + "\t" + produto[x] + "\t" + estoque[x] + "\t" + (preco[x] * quantidade));
                    Console.WriteLine(" ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("CODIGO  PRODUTO         ESTOQUE PREÇO");
                    
                    for (int y = 0; y < 10; y++)
                    {
                        Console.WriteLine(codigo[y] + "\t" + produto[y] + "\t" + estoque[y] + "\t" + preco[y]);
                    }
                    
                }

                
            }
        }
    }
}

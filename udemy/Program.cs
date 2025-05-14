using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados dos produtos: ");

        }
    }
}







/*

Numero ímpares antes do numero informado:

Console.Write("Digite um numero: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Números ímpares antes de " +numero + ":");

for (int i = 1; i < numero; i += 2){
    Console.WriteLine(i);
}




Estrutura for: 

Console.Write("Quantos numeros inteiros você vai digitar? ");
int N = int.Parse(Console.ReadLine());

/* o for = Inicio / condição / incremento */
/*int soma = 0;

for (int i = 1; i <= N; i++){
    Console.Write("Valor #{0}: ", i);
    int valor = int.Parse(Console.ReadLine());
    soma += valor;
}

Console.WriteLine("Soma = " +soma);


Raiz quadrada :

Console.Write("Digite um numero: ");
double x = double.Parse(Console.ReadLine());

while (x > 0.0) {
    double raiz = Math.Sqrt(x);
    Console.WriteLine(raiz.ToString("F3"));
    Console.Write("Digite outro número: ");
    x = double.Parse(Console.ReadLine());
}

Console.WriteLine("Número negativo!!!!");


Maior de 3 numero:

Console.WriteLine("Digite 3 numero: ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

double resultado = Maior(n1, n2, n3);

Console.WriteLine("Maior = " + resultado);


static int Maior(int a, int b, int c){
    int m;
    if (a > b && a > c ) {
        m = a;
    }
    else if (b > c) {
        m = b;
    }
    else {
        m = c;
    }
    return m;
}

--------------------------------------------
Saber se é dia, tarde ou noite:


Console.WriteLine("Qual a hora atual? ");
int hora = int.Parse(Console.ReadLine());

if (hora < 12){
     Console.WriteLine("Bom dia!");
}
else if (hora <= 18){
    Console.WriteLine("Boa tarde!");
}

else{
    Console.WriteLine("Boa noite!");
}

-----------------------------------------

/*bool c1 = 2 > 3 && 4 != 5;*/
/*Console.WriteLine(c1);*/

/*bool c2 = 2 > 3 || 4!= 5;*/
/*Console.WriteLine(c2);*/

/*bool c3 = ! (2>3) && 4 != 5;*/
/*Console.WriteLine(c3);*/
/*Console.WriteLine("-----------");*/

/*bool c4 = 10 < 5;*/
/*bool c5 = c2 || c3 && c4 ;*/
/*Console.WriteLine(c5);*/


/* ------------------------- */


/*int a = 10;*/
/*bool c1 = a < 10;*/ 
/*bool c2 = a < 20;*/
/*bool c3 = a > 10;*/
/*bool c4 = a > 5;*/
/*Console.WriteLine(c1);*/
/*Console.WriteLine(c2);*/
/*Console.WriteLine(c3);*/
/*Console.WriteLine(c4);*/
/*Console.WriteLine("-----------------");*/

/*bool c5 = a <= 10;*/
/*Console.WriteLine(c5);*/
/*bool c6 = a >= 10;*/
/*Console.WriteLine(c6);*/
/*bool c7 = a == 10;*/
/*Console.WriteLine(c7);*/
/*bool c8 = a != 10;*/
/*Console.WriteLine(c8);*/
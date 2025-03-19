//for (int i = 0; i <= 20; i++)
//{
//    Console.WriteLine(i);
//}

//int senha = 0;


//while (senha != 1234)
//{
//    Console.WriteLine("Digite a senha 1234: ");
//    senha = int.Parse(Console.ReadLine());

//}

//Console.WriteLine("Escolha um numero para ver sua tabuada: ");
//int numero = int.Parse(Console.ReadLine());

//Console.Clear();

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(numero*i);
//}

//Console.WriteLine("Digite um numero: ");
//int i = int.Parse(Console.ReadLine());

//for (; i >= 0; i -= 1)
//{
//    Console.WriteLine(i);
//}

//int nota = 0;
//int media = 0;
//int contagem = 0;

//while (nota <= 10 && nota >= 0)
//{
//    Console.WriteLine("Digite um numero ate errar");
//    nota = int.Parse(Console.ReadLine());

//    if (nota <= 10 && nota >= 0)
//    {
//        contagem += nota;
//        media += 1;
//    }

//}

//Console.WriteLine($"media das notas {contagem / media}");

//int numero;
//int contar = 0;
//int somar = 0;

//while (true)
//{
//    Console.WriteLine("Digite um numero ate errar");
//    numero = int.Parse(Console.ReadLine());

//    if (numero >= 0 && numero <= 10)
//    {
//        contar++;
//        somar += numero;
//    }
//    else
//    {
//        break;
//    }
//}

//Console.WriteLine($"a media das suas tentativas é {somar/contar}");

//int numero;
//int contagem = 0;

//while(true)
//{
//    Console.WriteLine("Digite um numero");
//    numero = int.Parse(Console.ReadLine());

//    if (numero > 0)
//    {
//        contagem += numero;
//    }
//    else
//    {
//        break;
//    }

//}

//Console.WriteLine($"A soma dos seus valores é {contagem}");

//Console.WriteLine("Digite um numero e vou verificar se é primo");
//int primo = int.Parse(Console.ReadLine());
//int contador = primo-1;
//int verif = 0;

//while (contador > 0)
//{
//    verif = primo % contador;

//    if (verif == 0)
//    {
//        Console.WriteLine("Seu numero nao é primo");
//        break;
//    }

//    contador -= 1;
//    Console.WriteLine(contador);

//    if (contador == 1)
//    {
//        Console.WriteLine("Seu numero é primo");
//        break;
//    }

//}
int idade = 0;
while (true)
{
	try
	{
		Console.WriteLine("Digite sua idade");
		idade = int.Parse(Console.ReadLine());
		Console.WriteLine(idade);
		break;
	}
	catch (ArgumentNullException)
	{
		Console.WriteLine("voce digitou um valor vazio");
	}
	catch (FormatException)
	{
		Console.WriteLine("permitido apenas numero");
	}
	catch (OverflowException)
	{
		Console.WriteLine("voce digitou um valor muito grande");
	}

}

//  I W B B
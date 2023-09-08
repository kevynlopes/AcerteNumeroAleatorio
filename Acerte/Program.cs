void acerteNumero()
{
    Random aleatorio = new Random();
    int numeroSecreto = aleatorio.Next(1, 101);
    int numero;
    Console.WriteLine(numeroSecreto);
    do
    {
        Console.WriteLine("Digite um numero de 1 a 100");
        numero = int.Parse(Console.ReadLine());
        
    } while (numero != numeroSecreto);
    Console.WriteLine("Voce acertou!");
}

acerteNumero();
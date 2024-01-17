Console.Write("Entre 3 e 10 números, digite quantos você deseja colocar na lista: ");
int n = int.Parse(Console.ReadLine());

List<float> numbers = new List<float>();

for (int i = 0; i < n; i++)
{
    Console.Write("Digite um número: ");
    string input = Console.ReadLine();
    if (float.TryParse(input, out float n1))
    {
        numbers.Add(n1);
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, insira números válidos");
        i--;
    }
}

static float calcularSoma(List<float> numbers)
{
    float sum = numbers.Sum();
    return sum;
}

static float calcularMedia(List<float> numbers)
{
    float media = numbers.Average();
    return media;
}


Console.WriteLine($"A soma dos valores digitados é {calcularSoma(numbers)} e a média é {calcularMedia(numbers)}");

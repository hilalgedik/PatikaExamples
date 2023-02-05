// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Düzenlenmesini istediğiniz sayı dizinini yazınız.");


Console.Write("Dizinin boyutunu girin: ");
int size = int.Parse(Console.ReadLine());

int[] numbers = new int[size];

for (int i = 0; i < size; i++)
{
    Console.Write("Dizinin {0}. elemanını girin: ", i + 1);
    numbers[i] = int.Parse(Console.ReadLine());
}

double[] result = SumOfTwoNumbers.SumOfTwoNumbers.GetSum(numbers);
Console.WriteLine("Girilen dizi: " + string.Join(", ", result));

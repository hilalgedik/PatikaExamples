// See https://aka.ms/new-console-template for more information

using FibonacciAverage;



Console.WriteLine("Fibonacci serisinin derinlik değerini giriniz.");
int userInput = Convert.ToInt32(Console.ReadLine());
int result = FibonacciFunctions.GetAverage(userInput);
Console.WriteLine("Fibonacci serisinin ortalaması: " + result);
Console.ReadLine();
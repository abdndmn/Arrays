int[] numbers = new int[10];

for(int i=0; i < numbers.Length; i++)
{
    Console.WriteLine($"Lütfen dizinin {i+1}. elemanını giriniz:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("\nOluşturulan Dizi:");
foreach (int i in numbers)
{
    Console.WriteLine(i);
}

Console.Write("\nLütfen diziye eklenecek olan değeri giriniz: ");
int number11 = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref numbers, numbers.Length + 1);
numbers[numbers.Length - 1] = number11;

Array.Sort(numbers);
Array.Reverse(numbers);

Console.WriteLine("\n Dizinin Son Hali:");
foreach (int i in numbers)
{
    Console.WriteLine(i);
}

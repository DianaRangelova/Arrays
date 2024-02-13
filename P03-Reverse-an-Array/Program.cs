int size = int.Parse(Console.ReadLine());
int[] numbersN = new int[size];

for (int i = numbersN.Length - 1; i >= 0; i--) //size
{
    numbersN[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(string.Join(" ", numbersN));
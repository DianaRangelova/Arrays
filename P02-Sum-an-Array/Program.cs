string inputLine = Console.ReadLine();
string[] strings = inputLine.Split();
int[] numbers = new int[strings.Length];

for (int i = 0; i < strings.Length; i++)
{
    numbers[i] = int.Parse(strings[i]);
}

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine(sum);
                   

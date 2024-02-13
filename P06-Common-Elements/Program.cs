int[] numbers1 = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
int[] numbers2 = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

for (int i = 0; i < numbers1.Length; i++)
{
    for (int j = 0; j < numbers2.Length; j++)
    {
        if (numbers1[i] == numbers2[j])
        {
            Console.Write($"{numbers1[i]} ");
        }
    }
}

//Option 2 with foreach:
//foreach (int numb1 in numbers1)
//{
// foreach (int numb2 in numbers2)
// {
// if (numb1 == numb2)
// {
//     Console.Write($"{numb} ");
// }



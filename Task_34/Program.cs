// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 

int[] array = new int[10];
int sumOddNum = 0;
int sumEvenNum = 0;
int countEvenNumbers = 0;
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
    Console.Write(array[i] + " ");

    if (array[i] > 0)
    {
        sumEvenNum += array[i];
    }
    else
    {
        sumOddNum += array[i];
    }

    if (array[i] % 2 == 0)
    {
        countEvenNumbers++;
    }
}

Console.WriteLine("\nКоличество четных чисел: " + countEvenNumbers);
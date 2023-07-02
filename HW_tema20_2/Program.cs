int[] nums = { 1, 2, 3, 4, 5 };

Console.WriteLine($"Среднее значение элементов массива: {Average_mass(nums)}");

int Average_mass(params int[] numbers)
{
    int result = 0;
    int count = 0;
    foreach (var n in numbers)
    {
        result += n;
        count++;
    }
    return result / count;
}


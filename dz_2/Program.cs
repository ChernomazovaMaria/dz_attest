//Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

int GetSumOfNatural(int m, int n, int sum = 0) {
    if (m > n) 
        return sum;
    sum = sum + m;
    return GetSumOfNatural(m+1,n, sum);
}

Console.WriteLine("Сумма натуральных чисел в промежутке от {0} до {1} равна {2}", m, n, GetSumOfNatural(m,n));
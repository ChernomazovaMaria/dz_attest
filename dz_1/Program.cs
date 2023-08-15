// Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Числа кратные трем от {0} до {n} равны - ");
GetMultiplesOf(3,m,n);

void GetMultiplesOf(int number, int m, int n) {
    if (m > n) 
        return;
    if (m % number ==0) {
        Console.Write("{0} ",m);
    }
    GetMultiplesOf(number, m + 1, n);
}
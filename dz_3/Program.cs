//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

int GetAckerman(int m, int n) {
    if (m == 0) {
        return n + 1;
    } else if (n == 0) {
        return GetAckerman(m-1,1);
    } else {
        return GetAckerman(m-1, GetAckerman(m, n-1));
    }
}

Console.WriteLine("Функция Аккермана для двух чисел {0} и {1} равна {2}",m, n, GetAckerman(m,n));
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0) Console.WriteLine("Вы ввели 0");
else {
    if (number % 2 == 0) Console.WriteLine("Да, число является четным");
    else Console.WriteLine("Нет, число является нечетным");
}
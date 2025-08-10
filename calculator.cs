double Sum(double a, double b) // метод выполняет сумму введенных чисел
{
    double sum = a + b;
    Console.WriteLine($"Ответ: {sum}");
    return sum;
}
double Minus(double a, double b) // метод выполняет разность введенных чисел
{
    double minus = a - b;
    Console.WriteLine($"Ответ: {minus}");
    return minus;
}
double Umn(double a, double b) // метод выполняет умножение введенных чисел
{
    double umn = a * b;
    Console.WriteLine($"Ответ: {umn}");
    return umn;
}
double Dele(double a, double b) // метод выполняет деление введенных чисел
{
    double dele = a / b;
    Console.WriteLine($"Ответ: {dele}");
    return dele;
}
double ValidInput(string input) // эта функция используются для того, чтобы проверить корректно ли введены данные
{
    Console.WriteLine(input);
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            return number;
        }
        Console.WriteLine("Введите число!");
    }
}
Console.WriteLine("Добро пожаловать в калькулятор :)");
while (true)
{
    Console.WriteLine("Выберете один из пунктов: ");
    Console.WriteLine("1.Сумма");
    Console.WriteLine("2.Вычитание");
    Console.WriteLine("3.Умножение");
    Console.WriteLine("4.Деление");
    Console.WriteLine("5.Выход");
    int a = int.Parse(Console.ReadLine());
    if (a == 5)
    {
        Console.WriteLine("Программа завершила работу -_- ");
        break;
    }
    switch (a) // вместо того чтобы писать много if-else, лучше прописать switch он удобнее  именно в таких случаях
    {
        case 1:
            Console.WriteLine("Вы выбрали сумму: ");
            double inputOneSum = ValidInput("Введите первое число: ");
            double inputTwoSum = ValidInput("Введите второе число: ");
            Sum(inputOneSum, inputTwoSum);
            Console.WriteLine(); // добавил что было расстояние между ответом и меню
            break;
        case 2:
            Console.WriteLine("Вы выбрали разность: ");
            double oneNumberMinus = ValidInput("Введите первое число: ");
            double twoNumberMinus = ValidInput("Введите второе число: ");
            Minus(oneNumberMinus, twoNumberMinus);
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine("Вы выбрали умножение: ");
            double oneNumberUmn = ValidInput("Введите первое число: ");
            double twoNumberUmn = ValidInput("Введите второе число: ");
            Umn(oneNumberUmn, twoNumberUmn);
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine("Вы выбрали деление: ");
            double oneNumberDele = ValidInput("Введите первое число: ");
            double twoNumberDele = ValidInput("Введите второе число: ");
            Dele(oneNumberDele, twoNumberDele);
            Console.WriteLine();
            break;
        default:
            Console.WriteLine("Ошибка, выберете один из пунктов ещё раз");
            Console.WriteLine();
            break;
    }
}

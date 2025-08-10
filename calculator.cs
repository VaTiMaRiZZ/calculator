double Sum(double a, double b) // метод который суммирует числа
{
    double sum = a + b;
    Console.WriteLine($"Ответ: {sum}");
    return sum;
}
double Minus(double a, double b) // метод который вычитает числа
{
    double minus = a - b;
    Console.WriteLine($"Ответ: {minus}");
    return minus;
}
double Umn(double a, double b) //метод который умножает числа
{
    double umn = a * b;
    Console.WriteLine($"Ответ: {umn}");
    return umn;
}
double Dele(double a, double b) // метод который делит числа
{
    
    double dele = a / b;
    Console.WriteLine($"Ответ: {dele}");
    return dele;
}
double ValidInput(string input) // это функция нужна для того, чтобы проверять корректность ввода данных
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
Console.WriteLine("Добро пожаловать в простой калькулятор :)");
while (true)
{
    Console.WriteLine("Выберете цифру: ");
    Console.WriteLine("1.Сумма");
    Console.WriteLine("2.Разность");
    Console.WriteLine("3.Умножение");
    Console.WriteLine("4.Деление");
    Console.WriteLine("5.Выход");
    int a = int.Parse(Console.ReadLine());
    if (a == 5)
    {
        Console.WriteLine("Программа завершила работу -_- ");
        break;
    }
    switch (a) 
    {
        case 1:
            Console.WriteLine("Вы выбрали сумму: ");
            double inputOneSum = ValidInput("Введите первое число: ");
            double inputTwoSum = ValidInput("Введите второе число: ");
            Sum(inputOneSum, inputTwoSum);
            break;
        case 2:
            Console.WriteLine("Вы выбрали разность: ");
            double oneNumberMinus = ValidInput("Введите первое число: ");
            double twoNumberMinus = ValidInput("Введите второе число: ");
            Minus(oneNumberMinus, twoNumberMinus);
            break;
        case 3:
            Console.WriteLine("Вы выбрали умножение: ");
            double oneNumberUmn = ValidInput("Введите первое число: ");
            double twoNumberUmn = ValidInput("Введите второе число: ");
            Umn(oneNumberUmn, twoNumberUmn);
            break;
        case 4:
            Console.WriteLine("Вы выбрали деление: ");
            double oneNumberDele = ValidInput("Введите первое число: ");
            double twoNumberDele =ValidInput("Введите второе число: ");
            if(twoNumberDele==0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                break;
            }
            Dele(oneNumberDele, twoNumberDele);
            break;
        default:
            Console.WriteLine("Ошибка, выберете число ещё раз!");
            break;
    }
}

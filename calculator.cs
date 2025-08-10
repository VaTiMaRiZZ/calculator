double Sum(double a, double b) // ����� ��������� ����� ��������� �����
{
    double sum = a + b;
    Console.WriteLine($"�����: {sum}");
    return sum;
}
double Minus(double a, double b) // ����� ��������� �������� ��������� �����
{
    double minus = a - b;
    Console.WriteLine($"�����: {minus}");
    return minus;
}
double Umn(double a, double b) // ����� ��������� ��������� ��������� �����
{
    double umn = a * b;
    Console.WriteLine($"�����: {umn}");
    return umn;
}
double Dele(double a, double b) // ����� ��������� ������� ��������� �����
{
    double dele = a / b;
    Console.WriteLine($"�����: {dele}");
    return dele;
}
double ValidInput(string input) // ��� ������� ������������ ��� ����, ����� ��������� ��������� �� ������� ������
{
    Console.WriteLine(input);
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            return number;
        }
        Console.WriteLine("������� �����!");
    }
}
Console.WriteLine("����� ���������� � ����������� :)");
while (true)
{
    Console.WriteLine("�������� ���� �� �������: ");
    Console.WriteLine("1.�����");
    Console.WriteLine("2.���������");
    Console.WriteLine("3.���������");
    Console.WriteLine("4.�������");
    Console.WriteLine("5.�����");
    int a = int.Parse(Console.ReadLine());
    if (a == 5)
    {
        Console.WriteLine("��������� ��������� ������ -_- ");
        break;
    }
    switch (a) // ������ ���� ����� ������ ����� if-else, ����� ��������� switch �� �������  ������ � ����� �������
    {
        case 1:
            Console.WriteLine("�� ������� �����: ");
            double inputOneSum = ValidInput("������� ������ �����: ");
            double inputTwoSum = ValidInput("������� ������ �����: ");
            Sum(inputOneSum, inputTwoSum);
            Console.WriteLine(); // ������� ��� ���� ���������� ����� ������� � ����
            break;
        case 2:
            Console.WriteLine("�� ������� ��������: ");
            double oneNumberMinus = ValidInput("������� ������ �����: ");
            double twoNumberMinus = ValidInput("������� ������ �����: ");
            Minus(oneNumberMinus, twoNumberMinus);
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine("�� ������� ���������: ");
            double oneNumberUmn = ValidInput("������� ������ �����: ");
            double twoNumberUmn = ValidInput("������� ������ �����: ");
            Umn(oneNumberUmn, twoNumberUmn);
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine("�� ������� �������: ");
            double oneNumberDele = ValidInput("������� ������ �����: ");
            double twoNumberDele = ValidInput("������� ������ �����: ");
            Dele(oneNumberDele, twoNumberDele);
            Console.WriteLine();
            break;
        default:
            Console.WriteLine("������, �������� ���� �� ������� ��� ���");
            Console.WriteLine();
            break;
    }
}

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Расчёт ИМТ");
Console.Write("Напишиет ваш вес: ");
double v = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишиет ваш рост(в метрах): ");
double h = Convert.ToDouble(Console.ReadLine());
double bmi = v / (h * h);
if (bmi >= 30)
{
    Console.WriteLine("Ожирение");
    Console.WriteLine("Вам надо сесть на диету");
}else if (bmi >= 25)
{
    Console.WriteLine("Избыточный вес");
    Console.WriteLine("Вам надо поменьше есть");
}else if (bmi >= 18.5)
{
    Console.WriteLine("Нормальный вес");
    Console.WriteLine("Вы в идеальной форме");
}else if (bmi < 18.5)
{
    Console.WriteLine("Недостаточный вес");
    Console.WriteLine("Вам надо побольше есть");
}
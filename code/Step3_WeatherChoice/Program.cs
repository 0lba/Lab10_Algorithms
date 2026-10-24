using System.Runtime.ConstrainedExecution;

Console.WriteLine("Выбор одежды по погоде");
Console.WriteLine("Введите текущую температуру (С): ");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >= 20)
{
    Console.WriteLine("Наденьте легкую одежду");
}
else
{
    Console.WriteLine("Наденьте теплую одежду");
}
Console.WriteLine("Хорошего дня!");
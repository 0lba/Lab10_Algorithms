bool play = false;
while (!play){
    int num = new Random().Next(1, 100);
    int c = 0;
    Console.Write("Угадайте число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num);
    do
    {
        if (a < num)
        {
            Console.WriteLine("Больше");
        }else if (a > num)
        {
            Console.WriteLine("Меньше");
        }
        c++;
        a = Convert.ToInt32(Console.ReadLine());
    }while (a != num);
    Console.WriteLine("Вы угадали!");
    Console.WriteLine("Хотите сыграть снова?");
    string q = Console.ReadLine();
    if (q.ToLower() == "да" || q.ToLower() == "yes" || q.ToLower() == "1")
    {
        play = false;
    }
    else if (q.ToLower() == "нет" || q.ToLower() == "no" || q.ToLower() == "0")
    {
        play = true;
    }
}
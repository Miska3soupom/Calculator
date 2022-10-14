
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаовать в музыкальную программу!\nВыберите октаву из списка:\n    F1 для перехода ко 2 октаве\n    F2 для перехода к 3 октаве\n    F3 для перехода к 4 октаве" +
        "\n    F4 для перехода к 5 октаве\n    F5 для перехода к 6 октаве\n    Esc для выхода из программы");        
        Console.WriteLine("До - A\nДо# - W\nРе - S\nРе# - E\nМи - D\nФа - F\nФа# - T\nСоль - G\nСоль# - Y\nЛя - H\nЛя# - U\nСи - J");
        ConsoleKey kluch = Console.ReadKey().Key;
        while (kluch != ConsoleKey.Escape)
        {
            switch (kluch)
            {
                case ConsoleKey.F1:
                    Console.Clear(); Console.WriteLine("2 октава");
                    kluch = oktava(0); break;
                case ConsoleKey.F2:
                    Console.Clear(); Console.WriteLine("3 октава");
                    kluch = oktava(1); break;
                case ConsoleKey.F3:
                    Console.Clear(); Console.WriteLine("4 октава");
                    kluch = oktava(2); break;
                case ConsoleKey.F4:
                    Console.Clear(); Console.WriteLine("5 октава");
                    kluch = oktava(3); break;
                case ConsoleKey.F5:
                    Console.Clear(); Console.WriteLine("6 октава");
                    kluch = oktava(4); break;
                default: Console.WriteLine("Выберете октаву заново");kluch = Console.ReadKey().Key; break;
            }
        }
        Console.WriteLine("\n\tВСЕ-ГО ХО-РО-ШЕ-ГО!");
    }

    static ConsoleKey oktava(int okt)
    {
        ConsoleKey Jmyak = Console.ReadKey().Key;
        while (Jmyak != ConsoleKey.F1 && Jmyak != ConsoleKey.F2 && Jmyak != ConsoleKey.F3 && Jmyak != ConsoleKey.F4 && Jmyak != ConsoleKey.F5 && Jmyak != ConsoleKey.Escape)
        {
            int rez;
            switch (Jmyak)
            {
                case ConsoleKey.A:
                    rez = Notes(okt,0);Console.Clear();
                    Console.Beep(rez, 200);break;
                case ConsoleKey.S:
                    rez = Notes(okt, 2); Console.Clear();
                    Console.Beep(rez, 200);break;
                case ConsoleKey.D:
                    rez = Notes(okt, 4); Console.Clear();
                    Console.Beep(rez, 200);break;
                case ConsoleKey.F:
                    rez = Notes(okt, 5); Console.Clear();
                    Console.Beep(rez, 200); break;
                case ConsoleKey.G:
                    rez = Notes(okt, 7); Console.Clear();
                    Console.Beep(rez, 200);break;
                case ConsoleKey.H:
                    rez = Notes(okt, 9); Console.Clear();
                    Console.Beep(rez, 200);break;
                case ConsoleKey.J:
                    rez = Notes(okt, 11); Console.Clear();
                    Console.Beep(rez, 200);break;

                case ConsoleKey.W:
                    rez = Notes(okt, 1); Console.Clear();
                    Console.Beep(rez, 200);break;
                case ConsoleKey.E:
                    rez = Notes(okt, 3); Console.Clear();
                    Console.Beep(rez, 200);break;
                case ConsoleKey.T:
                    rez = Notes(okt, 6); Console.Clear();
                    Console.Beep(rez, 200);break;
                case ConsoleKey.Y:
                    rez = Notes(okt, 8); Console.Clear();
                    Console.Beep(rez, 200);break;
                case ConsoleKey.U:
                    rez = Notes(okt, 10); Console.Clear();
                    Console.Beep(rez, 200);break;
                default:break;
            }
            Jmyak = Console.ReadKey().Key;
        }
       return Jmyak;
    }
    
    static int Notes(int a, int b)
    {
        int[,] igra = new int[,] { { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123}, { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246},
        { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 }, {523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987,}
        , { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976} };
        return igra[a,b];
    }
}

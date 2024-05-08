namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Операция: \n1. '+'\n2.'-'\n3.'*'\n4.'/'\n5.Выход");


            int Op = int.Parse(Console.ReadLine());
            int Rez;
            while (Op != 5)
            {
                if (Op == 1)
                {
                    Rez = A + B;
                    Console.WriteLine(Rez);
                }
                if (Op == 2)
                {
                    Rez = A - B;
                    Console.WriteLine(Rez);
                }
                if (Op == 1)
                {
                    Rez = A * B;
                    Console.WriteLine(Rez);
                }
                if (Op == 1)
                {
                    Rez = A / B;
                    Console.WriteLine(Rez);
                }
            }


        }
    }
}

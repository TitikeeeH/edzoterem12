namespace Gymmanager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            Member Member1 = new Member("Name", 5, true);
            Console.WriteLine(Member1.Age);
            Member Member2 = new Member("Jozsi", 23, false);
            Console.WriteLine(Member2.Name);
            Member Member3 = new Member("Pali", 44, false);
            Console.WriteLine(Member2.isStudent);
            Member Member4 = new Member("Kiki", 12, true);
            Console.WriteLine(Member4.isStudent);
        }
    }
}

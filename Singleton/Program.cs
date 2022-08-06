namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;
            Console.WriteLine(singleton1.GetHashCode()==singleton2.GetHashCode());

            //for (int i = 0; i < 20; i++)
            //{
            //    var singleton1 = Singleton.Instance;
            //    var singleton1 = Singleton.Instance;

            //}
        }
    }

}
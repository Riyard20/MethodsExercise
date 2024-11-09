namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?!");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favanimal = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine(
                $"One day, {userName} was walking through the woods wearing a {favoriteColor} t-shirt. {userName} saw a {favanimal} listening to {favoriteBand}");

        }

        public static int Add(int numbOne, int numbTwo)
        {
            return numbOne + numbTwo;
        }

        public static int Substract(int numbOne, int numbTwo)
        {
            return numbOne - numbTwo;
        }

        public static int Multiply(int numbOne, int numbTwo)
        {
            return numbOne * numbTwo;
        }

        public static int Divide(int numbOne, int numbTwo)
        {
            return numbOne / numbTwo;
        }

        public static int Sum(params int[] numbs)
        {
            int sum = 0;

            foreach (int numbers in numbs)
            {
                //sum= sum + numbers; 
                sum += numbers;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            //Madlib();
            // Console.WriteLine(Add(numbOne:2, numbTwo:2));
            //Console.WriteLine(Substract(2, 2));
            //Console.WriteLine(Multiply(2, 2));
            //Console.WriteLine(Divide(2, 2));
            Console.WriteLine(Sum(5));
        }

    }
}




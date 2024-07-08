namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();    
        }

        public static void Exercise1()
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Guess my favorite number between 1 and 1000:");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You guessed it! Congratulations!");
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();
            favoriteSubject = favoriteSubject.ToLower();
            switch (favoriteSubject)
            {
                case "math":
                    Console.WriteLine("Math is great for problem-solving and logic!");
                    break;

                case "science":
                    Console.WriteLine("Science is fascinating and helps us understand the world around us!");
                    break;

                case "english":
                    Console.WriteLine("English is the language of literature and communication!");
                    break;

                case "history":
                    Console.WriteLine("History teaches us about the past and helps us understand the present!");
                    break;

                case "music":
                    Console.WriteLine("Music is the language of emotions and brings joy to our lives!");
                    break;

                default:
                    Console.WriteLine("That's an interesting choice! I'm glad you enjoy your favorite subject!");
                    break;
            }

        }
    }
}

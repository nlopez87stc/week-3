using System;

namespace test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int SIZE =20;
            Char[] answers = {'B','D','A','A','C','A','B','A','C','D','B','C','D','A','D','C','C','B','D','A'};
            char[] userinput = new char[SIZE];
            int numberOfCorrect = 0, numberOfWrong = 0;
            for (int i=0; i<SIZE; i++)
            {
                Console.Write("Enter Question {0} answer: ",i+1);
                userinput[i] = char.Parse(Console.ReadLine());
                if (answers[i] !=userinput[i])
                numberOfWrong++;
                else
                numberOfCorrect++;
            }
            if (numberOfCorrect >=15)
            Console.WriteLine("\nYou have passed");
            else
            Console.WriteLine("/nYou have failed");
            Console.WriteLine("/nTotal number of correct answers : {0}",numberOfCorrect);
            Console.WriteLine("Total number of wrong answers: {0}", numberOfWrong);
            Console.WriteLine("/n/nQuestion which you have inputed wrong: ");

            for (int i=0; i<SIZE; i++)
            {
                if(answers[i] != userinput[i])
                Console.WriteLine("Question {0}", (i + 1));
            }
            Console.ReadKey();
        }
    }
}
using System;

namespace SixtiesNewWave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to some bite- sized 60s New Wave Film Trivia!");
            Console.WriteLine("Let's see how much you know about Nouvelle Vague.\n");

            // Array to store questions and answers
            string[,] questionsAndAnswers = {
                {"What year was the film 'Breathless' directed by Jean-Luc Godard released?", "1960"},
                {"Who was the female lead in 'Breathless'?", "Jean Seberg"},
                {"What was the name of the character played by Anna Karina in 'Pierrot le Fou'?", "Marianne"},
                {"Which Godard film features a character named 'Lemmy Caution'?", "Alphaville"},
                {"In 'Band of Outsiders', what famous dance scene occurs in a cafe?", "The Madison"},
                {"Which film, directed by François Truffaut, follows the story of a young boy named Antoine Doinel as he struggles with his troubled childhood?", "The 400 Blows"},
                {"Who is often credited as the 'father' of the French New Wave and directed films such as 1962's 'Jules and Jim?'", "Francois Truffaut"},
                {"Which Godard film is known for its innovative use of jump cuts?", "Breathless"},
                {"Bonus round- which famous Parisian landmark do the'Band of Outsiders' run through?", "The Louvre"},

            };

            int score = 0; // Initialize score

            // Loop through each question
            for (int i = 0; i < questionsAndAnswers.GetLength(0); i++)
            {
                Console.WriteLine($"Question {i + 1}: {questionsAndAnswers[i, 0]}");
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == questionsAndAnswers[i, 1].ToLower())
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is: {questionsAndAnswers[i, 1]}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"You answered {score} out of {questionsAndAnswers.GetLength(0)} questions correctly.");
            Console.WriteLine("Thank you for playing! Now put out your cigarette and go boogie in a cafe.");
        }
    }
}

using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int answer = 4; //Explcit Typing
            //string response; //Explcit Typing

            //if (answer < 9)
            //{
             //   response = answer + " is less than nine";
            //}
            //else
           // {
              //  response = answer + "greater than or equal to nine";
           // }
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"(answer) is greater than nine";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace AveMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX_SCORE;
            int MIN_SCORE;
            double AVE_SCORE;
            List<string> examGradesList = new List<string>();
            string[] examGradesArray = examGradesList.ToArray();
            Console.WriteLine("Enter your exam grades seperated by a comma.");
            string input = Console.ReadLine();
            examGradesArray = input.Split(',');
            for (int i = 0; i < examGradesArray.Length; i++)
            {
                examGradesArray[i] = examGradesArray[i].Trim();
            }
            for(int i=0; i <examGradesArray.Length; i++) 
            {
                examGradesList.Add(examGradesArray[i]);
            }
            foreach( var grade in examGradesList) 
            {
                Console.WriteLine(grade);
            }
            double ave;
            double sum = 0;
            for (int i=0; i < examGradesArray.Length; i++)
            {
              
                sum += Convert.ToDouble(examGradesArray[i]);
                
               
            }
            ave = sum / examGradesArray.Length;
            AVE_SCORE = ave;

            MIN_SCORE = Convert.ToInt32(examGradesList.Min());
            MAX_SCORE = Convert.ToInt32(examGradesList.Max());
            
            Console.WriteLine("The min grade is " + MIN_SCORE);
            Console.WriteLine("The max grade is " + MAX_SCORE);
            Console.WriteLine("The average grade is " + AVE_SCORE);

            //foreach (var grades in input.ToString())
            //{
            //     = Convert.ToString(input).Split(",");
            //}
            //examGradesList.Add(input);
            //foreach (var grade in examGradesList)
            //{
            //    Console.WriteLine(grade);
            //}

        }
    }
}

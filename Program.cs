using System;
using System.Collections.Generic;


namespace anonymousRoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables
            int Pass = 0;
            int Average = 0;
            int Fail = 0;
            
            //generate random number 
            int Students = new Random().Next(1,90);
            Console.WriteLine("The number of students who took the anonymous exam are " +  Students);

            //create a list 
            List<int> results = new List<int>();
            for(int i = 0; i < Students; i++)
                {
                    int Score = new Random().Next(1,100);                   
                   
                    if (Score> 70)
                    {
                        ++Pass ;
                    
                    }
                    else if (Score>50 && Score<69)
                    {
                        ++Average;
                    }
                    else
                    {
                        ++Fail;
                    }
                    results.Add(Score);
                    
                }

            Console.WriteLine( Pass + " students scored above 70 and passed the exam\r\n");
            Console.WriteLine( Average + " students scored between 50-69 with an average score\r\n");
            Console.WriteLine( Fail + " failed the exam\r\n");
             Console.WriteLine("The following is the score and anonymous results of all students that participated: ");   

            //accumulate results 
            for (int i = 0; i <Students; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}

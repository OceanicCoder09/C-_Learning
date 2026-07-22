using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the number of students: ");
            int totalStuds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter total subjects: ");
            int totalSubjects = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < totalStuds; i++)
            {
                Console.WriteLine("Enter name of student: ");
                string name = Console.ReadLine();

                int totalMarksOfStudent = 0;
                int totalMarks = totalSubjects * 100;

                for(int j = 0; j < totalSubjects; j++)
                {
                    Console.WriteLine($"Enter marks for subject {j + 1}: ");
                    int marks = Convert.ToInt32(Console.ReadLine());

                    if(marks < 0 || marks > 100)
                    {
                        throw new Exception("Marks should be between 0 and 100.");
                    }

                    totalMarksOfStudent += marks;
                }

                int percentage = (totalMarksOfStudent * 100) / totalMarks;

                if(percentage >= 90)
                {
                    Console.WriteLine($"Student {name} has got grade A with percentage {percentage}%");
                }
                else if(percentage >= 75)
                {
                    Console.WriteLine($"Student {name} has got grade B with percentage {percentage}%");
                }
                else if(percentage >= 60)
                {
                    Console.WriteLine($"Student {name} has got grade C with percentage {percentage}%");
                }
                else if(percentage >= 40)
                {
                    Console.WriteLine($"Student {name} has got grade D with percentage {percentage}%");
                }
                else
                {
                    Console.WriteLine($"Student {name} has failed with percentage {percentage}%");
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
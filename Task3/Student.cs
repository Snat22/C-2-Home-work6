namespace Task3;

public class Student
{
public string Name;
public int GradeLevel;
public double [] TestScores;

public double GetAverage()
{
    double sum = 0;
    foreach (var it in TestScores)
    {
        sum+=it;
    }
    return sum/TestScores.Length;
}

public string GetInfo()
{
     
    if (GetAverage() >= 80)
            {
                return $"Congratulations {Name} on achieving above average scores ({GetAverage()}) in grade{GradeLevel}! Keep up the good work!";
            }

             if (GetAverage() >= 70  && GetAverage() < 80)
            {
            return $"{Name} if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is {GetAverage()} in grade {GradeLevel}.";
            }
              else
            {
                return $"{Name} You cannot Pass a Curse it's so bad. Your Average{GetAverage()} in grade {GradeLevel}, YOU NEED TO TRY MORE :)";
            }
               
        }
}

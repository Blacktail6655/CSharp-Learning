using System.Reflection;

public class Student
{
    private string name {get; set;}
    private int[] scores {get; set;}

    public Student(string name, int[] scores)
    {
        this.name = name;
        this.scores = scores;
    }

    public double GetAverage()
    {
        if (scores.Length == 1)
        {
            return 0;
        } else
        {
            return scores.Sum()/scores.Length;
        }
    }

    public string GetLetterGrade()
    {
        if (GetAverage() >= 90)
        {
            return "A";
        } else if (GetAverage() >= 80)
        {
            return "B";
        } else if (GetAverage() >= 70)
        {
            return "C";
        } else if (GetAverage() >= 60)
        {
            return "D";
        } else
        {
            return "F";
        }
    }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student("John", [98, 65, 78, 93]));
        students.Add(new Student("Lisa", [87, 94, 97, 92, 86]));
        students.Add(new Student("Rachel", [68, 74, 72, 89]));
        students.Add(new Student("James", [99, 99, 101, 95, 97]));

        foreach (Student student in students)
        {
            Console.WriteLine(student.name, student.GetAverage()%0.1);
        }
    } 

}
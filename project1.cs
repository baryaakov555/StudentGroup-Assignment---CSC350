using System;

public class Program()
{
  public static void Main(string[] args)
{
    StudentGroup group1 = new StudentGroup("Team Alpha", 3);
    group1.AddStudent("Alice", 0);
    group1.AddStudent("Bob", 1);
    group1.AddStudent("Charlie", 2);
    group1.DisplayGroup();
    Console.WriteLine(group1.GetStudent(1));
    group1.AddStudent("Bar", -1);
    }
}

public class StudentGroup
{
    private string groupName;
    private int groupSize;

    private string[] studentNames;

    public StudentGroup(string GroupName, int GroupSize)
    {
        groupName = GroupName;
        groupSize = GroupSize;
        studentNames = new string[GroupSize];
    }

    public void AddStudent(string studentName, int position)
    {
        if (position < 0 || position > groupSize - 1)
        {
            Console.WriteLine("Position can not be a negative number");
        }
        else
        {
            studentNames[position] = studentName;
        }
    }

    public string GetStudent(int position)
    {
        string errorMessage = "Position can not be a negative number";

        if (position < 0 || position > groupSize - 1)
        {
            Console.WriteLine(errorMessage);
            return errorMessage;
        }
        else
        {
            return studentNames[position];
        }  
    }

    public void DisplayGroup()
    {
        Console.WriteLine($"Group: {groupName}");
        foreach(string name in studentNames)
        {
            Console.WriteLine(name);
        }
    }
}
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
            return;
        }

        studentNames[position] = studentName;
    }

    public string GetStudent(int position)
    {
        return studentNames[position];
    }

    public void DisplayGroup()
    {
        Console.WriteLine($"Group: {groupName}");
        foreach(string name in studentNames)
        {
            Console.WriteLine(studentNames);
        }
    }
}
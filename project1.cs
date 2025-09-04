public class StudentGroup
{
    private string groupName;
    private int groupSize;

    private string[] studentNames = new string[0];
    private string studentName = "";

    public StudentGroup(string GroupName, int GroupSize)
    {
        groupName = GroupName;
        groupSize = GroupSize;
    }
}
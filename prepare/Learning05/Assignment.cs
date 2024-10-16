public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studenName, string topic )
    {
        this._studentName = studenName;
        this._topic = topic;
    }
    public string GetSumary()
    {
        return $"Student Name: {_studentName} - Topic:{_topic}";
    }
    public string GetStudentName()
    {
        return _studentName;
    }
}
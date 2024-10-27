public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        this._name = name;
        this._description = description;
        this._points = points;
    }
    public int Points
    {
        get { return _points; }
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        return $"{_name}: {_description} - Points: {_points}";
    }
};

    


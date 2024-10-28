public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _tarjet;
    private int _bonus;

    public ChecklistGoal(string name, string descripción, int points, int tarjet, int bonus): base(name,descripción,points)
    {
        this._amountCompleted = 0;
        this._points += _points;
        this._tarjet = tarjet;
        this._bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted ++;
        _points += _points;
        
        if (_amountCompleted >= _tarjet)
        {
            _points +=_bonus;
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _tarjet;
    }
    public override string GetDetailsString()
    {
        string status = IsComplete()? "[X]" : "[]";
        return $"{status} {_name} ({_description}) - Completed {_amountCompleted}/{_tarjet} times";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_amountCompleted}|{_tarjet}|{_bonus}";
    }
}
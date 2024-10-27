public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
    
    }
    public override bool IsComplete()
    {
        // Las metas eternas nunca están "completas", así que siempre devolvemos false.
        return false;
    }
    public override string GetDetailsString()
    {
        // No se marca como completa, simplemente se muestra el nombre y la descripción.
        return $"[ ] {_name} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}

using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals; 
    private int _score;

    public GoalManager()
    {
        this._goals = new List<Goal>();
        this._score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\n--- Goals ---");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found. Please add a goal first.");
        }
        else
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }
    }


    public void RecordGoalEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _score += goal.Points;
            Console.WriteLine("Event recorded! Points awarded: " + goal.Points);
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    // Propiedad para obtener la cantidad de metas
    public int GoalsCount
    {
        get { return _goals.Count; }
    }

    // Propiedad para obtener la puntuación total
    public int Score
    {
        get { return _score; }
    }

    // Método para establecer la puntuación (usado al cargar desde un archivo)
    public void SetScore(int score)
    {
        _score = score;
    }

    // Método para obtener todas las metas (usado al guardar en un archivo)
    public List<Goal> GetGoals()
    {
        return _goals;
    }

    // Método para limpiar todas las metas actuales (usado antes de cargar nuevas metas)
    public void ClearGoals()
    {
        _goals.Clear();
    }
}

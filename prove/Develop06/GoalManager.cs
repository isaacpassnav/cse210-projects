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
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void RecordGoalEvent(int goalIndex)
    {
        if (goalIndex >=0 && goalIndex < _goals.Count)
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
     public int Score
    {
        get { return _score; }
    }
}
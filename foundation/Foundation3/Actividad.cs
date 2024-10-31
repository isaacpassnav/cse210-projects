using System;
using System.Collections.Generic;
public abstract class Activity
{
    private string _date;
    private int _minutes;
    private DateTime _timestamp;
    private double _weight;

    public Activity(string date, int minutes, double weight)
    {
        this._date = date;
        this._minutes = minutes;
        this._timestamp = DateTime.Now;
        this._weight = weight;

    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

     public virtual double CalculateCaloriesBurned()
    {
        return 0; 
    }
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km, Calories burned: {CalculateCaloriesBurned():F2} kcal";
    }
    protected int Minutes
    {
        get{return _minutes;}
    }
    public DateTime Timestamp
    {
        get {return _timestamp;}
    }
    protected double Weight => _weight;
}
// Class Running
public class Running:Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance, double weight): base(date,minutes, weight)
    {
        this._distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / Minutes) * 60;
    }
    public override double GetPace()
    {
        return Minutes / _distance;
    }
    public override double CalculateCaloriesBurned()
    {
        return Minutes * 0.075 * Weight;
    }
}
// Class Cycling
public class Cycling: Activity
{
    private double _speed;
    
    public Cycling(string date, int minutes,double speed, double weight): base(date, minutes, weight)
    {
        this._speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed * Minutes) / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override double CalculateCaloriesBurned()
    {
        return Minutes * 0.075 * Weight;
    }
}
public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps, double weight) : base(date, minutes, weight)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }
    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
    public override double CalculateCaloriesBurned()
    {
        return Minutes * 0.1 * Weight;
    }
}

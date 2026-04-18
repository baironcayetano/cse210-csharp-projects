abstract class Goal
{
    private string _name;
    private string _description;
    protected double _pointsEarned;
    private int _points;

    private bool _completed;

    public Goal(string name,string description, int points)
    {
        SetNameAndDescription(name, description);
        SetPoints(points);
        SetPointsEarned(0);
        SetCompleted(IsComplete() || false);
    }

    protected void SetNameAndDescription(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void SetCompleted(bool completed)
    {
        _completed = completed;
    }
    protected void SetPoints(int points)
    {
        _points = points;
    }

    protected virtual void SetPointsEarned(double pointsEarned)
    {
        _pointsEarned = pointsEarned;
    }

    public abstract void RecordEvent();
    public abstract string GetStringRepresentation();

    public virtual bool IsComplete(){
        return _completed;
    }

    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]":"[ ]";
        return $"{status} {_name} ({_description})";
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints(){
        return _points;
    }
    public double GetPointsEarned()
    {
        return _pointsEarned;
    }
}
class ChecklistGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string[] strRepresentationParts) : base("", "", 0)
    {
        SetNameAndDescription(strRepresentationParts[1], strRepresentationParts[2]);
        SetPoints(int.Parse(strRepresentationParts[3]));
        SetAmountCompleted(int.Parse(strRepresentationParts[4]));
        _target = int.Parse(strRepresentationParts[5]);
        _bonus = int.Parse(strRepresentationParts[6]);
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted += 1;
            double pointsEarned = GetPoints() + (IsComplete() ? _bonus : 0);
            SetPointsEarned(pointsEarned);
        } 
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()}) - Completed {_amountCompleted}/{_target} time(s)";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist,{GetName()},{GetDescription()},{GetPoints()},{_amountCompleted},{_target},{_bonus}";
    }

    protected override void SetPointsEarned(double pointsEarned)
    {
        _pointsEarned += pointsEarned; 
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
        double pointsEarned = GetPoints() + (IsComplete() ? _bonus : 0);
        SetPointsEarned(pointsEarned);
    }


}
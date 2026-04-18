class EternalGoal:Goal
{
    public EternalGoal(string[] strRepresentationParts):base("","",0)
    {
        SetNameAndDescription(strRepresentationParts[1], strRepresentationParts[2]);
        SetPoints(int.Parse(strRepresentationParts[3]));
        SetPointsEarned(double.Parse(strRepresentationParts[4]));
        SetCompleted(IsComplete() || false);
    }
    public EternalGoal(string name, string description, int points):base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        SetPointsEarned(GetPointsEarned() + GetPoints());
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"Enternal - {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal,{GetName()},{GetDescription()},{GetPoints()},{GetPointsEarned()}";
    }
}
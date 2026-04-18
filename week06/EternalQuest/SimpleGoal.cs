class SimpleGoal:Goal
{

    public SimpleGoal(string[] strRepresentationParts) : base("", "", 0)
    {
        SetNameAndDescription(strRepresentationParts[1], strRepresentationParts[2]);
        SetPoints(int.Parse(strRepresentationParts[3]));
        bool isCompleted = bool.Parse(strRepresentationParts[4]);
        if (isCompleted)
        {
            RecordEvent();
        }

    }
    public SimpleGoal(string name, string description, int points):base(name,description, points)
    {
    }

    public override void RecordEvent()
    {
        SetCompleted(true);
        SetPointsEarned(GetPoints());
    }

    public override string GetStringRepresentation(){
        return $"Simple,{GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }

}
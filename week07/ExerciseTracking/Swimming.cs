class Swimming: Exercise
{
    private int _numberOfLaps;
    private int _minutes;
    private double _distance;

    public Swimming(int numberOfLaps, int minutes)
    {
        _numberOfLaps = numberOfLaps;
        _minutes = minutes;
        _distance = GetDistance();
    }

    public double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override string GetSummary(bool KM)
    {
        double pace = GetPace(_minutes,_distance);
        double speed = GetSpeed(pace);
        string unitPerHour = KM ? "kph" : "mph";
        string unit = KM ? "km" : "mile"; 
        return $"{GetTime()} Swimming ({_minutes} min): Distance {_distance} miles, Speed {speed} {unitPerHour}, Pace {pace:2} min per {unit}";
    }
}
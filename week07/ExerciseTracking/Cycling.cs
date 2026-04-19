class Cycling : Exercise
{
    private double _distance;
    private int _minutes;

    public Cycling(double distance, int minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }

    public override string GetSummary(bool KM)
    {
        double pace = GetPace(_minutes,_distance);
        double speed = GetSpeed(pace);
        string unitPerHour = KM ? "kph" : "mph";
        string unit = KM ? "km" : "mile"; 
        return $"{GetTime()} Cycling ({_minutes} min): Distance {_distance} miles, Speed {speed} {unitPerHour}, Pace {pace:2} min per {unit}";
    }
}
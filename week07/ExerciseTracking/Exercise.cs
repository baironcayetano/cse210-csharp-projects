using System.Collections.Concurrent;

abstract class Exercise{
    public Exercise(){}

    public virtual double GetPace(double minutes, double distance)
    {
        return minutes / distance;
    }

    public double GetSpeed(double pace)
    {
        return 60 / pace;
    }

    protected string GetTime()
    {
        DateTime dateTime = new DateTime();
        string format = dateTime.ToString("dd MMM yyyy");
        return format;
    }
    public abstract string GetSummary(bool KM);
}
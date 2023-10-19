namespace LucianLasagna;

class Lasagna
{
    private const int MinutesToCook = 40;
    private const int MinutesPerLayer = 2;

    public static int ExpectedMinutesInOven() => MinutesToCook;

    public static int RemainingMinutesInOven(int minutesInTheOven) =>
        MinutesToCook - minutesInTheOven;

    public static int PreparationTimeInMinutes(int numberOfLayers) =>
        numberOfLayers * MinutesPerLayer;

    public static int ElapsedTimeInMinutes(int numberOfLayers, int minutesInTheOven) =>
        PreparationTimeInMinutes(numberOfLayers) + minutesInTheOven;
}
// See https://aka.ms/new-console-template for more information

class Lasagna
{
    private const int MinutesToCook = 40;
    private const int MinutesPerLayer = 2;

    public int ExpectedMinutesInOven() => MinutesToCook;

    public int RemainingMinutesInOven(int minutesInTheOven) => MinutesToCook - minutesInTheOven;

    public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers * MinutesPerLayer;

    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInTheOven) =>
        PreparationTimeInMinutes(numberOfLayers) + minutesInTheOven;
}
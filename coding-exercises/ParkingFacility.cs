/*
Additionally, there are 2 places a vehicle can park: parking lot and a parking garage. Both lots and garages have a set number of 
spaces for each location, but each type differs in the following ways:

· Lots can accommodate any type of vehicle; however, garages can only accommodate cars and motorcycles.

· Garages (only) have “compact only” spaces in addition to normal spaces where only vehicles weighing less than 1,500 can park. 
When possible, compact spaces should be utilized before normal spaces
*/


using System.Reflection.Metadata.Ecma335;

public interface IParkingFacility
{
    int TotalNormalSpaces { get; set; }
    bool Park(Vehicle vehicle);
}

public class ParkingLot : IParkingFacility
{
    private int normalParkedCars = 0;
    public int TotalNormalSpaces { get; set; }
    public ParkingLot(int totalSpaces)
    {
        TotalNormalSpaces = totalSpaces;
    }


    public bool Park(Vehicle vehicle)
    {
        if(normalParkedCars < TotalNormalSpaces) {
            normalParkedCars++;
            return true;
        }
        return false;
    }
}

public class Garage : IParkingFacility
{
    private int compactParkedCars = 0;
    private int normalParkedCars = 0;

    public int TotalNormalSpaces { get ; set; }
    public int TotalCompactSpaces { get ; set; }

    public Garage(int totalNormalSpaces, int totalCompactSpaces)
    {
        TotalNormalSpaces = totalNormalSpaces;
        TotalCompactSpaces = totalCompactSpaces;
    }


    public bool Park(Vehicle vehicle)
    {
        if(vehicle.WeightInPounds < 1500)
        {
            if(compactParkedCars < TotalCompactSpaces)
            {
                compactParkedCars++;
                return true;
            }
        }
        else if (normalParkedCars < TotalNormalSpaces)
        {
            normalParkedCars++;
            return true;
        }
        return false;
    }
}
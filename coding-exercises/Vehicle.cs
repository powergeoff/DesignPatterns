/*
Suppose there are 3 types of vehicles: cars, motorcycles, and buses. Each type of vehicle has the following public properties:

· Make and model

· Number of wheels

· Length

· Weight

· Max number of passengers
*/
public class Vehicle {
    public string Make { get; set; }
    public string Model { get; set; }
    public int NumberOfWheels { get; set; }
    public decimal LengthInFeet { get; set; }
    public decimal WeightInPounds { get; set; }
    public int MaxPassengers { get; set; }

    public Vehicle(string make, string model, int numberOfWheels, decimal lengthInFeet, decimal weightInPounds, int maxPassengers)
    {
        Make = make;
        Model = model;
        NumberOfWheels = numberOfWheels; 
        LengthInFeet = lengthInFeet;
        WeightInPounds = weightInPounds;
        MaxPassengers = maxPassengers;
    }
}

public class Car : Vehicle
{
    public Car(string make, string model, decimal lengthInFeet, decimal weightInPounds, int maxPassengers)
        : base(make, model, 4, lengthInFeet, weightInPounds, maxPassengers)
    {
    }
}

public class Motorcycle : Vehicle
{
    public Motorcycle(string make, string model, decimal lengthInFeet, decimal weightInPounds, int maxPassengers)
        : base(make, model, 2, lengthInFeet, weightInPounds, maxPassengers)
    {
    }
}

public class Bus : Vehicle
{
    public Bus(string make, string model, int numberOfWheels, decimal lengthInFeet, decimal weightInPounds, int maxPassengers)
        : base(make, model, numberOfWheels, lengthInFeet, weightInPounds, maxPassengers) //school bus has 6 wheels - city bus has more??
    {
    }
}
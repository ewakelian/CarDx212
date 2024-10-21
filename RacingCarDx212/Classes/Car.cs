using System;

namespace RacingCarDx212.Classes;

public class Car
{
    public string Model;
    public string Color;
    public double Speed;
    public double Fuel;
    public double TotalMiles;
    public double UseFuelRate; // xxx litre per distance unit
    public Car(string Model, double Speed , double Fuel, double UseFuelRate)
    {
        this.Model = Model;
        this.Speed = Speed;
        this.Fuel = Fuel;
        this.UseFuelRate = UseFuelRate;
    }
    public void Run(double miles)
    {
        //this.TotalDistance = this.TotalDistance + distance;
        this.TotalMiles += miles;
        var used_fuel = miles * this.UseFuelRate;
        this.Fuel = this.Fuel - used_fuel;
    } 

    public uint TimeUsedForRun(double miles)
    {
        var timeused = miles/Speed;
        this.Run(miles);
        return Convert.ToUInt16(timeused);
    }
    public string ShowInfo()
    {
        var info = $"Model {this.Model}\n TotalDistance {this.TotalMiles}\n Fuel {this.Fuel}\n";
        return info;
    }




}

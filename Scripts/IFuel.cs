using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFuel
{
    void Fuel();
}

public class Electric : IFuel
{
    public void Fuel()
    {
        StartCar();
        Debug.Log("Car recharged.");
    }

    private void StartCar()
    {
        Debug.Log("The car starts with barely a sound.");
    }
}

public class Diesel : IFuel
{
    public void Fuel()
    {
        StartTruck();
        Debug.Log("Car fueled with pure Diesel.");
    }

    private void StartTruck()
    {
        Debug.Log("The truck starts after turning over once.");
    }
}
public class Gas : IFuel
{
    public void Fuel()
    {
        StartCar();
        Debug.Log("Car fueled with normal gas.");
    }

    private void StartCar()
    {
        Debug.Log("The car starts.");
    }
}

public class Rainbow : IFuel
{
    public void Fuel()
    {
        StartCar();
        Debug.Log("Car fueled with rainbows.");
    }

    private void StartCar()
    {
        Debug.Log("How can a car run on rainbows?");
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private IFuel m_Fuel;
    private IDriver m_Driver;

    public void SetFuel(IFuel fuel)
    {
        m_Fuel = fuel;
    }

    public void SetDriver(IDriver driver)
    {
        m_Driver = driver;
    }

    public void FuelCar()
    {
        m_Fuel.Fuel();

        m_Driver.Control(this);
    }

    public void TurnRight()
    {
        Debug.Log("The car turns right.");
    }

    public void TurnLeft()
    {
        Debug.Log("The car turns left.");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDriver
{
    void Control(Car car);
}
public class AI : IDriver
{

    private Car m_Car;
    public void Control(Car car)
    {
        m_Car = car;
        Debug.Log("An AI will control the car.");
    }

}

public class Trucker : IDriver
{

    private Car m_Car;
    public void Control(Car car)
    {
        m_Car = car;
        Debug.Log("A trucker will control the car.");
    }

}
public class Human : IDriver
{

    private Car m_Car;
    public void Control(Car car)
    {
        m_Car = car;
        Debug.Log("A human will control the car.");
    }

}

public class Millionaire : IDriver
{
    private Car m_Car;
    public void Control(Car car)
    {
        m_Car = car;
        Debug.Log("A millionaire will control the car.");
    }
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Car m_PlayerCar;
    public Car m_AICar;
    public Car m_TruckerTruck;
    public Car m_FakeCar;

    public Text text;

    void Awake()
    {
        text.text = "Press A to turn LEFT and D to turn RIGHT\nOutput displayed in the debug console";

        //Human plus gas
        IFuel gas = new Gas();
        IDriver humanDriver = new Human();

        m_PlayerCar.SetFuel(gas);
        m_PlayerCar.SetDriver(humanDriver);
        m_PlayerCar.FuelCar();

        //AI plus electric
        IFuel electric = new Electric();
        IDriver artificialIntelligence = new AI();

        m_AICar.SetFuel(electric);
        m_AICar.SetDriver(artificialIntelligence);
        m_AICar.FuelCar();

        //Millionaire plus rainbow
        IFuel rainbow = new Rainbow();
        IDriver millionaire = new Millionaire();

        m_FakeCar.SetFuel(rainbow);
        m_FakeCar.SetDriver(millionaire);
        m_FakeCar.FuelCar();

        //Trucker plus diesel
        IFuel diesel = new Diesel();
        IDriver trucker = new Trucker();

        m_TruckerTruck.SetFuel(diesel);
        m_TruckerTruck.SetDriver(trucker);
        m_TruckerTruck.FuelCar();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_PlayerCar.TurnLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_PlayerCar.TurnRight();
        }
    }

}

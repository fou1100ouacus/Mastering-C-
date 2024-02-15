using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//public class TempratureChangedEventsArgs
//{
//    public double oldTemprature { get; }
//    public double newTemprature { get; }
//    public double Diffrence { get; }


//    public TempratureChangedEventsArgs(double oldTemprature, double newTemprature)
//    {
//        this.oldTemprature = oldTemprature;
//        this.newTemprature = newTemprature;
//        Diffrence = newTemprature - oldTemprature;
//    }
//}

//public class Thermostat
//{                       //     type of defined class
//    public event EventHandler<TempratureChangedEventsArgs> TemperatureChanged;

//    private double oldtempr;
//    private double Currenttempr;

//    public void settemp(double newTemprature)
//    {
//        if (newTemprature != Currenttempr)
//        {
//            oldtempr = Currenttempr;
//            Currenttempr = newTemprature;

//        }
//    }
//    private void OnTempratureChanged(double old, double current)
//    {
//        // call virtual func ==>
//        //call constructor of defined class
//        OnTempratureChanged(new TempratureChangedEventsArgs(old, current));
//    }
//    // protected virtual void
//    protected virtual void OnTempratureChanged(TempratureChangedEventsArgs e)
//    {
//        TemperatureChanged?.Invoke(this, e);
//    }


//}

//public class display
//{
//    public void subscribe(Thermostat thermostat)
//    {
//        // delegate
//        thermostat.TemperatureChanged += HandleTemperatureChange;
//    }
//    public void HandleTemperatureChange(object sender, TempratureChangedEventsArgs e)
//    {
//        Console.WriteLine("\n\nTemperature changed:");
//        Console.WriteLine($"Temperature changed from {e.oldTemprature}°C");
//        Console.WriteLine($"Temperature changed to {e.newTemprature}°C");
//        Console.WriteLine($"Temperature Differance to {e.Diffrence}°C");
//    }
//}
//namespace Temperature_Change_Event_Example
//{





//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            Thermostat tr = new Thermostat();
//            display display = new display();
//            display.subscribe(tr);

//            tr.settemp(0);
//            tr.settemp(1);
//            tr.settemp(2);
//            Console.ReadKey();
//        }
//    }
//}


public class TemperatureChangedEventArgs : EventArgs
{
    public double OldTemperature { get; }
    public double NewTemperature { get; }
    public double Diffrence { get; }


    public TemperatureChangedEventArgs(double OldTemperature, double NewTemperature)
    {
        this.OldTemperature = OldTemperature;
        this.NewTemperature = NewTemperature;
        this.Diffrence = NewTemperature - OldTemperature;
    }
}

public class Thermostat
{
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    private double OldTemperature;
    private double currentTemperature;//0

    public void SetTemperature(double newTemperature)
    {

        if (newTemperature != currentTemperature)
        {
            OldTemperature = currentTemperature;
            currentTemperature = newTemperature;
            OnTemperatureChanged(OldTemperature, currentTemperature);
        }
    }

    private void OnTemperatureChanged(double OldTemperature, double currentTemperature)
    {
        OnTemperatureChanged(new TemperatureChangedEventArgs(OldTemperature, currentTemperature));
    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }

}


public class Display
{
    public void Subscribe(Thermostat thermostat)
    {
        thermostat.TemperatureChanged += HandleTemperatureChange;
    }

    public void HandleTemperatureChange(object sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine("\n\nTemperature changed:");
        Console.WriteLine($"Temperature changed from {e.OldTemperature}°C");
        Console.WriteLine($"Temperature changed to {e.NewTemperature}°C");
        Console.WriteLine($"Temperature Differance to {e.Diffrence}°C");
    }

}


public class Program
{
    static void Main()
    {
        Thermostat thermostat = new Thermostat();
        Display display = new Display();

        display.Subscribe(thermostat);

        thermostat.SetTemperature(25);
        thermostat.SetTemperature(30);
        thermostat.SetTemperature(30);
        thermostat.SetTemperature(30);
        thermostat.SetTemperature(30);
        thermostat.SetTemperature(30);
        thermostat.SetTemperature(30);

        Console.ReadLine();

    }
}


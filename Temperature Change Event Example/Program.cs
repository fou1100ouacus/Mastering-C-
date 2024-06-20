using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    public double OldTemperature;
    public double currentTemperature;//0

    public void SetTemperature(double newTemperature)
    {

        if (newTemperature != currentTemperature)
        {
            OldTemperature = currentTemperature;
            currentTemperature = newTemperature;
            OnTemperatureChanged(OldTemperature, currentTemperature);
        }
    }

    public void OnTemperatureChanged(double OldTemperature, double currentTemperature)
    {
        OnTemperatureChanged(new TemperatureChangedEventArgs(OldTemperature, currentTemperature));
    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
    //private static bool SaveChanges()
    //{
    ////    return OnTemperatureChanged( new TemperatureChangedEventArgs (,));
    //    //if(())
    //    //{
    //    //    return true;
    //    //}
    //    //return false;
    //}
    

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
        //Thermostat thermostat = new Thermostat();
        //Display display = new Display();

        //display.Subscribe(thermostat);

        //thermostat.SetTemperature(25); // 0 to 25 
        //thermostat.SetTemperature(30);
        //thermostat.SetTemperature(30);
        //thermostat.SetTemperature(30);
        //thermostat.SetTemperature(30);
        //thermostat.SetTemperature(30);
        //thermostat.SetTemperature(30);

        //Console.ReadLine();

    }
}


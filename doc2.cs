using System;

     Interface I1Vehiculo  
      {
     void Drive ();
     
     bool Refuel (int addfuel);
     }  
    class Car Builder:IVehiculo 
     {
        public int startfuel;
        public void Gasoline(int startfuel)
        {
        Console.WriteLine("Gasoline amount :"+startfuel);
    public void Drive ()
    {
        if(startfuel>0)
        {
        Console.WriteLine("Car is driving");
        }
        else
        {
          Console.WriteLine("Car Strucks");  
        }
    }
     public bool Refuel ( int addfuel);
      {
         Console.WriteLine("add the fuel :"+addfuel); 
         totalFuel = startfuel +addfuel;
         Console.WriteLine("total fuel :"+totalfuel);
      }
        }
    static void Main()
    {
     Car car = new Car();
     car.Gasoline(0)
     car.Drive();
    }
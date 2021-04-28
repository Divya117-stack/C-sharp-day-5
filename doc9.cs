using System;
					
public class Employee
{
public struct employeeAddress
{
      
    
    public string City;
    public string State;
}
struct employee
{
      
    
    public string Name;
    public int Id;
    public employeeAddress A1;
}

	public static void Main()
	{
		   
        employee emp;
  
        
        emp.Name = "Raman";
        emp.Id = 102;
          
       
        emp.A1.City = "Coimbatore";
        emp.A1.State = "TamilNadue";
          
        
        Console.WriteLine("Name: " +emp.Name);
        Console.WriteLine("Age: " +emp.Id);
        Console.WriteLine("City: " +emp.A1.City);
        Console.WriteLine("State: " +emp.A1.State);
		
	}
	}
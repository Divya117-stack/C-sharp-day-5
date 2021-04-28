using system;
class People
    {
    public string Name;
    public People(string _name)
    {
      
      Name = _name;
    }
public override string Name()
    {
        return "hello my name is" +Name;
    }
    ~People()
    {
        Name = string.empty;
    }
    }
    public static void Main()
      {
          int total = 3;
     People[] people = new People[total];
      for (int i = 0; i < total; i++)
     {
       people[i]= new People(Console.ReadLine());
      
      }
       for (int i = 0; i < total; i++)
     {
       
       Console.writeLine(people[i].ToString());
      }
    
     }
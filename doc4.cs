	using System;
class Photobook
{
public int numPages;
public void GetNumberPages()
{
   
    return NumberPages;
}
public PhotoBook()
{
    numPages = 16;
    
}
public PhotoBook (int a)
{
    Console.WriteLine("The no.of album pages "+a);
}
}
class BigPhotoBook : Photobook
{
    public BigPhotoBook()
    {
    numPages = 64;
    }
}
class Test
{
public static void Main()
{
  Photobook pb = new Photobook();
  Console.WriteLine("no.of page in photobook"+pb.GetNumPages());
  Photobook pb1 = new Photobook(24);
  BigPhotoBook bp = new BigPhotoBook(); 
   Console.WriteLine("no.of page in bigphotobook"+bp.GetNumPages());
}
}
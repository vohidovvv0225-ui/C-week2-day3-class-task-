public class Student
{
    public int Id{get; set;}
    public string Name{get; set;}
     public int Age{get; set;}
     public double Avarage{get; set;}

     public void GetInfo()
    {
        System.Console.WriteLine($"ID={Id}; Name:{Name}; Age: {Age}; Avarage Grade:{Avarage} ");
    }
    public bool IsExcellentStudent()
    {
        if (Avarage > 4.00)
        {
            return true;
        }
        else
        {
           return false;
        }
    }
}
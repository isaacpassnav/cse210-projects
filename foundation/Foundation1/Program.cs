using System;

// class Program
// {
//     // static void Main(string[] args)
//     // {
//     //     Console.WriteLine("Hello Foundation1 World!");
//     // }
//     public class Person
//     { // The C# convention is to start member variables with an underscore _
//         public string _givenName = "";
//         public string _familyName = "";
//     // A special method, called a contructor that is invoked using the new keyword, CLASS MAME and ()
//         public Person()
//         {

//         }
//         public void ShowEasternName()
//         {
//             Console.WriteLine($"{_familyName}, {_givenName}");
//         }
//         public void ShowWesternName()
//         {
//             Console.WriteLine($"{_givenName}, {_familyName}");
//         }
        
//     }
// }
class Program
{
    public class Blind
    {
        public double _width ;
        public double _heigth;
        public string _color = "";

        public double GetArea()
        {
            return _width * _heigth;
        }
    }
    public class House
    {
        public string _owner = "";
        public Blind _kitchen = new Blind();
        public Blind _livingRoom = new Blind();
    }

    static void Main(string[] args)
    {
        House isaacsHome = new House();
        isaacsHome._owner = "Pasapera Family";
        isaacsHome._kitchen._width = 60;
        // Blind kitchen = new Blind();

        // kitchen._width = 60;
        // kitchen._heigth = 48;
        // kitchen._color = "Black";

        // double materialAmount = kitchen.GetArea();
        // Console.WriteLine($"Width:{kitchen._width}, Height:{kitchen._heigth}, Color:{kitchen._color}");
        // Console.WriteLine($"Material amount:{materialAmount}");
    }

}

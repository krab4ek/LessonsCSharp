using SimpleGC;
using System.Globalization;

Console.WriteLine("***** Simple GC *****");
Car refToMyCar = new Car("Valera", 78);
Console.WriteLine(refToMyCar.ToString());
//do MakeACar();
//while (true);
MakeACar();
static void MakeACar()
{
    Car myCar = new Car("Boris",56);
    Console.WriteLine(myCar.ToString);
}

string str = "5,0";
NumberFormatInfo number = new NumberFormatInfo()
{
    NumberDecimalSeparator = ",",
};

double d1 = double.Parse(str, number);
Console.WriteLine(d1);
Console.ReadLine();
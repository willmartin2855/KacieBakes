using DougExamples;

Console.WriteLine("Hello, World!");

Car dougsCar;
try
{
    dougsCar = new Car("asdf");
}
catch (Exception)
{
    //do some error handling, like log to a file that something broke
    throw;
}
dougsCar.Color = "blue";
//dougsCar.VinNumber = "asdh";

dougsCar.Drive();

Console.WriteLine(dougsCar.Color);
Console.ReadLine();

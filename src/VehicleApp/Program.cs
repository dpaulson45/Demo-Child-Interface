// See https://aka.ms/new-console-template for more information
using VehicleApp;

Console.WriteLine("Simple Vehicle App");
Car car = new Car();
IVehicle iCar = new Car();
Truck truck = new Truck();
IVehicle iTruck = new Truck();

Display.DisplayNewSection("Different Types");
//even though the types are the same, we can't do the same thing with the object.
Console.WriteLine("This is the type of car: {0}", car.GetType().ToString());
Console.WriteLine("This is the type of iCar: {0}", iCar.GetType().ToString());
//iCar.IsSportsCar; 
Console.WriteLine("But iCar doesn't have access to IsSportsCar, because it isn't in the interface");

Console.WriteLine("This is the type of truck: {0}", truck.GetType().ToString());
Console.WriteLine("This is the type of iTruck: {0}", iTruck.GetType().ToString());
Console.WriteLine("But iTruck doesn't have access to SupperCab, because it isn't in the interface");

Display.DisplayNewSection("Running Dipslay");
Console.WriteLine("On car");
//You can call the interface type here because car inherits BaseVehicle which uses the IVehicle interface.
Display.DisplayInterface(car);
Console.WriteLine("On iCar");
Display.DisplayInterface(iCar);

Console.WriteLine("On truck");
Display.DisplayInterface(truck);
Console.WriteLine("On iTruck");
Display.DisplayInterface(iTruck);

Display.DisplayNewSection("Displaying Parent Info");
//can't call DisplayParent here for the interface type because we can't convert the interface type to BaseVehicle type.
Display.DisplayParent(car);
Display.DisplayParent(truck);


Console.WriteLine();

Console.ReadKey();
// See https://aka.ms/new-console-template for more information


//Plane Plane1 = new Plane();
//Plane1.Capacity = 200;
//Plane1.ManufactureDate = new DateTime(2023, 01, 31);
//Plane1.planeType = PlaneType.Airbus;
//Plane Plane2 = new Plane(PlaneType.Boing, 500, new DateTime(2022, 05, 23));
using AM.ApplicationCore.Domain;

Plane Plane3 = new Plane
{
    Capacity = 3,
    ManufactureDate = new DateTime(2023, 02, 01),
    planeType = PlaneType.Boing
};

Passenger passenger1 = new Passenger
{
FirstName= "Foo",
LastName= "Bar",
EmailAdress="FooBar@esprit.tn"
};
Console.WriteLine(passenger1.CheckProfile("Rayen", "Bakali"));

Traveller traveller1 = new Traveller
{
    FirstName = "Zaineb",
    LastName = "Bouallegui",
 Nationality="tunisienne"
};
Console.WriteLine("traveller1:");
traveller1.PassengerType();

staff staff1 = new staff
{

    FirstName = "aa",
    LastName = "bb",
    Salary = 1000.0
};
Console.WriteLine("staff1:");
staff1.PassengerType();


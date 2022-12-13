using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        CarTest();
        DtoTest();
        test();
    }

    static void test()
    {
        Console.WriteLine("hello");
    }

    static void DtoTest()
    {
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var item in carManager.GetCarDetails())
    {
        Console.WriteLine(item.CarName + " / " + item.BrandName);
    }
    }

    static void CarTest()
    {
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var item in carManager.GetAll())
    {
        Console.WriteLine("Car ID : " + item.Id + " Car name : " + item.Description + " Brand ID : " + item.BrandId + " Color ID : " + item.ColorId + " Daily Price : " + item.DailyPrice + " ModelYear : " + item.ModelYear + " Description : " + item.Description);
    }
    }

}


//Console.WriteLine(carManager.Get(2).Description);

//CarManager carManager = new CarManager(new InMemoryCarDal());

//Console.WriteLine("Current Car List : ");
//foreach (var item in carManager.GetAll())
//{
//    Console.WriteLine($"Id : {item.Id} , Car Name : {item.Description}");
//}

//Console.WriteLine("----Add-------");
//carManager.Add(new Car() { Id = 6, BrandId = 63, ColorId = 53, DailyPrice = 2500, ModelYear = 1984, Description = "Ford Maya Concept" });
//carManager.Add(new Car() { Id = 7, BrandId = 46, ColorId = 28, DailyPrice = 3200, ModelYear = 1989, Description = "Callaway Speedster Corvette" });

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine($"{car.Id} {car.ColorId} {car.Description}");

//}
//Console.WriteLine("New Cars ; Ford Maya Concept , Callaway Speedster Corvette");

//Console.WriteLine("-----Update-----");
//carManager.Update(new Car() { Id = 7, BrandId = 35, ColorId = 10, DailyPrice = 6200, ModelYear = 1988, Description = "Jaguar XJ220 Prototype" });
//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine($"{car.Id} {car.ColorId} {car.Description}");

//}
//Console.WriteLine("Updated : Callaway Speedster Corvette > Jaguar XJ220 Prototype ");

//Console.WriteLine("-----Delete-----");

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine($"{car.Id} {car.ColorId} {car.Description}");

//}
//Console.WriteLine("Deleted : Jaguar XJ220 Prototype ");

//Console.WriteLine("--GetById--");
//foreach (var item in carManager.GetById(1))
//{
//    Console.WriteLine($"{item.Id} {item.BrandId} {item.DailyPrice} {item.Description}");
//}
//Console.WriteLine("Car id number is 1 shown.");


//Car car1 = new Car
//{
//    BrandId = 1,
//    ColorId = 1,
//    ModelYear = 2019,
//    DailyPrice = -300,
//    Description = "Audi A5"
//};

//ICarServices carService = new CarManager(new EfCarDal());
//carService.Add(car1);
//Console.WriteLine("-------");
//List<Car> cars = carService.GetCarsByColorId(1);
//foreach (var car in cars)
//{
//    Console.WriteLine($"Car Name : {car.Description}, Daily Price : {car.DailyPrice}");
//}

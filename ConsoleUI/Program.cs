using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using Core.Entities.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Color = Entities.Concrete.Color;

class Program
{
    static void Main(string[] args)
    {
        //CarAllTest();
        //Add();
        //Delete();
        //Update();
        //GetById();
        //BrandManagerTest();
        //ColorManagerTest();
        //RentalManagerTest();
        //CustomerManagerTest();
        //UserManagerTest();
        //testc();
        //test();
    }
}

    //private static void testc()
    //{
    //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    //    var result2 = customerManager.GetAll();
    //    foreach (var customer in result2.Data)
    //    {
    //        Console.WriteLine(customer.UserId + " " + customer.CompanyName);
    //    }
    //    Console.WriteLine(Messages.ListedCustomers);
    //}

    //private static void UserManagerTest()
    //{
    //    UserManager userManager = new UserManager(new EfUserDal());
    //    userManager.Add(new User { UserId = 1, FirstName = "Dan", LastName = "Ferdinand", Email = "Dan_Ferdinand@gmail.com", Password = "Re6N72fPeNfK" });
    //    userManager.Add(new User { UserId = 2, FirstName = "Antania", LastName = "Cato", Email = "Antania_Cato@gmail.com", Password = "Ij6703DWnm3p" });
    //    userManager.Add(new User { UserId = 3, FirstName = "Phil", LastName = "Themar", Email = "Phil_Themar@gmail.com", Password = "2g23lIQCccQF" });
    //    userManager.Delete(new User { UserId = 3 });
    //    userManager.Update(new User { UserId = 2, FirstName = "John", LastName = "Danton", Email = "John_Danton@gmail.com", Password = "Ij6703DWnm3p" });    
    //    var result3 = userManager.GetAll();
    //    foreach (var user in result3.Data)
    //    {
    //        Console.WriteLine(user.FirstName + " " + user.LastName );
    //    }
    //    Console.WriteLine(result3.Message);
    //}

    //private static void CustomerManagerTest()
    //{
    //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    //    customerManager.Add(new Customer{ UserId = 1, CompanyName = "Empire" });
    //    customerManager.Add(new Customer { UserId = 2, CompanyName = "Royal" });
    //    customerManager.Add(new Customer { UserId = 3, CompanyName = "Kingdom" });
    //    var result2 = customerManager.GetAll();
    //    foreach (var customer in result2.Data)
    //    {
    //        Console.WriteLine(customer.UserId + " " +customer.CompanyName);
    //    }
    //    Console.WriteLine(Messages.ListedCustomers);
    //}

//    private static void RentalManagerTest()
//    {
//        RentalManager rentalManager = new RentalManager(new EfRentalDal());
//        rentalManager.Add(new Rental { Id = 1 , CarId = 5 , CustomerId = 17 , RentDate= DateTime.Now });
//        rentalManager.Add(new Rental { Id = 2, CarId = 8, CustomerId = 11, RentDate = DateTime.Now });
//        rentalManager.Add(new Rental { Id = 3, CarId = 3, CustomerId = 9, RentDate = DateTime.Now });
//        rentalManager.Delete(new Rental { Id = 3 });
//        //var result = rentalManager.Add(new Rental { Id = 12, CarId = 4, CustomerId = 13, RentDate = DateTime.Now });
        
//        var result = rentalManager.GetAll();
//        foreach (var rent in result.Data)
//        {
//            Console.WriteLine(rent.CustomerId);
//        }
//        Console.WriteLine(result.Message);
//    }

//    static void ColorManagerTest()
//    {
//        ColorManager colorManager = new ColorManager(new EfColorDal());
//        colorManager.Add(new Color { ColorId = 6, ColorName = "Yellow" });
//        colorManager.Add(new Color { ColorId = 7, ColorName = "Pink" });
//        colorManager.Add(new Color { ColorId = 8, ColorName = "Grey" });
//        colorManager.Delete(new Color { ColorId = 8 });
//        Console.WriteLine(Messages.Deleted);
//        colorManager.Update(new Color { ColorId = 6, ColorName = "Orange" });
//        Console.WriteLine(Messages.Updated);
//        foreach (var color in colorManager.Get(6).Data)
//        {
//            Console.WriteLine(Messages.ColorAdded);
//            Console.WriteLine(color.ColorName);
//        }


//    }
//    static void BrandManagerTest()
//    {
//        BrandManager brandManager = new BrandManager(new EfBrandDal());
//        brandManager.Add(new Brand { BrandId = 6, BrandName = "Bently" });
//        brandManager.Add(new Brand { BrandId = 7, BrandName = "Bugatti" });
//        foreach (var brand in brandManager.Get(6).Data)
//        {
//            Console.WriteLine(Messages.BrandAdded);
//            Console.WriteLine(brand.BrandName);
//        }
        
        
//    }

//    static void GetById()
//    {
//        CarManager carManager = new CarManager(new EfCarDal());
//        Console.WriteLine(Messages.CarsListed);
//        Console.WriteLine(carManager.GetById(4));


//    }

//    static void Delete()
//    {
//        CarManager carManager = new CarManager(new EfCarDal());
//        carManager.Delete(new Car() { Id = 110 });
//        Console.WriteLine(Messages.Deleted);
        
//        foreach (var item in carManager.GetAll().Data)
//        {
//            Console.WriteLine("Car ID : " + item.Id + " Car name : " + item.Description + " Brand ID : " + item.BrandId + " Color ID : " + item.ColorId + " Daily Price : " + item.DailyPrice + " ModelYear : " + item.ModelYear + " Description : " + item.Description);
//        }
//    }

//    static void Update()
//    {
//        CarManager carManager = new CarManager(new EfCarDal());
//        carManager.Update(new Car() { Id = 110, BrandId = 10, ColorId = 12, DailyPrice = 3500, ModelYear = 1950, Description = "Audi" });
//        Console.WriteLine(Messages.Updated);

//        foreach (var item in carManager.GetAll().Data)
//        {
//            Console.WriteLine("Car ID : " + item.Id + " Car name : " + item.Description + " Brand ID : " + item.BrandId + " Color ID : " + item.ColorId + " Daily Price : " + item.DailyPrice + " ModelYear : " + item.ModelYear + " Description : " + item.Description);
//        }
//    }



//    static void Add()

//    {
//        CarManager carManager = new CarManager(new EfCarDal());
//        var car1 = new Car();
//        carManager.Add(new Car() { Id = 110, BrandId = 5, ColorId = 13, DailyPrice = 1000, ModelYear = 1956, Description = "Ford" });
//        Console.WriteLine(Messages.CarAdded);
//    }

//    static void CarAllTest()
//    {
//        CarManager carManager = new CarManager(new EfCarDal());
//        foreach (var item in carManager.GetAll().Data)
//        {
//        Console.WriteLine("Car ID : " + item.Id + " Car name : " + item.Description + " Brand ID : " + item.BrandId + " Color ID : " + item.ColorId + " Daily Price : " + item.DailyPrice + " ModelYear : " + item.ModelYear + " Description : " + item.Description);
//        }
//    }

//}


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

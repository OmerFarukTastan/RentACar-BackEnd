using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car { Id = 1 , BrandId = 23 , ColorId = 65 , ModelYear = 1982 , DailyPrice = 2000 , Description = "Porsche 989"},
                new Car { Id = 2, BrandId = 78, ColorId = 58, ModelYear = 1986, DailyPrice = 3000, Description = "Lamborghini LM002" },
                new Car { Id = 3, BrandId = 55, ColorId = 45, ModelYear = 1988, DailyPrice = 4000, Description = "Porsche 928 S4 Clubsport" },
                new Car { Id = 4, BrandId = 68, ColorId = 83, ModelYear = 1987, DailyPrice = 5000, Description = "Alpina B6 S" },
                new Car { Id = 5, BrandId = 92, ColorId = 23, ModelYear = 1989, DailyPrice = 6000, Description = "Mercedes-Benz 500 SL" },

            };
        }
        
        public void Add(Car car)
        {
            bool result = false;    
            for (int i = 0; i < _cars.Count; i++)
            {
                if (_cars[i].Id == car.Id )
                {
                    result = true;  
                    break;
                }
            }

            if (result == true)
            {
                Console.WriteLine("Invalid Car");

            }
            else
            {
                _cars.Add(car);
                Console.WriteLine("Car Added");
            }
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }
        

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(int id)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }
    }

}

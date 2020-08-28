using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _catigoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car { name = "Tesla", Category =  _catigoryCars.AllCategories.First() },
                    new Car { name = "Nissan", Category =  _catigoryCars.AllCategories.Last()},
                    new Car { name = "Mercedes", Category =  _catigoryCars.AllCategories.Last()}
                };
            }
        }
        public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

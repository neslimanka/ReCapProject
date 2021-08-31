using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car{ Id=1,BrandId=1,ColorId=1,CarName="BMW", ModelYear=1995, Description="1995 Model" ,Price=20},
                 new Car{ Id=2,BrandId=2,ColorId=2,CarName="Audi", ModelYear=1994, Description="1994 Model",Price=0 },
                  new Car{ Id=3,BrandId=3,ColorId=3,CarName="Ford", ModelYear=1993, Description="1993 Model",Price=9 },
                   new Car{ Id=4,BrandId=4,ColorId=4,CarName="cb", ModelYear=1992, Description="1992 Model",Price=0 },
                    new Car{ Id=5,BrandId=5,ColorId=5,CarName="ab", ModelYear=1991, Description="1991 Model",Price=5 },
            };
        }

        public void Add(Car entity)
        {
            _car.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == entity.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == entity.Id);
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ModelYear = entity.ModelYear;
            carToUpdate.Description = entity.Description;
            carToUpdate.CarName = entity.CarName;
            carToUpdate.Price = entity.Price;
        }
    }
}

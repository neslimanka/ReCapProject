using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentaldal)
        {
            _rentalDal = rentaldal;
        }
        public IResult Add(Rental rental)
        {
            return new SuccessResult(Messages.Addeded);
        }

        public IResult Delete(Rental rental)
        {
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(re => re.Id == id), Messages.Listed);
        }

        public IResult Update(Rental rental)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}

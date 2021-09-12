using Business.Constant;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ConsumerManager : IConsumerService
    {
        IConsumerDal _consumerDal;

        public ConsumerManager(IConsumerDal consumerDal)
        {
            _consumerDal = consumerDal;
        }

  
        public IDataResult<Consumer> GetById(int id)
        {
            return new SuccessDataResult<Consumer>(_consumerDal.Get(u => u.Id == id), Messages.GetConsumer);
        }

        public IDataResult<Consumer> GetByMail(string email)
        {
            var consumers = _consumerDal.GetAll();
            var consumer = consumers.FirstOrDefault(u => u.Email == email);

            if (consumer == null)
                return new ErrorDataResult<Consumer>(Messages.UserNotFound);

            return new SuccessDataResult<Consumer>(consumer, Messages.UserAlreadyExists);
        }

        public IDataResult<List<OperationClaim>> GetClaims(Consumer consumer)
        {
            return new SuccessDataResult<List<OperationClaim>>(_consumerDal.GetClaims(consumer));
        }

        public IResult  Add(Consumer consumer)
        {
            _consumerDal.Add(consumer);
            return new SuccessResult(Messages.ConsumerAdded);
        }

        public IDataResult<List<Consumer>> GetAll()
        {
            return new SuccessDataResult<List<Consumer>>(_consumerDal.GetAll(), Messages.ConsumerAdded);
        }

        public IResult Update(Consumer  consumer)
        {
            _consumerDal.Update(consumer);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IResult Delete(Consumer consumer)
        {
            _consumerDal.Delete(consumer);
            return new SuccessResult(Messages.ConsumerDeleted);
        }
    }
}

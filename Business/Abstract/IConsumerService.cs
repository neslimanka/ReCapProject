using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IConsumerService
    {
        IDataResult<Consumer> GetById(int id);
        IDataResult<Consumer> GetByMail(string email);
        IDataResult<List<Consumer>> GetAll();
        IDataResult<List<OperationClaim>> GetClaims(Consumer consumer);
        IResult Add(Consumer consumer);
        IResult Update(Consumer consumer);
        IResult Delete(Consumer consumer);
    }
}

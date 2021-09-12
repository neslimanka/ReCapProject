using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTO;

namespace DataAccess.Abstract
{
    public interface IAuthService
    {
        IDataResult<Consumer> Register(ConsumerForRegisterDto userForRegisterDto, string password);
        IDataResult<Consumer> Login(ConsumerForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Consumer consumer);
    }
}



using Business.Constant;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IConsumerService _consumerService;
        private ITokenHelper _tokenHelper;
        public AuthManager(IConsumerService consumerService, ITokenHelper tokenHelper)
        {
            _consumerService = consumerService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<AccessToken> CreateAccessToken(Consumer consumer)
        {
            var claims = _consumerService.GetClaims(consumer);
            var accessToken = _tokenHelper.CreateToken(consumer, claims.Data);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

        public IDataResult<Consumer> Login(ConsumerForLoginDto consumerForLoginDto)
        {
            var consumerToCheck = _consumerService.GetByMail(consumerForLoginDto.Email);

            if (!consumerToCheck.Success)
                return new ErrorDataResult<Consumer>(Messages.UserNotFound);

            if (!HashingHelper.VerifyPasswordHash(consumerForLoginDto.Password, consumerToCheck.Data.PasswordHash, consumerToCheck.Data.PasswordSalt))
                return new ErrorDataResult<Consumer>(Messages.PasswordError);

            return new SuccessDataResult<Consumer>(consumerToCheck.Data, Messages.SuccessfulLogin);
        }

        public IDataResult<Consumer> Register(ConsumerForRegisterDto consumerForRegisterDto, string password)
        {
            HashingHelper.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            var consumer = new Consumer
            {
                Email = consumerForRegisterDto.Email,
                FirstName = consumerForRegisterDto.FirstName,
                LastName = consumerForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };

            _consumerService.Add(consumer);
            return new SuccessDataResult<Consumer>(consumer, Messages.UserRegistered);
        }

        public IResult UserExists(string email)
        {
            var result = _consumerService.GetByMail(email);
            if (result.Success)
                return new ErrorResult(Messages.UserAlreadyExists);

            return new SuccessResult();
        }
    }

}

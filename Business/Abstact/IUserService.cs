﻿using Core.Entities.Concrete;
using Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstact
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserId(int id);
        IDataResult<List<User>> GetBlogsPaginated(int pageNumber, int pageSize);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}

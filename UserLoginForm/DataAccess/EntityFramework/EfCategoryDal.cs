using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginForm.DataAccess.EntityFramework.Context;
using UserLoginForm.Entities;

namespace UserLoginForm.DataAccess.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, VotingContext>, ICategoryDal
    {

    }
}

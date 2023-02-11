using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginForm.Entities;

namespace UserLoginForm.DataAccess
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}

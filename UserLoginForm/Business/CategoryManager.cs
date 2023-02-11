using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginForm.Core;
using UserLoginForm.DataAccess;
using UserLoginForm.DataAccess.EntityFramework;
using UserLoginForm.Entities;

namespace UserLoginForm.Business
{
    public class CategoryManager
    {
        private EfCategoryDal _efCategoryDal;
        Category _category;
        public CategoryManager(EfCategoryDal efCategoryDal, Category category)
        {
            _efCategoryDal = efCategoryDal;
            _category = category;
        }

        public void Add(Category category)
        {
            _efCategoryDal.Add(category);
        }



        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_efCategoryDal.GetList().ToList());
        }

        public List<Category> GetCategory()
        {
            return _efCategoryDal.GetList().ToList();
        }

        public List<Category> GetDistincCategory()
        {
            return _efCategoryDal.GetListWithGroupBy(groupBy: "CategoryName").ToList();
        }

        public List<Category> GetCategoryByName(string categoryName)
        {
            return _efCategoryDal.GetList(filter: p => p.CategoryName == categoryName).ToList();
        }

    }
}

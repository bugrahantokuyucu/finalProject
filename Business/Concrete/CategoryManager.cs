using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorDal;

        public CategoryManager(ICategoryDal categorDal)
        {
            _categorDal = categorDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları
            return _categorDal.GetAll();
            
        }

        public Category GetById(int categoryId)
        {
            return _categorDal.Get(c => c.CategoryId == categoryId);
        }
    }
}

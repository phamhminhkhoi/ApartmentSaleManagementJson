using BusinessObjectLayer.JsonModel;
using DataAccessLayer.JsonDAO;
using RepositoryLayer.JsonInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.JsonImplements
{
    public class CategoryJsonRepository : ICategoryJsonRepository
    {
        private readonly CategoryDAO _categoryDAO;

        public CategoryJsonRepository()
        {
            _categoryDAO = new CategoryDAO();
        }
        public void AddCategory(PropertyCategory newCategory)
        {
            _categoryDAO.AddCategory(newCategory);
        }

        public void DeleteCategory(int categoryId)
        {
            _categoryDAO.DeleteCategory(categoryId);
        }

        public List<PropertyCategory> GetAllCategories()
        {
            return _categoryDAO.GetAllCategories();
        }

        public PropertyCategory GetCategoryById(int categoryId)
        {
            return _categoryDAO.GetCategoryById(categoryId);
        }

        public void UpdateCategory(PropertyCategory updatedCategory)
        {
            _categoryDAO.UpdateCategory(updatedCategory);
        }
    }
}

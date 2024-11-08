using RepositoryLayer.JsonInterfaces;
using ServiceLayer.JsonInterfaces;
using BusinessObjectLayer.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.JsonImplements
{
    public class CategoryJsonService : ICategoryJsonService
    {
        private readonly ICategoryJsonRepository _categoryJsonRepository;
        public CategoryJsonService(ICategoryJsonRepository categoryJsonRepository) 
        {
            _categoryJsonRepository = categoryJsonRepository;
        }
        public void AddCategory(PropertyCategory newCategory)
        {
             _categoryJsonRepository.AddCategory(newCategory);
        }

        public void DeleteCategory(int categoryId)
        {
            _categoryJsonRepository.DeleteCategory(categoryId);
        }

        public List<PropertyCategory> GetAllCategories()
        {
            return _categoryJsonRepository.GetAllCategories();
        }

        public PropertyCategory GetCategoryById(int categoryId)
        {
            return _categoryJsonRepository.GetCategoryById(categoryId);
        }

        public void UpdateCategory(PropertyCategory updatedCategory)
        {
            _categoryJsonRepository.UpdateCategory(updatedCategory);
        }
    }
}

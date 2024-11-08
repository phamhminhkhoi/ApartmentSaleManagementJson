using BusinessObjectLayer.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.JsonInterfaces
{
    public interface ICategoryJsonRepository
    {
        List<PropertyCategory> GetAllCategories();
        PropertyCategory GetCategoryById(int categoryId);
        void AddCategory(PropertyCategory newCategory);
        void UpdateCategory(PropertyCategory updatedCategory);
        void DeleteCategory(int categoryId);
    }
}

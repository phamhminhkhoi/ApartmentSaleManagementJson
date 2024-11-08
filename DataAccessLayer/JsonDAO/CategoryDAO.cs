using BusinessObjectLayer.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataAccessLayer.JsonDAO
{
    public class CategoryDAO
    {
        private readonly string _jsonFilePath = "..\\BusinessObjectLayer\\JsonModel\\data.json";
        private SaleManagementData _data;

        public CategoryDAO()
        {
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(_jsonFilePath))
            {
                string jsonData = File.ReadAllText(_jsonFilePath);
                _data = JsonSerializer.Deserialize<SaleManagementData>(jsonData) ?? new SaleManagementData();
            }
            else
            {
                _data = new SaleManagementData();
            }
        }

        private void SaveData()
        {
            string jsonData = JsonSerializer.Serialize(_data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_jsonFilePath, jsonData);
        }

        public List<PropertyCategory> GetAllCategories()
        {
            return _data.PropertyCategories ?? new List<PropertyCategory>();
        }

        public PropertyCategory GetCategoryById(int categoryId)
        {
            return _data.PropertyCategories?.FirstOrDefault(c => c.CategoryId == categoryId);
        }

        public void AddCategory(PropertyCategory newCategory)
        {
            _data.PropertyCategories ??= new List<PropertyCategory>();
            _data.PropertyCategories.Add(newCategory);
            SaveData();
        }

        public void UpdateCategory(PropertyCategory updatedCategory)
        {
            var category = _data.PropertyCategories?.FirstOrDefault(c => c.CategoryId == updatedCategory.CategoryId);
            if (category != null)
            {
                category.CategoryName = updatedCategory.CategoryName;
                SaveData();
            }
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _data.PropertyCategories?.FirstOrDefault(c => c.CategoryId == categoryId);
            if (category != null)
            {
                _data.PropertyCategories.Remove(category);
                SaveData();
            }
        }
    }
}

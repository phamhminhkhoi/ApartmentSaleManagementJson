using BusinessObjectLayer.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataAccessLayer.JsonDAO
{
    public class PropertyDAO
    {
        private readonly string _jsonFilePath = "C:\\Users\\phamk\\Desktop\\PRN221\\ApartmentSaleManagement RazorPage\\ApartmentSaleManagementRazor\\BusinessObjectLayer\\JsonModel\\data.json";
        private SaleManagementData _data;

        public PropertyDAO()
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

        public List<Property> GetAllProperties()
        {
            return _data.Properties ?? new List<Property>();
        }

        public Property GetPropertyById(int propertyId)
        {
            return _data.Properties?.FirstOrDefault(p => p.PropertyId == propertyId);
        }

        public void AddProperty(Property newProperty)
        {
            _data.Properties ??= new List<Property>();
            _data.Properties.Add(newProperty);
            SaveData();
        }

        public void UpdateProperty(Property updatedProperty)
        {
            var property = _data.Properties?.FirstOrDefault(p => p.PropertyId == updatedProperty.PropertyId);
            if (property != null)
            {
                property.PropertyName = updatedProperty.PropertyName;
                property.Location = updatedProperty.Location;
                property.Description = updatedProperty.Description;
                property.Price = updatedProperty.Price;
                property.SizeSqFt = updatedProperty.SizeSqFt;
                property.Bedrooms = updatedProperty.Bedrooms;
                property.Bathrooms = updatedProperty.Bathrooms;
                property.CategoryId = updatedProperty.CategoryId;
                SaveData();
            }
        }

        public void DeleteProperty(int propertyId)
        {
            var property = _data.Properties?.FirstOrDefault(p => p.PropertyId == propertyId);
            if (property != null)
            {
                _data.Properties.Remove(property);
                SaveData();
            }
        }
    }
}

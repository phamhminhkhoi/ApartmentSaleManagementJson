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
    public class PropertyJsonRepository : IPropertyJsonRepository
    {
        private readonly PropertyDAO _propertyDao;

        public PropertyJsonRepository()
        {
            _propertyDao = new PropertyDAO();  // Initialize DAO instance
        }

        public List<Property> GetAllProperties()
        {
            return _propertyDao.GetAllProperties();
        }

        public Property GetPropertyById(int propertyId)
        {
            return _propertyDao.GetPropertyById(propertyId);
        }

        public void AddProperty(Property property)
        {
            _propertyDao.AddProperty(property);
        }

        public void UpdateProperty(Property property)
        {
            _propertyDao.UpdateProperty(property);
        }

        public void DeleteProperty(int propertyId)
        {
            _propertyDao.DeleteProperty(propertyId);
        }
    }

}

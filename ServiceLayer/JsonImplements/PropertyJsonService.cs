using BusinessObjectLayer.JsonModel;
using RepositoryLayer.JsonInterfaces;
using ServiceLayer.JsonInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.JsonImplements
{
    public class PropertyJsonService : IPropertyJsonService
    {
        private readonly IPropertyJsonRepository _propertyRepository;

        public PropertyJsonService(IPropertyJsonRepository propertyJsonRepository)
        {
            _propertyRepository = propertyJsonRepository;
        }

        public List<Property> GetAllProperties()
        {
            return _propertyRepository.GetAllProperties();
        }

        public Property GetPropertyById(int propertyId)
        {
            return _propertyRepository.GetPropertyById(propertyId);
        }

        public void CreateProperty(Property property)
        {
            _propertyRepository.AddProperty(property);
        }

        public void UpdateProperty(Property property)
        {
            _propertyRepository.UpdateProperty(property);
        }

        public void RemoveProperty(int propertyId)
        {
            _propertyRepository.DeleteProperty(propertyId);
        }
    }

}

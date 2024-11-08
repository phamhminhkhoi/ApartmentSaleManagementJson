using BusinessObjectLayer.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.JsonInterfaces
{
    public interface IPropertyJsonRepository
    {
        List<Property> GetAllProperties();
        Property GetPropertyById(int propertyId);
        void AddProperty(Property property);
        void UpdateProperty(Property property);
        void DeleteProperty(int propertyId);
    }

}

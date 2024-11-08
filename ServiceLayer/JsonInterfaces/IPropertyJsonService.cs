using BusinessObjectLayer.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.JsonInterfaces
{
    public interface IPropertyJsonService
    {
        List<Property> GetAllProperties();
        Property GetPropertyById(int propertyId);
        void CreateProperty(Property property);
        void UpdateProperty(Property property);
        void RemoveProperty(int propertyId);
    }
}

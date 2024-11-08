using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObjectLayer.JsonModel;
using ServiceLayer.JsonInterfaces;

namespace PresentationLayer.Pages.Properties
{
    public class IndexModel : PageModel
    {
        private readonly IPropertyJsonService _propertyService;
        private readonly ICategoryJsonService _categoryService;
        public IndexModel(IPropertyJsonService propertyService, ICategoryJsonService categoryService)
        {
            _propertyService = propertyService;
            _categoryService = categoryService;
        }

        public IList<Property> Property { get; set; } = default!;

        public async Task OnGetAsync(string? searchTerm)
        {
            LoadProp();
        }

        private void LoadProp()
        {
            Property = _propertyService.GetAllProperties();
            var ListToShow = new List<Property>();
            foreach (var property in Property) 
            {
                var category = _categoryService.GetCategoryById(property.CategoryId);
                var prop = new Property
                {
                    Bathrooms = property.Bathrooms,
                    Bedrooms = property.Bedrooms,
                    Description = property.Description,
                    Location = property.Location,
                    Price = property.Price,
                    SizeSqFt = property.SizeSqFt,
                    PropertyName = property.PropertyName,
                    CategoryName = category.CategoryName,
                };
                ListToShow.Add(prop);
            }
            Property = ListToShow;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObjectLayer.JsonModel;
using ServiceLayer.Interfaces;
using BusinessObjectLayer.Model;
using ServiceLayer.JsonInterfaces;

namespace PresentationLayer.Pages.Properties
{
    public class CreateModel : PageModel
    {
        private readonly IPropertyJsonService _propertyService;
		private readonly ICategoryJsonService _propertyCategoryService;


		public CreateModel(IPropertyJsonService propertyService, ICategoryJsonService propertyCategoryService)
        {
            this._propertyService = propertyService;
            this._propertyCategoryService = propertyCategoryService; 
        }

        public SelectList CategorySelectList { get; set; }

        public IActionResult OnGet()
        {
            var categories = _propertyCategoryService.GetAllCategories()
                              .Select(c => new PropertyCategoryViewModel
                              {
                                  CategoryId = c.CategoryId,
                                  CategoryName = c.CategoryName
                              });
            CategorySelectList = new SelectList(categories, "CategoryId", "CategoryName");

            return Page();
        }



        [BindProperty]
        public Property Property { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {


			_propertyService.CreateProperty(Property);

            return RedirectToPage("./Index");
        }
    }
}

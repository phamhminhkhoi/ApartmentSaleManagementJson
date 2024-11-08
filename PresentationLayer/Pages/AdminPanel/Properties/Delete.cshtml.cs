using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObjectLayer.JsonModel;
using ServiceLayer.Interfaces;
using ServiceLayer.JsonInterfaces;

namespace PresentationLayer.Pages.Properties
{
    public class DeleteModel : PageModel
    {
        private readonly IPropertyJsonService _propertyService;

        public DeleteModel(IPropertyJsonService propertyService)
        {
            this._propertyService = propertyService;
        }

        [BindProperty]
        public Property Property { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var property = _propertyService.GetPropertyById(id);

            if (property == null)
            {
                return NotFound();
            }
            else
            {
                Property = property;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var property = _propertyService.GetPropertyById(id);
            if (property != null)
            {
                Property = property;
                _propertyService.RemoveProperty(Property.PropertyId);    
            }

            return RedirectToPage("./Index");
        }
    }
}

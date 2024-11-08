using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObjectLayer.JsonModel;
using ServiceLayer.JsonInterfaces;

namespace PresentationLayer.Pages.Properties
{
    public class EditModel : PageModel
    {
        private readonly IPropertyJsonService _propertyService;
        private readonly ICategoryJsonService _propertyCategoryService;
        public EditModel(IPropertyJsonService propertyService, ICategoryJsonService propertyCategoryService)
        {
            this._propertyService = propertyService;
            this._propertyCategoryService = propertyCategoryService;
        }

        [BindProperty]
        public Property Property { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!id.HasValue || id == 0)
            {
                return NotFound();
            }

            var property =  _propertyService.GetPropertyById(id.Value);
            if (property == null)
            {
                return NotFound();
            }

            Property = property;
            var categories =  _propertyCategoryService.GetAllCategories();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName");

            return Page();
        }


        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _propertyService.UpdateProperty(Property);

            return RedirectToPage("./Index");
            //}
            //catch (DbUpdateConcurrencyException)
            //{

            //        return NotFound();

            //}

            //return RedirectToPage("./Index");
        }

        //private bool PropertyExists(int id)
        //{
        //    return _context.Properties.Any(e => e.PropertyId == id);
        //}
    }
}

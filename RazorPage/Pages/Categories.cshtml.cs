using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> CategoriesList { get; set; } = new();


        public void OnGet(int skip =0, int take = 25)
        {


            var temp = new List<Category>();

            for (var i = 0; i <= 1000; i++)
            {
                temp.Add(new Category(i, $"Categoria {i}", i * 18.95M));
            }

            CategoriesList = temp.Skip(skip).Take(take).ToList();

        }

        public void OnPost()
        {
        }


        public record Category(
        int Id,
        string Title,
        decimal Price);

    }
}

using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public List<Recipe_Ingredient> Recipes_Ingredients { get; set; }
    }
}

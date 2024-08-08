using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Recipe_Ingredient> Recipes_Ingredients { get; set; }
    }
}

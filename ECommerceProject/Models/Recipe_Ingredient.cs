using ECommerceProject.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Recipe_Ingredient
    {
        [Key]
        public int Id { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public decimal Quantity { get; set; }
        public Unit Unit { get; set; }
    }
}

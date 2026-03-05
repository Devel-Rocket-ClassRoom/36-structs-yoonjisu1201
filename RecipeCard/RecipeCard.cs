using System;
using System.Collections.Generic;
using System.Text;

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료: ");

        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}: {(ingredient.Amount) * Servings}{ingredient.Unit}");
        }
        Console.WriteLine();
    }

    public RecipeCard ScaleRecipe(int newServings)
    {
        return new RecipeCard(Name, newServings, Ingredients);
    }
}

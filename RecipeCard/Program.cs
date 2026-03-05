using System;
using System.Xml.Linq;

// README.md를 읽고 코드를 작성하세요.
Ingredient[] ingredient1 =
{
    new Ingredient("스파게티면", 100, "g"),
    new Ingredient("토마토소스", 75, "ml"),
    new Ingredient("양파", 0.5, "개"),
    new Ingredient("마늘", 1.5, "쪽"),
};
RecipeCard card1 = new RecipeCard("토마토 파스타", 2, ingredient1);

Console.WriteLine("=== 원본 레시피 ===");
card1.PrintRecipe();
Console.WriteLine("=== 4인분으로 변환 ===");
card1.ScaleRecipe(4).PrintRecipe();

using System;

// README.md를 읽고 코드를 작성하세요.
InventoryItem[] items = new InventoryItem[5];

items[0] = new InventoryItem("검", 3.5, 1500);
items[1] = new InventoryItem("방패", 5.0, 1200);
items[2] = new InventoryItem("포션", 0.3, 50);
items[3] = new InventoryItem("활", 1.8, 1300);
items[4] = new InventoryItem("투구", 2.0, 800);

ShowInven(items);
Console.WriteLine();
Calculate(items);

void ShowInven(InventoryItem[] items)
{
    Console.WriteLine("=== 인벤토리 목록 ===");

    foreach (var item in items)
    {
        Console.WriteLine($"{item.Name} - 무게: {item.Weight}kg, 가격: {item.Price}골드");
    }
}
void Calculate(InventoryItem[] items)
{
    double totalWeight = 0;
    int totalPrice = 0;
    int ExpensiveItem = int.MinValue;
    string ExpensiveItem_name = string.Empty;
    double lightestItem = double.MaxValue;
    string lightestItem_name = string.Empty;

    foreach (var item in items)
    {
        totalWeight += item.Weight;
        totalPrice += item.Price;
    }

    for (int i = 0; i < items.Length; i++)
    {
        if (items[i].Price > ExpensiveItem)
        {
            ExpensiveItem = items[i].Price;
            ExpensiveItem_name = items[i].Name;
        }

        if (items[i].Weight < lightestItem)
        {
            lightestItem = items[i].Weight;
            lightestItem_name = items[i].Name;
        }
    }
    double average = (double)totalPrice / items.Length;

    Console.WriteLine("=== 인벤토리 통계 ===");
    Console.WriteLine($"전체 무게: {totalWeight:F1}kg");
    Console.WriteLine($"전체 가격: {totalPrice}골드");
    Console.WriteLine($"평균 가격: {average:F0}골드");
    Console.WriteLine($"가장 비싼 아이템: {ExpensiveItem_name}");
    Console.WriteLine($"가장 가벼운 아이템: {lightestItem_name}");
}




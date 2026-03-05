using System;

// README.md를 읽고 코드를 작성하세요.
ColorRGB r = new ColorRGB(255, 0, 0, "빨강");
ColorRGB w = new ColorRGB(255, 255, 255, "흰색");
ColorRGB custom = new ColorRGB(100, 150, 200, "커스텀");

Console.WriteLine("=== RGB 색상 밝기 계산 ===\n");
ShowBright(r);
ShowBright(w);
ShowBright(custom);

void ShowBright(ColorRGB rGB)
{
    Console.WriteLine($"{rGB.Name} -  R: {rGB.R}, G: {rGB.G}, B: {rGB.B} → 밝기: {rGB.GetBrightness()}");
}



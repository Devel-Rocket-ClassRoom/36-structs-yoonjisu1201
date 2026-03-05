using System;
using System.Collections.Generic;
using System.Text;

struct ColorRGB
{
    public int R;
    public int G;
    public int B;
    public string Name;

    public ColorRGB(int r, int g, int b, string name)
    {
        this.R = r; this.G = g; this.B = b; this.Name = name;
    }

    public int GetBrightness()
    {
        return (R + G + B) / 3;
    }
}
﻿namespace DoomSharp.Core.Graphics;

public class Sky
{
    public const string FlatName = "F_SKY1";

    public int FlatNum { get; set; }
    public int Texture { get; set; }
    public int TextureMid { get; set; }

    public void InitSkyMap()
    {
        TextureMid = 100 * Constants.FracUnit;
    }
}
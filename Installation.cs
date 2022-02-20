using System;
using System.IO;
using System.IO.Compression;

public class Installation
{
    public Installation()
    {
        Directory.CreateDirectory("C:/Visix");
        Directory.CreateDirectory("C:/Visix/Embeds");
        ZipFile.ExtractToDirectory(@"Embeds.zip", @"C:/Visix/Embeds");
        ZipFile.ExtractToDirectory(@"Core.zip", @"C:/Visix/");
    }
}

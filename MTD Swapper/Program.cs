﻿using System;
using System.IO;
using SoulsFormats;
namespace MTD_Swapper
{
    class Program
    {
        public static readonly string ExeDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        static void Main(string[] args)
        {

            var redOrHuman = YesNo("Hit 1 to make red phantoms appear as human, press 0 to revert");
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd";
            Console.Write("\n");

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                Console.ReadLine();
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = redOrHuman ? new float[] { 0f ,0f,0f, 0f} : new float[] { 1f, .2f, .2f, .4f };
            mtd.Params[1].Value = redOrHuman ? new float[] { 0f ,0f,0f, 0f} : new float[] { -1f, -1f, -1f, .4f };
            mtd.Params[7].Value = redOrHuman ? new float[] { 0f ,0f,0f} : new float[] { 1f, .2f, .2f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);

            Console.WriteLine("Patching Complete. Please restart your game!");
        }

        static bool YesNo(string message)
        {
            Console.WriteLine(message);
            var result = Console.ReadKey();
            if (result.Key == ConsoleKey.D1)
                return true;
            else if (result.Key == ConsoleKey.D0)
                return false;
            else
                return YesNo(message);
        }
    }
}

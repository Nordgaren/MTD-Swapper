using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using SoulsFormats;
namespace MTD_Swapper
{
    public class MTDPatcher
    {
        public static readonly string ExeDir = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

        static void Main(string[] args)
        {
            var redOrHuman = YesNo("Hit 1 to make red phantoms appear as human, press 0 to revert");
            Console.Write("\n");

            PatchHumanBlues();

            if (redOrHuman)
            {
                PatchHumanReds();
            }
            else
            {
                PatchVanillaReds();
            }

            Console.WriteLine("Patching Complete. Please restart your game!");
            Console.ReadLine();
        }

        public static void PatchHumanReds()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[1].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[7].Value = new float[] { 0f, 0f, 0f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchHumanBlues()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[1].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[7].Value = new float[] { 0f, 0f, 0f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchOutlineReds()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[1].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[7].Value = new float[] { 0f, 0f, 0f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchOutlineBlues()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[1].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[7].Value = new float[] { 0f, 0f, 0f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchVanillaReds()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 1f, .2f, .2f, .4f };
            mtd.Params[1].Value = new float[] { -1f, -1f, -1f, .4f };
            mtd.Params[7].Value = new float[] { 1f, .2f, .2f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchVanillaBlues()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 1f, .2f, .2f, .4f };
            mtd.Params[1].Value = new float[] { -1f, -1f, -1f, .4f };
            mtd.Params[7].Value = new float[] { 1f, .2f, .2f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchVanillaGolds()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 1f, .2f, .2f, .4f };
            mtd.Params[1].Value = new float[] { -1f, -1f, -1f, .4f };
            mtd.Params[7].Value = new float[] { 1f, .2f, .2f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
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

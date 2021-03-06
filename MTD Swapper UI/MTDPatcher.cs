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

        private static bool DSR = File.Exists($@"{ExeDir}\DarkSoulsRemastered.exe");

        private static string DCX = DSR ? ".dcx" : "";

        public static void PatchHumanReds()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd{DCX}";

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

        public static void PatchHumanGolds()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd{DCX}";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Umbasa_a.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[1].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[7].Value = new float[] { 0f, 0f, 0f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Umbasa_a.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchHumanBlues()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd{DCX}";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_White.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[1].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[7].Value = new float[] { 0f, 0f, 0f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_White.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchOutlineReds()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd{DCX}";

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

            mtd.Params[0].Value = new float[] { 0.45f, 0.03f, 0.03f, 0.8f};
            mtd.Params[1].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[7].Value = new float[] { 0f, 0f, 0f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Black.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchOutlineGolds()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd{DCX}";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Umbasa_a.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 1f, 0.61f, 0.016f, 0.6f };
            mtd.Params[1].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[7].Value = new float[] { 0f, 0f, 0f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Umbasa_a.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchOutlineBlues()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd{DCX}";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_White.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 0.24f, 0.43f, 1f, 0.8f };
            mtd.Params[1].Value = new float[] { 0f, 0f, 0f, 0f };
            mtd.Params[7].Value = new float[] { 0f, 0f, 0f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_White.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchVanillaReds()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd{DCX}";

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
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd{DCX}";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_White.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 0.24f, 0.43f, 1f, 1f };
            mtd.Params[1].Value = new float[] { -0.5f, -0.2f, -0.1f, 0.2f };
            mtd.Params[7].Value = new float[] { 0.24f, 0.43f, 1f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_White.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }

        public static void PatchVanillaGolds()
        {
            var mtdFile = $@"{ExeDir}\mtd\Mtd.mtdbnd{DCX}";

            if (!File.Exists(mtdFile))
            {
                Console.WriteLine("Cannot find MTD file. Please run this in your Dark Souls Directory.");
                return;
            }

            var mtdBND = BND3.Read(mtdFile);
            MTD mtd = new MTD();

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Umbasa_a.mtd")
                    mtd = MTD.Read(file.Bytes);
            }

            mtd.Params[0].Value = new float[] { 1f, 0.61f, 0.016f, 0.6f };
            mtd.Params[1].Value = new float[] { 1f, 0.06f, -1f, 0.16f };
            mtd.Params[7].Value = new float[] { 1f, 1f, 1f };

            foreach (var file in mtdBND.Files)
            {
                if (file.Name == "Ps_Ghost_Param_Umbasa_a.mtd")
                    file.Bytes = mtd.Write();
            }

            mtdBND.Write(mtdFile);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyGenyuanImsactUpdate
{
    /// <summary>
    /// Methods in console interface.
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// 7z.exe and hdiff.exe check.
        /// </summary>
        public static void CheckForTools(bool requirediff = false)
        {
            bool ok = true;
            if (!File.Exists($"{exePath}\\7z.exe"))
            {
                Console.WriteLine("7z.exe was missing. " +
                    "Please copy it to the path of this program " +
                    "or download the newest release in " +
                    "https://github.com/YYHEggEgg/HappyGenyuanImsactUpdate/releases");
                ok = false;
            }
            if (!File.Exists($"{exePath}\\hpatchz.exe"))
            {
                Console.WriteLine("hpatchz.exe was missing. " +
                    "Please copy it to the path of this program " +
                    "or download the newest release in " +
                    "https://github.com/YYHEggEgg/HappyGenyuanImsactUpdate/releases");
                ok = false;
            }
            if (requirediff)
            {
                if (!File.Exists($"{exePath}\\hdiffz.exe"))
                {
                    Console.WriteLine("hpatchz.exe was missing. " +
                        "Please copy it to the path of this program " +
                        "or download the newest release in " +
                        "https://github.com/YYHEggEgg/HappyGenyuanImsactUpdate/releases");
                    ok = false;
                }
            }
            if (!ok)
            {
                Console.WriteLine("The program will exit after an enter. " +
                    "Please get missing file(s) the right location and restart.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Program executable path.
        /// </summary>
        public static string exePath { get => AppDomain.CurrentDomain.BaseDirectory; }

        //"ei hei"
        public const string certaingame1 = "\u0067\u0065\u006e\u0073\u0068\u0069\u006e\u0069\u006d\u0070\u0061\u0063\u0074";
        public const string certaingame2 = "\u0079\u0075\u0061\u006e\u0073\u0068\u0065\u006e";
    }
}
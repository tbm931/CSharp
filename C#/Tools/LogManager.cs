using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{

    public static class LogManager
    {

        private const string pathLog = "Log";

        public static String CurrentFilePath()
        {
            return $@"{pathLog}\{DateTime.Now.Month}\{DateTime.Now.Day}";
        }

        public static String CurrentFolderPath()
        {
            return $@"{pathLog}\{DateTime.Now.Month}";
        }

        private static void WriteToLog(String projName,String fileName, String msg) 
        {
            if (!Directory.Exists(CurrentFolderPath()))
                Directory.CreateDirectory(CurrentFolderPath());
            if (!File.Exists(CurrentFilePath()))
                File.Create(CurrentFilePath()).Close();
            using StreamWriter writeText = new(CurrentFilePath(), true);
            //if (!Directory.Exists(currentFolderPath())) 
            //    Directory.CreateDirectory(currentFolderPath());
            //if (!File.Exists(currentFilePath()))
            //    File.Create(currentFilePath()).Close();

            writeText.WriteLine($"{DateTime.Now}:\tin project {projName}:\tin function {fileName}\t:{msg}\n");
        }

        public static void DeleteOldDirs()
        {
            Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "deleteOldDirs", "delete Old Log Directories  Start--");
            for (int i = DateTime.Now.Month - 2; Directory.GetDirectories(pathLog).Length>2; i--)
            {
                if (Directory.Exists(@$"{pathLog}\\{i}"))
                    return;
                Directory.Delete(@$"{pathLog}\\{i}",true);
            }
            Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "deleteOldDirs", "delete Old Log Directories  --End");
        }

        public static void WriteToLogStartFunc(String projName,String fileName,String msg)
        {
            WriteToLog(projName,fileName, "\t" + msg);
        }
        public static void WriteToLogEndFunc(String projName, String fileName, String msg)
        {
            //writeTLog(projName, fileName, msg.Substring(2));
            WriteToLog(projName, fileName, msg);
        }
        public static void WriteToLogError(String projName, String fileName, String msg)
        {
            WriteToLog(projName, fileName, "!!!!!\t"+msg+"\t!!!!!");
        }
    }
}

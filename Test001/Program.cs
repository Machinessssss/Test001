using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test001
{
    class LogManager
    {
        public static string LogPath;

        // 静态构造：只执行一次
        static LogManager()
        {
            // 拼接日志路径 = 程序目录 + log.txt
            LogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
            Console.WriteLine("日志文件路径：" + LogPath);
        }

        // 写日志
        public static void WriteLog(string message)
        {
            // 追加写入文件
            File.AppendAllText(LogPath, $"{DateTime.Now}: {message}\n");
        }
    }

    class Program
    {
        static void Main()
        {
            LogManager.WriteLog("程序启动啦！");
            LogManager.WriteLog("用户登录成功！");
            Console.WriteLine("日志已写入！");
            Console.WriteLine("请按任意键退出啊...");
            Console.ReadKey();
        }
    }
}

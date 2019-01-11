using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHelp.Static.Debug("这里写日志 static");
            var log=new LogHelp.Instance();
            log.Debug("这里写日志 Instance");

            Console.WriteLine("Hello World!");
        }
    }
}

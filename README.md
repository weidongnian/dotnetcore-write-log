这是一个 dotnetcore 2.1 写日志的 demo

利用log4net库

引用LogHelp项目

在要使用的项目添加配置文件(请看项目test.csproj)

Config/Log4net.config

在代码使用
一，一种是调用静态方法
LogHelp.Static.Debug("这里写日志 static");

二，一种创建log实例
var log=new LogHelp.Instance();
log.Debug("这里写日志 Instance");

进入项目并生成
cd test

dotnet build

dotnet run


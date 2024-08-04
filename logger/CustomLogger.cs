using System;
namespace Radore_OOP.solid.kotu;


public class CustomLogger
{
    public Logger logger;
    public FileLog fileLog;

    public CustomLogger(Logger logger, FileLog fileLog)
    {
        this.logger = logger;
        this.fileLog = fileLog;
    }

    public void LogKaydet(LogType type, string message)
    {
        if (type == LogType.File)
        {
            fileLog.FileKaydet(message);
        }
        else
        {
            logger.LogKaydet(type, message);
        }
    }
}


    

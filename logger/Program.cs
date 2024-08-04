XmlLog xmlLog = new XmlLog();
DbLog dbLog = new DbLog();
JsonLog jsonLog = new JsonLog();
Logger logger = new Logger(dbLog, xmlLog, jsonLog);

FileLog fileLog = new FileLog();
CustomLogger customLogger = new CustomLogger(logger, fileLog);

// Yeni log formatı 
customLogger.LogKaydet(LogType.File, "Dosyaya kaydedilen mesaj");

// Mevcut log formatları
customLogger.LogKaydet(LogType.Db, "db log");
customLogger.LogKaydet(LogType.Xml, "xml log");
customLogger.LogKaydet(LogType.Json, "json log");

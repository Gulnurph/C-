using System;

namespace ConsoleApp2
{
    class FileLogServices : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya  Loglandı");
        }
    }
}

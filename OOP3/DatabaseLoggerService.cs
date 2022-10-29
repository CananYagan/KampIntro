﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanı loglandı.");
        }
    }

    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanı loglandı.");
        }
    }
}
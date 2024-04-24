using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Welcome.Model;


namespace WelcomeExtended.Loggers
{
    public class LoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            // For illustrative purposes, creating a new instance of HashLogger for each category
            return new HashLogger(categoryName);
        }

        public void Dispose()
        {
            // Dispose logic, if needed
        }
    }
}


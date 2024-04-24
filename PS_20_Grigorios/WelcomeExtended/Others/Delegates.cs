using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WelcomeExtended.Helpers;
using Welcome.Model;


namespace WelcomeExtended.Others
{
    public class Delegates
    {
        // Step 2: Add a field
        public static readonly ILogger logger = LoggerHelper.GetLogger("Hello");

        // Step 3: Add two static methods
        public static void Log(string error)
        {
            logger.LogError(error);
        }

        public static void Log2(string error)
        {
            Console.WriteLine("-DELEGATES-");
            Console.WriteLine($"{error}");
            Console.WriteLine("-DELEGATES-");
        }

        // Step 4: Create a delegate ActionOnError
        public delegate void ActionOnError(string errorMessage);
    }
}


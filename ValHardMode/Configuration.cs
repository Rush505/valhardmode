using System;

namespace ValHardMode
{
    public class Configuration
    {
        public static Configuration Current { get; set; }

        public bool IsEnabled { get; set; }
    }
}

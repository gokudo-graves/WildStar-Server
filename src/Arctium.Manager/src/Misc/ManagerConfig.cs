﻿// Copyright (c) Arctium.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Arctium.Core.Configuration;
using Arctium.Core.Logging;

namespace Arctium.Manager.Misc
{
    public class ManagerConfig : ConfigBase<ManagerConfig>
    {
        [ConfigEntry("Log.Level", LogTypes.All)]
        public static LogTypes LogLevel { get; }

        [ConfigEntry("Log.Directory", "logs/manager")]
        public static string LogDirectory { get; }

        [ConfigEntry("Log.Console.File", "")]
        public static string LogConsoleFile { get; }

        [ConfigEntry("Service.Console.Name", "")]
        public static string ServiceConsoleName { get; }
    }
}

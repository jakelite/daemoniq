﻿/*
 *  Copyright 2009 Kriztian Jake Sta. Teresa
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
using Common.Logging;
using Daemoniq.Framework;

namespace Daemoniq.Core.Commands
{
    class CommandFactory
    {
        private static ILog log = LogManager.GetCurrentClassLogger();

        public static ICommand CreateInstance(ConfigurationAction action)
        {
            log.Debug(m => m("Creating command instance for action '{0}'...", action));
            var command = default(ICommand);
            switch (action)
            {
                case ConfigurationAction.Console:
                    command = new ConsoleCommand();
                    break;
                case ConfigurationAction.Install:
                    command = new InstallCommand();
                    break;
                case ConfigurationAction.Uninstall:
                    command = new UninstallCommand();
                    break;
                case ConfigurationAction.Run:
                    command = new RunCommand();
                    break;
            }
            log.Debug(m => m("Done creating command instance for action '{0}'.", action));
            return command;
        }
    }
}
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
using System.Collections.Generic;

namespace Daemoniq.Framework
{
    public class Configuration:IConfiguration
    {
        private readonly List<ServiceInfo> services = new List<ServiceInfo>();

        #region IConfiguration Members

        public List<ServiceInfo> Services
        {
            get { return services; }
        }

        #endregion
    }
}
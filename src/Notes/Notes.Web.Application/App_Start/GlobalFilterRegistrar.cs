// Copyright (C) 2013 Werner Strydom <Werner Strydom>
// 
// This file is part of Notes.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//  http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Blueprints.Notes.Web.Application
{
    using System;
    using System.Web.Mvc;

    /// <summary>
    ///     Represents a registrar global filter
    /// </summary>
    public static class GlobalFilterRegistrar
    {
        /// <summary>
        ///     Register global filters
        /// </summary>
        /// <param name="filters">
        ///     An instance of <see cref="GlobalFilterCollection" /> where filters will be registered
        /// </param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            if (filters == null)
            {
                throw new ArgumentNullException("filters");
            }
            filters.Add(new HandleErrorAttribute());
        }
    }
}
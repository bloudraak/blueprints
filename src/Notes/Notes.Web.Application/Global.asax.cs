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
    using System.Diagnostics.CodeAnalysis;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    ///     Represents the notes application
    /// </summary>
    public class NotesApplication : HttpApplication
    {
        /// <summary>
        ///     Defines what happens at application start
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            GlobalFilterRegistrar.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteRegistrar.RegisterRoutes(RouteTable.Routes);
        }
    }
}
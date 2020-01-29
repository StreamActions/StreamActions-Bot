﻿/*
 * Copyright © 2019-2020 StreamActions Team
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Security.Principal;

namespace StreamActions.HttpServer
{
    internal class HttpServerBasicIdentity : GenericIdentity
    {
        #region Internal Constructors

        internal HttpServerBasicIdentity(string username, string password) : base(username, "Basic") => this.Password = password;

        #endregion Internal Constructors

        #region Internal Properties

        internal string Password { get; }

        #endregion Internal Properties
    }
}
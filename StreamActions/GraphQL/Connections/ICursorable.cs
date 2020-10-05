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

namespace StreamActions.GraphQL.Connections
{
    /// <summary>
    /// An interface for cursorable types that can be used as edges in a cursor connection.
    /// </summary>
    public interface ICursorable
    {
        #region Public Methods

        /// <summary>
        /// Returns a valid cursor type as a string, such as an Id. Base64 is recommended, but not required.
        /// </summary>
        /// <returns>A string that can be used as a cursor.</returns>
        public string GetCursor();

        #endregion Public Methods
    }
}
/*
 * Naiad ver. 0.5
 * Copyright (c) Microsoft Corporation
 * All rights reserved. 
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0 
 *
 * THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES OR
 * CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT
 * LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR
 * A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT.
 *
 * See the Apache Version 2.0 License for specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Research.Naiad.Runtime.Progress
{
    /// <summary>
    /// An update to a pointstamp count
    /// </summary>
    public struct Update
    {
        /// <summary>
        /// The pointstamp
        /// </summary>
        public Pointstamp Pointstamp;

        /// <summary>
        /// The change in the count of the pointstamp
        /// </summary>
        public Int64 Delta;

        internal Update(Pointstamp p, Int64 d) { this.Pointstamp = p; this.Delta = d; }
    }
}

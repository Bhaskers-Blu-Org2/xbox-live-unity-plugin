// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.Multiplayer
{
    public class WriteSessionResult
    {

        public WriteSessionStatus Status
        {
            get;
            private set;
        }

        public MultiplayerSession Session
        {
            get;
            private set;
        }

        public bool Succeeded
        {
            get;
            private set;
        }

    }
}

﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.DotNet.Internal.ProjectModel
{
    internal static class Constants
    {
        public static readonly string DefaultOutputDirectory = "bin";
        public static readonly string DefaultConfiguration = "Debug";

        public static readonly string LocaleLockFilePropertyName = "locale";

        public static readonly Version Version50 = new Version(5, 0);
    }
}
